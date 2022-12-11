using AdventOfCode2022.Day02;

namespace AdventOfCode2022.Tests;

public class Day02Solutions
{
    [Fact]
    public void Puzzle_FindTotalScore()
    {
        var rpc = new RockPaperScissors(Input.Day02);

        rpc.Sum(x => x.Score).Should().Be(12772);
        rpc.Sum(x => x.Score2).Should().Be(11618);
    }

    public const string Example =
@"A Y
B X
C Z";

    [Fact]
    public void Example_CountsScore()
    {
        var rpc = new RockPaperScissors(Example);

        rpc.Sum(x => x.Score).Should().Be(15);
        rpc.Sum(x => x.Score2).Should().Be(12);
    }
}