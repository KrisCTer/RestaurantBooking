using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantBooking.BUS;
using RestaurantBooking.DAL.Entities;
using RestaurantBooking.Properties;
using RestaurantBooking.Widget;

namespace RestaurantBooking
{
    public partial class ReviewControl : UserControl
    {
        private readonly UserService _userService = new UserService();
        public ReviewControl()
        {
            InitializeComponent();
        }
        private void ReviewControl_Load(object sender, EventArgs e)
        {
            LoadReview();
        }
        private void LoadReview()
        {
            try
            {
                List<REVIEW> reservations = _userService.listReviews();
                panelRes.SuspendLayout();
                panelRes.Controls.Clear();
                foreach (REVIEW reservation in reservations)
                {
                    ReviewWidget ReviewWidgetCard = new ReviewWidget();
                    ReviewWidgetCard.txtNameRes.Text = reservation.RESTAURANT.NAME;
                    ReviewWidgetCard.txtNameUser.Text = reservation.USER.NAME;
                    ReviewWidgetCard.txtRating.Text = new string('★', (int)reservation.RATING) + new string('☆', 5 - (int)reservation.RATING);
                    ReviewWidgetCard.txtComment.Text = reservation.COMMENT;
                    ReviewWidgetCard.picUser.Image = Resources.user;
                    panelRes.Controls.Add(ReviewWidgetCard);
                }
                panelRes.ResumeLayout();
                panelRes.PerformLayout();
            }
            catch (Exception ex)
            {
                //    MessageBox.Show("Error");
            }
        }
        public void RefreshReviewData()
        {
            panelRes.Controls.Clear();
            LoadReview();
        }

    }
}