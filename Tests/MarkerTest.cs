using AOC2022Day6;
using NFluent;
using Xunit;

namespace AOC2022TestProject
{
    public class MarkerTest
    {
        [Theory]
        [InlineData("mjqjpqmgbljsphdztnvjfqwrcgsmlb", 4, 7)]
        [InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz", 4, 5)]
        [InlineData("nppdvjthqldpwncqszvftbrmjlhg", 4, 6)]
        [InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 4, 10)]
        [InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 4, 11)]
        public void GetFirstMarkerTest(string buffer, int length, int expectedResult)
        {
            var marker = new Marker();
            var result = marker.GetFirstMarkerIndex(buffer, length);
            Check.That(result).IsEqualTo(expectedResult);
        }
    }
}
