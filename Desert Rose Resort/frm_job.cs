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
    public partial class frm_job : Form
    {
        public frm_job()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            string command = "select max (id_staff) from staff";
            SqlCommand cmd = new SqlCommand(command, con);
            string newid = cmd.ExecuteScalar().ToString();

            try { textBox1.Text = (int.Parse(newid) + 1) + ""; }
            catch { textBox1.Text = "111"; }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cheif" || comboBox1.Text == "Assistant chief" || comboBox1.Text == "Gardian" || comboBox1.Text == "diver"||comboBox1.Text=="waiter")
            {
                textBox8.Text = 0+"";
                textBox9.Text = "NULL";
            }
            else
            {
                SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
                con.Open();
                string command = "select max (id_staff) from staff";
                SqlCommand cmd = new SqlCommand(command, con);
                string newnum = cmd.ExecuteScalar().ToString();
                string command1 = "select  (num_floor) from staff where id=" + int.Parse(newnum) + "";
                SqlCommand cmd1 = new SqlCommand(command1, con);
                string newnum1 = cmd.ExecuteScalar().ToString();
                int x = int.Parse(newnum1);
                textBox8.Text = x + 1 + "";
                if (x == 1)
                {
                    textBox9.Text = "a";
                }
                if (x == 2)
                {
                    textBox9.Text = "b";
                }
                if (x == 3)
                {
                    textBox9.Text = "c";
                }
                if (x == 4)
                {
                    textBox9.Text = "d";
                }
                else
                {
                    textBox8.Text = 1 + "";
                    textBox9.Text = "a";
                }
                con.Close();
                
            }


            //SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            //con.Open();
            //string command = "select max (id_staff) from staff";
            //SqlCommand cmd = new SqlCommand(command, con);
            //string newnum = cmd.ExecuteScalar().ToString();    
            //string command1 = "select  (num_floor) from staff where id="+int.Parse(newnum)+"";
            //SqlCommand cmd1 = new SqlCommand(command1, con);
            //string newnum1 = cmd.ExecuteScalar().ToString();
            //int x = int.Parse(newnum1);
            //textBox8.Text = x+1 + "";
            //if (x == 1)
            //{
            //    textBox9.Text = "a";
            //}
            //if (x == 2)
            //{
            //    textBox9.Text = "b";
            //}
            //if (x == 3)
            //{
            //    textBox9.Text = "c";
            //}
            //if (x == 4)
            //{
            //    textBox9.Text = "d";
            //}
            //else
            //{
            //    textBox8.Text = 1 + "";
            //    textBox9.Text = "a";
            //}
            //con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                textBox5.Text = 1500 + "";

            }
             if (radioButton2.Checked == true)
            {
                textBox5.Text = 2000 + "";

            }
             if (radioButton3.Checked == true)
            {
                textBox5.Text = 2500 + "";

            }
            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into staff (id_staff,name,age,job,phone,sallary,city,st_name,num_floor,name_floor) values("+int.Parse(textBox1.Text)+",'"+textBox2.Text+"',"+int.Parse(textBox3.Text)+",'"+comboBox1.Text+"',"+int.Parse(textBox4.Text)+","+int.Parse(textBox5.Text)+",'"+textBox6.Text+"','"+textBox7.Text+"',"+int.Parse(textBox8.Text)+",'"+textBox9.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_image frm = new frm_image();
            frm.ShowDialog();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
