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
using System.IO;
namespace Desert_Rose_Resort
{
    public partial class frm_image : Form
    {
        public frm_image()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = " Images|*.jpg;*.png;*.gif;*.bmp";
            of.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (of.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(of.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = " Images|*.jpg;*.png;*.gif;*.bmp";
            of.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (of.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(of.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = " Images|*.jpg;*.png;*.gif;*.bmp";
            of.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (of.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = Image.FromFile(of.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = " Images|*.jpg;*.png;*.gif;*.bmp";
            of.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (of.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.Image = Image.FromFile(of.FileName);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("img"))
                Directory.CreateDirectory("img");
            pictureBox1.Image.Save("img/" + textBox1.Text + label1.Text+".jpg");
            if (!Directory.Exists("img"))
                Directory.CreateDirectory("img");
            pictureBox2.Image.Save("img/" + textBox1.Text + label2.Text + ".jpg");
            if (!Directory.Exists("img"))
                Directory.CreateDirectory("img");
            pictureBox3.Image.Save("img/" + textBox1.Text + label3.Text + ".jpg");
            if (!Directory.Exists("img"))
                Directory.CreateDirectory("img");
            pictureBox4.Image.Save("img/" + textBox1.Text + label4.Text + ".jpg");
            this.Visible = false;
            frm_choose frm = new frm_choose();
            frm.ShowDialog();
            //MemoryStream ms1 = new MemoryStream();
            //pictureBox1.Image.Save(ms1, pictureBox1.Image.RawFormat);
            //byte[] byteimage1 = ms1.ToArray();
            //MemoryStream ms2 = new MemoryStream();
            //pictureBox2.Image.Save(ms2, pictureBox1.Image.RawFormat);
            //byte[] byteimage2 = ms2.ToArray();
            //MemoryStream ms3 = new MemoryStream();
            //pictureBox3.Image.Save(ms3, pictureBox1.Image.RawFormat);
            //byte[] byteimage3 = ms3.ToArray();
            //MemoryStream ms4 = new MemoryStream();
            //pictureBox4.Image.Save(ms4, pictureBox1.Image.RawFormat);
            //byte[] byteimage4 = ms4.ToArray();
        }

        public string la { get; set; }
    }
}
