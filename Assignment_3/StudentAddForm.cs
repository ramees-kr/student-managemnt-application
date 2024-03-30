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
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(txtStudentFirstName.Text))
                {
                    throw new ArgumentException("First name cannot be empty.");
                }

                if (string.IsNullOrWhiteSpace(txtStudentLastName.Text))
                {
                    throw new ArgumentException("Last name cannot be empty.");
                }

                if (string.IsNullOrWhiteSpace(textBoxAge.Text))
                {
                    throw new ArgumentException("Age cannot be empty.");
                }

                if (!int.TryParse(textBoxAge.Text, out _))
                {
                    throw new FormatException("Age must be a valid number.");
                }

                //Create new student and assignment and add it to DB using AddStudent method
                Student = new Student(txtStudentFirstName.Text, txtStudentLastName.Text, int.Parse(textBoxAge.Text), comboBoxGender.Text, comboBoxClassName.Text);
                StudentDB.AddStudent(Student);

                // If all input is valid, close the form
                DialogResult = DialogResult.OK;
                Close();

                MainForm.Instance.Show();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
