using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class StudentAddForm : Form
    {
        public Student Student { get; private set; }

        public StudentAddForm()
        {
            InitializeComponent();

            txtAssignmentMaxScore.Text = "100";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtStudentName.Text) || string.IsNullOrWhiteSpace(txtAssignmentName.Text) || string.IsNullOrWhiteSpace(txtAssignmentScore.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Parse input values
            if (!int.TryParse(txtAssignmentScore.Text, out int assignmentScore))
            {
                MessageBox.Show("Invalid score format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Create new student and assignment and add it to DB
            StudentDB.AddNewStudent(txtStudentName.Text, txtAssignmentName.Text, assignmentScore);

            DialogResult = DialogResult.OK;
            this.Close();

            MainForm.Instance.Show();
             }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            MainForm.Instance.Show();
            //open the main form
            //MainForm mainForm = new MainForm();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCancel_Click(sender, e);
        }
    }
}
