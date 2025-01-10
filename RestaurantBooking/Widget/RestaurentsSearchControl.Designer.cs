namespace RestaurantBooking.Widget
{
    partial class RestaurentsSearchControl
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
            this.PicRes = new System.Windows.Forms.PictureBox();
            this.txtNameRes = new System.Windows.Forms.Label();
            this.txtLocationRes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicRes)).BeginInit();
            this.SuspendLayout();
            // 
            // PicRes
            // 
            this.PicRes.Location = new System.Drawing.Point(13, 13);
            this.PicRes.Name = "PicRes";
            this.PicRes.Size = new System.Drawing.Size(100, 100);
            this.PicRes.TabIndex = 1;
            this.PicRes.TabStop = false;
            // 
            // txtNameRes
            // 
            this.txtNameRes.AutoSize = true;
            this.txtNameRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameRes.Location = new System.Drawing.Point(150, 13);
            this.txtNameRes.Name = "txtNameRes";
            this.txtNameRes.Size = new System.Drawing.Size(288, 38);
            this.txtNameRes.TabIndex = 2;
            this.txtNameRes.Text = "Name Restaurant";
            // 
            // txtLocationRes
            // 
            this.txtLocationRes.AutoSize = true;
            this.txtLocationRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationRes.Location = new System.Drawing.Point(150, 60);
            this.txtLocationRes.Name = "txtLocationRes";
            this.txtLocationRes.Size = new System.Drawing.Size(86, 25);
            this.txtLocationRes.TabIndex = 3;
            this.txtLocationRes.Text = "Location";
            // 
            // RestaurentsSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.txtLocationRes);
            this.Controls.Add(this.txtNameRes);
            this.Controls.Add(this.PicRes);
            this.Name = "RestaurentsSearchControl";
            this.Size = new System.Drawing.Size(1100, 125);
            this.Tag = "";
            this.Load += new System.EventHandler(this.RestaurentsControl_Load);
            this.DoubleClick += new System.EventHandler(this.RestaurentsSearchControl_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.PicRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PicRes;
        internal System.Windows.Forms.Label txtNameRes;
        internal System.Windows.Forms.Label txtLocationRes;
    }
}
