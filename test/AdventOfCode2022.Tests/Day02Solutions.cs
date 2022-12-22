using AdventOfCode2022.Day02;

namespace AdventOfCode2022.Tests;

public class Day02Solutions
{
    [Fact]
    public void Puzzle1And2_FindTotalScores()
    {
        var rps = new RockPaperScissors(Input.Day02);

        rps.Sum(x => x.Score).Should().Be(12772);
        rps.Sum(x => x.Score2).Should().Be(11618);
    }

    public const string Example =
@"A Y
B X
C Z";

    [Fact]
    public void Example_CountsScore()
    {
        var rps = new RockPaperScissors(Example);

        rps.Sum(x => x.Score).Should().Be(15);
        rps.Sum(x => x.Score2).Should().Be(12);
    }
}