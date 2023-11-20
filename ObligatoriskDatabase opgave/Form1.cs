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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObligatoriskDatabase_opgave
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            conn = new SqlConnection(@"Data Source = HARUNPC; Initial Catalog = TrainingDatabase; Integrated Security = True;");
            cmd = new SqlCommand();
            cmd.Connection = conn;
            MessageBox.Show("Connected");
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            string query = $"insert into Facilities values('{Facility_Id.Text.ToString()}','{FacilityName.Text.ToString()}')";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            Cleardata();
            conn.Close();
            displaydata();
        }

        private void Cleardata()
        {
            Facility_Id.Clear();
            FacilityName.Clear();
        }

        private void Update_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Facilities set name='" + FacilityName.Text + "' where Facility_Id='" + Facility_Id.Text.ToString() + "' ";
            cmd.ExecuteNonQuery();
            conn.Close();
            displaydata();
            Cleardata();
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            displaydata();
        }

        private void displaydata()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Facilities";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string query = $"delete Facilities where Facility_Id='{Facility_Id.Text.ToString()}'";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            dataGridView1.DataSource = query;
            Cleardata();
            conn.Close();
            displaydata();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Facilities where Facility_Id='" + SearchBox.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FacilityName.Text = dt.ToString();
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

