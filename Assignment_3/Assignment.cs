using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Assignment
    {
        private static int nextAssignmentID = 1;

        public string AssignmentName { get; set; }
        public int AssignmentID { get; private set; }
        public int Score { get; set; }
        public int MaxScore { get; set; }

        public Assignment(string assignmentName, int maxScore, int score)
        {
            AssignmentName = assignmentName;
            MaxScore = maxScore;
            Score = score;
            AssignmentID = nextAssignmentID++;
        }
    }
}
