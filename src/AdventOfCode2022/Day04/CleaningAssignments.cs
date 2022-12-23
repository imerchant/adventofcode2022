namespace AdventOfCode2022.Day04;

public class CleaningAssignments : IEnumerable<AssignmentPair>
{
    public List<AssignmentPair> Pairs { get; }

    public CleaningAssignments(string input)
    {
        Pairs = input.SplitLines().Select(x => new AssignmentPair(x)).ToList();
    }

    public IEnumerator<AssignmentPair> GetEnumerator() => Pairs.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public class AssignmentPair
{
    private static readonly Regex AssignmentPattern = new(@"(\d+)", RegexOptions.Compiled);

    public Assignment First { get; }
    public Assignment Second { get; }
    public bool OneContainsTheOther { get; }
    public bool IsOverlap { get; }

    public AssignmentPair(string input)
    {
        var matches = AssignmentPattern.Matches(input).ToList();
        First = new Assignment(int.Parse(matches[0].Value), int.Parse(matches[1].Value));
        Second = new Assignment(int.Parse(matches[2].Value), int.Parse(matches[3].Value));
        OneContainsTheOther = First.Contains(Second) || Second.Contains(First);
        IsOverlap = First.Overlaps(Second) || Second.Overlaps(First);
    }
}

public record Assignment(int Low, int High);

internal static class AssignmentExtensions
{
    public static bool Contains(this Assignment left, Assignment right) => right.High <= left.High && right.Low >= left.Low;

    public static bool Overlaps(this Assignment left, Assignment right) =>
        right.High <= left.High && right.High >= left.Low ||
        right.Low <= left.High && right.Low >= left.Low;

}