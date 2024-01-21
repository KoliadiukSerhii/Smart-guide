using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Coursework
{
    public partial class RegistrationForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

        public RegistrationForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            this.Hide();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            if (emailInput.Text == String.Empty || passwordInput.Text == String.Empty)
            {
                MessageBox.Show("Invalid credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String email = emailInput.Text;
            String pass = passwordInput.Text;
            bool isAdmin = adminCheckBox.Checked;

            if (IsValidEmail(email))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        int existingUserCount = (int)command.ExecuteScalar();

                        if (existingUserCount == 0)
                        {
                            string insertQuery = "INSERT INTO Users (Email, Password, isAdmin) VALUES (@Email, @Password, @IsAdmin)";
                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@Email", email);
                                insertCommand.Parameters.AddWithValue("@Password", pass);
                                insertCommand.Parameters.AddWithValue("@IsAdmin", isAdmin);

                                int rowsAffected = insertCommand.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    LoginForm loginForm = new LoginForm();
                                    loginForm.Show();

                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("We ran into a problem. Try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("User with this email already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
