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
                    RestaurentsSearchWidget restaurantControl = new RestaurentsSearchWidget();

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
                if (control is RestaurentsSearchWidget)
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
                CountRes.Text = panelRes.Controls.OfType<RestaurentsSearchWidget>()
                    .Count(c => c.Visible).ToString() + " Restaurants";
            }
            buttonCancelSearch.Visible = !string.IsNullOrEmpty(filterText);
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            BookingDate bookingDate = new BookingDate();
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

            CountRes.Text = $"{panelRes.Controls.OfType<RestaurentsSearchWidget>().Count(c => c.Visible)} Restaurants";
        }
        private void FilterControlsOnPanelRes(SearchResult searchResult)
        {
            foreach (Control control in panelRes.Controls)
            {
                if (control.Tag is RESTAURANT restaurant)
                {
                    bool isVisible = true;

                    // Lọc theo Location
                    if (searchResult.SelectedLocations.Any())
                    {
                        isVisible = isVisible && searchResult.SelectedLocations.Contains(restaurant.LOCATION);
                    }

                    // Lọc theo Price
                    if (searchResult.MinPrice > 0 || searchResult.MaxPrice < 1000)
                    {
                        double restaurantPrice = restaurant.PRICE.GetValueOrDefault(); // Sử dụng giá từ RESTAURANT object
                        isVisible = isVisible && (restaurantPrice >= searchResult.MinPrice && restaurantPrice <= searchResult.MaxPrice);
                    }

                    // Lọc theo Services (Atmosphere)
                    if (searchResult.SelectedServices.Any())
                    {
                        bool hasMatchingService = false;
                        foreach (string selectedService in searchResult.SelectedServices)
                        {
                            // Giả sử RESTAURANT có property SERVICES là List<string> hoặc có quan hệ với bảng SERVICE
                            if (restaurant.SERVICEs.Any(s => s.NAME_SER == selectedService))
                            {
                                hasMatchingService = true;
                                break;
                            }
                        }
                        isVisible = isVisible && hasMatchingService;
                    }
                    control.Visible = isVisible;
                }
                else
                {
                    control.Visible = false;
                }
            }

            // Cập nhật số lượng nhà hàng hiển thị
            CountRes.Text = $"{panelRes.Controls.Cast<Control>().Count(c => c.Visible)} Restaurants";
            buttonCancel.Visible = searchResult.SelectedLocations.Any() || searchResult.SelectedServices.Any() || searchResult.MinPrice > 0 || searchResult.MaxPrice < 1000;
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
            buttonCancel.Visible = false;
        }
        private void setDefault()
        {
            MyReservations_Date.Text = "Date " + DateTime.Now.ToString("dd-MM");
            MyReservations_Time.Text = "Time " + DateTime.Now.ToString("HH:mm");
            MyReservations_People.Text = "People 2";
            txtSearch.Text = "";
            buttonCancelSearch.Visible = false;
            buttonCancel.Visible = false;
            buttonCancelCalendar.Visible = false;
        }

        private void buttonCancelSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            buttonCancelSearch.Visible = false;
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            var searchResult = new SearchResult();
            searchResult._mainButton = sender as Button;
            searchResult.ShowDialog();
            FilterControlsOnPanelRes(searchResult);
        }
    }
}

