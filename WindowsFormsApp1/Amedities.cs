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
    public partial class Amedities : Form
    {
        public Amedities()
        {
            InitializeComponent();
            FillGrid();
        }
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2BAN13A\SQLEXPRESS;Initial Catalog=HotelReservation;Integrated Security=True");
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-40PIGQM;Initial Catalog=HotelReservation;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 mainform = new Form2();
            mainform.Show();
        }
        
        void FillGrid()
        {
            SqlCommand comm2 = new SqlCommand("select * from Amedities", conn);
            DataSet dataset2 = new DataSet();
            SqlDataAdapter sda2 = new SqlDataAdapter(comm2);
            sda2.Fill(dataset2);
            AmeditiesGrid.DataSource = dataset2.Tables[0];
            AmeditiesGrid.RowTemplate.Height = 25;
            AmeditiesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnAme_Click(object sender, EventArgs e)
        {
            string insertQuery =
               "INSERT INTO Amedities VALUES('" + txtAmeID.Text.Trim() +
               "','" + txtAmeName.Text.Trim() + "','" + txtAmePrice.Text.Trim() +
               "');";
            conn.Open();
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            try
            {
                if (!txtAmeID.Text.Equals("") && !txtAmeName.Text.Equals("") && !txtAmePrice.Text.Equals(""))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted");
                    SqlCommand comm = new SqlCommand("select * from Amedities", conn);
                    DataSet dataset = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(comm);
                    sda.Fill(dataset);
                    AmeditiesGrid.DataSource = dataset.Tables[0];
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
            FillGrid();
        }
    }
}
