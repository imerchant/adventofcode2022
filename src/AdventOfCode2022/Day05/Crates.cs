namespace AdventOfCode2022.Day05;

public class Crates
{
    private static readonly Regex MovePattern = new(@"move (?'count'\d+) from (?'source'\d+) to (?'target'\d+)", RegexOptions.Compiled);

    public List<Stack<char>> Stacks { get; }
    public List<string> Moves { get; }
    public string Message => Stacks.Select(x => x.TryPeek(out var result) ? result : ' ').AsString();

    public Crates(string stackStarts, string movesInput)
    {
        Stacks = stackStarts.SplitLines().Select(x => new Stack<char>(x)).ToList();
        Moves = movesInput.SplitLines().ToList();
    }

    public void Run(Action<int, int, int> operation)
    {
        foreach (var move in Moves)
        {
            var match = MovePattern.Match(move);
            var (count, source, target) = (int.Parse(match.Groups["count"].Value), int.Parse(match.Groups["source"].Value), int.Parse(match.Groups["target"].Value));
            operation(count, source, target);
        }
    }

    public void Move9000(int count, int source, int target)
    {
        var sourceStack = Stacks[source - 1];
        var targetStack = Stacks[target - 1];
        for (var k = 0; k < count; k++)
        {
            if (sourceStack.TryPop(out var c))
            {
                targetStack.Push(c);
            }
        }
    }

    public void Move9001(int count, int source, int target)
    {
        var sourceStack = Stacks[source - 1];
        var targetStack = Stacks[target - 1];
        var tempStack = new Stack<char>();

        for (var k = 0; k < count; k++)
        {
            if (sourceStack.TryPop(out var c))
            {
                tempStack.Push(c);
            }
        }

        while (tempStack.Count > 0)
        {
            targetStack.Push(tempStack.Pop());
        }
    }
}