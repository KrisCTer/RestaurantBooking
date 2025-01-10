using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using RestaurantBooking.BUS;
using RestaurantBooking.DAL.Entities;
using RestaurantBooking.Widget;

namespace RestaurantBooking
{
    public partial class RestaurantControl : UserControl
    {
        private readonly RestaurantService _restaurantService = new RestaurantService();
        private readonly UserService _userService = new UserService();
        RESTAURANT mainRes;
        public RestaurantControl()
        {
            InitializeComponent();
        }
        public void PopulateRestaurants(RESTAURANT mainRes)
        {
            try
            {
                // Lấy danh sách các món ăn
                List<MENUITEM> menuItems = _restaurantService.listItem(mainRes);

                // Xóa các điều khiển cũ trong panelMenuItem
                panelMenuItem.Controls.Clear();

                foreach (MENUITEM item in menuItems)
                {
                    // Tạo một ItemControl để hiển thị thông tin món ăn
                    ItemControl itemControl = new ItemControl();

                    // Cập nhật thông tin món ăn vào ItemControl
                    itemControl.labelNameItem.Text = item.ITEM;  // Giả sử 'ITEM' là tên món ăn
                    itemControl.labelPriceItem.Text = $"${item.PRICE:F2}";  // Giả sử 'PRICE' là giá của món ăn

                    // Tạo và cập nhật các thông tin khác nếu cần, ví dụ:
                    itemControl.Tag = item;  // Đặt thông tin món ăn vào Tag để có thể sử dụng sau này

                    // Thêm ItemControl vào panelMenuItem
                    panelMenuItem.Controls.Add(itemControl);
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có sự cố
                //MessageBox.Show($"Lỗi khi tải dữ liệu món ăn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void register_Back_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)ParentForm;
            mainForm.restaurantControl.Visible = false;
            mainForm.searchControl.Visible = true;
        }
        public void LoadRestaurantData(RESTAURANT restaurant)
        {
            if (restaurant == null) return;
            restaurant.PRICE = _restaurantService.GetAveratePrice(restaurant);
            // Hiển thị thông tin nhà hàng lên giao diện
            labelNameRes.Text = restaurant.NAME; // TextBox hiển thị tên nhà hàng
            labelLocation.Text = restaurant.LOCATION; // TextBox hiển thị vị trí
            labelPhone.Text = restaurant.PHONE; // TextBox hiển thị số điện thoại
            labelBio.Text = restaurant.BIO; // Nếu có mô tả
            labelDetail.Text = restaurant.DETAIL; // Nếu có chi tiết
            labelPrice.Text = Convert.ToDouble(restaurant.PRICE).ToString("F2"); // TextBox hiển thị giá
            labelOpenning.Text = restaurant.OPEN.ToString("HH:mm"); // TextBox hiển thị giờ mở cửa
            labelClosing.Text = restaurant.CLOSE.ToString("HH:mm"); // TextBox hiển thị giờ đóng cửa

            LoadAvatar(restaurant.ID_RES);
            mainRes = restaurant;
        }
        private void LoadAvatar(string idRestaurant)
        {
            // Tên file ảnh dựa trên ID nhà hàng
            string fileName = $"{idRestaurant}.jpg";

            // 1. Kiểm tra ảnh trong Resources
            var resourceImage = GetImageFromResources(fileName);
            if (resourceImage != null)
            {
                pictureBoxRestaurant.Image = resourceImage;
                return;
            }

            // 2. Nếu không có trong Resources, kiểm tra thư mục `ImagesRestaurant`
            string folderPath = Path.Combine(Application.StartupPath, "ImagesRestaurant");
            string imagePath = Path.Combine(folderPath, fileName);

            if (File.Exists(imagePath))
            {
                pictureBoxRestaurant.Image = Image.FromFile(imagePath);
            }
            else
            {
                // 3. Nếu không tìm thấy ảnh, sử dụng ảnh mặc định
                pictureBoxRestaurant.Image = Properties.Resources.default_image; // Ảnh mặc định
                MessageBox.Show("Không tìm thấy ảnh nhà hàng.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Image GetImageFromResources(string fileName)
        {
            // Lấy danh sách tên file trong Resources
            var resourceManager = Properties.Resources.ResourceManager;
            var resourceSet = resourceManager.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, true, true);

            foreach (System.Collections.DictionaryEntry resource in resourceSet)
            {
                if (resource.Key.ToString().Equals(Path.GetFileNameWithoutExtension(fileName), StringComparison.OrdinalIgnoreCase))
                {
                    return (Image)resource.Value;
                }
            }

            return null; // Không tìm thấy trong Resources
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            try
            {
                // Show date selection dialog
                using (var bookingDate = new bookingDate())
                {
                    if (bookingDate.ShowDialog() != DialogResult.OK)
                    {
                        return; // User cancelled
                    }

                    // Extract and validate the values
                    string date = ExtractLastValue(bookingDate.select_Date.Text);
                    string people = ExtractLastValue(bookingDate.select_People.Text);
                    string time = ExtractLastValue(bookingDate.select_Time.Text);

                    // Validate inputs
                    if (string.IsNullOrEmpty(date) || string.IsNullOrEmpty(time) || string.IsNullOrEmpty(people))
                    {
                        throw new ArgumentException("Please select all required fields (date, time, and number of people).");
                    }

                    // Parse the date and time
                    if (!DateTime.TryParseExact(
                        $"{DateTime.Now.Year}-{date.Trim()} {time.Trim()}",
                        "yyyy-MM-dd HH:mm",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out DateTime reservationDate))
                    {
                        throw new FormatException("Invalid date or time format.");
                    }

                    // Validate reservation is not in the past
                    if (reservationDate < DateTime.Now)
                    {
                        throw new ArgumentException("Reservation date cannot be in the past.");
                    }

                    // Validate number of guests
                    if (!int.TryParse(people, out int numberOfGuests) || numberOfGuests <= 0)
                    {
                        throw new ArgumentException("Please enter a valid number of guests.");
                    }

                    // Create new reservation
                    var reservation = new RESERVATION
                    {
                        ID_RESERVATION = _userService.GetNextReservationId(),
                        ID_RES = mainRes.ID_RES,
                        ID_USER = MainForm._mainUser.ID_USER,
                        DATE_RESERVATION = reservationDate,
                        NUMBERS_OF_GUEST = numberOfGuests,
                        NOTE = "Reserved through application"
                    };

                    // Save to database
                    _userService.AddReservation(reservation);
                    MessageBox.Show(
                        $"Reservation successful!\nDate: {date}\nTime: {time}\nPeople: {people}",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error making reservation: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Helper method to safely extract the last value after a space
        private string ExtractLastValue(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            int lastSpaceIndex = input.LastIndexOf(' ');
            return lastSpaceIndex >= 0 ? input.Substring(lastSpaceIndex + 1).Trim() : input.Trim();
        }
    }
}
