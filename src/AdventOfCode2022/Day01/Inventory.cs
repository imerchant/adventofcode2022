using System.Collections;

namespace AdventOfCode2022.Day01;

public class Inventory : IEnumerable<Elf>
{
    private static readonly Regex BoardRegex = new Regex(@$"(?'content'[\d{Environment.NewLine}]+?)(?:{Environment.NewLine}{Environment.NewLine}|$)", RegexOptions.Compiled);
    private readonly List<Elf> _elves;

    public Inventory(string input)
    {
        _elves = BoardRegex.Matches(input).Select(x => new Elf(x.Groups["content"].Value)).ToList();
    }

    public IEnumerator<Elf> GetEnumerator() => _elves.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public class Elf
{
    public int Calories { get; }

    public Elf(string input)
    {
        Calories = input.SplitLines().Select(int.Parse).Sum();
    }
}