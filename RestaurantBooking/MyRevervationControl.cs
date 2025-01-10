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
using RestaurantBooking.Widget;

namespace RestaurantBooking
{
    public partial class MyRevervationControl : UserControl
    {
        private readonly RestaurantService _restaurantService = new RestaurantService();


        public MyRevervationControl()
        {
            InitializeComponent();
        }

        private void MyReservations_Reserved_Click(object sender, EventArgs e)
        {
            try
            {
                USER mainUser = MainForm._mainUser;
                List<RESERVATION> reservations = _restaurantService.getListReservedCurrentUser(mainUser);

                List<RESTAURANT> restaurants = _restaurantService.ListRestaurant();
                List<SERVICE> services = _restaurantService.ListService();

                panelRes.Controls.Clear();

                foreach (RESERVATION reservation in reservations)
                {
                    bool isCancelled = _restaurantService.checkIsCancelled(reservation);
                    if (!isCancelled)
                    {
                        RESTAURANT restaurant = _restaurantService.GetRestaurantReservation(reservation);

                        if (restaurant != null)
                        {
                            RevervationRestaurant myResCard = new RevervationRestaurant();

                            myResCard.txtNameRes.Text = restaurant.NAME;
                            myResCard.txtLocationRes.Text = restaurant.LOCATION;

                            myResCard.txtDate.Text = reservation.DATE_RESERVATION.Value.ToString("dd/MM");
                            myResCard.txtTime.Text = reservation.DATE_RESERVATION.Value.ToString("HH:mm");

                            myResCard.Tag = reservation.ID_RESERVATION;
                            panelRes.Controls.Add(myResCard);
                        }
                    }
                }

                if (reservations.Count == 0)
                {
                    Label noReservationsLabel = new Label
                    {
                        Text = "No upcoming reservations found",
                        AutoSize = true,
                        Location = new Point(10, 10)
                    };
                    panelRes.Controls.Add(noReservationsLabel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reservations: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MyReservations_Completed_Click(object sender, EventArgs e)
        {
            try
            {
                USER mainUser = MainForm._mainUser;

                List<RESERVATION> reservations = _restaurantService.getListCompletedCurrentUser(mainUser);

                List<CANCELLATION> cancellations = _restaurantService.ListCancellation();

                List<RESTAURANT> restaurants = _restaurantService.ListRestaurant();
                List<SERVICE> services = _restaurantService.ListService();

                panelRes.Controls.Clear();

                foreach (RESERVATION reservation in reservations)
                {
                    bool isCancelled = _restaurantService.checkIsCancelled(reservation);

                    if (!isCancelled)
                    {
                        RESTAURANT restaurant = _restaurantService.GetRestaurantReservation(reservation);

                        if (restaurant != null)
                        {
                            RevervationRestaurant myResCard = new RevervationRestaurant();

                            myResCard.txtNameRes.Text = restaurant.NAME;
                            myResCard.txtLocationRes.Text = restaurant.LOCATION;

                            myResCard.txtDate.Text = reservation.DATE_RESERVATION.Value.ToString("dd/MM");
                            myResCard.txtTime.Text = reservation.DATE_RESERVATION.Value.ToString("HH:mm");

                            myResCard.Tag = reservation.ID_RESERVATION;

                            panelRes.Controls.Add(myResCard);
                        }
                    }
                }

                if (reservations.Count == 0 || panelRes.Controls.Count == 0)
                {
                    Label noReservationsLabel = new Label
                    {
                        Text = "No reservations before today were found or all were canceled",
                        AutoSize = true,
                        Location = new Point(10, 10)
                    };
                    panelRes.Controls.Add(noReservationsLabel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reservations: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MyReservations_Canceled_Click(object sender, EventArgs e)
        {
            try
            {
                USER mainUser = MainForm._mainUser;

                List<CANCELLATION> cancellations = _restaurantService.getListCanceledCurrentUser(mainUser);

                List<RESERVATION> reservations = _restaurantService.ListResservation();
                List<RESTAURANT> restaurants = _restaurantService.ListRestaurant();
                List<SERVICE> services = _restaurantService.ListService();

                panelRes.Controls.Clear();

                foreach (CANCELLATION cancellation in cancellations)
                {
                    RESERVATION reservation = _restaurantService.GetCancelReservation(cancellation);

                    if (reservation != null)
                    {
                        RESTAURANT restaurant = _restaurantService.GetRestaurantReservation(reservation);

                        if (restaurant != null)
                        {
                            RevervationRestaurant myResCard = new RevervationRestaurant();

                            myResCard.txtNameRes.Text = restaurant.NAME;
                            myResCard.txtLocationRes.Text = restaurant.LOCATION;

                            myResCard.txtDate.Text = reservation.DATE_RESERVATION?.ToString("dd/MM");
                            myResCard.txtTime.Text = reservation.DATE_RESERVATION?.ToString("HH:mm");

                            myResCard.Tag = reservation.ID_RESERVATION;

                            panelRes.Controls.Add(myResCard);
                        }
                    }
                }

                if (cancellations.Count == 0 || panelRes.Controls.Count == 0)
                {
                    Label noCancellationsLabel = new Label
                    {
                        Text = "No canceled reservations found",
                        AutoSize = true,
                        Location = new Point(10, 10)
                    };
                    panelRes.Controls.Add(noCancellationsLabel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading canceled reservations: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void RefreshReservationData()
        {
            MyReservations_Reserved_Click(null, null);
        }
    }
}
