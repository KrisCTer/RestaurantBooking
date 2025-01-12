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

namespace RestaurantBooking
{
    public partial class SearchResult : Form
    {
        private readonly RestaurantService _restaurantService = new RestaurantService();
        public Button _mainButton;
        private List<string> selectedLocations = new List<string>();
        private List<string> selectedServices = new List<string>();
        private double minPrice = 0;
        private double maxPrice = 1000;

        public List<string> SelectedLocations => selectedLocations;
        public List<string> SelectedServices => selectedServices;
        public double MinPrice => minPrice;
        public double MaxPrice => maxPrice;
        public SearchResult()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelName.Text = _mainButton.Text;
            flowLayoutPanel1.Controls.Clear();

            if (_mainButton.Text == "Region")
            {
                List<RESTAURANT> restaurants = _restaurantService.GetAllLocation();

                foreach (var restaurant in restaurants)
                {
                    Button btn = new Button();
                    btn.Text = restaurant.LOCATION;
                    btn.Width = 475;
                    btn.Height = 50;
                    btn.BackColor = Color.White;
                    btn.Font = new Font("Arial", 20);
                    btn.Tag = restaurant;
                    btn.Click += (s, ev) =>
                    {
                        Button clickedButton = s as Button;
                        if (clickedButton.BackColor == Color.White)
                        {
                            clickedButton.BackColor = Color.LightBlue;
                            selectedLocations.Add(restaurant.LOCATION);
                        }
                        else
                        {
                            clickedButton.BackColor = Color.White;
                            selectedLocations.Remove(restaurant.LOCATION);
                        }
                    };
                    flowLayoutPanel1.Controls.Add(btn);
                }
            }
            if (_mainButton.Text == "Price")
            {
                Panel pricePanel = new Panel
                {
                    Width = 500,
                    Height = 150,
                    AutoSize = true
                };

                Label lblMin = new Label
                {
                    Text = "Minimum Price: $0",
                    AutoSize = true,
                    Font = new Font("Arial", 12)
                };

                Label lblMax = new Label
                {
                    Text = "Maximum Price: $1000",
                    AutoSize = true,
                    Font = new Font("Arial", 12)
                };

                TrackBar trackBarMIN = new TrackBar
                {
                    Minimum = 0,
                    Maximum = 1000,
                    TickFrequency = 100,
                    Width = 475,
                    Value = 0
                };

                TrackBar trackBarMAX = new TrackBar
                {
                    Minimum = 0,
                    Maximum = 1000,
                    TickFrequency = 100,
                    Width = 475,
                    Value = 1000
                };

                trackBarMIN.ValueChanged += (s, ev) =>
                {
                    if (trackBarMIN.Value > trackBarMAX.Value)
                    {
                        trackBarMIN.Value = trackBarMAX.Value;
                    }
                    lblMin.Text = $"Minimum Price: ${trackBarMIN.Value}";
                    minPrice = trackBarMIN.Value;
                };

                trackBarMAX.ValueChanged += (s, ev) =>
                {
                    if (trackBarMAX.Value < trackBarMIN.Value)
                    {
                        trackBarMAX.Value = trackBarMIN.Value;
                    }
                    lblMax.Text = $"Maximum Price: ${trackBarMAX.Value}";
                    maxPrice = trackBarMAX.Value;
                };

                lblMin.Location = new Point(10, 10);
                trackBarMIN.Location = new Point(10, 40);
                lblMax.Location = new Point(10, 100);
                trackBarMAX.Location = new Point(10, 130);

                pricePanel.Controls.AddRange(new Control[] {
                lblMin,
                trackBarMIN,
                lblMax,
                trackBarMAX,
            });

                flowLayoutPanel1.Controls.Add(pricePanel);
            }
            if (_mainButton.Text == "Atmosphere")
            {
                List<SERVICE> services = _restaurantService.listService();

                foreach (var service in services)
                {
                    Button btn = new Button();
                    btn.Text = service.NAME_SER;
                    btn.Width = 475;
                    btn.Height = 50;
                    btn.BackColor = Color.White;
                    btn.Font = new Font("Arial", 20);
                    btn.Tag = service;
                    btn.Click += (s, ev) =>
                    {
                        Button clickedButton = s as Button;
                        if (clickedButton.BackColor == Color.White)
                        {
                            clickedButton.BackColor = Color.LightBlue;
                            selectedServices.Add(service.NAME_SER);
                        }
                        else
                        {
                            clickedButton.BackColor = Color.White;
                            selectedServices.Remove(service.NAME_SER);
                        }
                    };
                    flowLayoutPanel1.Controls.Add(btn);
                }
            }
        }
        private void btnResult_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
