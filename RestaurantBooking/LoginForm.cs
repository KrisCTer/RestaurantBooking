using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantBooking
{
    public partial class LoginForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LOWJICHOW\SQLEXPRESS;Initial Catalog=RestaurantBooking;Integrated Security=True;Connect Timeout=30");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            //login_Username.Text = "";
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM USERS WHERE USERNAME = @USERN AND PASSWORD = @PASS";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@USERN", login_Username.Text.Trim());
                        cmd.Parameters.AddWithValue("@PASS", login_Password.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username/password or there's no Admin's approval", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }
        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
                return true;
            return false;
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
    }
}
