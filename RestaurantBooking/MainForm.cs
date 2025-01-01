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
using RestaurantBooking.Entities;

namespace RestaurantBooking
{
    public partial class MainForm : Form
    {
        public USER mainUser;
        public MainForm()
        {
            InitializeComponent();
            Image roundedImage = RoundImage(pictureBox.Image, 200, 200);

            pictureBox.Image = roundedImage;
        }
        public void SetMainUser(USER user)
        {
            mainUser = user;
            wellcome.Text = "Welcome " + (mainUser != null ? mainUser.USERNAME : "Guest");
        }
        private Image RoundImage(Image originalImage, int size, int radius)
        {
            Bitmap roundedImage = new Bitmap(size, size);

            using (Graphics g = Graphics.FromImage(roundedImage))
            {
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, size, size);

                Region region = new Region(path);

                g.SetClip(region, CombineMode.Replace);

                g.DrawImage(originalImage, new Rectangle(0, 0, size, size));
            }

            return roundedImage;
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

        private void buttonHome_Click(object sender, EventArgs e)
        {
            LoginForm registerForm = new LoginForm(this);
            registerForm.Show();
            this.Hide();
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
        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            if (mainUser != null)
            {
                //profileControl.Visible = true;
                //loginOrSignupControl.Visible = true;
                //myReservationsControl.Visible = false;
            }
            else
            {
                //profileControl.Visible = false;
                //loginOrSignupControl.Visible = false;
                //myReservationsControl.Visible = false;
            }
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            //profileControl.Visible = false;
            //loginOrSignupControl.Visible = false;
            //myReservationsControl.Visible = true;
        }

        private void buttonReview_Click(object sender, EventArgs e)
        {

        }
    }
}
