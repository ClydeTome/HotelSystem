using System;
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

    public partial class Form4 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2BAN13A\SQLEXPRESS;Initial Catalog=HotelReservation;Integrated Security=True");
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-40PIGQM;Initial Catalog=HotelReservation;Integrated Security=True");
        int adult = 0;
        int child = 0;
        int hour = 0;
        public Form4()
        {
            InitializeComponent();
            DataGridReserve();
        }
        void Clear_Text()
        {
            txtGuestName.Clear();
            txtRoomNumber.Clear();
            txtRoomRate.Clear();
            txtTotal.Clear();
            txtChildren.Text = "0";
            txtAdults.Text = "0";
        }
        void DataGridReserve()
        {
            SqlCommand comm3 = new SqlCommand("select * from Reservations", conn);
            DataSet dataset3 = new DataSet();
            SqlDataAdapter sda3 = new SqlDataAdapter(comm3);
            sda3.Fill(dataset3);
            ReserveGrid.DataSource = dataset3.Tables[0];
            ReserveGrid.RowTemplate.Height = 20;
            ReserveGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 mainform = new Form2();
            mainform.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (txtGuestName.Text.Equals(""))
            {
                MessageBox.Show("Guest name cannot be empty");
            }
            else
            {
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
                DataGridReserve();
                Clear_Text();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form2 mainform = new Form2();
            mainform.Show();
        }

        private void bttnAddAdult_Click(object sender, EventArgs e)
        {
            adult++;
            txtAdults.Text = adult.ToString();
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

        private void bttnAddChildren_Click(object sender, EventArgs e)
        {
            child--;
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
    }
}
