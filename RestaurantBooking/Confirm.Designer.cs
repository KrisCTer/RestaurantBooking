namespace RestaurantBooking
{
    partial class Confirm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelReservationInformation = new System.Windows.Forms.Label();
            this.labelNameRes = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnComfirm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelNote = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelBooker = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPeople = new System.Windows.Forms.Label();
            this.labelPriceRes = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelClosingRes = new System.Windows.Forms.Label();
            this.labelOpenningRes = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.labelReservationInformation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 48);
            this.panel1.TabIndex = 3;
            // 
            // labelReservationInformation
            // 
            this.labelReservationInformation.AutoSize = true;
            this.labelReservationInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReservationInformation.Location = new System.Drawing.Point(206, 10);
            this.labelReservationInformation.Name = "labelReservationInformation";
            this.labelReservationInformation.Size = new System.Drawing.Size(385, 38);
            this.labelReservationInformation.TabIndex = 1;
            this.labelReservationInformation.Text = "Reservation Information";
            // 
            // labelNameRes
            // 
            this.labelNameRes.AutoSize = true;
            this.labelNameRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameRes.Location = new System.Drawing.Point(10, 51);
            this.labelNameRes.Name = "labelNameRes";
            this.labelNameRes.Size = new System.Drawing.Size(319, 46);
            this.labelNameRes.TabIndex = 5;
            this.labelNameRes.Text = "Uiiia Restaurant";
            // 
            // txtNote
            // 
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(0, 0);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(782, 150);
            this.txtNote.TabIndex = 7;
            // 
            // btnComfirm
            // 
            this.btnComfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnComfirm.Location = new System.Drawing.Point(0, 0);
            this.btnComfirm.Name = "btnComfirm";
            this.btnComfirm.Size = new System.Drawing.Size(782, 50);
            this.btnComfirm.TabIndex = 8;
            this.btnComfirm.Text = "Comfirm reservation";
            this.btnComfirm.UseVisualStyleBackColor = true;
            this.btnComfirm.Click += new System.EventHandler(this.btnComfirm_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnComfirm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 453);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 50);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtNote);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 303);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(782, 150);
            this.panel3.TabIndex = 10;
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.Location = new System.Drawing.Point(12, 268);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(74, 32);
            this.labelNote.TabIndex = 11;
            this.labelNote.Text = "Note";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.labelBooker, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.labelPeople, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelPriceRes, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.labelDate, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelTime, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelClosingRes, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelOpenningRes, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(18, 100);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(300, 165);
            this.tableLayoutPanel.TabIndex = 13;
            // 
            // labelBooker
            // 
            this.labelBooker.AutoSize = true;
            this.labelBooker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBooker.Location = new System.Drawing.Point(153, 123);
            this.labelBooker.Name = "labelBooker";
            this.labelBooker.Size = new System.Drawing.Size(91, 29);
            this.labelBooker.TabIndex = 14;
            this.labelBooker.Text = "Booker";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Booker";
            // 
            // labelPeople
            // 
            this.labelPeople.AutoSize = true;
            this.labelPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeople.Location = new System.Drawing.Point(153, 82);
            this.labelPeople.Name = "labelPeople";
            this.labelPeople.Size = new System.Drawing.Size(91, 29);
            this.labelPeople.TabIndex = 12;
            this.labelPeople.Text = "People";
            // 
            // labelPriceRes
            // 
            this.labelPriceRes.AutoSize = true;
            this.labelPriceRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceRes.Location = new System.Drawing.Point(3, 82);
            this.labelPriceRes.Name = "labelPriceRes";
            this.labelPriceRes.Size = new System.Drawing.Size(91, 29);
            this.labelPriceRes.TabIndex = 7;
            this.labelPriceRes.Text = "People";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(153, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(63, 29);
            this.labelDate.TabIndex = 11;
            this.labelDate.Text = "Date";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(153, 41);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(69, 29);
            this.labelTime.TabIndex = 10;
            this.labelTime.Text = "Time";
            // 
            // labelClosingRes
            // 
            this.labelClosingRes.AutoSize = true;
            this.labelClosingRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClosingRes.Location = new System.Drawing.Point(3, 41);
            this.labelClosingRes.Name = "labelClosingRes";
            this.labelClosingRes.Size = new System.Drawing.Size(69, 29);
            this.labelClosingRes.TabIndex = 9;
            this.labelClosingRes.Text = "Time";
            // 
            // labelOpenningRes
            // 
            this.labelOpenningRes.AutoSize = true;
            this.labelOpenningRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpenningRes.Location = new System.Drawing.Point(3, 0);
            this.labelOpenningRes.Name = "labelOpenningRes";
            this.labelOpenningRes.Size = new System.Drawing.Size(63, 29);
            this.labelOpenningRes.TabIndex = 8;
            this.labelOpenningRes.Text = "Date";
            // 
            // Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelNameRes);
            this.Controls.Add(this.panel1);
            this.Name = "Confirm";
            this.Text = "Confirm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label labelReservationInformation;
        internal System.Windows.Forms.Label labelNameRes;
        internal System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnComfirm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label labelNote;
        internal System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        internal System.Windows.Forms.Label labelPeople;
        internal System.Windows.Forms.Label labelPriceRes;
        internal System.Windows.Forms.Label labelDate;
        internal System.Windows.Forms.Label labelTime;
        internal System.Windows.Forms.Label labelClosingRes;
        internal System.Windows.Forms.Label labelOpenningRes;
        internal System.Windows.Forms.Label labelBooker;
        internal System.Windows.Forms.Label label1;
    }
}