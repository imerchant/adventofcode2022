using System.Collections;

namespace AdventOfCode2022.Day03;

public class Rucksacks : IEnumerable<Rucksack>
{
    public List<Rucksack> Items { get; }

    public Rucksacks(string input)
    {
        Items = input.SplitLines().Select(x => new Rucksack(x)).ToList();
    }


    public IEnumerator<Rucksack> GetEnumerator() => Items.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public class Rucksack
{
    public IEnumerable<char> First { get; }
    public IEnumerable<char> Second { get; }
    public char MostCommon { get; }
    public int Priority { get; }

    public Rucksack(string input)
    {
        var half = input.Length / 2;
        First = new List<char>(input[..half]);
        Second = new List<char>(input[half..]);
        var intersection = First.Intersect(Second).ToList();
        MostCommon = intersection
            .GroupBy(x => intersection.Count(i => i == x))
            .OrderByDescending(x => x.Key)
            .First()
            .First();
        Priority = MostCommon.Priority();
    }
}

internal static class RucksackExtensions
{
    public static int Priority(this char c) =>
        char.IsUpper(c) switch
        {
            true => c - 'A' + 26 + 1,
            false => c - 'a' + 1
        };
}