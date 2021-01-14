﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Check_In : Form
    {
        public Check_In()
        {
            InitializeComponent();
            FillCombo();
            DataGridUno();
            txtHours2.Hide();
        }
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2BAN13A\SQLEXPRESS;Initial Catalog=HotelReservation;Integrated Security=True");
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-40PIGQM;Initial Catalog=HotelReservation;Integrated Security=True");
        int adult = 0;
        int child = 0;
        int hour = 0;
        
        void FillCombo()
        {

            string query = "SELECT RoomType FROM RegisterRoomTable";
            SqlCommand cmddb = new SqlCommand(query, conn);
            SqlDataReader mreader;
            try
            {
                conn.Open();
                mreader = cmddb.ExecuteReader();
                while (mreader.Read())
                {
                    string SRType = mreader["RoomType"].ToString();
                    cboRoomType.Items.Add(SRType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        void Clear_Text()
        {
            txtGuestName.Clear();
            txtRoomNumber.Clear();
            txtRoomRate.Clear();
            txtTotal.Clear();
            txtChildren.Text = "0";
            txtAdults.Text = "0";
            txtHours.Text = "";

        }

        void DataGridUno()
        {
            SqlCommand comm = new SqlCommand("select * from CHECKIN", conn);
            DataSet dataset = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(comm);
            sda.Fill(dataset);
            checkingrid.DataSource = dataset.Tables[0];
            checkingrid.RowTemplate.Height = 20;
            checkingrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            SqlCommand comm2 = new SqlCommand("select * from Amedities", conn);
            DataSet dataset2 = new DataSet();
            SqlDataAdapter sda2 = new SqlDataAdapter(comm2);
            sda2.Fill(dataset2);
            AmeditiesGrid.DataSource = dataset2.Tables[0];
            AmeditiesGrid.RowTemplate.Height = 20;
            AmeditiesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            SqlCommand comm3 = new SqlCommand("select * from Reservations", conn);
            DataSet dataset3 = new DataSet();
            SqlDataAdapter sda3 = new SqlDataAdapter(comm3);
            sda3.Fill(dataset3);
            ReserveGrid.DataSource = dataset3.Tables[0];
            ReserveGrid.RowTemplate.Height = 20;
            ReserveGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtGuestName.Text.Equals(""))
            {
                MessageBox.Show("Guest Name Cannot Be Empty");
            }
            else {
                double hours = int.Parse(txtHours.Text);
                string insertQuery = "INSERT INTO CHECKIN VALUES ('" + txtGuestName.Text.Trim() + "','"
                   + cboRoomType.Text.Trim() + "','" + txtRoomNumber.Text.Trim() + "','" + txtAdults.Text.Trim() +
                   "','" + txtChildren.Text.Trim() + "','" + dtpCheckIn.Text + DateTime.Now.ToString(" h:mm:ss tt") + "','"
                   + dtpCheckOut.Text + DateTime.Now.AddHours(hours).ToString(" h:mm:ss tt") + "','" + txtTotal.Text.Trim() + "','" + DateTime.Now.ToString("yyyy-MMdd-t-HH-mmss" + txtHours.Text) + "');";

                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                conn.Open();
                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Check-In Successful!");
                    }
                    else
                    {
                        MessageBox.Show("Error in Checking-In");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
                DataGridUno();
                Clear_Text();
            }
        }

        private void txtcombo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string sqlQuery = "SELECT * FROM RegisterRoomTable WHERE RoomType = '" + cboRoomType.Text + "'";
            SqlCommand objCommand = new SqlCommand(sqlQuery, conn);
            conn.Open();
            SqlDataReader dr;
            dr = objCommand.ExecuteReader();
            while (dr.Read())
            {
                string Tname = (string)dr["RoomID"].ToString();
                txtRoomNumber.Text = Tname;
                string RRate = (string)dr["RoomRate"].ToString();
                txtRoomRate.Text = RRate;
            }
            conn.Close();
            if (txtHours.Text.Equals(""))
            {
                txtHours.Text = "0";
            }
            else if (txtRoomRate.Text.Equals(""))
            {
                txtRoomRate.Text = "0";
            }
            DateTime startTime = Convert.ToDateTime(dtpCheckIn.Value);
            DateTime endTime = Convert.ToDateTime(dtpCheckOut.Value);
            TimeSpan span = endTime.Subtract(startTime);
            double hours = int.Parse(txtHours.Text);
            double rates = int.Parse(txtRoomRate.Text);
            double totalbal = Math.Round(hours * rates);
            txtTotal.Text = totalbal.ToString();
        }

        private void bttnSubAdult_Click(object sender, EventArgs e)
        {
            if (adult != 0)
            {
                adult--;
                txtAdults.Text = adult.ToString();
            }
            else
            {
                MessageBox.Show("cannot have below zero");
            }
        }

        private void bttnAddAdult_Click(object sender, EventArgs e)
        {
            adult++;
            txtAdults.Text = adult.ToString();
        }

        private void bttnAddChildren_Click(object sender, EventArgs e)
        {
            child++;
            txtChildren.Text = child.ToString();
        }

        private void bttnSubChildren_Click(object sender, EventArgs e)
        {
            if (child != 0)
            {
                child--;
                txtChildren.Text = child.ToString();
            }
            else
            {
                MessageBox.Show("cannot have below zero");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 mainform = new Form2();
            mainform.Show();
        }

        private void txtHours_TextChanged(object sender, EventArgs e)
        {
            if (txtHours.Text.Equals(""))
            {
                txtHours.Text = "0";
            }
            else if (txtRoomRate.Text.Equals(""))
            {
                txtRoomRate.Text = "0";
            }
            DateTime startTime = Convert.ToDateTime(dtpCheckIn.Value);
            DateTime endTime = Convert.ToDateTime(dtpCheckOut.Value);
            TimeSpan span = endTime.Subtract(startTime);
            double hours = int.Parse(txtHours.Text);
            double rates = int.Parse(txtRoomRate.Text);
            double totalbal = Math.Round(hours * rates);
            txtTotal.Text = totalbal.ToString();
        }

        private void btnSubHours_Click(object sender, EventArgs e)
        {
            if (hour != 0)
            {
                hour--;
                txtHours.Text = hour.ToString();
            }
            else
            {
                MessageBox.Show("cannot have below zero");
            }
        }

        private void btnAddHours_Click(object sender, EventArgs e)
        {
            hour++;
            txtHours.Text = hour.ToString();
        }

        private void checkingrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.checkingrid.Rows[e.RowIndex];

                amedtextb1.Text = row.Cells[8].Value.ToString();
                amedtextb2.Text = row.Cells[0].Value.ToString();

            }
        }

        private void btnInclude_Click(object sender, EventArgs e)
        {

        }

        private void reservebtn1_Click(object sender, EventArgs e)
        {

            if (txtGuestName.Text.Equals(""))
            {
                MessageBox.Show("Guest Name Cannot Be Empty");
            }
            else {
                double hours = int.Parse(txtHours.Text);
                string insertQuery = "INSERT INTO Reservations VALUES ('" + txtGuestName.Text.Trim() + "','"
                   + cboRoomType.Text.Trim() + "','" + txtRoomNumber.Text.Trim() + "','" + txtAdults.Text.Trim() +
                   "','" + txtChildren.Text.Trim() + "','" + dtpCheckIn.Text + DateTime.Now.ToString(" h:mm:ss tt") + "','"
                   + dtpCheckOut.Text + DateTime.Now.AddHours(hours).ToString(" h:mm:ss tt") + "','" + txtTotal.Text.Trim() + "','" + DateTime.Now.ToString("yyyy-MMdd-t-HH-mmss" + txtHours.Text) + "','Reserved');";

                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                conn.Open();
                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data Inserted");
                    }
                    else
                    {
                        MessageBox.Show("Data Not Inserted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
                DataGridUno();
                Clear_Text();


            }
            
        }

        private void dtpCheckOut_CloseUp(object sender, EventArgs e)
        {
          
        }

        private void ReservCKIbtn1_Click(object sender, EventArgs e)
        {
            string insertQuery = "BEGIN TRANSACTION INSERT INTO CHECKIN SELECT GuestName,RoomType,RoomNumber,NumOfAdult,NumOfChild,CheckInDate,CheckOutDate,TotalBalance,TransactionID FROM Reservations WHERE TransactionID = '"+ Reservtxtbox2 .Text.Trim()+"' DELETE FROM Reservations WHERE TransactionID = '"+Reservtxtbox2.Text.Trim()+"' COMMIT;" ;
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            conn.Open();
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Not Inserted");
                }
                else
                {
                    MessageBox.Show("Data Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            DataGridUno();
            Clear_Text();
        }

        private void ReserveGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.ReserveGrid.Rows[e.RowIndex];

                Reservtxtbox2.Text = row.Cells[8].Value.ToString();

            }
        }
    }
}
