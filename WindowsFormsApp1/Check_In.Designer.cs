namespace WindowsFormsApp1
{
    partial class Check_In
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cboRoomType = new System.Windows.Forms.ComboBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtChildren = new System.Windows.Forms.TextBox();
            this.txtAdults = new System.Windows.Forms.TextBox();
            this.bttnSubAdult = new System.Windows.Forms.Button();
            this.bttnSubChildren = new System.Windows.Forms.Button();
            this.bttnAddAdult = new System.Windows.Forms.Button();
            this.bttnAddChildren = new System.Windows.Forms.Button();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.checkingrid = new System.Windows.Forms.DataGridView();
            this.txtRoomRate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AmeditiesGrid = new System.Windows.Forms.DataGridView();
            this.btnInclude = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubHours = new System.Windows.Forms.Button();
            this.btnAddHours = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.checkingrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmeditiesGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHECK IN FORM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Guest Name\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Room Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Room Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Check In Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Check Out Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total Balance";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(106, 80);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(176, 20);
            this.txtRoomNumber.TabIndex = 8;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(106, 267);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(176, 25);
            this.txtTotal.TabIndex = 59;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboRoomType
            // 
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.Location = new System.Drawing.Point(106, 53);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.Size = new System.Drawing.Size(176, 21);
            this.cboRoomType.TabIndex = 61;
            this.cboRoomType.SelectedIndexChanged += new System.EventHandler(this.txtcombo1_SelectedIndexChanged);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(16, 308);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(120, 23);
            this.btnCheckIn.TabIndex = 62;
            this.btnCheckIn.Text = "Check-In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(150, 308);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 23);
            this.btnBack.TabIndex = 63;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(12, 109);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(85, 16);
            this.Label10.TabIndex = 74;
            this.Label10.Text = "No. Of Adults";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(3, 137);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(97, 16);
            this.Label12.TabIndex = 75;
            this.Label12.Text = "No. Of Children";
            // 
            // txtChildren
            // 
            this.txtChildren.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChildren.Location = new System.Drawing.Point(106, 134);
            this.txtChildren.Multiline = true;
            this.txtChildren.Name = "txtChildren";
            this.txtChildren.ReadOnly = true;
            this.txtChildren.Size = new System.Drawing.Size(43, 22);
            this.txtChildren.TabIndex = 76;
            this.txtChildren.Text = "0";
            this.txtChildren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAdults
            // 
            this.txtAdults.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAdults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdults.Location = new System.Drawing.Point(106, 106);
            this.txtAdults.Multiline = true;
            this.txtAdults.Name = "txtAdults";
            this.txtAdults.ReadOnly = true;
            this.txtAdults.Size = new System.Drawing.Size(43, 22);
            this.txtAdults.TabIndex = 77;
            this.txtAdults.Text = "0";
            this.txtAdults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bttnSubAdult
            // 
            this.bttnSubAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSubAdult.Location = new System.Drawing.Point(150, 105);
            this.bttnSubAdult.Name = "bttnSubAdult";
            this.bttnSubAdult.Size = new System.Drawing.Size(23, 25);
            this.bttnSubAdult.TabIndex = 78;
            this.bttnSubAdult.Text = "<";
            this.bttnSubAdult.UseVisualStyleBackColor = true;
            this.bttnSubAdult.Click += new System.EventHandler(this.bttnSubAdult_Click);
            // 
            // bttnSubChildren
            // 
            this.bttnSubChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSubChildren.Location = new System.Drawing.Point(150, 133);
            this.bttnSubChildren.Name = "bttnSubChildren";
            this.bttnSubChildren.Size = new System.Drawing.Size(23, 25);
            this.bttnSubChildren.TabIndex = 79;
            this.bttnSubChildren.Text = "<";
            this.bttnSubChildren.UseVisualStyleBackColor = true;
            this.bttnSubChildren.Click += new System.EventHandler(this.bttnSubChildren_Click);
            // 
            // bttnAddAdult
            // 
            this.bttnAddAdult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddAdult.Location = new System.Drawing.Point(169, 105);
            this.bttnAddAdult.Name = "bttnAddAdult";
            this.bttnAddAdult.Size = new System.Drawing.Size(23, 25);
            this.bttnAddAdult.TabIndex = 80;
            this.bttnAddAdult.Text = ">";
            this.bttnAddAdult.UseVisualStyleBackColor = true;
            this.bttnAddAdult.Click += new System.EventHandler(this.bttnAddAdult_Click);
            // 
            // bttnAddChildren
            // 
            this.bttnAddChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddChildren.Location = new System.Drawing.Point(169, 133);
            this.bttnAddChildren.Name = "bttnAddChildren";
            this.bttnAddChildren.Size = new System.Drawing.Size(23, 25);
            this.bttnAddChildren.TabIndex = 81;
            this.bttnAddChildren.Text = ">";
            this.bttnAddChildren.UseVisualStyleBackColor = true;
            this.bttnAddChildren.Click += new System.EventHandler(this.bttnAddChildren_Click);
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(106, 27);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(176, 20);
            this.txtGuestName.TabIndex = 82;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(106, 164);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(176, 20);
            this.dtpCheckIn.TabIndex = 83;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(106, 215);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(176, 20);
            this.dtpCheckOut.TabIndex = 84;
            // 
            // checkingrid
            // 
            this.checkingrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkingrid.Location = new System.Drawing.Point(357, 12);
            this.checkingrid.Name = "checkingrid";
            this.checkingrid.Size = new System.Drawing.Size(497, 280);
            this.checkingrid.TabIndex = 85;
            // 
            // txtRoomRate
            // 
            this.txtRoomRate.Location = new System.Drawing.Point(106, 241);
            this.txtRoomRate.Name = "txtRoomRate";
            this.txtRoomRate.Size = new System.Drawing.Size(176, 20);
            this.txtRoomRate.TabIndex = 86;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 87;
            this.label9.Text = "Room Rate";
            // 
            // AmeditiesGrid
            // 
            this.AmeditiesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AmeditiesGrid.Location = new System.Drawing.Point(860, 12);
            this.AmeditiesGrid.Name = "AmeditiesGrid";
            this.AmeditiesGrid.Size = new System.Drawing.Size(276, 150);
            this.AmeditiesGrid.TabIndex = 89;
            // 
            // btnInclude
            // 
            this.btnInclude.Location = new System.Drawing.Point(860, 170);
            this.btnInclude.Name = "btnInclude";
            this.btnInclude.Size = new System.Drawing.Size(96, 23);
            this.btnInclude.TabIndex = 90;
            this.btnInclude.Text = "Include Amedity";
            this.btnInclude.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddHours);
            this.panel1.Controls.Add(this.btnSubHours);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtHours);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnInclude);
            this.panel1.Controls.Add(this.AmeditiesGrid);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtRoomRate);
            this.panel1.Controls.Add(this.checkingrid);
            this.panel1.Controls.Add(this.dtpCheckOut);
            this.panel1.Controls.Add(this.dtpCheckIn);
            this.panel1.Controls.Add(this.txtGuestName);
            this.panel1.Controls.Add(this.bttnAddChildren);
            this.panel1.Controls.Add(this.bttnAddAdult);
            this.panel1.Controls.Add(this.bttnSubChildren);
            this.panel1.Controls.Add(this.bttnSubAdult);
            this.panel1.Controls.Add(this.txtAdults);
            this.panel1.Controls.Add(this.txtChildren);
            this.panel1.Controls.Add(this.Label12);
            this.panel1.Controls.Add(this.Label10);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnCheckIn);
            this.panel1.Controls.Add(this.cboRoomType);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.txtRoomNumber);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 657);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(357, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(497, 150);
            this.dataGridView1.TabIndex = 91;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(106, 190);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(43, 20);
            this.txtHours.TabIndex = 92;
            this.txtHours.TextChanged += new System.EventHandler(this.txtHours_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 93;
            this.label2.Text = "Hours";
            // 
            // btnSubHours
            // 
            this.btnSubHours.Location = new System.Drawing.Point(150, 190);
            this.btnSubHours.Name = "btnSubHours";
            this.btnSubHours.Size = new System.Drawing.Size(23, 23);
            this.btnSubHours.TabIndex = 94;
            this.btnSubHours.Text = "<";
            this.btnSubHours.UseVisualStyleBackColor = true;
            this.btnSubHours.Click += new System.EventHandler(this.btnSubHours_Click);
            // 
            // btnAddHours
            // 
            this.btnAddHours.Location = new System.Drawing.Point(169, 190);
            this.btnAddHours.Name = "btnAddHours";
            this.btnAddHours.Size = new System.Drawing.Size(23, 23);
            this.btnAddHours.TabIndex = 95;
            this.btnAddHours.Text = ">";
            this.btnAddHours.UseVisualStyleBackColor = true;
            this.btnAddHours.Click += new System.EventHandler(this.btnAddHours_Click);
            // 
            // Check_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Name = "Check_In";
            this.Text = "Check_In";
            ((System.ComponentModel.ISupportInitialize)(this.checkingrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmeditiesGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRoomNumber;
        internal System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cboRoomType;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox txtChildren;
        internal System.Windows.Forms.TextBox txtAdults;
        internal System.Windows.Forms.Button bttnSubAdult;
        internal System.Windows.Forms.Button bttnSubChildren;
        internal System.Windows.Forms.Button bttnAddAdult;
        internal System.Windows.Forms.Button bttnAddChildren;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.DataGridView checkingrid;
        private System.Windows.Forms.TextBox txtRoomRate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView AmeditiesGrid;
        private System.Windows.Forms.Button btnInclude;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Button btnAddHours;
        private System.Windows.Forms.Button btnSubHours;
    }
}