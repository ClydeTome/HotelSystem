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
    public partial class Form1 : Form
    {
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2BAN13A\SQLEXPRESS;Initial Catalog=HotelReservation;Integrated Security=True");
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-40PIGQM;Initial Catalog=HotelReservation;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqa = new SqlDataAdapter("SELECT * FROM logincred WHERE Username='" + logtxtb1.Text.Trim() + "'and Password = '" + logtxtb2.Text.Trim() + "'", conn);
            DataTable dt = new DataTable();
            sqa.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                Form2 mainform = new Form2();
                mainform.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username/Password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
