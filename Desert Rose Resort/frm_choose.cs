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
    public partial class frm_choose : Form
    {
        public frm_choose()
        {
            InitializeComponent();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.desert rose resort.com");
        
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             System.Diagnostics.Process.Start("www.facebook.com");
        
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.instagram.com");
        
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.gmail.com");
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_login frm = new frm_login();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_tourist frm = new frm_tourist();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_staff frm = new frm_staff();
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
