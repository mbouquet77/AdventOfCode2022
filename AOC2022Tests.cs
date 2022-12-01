using AOC2022Day1;
using NFluent;
using Xunit;

namespace AOC2022TestProject
{
    public class AOC2022Tests
    {
        [Fact]
        public void CountCaloriesTest()
        {
            var expectedDict = new Dictionary<int, int>()
            {
                { 1, 6000 },
                { 2, 4000 },
                { 3, 11000 },
                { 4, 24000 },
                { 5, 10000 },
            };
            var countCalories = new CountCalories();
            var lines = new string[]
            {
                "1000", "2000", "3000", "",
                "4000", "",
                "5000", "6000", "",
                "7000", "8000", "9000", "",
                "10000"
            };
            var dict = countCalories.CreateDictionary(lines);

            Check.That(dict).IsEqualTo(expectedDict);

            var winningElf = countCalories.GetMaxCalories(lines);
            Check.That(winningElf).IsEqualTo(24000);

            var topThreeCaloriesSum = countCalories.TopThreeCaloriesSum(lines);
            Check.That(topThreeCaloriesSum).IsEqualTo(45000);
        }
    }
}