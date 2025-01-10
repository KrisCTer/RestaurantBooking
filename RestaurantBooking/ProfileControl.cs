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
using RestaurantBooking.BUS;

namespace RestaurantBooking
{
    public partial class ProfileControl : UserControl
    {
        private readonly UserService _userService = new UserService();
        private string _avatarPath;
        public ProfileControl()
        {
            InitializeComponent();

        }
        private void LoadProfile()
        {
            if (MainForm._mainUser == null) return;
            var user = _userService.GetUser(MainForm._mainUser.ID_USER);
            Profile_Name.Text = user.NAME;
            Profile_Bio.Text = user.BIO;
            Profile_Email.Text = user.EMAIL;
            Profile_Phone.Text = user.PHONE;
            Profile_Address.Text = user.ADDRESS;
            Profile_Gender.Text = user.GENDER;
            if (user.BIRTHDAY.HasValue)
            {
                DateTime dateTime = user.BIRTHDAY.Value;
                Profile_Birthday.Value = dateTime;
            }
            Profile_Password.Text = user.PASSWORD;
            Profile_Password.PasswordChar = '*';

            LoadAvatar();
        }
        private void LoadAvatar()
        {
            try
            {
                // Đường dẫn ảnh đại diện của user hiện tại
                string imagePath = Path.Combine(Application.StartupPath, "ImagesUser", $"{MainForm._mainUser.ID_USER}.jpg");

                if (File.Exists(imagePath))
                {
                    // Mở tệp ảnh và gán vào PictureBox
                    using (var stream = File.OpenRead(imagePath))
                    using (var img = Image.FromStream(stream))
                    {
                        pictureBox.Image?.Dispose(); // Giải phóng ảnh cũ nếu có
                        pictureBox.Image = new Bitmap(img); // Gán ảnh mới
                    }
                }
                else
                {
                    // Ảnh không tồn tại, hiển thị ảnh mặc định
                    pictureBox.Image?.Dispose();
                    pictureBox.Image = Properties.Resources.user; // Sử dụng ảnh mặc định từ Resources
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải ảnh đại diện: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ProfileControl_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }

        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _avatarPath = openFileDialog.FileName;
                    pictureBox.Image = Image.FromFile(_avatarPath);
                }
            }
        }
        private void Profile_Save_Click(object sender, EventArgs e)
        {
            //kiểm tra tính bắt buộc
            if (string.IsNullOrEmpty(Profile_Name.Text) ||
                string.IsNullOrEmpty(Profile_Email.Text) ||
                string.IsNullOrEmpty(Profile_Address.Text) ||
                string.IsNullOrEmpty(Profile_Phone.Text))
            {
                MessageBox.Show("Please fill in all the required information");
                return;
            }

            try
            {
                var user = _userService.GetUser(MainForm._mainUser.ID_USER);
                if (user == null) return;

                user.NAME = Profile_Name.Text;
                user.BIO = Profile_Bio.Text;
                user.EMAIL = Profile_Email.Text;
                user.PHONE = Profile_Phone.Text;
                user.ADDRESS = Profile_Address.Text;
                user.GENDER = Profile_Gender.Text;
                user.BIRTHDAY = DateTime.Parse(Profile_Birthday.Text);
                user.PASSWORD = Profile_Password.Text;
                if (!string.IsNullOrEmpty(_avatarPath))
                {
                    string avatarFileName = SaveAvatar(_avatarPath, MainForm._mainUser.ID_USER);
                    if (!string.IsNullOrEmpty(avatarFileName))
                    {
                        user.AVATAR = avatarFileName;
                    }
                }
                _userService.saveUser(user);
                MessageBox.Show("Profile updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}");
            }
        }
        private string SaveAvatar(string sourceFilePath, string studentID)
        {
            try
            {
                string folderPath = Path.Combine(Application.StartupPath, "ImagesUser");
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                string fileExtension = Path.GetExtension(sourceFilePath);
                string targetFilePath = Path.Combine(folderPath, $"{studentID}{fileExtension}");
                if (!File.Exists(sourceFilePath))
                {
                    throw new FileNotFoundException($"File not found: {sourceFilePath}");
                }
                File.Copy(sourceFilePath, targetFilePath, true);
                return $"{studentID}{fileExtension}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving avatar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public void RefreshProfileData()
        {
            if (MainForm._mainUser != null)
            {
                LoadProfile();
            }
        }
    }
}
