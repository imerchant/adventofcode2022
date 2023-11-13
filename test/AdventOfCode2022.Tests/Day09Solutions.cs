using AdventOfCode2022.Day09;

namespace AdventOfCode2022.Tests;

public class Day09Solutions
{
    [Fact]
    public void Puzzle1_RopeCountsTailLocations()
    {
        var rope = new Rope(Input.Day09);
        rope.TailLocations.Should().HaveCount(6464);
    }

    private const string Example1 =
@"R 4
U 4
L 3
D 1
R 4
D 1
L 5
R 2";

    [Fact]
    public void Example1_RopeCountsTailLocations()
    {
        var rope = new Rope(Example1);
        rope.TailLocations.Should().HaveCount(13);
    }
}