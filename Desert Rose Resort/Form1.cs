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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                this.Visible = false;
                timer1.Stop();
                frm_choose frm = new frm_choose();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                progressBar1.Value++;
                label5.Text = progressBar1.Value.ToString();
                if (progressBar1.Value % 8 == 2)
                {
                    label3.Text = "Please Wait .";
                }
                if (progressBar1.Value % 8 == 5)
                {
                    label3.Text = "Please Wait ..";
                } if (progressBar1.Value % 8 == 7)
                {
                    label3.Text = "Please Wait ...";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
