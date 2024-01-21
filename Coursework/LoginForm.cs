using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Coursework
{
    public partial class LoginForm : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();

            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (emailInput.Text == String.Empty || passwordInput.Text == String.Empty)
            {
                MessageBox.Show("Invalid credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String email = emailInput.Text;
            String pass = passwordInput.Text;

            if (IsValidEmail(email))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT isAdmin FROM Users WHERE email = @Email AND password = @Password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", pass);

                        object isAdminResult = command.ExecuteScalar();

                        if (isAdminResult != null)
                        {
                            bool isAdmin = Convert.ToBoolean(isAdminResult);
                            if (isAdmin)
                            {
                                AdminPanel adminPanel = new AdminPanel();
                                adminPanel.Show();

                                this.Hide();
                            }
                            else
                            {
                                UserPanelForm userPanel = new UserPanelForm();
                                userPanel.Show();

                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
