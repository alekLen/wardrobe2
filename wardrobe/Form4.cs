using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace wardrobe
{
    public partial class Form4 : Form
    {
        public string name { get; set; }
        public string oldname { get; set; }
        public string category { get; set; }
        public string action { get; set; }
        public event EventHandler<EventArgs> LoadEditStyle;
        public event EventHandler<EventArgs> LoadEditColor;
        public event EventHandler<EventArgs> LoadEditSeason;
        public event EventHandler<EventArgs> LoadEditAlbum;
        public event EventHandler<EventArgs> LoadShowStyle;
        public event EventHandler<EventArgs> LoadShowSeason;
        public event EventHandler<EventArgs> LoadShowColor;
        public event EventHandler<EventArgs> LoadShowAlbum;
        public event EventHandler<EventArgs> AddStyle;
        public event EventHandler<EventArgs> AddSeason;
        public event EventHandler<EventArgs> AddColor;
        public event EventHandler<EventArgs> AddAlbum;
        public event EventHandler<EventArgs> EditStyle;
        public event EventHandler<EventArgs> EditSeason;
        public event EventHandler<EventArgs> EditColor;
        public event EventHandler<EventArgs> EditAlbum;
        public event EventHandler<EventArgs> DeleteStyle;
        public event EventHandler<EventArgs> DeleteSeason;
        public event EventHandler<EventArgs> DeleteColor;
        System.Windows.Forms.ListBox listbox;
        public Form1 MainForm { get; set; }
        public Form4()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Load_Form4(object sender, EventArgs e)
        {
            if (action == "edit")
            {
                this.Text = "Редактирование";
                textBox1.Enabled = true;
                button1.Text = "Изменить";
                if (category == "style")
                {
                    label1.Text = "Стили";
                    LoadEditStyle?.Invoke(this, EventArgs.Empty);
                    button1.Click += editStyle;
                }
                if (category == "season")
                {
                    label1.Text = "Сезоны";
                    LoadEditSeason?.Invoke(this, EventArgs.Empty);
                    button1.Click += editSeason;
                }
                if (category == "color")
                {
                    label1.Text = "Цвета";
                    LoadEditColor?.Invoke(this, EventArgs.Empty);
                    button1.Click += editColor;
                }
                if (category == "album")
                {
                    label1.Text = "Альбомы";
                    LoadEditAlbum?.Invoke(this, EventArgs.Empty);
                    button1.Click += editColor;
                }
                comboBox1.SelectedIndex = 0;
            }
            if (action == "delete")
            {
                this.Text = "Удаление";
                textBox1.Enabled = false;
                button1.Text = "Удалить";
                if (category == "style")
                {
                    label1.Text = "Стили";
                    LoadEditStyle?.Invoke(this, EventArgs.Empty);
                    button1.Click += deleteStyle;
                }
                if (category == "season")
                {
                    label1.Text = "Сезоны";
                    LoadEditSeason?.Invoke(this, EventArgs.Empty);
                    button1.Click += deleteSeason;
                }
                if (category == "color")
                {
                    label1.Text = "Цвета";
                    LoadEditColor?.Invoke(this, EventArgs.Empty);
                    button1.Click += deleteColor;
                }
                comboBox1.SelectedIndex = 0;
            }
            if (action == "add")
            {
                this.Text = "Добавление";
                textBox1.Enabled = true;
                button1.Text = "Добавить";
                CreateList();
                if (category == "style")
                {
                    label1.Text = "Стили";
                    label2.Text = "Новый стиль";
                    LoadShowStyle?.Invoke(this, EventArgs.Empty);
                    button1.Click += addStyle;
                }
                if (category == "season")
                {
                    label1.Text = "Сезоны";
                    label2.Text = "Новый сезон";
                    LoadShowSeason?.Invoke(this, EventArgs.Empty);
                    button1.Click += addSeason;
                }
                if (category == "color")
                {
                    label1.Text = "Цвета";
                    label2.Text = "Новый цвет";
                    LoadShowColor?.Invoke(this, EventArgs.Empty);
                    button1.Click += addColor;
                }
                if (category == "album")
                {
                    label1.Text = "Альбомы";
                    label2.Text = "Новый альбом";
                    LoadShowAlbum?.Invoke(this, EventArgs.Empty);
                    button1.Click += addAlbum;
                }
            }
        }
        public void SetCategory(string s)
        {
            comboBox1.Items.Add(s);
        }
        public void ShowCategory(string s)
        {
            listbox.Items.Add(s);
        }
        private void selected(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
        }
        private void CreateList()
        {
            listbox = new ListBox();
            listbox.Location = comboBox1.Location;
            listbox.Size = comboBox1.Size;
            listbox.Height= comboBox1.Height*2;
            this.Controls.Remove(comboBox1);
            this.Controls.Add(listbox);
        }
        private void addStyle(object sender, EventArgs e)
        {
            name = textBox1.Text;
            AddStyle?.Invoke(this, EventArgs.Empty);
            this.Close();
            MessageBox.Show("Стиль добавлен!");
        }
        private void addSeason(object sender, EventArgs e)
        {
            name = textBox1.Text;
            AddSeason?.Invoke(this, EventArgs.Empty);
            this.Close();
            MessageBox.Show("Сезон добавлен!");
        }
        private void addColor(object sender, EventArgs e)
        {
            name = textBox1.Text;
            AddColor?.Invoke(this, EventArgs.Empty);
            this.Close();
            MessageBox.Show("Цвет добавлен!");
        }
        private void addAlbum(object sender, EventArgs e)
        {
            name = textBox1.Text;
            AddAlbum?.Invoke(this, EventArgs.Empty);
            this.Close();
            MessageBox.Show("Альбом добавлен!");
        }
        private void editStyle(object sender, EventArgs e)
        {
            oldname = comboBox1.SelectedItem.ToString();
            name = textBox1.Text;
            EditStyle?.Invoke(this, EventArgs.Empty);
            this.Close();
            MessageBox.Show("Стиль исправлен!");
        }
        private void editSeason(object sender, EventArgs e)
        {
            oldname = comboBox1.SelectedItem.ToString();
            name = textBox1.Text;
            EditSeason?.Invoke(this, EventArgs.Empty);
            this.Close();
            MessageBox.Show("Сезон исправлен!");
        }
        private void editColor(object sender, EventArgs e)
        {
            oldname = comboBox1.SelectedItem.ToString();
            name = textBox1.Text;
            EditColor?.Invoke(this, EventArgs.Empty);
            this.Close();
            MessageBox.Show("Цвет исправлен!");
        }
        private void deleteStyle(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Если в гардеробе есть вещи этого стиля\n они тоже будут удалены  безвозвратно\n \nуверены , что хотите удалить ?", "Подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                oldname = textBox1.Text;
                DeleteStyle?.Invoke(this, EventArgs.Empty);
                this.Close();
                MessageBox.Show("Стиль удален!");
            }
        }
        private void deleteSeason(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Если в гардеробе есть вещи этого сезона\n они тоже будут удалены  безвозвратно\n \nуверены , что хотите удалить ?", "Подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                oldname = textBox1.Text;
                DeleteSeason?.Invoke(this, EventArgs.Empty);
                this.Close();
                MessageBox.Show("Сезон удален!");
            }
        }
        private void deleteColor(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Если в гардеробе есть вещи этого цвета\n они тоже будут удалены  безвозвратно\n \nуверены , что хотите удалить ?", "Подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                oldname = textBox1.Text;
                DeleteColor?.Invoke(this, EventArgs.Empty);
                this.Close();
                MessageBox.Show("Цвет удален!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
