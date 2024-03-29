using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class MainForm : Form
    {
        public static MainForm Instance { get; private set; }
        public MainForm()
        {
            Instance = this;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Create initial data
            StudentDB.CreateInitialData();

            // Populate the DataGridView with the list of students
            UpdateDataGridView();

            // Populate the list of students in the ListBox
            UpdateStudentList();

        }

        private void UpdateDataGridView()
        {
            // Clear any existing data
            dataGridViewStudents.DataSource = null;

            // Get student data from StudentDB
            List<Student> students = StudentDB.GetStudents();

            // Create a DataTable to hold student information
            DataTable studentTable = new DataTable();
            studentTable.Columns.Add("Student Info");

            // Add student data to the DataTable
            foreach (Student student in students)
            {
                studentTable.Rows.Add($"S{student.StudentID}: {student.Name}");
            }

            // Set the DataGridView's DataSource to the DataTable
            dataGridViewStudents.DataSource = studentTable;

            // (Optional) Set the "Student Info" column as the default displayed column
            dataGridViewStudents.Columns["Student Info"].DisplayIndex = 0;
        }

        

        public void UpdateStudentList()
        {
            // Update the ListBox with the list of students from StudentDB
            listOfStudents.Items.Clear();
            foreach (Student student in StudentDB.GetStudents())
            {
                listOfStudents.Items.Add($"S{student.StudentID}: {student.Name}");
            }
            // Clear the TextBoxes
            ClearTextBoxes();
        }

        private void listOfStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

            Student selectedStudent = GetSelectedStudent();

            if (selectedStudent != null)
            {
                //MessageBox.Show(selectedStudent.ToString());
                // Display student details in text boxes
                StudentDB.UpdateStudentTextBoxes(selectedStudent, txtScoreTotal, txtScoreCount, txtAverage);
            }
            else
            {
                // Clear text boxes if no student is selected
                ClearTextBoxes();
            }

                
        }

        //method to get the selected student
        public Student GetSelectedStudent()
        {
            // Check if a student is selected in the DataGridView
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                DataRow selectedRow = ((DataRowView)dataGridViewStudents.SelectedRows[0].DataBoundItem).Row;
                string studentInfo = selectedRow["Student Info"].ToString();

                // Extract student ID from the formatted string
                int startIndex = studentInfo.IndexOf("S") + 1;
                int endIndex = studentInfo.IndexOf(":");
                string studentIDString = studentInfo.Substring(startIndex, endIndex - startIndex).Trim();

                if (int.TryParse(studentIDString, out int selectedStudentID))
                {
                    return StudentDB.FindStudent(selectedStudentID);
                }
            }

            return null;
        }


        private void ClearTextBoxes()
        {
            // Clear the TextBoxes
            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtAverage.Text = "";
        }

        private void btnPerform_Click(object sender, EventArgs e)
        {
            Student selectedStudent = GetSelectedStudent();
            // Perform the selected operation based on the radio button
            if (rbtnAdd.Checked)
            {
                this.Hide();

                // Open a new form to add a new student
                StudentAddForm studentAddForm = new StudentAddForm();
                DialogResult result = studentAddForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    UpdateStudentList();
                }
                else
                {
                    this.Show();
                }
            }
            else if (rbtnDelete.Checked)
            {
                // Check if a student is selected in the ListBox
                if (GetSelectedStudent() != null)
                {
                    StudentDB.RemoveStudent(selectedStudent);
                    UpdateStudentList();
                }
                else
                {
                    MessageBox.Show("Please select a student to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbtnUpdate.Checked)
            {
                if (selectedStudent != null)
                {
                    //MessageBox.Show(selectedStudent.ToString());
                    // Open a new form to update the selected student
                    DataUpdateForm dataUpdateForm = new DataUpdateForm(StudentDB.GetStudents(), selectedStudent);
                    DialogResult result = dataUpdateForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        // No need to update the student list here
                    }
                }
                else
                {
                    MessageBox.Show("Please select a student to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbtnExit.Checked)
            {
                // Close the application
                Application.Exit();
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //rbtnExit.Checked to close the application
            rbtnExit.Checked = true;
            btnPerform_Click(sender, e);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //rbtnAdd.Checked to add a new student
            rbtnAdd.Checked = true;
            btnPerform_Click(sender, e);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //rbtnUpdate.Checked to update a student
            rbtnUpdate.Checked = true;
            btnPerform_Click(sender, e);

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //rbtnDelete.Checked to delete a student
            rbtnDelete.Checked = true;
            btnPerform_Click(sender, e);
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row is selected
            {
                Student selectedStudent = GetSelectedStudent();

                if (selectedStudent != null)
                {
                    StudentDB.UpdateStudentTextBoxes(selectedStudent, txtScoreTotal, txtScoreCount, txtAverage);
                }
            }

        }

        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row is selected
            {
                Student selectedStudent = GetSelectedStudent();

                if (selectedStudent != null)
                {
                    StudentDB.UpdateStudentTextBoxes(selectedStudent, txtScoreTotal, txtScoreCount, txtAverage);
                }
            }
        }
    }
}
