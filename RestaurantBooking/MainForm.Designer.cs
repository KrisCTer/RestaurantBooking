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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonReview = new System.Windows.Forms.Button();
            this.buttonReservation = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(27)))));
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this.buttonLogout);
            this.groupBox1.Controls.Add(this.buttonProfile);
            this.groupBox1.Controls.Add(this.buttonReview);
            this.groupBox1.Controls.Add(this.buttonReservation);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.buttonHome);
            this.groupBox1.Location = new System.Drawing.Point(0, -40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 1102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(27)))));
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonLogout.Location = new System.Drawing.Point(6, 1100);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(338, 50);
            this.buttonLogout.TabIndex = 5;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.buttonLogout.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(27)))));
            this.buttonProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfile.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonProfile.Location = new System.Drawing.Point(6, 800);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(338, 100);
            this.buttonProfile.TabIndex = 4;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.buttonProfile.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // buttonReview
            // 
            this.buttonReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(27)))));
            this.buttonReview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReview.FlatAppearance.BorderSize = 0;
            this.buttonReview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.buttonReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReview.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonReview.Location = new System.Drawing.Point(6, 700);
            this.buttonReview.Name = "buttonReview";
            this.buttonReview.Size = new System.Drawing.Size(338, 100);
            this.buttonReview.TabIndex = 3;
            this.buttonReview.Text = "Review";
            this.buttonReview.UseVisualStyleBackColor = false;
            this.buttonReview.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.buttonReview.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // buttonReservation
            // 
            this.buttonReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(27)))));
            this.buttonReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReservation.FlatAppearance.BorderSize = 0;
            this.buttonReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.buttonReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReservation.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonReservation.Location = new System.Drawing.Point(6, 600);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Size = new System.Drawing.Size(338, 100);
            this.buttonReservation.TabIndex = 2;
            this.buttonReservation.Text = "Reservation";
            this.buttonReservation.UseVisualStyleBackColor = false;
            this.buttonReservation.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.buttonReservation.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(27)))));
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonSearch.Location = new System.Drawing.Point(6, 500);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(338, 100);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.buttonSearch.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(27)))));
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(18)))), ((int)(((byte)(29)))));
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
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
            // pictureBox
            // 
            this.pictureBox.Image = global::RestaurantBooking.Properties.Resources.ethical_hacker;
            this.pictureBox.Location = new System.Drawing.Point(75, 100);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 200);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 1055);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Restaurant Booking System";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Button buttonHome;
        private Button buttonReview;
        private Button buttonReservation;
        private Button buttonSearch;
        private Button buttonProfile;
        private Button buttonLogout;
        private PictureBox pictureBox;
    }
}

