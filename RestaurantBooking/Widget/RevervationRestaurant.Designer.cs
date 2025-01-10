namespace RestaurantBooking
{
    partial class RevervationRestaurant
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNameRes = new System.Windows.Forms.Label();
            this.txtLocationRes = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.Label();
            this.txtPeople = new System.Windows.Forms.Label();
            this.txtCanceled = new System.Windows.Forms.Label();
            this.txtService = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtNameRes
            // 
            this.txtNameRes.AutoSize = true;
            this.txtNameRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameRes.Location = new System.Drawing.Point(250, 10);
            this.txtNameRes.Name = "txtNameRes";
            this.txtNameRes.Size = new System.Drawing.Size(288, 38);
            this.txtNameRes.TabIndex = 3;
            this.txtNameRes.Text = "Name Restaurant";
            // 
            // txtLocationRes
            // 
            this.txtLocationRes.AutoSize = true;
            this.txtLocationRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationRes.Location = new System.Drawing.Point(250, 55);
            this.txtLocationRes.Name = "txtLocationRes";
            this.txtLocationRes.Size = new System.Drawing.Size(86, 25);
            this.txtLocationRes.TabIndex = 4;
            this.txtLocationRes.Text = "Location";
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(250, 100);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(53, 25);
            this.txtDate.TabIndex = 0;
            this.txtDate.Text = "Date";
            // 
            // txtTime
            // 
            this.txtTime.AutoSize = true;
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(500, 100);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(56, 25);
            this.txtTime.TabIndex = 1;
            this.txtTime.Text = "Time";
            // 
            // txtPeople
            // 
            this.txtPeople.AutoSize = true;
            this.txtPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeople.Location = new System.Drawing.Point(750, 100);
            this.txtPeople.Name = "txtPeople";
            this.txtPeople.Size = new System.Drawing.Size(73, 25);
            this.txtPeople.TabIndex = 2;
            this.txtPeople.Text = "People";
            // 
            // txtCanceled
            // 
            this.txtCanceled.AutoSize = true;
            this.txtCanceled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCanceled.Location = new System.Drawing.Point(750, 150);
            this.txtCanceled.Name = "txtCanceled";
            this.txtCanceled.Size = new System.Drawing.Size(96, 25);
            this.txtCanceled.TabIndex = 6;
            this.txtCanceled.Text = "Canceled";
            // 
            // txtService
            // 
            this.txtService.AutoSize = true;
            this.txtService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtService.Location = new System.Drawing.Point(250, 150);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(78, 25);
            this.txtService.TabIndex = 7;
            this.txtService.Text = "Service";
            // 
            // MyResCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.txtPeople);
            this.Controls.Add(this.txtCanceled);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtLocationRes);
            this.Controls.Add(this.txtNameRes);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MyResCard";
            this.Size = new System.Drawing.Size(1100, 200);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label txtNameRes;
        internal System.Windows.Forms.Label txtLocationRes;
        internal System.Windows.Forms.Label txtDate;
        internal System.Windows.Forms.Label txtPeople;
        internal System.Windows.Forms.Label txtTime;
        internal System.Windows.Forms.Label txtCanceled;
        internal System.Windows.Forms.Label txtService;
    }
}
