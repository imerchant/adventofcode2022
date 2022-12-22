using System.Diagnostics;

namespace AdventOfCode2022.Day07;

public class Files
{
    private static readonly Regex DirectoryPattern = new(@"dir (?'name'.+)", RegexOptions.Compiled);
    private static readonly Regex FilePattern = new(@"(?'size'\d+) (?'name'.+)", RegexOptions.Compiled);

    private readonly DirectoryNode _head;

    public List<DirectoryNode> Directories { get; }

    public Files(string input)
    {
        Directories = new List<DirectoryNode>();
        DirectoryNode current;
        _head = current = new DirectoryNode(null, "/");

        foreach (var command in input.SplitLines())
        {
            if (command.StartsWith("$ cd"))
            {
                if (command.Contains('/'))
                {
                    current = _head;
                }
                else if (command.Contains("..") && current.Parent is not null)
                {
                    current = current.Parent;
                }
                else
                {
                    var split = command.SplitOn(' ');
                    current = current.Children.OfType<DirectoryNode>().First(x => x.Name == split[2]);
                }
            }
            else if (command == "$ ls")
            {
                continue;
            }
            else
            {
                if (DirectoryPattern.TryMatch(command, out var directoryMatch))
                {
                    var name = directoryMatch.Groups["name"].Value;
                    if (current.Children.Any(x => x.Name == name))
                    {
                        continue;
                    }

                    var directory = new DirectoryNode(current, name);
                    Directories.Add(directory);
                    current.Children.Add(directory);
                }

                if (FilePattern.TryMatch(command, out var fileMatch))
                {
                    var name = fileMatch.Groups["name"].Value;
                    if (current.Children.Any(x => x.Name == name))
                    {
                        continue;
                    }
                    current.Children.Add(new FileNode(name, int.Parse(fileMatch.Groups["size"].Value)));
                }
            }
        }
    }
}

[DebuggerDisplay("{Name} (dir)")]
public class DirectoryNode : IFileNode
{
    public DirectoryNode? Parent { get; }
    public string Name { get; }
    public int Size => Children.Sum(x => x.Size);
    public List<IFileNode> Children { get; }

    public DirectoryNode(DirectoryNode? parent, string name)
    {
        Parent = parent;
        Name = name;
        Children = new List<IFileNode>();
    }
}

[DebuggerDisplay("{Name} (file, size={Size})")]
public class FileNode : IFileNode
{
    public string Name { get; }
    public int Size { get; }

    public FileNode(string name, int size)
    {
        Name = name;
        Size = size;
    }
}

public interface IFileNode
{
    string Name { get; }
    int Size { get; }
}