using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantBooking
{
    public partial class LoginOrSignupControl : UserControl
    {
        public MainForm _mainForm;
        public LoginOrSignupControl()
        {
            InitializeComponent();
        }
        private void LOS_LoginSignup_Click(object sender, EventArgs e)
        {
            LoginForm formLogin = new LoginForm(_mainForm);
            formLogin.Show();
            _mainForm.Hide();
            this.Hide();
        }
    }
}
