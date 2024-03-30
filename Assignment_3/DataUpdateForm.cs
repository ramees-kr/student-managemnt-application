using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Assignment_3
{
    public partial class DataUpdateForm : Form
    {
        public Student selectedStudent { get; set; }
        public List<Student> students { get; set; }
        private Assignment selectedAssignment;


        public DataUpdateForm(List<Student> students, Student selectedStudent)
        {
            InitializeComponent();
            this.students = students;
            this.selectedStudent = selectedStudent;

            // Populate comboStudentName with student names
            comboStudentName.DataSource = students;
            //comboStudentName.DisplayMember = selectedStudent.FullName;
            //comboStudentName.ValueMember = selectedStudent.FullName;
            comboStudentName.SelectedItem = selectedStudent;

            InitializeControls();
        }


        private void InitializeControls()
        {
            // Select the current student in the ComboBox
            //comboStudentName.SelectedItem = selectedStudent;

            // Display selected student's name in textBoxNewStudentName
            //textBoxNewStudentName.Text = selectedStudent.FirstName + selectedStudent.LastName;

            if (rbtnUpdateAssignments.Checked)
            {
                LoadAssignments(selectedStudent);
            }
            else
            {
                // Clear assignment-related controls
                ClearAssignmentControls();
                DisableAssignmentControls();
            }
        }

        private void DisableAssignmentControls()
        {
            groupBox1.Enabled = false;
            dataGridViewAssignments.Enabled = false;
            label1.Enabled = false;
            textBoxAssignmentScore.Enabled = false;
            textBoxAssignmentName.Enabled = false;
            labelAssignmentScore.Enabled = false;
            labelAssignemntName.Enabled = false;
            textBoxAssignmentID.Enabled = false;
            findAssignmentGroupBox.Visible = false;
            textBoxAssignmentIDSearch.Visible = false;
            btnFind.Visible = false;
        }

        private void EnableAssignmentControls()
        {
            groupBox1.Enabled = true;
            dataGridViewAssignments.Enabled = true;
            label1.Enabled = true;
            textBoxAssignmentScore.Enabled = true;
            textBoxAssignmentName.Enabled = true;
            labelAssignmentScore.Enabled = true;
            labelAssignemntName.Enabled = true;
            textBoxAssignmentID.Enabled = true;
            findAssignmentGroupBox.Visible = true;
            textBoxAssignmentIDSearch.Visible = true;
            btnFind.Visible = true;
        }

        private void LoadAssignments(Student selectedStudent)
        {
            // Clear existing rows in the DataGridView
            dataGridViewAssignments.Rows.Clear();

            // Check if selectedStudent or its Assignments array is null
            if (selectedStudent == null || selectedStudent.Assignments == null)
            {
                // Handle the case where there are no assignments for the selected student
                MessageBox.Show("No assignments found for the selected student.");
                return;
            }

            // Iterate over the assignments of the selected student
            foreach (Assignment assignment in selectedStudent.Assignments)
            {
                if (assignment == null) continue; // Skip null assignments

                // Add a new row to the DataGridView
                int rowIndex = dataGridViewAssignments.Rows.Add();

                // Set values for each column based on assignment properties
                dataGridViewAssignments.Rows[rowIndex].Cells["AssignmentID"].Value = assignment.AssignmentID;
                dataGridViewAssignments.Rows[rowIndex].Cells["AssignmentName"].Value = assignment.AssignmentName;
                dataGridViewAssignments.Rows[rowIndex].Cells["Score"].Value = assignment.Score;
                dataGridViewAssignments.Rows[rowIndex].Cells["MaxScore"].Value = assignment.MaxScore;
            }
        }



        private void ClearAssignmentControls()
        {
            //listOfAssignments.DataSource = null;
            textBoxAssignmentID.Clear();
            textBoxAssignmentName.Clear();
            textBoxAssignmentScore.Clear();
        }

        public Assignment GetSelectedAssignment()
        {
            // Get the selected assignment from the DataGridView
            if (dataGridViewAssignments.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewAssignments.SelectedRows[0];
                int assignmentID = (int)selectedRow.Cells["AssignmentID"].Value;
                return StudentDB.GetAssignmentByID(selectedStudent, assignmentID);
            }
            return null;
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rbtnUpdateStudent.Checked == true)
            {
                // open a new form to update the selected student
                StudentUpdateForm updateStudent = new StudentUpdateForm(selectedStudent);
                DialogResult result = updateStudent.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Refresh students in MainForm
                    MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                    if (mainForm != null)
                    {
                        mainForm.UpdateDataGridView();
                        MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else if (rbtnUpdateAssignments.Checked == true)
            {
                // Update selected assignment data
                if (selectedAssignment != null)
                {
                    // Update assignment data
                    selectedAssignment.AssignmentName = textBoxAssignmentName.Text;
                    int newScore;
                    if (int.TryParse(textBoxAssignmentScore.Text, out newScore))
                    {
                        if (newScore < 0 || newScore > 100)
                        {
                            MessageBox.Show("Score must be between 0 and 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        selectedAssignment.Score = newScore;
                    }
                    else
                    {
                        MessageBox.Show("Invalid score format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Update assignment data in StudentDB
                    StudentDB.UpdateAssignmentScore(selectedStudent.StudentID, selectedAssignment);
                    LoadAssignments(selectedStudent);

                    // Refresh students in MainForm
                    MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                    if (mainForm != null)
                    {
                        mainForm.UpdateDataGridView();
                        MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // Add a new assignment
                    int newScore;
                    if (int.TryParse(textBoxAssignmentScore.Text, out newScore))
                    {
                        if (newScore < 0 || newScore > 100)
                        {
                            MessageBox.Show("Score must be between 0 and 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        StudentDB.AddAssignmentToStudent(selectedStudent, textBoxAssignmentName.Text, newScore);
                        LoadAssignments(selectedStudent);

                        // Refresh students in MainForm
                        MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                        if (mainForm != null)
                        {
                            mainForm.UpdateDataGridView();
                            MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid score format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form with DialogResult.Cancel
            DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void UpdateSelectedAssignment(Assignment selectedAssignment)
        {
            selectedAssignment = GetSelectedAssignment();

            if (selectedAssignment != null)
            {
                textBoxAssignmentID.Text = selectedAssignment.AssignmentID.ToString();
                textBoxAssignmentName.Text = selectedAssignment.AssignmentName;
                textBoxAssignmentScore.Text = selectedAssignment.Score.ToString();
            }
        }

        private void comboStudentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if a student is selected in the ComboBox
            if (comboStudentName.SelectedIndex != -1)
            {
                // Get the selected student from the ComboBox by name
                selectedStudent = (Student)comboStudentName.SelectedItem;

                InitializeControls();
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbtnUpdateAssignments.Checked = true;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rbtnUpdateAssignments.Checked)
            {
                Assignment[] assignments = StudentDB.GetAssignments(selectedStudent);

                if (assignments.Length <= 5)
                {
                    // make textBoxAssignmentID editable
                    //textBoxAssignmentID.ReadOnly = false;

                    textBoxAssignmentID.Clear();
                    textBoxAssignmentName.Clear();
                    textBoxAssignmentScore.Clear();

                    MessageBox.Show("Enter the Assignment Name and score in the textboxes and click Save button to add the assignment.", "Add Assignment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rbtnUpdateAssignments.Checked = true;
                }
                else
                {
                    MessageBox.Show("The student already has 5 assignments. You cannot add more assignments.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please check the Update Assignments checkbox to enable this feature.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rbtnUpdateAssignments.Checked)
            {
                //textBoxAssignmentIDSearch.Enabled = true;
                //btnFind.Enabled = true;

                textBoxAssignmentIDSearch.Clear();
                textBoxAssignmentIDSearch.Focus();
                MessageBox.Show("Enter the assignment ID to find the assignment.", "Find Assignment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please check the Update Assignments checkbox to enable this feature.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            if (rbtnUpdateAssignments.Checked)
            {
                int assignmentID;
                if (int.TryParse(textBoxAssignmentIDSearch.Text, out assignmentID))
                {
                    selectedAssignment = StudentDB.GetAssignmentByID(selectedStudent, assignmentID);
                    if (selectedAssignment != null)
                    {
                        MessageBox.Show("Assignment found.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateSelectedAssignment(selectedAssignment);
                    }
                    else
                    {
                        MessageBox.Show("Assignment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rbtnUpdateAssignments.Checked)
            {
                if (selectedAssignment != null)
                {
                    StudentDB.RemoveAssignment(selectedStudent, selectedAssignment.AssignmentID);
                    LoadAssignments(selectedStudent);
                    ClearAssignmentControls();
                    MessageBox.Show("Assignment deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please select an assignment to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please check the Update Assignments checkbox to enable this feature.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewAssignments_SelectionChanged(object sender, EventArgs e)
        {
            // Get the selected assignment from the DataGridView
            if (dataGridViewAssignments.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewAssignments.SelectedRows[0];
                int assignmentID = (int)selectedRow.Cells["AssignmentID"].Value;
                selectedAssignment = StudentDB.GetAssignmentByID(selectedStudent, assignmentID);

                if (selectedAssignment != null)
                {
                    textBoxAssignmentID.Text = selectedAssignment.AssignmentID.ToString();
                    textBoxAssignmentName.Text = selectedAssignment.AssignmentName;
                    textBoxAssignmentScore.Text = selectedAssignment.Score.ToString();
                }
            }
        }

        private void rbtnUpdateStudent_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnUpdateAssignments.Checked == true)
            {
                EnableAssignmentControls();
                LoadAssignments(selectedStudent);
            }
            else
            {
                ClearAssignmentControls();
                DisableAssignmentControls();
            }
        }

        private void rbtnUpdateAssignments_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnUpdateAssignments.Checked == true)
            {
                EnableAssignmentControls();
                LoadAssignments(selectedStudent);
            }
            else
            {
                ClearAssignmentControls();
                DisableAssignmentControls();
            }
        }
    }
}
