using BookHaven.Business.Interfaces;
using BookHaven.Business.Services;
using BookHaven.Data.Models;
using BookHaven.Data.Repositories;
using BookHaven.Presentation.Admin;
using BookHaven.Presentation.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven.Presentation
{
    public partial class LoginForm : Form
    {
        private readonly IAuthService _authService;
        public LoginForm()
        {
            InitializeComponent();
            _authService = new AuthService(new UserRepository());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtemail.Text.Trim();
                string password = txtpassword.Text.Trim();

                // Validate email format using regular expression
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter email and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Invalid email format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (password.Length < 8)
                {
                    MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                UserModel user = _authService.AuthenticateUser(email, password);

                if (user != null)
                {
                    MessageBox.Show($"Welcome, {user.FirstName}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (user.RoleID == 1)
                    {
                        AdminDashboard adminDashboard = new AdminDashboard();
                        adminDashboard.Show();
                    }
                    else if (user.RoleID == 2)
                    {
                        SalesClerkDashboard salesDashboard = new SalesClerkDashboard();
                        salesDashboard.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Email format validation method
        private bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
