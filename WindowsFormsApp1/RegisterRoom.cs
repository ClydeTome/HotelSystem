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
    public partial class RegisterRoom : Form
    {
        public RegisterRoom()
        {
            InitializeComponent();
            FillCombo();
            FillGrid();

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-2BAN13A\SQLEXPRESS;Initial Catalog=HotelReservation;Integrated Security=True");
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-40PIGQM;Initial Catalog=HotelReservation;Integrated Security=True");


        void FillCombo()
        {
            conn.Open();
            SqlCommand comm = new SqlCommand("select RoomType from RegisterRoomTable", conn);
            SqlCommand count = new SqlCommand("select count(RoomType) from RegisterRoomTable", conn);
            SqlDataReader sdr = comm.ExecuteReader();
            // Adding elements in the combobox
            while (sdr.Read())
            {
                regcb1.Items.Add(sdr["RoomType"]);
            }
            sdr.Close();
            conn.Close();
        }
        public void FillGrid()
        {
            SqlCommand comm = new SqlCommand("select * from RegisterRoomTable", conn);
            DataSet dataset = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(comm);
            sda.Fill(dataset);
            regview1.DataSource = dataset.Tables[0];
            regview1.RowTemplate.Height = 25;
            regview1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            SqlCommand comm2 = new SqlCommand("select * from Amedities", conn);
            DataSet dataset2 = new DataSet();
            SqlDataAdapter sda2 = new SqlDataAdapter(comm2);
            sda2.Fill(dataset2);
            AmeditiesGrid.DataSource = dataset2.Tables[0];
            AmeditiesGrid.RowTemplate.Height = 25;
            AmeditiesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void RegisterRoom_Load(object sender, EventArgs e)
        {/**
            regview1.GridLines = true;
            regview1.View = View.Details;

            regview1.Columns.Add("RoomID", 150);
            regview1.Columns.Add("RoomName", 150);
            regview1.Columns.Add("RoomType", 150);
            regview1.Columns.Add("RoomRate", 150);
            **/
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form2 mainform = new Form2();
            mainform.Show();
        }

        private void regbtn1_Click(object sender, EventArgs e)
        {
            string insertQuery = 
                "INSERT INTO RegisterRoomTable VALUES('" + regtxt1.Text.Trim()
                + "','" + regtxt2.Text.Trim() + "','" + regtxt3.Text.Trim()
                +"','"+regtxt4.Text+"');";
            conn.Open();
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            try
            {
                if (!regtxt1.Text.Equals("") && !regtxt2.Text.Equals("") && !regtxt3.Text.Equals("") && !regtxt4.Text.Equals(""))
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted");
                    SqlCommand comm = new SqlCommand("select * from RegisterRoomTable", conn);
                    DataSet dataset = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(comm);
                    sda.Fill(dataset);
                    regview1.DataSource = dataset.Tables[0];        
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
            if (!regtxt1.Text.Equals("") && !regtxt2.Text.Equals("") && !regtxt3.Text.Equals("") && !regtxt4.Text.Equals(""))
            {
                FillCombo();
                regtxt1.Text = "";
                regtxt2.Text = "";
                regtxt3.Text = "";
                regtxt4.Text = "";
            }
            FillGrid();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery ="TRUNCATE TABLE RegisterRoomTable;";
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
                    MessageBox.Show("All Data Deleted.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            this.Dispose();
            RegisterRoom rg = new RegisterRoom();
            rg.Show();
        }

        private void regbtnref_Click(object sender, EventArgs e)
        {
            /**conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM RegisterRoomTable", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();

            DataTable dt;
            dt = ds.Tables["Table"];
            int i;
            for (i=0; i <=dt.Rows.Count-1;i++)
            {
                regview1.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                regview1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                regview1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                regview1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
            }
            **/
        }

        private void regcb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandText = "select * from RegisterRoomTable where RoomType='"+regcb1.SelectedItem.ToString()+"'";
            comm.Connection = conn;
            DataSet dataset = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(comm);
            sda.Fill(dataset);
            regview1.DataSource = dataset.Tables[0];
        }

        private void btnAme_Click(object sender, EventArgs e)
        {
            string insertQuery =
                "INSERT INTO Amedities VALUES('" +txtAmeID.Text.Trim()+
                "','" +txtAmeName.Text.Trim()+ "','" +txtAmePrice.Text.Trim()+
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

        private void regtxt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
            }
        }
    }
}
