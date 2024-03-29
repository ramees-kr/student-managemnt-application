using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class Login : Form
    {
        private const string Path = "..\\..\\user.txt";

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            try
            {
                if (AuthenticateUser(username, password))
                {
                    // Authentication successful, open main form
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide(); // Hide the login form
                }
                else
                {
                    // Authentication failed, show error message
                    MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle any unexpected errors
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool AuthenticateUser(string username, string password)
        {
            try
            {
                // Use StreamReader to read the user.txt file
                using (StreamReader reader = new StreamReader(Path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] credentials = line.Split(',');
                        if (credentials.Length == 2 && credentials[0] == username && credentials[1] == password)
                        {
                            if (username == "ADMIN")
                            {
                                MessageBox.Show("Admin user logged in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("User logged in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            return true; // Authentication successful
                        }
                    }
                }
                return false; // Authentication failed
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("User file not found. Please contact your system administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Error authenticating user.", ex);
            }
        }

    }
}
