using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace RestaurantBooking
{
    public partial class CustomControl : UserControl
    {
        private int currentIndex = 0;
        private List<Image> images = new List<Image>();
        public CustomControl()
        {
            InitializeComponent();
            InitializeImageSlider();
        }

        private void InitializeImageSlider()
        {
            // Add images to the list
            images.Add(Properties.Resources.Pic1);
            images.Add(Properties.Resources.Pic2);
            images.Add(Properties.Resources.Pic3);
            images.Add(Properties.Resources.Pic4);
            images.Add(Properties.Resources.Pic5);

            if (images.Count == 0)
            {
                MessageBox.Show("Danh sách ảnh trống!", "Thông báo");
                return;
            }

            // Set up the Timer
            timerPic.Interval = 3000; // Time interval for image change (1000ms = 1 second)
            timerPic.Tick += Timer_Tick;
            timerPic.Start();

            // Display the first image
            ShowImage(currentIndex);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Increment the current image index
            currentIndex++;
            if (currentIndex >= images.Count)
            {
                currentIndex = 0; // Go back to the first image if the list is exhausted
            }

            // Show the new image
            ShowImage(currentIndex);
        }

        private void ShowImage(int index)
        {
            // Remove old PictureBox from the Panel
            panel.Controls.Clear();

            // Create a new PictureBox to display the current image
            PictureBox pictureBox = new PictureBox
            {
                Image = images[index],
                SizeMode = PictureBoxSizeMode.StretchImage, // Adjust the display mode
                Dock = DockStyle.Fill // Fill the Panel area
            };

            // Add the PictureBox to the Panel
            panel.Controls.Add(pictureBox);
        }

        private void ImageSwitchTimer_Tick(object sender, EventArgs e)
        {
            // Switch to the next image
            currentIndex++;
            if (currentIndex >= images.Count)
            {
                currentIndex = 0; // Go back to the first image
            }

            ShowImage(currentIndex);
        }
        public void StopTimer()
        {
            timerPic.Stop();
        }
        public void StartTimer()
        {
            timerPic.Start();
        }
    }
}
