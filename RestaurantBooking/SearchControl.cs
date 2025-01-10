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
using RestaurantBooking.BUS;
using RestaurantBooking.DAL.Entities;
using RestaurantBooking.Widget;

namespace RestaurantBooking
{
    public partial class SearchControl : UserControl
    {
        private readonly RestaurantService _restaurantService = new RestaurantService();
        public readonly RESTAURANT _mainRes;
        public SearchControl()
        {
            InitializeComponent();
            PopulateRestaurants();
        }

        private void SearchControl_Load(object sender, EventArgs e)
        {
            setDefault();
        }
        private void PopulateRestaurants()
        {
            try
            {
                panelRes.SuspendLayout();
                List<RESTAURANT> restaurants = _restaurantService.ListRestaurant();
                CountRes.Text = restaurants.Count.ToString() + " Restaurants";
                panelRes.Controls.Clear();

                foreach (RESTAURANT restaurant in restaurants)
                {
                    RestaurentsSearchControl restaurantControl = new RestaurentsSearchControl();

                    restaurantControl.txtNameRes.Text = restaurant.NAME;
                    restaurantControl.txtLocationRes.Text = restaurant.LOCATION;

                    restaurantControl.Tag = restaurant;

                    panelRes.Controls.Add(restaurantControl);
                }
                panelRes.ResumeLayout();
                panelRes.PerformLayout();
            }

            catch (Exception ex)
            {
                //MessageBox.Show($"Lỗi khi tải dữ liệu nhà hàng: {ex.Message}", "Lỗi",
                //    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void panelRes_Resize(object sender, EventArgs e)
        {
            foreach (Control control in panelRes.Controls)
            {
                if (control is RestaurentsSearchControl)
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
                CountRes.Text = panelRes.Controls.OfType<RestaurentsSearchControl>()
                    .Count(c => c.Visible).ToString() + " Restaurants";
            }
            buttonCancelSearch.Visible = !string.IsNullOrEmpty(filterText);
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            bookingDate bookingDate = new bookingDate();
            bookingDate.ShowDialog();
            MyReservations_Date.Text = bookingDate.select_Date.Text;
            MyReservations_People.Text = bookingDate.select_People.Text;
            MyReservations_Time.Text = bookingDate.select_Time.Text;
            FilterControlsOnPanelRes(bookingDate.select_Date.Text, bookingDate.select_People.Text, bookingDate.select_Time.Text.Substring(bookingDate.select_Time.Text.LastIndexOf(" ")));
            this.buttonCancelCalendar.Visible = true;
        }

        private void FilterControlsOnPanelRes(string date, string people, string time)
        {
            if (!TimeSpan.TryParse(time, out TimeSpan selectedTime))
            //!int.TryParse(people, out int peopleCount) ||
            //!DateTime.TryParse(date, out DateTime selectedDate))
            {
                MessageBox.Show("Invalid input format");
                return;
            }

            foreach (Control control in panelRes.Controls)
            {
                if (control.Tag is RESTAURANT restaurant)
                {
                    bool matchesTime = restaurant.OPEN.TimeOfDay <= selectedTime &&
                                      restaurant.CLOSE.TimeOfDay >= selectedTime;
                    //bool matchesCapacity = restaurant.CAPACITY >= peopleCount;
                    //bool matchesDate = !restaurant.BOOKED_DATES.Contains(selectedDate);

                    control.Visible = matchesTime;//&& matchesCapacity && matchesDate;
                }
                else
                {
                    control.Visible = false;
                }
            }

            CountRes.Text = $"{panelRes.Controls.OfType<RestaurentsSearchControl>().Count(c => c.Visible)} Restaurants";
        }
        public void RefreshSearchData()
        {
            if (MainForm._mainUser != null)
            {
                setDefault();
                PopulateRestaurants();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            RefreshSearchData();
            buttonCancelCalendar.Visible = false;
        }
        private void setDefault()
        {
            MyReservations_Date.Text = "Date " + DateTime.Now.ToString("dd-MM");
            MyReservations_Time.Text = "Time " + DateTime.Now.ToString("HH:mm");
            MyReservations_People.Text = "People 2";
        }

        private void buttonCancelSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            buttonCancelSearch.Visible = false;
        }

        private void buttonRegion_Click(object sender, EventArgs e)
        {

        }

        private void buttonPrice_Click(object sender, EventArgs e)
        {

        }

        private void buttonAtmosphere_Click(object sender, EventArgs e)
        {

        }
    }
}

