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
    public partial class Form10 : Form
    {
        public event EventHandler<EventArgs> LoadF10;
        public event EventHandler<EventArgs> ShowComplects;
        public event EventHandler<EventArgs> NewF11;

        public Form11 formcomplInAlbum {  get; set; }=new Form11();
        public Form1 MainForm { get; set; }
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            LoadF10?.Invoke(this, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (formcomplInAlbum.IsDisposed || formcomplInAlbum.Visible)
            {
                formcomplInAlbum = new Form11();
                NewF11?.Invoke(this, EventArgs.Empty);
            }
            string str = comboBox1.SelectedItem.ToString();
            if (str == "")
                str = comboBox1.Items[0].ToString();
            formcomplInAlbum.name = str;
            formcomplInAlbum.MainForm= this;
            formcomplInAlbum.ShowDialog();
        }
        public void ShowAlbum(string s)
        {
            comboBox1.Items.Add(s);
        }
        public void SelectAlbum(int i)
        {
            if (i > 0)
                comboBox1.SelectedIndex = 0;
            else
                MessageBox.Show("У вас не создано ни одного альбома!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
