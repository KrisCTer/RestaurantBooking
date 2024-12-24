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

namespace RestaurantBooking
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MakePictureBoxCircular(pictureBox);
        }
        private void MakePictureBoxCircular(PictureBox pictureBox)
        {
            // Tạo một hình tròn với kích thước của PictureBox
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);

            // Áp dụng hình tròn vào thuộc tính Region của PictureBox
            pictureBox.Region = new Region(path);
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
            LoginForm registerForm = new LoginForm();
            registerForm.Show();
            this.Hide();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            int borderWidth = 5; // Độ rộng viền
            Color borderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(177))))); // Màu viền

            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawEllipse(pen, borderWidth / 2, borderWidth / 2,
                    pictureBox.Width - borderWidth, pictureBox.Height - borderWidth);
            }
        }
    }
}
