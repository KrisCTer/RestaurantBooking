using RestaurantBooking.BUS;
using RestaurantBooking.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestaurantBooking
{
    public partial class RegisterForm : Form
    {
        private MainForm _mainForm;
        private readonly AuthenService _authenService = new AuthenService();
        public RegisterForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void labelSignIn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(_mainForm);
            loginForm.Show();
            this.Close();
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(register_Username.Text) ||
                string.IsNullOrEmpty(register_Password.Text) ||
                string.IsNullOrEmpty(register_Email.Text) ||
                string.IsNullOrEmpty(register_ConfirmPassword.Text))
            {
                throw new Exception("Please fill all empty fields");
            }
            try
            {
                string username = register_Username.Text.Trim();

                if (register_Password.Text.Trim() != register_ConfirmPassword.Text.Trim())
                {
                    throw new Exception("Password does not match");
                }

                var newUser = new USER
                {
                    ID_USER = _authenService.GenerateUserId(),
                    USERNAME = username,
                    EMAIL = register_Email.Text.Trim(),
                    PASSWORD = register_Password.Text.Trim(),
                    DATE = DateTime.Now
                };
                var createUser = _authenService.RegisterUser(newUser);
                MessageBox.Show("Register successfully!", "Information Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                var loginForm = new LoginForm(_mainForm);
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            register_Password.PasswordChar = registerShowPassword.Checked ? '\0' : '*';
            register_ConfirmPassword.PasswordChar = registerShowPassword.Checked ? '\0' : '*';
        }

        private void register_TextChanged(object sender, EventArgs e)
        {
            if (sender == register_Password)
                register_Password.PasswordChar = '*';
            if (sender == register_ConfirmPassword)
                register_ConfirmPassword.PasswordChar = '*';
        }
        private void Register_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender == register_Username)
                if (register_Username.Text == "Username")
                {
                    register_Username.Text = "";
                    register_Username.ForeColor = System.Drawing.Color.Black;
                }
            if (sender == register_Email)
                if (register_Email.Text == "Email")
                {
                    register_Email.Text = "";
                    register_Email.ForeColor = System.Drawing.Color.Black;
                }
            if (sender == register_Password)
                if (register_Password.Text == "Password")
                {
                    register_Password.Text = "";
                    register_Password.ForeColor = System.Drawing.Color.Black;
                }
            if (sender == register_ConfirmPassword)
                if (register_ConfirmPassword.Text == "Confirm Password")
                {
                    register_ConfirmPassword.Text = "";
                    register_ConfirmPassword.ForeColor = System.Drawing.Color.Black;
                }
        }

        private void register_Back_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(_mainForm);
            loginForm.Show();
            this.Close();
        }
    }
}
