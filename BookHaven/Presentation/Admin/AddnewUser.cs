using BookHaven.Business.Interfaces;
using BookHaven.Business.Services;
using BookHaven.Data.Models;
using BookHaven.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven.Presentation.Admin
{
    public partial class AddnewUser : Form
    {
        private readonly IUserService _userService;
        public AddnewUser()
        {
            InitializeComponent();
            _userService = new UserService(new UserManageRepository());
            LoadUserRoles();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadUserRoles()
        {
            List<KeyValuePair<int, string>> roles = _userService.GetUserRoles();
            cmbuserrole.DataSource = new BindingSource(roles, null);
            cmbuserrole.DisplayMember = "Value";
            cmbuserrole.ValueMember = "Key";
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            // Validate First Name
            if (string.IsNullOrWhiteSpace(txtfirstname.Text))
            {
                MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Last Name
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Email
            if (string.IsNullOrWhiteSpace(txtemail.Text) || !IsValidEmail(txtemail.Text))
            {
                MessageBox.Show("Enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Address
            if (string.IsNullOrWhiteSpace(txtaddress.Text))
            {
                MessageBox.Show("Address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Phone Number (Must be 10 digits)
            if (string.IsNullOrWhiteSpace(txtphone.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txtphone.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Enter a valid 10-digit phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Role Selection
            if (cmbuserrole.SelectedValue == null)
            {
                MessageBox.Show("Please select a user role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate ID Number
            if (string.IsNullOrWhiteSpace(txtidnum.Text))
            {
                MessageBox.Show("ID Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Gender
            if (cmbgender.SelectedItem == null)
            {
                MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Date of Birth (Must be in the past)
            if (dobpicker.Value.Date >= DateTime.Today)
            {
                MessageBox.Show("Date of Birth must be in the past.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create the user object
            UserModel newUser = new UserModel
            {
                FirstName = txtfirstname.Text.Trim(),
                LastName = txtname.Text.Trim(),
                Email = txtemail.Text.Trim(),
                Address = txtaddress.Text.Trim(),
                Phone = txtphone.Text.Trim(),
                RoleID = (int)cmbuserrole.SelectedValue,
                Idnumber = txtidnum.Text.Trim(),
                Gender = cmbgender.SelectedItem.ToString(),
                Dob = dobpicker.Value
            };

            // Add user via service
            _userService.AddUser(newUser);

            MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtfirstname.Text = string.Empty;
            txtname.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtaddress.Text = string.Empty;
            txtphone.Text = string.Empty;
            txtidnum.Text = string.Empty;
            cmbuserrole.SelectedIndex = -1;
            cmbgender.SelectedIndex = -1;
            dobpicker.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserManagement userManagementForm = new UserManagement(_userService);
            this.Hide();  
            userManagementForm.Show(); 
        }
        // Email validation method
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }

}
