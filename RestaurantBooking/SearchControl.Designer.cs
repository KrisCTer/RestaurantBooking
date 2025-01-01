using System;

namespace RestaurantBooking
{
    partial class SearchControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelProfile = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MyReservations_People = new System.Windows.Forms.Label();
            this.MyReservations_Time = new System.Windows.Forms.Label();
            this.MyReservations_Date = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.restaurentsControl5 = new RestaurantBooking.Widget.RestaurentsControl();
            this.restaurentsControl6 = new RestaurantBooking.Widget.RestaurentsControl();
            this.restaurentsControl1 = new RestaurantBooking.Widget.RestaurentsControl();
            this.restaurentsControl4 = new RestaurantBooking.Widget.RestaurentsControl();
            this.restaurentsControl3 = new RestaurantBooking.Widget.RestaurentsControl();
            this.restaurentsControl2 = new RestaurantBooking.Widget.RestaurentsControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelProfile);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 75);
            this.panel1.TabIndex = 1;
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfile.Location = new System.Drawing.Point(500, 15);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(127, 38);
            this.labelProfile.TabIndex = 1;
            this.labelProfile.Text = "Search";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MyReservations_People);
            this.panel2.Controls.Add(this.MyReservations_Time);
            this.panel2.Controls.Add(this.MyReservations_Date);
            this.panel2.Location = new System.Drawing.Point(3, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1194, 100);
            this.panel2.TabIndex = 2;
            // 
            // MyReservations_People
            // 
            this.MyReservations_People.AutoSize = true;
            this.MyReservations_People.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyReservations_People.Location = new System.Drawing.Point(900, 35);
            this.MyReservations_People.Name = "MyReservations_People";
            this.MyReservations_People.Size = new System.Drawing.Size(127, 32);
            this.MyReservations_People.TabIndex = 2;
            this.MyReservations_People.Text = "People 2";
            // 
            // MyReservations_Time
            // 
            this.MyReservations_Time.AutoSize = true;
            this.MyReservations_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyReservations_Time.Location = new System.Drawing.Point(500, 35);
            this.MyReservations_Time.Name = "MyReservations_Time";
            this.MyReservations_Time.Size = new System.Drawing.Size(156, 32);
            this.MyReservations_Time.TabIndex = 1;
            this.MyReservations_Time.Text = "Time 12:00";
            // 
            // MyReservations_Date
            // 
            this.MyReservations_Date.AutoSize = true;
            this.MyReservations_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyReservations_Date.Location = new System.Drawing.Point(100, 35);
            this.MyReservations_Date.Name = "MyReservations_Date";
            this.MyReservations_Date.Size = new System.Drawing.Size(156, 32);
            this.MyReservations_Date.TabIndex = 0;
            this.MyReservations_Date.Text = "Time 12:00";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(225, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(800, 38);
            this.textBox1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.restaurentsControl5);
            this.panel3.Controls.Add(this.restaurentsControl6);
            this.panel3.Controls.Add(this.restaurentsControl1);
            this.panel3.Controls.Add(this.restaurentsControl4);
            this.panel3.Controls.Add(this.restaurentsControl3);
            this.panel3.Controls.Add(this.restaurentsControl2);
            this.panel3.Location = new System.Drawing.Point(20, 325);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1160, 780);
            this.panel3.TabIndex = 4;
            // 
            // restaurentsControl5
            // 
            this.restaurentsControl5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.restaurentsControl5.Location = new System.Drawing.Point(30, 805);
            this.restaurentsControl5.Name = "restaurentsControl5";
            this.restaurentsControl5.Size = new System.Drawing.Size(1100, 125);
            this.restaurentsControl5.TabIndex = 7;
            // 
            // restaurentsControl6
            // 
            this.restaurentsControl6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.restaurentsControl6.Location = new System.Drawing.Point(30, 655);
            this.restaurentsControl6.Name = "restaurentsControl6";
            this.restaurentsControl6.Size = new System.Drawing.Size(1100, 125);
            this.restaurentsControl6.TabIndex = 6;
            // 
            // restaurentsControl1
            // 
            this.restaurentsControl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.restaurentsControl1.Location = new System.Drawing.Point(30, 520);
            this.restaurentsControl1.Name = "restaurentsControl1";
            this.restaurentsControl1.Size = new System.Drawing.Size(1100, 125);
            this.restaurentsControl1.TabIndex = 5;
            // 
            // restaurentsControl4
            // 
            this.restaurentsControl4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.restaurentsControl4.Location = new System.Drawing.Point(30, 370);
            this.restaurentsControl4.Name = "restaurentsControl4";
            this.restaurentsControl4.Size = new System.Drawing.Size(1100, 125);
            this.restaurentsControl4.TabIndex = 4;
            // 
            // restaurentsControl3
            // 
            this.restaurentsControl3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.restaurentsControl3.Location = new System.Drawing.Point(30, 225);
            this.restaurentsControl3.Name = "restaurentsControl3";
            this.restaurentsControl3.Size = new System.Drawing.Size(1100, 125);
            this.restaurentsControl3.TabIndex = 3;
            // 
            // restaurentsControl2
            // 
            this.restaurentsControl2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.restaurentsControl2.Location = new System.Drawing.Point(30, 30);
            this.restaurentsControl2.Name = "restaurentsControl2";
            this.restaurentsControl2.Size = new System.Drawing.Size(1100, 125);
            this.restaurentsControl2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Restaurants";
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(1200, 1100);
            this.Load += new System.EventHandler(this.SearchControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label MyReservations_Date;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label MyReservations_Time;
        private System.Windows.Forms.Label MyReservations_People;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private Widget.RestaurentsControl restaurentsControl3;
        private Widget.RestaurentsControl restaurentsControl2;
        private Widget.RestaurentsControl restaurentsControl1;
        private Widget.RestaurentsControl restaurentsControl4;
        private Widget.RestaurentsControl restaurentsControl5;
        private Widget.RestaurentsControl restaurentsControl6;
    }
}
