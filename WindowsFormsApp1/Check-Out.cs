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
    public partial class Check_Out : Form
    {
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2BAN13A\SQLEXPRESS;Initial Catalog=HotelReservation;Integrated Security=True");
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-40PIGQM;Initial Catalog=HotelReservation;Integrated Security=True");

        public Check_Out()
        {
            InitializeComponent();
            DataGridData();
            txtboxprops();
        }

        void DataGridData()
        {
            SqlCommand comm = new SqlCommand("select * from CHECKIN", conn);
            DataSet dataset = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(comm);
            sda.Fill(dataset);
            chkoutdgv1.DataSource = dataset.Tables[0];
            chkoutdgv1.RowTemplate.Height = 20;
            chkoutdgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        void txtboxprops()
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox8.ReadOnly = true;
            textBox9.ReadOnly = true;
        }

        void clearing()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }

        private void bckbtn1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 Mainform = new Form2();
            Mainform.Show();
        }

        private void chkoutbtn1_Click(object sender, EventArgs e)
        {
            string insertQuery = "BEGIN TRANSACTION INSERT INTO checkoutlezgo(TransactionID, GuestName, RoomType, RoomNumber, NumOfAdult, NumOfChild, CheckInDate, CheckOutDate, TotalBalance) SELECT TransactionID, GuestName, RoomType, RoomNumber, NumOfAdult, NumOfChild, CheckInDate, CheckOutDate, TotalBalance FROM CHECKIN WHERE TransactionID = '"+textBox1 .Text.Trim()+ "' DELETE FROM CHECKIN WHERE TransactionID = '"+ textBox1.Text.Trim() + "' COMMIT; ";
            
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            conn.Open();
            try
            {
                DialogResult ex = MessageBox.Show("Are you sure of the Check-Out?", "Warning", MessageBoxButtons.YesNo);
                if (ex == DialogResult.Yes)
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Check-Out Error");
                    }
                    else
                    {
                        MessageBox.Show("Check-Out Successful");
                        DataGridData();
                    }
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            
            clearing();
            DataGridData();
        }

        private void chkoutdgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.chkoutdgv1.Rows[e.RowIndex];

                textBox1.Text = row.Cells[8].Value.ToString();
                textBox2.Text = row.Cells[0].Value.ToString();
                textBox3.Text = row.Cells[1].Value.ToString();
                textBox4.Text = row.Cells[2].Value.ToString();
                textBox5.Text = row.Cells[3].Value.ToString();
                textBox6.Text = row.Cells[4].Value.ToString();
                textBox7.Text = row.Cells[5].Value.ToString();
                textBox8.Text = row.Cells[6].Value.ToString();
                textBox9.Text = row.Cells[7].Value.ToString();

            }
        }
    }
}
