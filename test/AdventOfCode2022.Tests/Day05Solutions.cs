using AdventOfCode2022.Day05;

namespace AdventOfCode2022.Tests;

public class Day05Solutions
{
    [Fact]
    public void Puzzle1_FindMessage9000()
    {
        var crates = new Crates(Input.Day05.Stacks, Input.Day05.Moves);

        crates.Run(crates.Move9000);

        crates.Message.Should().Be("QGTHFZBHV");
    }

    [Fact]
    public void Puzzle2_FindMessage9001()
    {
        var crates = new Crates(Input.Day05.Stacks, Input.Day05.Moves);

        crates.Run(crates.Move9001);

        crates.Message.Should().Be("MGDMPSZTM");
    }

    private const string ExampleStacks =
@"ZN
MCD
P";

    private const string ExampleMoves =
@"move 1 from 2 to 1
move 3 from 1 to 3
move 2 from 2 to 1
move 1 from 1 to 2";

    [Fact]
    public void Example_CreatesStacksProperly9000()
    {
        var crates = new Crates(ExampleStacks, string.Empty);

        crates.Stacks.Should().HaveCount(3);
        crates.Message.Should().Be("NDP");

        crates.Move9000(1, 2, 1);
        crates.Message.Should().Be("DCP");

        crates.Move9000(3, 1, 3);
        crates.Message.Should().Be(" CZ");
    }

    [Fact]
    public void Example_RunsCorrectly9000()
    {
        var crates = new Crates(ExampleStacks, ExampleMoves);

        crates.Run(crates.Move9000);

        crates.Message.Should().Be("CMZ");
    }

    [Fact]
    public void Example_CreatesStacksProperly9001()
    {
        var crates = new Crates(ExampleStacks, string.Empty);

        crates.Stacks.Should().HaveCount(3);
        crates.Message.Should().Be("NDP");

        crates.Move9001(1, 2, 1);
        crates.Message.Should().Be("DCP");

        crates.Move9001(3, 1, 3);
        crates.Message.Should().Be(" CD");

        crates.Move9001(2, 2, 1);
        crates.Message.Should().Be("C D");

        crates.Move9001(1, 1, 2);
        crates.Message.Should().Be("MCD");
    }
}