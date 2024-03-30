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
            StudentDB.LoadInitialData();

            // Populate the DataGridView with the list of students
            UpdateDataGridView();

            dataGridViewStudents.SelectionChanged += dataGridViewStudents_SelectionChanged;

        }


        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void UpdateDataGridView()
        {
            // Get the list of students from StudentDB
            List<Student> students = StudentDB.GetStudents();

            // Clear existing data (optional)
            dataGridViewStudents.Rows.Clear();

            // Loop through each student and add a row to the DataGridView
            foreach (Student student in students)
            {
                int rowIndex = dataGridViewStudents.Rows.Add();

                // Set values for each column based on student properties
                dataGridViewStudents.Rows[rowIndex].Cells["StudentID"].Value = student.StudentID;
                dataGridViewStudents.Rows[rowIndex].Cells["FirstName"].Value = student.FirstName;
                dataGridViewStudents.Rows[rowIndex].Cells["LastName"].Value = student.LastName;
                dataGridViewStudents.Rows[rowIndex].Cells["Age"].Value = student.Age;
                dataGridViewStudents.Rows[rowIndex].Cells["Gender"].Value = student.Gender;
                dataGridViewStudents.Rows[rowIndex].Cells["ClassName"].Value = student.Classname;
                dataGridViewStudents.Rows[rowIndex].Cells["Score"].Value = student.TotalAssignmentScore;
                dataGridViewStudents.Rows[rowIndex].Cells["MaxScore"].Value = student.TotalMaxScore;
                dataGridViewStudents.Rows[rowIndex].Cells["Average"].Value = (double)student.TotalAssignmentScore / student.Assignments.Length;
            }
        }

        private void dataGridViewStudents_SelectionChanged(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewStudents.SelectedRows[0];

                // Extract student ID (assuming the ID is in the first column)
                int studentID = int.Parse(selectedRow.Cells[0].Value.ToString());

                // Use the student ID for further actions (e.g., display details, edit student)
                Student selectedStudent = StudentDB.FindStudent(studentID);

                if (selectedStudent != null)
                {
                    // Display student details in a separate control or perform other actions
                    MessageBox.Show($"Selected Student: {selectedStudent.ToString()}");
                }
                else
                {
                    MessageBox.Show("Student not found!");
                }
            }
        }

        //Find the selected student in the DataGridView and return the corresponding Student object
        private Student GetSelectedStudent()
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewStudents.SelectedRows[0];
                int studentID = int.Parse(selectedRow.Cells["StudentID"].Value.ToString());
                return StudentDB.FindStudent(studentID);
            }
            return null;
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
                    UpdateDataGridView();
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
                    StudentDB.DeleteStudentByID(selectedStudent.StudentID);
                    UpdateDataGridView();
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

        
    }
}
