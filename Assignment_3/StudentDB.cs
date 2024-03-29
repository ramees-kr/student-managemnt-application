using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public static class StudentDB
    {
        private static List<Student> students = new List<Student>();

        public static void AddNewStudent(string studentName, string assignmentName, int assignmentScore)
        {
            Student newStudent = new Student(studentName);
            Assignment assignment = new Assignment(assignmentName, assignmentScore, 100);
            newStudent.AddAssignment(assignment);

            students.Add(newStudent);
            UpdateStudentListInMainForm();
        }

        public static void UpdateStudentListInMainForm()
        {
            MainForm.Instance.UpdateStudentList();
        }

        // Find student by ID
        public static Student FindStudent(int studentID)
        {
            return students.FirstOrDefault(s => s.StudentID == studentID);
        }

        //
        public static void AddStudentToDB(Student student)
        {
            students.Add(student);
        }

        public static List<Student> GetStudents()
        {
            return students;
        }

        //method to get assignments array of a student
        public static Assignment[] GetAssignments(Student student)
        {
            return student.Assignments;
        }

        public static void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public static void UpdateStudent(Student student)
        {
            // Find the student in the list and replace it with the updated student
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].StudentID == student.StudentID)
                {
                    students[i] = student;
                    break;
                }
            }
        }

        //create initial student data
        public static void CreateInitialData()
        {
            string[] studentNames = { "John Doe", "Jane Smith", "Bob Johnson", "Sue Wilson", "Mike Brown" };

            string[] assignmentNames = { "Assignment 1", "Assignment 2", "Assignment 3", "Assignment 4", "Assignment 5" };

            foreach (string studentName in studentNames)
            {
                Student student = new Student(studentName);

                // Use methods from StudentDB to add assignments and add the student
                for (int i = 0; i < student.Assignments.Length; i++)
                {
                    int randomScore = GetRandomScore(studentName, 70, 100);
                    
                    // Add a new assignment to the student pick random assignment name and score
                    int randomAssignmentNameIndex = new Random().Next(0, assignmentNames.Length);
                    student.AddAssignment(new Assignment(assignmentNames[randomAssignmentNameIndex], randomScore, 100));
                    //student.AddAssignment(new Assignment(randomScore, 100));
                }

                // Add the student to the StudentDB
                StudentDB.AddStudentToDB(student);
            }
        }

        //method to take in student object and add a new assignment to the student
        public static void AddAssignmentToStudent(Student student, string assignmentName, int assignmentScore)
        {
            student.AddAssignment(new Assignment(assignmentName, assignmentScore, 100));
        }

        private static int GetRandomScore(string studentName, int min, int max)
        {
            // Use a seed based on the student's name to ensure unique scores
            int seed = studentName.GetHashCode();
            Random random = new Random(seed);
            return random.Next(min, max + 1);
        }

        public static void UpdateStudentTextBoxes(Student student, TextBox txtScoreTotal, TextBox txtScoreCount, TextBox txtAverage)
        {
            int totalScore = 0;
            int scoreCount = student.Assignments.Count(a => a != null);

            foreach (Assignment assignment in student.Assignments)
            {
                if (assignment != null)
                {
                    totalScore = totalScore + assignment.Score;
                }
            }

            double averageScore = (scoreCount > 0) ? (double)totalScore / scoreCount : 0;

            // Update the TextBoxes
            txtScoreTotal.Text = totalScore.ToString();
            txtScoreCount.Text = scoreCount.ToString();
            txtAverage.Text = averageScore.ToString("F2"); // Format average to two decimal places
        }

        internal static void UpdateAssignment(int studentID, Assignment selectedAssignment)
        {
            Student student = FindStudent(studentID);
            student.UpdateAssignment(selectedAssignment.AssignmentID, selectedAssignment.AssignmentName, selectedAssignment.Score);
            UpdateStudent(student);
            UpdateStudentListInMainForm();
        }

        internal static Assignment GetAssignmentByID(Student selectedStudent, int selectedAssignmentID)
        {
           //return the assignment with the given ID from the student's assignments
            return selectedStudent.FindAssignment(selectedAssignmentID);
        }

        internal static void RemoveAssignment(Student selectedStudent, int assignmentID)
        {
            selectedStudent.RemoveAssignment(assignmentID);
            UpdateStudentListInMainForm();
        }
    }
}

