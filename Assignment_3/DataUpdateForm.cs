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
            comboStudentName.DisplayMember = "Name";
            comboStudentName.ValueMember = "Name";
            comboStudentName.SelectedItem = selectedStudent;

            InitializeControls();
        }

        private void InitializeControls()
        {
            // Select the current student in the ComboBox
            comboStudentName.SelectedItem = selectedStudent;

            // Display selected student's name in textBoxNewStudentName
            textBoxNewStudentName.Text = selectedStudent.FirstName + selectedStudent.LastName;

            if (checkBoxUpdateAssignments.Checked)
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
            listOfAssignments.Enabled = false;
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
            listOfAssignments.Enabled = true;
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
            // Get the assignments for the selected student using the method in StudentDB
            Assignment[] assignments = StudentDB.GetAssignments(selectedStudent);

            // Clear the listbox
            listOfAssignments.Items.Clear();

            // Add the assignments to the listbox
            foreach (Assignment assignment in assignments)
            {
                if (assignment != null)
                {
                    listOfAssignments.Items.Add(assignment);
                }
            }
        }

        private void ClearAssignmentControls()
        {
            listOfAssignments.DataSource = null;
            textBoxAssignmentID.Clear();
            textBoxAssignmentName.Clear();
            textBoxAssignmentScore.Clear();
        }

        public Assignment GetSelectedAssignment()
        {
            // Check if an assignment is selected in the ListBox
            if (listOfAssignments.SelectedItem != null)
            {
                string selectedItem = listOfAssignments.SelectedItem.ToString();

                // Extract the part between "ID:" and ","
                int startIndex = selectedItem.IndexOf("ID:") + 3;
                int endIndex = selectedItem.IndexOf(",");

                string assignmentIDString = selectedItem.Substring(startIndex, endIndex - startIndex).Trim();

                if (int.TryParse(assignmentIDString, out int selectedAssignmentID))
                {
                    return StudentDB.GetAssignmentByID(selectedStudent, selectedAssignmentID);
                }
            }

            // If no assignment is selected, return null
            return null;
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkBoxUpdateAssignments.Checked)
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
                    StudentDB.UpdateAssignment(selectedStudent.StudentID, selectedAssignment);
                    LoadAssignments(selectedStudent);
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
                    }
                    else
                    {
                        MessageBox.Show("Invalid score format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
            }

            // Update selected student data
            selectedStudent.FirstName = textBoxNewStudentName.Text;

            // Update student data in StudentDB
            StudentDB.UpdateStudent(selectedStudent);

            // Refresh students in MainForm
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.UpdateDataGridView();
            }

            MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form with DialogResult.Cancel
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void checkBoxUpdateAssignments_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUpdateAssignments.Checked)
            {
                EnableAssignmentControls();
                // Load assignments for the selected student
                LoadAssignments(selectedStudent);
            }
            else
            {
                ClearAssignmentControls();
                DisableAssignmentControls();
            }
        }

        private void listOfAssignments_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAssignment = GetSelectedAssignment();

            if (selectedAssignment != null)
            {
                textBoxAssignmentID.Text = selectedAssignment.AssignmentID.ToString();
                textBoxAssignmentName.Text = selectedAssignment.AssignmentName;
                textBoxAssignmentScore.Text = selectedAssignment.Score.ToString();
            }
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
            checkBoxUpdateAssignments.Checked = true;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkBoxUpdateAssignments.Checked)
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
                    checkBoxUpdateAssignments.Checked = true;
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
            if (checkBoxUpdateAssignments.Checked)
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

            if (checkBoxUpdateAssignments.Checked)
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
            if (checkBoxUpdateAssignments.Checked)
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
    }
}
