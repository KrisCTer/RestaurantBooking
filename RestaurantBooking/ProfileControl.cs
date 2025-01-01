using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantBooking
{
    public partial class ProfileControl : UserControl
    {
        private string avatarPath = string.Empty;
        private int _user;
        public ProfileControl()
        {
            InitializeComponent();
            //_user = ID_User;
        }
        private void pictureBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Store the selected file path
                        avatarPath = ofd.FileName;

                        // Load the new image into pictureBox
                        if (pictureBox.Image != null)
                        {
                            pictureBox.Image.Dispose();
                        }
                        pictureBox.Image = Image.FromFile(avatarPath);

                        // Save the avatar
                        string folderPath = Path.Combine(Application.StartupPath, "Images");
                        if (!Directory.Exists(folderPath))
                            Directory.CreateDirectory(folderPath);

                        string fileName = _user.ToString() + ".jpg";
                        string filePath = Path.Combine(folderPath, fileName);

                        // Delete existing file if it exists
                        if (File.Exists(filePath))
                            File.Delete(filePath);

                        // Save the new image
                        pictureBox.Image.Save(filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error processing image: " + ex.Message);
                    }
                }
            }
        }

        private void Profile_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Profile_Name.Text) || string.IsNullOrEmpty(Profile_Email.Text) || string.IsNullOrEmpty(Profile_Address.Text))
            {
                MessageBox.Show("Please fill in all required fields");
                return;
            }
        }

        //private void ProfileControl_Load(object sender, EventArgs e)
        //{
        //    using (var context = new Model1())
        //    {
        //        //PROFILE profile = context.PROFILEs.Find(_user);
        //        //USER user = context.USERs.Find(_user);

        //        if (profile != null && user != null)
        //        {
        //            // Load text fields
        //            Profile_Name.Text = profile.NAME;
        //            Profile_Bio.Text = profile.BIO;
        //            Profile_Email.Text = user.EMAIL;
        //            Profile_Address.Text = profile.ADDRESS;
        //            Profile_Password.Text = user.PASSWORD;

        //            // Load avatar image
        //            _user = user.ID_USER;
        //            string folderPath = Path.Combine(Application.StartupPath, "Images");
        //            string fileName = _user + ".jpg";
        //            string filePath = Path.Combine(folderPath, fileName);

        //            try
        //            {
        //                if (File.Exists(filePath))
        //                {
        //                    if (pictureBox.Image != null)
        //                    {
        //                        pictureBox.Image.Dispose();
        //                    }
        //                    pictureBox.Image = Image.FromFile(filePath);
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Error loading profile image: " + ex.Message);
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Profile or user data not found.");
        //        }
        //    }
        //}
    }
}
