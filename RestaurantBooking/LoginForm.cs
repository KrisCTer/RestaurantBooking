using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantBooking.BUS;

namespace RestaurantBooking
{
    public partial class LoginForm : Form
    {
        public MainForm _mainForm;
        private readonly AuthenService _authenService = new AuthenService();
        public LoginForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }
        private void labelRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(_mainForm);
            registerForm.Show();
            this.Close();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var user = _authenService.Login(login_Username.Text, login_Password.Text);

                if (user != null)
                {
                    MessageBox.Show("Login successfully!", "Information Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _mainForm.SetMainUser(user);
                    _mainForm.loginOrSignupControl.Visible = false;
                    _mainForm.homeControl.Visible = true;
                    _mainForm.searchControl.Visible = false;
                    _mainForm.myRevervationControl.Visible = false;

                    _mainForm.profileControl.Visible = false;
                    _mainForm.restaurantControl.Visible = false;
                    _mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username/password or there's no Admin's approval",
                        "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void registerShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            login_Password.PasswordChar = loginShowPassword.Checked ? '\0' : '*';
        }

        private void login_Password_TextChanged(object sender, EventArgs e)
        {
            login_Password.PasswordChar = '*';
        }
        private void Register_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender == login_Username)
                if (login_Username.Text == "Username")
                {
                    login_Username.Text = "";
                    login_Username.ForeColor = System.Drawing.Color.Black;
                }
            if (sender == login_Password)
                if (login_Password.Text == "Password")
                {
                    login_Password.Text = "";
                    login_Password.ForeColor = System.Drawing.Color.Black;
                }
        }

        private void register_Back_Click(object sender, EventArgs e)
        {
            try
            {
                _mainForm.Show();
                _mainForm.loginOrSignupControl.Visible = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error returning to login: " + ex.Message);
            }
        }
    }
}
