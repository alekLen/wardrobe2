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
    public partial class Form6 : Form
    {
        public event EventHandler<EventArgs> CountComplects;
        public event EventHandler<EventArgs> CountItems;
        public event EventHandler<EventArgs> TakeName;
        public event EventHandler<EventArgs> TakePhoto;
        public event EventHandler<EventArgs> LoadAlbum;
        public event EventHandler<EventArgs> AddComplToAlbum;
        public event EventHandler<EventArgs> DeleteComplect;
     
        public Form9 album_form { get; set; } = new Form9();
       

        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public int c1 { get; set; }
        public int n { get; set; }
        public string s { get; set; }
        public List<int> Complects { get; set; } = new();
        public List<int> Items { get; set; } = new();
        public Form6()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            album_form.CountItems += SetCountItems;
            album_form.TakeName += SetName;
            album_form.TakePhoto += SetPhoto;
            album_form.LoadAlbums += LoadAlbums;
            album_form.AddComplectToAlbum += AddComplectToAlbum;
        }

        private void LoadF6(object sender, EventArgs e)
        {
            try
            {
                CountComplects?.Invoke(this, new EventArgs());
                int y = 50;
                c = 0;
                n = 0;
                for (int i = 0; i < a; i++)
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
                    Button button = new Button();
                    button.Text = "Удалить комплект";
                    button.Name = "button." + i;
                    button.Width = 150;
                    button.Height = 50;
                    button.BackColor = System.Drawing.Color.LightYellow;
                    button.Click += Button_Click;
                    button.Location = new System.Drawing.Point(250 + x * 120 + 150, y);
                    this.Controls.Add(button);
                    Button button1 = new Button();
                    button1.Text = "Добавить в альбом";
                    button1.Name = "button1." + i;
                    button1.Width = 150;
                    button1.Height =85;
                    button1.BackColor = System.Drawing.Color.LightYellow;
                    button1.Click += Button1_Click;
                    button1.Location = new System.Drawing.Point(450 + x * 120 + 150, y);
                    this.Controls.Add(button1);
                    y += 120;
                    c++;
                }
            }
            catch { }
        }
        private void SetCountItems(object sender, EventArgs e)
        {
            CountItems?.Invoke(this, new EventArgs());
        }
        private void SetName(object sender, EventArgs e)
        {
            TakeName?.Invoke(this, new EventArgs());
        }
        private void SetPhoto(object sender, EventArgs e)
        {
            TakePhoto?.Invoke(this, new EventArgs());
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            string s = clickedButton.Name;
            string[] s1 = s.Split('.');
            n = int.Parse(s1[1]);
            DialogResult result = MessageBox.Show("Уверены , что хотите удалить комплект ?", "Подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeleteComplect?.Invoke(this, new EventArgs());
                this.Close();
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (album_form.IsDisposed || album_form.Visible)
            {
                album_form = new Form9();
                album_form.CountItems += SetCountItems;
                album_form.TakeName += SetName;
                album_form.TakePhoto += SetPhoto;
                album_form.LoadAlbums += LoadAlbums;
                album_form.AddComplectToAlbum += AddComplectToAlbum;
            }
            Button clickedButton = sender as Button;
            string s = clickedButton.Name;
            string[] s1 = s.Split('.');
            n = int.Parse(s1[1]);
            Items.Clear();
            album_form.MainForm = this;
            album_form.ShowDialog();
        }
        private void LoadAlbums(object sender, EventArgs e)
        {
            LoadAlbum?.Invoke(this, new EventArgs());
        }
        private void AddComplectToAlbum(object sender, EventArgs e)
        {
            AddComplToAlbum?.Invoke(this, new EventArgs());
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
        public void ShowAlbum(string s)
        {
            album_form.SetAlbum(s);
        }
        public void SelectAlbum(int i)
        {
            if(i>0)
            album_form.SelectAlbum();
            else
               MessageBox.Show("У вас не создано ни одного альбома!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


    }
}
