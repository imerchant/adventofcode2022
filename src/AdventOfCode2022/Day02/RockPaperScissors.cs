using System.Collections;

namespace AdventOfCode2022.Day02;

public class RockPaperScissors : IEnumerable<Round>
{
    private readonly List<Round> _rounds;

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
    public Outcome Outcome { get; }
    public Play OutcomePlay { get; }

    public int Score { get; }
    public int Score2 { get; }

    public Round(string input)
    {
        var plays = input.SplitOn(' ');
        First = ParsePlay(plays[0]);
        Second = ParsePlay(plays[1]);
        Outcome = ParseOutcome(plays[1]);

        OutcomePlay = PlayForOutcome();
        Score = Second.Against(First);
        Score2 = OutcomePlay.Against(First);

        static Play ParsePlay(string p) =>
            p switch
            {
                "A" or "X" => Play.Rock,
                "B" or "Y" => Play.Paper,
                "C" or "Z" => Play.Scissor,
                _ => throw new Exception()
            };

        static Outcome ParseOutcome(string o) =>
            o switch
            {
                "X" => Outcome.Lose,
                "Y" => Outcome.Draw,
                "Z" => Outcome.Win,
                _ => throw new Exception()
            };
    }

    private Play PlayForOutcome() =>
        Outcome switch
        {
            Outcome.Draw => First,
            Outcome.Win  => First == Play.Scissor ? Play.Rock : First + 1,
            Outcome.Lose => First == Play.Rock ? Play.Scissor : First - 1,
            _ => throw new Exception()
        };
}

public enum Play
{
    Rock = 1,
    Paper = 2,
    Scissor = 3
}

public enum Outcome
{
    Lose,
    Draw,
    Win
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