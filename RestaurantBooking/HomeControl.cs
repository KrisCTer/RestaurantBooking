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
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.FindForm();
            mainForm.homeControl.Visible = false;
            mainForm.searchControl.Visible = true;
            mainForm.myRevervationControl.Visible = false;
            mainForm.reviewControl.Visible = false;
            mainForm.profileControl.Visible = false;
            mainForm.loginOrSignupControl.Visible = false;
            mainForm.restaurantControl.Visible = false;
        }
        public void StopTimerHome()
        {
            customControl.StopTimer();
        }
        public void StartTimerHome()
        {
            customControl.StartTimer();
        }
    }
}
