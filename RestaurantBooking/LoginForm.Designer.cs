using System.Drawing;

namespace RestaurantBooking
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel = new System.Windows.Forms.Panel();
            this.loginShowPassword = new System.Windows.Forms.CheckBox();
            this.login_Password = new System.Windows.Forms.TextBox();
            this.labelRegister = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_btbLogin = new System.Windows.Forms.Button();
            this.login_Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.register_Back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(177)))));
            this.panel.Controls.Add(this.loginShowPassword);
            this.panel.Controls.Add(this.login_Password);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Controls.Add(this.labelRegister);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.login_btbLogin);
            this.panel.Controls.Add(this.login_Username);
            this.panel.Controls.Add(this.label1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(500, 603);
            this.panel.TabIndex = 0;
            // 
            // loginShowPassword
            // 
            this.loginShowPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginShowPassword.AutoSize = true;
            this.loginShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginShowPassword.Location = new System.Drawing.Point(250, 326);
            this.loginShowPassword.Name = "loginShowPassword";
            this.loginShowPassword.Size = new System.Drawing.Size(151, 24);
            this.loginShowPassword.TabIndex = 10;
            this.loginShowPassword.Text = "Show Password";
            this.loginShowPassword.UseVisualStyleBackColor = true;
            this.loginShowPassword.CheckedChanged += new System.EventHandler(this.registerShowPassword_CheckedChanged);
            // 
            // login_Password
            // 
            this.login_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Password.ForeColor = System.Drawing.Color.Gray;
            this.login_Password.Location = new System.Drawing.Point(100, 276);
            this.login_Password.Name = "login_Password";
            this.login_Password.Size = new System.Drawing.Size(300, 27);
            this.login_Password.TabIndex = 7;
            this.login_Password.Text = "Password";
            this.login_Password.TextChanged += new System.EventHandler(this.login_Password_TextChanged);
            this.login_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Register_KeyPress);
            // 
            // labelRegister
            // 
            this.labelRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRegister.AutoSize = true;
            this.labelRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelRegister.Location = new System.Drawing.Point(275, 376);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(110, 20);
            this.labelRegister.TabIndex = 5;
            this.labelRegister.Text = "Register here";
            this.labelRegister.Click += new System.EventHandler(this.labelRegister_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Have no account yet?";
            // 
            // login_btbLogin
            // 
            this.login_btbLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_btbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(172)))), ((int)(((byte)(92)))));
            this.login_btbLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btbLogin.FlatAppearance.BorderSize = 0;
            this.login_btbLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btbLogin.Location = new System.Drawing.Point(125, 426);
            this.login_btbLogin.Name = "login_btbLogin";
            this.login_btbLogin.Size = new System.Drawing.Size(250, 50);
            this.login_btbLogin.TabIndex = 3;
            this.login_btbLogin.Text = "Login";
            this.login_btbLogin.UseVisualStyleBackColor = false;
            this.login_btbLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // login_Username
            // 
            this.login_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Username.ForeColor = System.Drawing.Color.Gray;
            this.login_Username.Location = new System.Drawing.Point(100, 226);
            this.login_Username.Name = "login_Username";
            this.login_Username.Size = new System.Drawing.Size(300, 27);
            this.login_Username.TabIndex = 1;
            this.login_Username.Text = "Username";
            this.login_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Register_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Account";
            // 
            // register_Back
            // 
            this.register_Back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.register_Back.BackColor = System.Drawing.Color.Red;
            this.register_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_Back.ForeColor = System.Drawing.SystemColors.Desktop;
            this.register_Back.Location = new System.Drawing.Point(1100, 25);
            this.register_Back.Name = "register_Back";
            this.register_Back.Size = new System.Drawing.Size(50, 50);
            this.register_Back.TabIndex = 3;
            this.register_Back.Text = "X";
            this.register_Back.UseVisualStyleBackColor = false;
            this.register_Back.Click += new System.EventHandler(this.register_Back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::RestaurantBooking.Properties.Resources.Register;
            this.pictureBox1.Location = new System.Drawing.Point(500, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(682, 603);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.ErrorImage = null;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(225, 101);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(50, 50);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.ControlBox = false;
            this.Controls.Add(this.register_Back);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Account";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login_btbLogin;
        private System.Windows.Forms.TextBox login_Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox login_Password;
        private System.Windows.Forms.CheckBox loginShowPassword;
        private System.Windows.Forms.Button register_Back;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}