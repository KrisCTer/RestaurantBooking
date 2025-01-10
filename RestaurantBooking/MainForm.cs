using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantBooking.DAL.Entities;

namespace RestaurantBooking
{
    public partial class MainForm : Form
    {
        public static USER _mainUser = null;
        public MainForm()
        {
            InitializeComponent();
            this.loginOrSignupControl._mainForm = this;
        }
        public void SetMainUser(USER user)
        {
            _mainUser = user;
            wellcome.Text = "Welcome " + (_mainUser != null ? _mainUser.USERNAME : "Guest");
        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Color myColorClick = ColorTranslator.FromHtml("#7e121d");
            if (sender == buttonHome)
                buttonHome.BackColor = myColorClick;
            if (sender == buttonSearch)
                buttonSearch.BackColor = myColorClick;
            if (sender == buttonReservation)
                buttonReservation.BackColor = myColorClick;
            if (sender == buttonReview)
                buttonReview.BackColor = myColorClick;
            if (sender == buttonProfile)
                buttonProfile.BackColor = myColorClick;
            if (sender == buttonLogout)
                buttonLogout.BackColor = myColorClick;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Color myColorClick = ColorTranslator.FromHtml("#034f1b");
            if (sender == buttonHome)
                buttonHome.BackColor = myColorClick;
            if (sender == buttonSearch)
                buttonSearch.BackColor = myColorClick;
            if (sender == buttonReservation)
                buttonReservation.BackColor = myColorClick;
            if (sender == buttonReview)
                buttonReview.BackColor = myColorClick;
            if (sender == buttonProfile)
                buttonProfile.BackColor = myColorClick;
            if (sender == buttonLogout)
                buttonLogout.BackColor = myColorClick;
        }
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {

            {
                int borderWidth = 5;
                Color borderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(177))))); // Màu viền

                using (Pen pen = new Pen(borderColor, borderWidth))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawEllipse(pen, borderWidth / 2, borderWidth / 2,
                        pictureBox.Width - borderWidth, pictureBox.Height - borderWidth);
                }
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (_mainUser == null)
            {
                loginOrSignupControl.Visible = true;
                homeControl.Visible = false;
                searchControl.Visible = false;
                myRevervationControl.Visible = false;

                profileControl.Visible = false;
            }
            else
            {
                if (sender == buttonHome)
                {
                    loginOrSignupControl.Visible = false;
                    homeControl.Visible = true;
                    searchControl.Visible = false;
                    myRevervationControl.Visible = false;

                    profileControl.Visible = false;
                    restaurantControl.Visible = false;
                }
                if (sender == buttonSearch)
                {
                    loginOrSignupControl.Visible = false;
                    homeControl.Visible = false;
                    searchControl.RefreshSearchData();
                    searchControl.Visible = true;
                    myRevervationControl.Visible = false;

                    profileControl.Visible = false;
                    restaurantControl.Visible = false;
                }
                if (sender == buttonReservation)
                {
                    loginOrSignupControl.Visible = false;
                    homeControl.Visible = false;
                    searchControl.Visible = false;
                    myRevervationControl.RefreshReservationData();
                    myRevervationControl.Visible = true;

                    profileControl.Visible = false;
                    restaurantControl.Visible = false;
                }
                if (sender == buttonReview)
                {
                    loginOrSignupControl.Visible = false;
                    homeControl.Visible = false;
                    searchControl.Visible = false;
                    myRevervationControl.Visible = false;

                    profileControl.Visible = false;
                    restaurantControl.Visible = false;
                }
                if (sender == buttonProfile)
                {
                    loginOrSignupControl.Visible = false;
                    homeControl.Visible = false;
                    searchControl.Visible = false;
                    myRevervationControl.Visible = false;

                    profileControl.RefreshProfileData();
                    profileControl.Visible = true;
                    restaurantControl.Visible = false;
                }
            }
        }


        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (_mainUser == null)
            {
                MessageBox.Show("You are not logged in", "Log out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
                _mainUser = null;
                wellcome.Text = "Welcome Guest";
                loginOrSignupControl.Visible = true;
                homeControl.Visible = false;
                searchControl.Visible = false;
                //searchControl.
                myRevervationControl.Visible = false;

                profileControl.Visible = false;
            }
        }
    }
}
