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
    public partial class frm_reservation1 : Form
    {
        int shahd=1,roqaia;
        
        private string te;
        public frm_reservation1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            string command = "select max (res_id) from reservation";
            SqlCommand cmd = new SqlCommand(command, con);
            string newid = cmd.ExecuteScalar().ToString();

            try { textBox1.Text = (int.Parse(newid) + 1) + ""; }
            catch { textBox1.Text = "1"; }
            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            string command = "select max (bill_code) from reservation";
            SqlCommand cmd = new SqlCommand(command, con);
            string newid = cmd.ExecuteScalar().ToString();

            try { textBox8.Text = (int.Parse(newid) + 10) + ""; }
            catch { textBox8.Text = "10"; }
            con.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
             
            
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "RED")
            {
                shahd = int.Parse(textBox2.Text) * int.Parse(textBox3.Text) * 400;
            }
            if (comboBox1.Text == "BLUE")
            {
                shahd = int.Parse(textBox2.Text) * int.Parse(textBox3.Text) * 300;
            }
            if (comboBox1.Text == "YALLOW")
            {
                shahd = int.Parse(textBox2.Text) * int.Parse(textBox3.Text) * 200;
            }
            roqaia = int.Parse(textBox5.Text);
            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into reservation (res_id,type,period,date_start,date_end,date_of_bill,bill_code,bill_price,id_tour,num_people,month) values("+int.Parse(textBox1.Text)+",'"+comboBox1.Text+"',"+int.Parse(textBox2.Text)+","+int.Parse(textBox5.Text)+","+int.Parse(textBox6.Text)+","+roqaia+","+int.Parse(textBox8.Text)+","+shahd+","+int.Parse(textBox10.Text)+","+int.Parse(textBox3.Text)+","+int.Parse(textBox4.Text)+")";
            cmd.ExecuteNonQuery();
          
            con.Close();
            DialogResult dr = MessageBox.Show("Your Bill Code :"+int.Parse(textBox8.Text)+"\n Your Price : "+shahd+"", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Visible = false;
            frm_rooms frm = new frm_rooms();
            frm.ShowDialog();
        }

    }
}
