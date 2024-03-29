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

        public Assignment(int score, int maxScore)
        {
            AssignmentID = nextAssignmentID++;
            Score = score;
            MaxScore = maxScore;
        }

        public Assignment(string AssignmentName, int score, int maxScore)
        {
            AssignmentID = nextAssignmentID++;
            this.AssignmentName = AssignmentName;
            Score = score;
            MaxScore = maxScore;
        }

        public override string ToString()
        {
            return $"ID: {AssignmentID}, Assignment Name: {AssignmentName}, Score: {Score}, MaxScore: {MaxScore}";
        }


    }

}
