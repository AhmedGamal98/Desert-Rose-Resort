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
    public partial class frm_tour : Form
    {
        public frm_tour()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.Screenshot_2017_12_11_00_53_21_195;
            Timer tim = new Timer();
            tim.Interval = 1000;
            tim.Tick += new EventHandler(changeimage);
            tim.Start();
        }

        private void changeimage(object sender, EventArgs e)
        {
            List<Bitmap> b1 = new List<Bitmap>();
            b1.Add(Properties.Resources.FB_IMG_1512945833402);
            b1.Add(Properties.Resources.FB_IMG_1512945926369);
            b1.Add(Properties.Resources.FB_IMG_1512945931015);
            b1.Add(Properties.Resources.FB_IMG_1512946069511);
            b1.Add(Properties.Resources.FB_IMG_1512945970615);
            b1.Add(Properties.Resources.Screenshot_2017_12_11_00_53_17_209);
            b1.Add(Properties.Resources.Screenshot_2017_12_11_00_54_00_575);
            b1.Add(Properties.Resources.Screenshot_2017_12_11_00_59_55_446);
            b1.Add(Properties.Resources.FB_IMG_1512946158878);
            b1.Add(Properties.Resources.Screenshot_2017_12_11_00_59_33_322);
            b1.Add(Properties.Resources.Screenshot_2017_12_11_00_54_38_560);
            int index = DateTime.Now.Second % b1.Count;
            this.BackgroundImage = b1[index];
        }

        private void frm_tour_Load(object sender, EventArgs e)
        {

        }


    }
}
