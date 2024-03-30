using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class StudentUpdateForm : Form
    {
        private Student selectedStudent;

        public StudentUpdateForm()
        {
        }

        public StudentUpdateForm(Student selectedStudent)
        {
            this.selectedStudent = selectedStudent;
            InitializeComponent();

            txtStudentFirstName.Text = selectedStudent.FirstName;
            txtStudentLastName.Text = selectedStudent.LastName;
            comboBoxClassName.Text = selectedStudent.Classname;
            textBoxAge.Text = selectedStudent.Age.ToString();
            comboBoxGender.Text = selectedStudent.Gender;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //validate input with exception handling
            try
            {
                if (txtStudentFirstName.Text == "")
                {
                    throw new Exception("Please enter a first name.");
                }
                if (txtStudentLastName.Text == "")
                {
                    throw new Exception("Please enter a last name.");
                }
                if (comboBoxClassName.Text == "")
                {
                    throw new Exception("Please select a class name.");
                }
                if (textBoxAge.Text == "")
                {
                    throw new Exception("Please enter an age.");
                }
                if (comboBoxGender.Text == "")
                {
                    throw new Exception("Fields must not be empty");
                }

                selectedStudent.FirstName = txtStudentFirstName.Text;
                selectedStudent.LastName = txtStudentLastName.Text;
                selectedStudent.Classname = comboBoxClassName.Text;
                selectedStudent.Age = Convert.ToInt32(textBoxAge.Text);
                selectedStudent.Gender = comboBoxGender.Text;

                // Update student data in StudentDB
                StudentDB.UpdateStudent(selectedStudent.StudentID);

                DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
