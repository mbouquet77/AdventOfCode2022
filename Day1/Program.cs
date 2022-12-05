using AOC2022;
using AOC2022Day1;

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
        var countCalories = new CountCalories();
        var maxCalories = countCalories.GetMaxCalories(lines);
        Console.WriteLine(maxCalories.ToString());
    }
    private static void Part2(string[] lines)
    {
        var countCalories = new CountCalories();
        var topThreeCaloriesSum = countCalories.TopThreeCaloriesSum(lines);
        Console.WriteLine(topThreeCaloriesSum.ToString());
    }
}
