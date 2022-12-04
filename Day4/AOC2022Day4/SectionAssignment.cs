namespace AOC2022Day4
{
    public class SectionAssignment
    {
        public int GetHowManyAssignmentsContainTheOther(string[] lines)
        {
            var result = 0;
            foreach (var line in lines)
            {
                if (OneAssignmentContainsTheOther(line))
                    result++;
            }
            return result;
        }

        public bool OneAssignmentContainsTheOther(string line)
        {
            var assignements = line.Split(',');
            var firstAssignment = assignements[0];
            var firstAssignmentDetails = firstAssignment.Split("-");
            var firstAssignmentStart = int.Parse(firstAssignmentDetails[0]);
            var firstAssignmentEnd = int.Parse(firstAssignmentDetails[1]);

            var secondAssignment = assignements[1];
            var secondAssignmentDetails = secondAssignment.Split("-");
            var secondAssignmentStart = int.Parse(secondAssignmentDetails[0]);
            var secondAssignmentEnd = int.Parse(secondAssignmentDetails[1]);

            if (firstAssignmentStart == secondAssignmentStart)
                return true;
            if (firstAssignmentStart < secondAssignmentStart)
                return firstAssignmentEnd >= secondAssignmentEnd;
            else
                return firstAssignmentEnd <= secondAssignmentEnd;
        }
    }
}
