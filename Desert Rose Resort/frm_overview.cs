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
    public partial class frm_overview : Form
    {
        public frm_overview()
        {
            InitializeComponent();
        }

        private void frm_overview_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_tour frm = new frm_tour();
            frm.ShowDialog();
        }
    }
}
