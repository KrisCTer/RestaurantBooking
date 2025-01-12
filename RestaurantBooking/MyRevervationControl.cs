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

                panelRes.Controls.Clear();

                foreach (RESERVATION reservation in reservations)
                {
                    bool IsReservatio = _restaurantService.checkIsReservation(reservation);
                    if (!IsReservatio)
                    {
                        RESTAURANT restaurant = _restaurantService.GetRestaurantReservation(reservation);

                        if (restaurant != null)
                        {
                            ReservationWidget myResCard = new ReservationWidget();

                            // Cập nhật thông tin nhà hàng
                            myResCard.txtNameRes.Text = restaurant.NAME;
                            myResCard.txtLocationRes.Text = restaurant.LOCATION;

                            // Cập nhật thông tin đặt chỗ
                            if (reservation.DATE_RESERVATION.HasValue)
                            {
                                myResCard.lbDateTime.Text = reservation.DATE_RESERVATION.Value.ToString("dd/MM/yyyy");
                                myResCard.label1e.Text = reservation.DATE_RESERVATION.Value.ToString("HH:mm");
                                myResCard.lbPeople.Text = reservation.NUMBERS_OF_GUEST?.ToString() ?? "0"; // Sửa từ ToShortDateString sang số người
                            }
                            myResCard.labelStatus.Text = "Awaiting";

                            myResCard.XControl.Click += (s, args) =>
                            {
                                DialogResult result = MessageBox.Show(
                                    "Bạn có chắc chắn muốn hủy đặt bàn này?",
                                    "Xác nhận hủy",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning
                                );

                                if (result == DialogResult.Yes)
                                {
                                    if (_restaurantService.AddToCanceled(reservation))
                                    {
                                        if (_restaurantService.DeleteReservation(reservation))
                                        {
                                            MessageBox.Show("Đặt bàn đã bị hủy và chuyển vào danh sách hủy.",
                                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            panelRes.Controls.Remove(myResCard);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Có lỗi khi xóa đặt bàn.",
                                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Có lỗi khi thêm vào danh sách hủy.",
                                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            };

                            panelRes.Controls.Add(myResCard);
                        }
                    }
                }

                if (!panelRes.Controls.OfType<ReservationWidget>().Any())
                {
                    Label noReservationsLabel = new Label
                    {
                        Text = "No upcoming reservations found",
                        AutoSize = true,
                        Location = new Point(10, 10),
                        Font = new Font("Arial", 12),
                        ForeColor = Color.Gray
                    };
                    panelRes.Controls.Add(noReservationsLabel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reservations: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MyReservations_Completed_Click(object sender, EventArgs e)
        {
            try
            {
                USER mainUser = MainForm._mainUser;

                List<RESERVATION> reservations = _restaurantService.getListCompletedCurrentUser(mainUser);

                panelRes.Controls.Clear();

                foreach (RESERVATION reservation in reservations)
                {
                    bool isCancelled = _restaurantService.checkIsReservation(reservation);

                    if (!isCancelled)
                    {
                        RESTAURANT restaurant = _restaurantService.GetRestaurantReservation(reservation);

                        if (restaurant != null)
                        {
                            ReservationWidget myResCard = new ReservationWidget();

                            myResCard.txtNameRes.Text = restaurant.NAME;
                            myResCard.txtLocationRes.Text = restaurant.LOCATION;

                            myResCard.lbDateTime.Text = reservation.DATE_RESERVATION?.ToString("dd/MM");
                            myResCard.label1e.Text = reservation.DATE_RESERVATION?.ToString("HH:mm");
                            myResCard.lbPeople.Text = reservation.DATE_RESERVATION?.ToShortDateString();
                            myResCard.labelStatus.Text = "Completed";

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
                        Location = new Point(10, 10),
                        Font = new Font("Arial", 12),
                        ForeColor = Color.Gray
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

                panelRes.Controls.Clear();

                foreach (CANCELLATION cancellation in cancellations)
                {
                    RESERVATION reservation = _restaurantService.GetCancelReservation(cancellation);

                    if (reservation != null)
                    {
                        RESTAURANT restaurant = _restaurantService.GetRestaurantReservation(reservation);

                        if (restaurant != null)
                        {
                            ReservationWidget myResCard = new ReservationWidget();

                            myResCard.txtNameRes.Text = restaurant.NAME;
                            myResCard.txtLocationRes.Text = restaurant.LOCATION;

                            myResCard.lbDateTime.Text = reservation.DATE_RESERVATION?.ToString("dd/MM");
                            myResCard.label1e.Text = reservation.DATE_RESERVATION?.ToString("HH:mm");
                            myResCard.lbPeople.Text = reservation.DATE_RESERVATION?.ToShortDateString();
                            myResCard.labelStatus.Text = "Canceled on " + DateTime.Now;

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
                        Location = new Point(10, 10),
                        Font = new Font("Arial", 12),
                        ForeColor = Color.Gray
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
