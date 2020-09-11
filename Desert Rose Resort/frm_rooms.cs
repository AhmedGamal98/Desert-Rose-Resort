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
    public partial class frm_rooms : Form
    {
        int ahmed, abdo;
        public frm_rooms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frm_rooms_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select max (id_tour) from room";
            string id = cmd.ExecuteScalar().ToString();
            ahmed = int.Parse(id);
            for (int i = 1; i <= ahmed; i++)
            {
                cmd.CommandText = "select (room_num) from room where id_tour=" + i + "";
                string room = cmd.ExecuteScalar().ToString();
                int abdo = int.Parse(room);
                if (abdo == 1)
                {
                    button9.Enabled = false;
                }
                if (abdo == 2)
                {
                    button8.Enabled = false;

                }
                if (abdo == 3)
                {
                    button7.Enabled = false;
                }
                if (abdo == 4)
                {
                    button6.Enabled = false;
                }
                if (abdo == 5)
                {
                    button5.Enabled = false;
                }
                if (abdo == 6)
                {
                    button4.Enabled = false;
                }
                if (abdo == 7)
                {
                    button3.Enabled = false;
                }
                if (abdo == 8)
                {
                    button2.Enabled = false;
                }
                if (abdo == 9)
                {
                    button10.Enabled = false;
                }
                if (abdo == 10)
                {
                    button11.Enabled = false;
                }
                if (abdo == 11)
                {
                    button12.Enabled = false;
                }
                if (abdo == 12)
                {
                    button13.Enabled = false;
                }
                if (abdo == 13)
                {
                    button14.Enabled = false;
                }
                if (abdo == 14)
                {
                    button15.Enabled = false;
                }
                if (abdo == 15)
                {
                    button16.Enabled = false;
                }
                if (abdo == 16)
                {
                    button17.Enabled = false;
                }
                if (abdo == 17)
                {
                    button18.Enabled = false;
                }
                if (abdo == 18)
                {
                    button19.Enabled = false;

                }
                if (abdo == 19)
                {
                    button20.Enabled = false;
                }
                if (abdo == 20)
                {
                    button21.Enabled = false;
                }
                if (abdo == 21)
                {
                    button22.Enabled = false;
                }
                if (abdo == 22)
                {
                    button23.Enabled = false;
                }
                if (abdo == 23)
                {
                    button24.Enabled = false;
                }
                if (abdo == 24)
                {
                    button25.Enabled = false;
                }
                if (abdo == 25)
                {
                    button26.Enabled = false;
                }
                if (abdo == 26)
                {
                    button27.Enabled = false;
                }
                if (abdo == 27)
                {
                    button28.Enabled = false;
                }
                if (abdo == 28)
                {
                    button29.Enabled = false;
                }
                if (abdo == 29)
                {
                    button30.Enabled = false;
                }
                if (abdo == 30)
                {
                    button31.Enabled = false;
                }
                if (abdo == 31)
                {
                    button32.Enabled = false;
                }
                if (abdo == 32)
                {
                    button33.Enabled = false;
                }


            }
            con.Close();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 1 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 2 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 3 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 4 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 5 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 6 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 7 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 8 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 9 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 10 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 11 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 12 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 13 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 14 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 15 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 16 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 17+ "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 18 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 19 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 20 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 21 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button23_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 22 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button24_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 23 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button25_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 24 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button26_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 25 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button27_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 26 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button28_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 27 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button29_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 28 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button30_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 29 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button31_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 30 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button32_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 31 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }

        private void button33_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into room(room_num,id_tour) values(" + 32 + "," + int.Parse(textBox1.Text) + ")";
            cmd.ExecuteNonQuery();
            con.Close();
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
        }
    }
}

            
 //cmd.CommandText = "select max (room_num) from room";
 //           string newnumroom = cmd.ExecuteScalar().ToString();
 //           try { n = (int.Parse(newnumroom) + 1); }
 //           catch { n = 1; }
 //           cmd.CommandText = "select max (floor_num) from room";
 //           string newnumfloor = cmd.ExecuteScalar().ToString();
 //           try { r = (int.Parse(newnumfloor) + 1); }
 //           catch { r = 1; }
 //           if (n <= 11 && r <= 11)
 //           {
 //               n = 1;
 //               r = 1;
 //           }