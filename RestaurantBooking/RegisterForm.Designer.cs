namespace RestaurantBooking
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.panel = new System.Windows.Forms.Panel();
            this.register_Email = new System.Windows.Forms.TextBox();
            this.registerShowPassword = new System.Windows.Forms.CheckBox();
            this.register_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.register_Password = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelSignIn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.register_Signup = new System.Windows.Forms.Button();
            this.register_Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.register_Back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(177)))));
            this.panel.Controls.Add(this.register_Email);
            this.panel.Controls.Add(this.registerShowPassword);
            this.panel.Controls.Add(this.register_ConfirmPassword);
            this.panel.Controls.Add(this.register_Password);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Controls.Add(this.labelSignIn);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.register_Signup);
            this.panel.Controls.Add(this.register_Username);
            this.panel.Controls.Add(this.label1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(500, 603);
            this.panel.TabIndex = 1;
            // 
            // register_Email
            // 
            this.register_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.register_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_Email.ForeColor = System.Drawing.Color.Gray;
            this.register_Email.Location = new System.Drawing.Point(100, 251);
            this.register_Email.Name = "register_Email";
            this.register_Email.Size = new System.Drawing.Size(300, 27);
            this.register_Email.TabIndex = 10;
            this.register_Email.Text = "Email";
            this.register_Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Register_KeyPress);
            // 
            // registerShowPassword
            // 
            this.registerShowPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerShowPassword.AutoSize = true;
            this.registerShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerShowPassword.Location = new System.Drawing.Point(249, 401);
            this.registerShowPassword.Name = "registerShowPassword";
            this.registerShowPassword.Size = new System.Drawing.Size(151, 24);
            this.registerShowPassword.TabIndex = 9;
            this.registerShowPassword.Text = "Show Password";
            this.registerShowPassword.UseVisualStyleBackColor = true;
            this.registerShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // register_ConfirmPassword
            // 
            this.register_ConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.register_ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_ConfirmPassword.ForeColor = System.Drawing.Color.Gray;
            this.register_ConfirmPassword.Location = new System.Drawing.Point(100, 351);
            this.register_ConfirmPassword.Name = "register_ConfirmPassword";
            this.register_ConfirmPassword.Size = new System.Drawing.Size(300, 27);
            this.register_ConfirmPassword.TabIndex = 8;
            this.register_ConfirmPassword.Text = "Confirm Password";
            this.register_ConfirmPassword.TextChanged += new System.EventHandler(this.register_TextChanged);
            this.register_ConfirmPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Register_KeyPress);
            // 
            // register_Password
            // 
            this.register_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.register_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_Password.ForeColor = System.Drawing.Color.Gray;
            this.register_Password.Location = new System.Drawing.Point(100, 301);
            this.register_Password.Name = "register_Password";
            this.register_Password.Size = new System.Drawing.Size(300, 27);
            this.register_Password.TabIndex = 7;
            this.register_Password.Text = "Password";
            this.register_Password.TextChanged += new System.EventHandler(this.register_TextChanged);
            this.register_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Register_KeyPress);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.ErrorImage = null;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(225, 76);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(50, 50);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // labelSignIn
            // 
            this.labelSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSignIn.AutoSize = true;
            this.labelSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignIn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelSignIn.Location = new System.Drawing.Point(275, 451);
            this.labelSignIn.Name = "labelSignIn";
            this.labelSignIn.Size = new System.Drawing.Size(98, 20);
            this.labelSignIn.TabIndex = 5;
            this.labelSignIn.Text = "Sign in here";
            this.labelSignIn.Click += new System.EventHandler(this.labelSignIn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Have no account yet?";
            // 
            // register_Signup
            // 
            this.register_Signup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.register_Signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(172)))), ((int)(((byte)(92)))));
            this.register_Signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_Signup.FlatAppearance.BorderSize = 0;
            this.register_Signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_Signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_Signup.Location = new System.Drawing.Point(125, 501);
            this.register_Signup.Name = "register_Signup";
            this.register_Signup.Size = new System.Drawing.Size(250, 50);
            this.register_Signup.TabIndex = 3;
            this.register_Signup.Text = "Signup";
            this.register_Signup.UseVisualStyleBackColor = false;
            this.register_Signup.Click += new System.EventHandler(this.buttonSignup_Click);
            // 
            // register_Username
            // 
            this.register_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.register_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_Username.ForeColor = System.Drawing.Color.Gray;
            this.register_Username.Location = new System.Drawing.Point(100, 201);
            this.register_Username.Name = "register_Username";
            this.register_Username.Size = new System.Drawing.Size(300, 27);
            this.register_Username.TabIndex = 1;
            this.register_Username.Text = "Username";
            this.register_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Register_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Account";
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
            this.register_Back.TabIndex = 2;
            this.register_Back.Text = "X";
            this.register_Back.UseVisualStyleBackColor = false;
            this.register_Back.Click += new System.EventHandler(this.register_Back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::RestaurantBooking.Properties.Resources.Login;
            this.pictureBox1.Location = new System.Drawing.Point(500, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(682, 603);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(79)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.ControlBox = false;
            this.Controls.Add(this.register_Back);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Account";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox register_Password;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelSignIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button register_Signup;
        private System.Windows.Forms.TextBox register_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox register_ConfirmPassword;
        private System.Windows.Forms.CheckBox registerShowPassword;
        private System.Windows.Forms.TextBox register_Email;
        private System.Windows.Forms.Button register_Back;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}