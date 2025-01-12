using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantBooking.BUS;
using RestaurantBooking.DAL.Entities;

namespace RestaurantBooking
{
    public partial class Confirm : Form
    {
        private readonly RestaurantService _restaurantService = new RestaurantService();
        private readonly UserService _userService = new UserService();
        public Confirm()
        {
            InitializeComponent();
        }
        private void LoadView()
        {

        }
        private void btnComfirm_Click(object sender, EventArgs e)
        {
            try
            {

                string labelDateText = labelDate.Text;  // e.g., "12-01"
                string labelTimeText = labelTime.Text;  // e.g., "14:30"

                // Combine the date string with the current year to form "MM-dd-yyyy"
                string fullDateString = labelDateText + "-" + DateTime.Now.Year.ToString();  // Example: "12-01-2025"

                // Parse the full date string (ensure the correct format "MM-dd-yyyy")
                DateTime date = DateTime.ParseExact(fullDateString, "dd-MM-yyyy", CultureInfo.InvariantCulture);

                // Parse the time string into a TimeSpan (assuming the time is in "HH:mm" format)
                TimeSpan time = TimeSpan.Parse(labelTimeText);  // Example: "14:30"

                // Combine the date and time into a single DateTime
                DateTime reservationDateTime = date.Date.Add(time);

                // Format the resulting DateTime as "dd-MM-yyyy HH:mm"
                string formattedDateTime = reservationDateTime.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);

                reservationDateTime = DateTime.ParseExact(formattedDateTime, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);

                // Chuyển đổi số khách từ string sang int
                int numberOfGuests;
                if (!int.TryParse(labelPeople.Text, out numberOfGuests))
                {
                    MessageBox.Show("Số lượng khách không hợp lệ!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                RESERVATION newReservation = new RESERVATION
                {
                    ID_RESERVATION = _userService.GetNextReservationId(),
                    ID_RES = RestaurantControl.GetMainRes(), // Giả sử đã sửa thành phương thức static
                    ID_USER = MainForm._mainUser.ID_USER,
                    DATE_RESERVATION = reservationDateTime,
                    NUMBERS_OF_GUEST = numberOfGuests,
                    NOTE = txtNote.Text
                };

                // Kiểm tra dữ liệu
                if (string.IsNullOrEmpty(newReservation.ID_RES) ||
                    string.IsNullOrEmpty(newReservation.ID_USER))
                {
                    MessageBox.Show("ID_RES và ID_USER không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (newReservation.ID_RES.Length > 10 || newReservation.ID_USER.Length > 5)
                {
                    MessageBox.Show("ID_RES không được quá 10 ký tự và ID_USER không được quá 5 ký tự!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra khóa chính đã tồn tại chưa
                var exists = _userService.CheckReservation(newReservation);
                if (exists)
                {
                    MessageBox.Show("Đã tồn tại bản ghi với các ID này!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Thêm vào database
                _userService.AddReservation(newReservation);
                MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
