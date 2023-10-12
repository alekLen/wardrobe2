using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wardrobe
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        public Form3 MainForm3 { get; set; }
        public Form7 MainForm7 { get; set; }
        public Form2 MainForm2 { get; set; }

        private void Form8_Load(object sender, EventArgs e)
        {
            if (MainForm3 != null)
            {
                if (MainForm3.newphoto == null)
                    pictureBox1.Image = Image.FromFile(MainForm3.oldphoto);
                else
                    pictureBox1.Image = Image.FromFile(MainForm3.newphoto);
            }
            if (MainForm7 != null)
            {
                if (MainForm7.newphoto == null)
                    pictureBox1.Image = Image.FromFile(MainForm7.oldphoto);
                else
                    pictureBox1.Image = Image.FromFile(MainForm7.newphoto);
            }
            if (MainForm2 != null)
            {
                pictureBox1.Image = Image.FromFile(MainForm2.FilePath);
            }
        }

        private void Form8_FormClosed(object sender, FormClosedEventArgs e)
        {
            pictureBox1.Image.Dispose();
            this.Dispose();
        }
    }
}
