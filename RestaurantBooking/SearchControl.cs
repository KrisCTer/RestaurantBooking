using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantBooking.Entities;
using RestaurantBooking.Widget;

namespace RestaurantBooking
{
    public partial class SearchControl : UserControl
    {
        public SearchControl()
        {
            InitializeComponent();
            PopulateRestaurants();
            this.Load += SearchControl_Load;
        }

        private void SearchControl_Load(object sender, EventArgs e)
        {
            string currentDate = "Date: " + DateTime.Now.ToString("dd-MM");
            string currentTime = "Time: " + DateTime.Now.ToString("HH:mm");
            this.MyReservations_Date.Text = currentDate;
            this.MyReservations_Time.Text = currentTime;
        }
        private void PopulateRestaurants()
        {
            try
            {
                using (var context = new RestaurantBookingDB())
                {
                    List<RESTAURANT> restaurants = context.RESTAURANTs.ToList();
                    CountRes.Text = restaurants.Count.ToString() + " Restaurants";
                    foreach (RESTAURANT restaurant in restaurants)
                    {
                        RestaurentsControl restaurantControl = new RestaurentsControl();

                        restaurantControl.txtNameRes.Text = restaurant.NAME;
                        restaurantControl.txtLocationRes.Text = restaurant.LOCATION;

                        panelRes.Controls.Add(restaurantControl);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu nhà hàng: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void panelRes_Resize(object sender, EventArgs e)
        {
            foreach (Control control in panelRes.Controls)
            {
                if (control is RestaurentsControl)
                {
                    control.Width = panelRes.Width - 20;
                }
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtSearch.Text.Trim().ToLower();
            foreach (Control control in panelRes.Controls)
            {
                var txtNameRes = control.Controls.Find("txtNameRes", true).FirstOrDefault();
                control.Visible = txtNameRes != null &&
                                 txtNameRes.Text.ToLower().Contains(filterText);
            }
        }

        private void panel2_DoubleClick(object sender, EventArgs e)
        {
            bookingDate bookingDate = new bookingDate();
            bookingDate.Show();
        }
    }
}

