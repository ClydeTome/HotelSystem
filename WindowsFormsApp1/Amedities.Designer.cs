namespace WindowsFormsApp1
{
    partial class Amedities
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
            this.AmeditiesGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAmePrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAme = new System.Windows.Forms.Button();
            this.txtAmeName = new System.Windows.Forms.TextBox();
            this.txtAmeID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AmeditiesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amenities Control";
            // 
            // AmeditiesGrid
            // 
            this.AmeditiesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AmeditiesGrid.Location = new System.Drawing.Point(35, 58);
            this.AmeditiesGrid.Name = "AmeditiesGrid";
            this.AmeditiesGrid.Size = new System.Drawing.Size(424, 247);
            this.AmeditiesGrid.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(482, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Amenity Price";
            // 
            // txtAmePrice
            // 
            this.txtAmePrice.Location = new System.Drawing.Point(485, 164);
            this.txtAmePrice.Name = "txtAmePrice";
            this.txtAmePrice.Size = new System.Drawing.Size(137, 20);
            this.txtAmePrice.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(482, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Amenity Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(482, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Amenity ID";
            // 
            // btnAme
            // 
            this.btnAme.Location = new System.Drawing.Point(485, 209);
            this.btnAme.Name = "btnAme";
            this.btnAme.Size = new System.Drawing.Size(92, 42);
            this.btnAme.TabIndex = 26;
            this.btnAme.Text = "Add Amenity";
            this.btnAme.UseVisualStyleBackColor = true;
            this.btnAme.Click += new System.EventHandler(this.btnAme_Click);
            // 
            // txtAmeName
            // 
            this.txtAmeName.Location = new System.Drawing.Point(485, 119);
            this.txtAmeName.Name = "txtAmeName";
            this.txtAmeName.Size = new System.Drawing.Size(137, 20);
            this.txtAmeName.TabIndex = 25;
            // 
            // txtAmeID
            // 
            this.txtAmeID.Location = new System.Drawing.Point(485, 74);
            this.txtAmeID.Name = "txtAmeID";
            this.txtAmeID.Size = new System.Drawing.Size(137, 20);
            this.txtAmeID.TabIndex = 24;
            // 
            // Amedities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(705, 452);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAmePrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAme);
            this.Controls.Add(this.txtAmeName);
            this.Controls.Add(this.txtAmeID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AmeditiesGrid);
            this.Controls.Add(this.label1);
            this.Name = "Amedities";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amenities";
            ((System.ComponentModel.ISupportInitialize)(this.AmeditiesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AmeditiesGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAmePrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAme;
        private System.Windows.Forms.TextBox txtAmeName;
        private System.Windows.Forms.TextBox txtAmeID;
    }
}