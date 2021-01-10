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
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2BAN13A\SQLEXPRESS;Initial Catalog=HotelReservation;Integrated Security=True");
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-40PIGQM;Initial Catalog=HotelReservation;Integrated Security=True");

        public Form4()
        {
            InitializeComponent();
            DataGridReserve();
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
    }
}
