using AOC2022;
using AOC2022Day3;

class Program
{
    static void Main()
    {
        var aocFiles = new AocFiles();
        var lines = aocFiles.GetArrayFromFile();
        Part1(lines);
        Console.WriteLine("");
        Part2(lines);
    }

    private static void Part1(string[] lines)
    {
        var itemsInRuckstack = new ItemsInRucksack();
        var commonItemsSum = itemsInRuckstack.GetCommonItemsSum(lines);
        Console.WriteLine(commonItemsSum);
    }

    private static void Part2(string[] lines)
    {
        var itemsInRuckStack = new ItemsInRucksack();
        var threeElvesCommonItems = itemsInRuckStack.GetThreeElvesCommonItemSum(lines);
        Console.WriteLine(threeElvesCommonItems);
    }
}
