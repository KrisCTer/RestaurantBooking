using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantBooking
{
    public partial class BookingDate : Form
    {
        private bool isSaved = false;
        public BookingDate()
        {
            InitializeComponent();
        }
        private void AddTimeButtonsToPanel(Panel panel)
        {
            int buttonWidth = 100;
            int buttonHeight = 30;
            int margin = 10;
            int x = 10;
            int y = 10;

            TimeSpan startTime = new TimeSpan(0, 0, 0);
            TimeSpan endTime = new TimeSpan(23, 30, 0);
            TimeSpan interval = new TimeSpan(0, 30, 0);

            for (TimeSpan time = startTime; time <= endTime; time += interval)
            {
                Button btn = new Button();
                btn.Text = time.ToString(@"hh\:mm");
                btn.Size = new Size(buttonWidth, buttonHeight);
                btn.Location = new Point(x, y);

                btn.Click += (sender, e) =>
                {
                    select_Time.Text = $"{btn.Text}";
                    buttonCancel.Visible = true;
                };

                panel.Controls.Add(btn);

                y += buttonHeight + margin;
            }
        }
        private void AddPersonButtonsToPanel(Panel panel)
        {
            int buttonWidth = 100;
            int buttonHeight = 30;
            int margin = 10;
            int x = 10;
            int y = 10;

            for (int i = 1; i <= 30; i++)
            {
                // Tạo nút mới
                Button btn = new Button();
                btn.Text = $"{i}";
                btn.Size = new Size(buttonWidth, buttonHeight);
                btn.Location = new Point(x, y);

                // Gắn sự kiện click cho nút
                btn.Click += (sender, e) =>
                {
                    string number = btn.Text.Split(' ')[0];
                    select_People.Text = $"{number}";
                    buttonCancel.Visible = true;
                };

                panel.Controls.Add(btn);

                y += buttonHeight + margin;
            }
        }
        private void bookingDate_Load(object sender, EventArgs e)
        {
            AddTimeButtonsToPanel(flpTime);
            AddPersonButtonsToPanel(flpPeople);
            select_Date.Text = DateTime.Now.ToString("dd-MM");
            select_Time.Text = DateTime.Now.ToString("HH:mm");
            select_People.Text = "2";
            this.monthCalendar.MinDate = DateTime.Now;
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            select_Date.Text = monthCalendar.SelectionStart.ToString("dd-MM");
            buttonCancel.Visible = true;
        }

        private void btbSave_Click(object sender, EventArgs e)
        {
            isSaved = true;
            MessageBox.Show("Reservation successful!", "Notification",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void bookingDate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSaved)
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                "Do you want to save your data before exiting?",
                "Confirm Exit",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Data has been saved successfully!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else if (result == DialogResult.No)
            {
                select_Date.Text = DateTime.Now.ToString("dd-MM");
                select_Time.Text = DateTime.Now.ToString("HH:mm");
                select_People.Text = "2";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            select_Date.Text = DateTime.Now.ToString("dd-MM");
            select_Time.Text = DateTime.Now.ToString("HH:mm");
            select_People.Text = "2";
            monthCalendar.SetDate(DateTime.Now);
            buttonCancel.Visible = false;
        }
    }
}
