using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Student
    {
        private static int nextStudentID;

        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Classname { get; set; }
        public string Grade { get; set; }
        public int TotalAssignmentScore { get; private set; }
        public int TotalMaxScore { get; private set; }
        public Assignment[] Assignments { get; set; } = new Assignment[5];

        //Static field to return first name and last name
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public static void SetNextStudentID(int studid)
        {
            nextStudentID = studid;
        }
        public Student(string firstName, string lastName, int age, string gender, string classname)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            Classname = classname;
            StudentID = nextStudentID++;
            Assignments = new Assignment[5];

            for (int i = 0; i < Assignments.Length; i++)
            {
                Assignments[i] = null;
            }

            TotalAssignmentScore = 0;
            TotalMaxScore = 0;
            Grade = CalculateGrade();
        }

        public Student(int studentID, string firstName, string lastName, int age, string gender, string className)
        {
            StudentID = studentID;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            Classname = className;
        }

        public void AddAssignment(string assignmentName, int maxScore, int score)
        {
            for (int i = 0; i < Assignments.Length; i++)
            {
                if (Assignments[i] == null)
                {
                    Assignments[i] = new Assignment(assignmentName, maxScore, score);
                    TotalMaxScore += maxScore;
                    TotalAssignmentScore += score;
                    Grade = CalculateGrade();
                    return;
                }
            }

            // Handle case where all assignment slots are filled
            throw new Exception("Student assignment slots are full!");
        }

        public void UpdateAssignment(int assignmentID, string assignmentName, int newScore)
        {
            for (int i = 0; i < Assignments.Length; i++)
            {
                if (Assignments[i] != null && Assignments[i].AssignmentID == assignmentID)
                {
                    int oldScore = Assignments[i].Score;
                    Assignments[i].AssignmentName = assignmentName;
                    Assignments[i].Score = newScore;
                    TotalMaxScore -= oldScore;
                    TotalMaxScore += newScore;
                    TotalAssignmentScore -= oldScore;
                    TotalAssignmentScore += newScore;
                    Grade = CalculateGrade();
                    return;
                }
            }

            // Handle case where assignment not found
            throw new Exception("Assignment with ID " + assignmentID + " not found for student!");
        }

        public Assignment FindAssignment(int assignmentID)
        {
            for (int i = 0; i < Assignments.Length; i++)
            {
                if (Assignments[i] != null && Assignments[i].AssignmentID == assignmentID)
                {
                    return Assignments[i];
                }
            }
            return null; // Assignment not found
        }

        public void RemoveAssignment(int assignmentID)
        {
            for (int i = 0; i < Assignments.Length; i++)
            {
                if (Assignments[i] != null && Assignments[i].AssignmentID == assignmentID)
                {
                    int removedScore = Assignments[i].Score;
                    int removedMaxScore = Assignments[i].MaxScore;
                    Assignments[i] = null;
                    TotalMaxScore -= removedMaxScore;
                    TotalAssignmentScore -= removedScore;
                    Grade = CalculateGrade();
                    return;
                }
            }

            // Handle case where assignment not found
            throw new Exception("Assignment with ID " + assignmentID + " not found for student!");
        }

        public string CalculateGrade()
        {
            double percentage = (double)TotalAssignmentScore / TotalMaxScore * 100;

            if (percentage >= 90)
            {
                return "A";
            }
            else if (percentage >= 80)
            {
                return "B";
            }
            else if (percentage >= 70)
            {
                return "C";
            }
            else if (percentage >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        public override string ToString()
        {
            return $"{StudentID}: {FirstName} {LastName}";
        }
    }

}
