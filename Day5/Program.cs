using AOC2022;
using AOC2022Day5;

class Program
{
    private static readonly MovingCrates _movingCrates = new MovingCrates();

    static void Main()
    {
        var aocFiles = new AocFiles();
        var lines = aocFiles.GetArrayFromFile();
        var input = new List<string> { };
        var instructions = new List<string> { };
        var getInput = true;
        var getInstructions = false;
        foreach (var line in lines)
        {
            if (string.IsNullOrEmpty(line))
            {
                getInput = false;
                getInstructions = true;
                continue;
            }

            if (getInput)
                input.Add(line);
            if (getInstructions)
                instructions.Add(line);
        };

        Part1(input, instructions);
        Console.WriteLine("");
        Part2(input, instructions);
    }

    private static void Part1(List<string> input, List<string> instructions)
    {
        var message = _movingCrates.GetMessage(input, instructions);
        Console.WriteLine(message);
    }

    private static void Part2(List<string> input, List<string> instructions)
    {
        var message = _movingCrates.GetMessageWhenMovingAllAtOnce(input, instructions);
        Console.WriteLine(message);
    }
}
