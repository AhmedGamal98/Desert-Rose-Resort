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
namespace Desert_Rose_Resort
{
    public partial class frm_cancel_reservation : Form
    {
        public frm_cancel_reservation()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from tourist where id=" + int.Parse(textBox1.Text) + "";
            SqlDataAdapter adpt1 = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            adpt1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            cmd.CommandText = "select * from reservation where id_tour=" + int.Parse(textBox1.Text) + "";
            SqlDataAdapter adpt2 = new SqlDataAdapter(cmd);
            DataTable dt2 = new DataTable();
            adpt2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            cmd.CommandText = "select * from room where id_tour=" + int.Parse(textBox1.Text) + "";
            SqlDataAdapter adpt3 = new SqlDataAdapter(cmd);
            DataTable dt3 = new DataTable();
            adpt3.Fill(dt3);
            dataGridView3.DataSource = dt3;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete * from tourist where id="+int.Parse(textBox1.Text)+"";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete * from reservation where id_tour=" + int.Parse(textBox1.Text) + "";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete * from room where id_tour=" + int.Parse(textBox1.Text) + "";
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
