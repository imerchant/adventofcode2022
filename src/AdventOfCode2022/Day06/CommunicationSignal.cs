namespace AdventOfCode2022.Day06;

public class CommunicationSignal
{
    public string Signal { get; }
    public int MarkerDetected { get; } = -1;

    public CommunicationSignal(string input)
    {
        Signal = input;

        for (var k = 0; k < Signal.Length - 4; ++k)
        {
            var substring = Signal[k..(k + 4)];
            if (substring.Distinct().Count() == 4)
            {
                MarkerDetected = k + 4;
                break;
            }
        }
    }
}