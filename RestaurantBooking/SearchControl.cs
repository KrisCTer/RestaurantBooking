using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantBooking.Widget;

namespace RestaurantBooking
{
    public partial class SearchControl : UserControl
    {
        public SearchControl()
        {
            InitializeComponent();
            this.Load += SearchControl_Load;
        }

        private void SearchControl_Load(object sender, EventArgs e)
        {
            string currentDate = DateTime.Now.ToString("dd-MM");
            string currentTime = DateTime.Now.ToString("HH:mm");
            this.MyReservations_Date.Text = currentDate;
            this.MyReservations_Time.Text = currentTime;
        }
    }
}
