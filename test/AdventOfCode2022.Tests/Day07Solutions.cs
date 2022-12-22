using AdventOfCode2022.Day07;

namespace AdventOfCode2022.Tests;

public class Day07Solutions
{
    [Fact]
    public void Puzzle1_SumDirectoriesLessThan100k()
    {
        var files = new Files(Input.Day07);

        files.Directories.Where(x => x.Size <= 100_000).Sum(x => x.Size).Should().Be(1391690);
    }

    private const string Example =
@"$ cd /
$ ls
dir a
14848514 b.txt
8504156 c.dat
dir d
$ cd a
$ ls
dir e
29116 f
2557 g
62596 h.lst
$ cd e
$ ls
584 i
$ cd ..
$ cd ..
$ cd d
$ ls
4060174 j
8033020 d.log
5626152 d.ext
7214296 k";

    [Fact]
    public void Example_CreatesFileSystem()
    {
        var files = new Files(Example);

        files.Directories.Where(x => x.Size <= 100_000).Sum(x => x.Size).Should().Be(95437);
    }
}