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
    public partial class frm_dismissal : Form
    {
        public frm_dismissal()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from staff where id_staff=" + int.Parse(textBox1.Text) + "";
            SqlDataAdapter adpt1 = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            adpt1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "delete * from staff where id_staff=" + int.Parse(textBox1.Text) + "";
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
