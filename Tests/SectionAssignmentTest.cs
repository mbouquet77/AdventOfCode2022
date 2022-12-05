using AOC2022Day4;
using NFluent;
using Xunit;

namespace AOC2022TestProject
{
    public class SectionAssignmentTest
    {
        private readonly SectionAssignment _sectionAssignment = new SectionAssignment();
        private readonly string[] _lines = new string[]
            {
                "2-4,6-8",
                "2-3,4-5",
                "5-7,7-9",
                "2-8,3-7",
                "6-6,4-6",
                "2-6,4-8"
            };

        [Fact]
        public void OneAssignmentContainsTheOtherTest()
        {
            var oneAssignmentContainsTheOther = _sectionAssignment.OneAssignmentContainsTheOther(_lines[0]);
            Check.That(oneAssignmentContainsTheOther).IsFalse();
            oneAssignmentContainsTheOther = _sectionAssignment.OneAssignmentContainsTheOther(_lines[1]);
            Check.That(oneAssignmentContainsTheOther).IsFalse();
            oneAssignmentContainsTheOther = _sectionAssignment.OneAssignmentContainsTheOther(_lines[2]);
            Check.That(oneAssignmentContainsTheOther).IsFalse();
            oneAssignmentContainsTheOther = _sectionAssignment.OneAssignmentContainsTheOther(_lines[3]);
            Check.That(oneAssignmentContainsTheOther).IsTrue();
            oneAssignmentContainsTheOther = _sectionAssignment.OneAssignmentContainsTheOther(_lines[4]);
            Check.That(oneAssignmentContainsTheOther).IsTrue();
            oneAssignmentContainsTheOther = _sectionAssignment.OneAssignmentContainsTheOther(_lines[5]);
            Check.That(oneAssignmentContainsTheOther).IsFalse();
            oneAssignmentContainsTheOther = _sectionAssignment.OneAssignmentContainsTheOther("6-35,6-36");
            Check.That(oneAssignmentContainsTheOther).IsTrue();
        }

        [Fact]
        public void GetHowManyAssignmentsContainTheOtherTest()
        {
            var result = _sectionAssignment.GetHowManyAssignmentsContainTheOther(_lines);
            Check.That(result).IsEqualTo(2);
        }

        [Fact]
        public void DoAssignmentPairsOverlapTest()
        {
            var doAssignmentPairsOverlap = _sectionAssignment.DoAssignmentPairsOverlap(_lines[0]);
            Check.That(doAssignmentPairsOverlap).IsFalse();
            doAssignmentPairsOverlap = _sectionAssignment.DoAssignmentPairsOverlap(_lines[1]);
            Check.That(doAssignmentPairsOverlap).IsFalse();
            doAssignmentPairsOverlap = _sectionAssignment.DoAssignmentPairsOverlap(_lines[2]);
            Check.That(doAssignmentPairsOverlap).IsTrue();
            doAssignmentPairsOverlap = _sectionAssignment.DoAssignmentPairsOverlap(_lines[3]);
            Check.That(doAssignmentPairsOverlap).IsTrue();
            doAssignmentPairsOverlap = _sectionAssignment.DoAssignmentPairsOverlap(_lines[4]);
            Check.That(doAssignmentPairsOverlap).IsTrue();
            doAssignmentPairsOverlap = _sectionAssignment.DoAssignmentPairsOverlap(_lines[5]);
            Check.That(doAssignmentPairsOverlap).IsTrue();
        }

        [Fact]
        public void GetHowManyAssignmentPairsOverlapTest()
        {
            var result = _sectionAssignment.GetHowManyAssignmentPairsOverlap(_lines);
            Check.That(result).IsEqualTo(4);
        }
    }
}
