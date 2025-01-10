namespace RestaurantBooking
{
    partial class LoginOrSignupControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.LOS_LoginSignup = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 92);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Login/Sign up \n to use this function";
            // 
            // LOS_LoginSignup
            // 
            this.LOS_LoginSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LOS_LoginSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOS_LoginSignup.Location = new System.Drawing.Point(400, 650);
            this.LOS_LoginSignup.Name = "LOS_LoginSignup";
            this.LOS_LoginSignup.Size = new System.Drawing.Size(421, 50);
            this.LOS_LoginSignup.TabIndex = 1;
            this.LOS_LoginSignup.Text = "Login/Sign up";
            this.LOS_LoginSignup.UseVisualStyleBackColor = true;
            this.LOS_LoginSignup.Click += new System.EventHandler(this.LOS_LoginSignup_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RestaurantBooking.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(508, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LoginOrSignupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LOS_LoginSignup);
            this.Controls.Add(this.label1);
            this.Name = "LoginOrSignupControl";
            this.Size = new System.Drawing.Size(1200, 950);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LOS_LoginSignup;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
