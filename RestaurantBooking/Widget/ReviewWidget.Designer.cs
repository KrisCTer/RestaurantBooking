namespace RestaurantBooking.Widget
{
    partial class ReviewWidget
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
            this.txtNameRes = new System.Windows.Forms.Label();
            this.txtNameUser = new System.Windows.Forms.Label();
            this.txtRating = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNameRes
            // 
            this.txtNameRes.AutoSize = true;
            this.txtNameRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameRes.Location = new System.Drawing.Point(283, 10);
            this.txtNameRes.Name = "txtNameRes";
            this.txtNameRes.Size = new System.Drawing.Size(288, 38);
            this.txtNameRes.TabIndex = 4;
            this.txtNameRes.Text = "Name Restaurant";
            // 
            // txtNameUser
            // 
            this.txtNameUser.AutoSize = true;
            this.txtNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameUser.Location = new System.Drawing.Point(283, 48);
            this.txtNameUser.Name = "txtNameUser";
            this.txtNameUser.Size = new System.Drawing.Size(192, 38);
            this.txtNameUser.TabIndex = 5;
            this.txtNameUser.Text = "Name User";
            // 
            // txtRating
            // 
            this.txtRating.AutoSize = true;
            this.txtRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRating.Location = new System.Drawing.Point(285, 90);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(102, 36);
            this.txtRating.TabIndex = 6;
            this.txtRating.Text = "Rating";
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Location = new System.Drawing.Point(290, 126);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ReadOnly = true;
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComment.Size = new System.Drawing.Size(750, 100);
            this.txtComment.TabIndex = 7;
            // 
            // picUser
            // 
            this.picUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.picUser.Location = new System.Drawing.Point(0, 0);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(250, 250);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 0;
            this.picUser.TabStop = false;
            // 
            // ReviewWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtNameUser);
            this.Controls.Add(this.txtNameRes);
            this.Controls.Add(this.picUser);
            this.Name = "ReviewWidget";
            this.Size = new System.Drawing.Size(1100, 250);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox picUser;
        internal System.Windows.Forms.Label txtNameRes;
        internal System.Windows.Forms.Label txtNameUser;
        internal System.Windows.Forms.Label txtRating;
        internal System.Windows.Forms.TextBox txtComment;
    }
}
