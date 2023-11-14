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
    public partial class Form9 : Form
    {
        public Form6 MainForm { get; set; }
        public event EventHandler<EventArgs> CountItems;
        public event EventHandler<EventArgs> TakeName;
        public event EventHandler<EventArgs> TakePhoto;
        public event EventHandler<EventArgs> LoadAlbums;
        public event EventHandler<EventArgs> AddComplectToAlbum;
        public List<int> Items { get; set; } = new();
        public int n { get; set; }
        public int b { get; set; }
        public int id { get; set; }

        public string s { get; set; }
        public Form9()
        {
            InitializeComponent();

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            n = MainForm.n;
            id = MainForm.n;
            MainForm.c = n;
            TakeName?.Invoke(this, new EventArgs());
            s = MainForm.s;
            TextBox textbox = new TextBox();
            textbox.Location = new System.Drawing.Point(20, 5);
            textbox.Width = 200;
            textbox.Text = s;
            textbox.BackColor = Color.White;
            textbox.Enabled = false;
            this.Controls.Add(textbox);
            CountItems?.Invoke(this, new EventArgs());
            Items = MainForm.Items;
            b = MainForm.b;
            int x = 0;
            MainForm.n = 0;
            for (int i1 = 0; i1 < b; i1++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 100;
                pictureBox.Height = 100;
                pictureBox.Location = new System.Drawing.Point(50 + i1 * 120, 50);
                pictureBox.BackColor = System.Drawing.Color.White;
                TakePhoto?.Invoke(this, new EventArgs());
                s = MainForm.s;
                pictureBox.Image = Image.FromFile(s);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                this.Controls.Add(pictureBox);
                MainForm.n++;
                x = i1;
            }
            LoadAlbums?.Invoke(this, new EventArgs());
        }
        public void SetAlbum(string s)
        {
            comboBox1.Items.Add(s);
        }
        public void SelectAlbum()
        {
            comboBox1.SelectedIndex = 0;
        }
        private void Form9_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.s = comboBox1.SelectedItem.ToString();
            if (MainForm.s == "")           
                MainForm.s = comboBox1.Items[0].ToString();         
            MainForm.n = id;
            AddComplectToAlbum?.Invoke(this, new EventArgs());
            MessageBox.Show("Одежда добавлена в альбом!", "Добавлено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }
    }
}
