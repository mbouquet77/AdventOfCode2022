using AOC2022Day2;
using NFluent;
using Xunit;

namespace AOC2022TestProject
{
    public class RockPaperScissorTest
    {
        private readonly RockPaperScissor _rockPaperScissor = new RockPaperScissor();
        private readonly string[] _lines = new string[]
        {
            "A Y",
            "B X",
            "C Z"
        };

        [Fact]
        public void GetShapesTest()
        {
            ShapeEnum opponentShape;
            ShapeEnum myShape;
            _rockPaperScissor.GetShapes(_lines[0], out opponentShape, out myShape);
            Check.That(opponentShape).IsEqualTo(ShapeEnum.Rock);
            Check.That(myShape).IsEqualTo(ShapeEnum.Paper);

            _rockPaperScissor.GetShapes(_lines[1], out opponentShape, out myShape);
            Check.That(opponentShape).IsEqualTo(ShapeEnum.Paper);
            Check.That(myShape).IsEqualTo(ShapeEnum.Rock);

            _rockPaperScissor.GetShapes(_lines[2], out opponentShape, out myShape);
            Check.That(opponentShape).IsEqualTo(ShapeEnum.Scissors);
            Check.That(myShape).IsEqualTo(ShapeEnum.Scissors);
        }

        [Fact]
        public void GetMyScoreTest()
        {
            var myScore = _rockPaperScissor.GetMyScore(_lines[0]);
            Check.That(myScore).IsEqualTo(2);
            myScore = _rockPaperScissor.GetMyScore(_lines[1]);
            Check.That(myScore).IsEqualTo(1);
            myScore = _rockPaperScissor.GetMyScore(_lines[2]);
            Check.That(myScore).IsEqualTo(3);
        }

        [Fact]
        public void GetHandResultTest()
        {
            var handResult = _rockPaperScissor.GetHandResult(_lines[0]);
            Check.That(handResult).IsEqualTo(HandResult.Win);
            handResult = _rockPaperScissor.GetHandResult(_lines[1]);
            Check.That(handResult).IsEqualTo(HandResult.Lose);
            handResult = _rockPaperScissor.GetHandResult(_lines[2]);
            Check.That(handResult).IsEqualTo(HandResult.Equality);
        }

        [Fact]
        public void GetOutcomeScoreTest()
        {
            var outcomeScore = _rockPaperScissor.GetOutcomeScore(_lines[0]);
            Check.That(outcomeScore).IsEqualTo(6);
            outcomeScore = _rockPaperScissor.GetOutcomeScore(_lines[1]);
            Check.That(outcomeScore).IsEqualTo(0);
            outcomeScore = _rockPaperScissor.GetOutcomeScore(_lines[2]);
            Check.That(outcomeScore).IsEqualTo(3);
        }

        [Fact]
        public void GetTotalLineScoreTest()
        {
            var totalLineScore = _rockPaperScissor.GetTotalLineScore(_lines[0]);
            Check.That(totalLineScore).IsEqualTo(8);
            totalLineScore = _rockPaperScissor.GetTotalLineScore(_lines[1]);
            Check.That(totalLineScore).IsEqualTo(1);
            totalLineScore = _rockPaperScissor.GetTotalLineScore(_lines[2]);
            Check.That(totalLineScore).IsEqualTo(6);
        }

        [Fact]
        public void GetTotalScoreTest()
        {
            var result = _rockPaperScissor.GetTotalScore(_lines);
            Check.That(result).IsEqualTo(15);
        }
    }
}
