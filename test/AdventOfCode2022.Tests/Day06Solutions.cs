using AdventOfCode2022.Day06;

namespace AdventOfCode2022.Tests;

public class Day06Solutions
{
    [Fact]
    public void Puzzle1_FindMarkerLocation()
    {
        var signal = new CommunicationSignal(Input.Day06);

        signal.MarkerDetected.Should().Be(1876);
    }

    [Theory]
    [InlineData("mjqjpqmgbljsphdztnvjfqwrcgsmlb", 7)]
    [InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz", 5)]
    [InlineData("nppdvjthqldpwncqszvftbrmjlhg", 6)]
    [InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 10)]
    [InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 11)]
    public void Examples_FindMarkerLocation(string input, int expectedMarkerDetected)
    {
        new CommunicationSignal(input).MarkerDetected.Should().Be(expectedMarkerDetected);
    }
}