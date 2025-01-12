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

namespace RestaurantBooking.Widget
{
    public partial class RestaurentsSearchWidget : UserControl
    {
        private RESTAURANT _mainRes;
        public RestaurentsSearchWidget()
        {
            InitializeComponent();
        }
        private void RoundCornersForControl(Control control)
        {
            GraphicsPath path = new GraphicsPath();

            int radius = 20;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius - 1, control.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius - 1, radius, radius, 90, 90);

            path.CloseFigure();

            control.Region = new System.Drawing.Region(path);
        }
        private void RestaurentsControl_Load(object sender, EventArgs e)
        {
            RoundCornersForControl(this);
        }

        private void RestaurentsSearchControl_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem parent form có phải là MainForm không
                if (!(ParentForm is MainForm mainForm))
                {
                    MessageBox.Show("Cannot access main form", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra sender là RestaurantControl và Tag có phải là RESTAURANT
                if (sender is RestaurentsSearchWidget control)
                {
                    if (control.Tag is RESTAURANT selectedRestaurant)
                    {
                        // Cập nhật nhà hàng chính
                        _mainRes = selectedRestaurant;

                        // Kiểm tra các control có tồn tại không trước khi thay đổi visibility
                        if (mainForm.restaurantControl != null && mainForm.searchControl != null)
                        {
                            // Chuyển đổi visibility
                            mainForm.restaurantControl.Visible = true;
                            mainForm.searchControl.Visible = false;

                            // Cập nhật control với dữ liệu nhà hàng đã chọn
                            mainForm.restaurantControl.LoadRestaurantData(selectedRestaurant);
                            mainForm.restaurantControl.PopulateRestaurants(selectedRestaurant);
                        }
                        else
                        {
                            MessageBox.Show("Required controls are not initialized", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No restaurant selected or Tag is invalid", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Sender is not a RestaurantControl", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error switching to restaurant view: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Ghi lại lỗi nếu cần
            }
        }
    }
}
