namespace RestaurantBooking
{
    partial class ItemWidget
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
            this.labelNameItem = new System.Windows.Forms.Label();
            this.labelPriceItem = new System.Windows.Forms.Label();
            this.pictureBoxItem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNameItem
            // 
            this.labelNameItem.AutoSize = true;
            this.labelNameItem.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameItem.Location = new System.Drawing.Point(15, 15);
            this.labelNameItem.Name = "labelNameItem";
            this.labelNameItem.Size = new System.Drawing.Size(123, 31);
            this.labelNameItem.TabIndex = 0;
            this.labelNameItem.Text = "NameItem";
            // 
            // labelPriceItem
            // 
            this.labelPriceItem.AutoSize = true;
            this.labelPriceItem.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceItem.ForeColor = System.Drawing.Color.Orange;
            this.labelPriceItem.Location = new System.Drawing.Point(15, 80);
            this.labelPriceItem.Name = "labelPriceItem";
            this.labelPriceItem.Size = new System.Drawing.Size(112, 45);
            this.labelPriceItem.TabIndex = 1;
            this.labelPriceItem.Text = "$Price";
            // 
            // pictureBoxItem
            // 
            this.pictureBoxItem.Image = global::RestaurantBooking.Properties.Resources.default_image;
            this.pictureBoxItem.Location = new System.Drawing.Point(200, 50);
            this.pictureBoxItem.Name = "pictureBoxItem";
            this.pictureBoxItem.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxItem.TabIndex = 2;
            this.pictureBoxItem.TabStop = false;
            // 
            // ItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.Controls.Add(this.pictureBoxItem);
            this.Controls.Add(this.labelPriceItem);
            this.Controls.Add(this.labelNameItem);
            this.Name = "ItemControl";
            this.Size = new System.Drawing.Size(300, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label labelNameItem;
        internal System.Windows.Forms.Label labelPriceItem;
        internal System.Windows.Forms.PictureBox pictureBoxItem;
    }
}
