using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RestaurantBooking
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonReservation = new System.Windows.Forms.Button();
            this.buttonReview = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.wellcome = new System.Windows.Forms.Label();
            this.panelSystem = new System.Windows.Forms.Panel();
            this.searchControl1 = new RestaurantBooking.SearchControl();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(27)))));
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Harlow Solid Italic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(177)))));
            this.buttonHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonHome.Location = new System.Drawing.Point(6, 400);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(338, 100);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            this.buttonHome.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.buttonHome.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(27)))));
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Harlow Solid Italic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(177)))));
            this.buttonSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSearch.Location = new System.Drawing.Point(6, 500);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(338, 100);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            this.buttonSearch.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.buttonSearch.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // buttonReservation
            // 
            this.buttonReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(27)))));
            this.buttonReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReservation.FlatAppearance.BorderSize = 0;
            this.buttonReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.buttonReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReservation.Font = new System.Drawing.Font("Harlow Solid Italic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(177)))));
            this.buttonReservation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonReservation.Location = new System.Drawing.Point(6, 600);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Size = new System.Drawing.Size(338, 100);
            this.buttonReservation.TabIndex = 2;
            this.buttonReservation.Text = "Reservation";
            this.buttonReservation.UseVisualStyleBackColor = false;
            this.buttonReservation.Click += new System.EventHandler(this.buttonReservation_Click);
            this.buttonReservation.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.buttonReservation.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // buttonReview
            // 
            this.buttonReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(27)))));
            this.buttonReview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReview.FlatAppearance.BorderSize = 0;
            this.buttonReview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.buttonReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReview.Font = new System.Drawing.Font("Harlow Solid Italic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonReview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(177)))));
            this.buttonReview.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonReview.Location = new System.Drawing.Point(6, 700);
            this.buttonReview.Name = "buttonReview";
            this.buttonReview.Size = new System.Drawing.Size(338, 100);
            this.buttonReview.TabIndex = 3;
            this.buttonReview.Text = "Review";
            this.buttonReview.UseVisualStyleBackColor = false;
            this.buttonReview.Click += new System.EventHandler(this.buttonReview_Click);
            this.buttonReview.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.buttonReview.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(27)))));
            this.buttonProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Harlow Solid Italic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(177)))));
            this.buttonProfile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonProfile.Location = new System.Drawing.Point(6, 800);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(338, 100);
            this.buttonProfile.TabIndex = 4;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            this.buttonProfile.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.buttonProfile.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(27)))));
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Harlow Solid Italic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(177)))));
            this.buttonLogout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonLogout.Location = new System.Drawing.Point(6, 950);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(338, 100);
            this.buttonLogout.TabIndex = 5;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.buttonLogout.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // wellcome
            // 
            this.wellcome.AutoSize = true;
            this.wellcome.Font = new System.Drawing.Font("Harlow Solid Italic", 16.2F, System.Drawing.FontStyle.Italic);
            this.wellcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(177)))));
            this.wellcome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.wellcome.Location = new System.Drawing.Point(30, 350);
            this.wellcome.Name = "wellcome";
            this.wellcome.Size = new System.Drawing.Size(197, 35);
            this.wellcome.TabIndex = 7;
            this.wellcome.Text = "Wellcome Guest";
            // 
            // panelSystem
            // 
            this.panelSystem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(27)))));
            this.panelSystem.Controls.Add(this.pictureBox);
            this.panelSystem.Controls.Add(this.buttonLogout);
            this.panelSystem.Controls.Add(this.wellcome);
            this.panelSystem.Controls.Add(this.buttonProfile);
            this.panelSystem.Controls.Add(this.buttonReview);
            this.panelSystem.Controls.Add(this.buttonHome);
            this.panelSystem.Controls.Add(this.buttonReservation);
            this.panelSystem.Controls.Add(this.buttonSearch);
            this.panelSystem.Location = new System.Drawing.Point(0, -50);
            this.panelSystem.Name = "panelSystem";
            this.panelSystem.Size = new System.Drawing.Size(350, 1197);
            this.panelSystem.TabIndex = 1;
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(350, 50);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Size = new System.Drawing.Size(1225, 1100);
            this.searchControl1.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::RestaurantBooking.Properties.Resources.ethical_hacker;
            this.pictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox.Location = new System.Drawing.Point(75, 100);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 200);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(350, 0);
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(27)))));
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 50);
            this.panel1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1582, 1053);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.panelSystem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "MainForm";
            this.Text = "Restaurant Booking System";
            this.panelSystem.ResumeLayout(false);
            this.panelSystem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonHome;
        private Button buttonSearch;
        private Button buttonReservation;
        private Button buttonReview;
        private Button buttonProfile;
        private Button buttonLogout;
        private Label wellcome;
        private Panel panelSystem;
        private SearchControl searchControl1;
        private PictureBox pictureBox;
        private Panel panel1;
        //private LoginOrSignupControl loginOrSignupControl;
        //private ProfileControl profileControl;
    }
}

