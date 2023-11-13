namespace AdventOfCode2022.Day09;

public class Rope
{
    private readonly List<Step> _steps;

    public HashSet<(int X, int Y)> TailLocations { get; }
    public List<string> History { get; }

    public Rope(string input)
    {
        _steps = input
            .SplitLines()
            .Select(step => step.SplitOn(' '))
            .Select(split => new Step(split[0].ParseEnum<Direction>(), int.Parse(split[1])))
            .ToList();

        (int X, int Y) head = (0, 0);
        (int X, int Y) tail = (0, 0);
        History = new List<string>();
        TailLocations = new HashSet<(int X, int Y)>
        {
            (0, 0)
        };

        foreach (var step in _steps)
        {
            for (var k = 0; k < step.Count; ++k)
            {
                head = head.Move(step.Direction);
                History.Add($"Head to ({head.X}, {head.Y})");

                tail = tail.MoveToward(head, step.Direction);
                History.Add($"Tail to ({tail.X}, {tail.Y})");

                TailLocations.Add(tail);
            }
        }
    }
}

public record Step(Direction Direction, int Count);

public enum Direction
{
    U, D, L, R
}

public static class RopeExtensions
{
    public static (int X, int Y) Move(this (int X, int Y) head, Direction direction) => direction switch
    {
        Direction.U => (head.X, head.Y + 1),
        Direction.D => (head.X, head.Y - 1),
        Direction.L => (head.X - 1, head.Y),
        Direction.R => (head.X + 1, head.Y),
        _ => throw new NotSupportedException(),
    };

    public static (int X, int Y) MoveToward(this (int X, int Y) tail, (int X, int Y) head, Direction headDirection)
    {
        if (head == tail) return tail;
        var distance = tail.DistanceFrom(head);
        if (distance is 0 or 1) return tail;
        if (distance is 2 && head.X != tail.X && head.Y != tail.Y) return tail;
        return head.Move(headDirection.Opposite());
    }

    public static int DistanceFrom(this (int X, int Y) tail, (int X, int Y) head)
    {
        return Math.Abs(head.X - tail.X) + Math.Abs(head.Y - tail.Y);
    }

    public static Direction Opposite(this Direction direction) => direction switch
    {
        Direction.U => Direction.D,
        Direction.D => Direction.U,
        Direction.L => Direction.R,
        Direction.R => Direction.L,
        _ => throw new NotSupportedException(),
    };
}