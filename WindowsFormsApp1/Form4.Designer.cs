namespace WindowsFormsApp1
{
    partial class Form4
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
            this.label15 = new System.Windows.Forms.Label();
            this.ReserveGrid = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtHours2 = new System.Windows.Forms.TextBox();
            this.btnAddHours = new System.Windows.Forms.Button();
            this.btnSubHours = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRoomRate = new System.Windows.Forms.TextBox();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.bttnAddChildren = new System.Windows.Forms.Button();
            this.bttnAddAdult = new System.Windows.Forms.Button();
            this.bttnSubChildren = new System.Windows.Forms.Button();
            this.bttnSubAdult = new System.Windows.Forms.Button();
            this.txtAdults = new System.Windows.Forms.TextBox();
            this.txtChildren = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.cboRoomType = new System.Windows.Forms.ComboBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReserveGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(418, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 104;
            this.label15.Text = "Reservations";
            // 
            // ReserveGrid
            // 
            this.ReserveGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReserveGrid.Location = new System.Drawing.Point(421, 41);
            this.ReserveGrid.Name = "ReserveGrid";
            this.ReserveGrid.Size = new System.Drawing.Size(802, 315);
            this.ReserveGrid.TabIndex = 103;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1147, 616);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 53);
            this.btnBack.TabIndex = 105;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtHours2
            // 
            this.txtHours2.Location = new System.Drawing.Point(283, 206);
            this.txtHours2.Name = "txtHours2";
            this.txtHours2.Size = new System.Drawing.Size(43, 20);
            this.txtHours2.TabIndex = 135;
            // 
            // btnAddHours
            // 
            this.btnAddHours.Location = new System.Drawing.Point(254, 204);
            this.btnAddHours.Name = "btnAddHours";
            this.btnAddHours.Size = new System.Drawing.Size(23, 23);
            this.btnAddHours.TabIndex = 133;
            this.btnAddHours.Text = ">";
            this.btnAddHours.UseVisualStyleBackColor = true;
            // 
            // btnSubHours
            // 
            this.btnSubHours.Location = new System.Drawing.Point(235, 204);
            this.btnSubHours.Name = "btnSubHours";
            this.btnSubHours.Size = new System.Drawing.Size(23, 23);
            this.btnSubHours.TabIndex = 132;
            this.btnSubHours.Text = "<";
            this.btnSubHours.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 131;
            this.label2.Text = "Hours";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(191, 204);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(43, 20);
            this.txtHours.TabIndex = 130;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 129;
            this.label9.Text = "Room Rate";
            // 
            // txtRoomRate
            // 
            this.txtRoomRate.Location = new System.Drawing.Point(191, 255);
            this.txtRoomRate.Name = "txtRoomRate";
            this.txtRoomRate.Size = new System.Drawing.Size(176, 20);
            this.txtRoomRate.TabIndex = 128;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(191, 229);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(176, 20);
            this.dtpCheckOut.TabIndex = 127;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(191, 178);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(176, 20);
            this.dtpCheckIn.TabIndex = 126;
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(191, 41);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(176, 20);
            this.txtGuestName.TabIndex = 125;
            // 
            // bttnAddChildren
            // 
            this.bttnAddChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddChildren.Location = new System.Drawing.Point(254, 147);
            this.bttnAddChildren.Name = "bttnAddChildren";
            this.bttnAddChildren.Size = new System.Drawing.Size(23, 25);
            this.bttnAddChildren.TabIndex = 124;
            this.bttnAddChildren.Text = ">";
            this.bttnAddChildren.UseVisualStyleBackColor = true;
            this.bttnAddChildren.Click += new System.EventHandler(this.bttnAddChildren_Click);
            // 
            // bttnAddAdult
            // 
            this.bttnAddAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddAdult.Location = new System.Drawing.Point(254, 119);
            this.bttnAddAdult.Name = "bttnAddAdult";
            this.bttnAddAdult.Size = new System.Drawing.Size(23, 25);
            this.bttnAddAdult.TabIndex = 123;
            this.bttnAddAdult.Text = ">";
            this.bttnAddAdult.UseVisualStyleBackColor = true;
            this.bttnAddAdult.Click += new System.EventHandler(this.bttnAddAdult_Click);
            // 
            // bttnSubChildren
            // 
            this.bttnSubChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSubChildren.Location = new System.Drawing.Point(235, 147);
            this.bttnSubChildren.Name = "bttnSubChildren";
            this.bttnSubChildren.Size = new System.Drawing.Size(23, 25);
            this.bttnSubChildren.TabIndex = 122;
            this.bttnSubChildren.Text = "<";
            this.bttnSubChildren.UseVisualStyleBackColor = true;
            this.bttnSubChildren.Click += new System.EventHandler(this.bttnSubChildren_Click);
            // 
            // bttnSubAdult
            // 
            this.bttnSubAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSubAdult.Location = new System.Drawing.Point(235, 119);
            this.bttnSubAdult.Name = "bttnSubAdult";
            this.bttnSubAdult.Size = new System.Drawing.Size(23, 25);
            this.bttnSubAdult.TabIndex = 121;
            this.bttnSubAdult.Text = "<";
            this.bttnSubAdult.UseVisualStyleBackColor = true;
            this.bttnSubAdult.Click += new System.EventHandler(this.bttnSubAdult_Click);
            // 
            // txtAdults
            // 
            this.txtAdults.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAdults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdults.Location = new System.Drawing.Point(191, 120);
            this.txtAdults.Multiline = true;
            this.txtAdults.Name = "txtAdults";
            this.txtAdults.ReadOnly = true;
            this.txtAdults.Size = new System.Drawing.Size(43, 22);
            this.txtAdults.TabIndex = 120;
            this.txtAdults.Text = "0";
            this.txtAdults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChildren
            // 
            this.txtChildren.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChildren.Location = new System.Drawing.Point(191, 148);
            this.txtChildren.Multiline = true;
            this.txtChildren.Name = "txtChildren";
            this.txtChildren.ReadOnly = true;
            this.txtChildren.Size = new System.Drawing.Size(43, 22);
            this.txtChildren.TabIndex = 119;
            this.txtChildren.Text = "0";
            this.txtChildren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(88, 151);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(97, 16);
            this.Label12.TabIndex = 118;
            this.Label12.Text = "No. Of Children";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(97, 123);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(85, 16);
            this.Label10.TabIndex = 117;
            this.Label10.Text = "No. Of Adults";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 116;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(101, 322);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(120, 23);
            this.btnReserve.TabIndex = 115;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // cboRoomType
            // 
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.Location = new System.Drawing.Point(191, 67);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.Size = new System.Drawing.Size(176, 21);
            this.cboRoomType.TabIndex = 114;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(191, 281);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(176, 25);
            this.txtTotal.TabIndex = 113;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(191, 94);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(176, 20);
            this.txtRoomNumber.TabIndex = 112;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 111;
            this.label8.Text = "Total Balance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 110;
            this.label7.Text = "Check Out Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 109;
            this.label6.Text = "Check In Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 108;
            this.label5.Text = "Room Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 107;
            this.label4.Text = "Room Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 106;
            this.label3.Text = "Guest Name\n";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.txtHours2);
            this.Controls.Add(this.btnAddHours);
            this.Controls.Add(this.btnSubHours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtRoomRate);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.bttnAddChildren);
            this.Controls.Add(this.bttnAddAdult);
            this.Controls.Add(this.bttnSubChildren);
            this.Controls.Add(this.bttnSubAdult);
            this.Controls.Add(this.txtAdults);
            this.Controls.Add(this.txtChildren);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.cboRoomType);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ReserveGrid);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation Form";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReserveGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView ReserveGrid;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtHours2;
        private System.Windows.Forms.Button btnAddHours;
        private System.Windows.Forms.Button btnSubHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRoomRate;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.TextBox txtGuestName;
        internal System.Windows.Forms.Button bttnAddChildren;
        internal System.Windows.Forms.Button bttnAddAdult;
        internal System.Windows.Forms.Button bttnSubChildren;
        internal System.Windows.Forms.Button bttnSubAdult;
        internal System.Windows.Forms.TextBox txtAdults;
        internal System.Windows.Forms.TextBox txtChildren;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.ComboBox cboRoomType;
        internal System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}