namespace RestaurantBooking
{
    partial class MyResCard
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
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelPeople = new System.Windows.Forms.Label();
            this.LabelCanceled = new System.Windows.Forms.Label();
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
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(250, 100);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(53, 25);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Date";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(500, 100);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(56, 25);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "Time";
            // 
            // labelPeople
            // 
            this.labelPeople.AutoSize = true;
            this.labelPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeople.Location = new System.Drawing.Point(750, 100);
            this.labelPeople.Name = "labelPeople";
            this.labelPeople.Size = new System.Drawing.Size(73, 25);
            this.labelPeople.TabIndex = 2;
            this.labelPeople.Text = "People";
            // 
            // LabelCanceled
            // 
            this.LabelCanceled.AutoSize = true;
            this.LabelCanceled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCanceled.Location = new System.Drawing.Point(250, 150);
            this.LabelCanceled.Name = "LabelCanceled";
            this.LabelCanceled.Size = new System.Drawing.Size(96, 25);
            this.LabelCanceled.TabIndex = 6;
            this.LabelCanceled.Text = "Canceled";
            // 
            // MyResCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelPeople);
            this.Controls.Add(this.LabelCanceled);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDate);
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

        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label txtNameRes;
        internal System.Windows.Forms.Label txtLocationRes;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelPeople;
        private System.Windows.Forms.Label labelTime;
        internal System.Windows.Forms.Label LabelCanceled;
    }
}
