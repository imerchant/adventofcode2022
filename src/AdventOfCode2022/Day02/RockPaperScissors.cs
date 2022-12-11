using System.Collections;

namespace AdventOfCode2022.Day02;

public class RockPaperScissors : IEnumerable<Round>
{
    private List<Round> _rounds;

    public RockPaperScissors(string input)
    {
        _rounds = input.SplitLines().Select(x => new Round(x)).ToList();
    }

    public IEnumerator<Round> GetEnumerator() => _rounds.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public class Round
{
    public Play First { get; }
    public Play Second { get; }

    public int Score => Second.Against(First);

    public Round(string input)
    {
        var plays = input.SplitOn(' ');
        First = Parse(plays[0]);
        Second = Parse(plays[1]);

        static Play Parse(string p) =>
            p switch
            {
                "A" or "X" => Play.Rock,
                "B" or "Y" => Play.Paper,
                "C" or "Z" => Play.Scissor,
                _ => throw new Exception()
            };
    }
}

public enum Play
{
    Rock = 1,
    Paper = 2,
    Scissor = 3
}

public static class Plays
{
    public static int Against(this Play first, Play second)
    {
        if (first == second)
        {
            return 3 + (int)first;
        }

        if (first.Beats(second))
        {
            return 6 + (int)first;
        }

        return (int)first;
    }

    public static bool Beats(this Play first, Play second) =>
        second switch
        {
            Play.Rock => first == Play.Paper,
            Play.Paper => first == Play.Scissor,
            Play.Scissor => first == Play.Rock,
            _ => false
        };
}