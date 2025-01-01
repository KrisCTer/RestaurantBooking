using RestaurantBooking.Entities;
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

namespace RestaurantBooking
{
    public partial class LoginForm : Form
    {
        public MainForm _mainForm;
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

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            using (var context = new RestaurantBookingDB())
            {
                try
                {
                    var user = await context.USERs
                        .FirstOrDefaultAsync(u =>
                            u.USERNAME == login_Username.Text.Trim() &&
                            u.PASSWORD == login_Password.Text.Trim());

                    if (user != null)
                    {
                        MessageBox.Show("Login successfully!", "Information Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _mainForm.SetMainUser(user);
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

                //LoginOrSignupControl loginControl = new LoginOrSignupControl(_mainForm);
                //loginControl.Location = new Point(262, 0);
                //_mainForm.Controls.Add(loginControl);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error returning to login: " + ex.Message);
            }
        }
    }
}
