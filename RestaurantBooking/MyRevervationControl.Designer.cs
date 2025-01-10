namespace RestaurantBooking
{
    partial class MyRevervationControl
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
            this.MyReservations_Reserved = new System.Windows.Forms.Button();
            this.MyReservations_Completed = new System.Windows.Forms.Button();
            this.MyReservations_Canceled = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelRes = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelProfile);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 75);
            this.panel1.TabIndex = 1;
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfile.Location = new System.Drawing.Point(450, 15);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(277, 38);
            this.labelProfile.TabIndex = 1;
            this.labelProfile.Text = "My Reservations";
            // 
            // MyReservations_Reserved
            // 
            this.MyReservations_Reserved.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MyReservations_Reserved.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyReservations_Reserved.Location = new System.Drawing.Point(100, 25);
            this.MyReservations_Reserved.Name = "MyReservations_Reserved";
            this.MyReservations_Reserved.Size = new System.Drawing.Size(200, 50);
            this.MyReservations_Reserved.TabIndex = 2;
            this.MyReservations_Reserved.Text = "Reserved";
            this.MyReservations_Reserved.UseVisualStyleBackColor = true;
            this.MyReservations_Reserved.Click += new System.EventHandler(this.MyReservations_Reserved_Click);
            // 
            // MyReservations_Completed
            // 
            this.MyReservations_Completed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MyReservations_Completed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyReservations_Completed.Location = new System.Drawing.Point(500, 25);
            this.MyReservations_Completed.Name = "MyReservations_Completed";
            this.MyReservations_Completed.Size = new System.Drawing.Size(200, 50);
            this.MyReservations_Completed.TabIndex = 3;
            this.MyReservations_Completed.Text = "Completed";
            this.MyReservations_Completed.UseVisualStyleBackColor = true;
            this.MyReservations_Completed.Click += new System.EventHandler(this.MyReservations_Completed_Click);
            // 
            // MyReservations_Canceled
            // 
            this.MyReservations_Canceled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MyReservations_Canceled.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyReservations_Canceled.Location = new System.Drawing.Point(900, 25);
            this.MyReservations_Canceled.Name = "MyReservations_Canceled";
            this.MyReservations_Canceled.Size = new System.Drawing.Size(200, 50);
            this.MyReservations_Canceled.TabIndex = 4;
            this.MyReservations_Canceled.Text = "Canceled";
            this.MyReservations_Canceled.UseVisualStyleBackColor = true;
            this.MyReservations_Canceled.Click += new System.EventHandler(this.MyReservations_Canceled_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MyReservations_Reserved);
            this.panel2.Controls.Add(this.MyReservations_Completed);
            this.panel2.Controls.Add(this.MyReservations_Canceled);
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 100);
            this.panel2.TabIndex = 6;
            // 
            // panelRes
            // 
            this.panelRes.AutoScroll = true;
            this.panelRes.Location = new System.Drawing.Point(20, 250);
            this.panelRes.Name = "panelRes";
            this.panelRes.Size = new System.Drawing.Size(1160, 670);
            this.panelRes.TabIndex = 7;
            // 
            // MyRevervationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelRes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MyRevervationControl";
            this.Size = new System.Drawing.Size(1200, 950);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.Button MyReservations_Reserved;
        private System.Windows.Forms.Button MyReservations_Completed;
        private System.Windows.Forms.Button MyReservations_Canceled;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel panelRes;
    }
}
