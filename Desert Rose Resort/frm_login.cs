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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try {
                if (int.Parse(textBox2.Text) == 123)
                {
                    this.Visible = false;
                    frm_reception frm = new frm_reception();
                    frm.ShowDialog();
                }
                else if (int.Parse(textBox2.Text) == 1234)
                {
                    this.Visible = false;
                    frm_resturant_manager frm = new frm_resturant_manager();
                    frm.ShowDialog();

                }
                else if (int.Parse(textBox2.Text) == 12345)
                {
                    this.Visible = false;
                    frm_room_service_manager frm = new frm_room_service_manager();
                    frm.ShowDialog();
                }
                else if (int.Parse(textBox2.Text) == 123456)
                {
                    this.Visible = false;
                    frm_guardian_manager frm = new frm_guardian_manager();
                    frm.ShowDialog();
                }
                else
                { DialogResult dr = MessageBox.Show("incorect name or password", "Atention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
           // }
           // catch { DialogResult dr = MessageBox.Show("Please fill all fields", "Atention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }
    }
}
