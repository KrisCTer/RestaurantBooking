using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestaurantBooking
{
    public partial class RegisterForm : Form
    {
        // change
        SqlConnection connect = new SqlConnection(@"Data Source=LOWJICHOW\SQLEXPRESS;Initial Catalog=RestaurantBooking;Integrated Security=True;Connect Timeout=30");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void labelSignIn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            if (register_Username.Text == "" || register_Password.Text == "" || register_ConfirmPassword.Text == "")
            {
                MessageBox.Show("Please fill all empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string checkUserName = "SELECT * FROM USERS WHERE USERNAME = @USERN";
                        using (SqlCommand cmd = new SqlCommand(checkUserName, connect))
                        {
                            cmd.Parameters.AddWithValue("@USERN", register_Username.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(register_Username.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_Password.Text.Length < 8)
                            {
                                MessageBox.Show("Invalid Passsword, at least 8 characters are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_Password.Text.Trim() != register_ConfirmPassword.Text.Trim())
                            {
                                MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO USERS (USERNAME,PASSWORD,ROLE,STATUS,DATE) " +
                                    "VALUES(@USERN,@PASS,@ROLE,@STATUS,@DATE)";
                                using (SqlCommand insert = new SqlCommand(insertData, connect))
                                {
                                    insert.Parameters.AddWithValue("@USERN", register_Username.Text.Trim());
                                    insert.Parameters.AddWithValue("@PASS", register_Password.Text.Trim());
                                    insert.Parameters.AddWithValue("@ROLE", "User");
                                    insert.Parameters.AddWithValue("@STATUS", "Approval");
                                    DateTime today = DateTime.Now;
                                    insert.Parameters.AddWithValue("@DATE", today);
                                    insert.ExecuteNonQuery();
                                    MessageBox.Show("Register successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    LoginForm loginForm = new LoginForm();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("WHart");
                        MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
                return true;
            return false;
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
    }
}
