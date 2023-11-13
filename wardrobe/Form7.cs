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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeUI();
        }
        public Form1 MainForm { get; set; }
        public event EventHandler<EventArgs> LoadF7;
        public event EventHandler<EventArgs> AddToCom;
        public event EventHandler<EventArgs> DeleteItem;
        public event EventHandler<EventArgs> EditItem;
        public event EventHandler<EventArgs> LoadStyle;
        public event EventHandler<EventArgs> LoadSeason;
        public event EventHandler<EventArgs> LoadColor;
        public event EventHandler<EventArgs> DeletePhoto;
        public string act;
        public int cId { get; set; }
        public string newphoto { get; set; } = null;
        public string oldphoto { get; set; }
        public string newName { get; set; }
        public string oldName { get; set; }
        public string newStyle { get; set; }
        public string oldStyle { get; set; }
        public string newSeason { get; set; }
        public string oldSeason { get; set; }
        public string newColor { get; set; }
        public string oldColor { get; set; }
        public string newDate { get; set; }
        public string oldDate { get; set; }
        public string newPlace { get; set; }
        public string oldPlace { get; set; }
        public string newSize { get; set; }
        public string oldSize { get; set; }
        public void AddC()
        {
            MainForm.see_clotheDop = this;
            this.Text = "Добавление в комплект";
            button1.Text = "Добавить";
            button1.Click += AddToComplectBox;
        }
        public void DelC()
        {
            MainForm.see_clotheDop = this;
            this.Text = "Удаление";
            button1.Text = "Удалить";
            button1.Click += delete;
        }
        public void EditC()
        {
            this.Text = "Редактирование";
            button1.Text = "Сохранить";
            button1.Click += SaveIt;
            MainForm.see_clotheDop = this;
            textBoxName.Enabled = true;
            textBoxDate.Enabled = true;
            textBoxPlace.Enabled = true;
            textBoxSize.Enabled = true;
            LoadEditStyle();
            LoadEditSeason();
            LoadEditColor();
            LoadPhotoButton();
        }

        System.Windows.Forms.ComboBox comboBoxStyle;
        System.Windows.Forms.ComboBox comboBoxSeason;
        System.Windows.Forms.ComboBox comboBoxColor;
        public void SetSeason(string s)
        {
            textBoxSeason.Text = s;
            oldSeason = s;
        }
        public void SetSeasonToEdit(string s)
        {
            comboBoxSeason.Items.Add(s);
        }
        public void SetStyle(string s)
        {
            textBoxStyle.Text = s;
            oldStyle = s;
        }
        public void SetStyleToEdit(string s)
        {
            comboBoxStyle.Items.Add(s);
        }
        public void SetColor(string s)
        {
            textBoxColor.Text = s;
            oldColor = s;
        }
        public void SetColorToEdit(string s)
        {
            comboBoxColor.Items.Add(s);
        }
        public void SetName(string s)
        {
            textBoxName.Text = s;
            oldName = s;
        }
        public void SetPlace(string s)
        {
            textBoxPlace.Text = s;
            oldPlace = s;
        }
        public void SetDate(string s)
        {
            textBoxDate.Text = s;
            oldDate = s;
        }
        public void SetSize(string s)
        {
            textBoxSize.Text = s;
            oldSize = s;
        }
        public void SetPhoto(string s)
        {
            pictureBox1.Image = Image.FromFile(s);
            oldphoto = s;
        }

        private void LoadFm7(object sender, EventArgs e)
        {

            try
            {
                LoadF7?.Invoke(this, EventArgs.Empty);
                cId = MainForm.setId;
                if (act == "Add")
                    AddC();
                else if (act == "Delete")
                    DelC();
                else if (act == "Edit")
                    EditC();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddToComplectBox(object sender, EventArgs e)
        {
            button1.Click -= AddToComplectBox;
            // MainForm.see_clotheDop = this;
            AddToCom?.Invoke(this, EventArgs.Empty);
            this.Close();
            this.Dispose();
        }

        private void edit_item(object sender, EventArgs e)
        {
            button1.Text = "Сохранить";
            button1.Click -= edit_item;
            button1.Click += SaveIt;
            //  MainForm.see_clotheDop = this;
            textBoxName.Enabled = true;
            textBoxDate.Enabled = true;
            textBoxPlace.Enabled = true;
            textBoxSize.Enabled = true;
            LoadEditStyle();
            LoadEditSeason();
            LoadEditColor();
            LoadPhotoButton();
        }
        void LoadPhotoButton()
        {
            button3Photo.Visible = true;
            button3Photo.Text = "Изменить фото";
            button3Photo.Click += buttonPhoto_Click;

        }
        void LoadEditStyle()
        {
            try
            {
                MainForm.see_clotheDop = this;
                comboBoxStyle = new System.Windows.Forms.ComboBox();
                comboBoxStyle.Location = textBoxStyle.Location;
                comboBoxStyle.Size = textBoxStyle.Size;
                LoadStyle?.Invoke(this, EventArgs.Empty);
                // comboBoxStyle.SelectedText = textBoxStyle.Text;
                comboBoxStyle.DropDownStyle = ComboBoxStyle.DropDownList;
                int index = comboBoxStyle.FindStringExact(textBoxStyle.Text);
                comboBoxStyle.SelectedIndex = index;
                this.Controls.Remove(textBoxStyle);
                this.Controls.Add(comboBoxStyle);
            }
            catch { }
        }
        void LoadEditSeason()
        {
            try
            {
                MainForm.see_clotheDop = this;
                comboBoxSeason = new System.Windows.Forms.ComboBox();
                comboBoxSeason.Location = textBoxSeason.Location;
                comboBoxSeason.Size = textBoxSeason.Size;
                LoadSeason?.Invoke(this, EventArgs.Empty);
                // comboBoxSeason.SelectedText = textBoxSeason.Text;
                comboBoxSeason.DropDownStyle = ComboBoxStyle.DropDownList;
                int index = comboBoxSeason.FindStringExact(textBoxSeason.Text);
                comboBoxSeason.SelectedIndex = index;
                this.Controls.Remove(textBoxSeason);
                this.Controls.Add(comboBoxSeason);
            }
            catch { }
        }
        void LoadEditColor()
        {
            try
            {
                MainForm.see_clotheDop = this;
                comboBoxColor = new System.Windows.Forms.ComboBox();
                comboBoxColor.Location = textBoxColor.Location;
                comboBoxColor.Size = textBoxColor.Size;
                LoadColor?.Invoke(this, EventArgs.Empty);
                // comboBoxColor.SelectedText = textBoxColor.Text;
                comboBoxColor.DropDownStyle = ComboBoxStyle.DropDownList;
                int index = comboBoxColor.FindStringExact(textBoxColor.Text);
                comboBoxColor.SelectedIndex = index;
                this.Controls.Remove(textBoxColor);
                this.Controls.Add(comboBoxColor);
            }
            catch { }
        }
        private void delete(object sender, EventArgs e)
        {
            button1.Click -= delete;
            // MainForm.see_clotheDop = this;
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить\n " + textBoxName.Text + " из гардероба", "Подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                pictureBox1.Image.Dispose();
                DeleteItem?.Invoke(this, EventArgs.Empty);
                this.Close();
                this.Dispose();
                MessageBox.Show("Одежда  удалена!");
            }
        }

        private void SaveIt(object sender, EventArgs e)
        {
            button1.Click -= SaveIt;
            // MainForm.see_clotheDop = this;
            DialogResult result = MessageBox.Show("Вы хотите сохранить изменения\n если изменили фото, то старое будет удалено", "Подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SetNewData();
                if (newphoto != null)
                {
                    pictureBox1.Image.Dispose();
                    DeletePhoto?.Invoke(this, EventArgs.Empty);
                }
                EditItem?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Измененения сохранены успешно");
            }
            if (result == DialogResult.No)
            {
                if (newphoto != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = Image.FromFile(oldphoto);
                }
            }
            this.Close();
            this.Dispose();
        }
        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            // MainForm.see_clotheDop = this;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    newphoto = openFileDialog.FileName;
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = Image.FromFile(newphoto);
                }
            }
        }
        void SetNewData()
        {
            newName = textBoxName.Text;
            newSeason = comboBoxSeason.Text;
            newStyle = comboBoxStyle.Text;
            newColor = comboBoxColor.Text;
            newDate = textBoxDate.Text;
            newPlace = textBoxPlace.Text;
            newSize = textBoxSize.Text;
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (oldphoto != null)
            {
                Form8 f = new Form8();
                f.MainForm7 = this;
                f.ShowDialog();
            }
        }
        private void InitializeUI()
        {
            Bitmap originalIcon = new Bitmap(Properties.Resources._100);
            Size controlSize = new Size(20, 20);
            Bitmap scaledIcon = ScaleImage(originalIcon, controlSize);
            button3.Image = scaledIcon;
        }

        private Bitmap ScaleImage(Bitmap image, Size newSize)
        {
            Bitmap newImage = new Bitmap(newSize.Width, newSize.Height);
            using (Graphics g = Graphics.FromImage(newImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, newSize.Width, newSize.Height);
            }
            return newImage;
        }
    }
}
