namespace AdventOfCode2022.Day06;

public class CommunicationSignal
{
    public int PacketMarkerDetected { get; }
    public int MessageMarkerDetected { get; }

    public CommunicationSignal(string input)
    {
        PacketMarkerDetected = FindMarker(4);
        MessageMarkerDetected = FindMarker(14);

        int FindMarker(int distinctCount)
        {
            for (var k = 0; k < input.Length - distinctCount; ++k)
            {
                var substring = input[k..(k + distinctCount)];
                if (substring.Distinct().Count() == distinctCount)
                {
                    return k + distinctCount;
                }
            }

            return -1;
        }
    }
}