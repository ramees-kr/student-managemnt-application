using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Student
    {
        private static int nextStudentID = 100;

        public int StudentID;
        public string Name { get; set; }
        public int TotalAssignmentScore { get; set; }
        public int TotalMaxScore { get; set; }
        public Assignment[] Assignments { get; set; } = new Assignment[5];


        // Constructor to create a student with only a student name
        public Student(string name)
        {
            Name = name;
            StudentID = nextStudentID++;
            Assignments = new Assignment[5];

            for (int i = 0; i < Assignments.Length; i++)
            {
                Assignments[i] = null;
            }

            TotalAssignmentScore = 0;
            TotalMaxScore = 0;
        }

        
        public void AddAssignment(Assignment assignment)
        {
            for (int i = 0; i < Assignments.Length; i++)
            {
                if (Assignments[i] == null)
                {
                    Assignments[i] = assignment;
                    TotalAssignmentScore += assignment.Score;
                    TotalMaxScore += assignment.MaxScore;
                    break;
                }
            }
        }

        public Assignment FindAssignment(int assignmentID)
        {
            return Assignments.FirstOrDefault(a => a != null && a.AssignmentID == assignmentID);
        }

        public void RemoveAssignment(int assignmentID)
        {
            for (int i = 0; i < Assignments.Length; i++)
            {
                if (Assignments[i] != null && Assignments[i].AssignmentID == assignmentID)
                {
                    TotalAssignmentScore -= Assignments[i].Score;
                    TotalMaxScore -= Assignments[i].MaxScore;
                    Assignments[i] = null;
                    break;
                }
            }
        }

        public void UpdateAssignment(int AssignmentID, string newAssignmentName, int newAssignmentScore)
        {
            // Find the index of assigment in the array of assignments of the student
            int index = Array.FindIndex(Assignments, a => a != null && a.AssignmentID == AssignmentID);

            // Update the assignment name and score at index 
            if (index != -1)
            {
                Assignments[index].AssignmentName = newAssignmentName;
                Assignments[index].Score = newAssignmentScore;

                TotalAssignmentScore -= Assignments[index].Score;
                TotalAssignmentScore += newAssignmentScore;
            }
        }

        public override string ToString()
        {
            return $"StudentID: {StudentID}, Name: {Name}, TotalAssignmentScore: {TotalAssignmentScore}, TotalMaxScore: {TotalMaxScore}";
        }

    }

}
