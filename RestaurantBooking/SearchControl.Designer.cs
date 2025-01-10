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
            this.MyReservations_Time = new System.Windows.Forms.Label();
            this.MyReservations_Date = new System.Windows.Forms.Label();
            this.MyReservations_People = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.CountRes = new System.Windows.Forms.Label();
            this.panelRes = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCancelSearch = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAtmosphere = new System.Windows.Forms.Button();
            this.buttonPrice = new System.Windows.Forms.Button();
            this.buttonCancelCalendar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonRegion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelProfile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 75);
            this.panel1.TabIndex = 1;
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfile.Location = new System.Drawing.Point(502, 15);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(127, 38);
            this.labelProfile.TabIndex = 1;
            this.labelProfile.Text = "Search";
            // 
            // MyReservations_Time
            // 
            this.MyReservations_Time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MyReservations_Time.AutoSize = true;
            this.MyReservations_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyReservations_Time.Location = new System.Drawing.Point(626, 9);
            this.MyReservations_Time.Name = "MyReservations_Time";
            this.MyReservations_Time.Size = new System.Drawing.Size(0, 32);
            this.MyReservations_Time.TabIndex = 1;
            this.MyReservations_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MyReservations_Time.DoubleClick += new System.EventHandler(this.panel_DoubleClick);
            // 
            // MyReservations_Date
            // 
            this.MyReservations_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MyReservations_Date.AutoSize = true;
            this.MyReservations_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyReservations_Date.Location = new System.Drawing.Point(328, 9);
            this.MyReservations_Date.Name = "MyReservations_Date";
            this.MyReservations_Date.Size = new System.Drawing.Size(0, 32);
            this.MyReservations_Date.TabIndex = 0;
            this.MyReservations_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MyReservations_Date.DoubleClick += new System.EventHandler(this.panel_DoubleClick);
            // 
            // MyReservations_People
            // 
            this.MyReservations_People.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MyReservations_People.AutoSize = true;
            this.MyReservations_People.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyReservations_People.Location = new System.Drawing.Point(924, 9);
            this.MyReservations_People.Name = "MyReservations_People";
            this.MyReservations_People.Size = new System.Drawing.Size(0, 32);
            this.MyReservations_People.TabIndex = 2;
            this.MyReservations_People.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MyReservations_People.DoubleClick += new System.EventHandler(this.panel_DoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(193, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(800, 45);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // CountRes
            // 
            this.CountRes.AutoSize = true;
            this.CountRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountRes.Location = new System.Drawing.Point(44, 290);
            this.CountRes.Name = "CountRes";
            this.CountRes.Size = new System.Drawing.Size(167, 32);
            this.CountRes.TabIndex = 1;
            this.CountRes.Text = "Restaurants";
            // 
            // panelRes
            // 
            this.panelRes.AutoScroll = true;
            this.panelRes.Location = new System.Drawing.Point(20, 325);
            this.panelRes.Name = "panelRes";
            this.panelRes.Size = new System.Drawing.Size(1160, 600);
            this.panelRes.TabIndex = 4;
            this.panelRes.Resize += new System.EventHandler(this.panelRes_Resize);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonCancelSearch);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Location = new System.Drawing.Point(0, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1200, 100);
            this.panel3.TabIndex = 5;
            // 
            // buttonCancelSearch
            // 
            this.buttonCancelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelSearch.Location = new System.Drawing.Point(999, 26);
            this.buttonCancelSearch.Name = "buttonCancelSearch";
            this.buttonCancelSearch.Size = new System.Drawing.Size(115, 44);
            this.buttonCancelSearch.TabIndex = 4;
            this.buttonCancelSearch.Text = "X";
            this.buttonCancelSearch.UseVisualStyleBackColor = true;
            this.buttonCancelSearch.Visible = false;
            this.buttonCancelSearch.Click += new System.EventHandler(this.buttonCancelSearch_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.buttonAtmosphere, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonPrice, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.MyReservations_People, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.MyReservations_Time, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.MyReservations_Date, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonCancelCalendar, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonCancel, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonRegion, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 175);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1194, 100);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.DoubleClick += new System.EventHandler(this.panel_DoubleClick);
            // 
            // buttonAtmosphere
            // 
            this.buttonAtmosphere.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAtmosphere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtmosphere.Location = new System.Drawing.Point(778, 53);
            this.buttonAtmosphere.Name = "buttonAtmosphere";
            this.buttonAtmosphere.Size = new System.Drawing.Size(292, 44);
            this.buttonAtmosphere.TabIndex = 10;
            this.buttonAtmosphere.Text = "Atmosphere";
            this.buttonAtmosphere.UseVisualStyleBackColor = true;
            this.buttonAtmosphere.Click += new System.EventHandler(this.buttonAtmosphere_Click);
            // 
            // buttonPrice
            // 
            this.buttonPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrice.Location = new System.Drawing.Point(480, 53);
            this.buttonPrice.Name = "buttonPrice";
            this.buttonPrice.Size = new System.Drawing.Size(292, 44);
            this.buttonPrice.TabIndex = 9;
            this.buttonPrice.Text = "Price";
            this.buttonPrice.UseVisualStyleBackColor = true;
            this.buttonPrice.Click += new System.EventHandler(this.buttonPrice_Click);
            // 
            // buttonCancelCalendar
            // 
            this.buttonCancelCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancelCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelCalendar.Location = new System.Drawing.Point(1076, 3);
            this.buttonCancelCalendar.Name = "buttonCancelCalendar";
            this.buttonCancelCalendar.Size = new System.Drawing.Size(115, 44);
            this.buttonCancelCalendar.TabIndex = 3;
            this.buttonCancelCalendar.Text = "X";
            this.buttonCancelCalendar.UseVisualStyleBackColor = true;
            this.buttonCancelCalendar.Visible = false;
            this.buttonCancelCalendar.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::RestaurantBooking.Properties.Resources.calendar;
            this.pictureBox1.Location = new System.Drawing.Point(67, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.panel_DoubleClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::RestaurantBooking.Properties.Resources.setting;
            this.pictureBox2.Location = new System.Drawing.Point(67, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.DoubleClick += new System.EventHandler(this.panel_DoubleClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(1076, 53);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(115, 44);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "X";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            // 
            // buttonRegion
            // 
            this.buttonRegion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegion.Location = new System.Drawing.Point(182, 53);
            this.buttonRegion.Name = "buttonRegion";
            this.buttonRegion.Size = new System.Drawing.Size(292, 44);
            this.buttonRegion.TabIndex = 8;
            this.buttonRegion.Text = "Region";
            this.buttonRegion.UseVisualStyleBackColor = true;
            this.buttonRegion.Click += new System.EventHandler(this.buttonRegion_Click);
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelRes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CountRes);
            this.Controls.Add(this.panel3);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(1200, 950);
            this.Load += new System.EventHandler(this.SearchControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.Label MyReservations_Date;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label MyReservations_Time;
        private System.Windows.Forms.Label MyReservations_People;
        private System.Windows.Forms.Label CountRes;
        private System.Windows.Forms.FlowLayoutPanel panelRes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonCancelCalendar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCancelSearch;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAtmosphere;
        private System.Windows.Forms.Button buttonPrice;
        private System.Windows.Forms.Button buttonRegion;
    }
}
