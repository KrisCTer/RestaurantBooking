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
        public static RESTAURANT _mainRes;
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
                    ItemWidget itemControl = new ItemWidget();

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
            _mainRes = restaurant;
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
            BookingDate bookingDate = new BookingDate();
            bookingDate.ShowDialog();
            Confirm confirm = new Confirm();
            confirm.labelDate.Text = bookingDate.select_Date.Text;
            confirm.labelTime.Text = bookingDate.select_Time.Text;
            confirm.labelPeople.Text = bookingDate.select_People.Text;
            confirm.labelBooker.Text = MainForm._mainUser.NAME;
            confirm.labelNameRes.Text = labelNameRes.Text;
            confirm.ShowDialog();
        }
        public static string GetMainRes()
        {
            return _mainRes.ID_RES;
        }
    }
}
