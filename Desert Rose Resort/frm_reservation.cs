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
    public partial class frm_reservation : Form
    {
        public frm_reservation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            string command = "select max (id) from tourist";
            SqlCommand cmd = new SqlCommand(command, con);
            string newid = cmd.ExecuteScalar().ToString();

            try { textBox1.Text = (int.Parse(newid) + 1) + ""; }
            catch { textBox1.Text = "1"; }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into tourist (id,name,phone,age,nationality) values("+int.Parse(textBox1.Text)+",'"+textBox5.Text+"',"+int.Parse(textBox4.Text)+","+int.Parse(textBox3.Text)+",'"+textBox2.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_reservation1 frm = new frm_reservation1();
            frm.ShowDialog();
        }
    }
}
