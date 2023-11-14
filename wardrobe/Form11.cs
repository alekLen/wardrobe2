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
    public partial class Form11 : Form
    {
        public event EventHandler<EventArgs> CountComplects;
        public event EventHandler<EventArgs> CountItems;
        public event EventHandler<EventArgs> TakeName;
        public event EventHandler<EventArgs> TakePhoto;
        public Form MainForm { get; set; }
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public int c1 { get; set; }
        public int n { get; set; }
        public string s { get; set; }
        public string name { get; set; }
        public List<int> Complects { get; set; } = new();
        public List<int> Items { get; set; } = new();
        public Form11()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Альбом: " + name;
                CountComplects?.Invoke(this, new EventArgs());
                int y = 50;
                c = 0;
                n = 0;
                if (Complects.Count > 0)
                {
                    for (int i = 0; i < Complects.Count; i++)
                    {
                        TakeName?.Invoke(this, new EventArgs());
                        TextBox textbox = new TextBox();
                        textbox.Location = new System.Drawing.Point(20, y);
                        textbox.Width = 200;
                        textbox.Text = s;
                        textbox.BackColor = Color.White;
                        textbox.Enabled = false;
                        this.Controls.Add(textbox);
                        CountItems?.Invoke(this, new EventArgs());
                        c1 = 0;
                        int x = 0;
                        for (int i1 = 0; i1 < b; i1++)
                        {
                            PictureBox pictureBox = new PictureBox();
                            pictureBox.Width = 100;
                            pictureBox.Height = 100;
                            pictureBox.Location = new System.Drawing.Point(250 + i1 * 120, y);
                            pictureBox.BackColor = System.Drawing.Color.White;
                            TakePhoto?.Invoke(this, new EventArgs());
                            pictureBox.Image = Image.FromFile(s);
                            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                            this.Controls.Add(pictureBox);
                            c1++; n++;
                            x = i1;
                        }

                        y += 120;
                        c++;
                    }
                }
                else
                {
                    MessageBox.Show("Этот альбом еще пустой!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch { }
        }

        private void Form11_FormClosed(object sender, FormClosedEventArgs e)
        {
            Complects.Clear();
            this.Dispose();
        }
    }
}
