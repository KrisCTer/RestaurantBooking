using System;
using System.Windows.Forms;

namespace RestaurantBooking
{
    partial class bookingDate
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btbCheck = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flpPeople = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.select_Date = new System.Windows.Forms.Label();
            this.select_Time = new System.Windows.Forms.Label();
            this.select_People = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.headPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.flpTime = new System.Windows.Forms.FlowLayoutPanel();
            this.MainPanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.headPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.btbCheck);
            this.MainPanel.Controls.Add(this.flowLayoutPanel2);
            this.MainPanel.Controls.Add(this.tableLayoutPanel1);
            this.MainPanel.Controls.Add(this.headPanel);
            this.MainPanel.Controls.Add(this.flowLayoutPanel1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(962, 453);
            this.MainPanel.TabIndex = 0;
            // 
            // btbCheck
            // 
            this.btbCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbCheck.Location = new System.Drawing.Point(323, 390);
            this.btbCheck.Name = "btbCheck";
            this.btbCheck.Size = new System.Drawing.Size(320, 50);
            this.btbCheck.TabIndex = 4;
            this.btbCheck.Text = "Check";
            this.btbCheck.UseVisualStyleBackColor = true;
            this.btbCheck.Click += new System.EventHandler(this.btbSave_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.flpPeople);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(640, 100);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(320, 280);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "People";
            // 
            // flpPeople
            // 
            this.flpPeople.AutoScroll = true;
            this.flpPeople.Location = new System.Drawing.Point(3, 41);
            this.flpPeople.Name = "flpPeople";
            this.flpPeople.Size = new System.Drawing.Size(317, 231);
            this.flpPeople.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.select_Date, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.select_Time, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.select_People, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonCancel, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(962, 100);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // select_Date
            // 
            this.select_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.select_Date.AutoSize = true;
            this.select_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_Date.Location = new System.Drawing.Point(264, 34);
            this.select_Date.Name = "select_Date";
            this.select_Date.Size = new System.Drawing.Size(0, 32);
            this.select_Date.TabIndex = 0;
            this.select_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // select_Time
            // 
            this.select_Time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.select_Time.AutoSize = true;
            this.select_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_Time.Location = new System.Drawing.Point(504, 34);
            this.select_Time.Name = "select_Time";
            this.select_Time.Size = new System.Drawing.Size(0, 32);
            this.select_Time.TabIndex = 1;
            this.select_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // select_People
            // 
            this.select_People.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.select_People.AutoSize = true;
            this.select_People.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_People.Location = new System.Drawing.Point(744, 34);
            this.select_People.Name = "select_People";
            this.select_People.Size = new System.Drawing.Size(0, 32);
            this.select_People.TabIndex = 2;
            this.select_People.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(868, 28);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 44);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "X";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // headPanel
            // 
            this.headPanel.Controls.Add(this.label1);
            this.headPanel.Controls.Add(this.monthCalendar);
            this.headPanel.Location = new System.Drawing.Point(0, 100);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(320, 280);
            this.headPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Month";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar.Location = new System.Drawing.Point(9, 47);
            this.monthCalendar.MinDate = new System.DateTime(2025, 1, 6, 0, 0, 0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowToday = false;
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.flpTime);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(320, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(320, 280);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time";
            // 
            // flpTime
            // 
            this.flpTime.AutoScroll = true;
            this.flpTime.Location = new System.Drawing.Point(3, 41);
            this.flpTime.Name = "flpTime";
            this.flpTime.Size = new System.Drawing.Size(317, 231);
            this.flpTime.TabIndex = 3;
            // 
            // bookingDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 453);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "bookingDate";
            this.Text = "Date";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bookingDate_FormClosing);
            this.Load += new System.EventHandler(this.bookingDate_Load);
            this.MainPanel.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private FlowLayoutPanel headPanel;
        private Label label1;
        private MonthCalendar monthCalendar;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel flpTime;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flpPeople;
        public Label select_People;
        public Label select_Time;
        public Label select_Date;
        private Button btbCheck;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonCancel;
    }
}