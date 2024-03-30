using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public static class StudentDB
    {
        private static List<Student> students = new List<Student>();
        private static string studentFile = "..\\..\\students.txt";
        private static string assignmentFile = "..\\..\\assignments.txt";

        static StudentDB()
        {
        }

        public static void LoadInitialData()
        {
            MessageBox.Show("Before Reading Students");
            // Load initial student data from files on startup
            students = ReadStudentsFromFile(studentFile);
            MessageBox.Show("After Reading Students");

            LoadStudentAssignments(students, assignmentFile);
            //CalculateGrade();
        }

        //Method to calculate the grade of the all students
        public static void CalculateGrade()
        {
            foreach (Student student in students)
            {
                student.Grade = student.CalculateGrade();
            }
        }

        // CRUD methods for students
        public static void AddStudent(Student student)
        {
            students.Add(student);
            SaveStudentsToFile(studentFile);
        }

        public static List<Student> GetStudents()
        {
            return students;
        }

        //Method to get the student by ID
        public static Student GetStudentByID(int studentID)
        {
            return students.FirstOrDefault(s => s.StudentID == studentID);
        }

        //Method to delete student by ID, delete assignements of the student, update both files.
        public static void DeleteStudentByID(int studentID)
        {
            Student student = GetStudentByID(studentID);
            if (student != null)
            {
                students.Remove(student);
                DeleteStudentAssignments(studentID);
                SaveStudentsToFile(studentFile);
            }
        }


        public static void UpdateStudent(Student student)
        {
            int index = students.FindIndex(s => s.StudentID == student.StudentID);
            if (index != -1)
            {
                students[index] = student;
                SaveStudentsToFile(studentFile);
            }
            else
            {
                throw new Exception("Student not found!");
            }
        }

        public static void DeleteStudent(int studentID)
        {
            int index = students.FindIndex(s => s.StudentID == studentID);
            if (index != -1)
            {
                students.RemoveAt(index);
                SaveStudentsToFile(studentFile);
            }
            else
            {
                throw new Exception("Student not found!");
            }
        }

        public static Student FindStudent(int studentID)
        {
            return students.FirstOrDefault(s => s.StudentID == studentID);
        }

        public static void UpdateAssignmentScore(int studentID, string assignmentName, int newScore)
        {
            Student student = FindStudent(studentID);
            //student.UpdateAssignment(assignmentName, newScore);
            SaveStudentsToFile(studentFile);
            SaveAssignmentsToFile(assignmentFile);
        }

        // Helper methods for file operations
        private static List<Student> ReadStudentsFromFile(string filename)
        {
            List<Student> students = new List<Student>();
            using (StreamReader reader = new StreamReader(filename))
            {
                // Skip header line
                reader.ReadLine();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');

                    // Ensure correct number of fields
                    if (data.Length != 7)
                    {
                        Console.WriteLine("Invalid data format: " + line);
                        continue;
                    }

                    // Extract data using named properties
                    string firstName = data[1].Trim();
                    string lastName = data[2].Trim();
                    int age = int.Parse(data[3].Trim());
                    string gender = data[4].Trim();
                    string className = data[5].Trim();

                    // Create new student
                    Student student = new Student(firstName, lastName, age, gender, className);

                    MessageBox.Show(student.ToString());

                    // Assign student ID from file
                    student.StudentID = int.Parse(data[0].Trim());

                    // Add student to list
                    students.Add(student);
                }
            }
            return students;
        }


        private static void SaveStudentsToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("StudentID,FirstName,LastName,Age,Gender,Classname,Grade");
                foreach (Student student in students)
                {
                    string studentData = $"{student.StudentID},{student.FirstName},{student.LastName},{student.Age},{student.Gender},{student.Classname},{student.Grade}";
                    writer.WriteLine(studentData);
                }
            }
        }

        private static void LoadStudentAssignments(List<Student> students, string filename)
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    if (data.Length != 4)
                    {
                        Console.WriteLine("Invalid data format: " + line);
                        continue; // Skip invalid lines
                    }

                    int studentID;
                    if (!int.TryParse(data[0], out studentID))
                    {
                        Console.WriteLine($"Invalid student ID: {data[0]}");
                        continue; // Skip this line and move to the next one
                    }

                    string assignmentName = data[1];

                    int maxScore;
                    if (!int.TryParse(data[2], out maxScore))
                    {
                        Console.WriteLine($"Invalid max score: {data[2]}");
                        continue; // Skip this line and move to the next one
                    }

                    int score;
                    if (!int.TryParse(data[3], out score))
                    {
                        Console.WriteLine($"Invalid score: {data[3]}");
                        continue; // Skip this line and move to the next one
                    }


                    // Find the student with the corresponding ID
                    Student student = students.FirstOrDefault(s => s.StudentID == studentID);
                    if (student != null)
                    {
                        // Add the assignment to the student
                        student.AddAssignment(assignmentName, maxScore, score);
                    }
                    else
                    {
                        Console.WriteLine($"Student with ID {studentID} not found.");
                    }
                }
            }
        }

        private static void SaveAssignmentsToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Student student in students)
                {
                    foreach (Assignment assignment in student.Assignments)
                    {
                        if (assignment != null)
                        {
                            writer.WriteLine($"{student.StudentID},{assignment.AssignmentName},{assignment.MaxScore},{assignment.Score}");
                        }
                    }
                }
            }
        }

        private static void DeleteStudentAssignments(int studentID)
        {
            foreach (Student student in students)
            {
                if (student.StudentID == studentID)
                {
                    for (int i = 0; i < student.Assignments.Length; i++)
                    {
                        student.Assignments[i] = null;
                    }
                }
            }
            SaveAssignmentsToFile(assignmentFile);
        }

        internal static Assignment[] GetAssignments(Student selectedStudent)
        {
            //retun the assignments of the selected student
            return selectedStudent.Assignments;
        }

        internal static Assignment GetAssignmentByID(Student selectedStudent, int selectedAssignmentID)
        {
            throw new NotImplementedException();
        }

        internal static void UpdateAssignment(int studentID, Assignment selectedAssignment)
        {
            throw new NotImplementedException();
        }

        internal static void AddAssignmentToStudent(Student selectedStudent, string text, int newScore)
        {
            throw new NotImplementedException();
        }

        internal static void RemoveAssignment(Student selectedStudent, int assignmentID)
        {
            throw new NotImplementedException();
        }
    }
}

