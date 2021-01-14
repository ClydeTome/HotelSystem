using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            
            InitializeComponent();
            FillGrid();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DESKTOP-2BAN13A\SQLEXPRESS;Initial Catalog=HotelReservation;Integrated Security=True");
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-40PIGQM;Initial Catalog=HotelReservation;Integrated Security=True");
        public void FillGrid()
        {
            SqlCommand comm = new SqlCommand("select * from RegisterRoomTable", conn);
            DataSet dataset = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(comm);
            sda.Fill(dataset);
            roomGrid1.DataSource = dataset.Tables[0];
        }
    }
}
