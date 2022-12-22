using AdventOfCode2022.Day06;

namespace AdventOfCode2022.Tests;

public class Day06Solutions
{
    [Fact]
    public void Puzzle1And2_FindMarkerLocations()
    {
        var signal = new CommunicationSignal(Input.Day06);

        signal.PacketMarkerDetected.Should().Be(1876);
        signal.MessageMarkerDetected.Should().Be(2202);
    }

    [Theory]
    [InlineData("mjqjpqmgbljsphdztnvjfqwrcgsmlb", 7, 19)]
    [InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz", 5, 23)]
    [InlineData("nppdvjthqldpwncqszvftbrmjlhg", 6, 23)]
    [InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 10, 29)]
    [InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 11, 26)]
    public void Examples_FindPacketMarkerLocation(string input, int expectedPacketMarkerDetected, int expectedMessageMarkerDetected)
    {
        var signal = new CommunicationSignal(input);

        signal.PacketMarkerDetected.Should().Be(expectedPacketMarkerDetected);
        signal.MessageMarkerDetected.Should().Be(expectedMessageMarkerDetected);
    }
}