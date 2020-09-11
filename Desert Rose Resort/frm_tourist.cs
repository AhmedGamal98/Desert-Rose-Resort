using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desert_Rose_Resort
{
    public partial class frm_tourist : Form
    {
        public frm_tourist()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_reservation frm = new frm_reservation();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_query frm = new frm_query();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_overview frm = new frm_overview();
            frm.ShowDialog();
        }
    }
}
