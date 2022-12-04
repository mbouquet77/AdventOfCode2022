using AOC2022Day1;
using AOC2022Day2;
using AOC2022Day3;
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

        [Fact]
        public void RockPaperScissorTests()
        {
            var lines = new string[]
            {
                "A Y",
                "B X",
                "C Z"
            };
            var rockPaperScissor = new RockPaperScissor();
            var result = rockPaperScissor.CountScore(lines);
            Check.That(result).IsEqualTo(15);
            var line = lines[0];
            var myScore = rockPaperScissor.GetMyScore(line);
            Check.That(myScore).IsEqualTo(2);
            var outcomeScore = rockPaperScissor.GetOutcomeScore(line);
            Check.That(outcomeScore).IsEqualTo(6);
            line = lines[1];
            myScore = rockPaperScissor.GetMyScore(line);
            Check.That(myScore).IsEqualTo(1);
            outcomeScore = rockPaperScissor.GetOutcomeScore(line);
            Check.That(outcomeScore).IsEqualTo(0);
            line = lines[2];
            myScore = rockPaperScissor.GetMyScore(line);
            Check.That(myScore).IsEqualTo(3);
            outcomeScore = rockPaperScissor.GetOutcomeScore(line);
            Check.That(outcomeScore).IsEqualTo(3);
        }

        [Fact]
        public void ItemsInRucksakPart1Tests()
        {
            var lines = new string[]
            {
                "vJrwpWtwJgWrhcsFMMfFFhFp",
                "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL",
                "PmmdzqPrVvPwwTWBwg",
                "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn",
                "ttgJtRGJQctTZtZT",
                "CrZsJsPPZsGzwwsLwLmpwMDw"
            };
            var itemsInRucksac = new ItemsInRucksack();
            var commonItemType = itemsInRucksac.GetCommonItemType(lines[0]);
            Check.That(commonItemType).IsEqualTo('p');
            var value = itemsInRucksac.CharValue(commonItemType.Value);
            Check.That(value).IsEqualTo(16);
            commonItemType = itemsInRucksac.GetCommonItemType(lines[1]);
            Check.That(commonItemType).IsEqualTo('L');
            value = itemsInRucksac.CharValue(commonItemType.Value);
            Check.That(value).IsEqualTo(38);
            commonItemType = itemsInRucksac.GetCommonItemType(lines[2]);
            Check.That(commonItemType).IsEqualTo('P');
            value = itemsInRucksac.CharValue(commonItemType.Value);
            Check.That(value).IsEqualTo(42);
            commonItemType = itemsInRucksac.GetCommonItemType(lines[3]);
            Check.That(commonItemType).IsEqualTo('v');
            value = itemsInRucksac.CharValue(commonItemType.Value);
            Check.That(value).IsEqualTo(22);
            commonItemType = itemsInRucksac.GetCommonItemType(lines[4]);
            Check.That(commonItemType).IsEqualTo('t');
            value = itemsInRucksac.CharValue(commonItemType.Value);
            Check.That(value).IsEqualTo(20);
            commonItemType = itemsInRucksac.GetCommonItemType(lines[5]);
            Check.That(commonItemType).IsEqualTo('s');
            value = itemsInRucksac.CharValue(commonItemType.Value);
            Check.That(value).IsEqualTo(19);
            Check.That(itemsInRucksac.GetCommonItemsSum(lines)).IsEqualTo(157);
        }

        [Fact]
        public void ItemsInRucksakPart2Tests()
        {
            var itemsInRuckstack = new ItemsInRucksack();
            var lines1 = new string[]
            {
                "vJrwpWtwJgWrhcsFMMfFFhFp",
                "jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL",
                "PmmdzqPrVvPwwTWBwg"
            };
            var commonItem = itemsInRuckstack.GetThreeElvesCommonItem(lines1);
            Check.That(commonItem).IsEqualTo('r');
            var value = itemsInRuckstack.CharValue(commonItem.Value);
            Check.That(value).IsEqualTo(18);

            var lines2 = new string[]
            {
                "wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn",
                "ttgJtRGJQctTZtZT",
                "CrZsJsPPZsGzwwsLwLmpwMDw"
            };
            commonItem = itemsInRuckstack.GetThreeElvesCommonItem(lines2);
            Check.That(commonItem).IsEqualTo('Z');
            value = itemsInRuckstack.CharValue(commonItem.Value);
            Check.That(value).IsEqualTo(52);

            var lines = new List<string>();
            lines.AddRange(lines1);
            lines.AddRange(lines2);
            var sum = itemsInRuckstack.GetThreeElvesCommonItemSum(lines.ToArray());
            Check.That(sum).IsEqualTo(70);

        }
    }
}