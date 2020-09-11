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
    public partial class frm_staff_acc : Form
    {
        public frm_staff_acc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                SqlConnection con = new SqlConnection(Properties.Settings.Default.resort);
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from staff where id_staff=" + int.Parse(textBox1.Text) + "";
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
          
        }
    }
}
