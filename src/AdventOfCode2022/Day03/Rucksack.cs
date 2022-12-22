using System.Collections;

namespace AdventOfCode2022.Day03;

public class Rucksacks : IEnumerable<Rucksack>
{
    public List<Rucksack> Items { get; }
    public List<Group> Groups { get; }

    public Rucksacks(string input)
    {
        Items = input.SplitLines().Select(x => new Rucksack(x)).ToList();
        Groups = Items.Chunk(3).Select(x => new Group(x)).ToList();
    }

    public IEnumerator<Rucksack> GetEnumerator() => Items.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public class Group
{
    public List<Rucksack> Items { get; }
    public char Badge { get; }
    public int Priority { get; }

    public Group(IEnumerable<Rucksack> rucksacks)
    {
        Items = rucksacks.ToList();
        Badge = Items[0].Input.Intersect(Items[1].Input).Intersect(Items[2].Input).Single();
        Priority = Badge.Priority();
    }
}

public class Rucksack
{
    public string Input { get; }
    public IEnumerable<char> First { get; }
    public IEnumerable<char> Second { get; }
    public char MostCommon { get; }
    public int Priority { get; }

    public Rucksack(string input)
    {
        Input = input;
        int half = input.Length / 2;
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
        char.IsUpper(c)
            ? c - 'A' + 26 + 1
            : c - 'a' + 1;
}