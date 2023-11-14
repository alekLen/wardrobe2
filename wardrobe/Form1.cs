using Azure.Messaging;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization.Charting;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Linq.Expressions;
using System;

namespace wardrobe
{

    public partial class Form1 : Form, IForm1
    {
        public ListItem l { set; get; }
        public List<ListItem> itemsSeason { set; get; } = new List<ListItem>();
        public List<ListItem> itemsStyle { set; get; } = new List<ListItem>();
        public List<ListItem> itemsColor { set; get; } = new List<ListItem>();
        public Form2 add_clothe { get; set; } = new Form2();
        public Form3 see_clothe { get; set; } = new Form3();
        public Form4 edit_form { get; set; } = new Form4();
        public Form5 complect_form { get; set; } = new Form5();
        public Form6 complects_show_form { get; set; } = new Form6();
        public Form7 see_clotheDop { get; set; } = new Form7();
        public Form10 album_form { get; set; } = new Form10();
        public Form11 Compl_album_form { get; set; } =  new Form11();
        public Form seasonStat { get; set; } = null;
        public Form styleStat { get; set; } = null;
        public Form colorStat { get; set; } = null;
        public int setId { get; set; }
        public List<int> Ids { get; set; } = new();
        public List<int> f_color1 { get; set; } = new();
        public List<int> f_style1 { get; set; } = new();
        public List<int> f_season1 { get; set; } = new();

        public int point { get; set; }
        public int categoryId { get; set; }
        public string nameCategory { get; set; }
        public int number { get; set; }
        public Color color { get; set; }

        public event EventHandler<EventArgs> LoadF;
        public event EventHandler<EventArgs> LoadUp;
        public event EventHandler<EventArgs> LoadBottom;
        public event EventHandler<EventArgs> LoadSuit;
        public event EventHandler<EventArgs> LoadShoe;
        public event EventHandler<EventArgs> LoadAcc;
        public event EventHandler<EventArgs> NewF2;
        public event EventHandler<EventArgs> NewF3;
        public event EventHandler<EventArgs> NewF4;
        public event EventHandler<EventArgs> NewF5;
        public event EventHandler<EventArgs> NewF6;
        public event EventHandler<EventArgs> NewF7;
        public event EventHandler<EventArgs> NewF10;
        public event EventHandler<EventArgs> Filtr;
        public event EventHandler<EventArgs> Clear_Filtr;
        public event EventHandler<EventArgs> Change_Photo_Up;
        public event EventHandler<EventArgs> Change_Photo_Bottom;
        public event EventHandler<EventArgs> Change_Photo_Suit;
        public event EventHandler<EventArgs> Change_Photo_Shoe;
        public event EventHandler<EventArgs> Change_Photo_Acc;
        public event EventHandler<EventArgs> SeeComplects;
        public event EventHandler<EventArgs> GetNumberColors;
        public event EventHandler<EventArgs> GetStatColor;
        public event EventHandler<EventArgs> GetNumberSeasons;
        public event EventHandler<EventArgs> GetStatSeason;
        public event EventHandler<EventArgs> GetNumberStyles;
        public event EventHandler<EventArgs> GetStatStyle;


        public Form1()
        {
            InitializeComponent();
            complect_form.F5Close += new EventHandler<EventArgs>(F5Close);
            try
            {
                Ids = new();
                PictureFill();
                ImageList largeImageList = new ImageList();
                largeImageList.ImageSize = new Size(48, 48);
                listView5.LargeImageList = largeImageList;
                ImageList largeImageList1 = new ImageList();
                largeImageList1.ImageSize = new Size(48, 48);
                listView6.LargeImageList = largeImageList1;
                ImageList largeImageList2 = new ImageList();
                largeImageList2.ImageSize = new Size(48, 48);
                listView7.LargeImageList = largeImageList2;
                ImageList largeImageList3 = new ImageList();
                largeImageList3.ImageSize = new Size(48, 48);
                listView8.LargeImageList = largeImageList3;
                ImageList largeImageList4 = new ImageList();
                largeImageList4.ImageSize = new Size(48, 48);
                listView1.LargeImageList = largeImageList4;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void SetSeasonToWardrobe(string s, int i)
        {
            l = new ListItem { Name = s, Id = i, IsChecked = false };
            itemsSeason.Add(l);
        }
        public void SetStyleToWardrobe(string s, int i)
        {
            l = new ListItem { Name = s, Id = i, IsChecked = false };
            itemsStyle.Add(l);
        }
        public void ClearUp()
        {
            listView5.Items.Clear();
            listView5.LargeImageList.Images.Clear();
        }
        public void ClearBottom()
        {
            listView6.Items.Clear();
            listView6.LargeImageList.Images.Clear();
        }
        public void ClearSuit()
        {
            listView7.Items.Clear();
            listView7.LargeImageList.Images.Clear();
        }
        public void ClearShoe()
        {
            listView8.Items.Clear();
            listView8.LargeImageList.Images.Clear();
        }
        public void ClearAcc()
        {
            listView1.Items.Clear();
            listView1.LargeImageList.Images.Clear();
        }
        public void SetColorToWardrobe(string s, int i)
        {
            l = new ListItem { Name = s, Id = i, IsChecked = false };
            itemsColor.Add(l);
        }
        public void SetChoseItemUp(string s)
        {
            listBox1.Items.Add(s);
            label13.Text = listBox1.Items.Count.ToString();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
        public void SetPhotoItemUp(string s)
        {
            pictureBox1.Image = Image.FromFile(s);
        }
        public void SetChoseItemBottom(string s)
        {
            listBox2.Items.Add(s);
            label14.Text = listBox2.Items.Count.ToString();
            listBox2.SelectedIndex = listBox2.Items.Count - 1;
        }
        public void SetPhotoItemBottom(string s)
        {
            pictureBox2.Image = Image.FromFile(s);
        }
        public void SetChoseItemSuit(string s)
        {
            listBox3.Items.Add(s);
            label15.Text = listBox3.Items.Count.ToString();
            listBox3.SelectedIndex = listBox3.Items.Count - 1;
        }
        public void SetPhotoItemSuit(string s)
        {
            pictureBox3.Image = Image.FromFile(s);
        }
        public void SetChoseItemShoe(string s)
        {
            listBox4.Items.Add(s);
            label16.Text = listBox4.Items.Count.ToString();
            listBox4.SelectedIndex = listBox4.Items.Count - 1;
        }
        public void SetPhotoItemShoe(string s)
        {
            pictureBox4.Image = Image.FromFile(s);
        }
        public void SetChoseItemAcc(string s)
        {
            listBox5.Items.Add(s);
            label27.Text = listBox5.Items.Count.ToString();
            listBox5.SelectedIndex = listBox5.Items.Count - 1;
        }
        public void SetPhotoItemAcc(string s)
        {
            pictureBox5.Image = Image.FromFile(s);
        }

        private void LoadForm(object sender, EventArgs e)
        {
            try
            {
                LoadF?.Invoke(this, EventArgs.Empty);
                LoadUp?.Invoke(this, EventArgs.Empty);
                LoadBottom?.Invoke(this, EventArgs.Empty);
                LoadSuit?.Invoke(this, EventArgs.Empty);
                LoadShoe?.Invoke(this, EventArgs.Empty);
                LoadAcc?.Invoke(this, EventArgs.Empty);
                Form1Color();
                Form1Style();
                Form1Season();
                ClearFiltrBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Add_Form(object sender, EventArgs e)
        {
            if (add_clothe.IsDisposed || add_clothe.Visible)
            {
                add_clothe = new Form2();
                NewF2?.Invoke(this, EventArgs.Empty);
            }
            add_clothe.MainForm = this;
            add_clothe.ShowDialog();
        }

        private void Load_see_formUp(object sender, EventArgs e)
        {
            try
            {
                if (see_clothe.IsDisposed)//|| see_clothe.Visible)
                {
                    see_clothe = new Form3();
                    NewF3?.Invoke(this, EventArgs.Empty);
                }
                if (listView5.SelectedItems.Count > 0 && !see_clothe.Visible)
                {
                    ListViewItem selectedItem = listView5.SelectedItems[0];
                    // string s = selectedItem.Text;
                    string s = selectedItem.ImageKey;
                    string[] s1 = s.Split('.');
                    setId = int.Parse(s1[0]);
                    see_clothe.MainForm = this;
                    listView5.SelectedIndices.Clear();
                    see_clothe.ShowDialog();
                }
            }
            catch { MessageBox.Show("opsup"); }
        }
        private void Load_see_formUpDop(string str)
        {
            try
            {
                if (see_clotheDop.IsDisposed)
                {
                    see_clotheDop = new Form7();
                    NewF7?.Invoke(this, EventArgs.Empty);
                }
                if (listView5.SelectedItems.Count > 0 && !see_clotheDop.Visible)
                {
                    ListViewItem selectedItem = listView5.SelectedItems[0];
                    string s = selectedItem.ImageKey;
                    string[] s1 = s.Split('.');
                    setId = int.Parse(s1[0]);
                    see_clotheDop.MainForm = this;
                    listView5.SelectedIndices.Clear();
                    see_clotheDop.act = str;
                    see_clotheDop.ShowDialog();
                }
            }
            catch { MessageBox.Show("opsup"); }
        }

        private void Load_see_formBottom(object sender, EventArgs e)
        {
            try
            {
                if (see_clothe.IsDisposed)
                {
                    see_clothe = new Form3();
                    NewF3?.Invoke(this, EventArgs.Empty);
                }
                if (listView6.SelectedItems.Count > 0 && !see_clothe.Visible)
                {
                    ListViewItem selectedItem = listView6.SelectedItems[0];
                    string s = selectedItem.Text;
                    string[] s1 = s.Split('.');
                    setId = int.Parse(s1[0]);
                    see_clothe.MainForm = this;
                    listView6.SelectedIndices.Clear();
                    see_clothe.ShowDialog();
                }
            }
            catch { MessageBox.Show("opsbottom"); }
        }
        private void Load_see_formBottomDop(string str)
        {
            try
            {
                if (see_clotheDop.IsDisposed)
                {
                    see_clotheDop = new Form7();
                    NewF7?.Invoke(this, EventArgs.Empty);
                }
                if (listView6.SelectedItems.Count > 0 && !see_clotheDop.Visible)
                {
                    ListViewItem selectedItem = listView6.SelectedItems[0];
                    string s = selectedItem.Text;
                    string[] s1 = s.Split('.');
                    setId = int.Parse(s1[0]);
                    see_clotheDop.MainForm = this;
                    listView6.SelectedIndices.Clear();
                    see_clotheDop.act = str;
                    see_clotheDop.ShowDialog();
                }
            }
            catch { MessageBox.Show("opsbottom"); }
        }

        private void Load_see_formSuit(object sender, EventArgs e)
        {
            try
            {
                if (see_clothe.IsDisposed)
                {
                    see_clothe = new Form3();
                    NewF3?.Invoke(this, EventArgs.Empty);
                }
                if (listView7.SelectedItems.Count > 0 && !see_clothe.Visible)
                {
                    ListViewItem selectedItem = listView7.SelectedItems[0];
                    string s = selectedItem.Text;
                    string[] s1 = s.Split('.');
                    setId = int.Parse(s1[0]);
                    see_clothe.MainForm = this;
                    listView7.SelectedIndices.Clear();
                    see_clothe.ShowDialog();
                }
            }
            catch { MessageBox.Show("opssuit"); }
        }
        private void Load_see_formSuitDop(string str)
        {
            try
            {
                if (see_clotheDop.IsDisposed)
                {
                    see_clotheDop = new Form7();
                    NewF7?.Invoke(this, EventArgs.Empty);
                }
                if (listView7.SelectedItems.Count > 0 && !see_clotheDop.Visible)
                {
                    ListViewItem selectedItem = listView7.SelectedItems[0];
                    string s = selectedItem.Text;
                    string[] s1 = s.Split('.');
                    setId = int.Parse(s1[0]);
                    see_clotheDop.MainForm = this;
                    listView7.SelectedIndices.Clear();
                    see_clotheDop.act = str;
                    see_clotheDop.ShowDialog();
                }
            }
            catch { MessageBox.Show("opssuit"); }
        }

        private void Load_see_formShoe(object sender, EventArgs e)
        {
            try
            {
                if (see_clothe.IsDisposed)
                {
                    see_clothe = new Form3();
                    NewF3?.Invoke(this, EventArgs.Empty);
                }
                if (listView8.SelectedItems.Count > 0 && !see_clothe.Visible)
                {
                    ListViewItem selectedItem = listView8.SelectedItems[0];
                    string s = selectedItem.Text;
                    string[] s1 = s.Split('.');
                    setId = int.Parse(s1[0]);
                    see_clothe.MainForm = this;
                    listView8.SelectedIndices.Clear();
                    see_clothe.ShowDialog();
                }
            }
            catch { MessageBox.Show("opsshoe"); }
        }
        private void Load_see_formAcc(object sender, EventArgs e)
        {
            try
            {
                if (see_clothe.IsDisposed)
                {
                    see_clothe = new Form3();
                    NewF3?.Invoke(this, EventArgs.Empty);
                }
                if (listView1.SelectedItems.Count > 0 && !see_clothe.Visible)
                {
                    ListViewItem selectedItem = listView1.SelectedItems[0];
                    string s = selectedItem.Text;
                    string[] s1 = s.Split('.');
                    setId = int.Parse(s1[0]);
                    see_clothe.MainForm = this;
                    listView1.SelectedIndices.Clear();
                    see_clothe.ShowDialog();
                }
            }
            catch { MessageBox.Show("opsacc"); }
        }
        private void Load_see_formShoeDop(string str)
        {
            try
            {
                if (see_clotheDop.IsDisposed)
                {
                    see_clotheDop = new Form7();
                    NewF7?.Invoke(this, EventArgs.Empty);
                }
                if (listView8.SelectedItems.Count > 0 && !see_clotheDop.Visible)
                {
                    ListViewItem selectedItem = listView8.SelectedItems[0];
                    string s = selectedItem.Text;
                    string[] s1 = s.Split('.');
                    setId = int.Parse(s1[0]);
                    see_clotheDop.MainForm = this;
                    listView8.SelectedIndices.Clear();
                    see_clotheDop.act = str;
                    see_clotheDop.ShowDialog();
                }
            }
            catch { MessageBox.Show("opsshoe"); }
        }
        private void Load_see_formAccDop(string str)
        {
            try
            {
                if (see_clotheDop.IsDisposed)
                {
                    see_clotheDop = new Form7();
                    NewF7?.Invoke(this, EventArgs.Empty);
                }
                if (listView1.SelectedItems.Count > 0 && !see_clotheDop.Visible)
                {
                    ListViewItem selectedItem = listView1.SelectedItems[0];
                    string s = selectedItem.Text;
                    string[] s1 = s.Split('.');
                    setId = int.Parse(s1[0]);
                    see_clotheDop.MainForm = this;
                    listView1.SelectedIndices.Clear();
                    see_clotheDop.act = str;
                    see_clotheDop.ShowDialog();
                }
            }
            catch { MessageBox.Show("opsshoe"); }
        }

        private void editStyle(object sender, EventArgs e)
        {
            try
            {
                ClearFiltrBox();
                if (edit_form.IsDisposed || edit_form.Visible)
                {
                    edit_form = new Form4();
                    NewF4?.Invoke(this, EventArgs.Empty);
                }
                edit_form.MainForm = this;
                edit_form.category = "style";
                edit_form.action = "edit";
                edit_form.ShowDialog();
            }
            catch { }
        }

        private void delStyle(object sender, EventArgs e)
        {
            try
            {
                ClearFiltrBox();
                if (edit_form.IsDisposed || edit_form.Visible)
                {
                    edit_form = new Form4();
                    NewF4?.Invoke(this, EventArgs.Empty);
                }
                edit_form.MainForm = this;
                edit_form.category = "style";
                edit_form.action = "delete";
                edit_form.ShowDialog();
                // Clear_Filtr?.Invoke(this, EventArgs.Empty);
            }
            catch { }
        }

        private void addStyle(object sender, EventArgs e)
        {
            try
            {
                ClearFiltrBox();
                if (edit_form.IsDisposed || edit_form.Visible)
                {
                    edit_form = new Form4();
                    NewF4?.Invoke(this, EventArgs.Empty);
                }
                edit_form.MainForm = this;
                edit_form.category = "style";
                edit_form.action = "add";
                edit_form.ShowDialog();
            }
            catch { }
        }

        private void delSeason(object sender, EventArgs e)
        {
            try
            {
                ClearFiltrBox();
                if (edit_form.IsDisposed || edit_form.Visible)
                {
                    edit_form = new Form4();
                    NewF4?.Invoke(this, EventArgs.Empty);
                }
                edit_form.MainForm = this;
                edit_form.category = "season";
                edit_form.action = "delete";
                edit_form.ShowDialog();
            }
            catch { }
        }

        private void editSeason(object sender, EventArgs e)
        {
            try
            {
                ClearFiltrBox();
                if (edit_form.IsDisposed || edit_form.Visible)
                {
                    edit_form = new Form4();
                    NewF4?.Invoke(this, EventArgs.Empty);
                }
                edit_form.MainForm = this;
                edit_form.category = "season";
                edit_form.action = "edit";
                edit_form.ShowDialog();
            }
            catch { }
        }

        private void addSeason(object sender, EventArgs e)
        {
            try
            {
                ClearFiltrBox();
                if (edit_form.IsDisposed || edit_form.Visible)
                {
                    edit_form = new Form4();
                    NewF4?.Invoke(this, EventArgs.Empty);
                }
                edit_form.MainForm = this;
                edit_form.category = "season";
                edit_form.action = "add";
                edit_form.ShowDialog();
            }
            catch { }
        }

        private void delColor(object sender, EventArgs e)
        {
            try
            {
                ClearFiltrBox();
                if (edit_form.IsDisposed || edit_form.Visible)
                {
                    edit_form = new Form4();
                    NewF4?.Invoke(this, EventArgs.Empty);
                }
                edit_form.MainForm = this;
                edit_form.category = "color";
                edit_form.action = "delete";
                edit_form.ShowDialog();
            }
            catch { }
        }

        private void editColor(object sender, EventArgs e)
        {
            try
            {
                ClearFiltrBox();
                if (edit_form.IsDisposed || edit_form.Visible)
                {
                    edit_form = new Form4();
                    NewF4?.Invoke(this, EventArgs.Empty);
                }
                edit_form.MainForm = this;
                edit_form.category = "color";
                edit_form.action = "edit";
                edit_form.ShowDialog();
            }
            catch { }
        }

        private void addColor(object sender, EventArgs e)
        {
            try
            {
                ClearFiltrBox();
                if (edit_form.IsDisposed || edit_form.Visible)
                {
                    edit_form = new Form4();
                    NewF4?.Invoke(this, EventArgs.Empty);
                }
                edit_form.MainForm = this;
                edit_form.category = "color";
                edit_form.action = "add";
                edit_form.ShowDialog();
            }
            catch { }
        }

        private void filter_Start(object sender, EventArgs e)
        {
            f_colorInput();
            f_styleInput();
            f_seasonInput();
            if (f_color1.Count > 0 || f_season1.Count > 0 || f_style1.Count > 0)
            {
                Filtr?.Invoke(this, EventArgs.Empty);
            }

        }

        private void clear_filter(object sender, EventArgs e)
        {
            try
            {
                /*  f_color.Clear();
                  f_season.Clear();
                  f_style.Clear();*/
                //  listView5.Items.Clear();
                Clear_Filtr?.Invoke(this, EventArgs.Empty);
                // comboBox1.SelectedItem = null;
                // comboBox2.SelectedItem = null;
                // comboBox3.SelectedItem = null;
            }
            catch { }
        }

        private void Add_Complect(object sender, EventArgs e)
        {
            if (Ids.Count > 1)
            {
                if (complect_form.IsDisposed || complect_form.Visible)
                {
                    complect_form = new Form5();
                    NewF5?.Invoke(this, EventArgs.Empty);
                    complect_form.F5Close += new EventHandler<EventArgs>(F5Close);
                }
                complect_form.MainForm = this;
                complect_form.ShowDialog();
            }
            else
                MessageBox.Show("Добавьте как минимум 2 предмета одежды!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void del_Choosen_Up(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex != -1)
                {
                    string s = listBox1.SelectedItem.ToString();
                    DialogResult result = MessageBox.Show("вы действительно хотите удалить из комплекта\n" + s + "  ?", "подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string[] s1 = s.Split('.');
                        Ids.Remove(int.Parse(s1[0]));
                        pictureBox1.Image = Image.FromFile("Photos/up1.jpg");
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                        label13.Text = listBox1.Items.Count.ToString();
                        if (listBox1.Items.Count > 0)
                        {
                            listBox1.SelectedIndex = listBox1.Items.Count - 1;
                            string s2 = listBox1.Items[listBox1.Items.Count - 1].ToString();
                            string[] s3 = s2.Split('.');
                            setId = int.Parse(s3[0]);
                            Change_Photo_Up?.Invoke(this, new EventArgs());
                        }
                    }
                }
            }
            catch { }
        }

        private void del_chosen_bottom(object sender, EventArgs e)
        {
            try
            {
                if (listBox2.SelectedIndex != -1)
                {
                    string s = listBox2.SelectedItem.ToString();
                    DialogResult result = MessageBox.Show("вы действительно хотите удалить из комплекта\n" + s + "  ?", "подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string[] s1 = s.Split('.');
                        Ids.Remove(int.Parse(s1[0]));
                        pictureBox2.Image = Image.FromFile("Photos/bottom1.png");
                        listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                        label14.Text = listBox2.Items.Count.ToString();
                        if (listBox2.Items.Count > 0)
                        {
                            listBox2.SelectedIndex = listBox2.Items.Count - 1;
                            string s2 = listBox2.Items[listBox2.Items.Count - 1].ToString();
                            string[] s3 = s2.Split('.');
                            setId = int.Parse(s3[0]);
                            Change_Photo_Bottom?.Invoke(this, new EventArgs());
                        }
                    }
                }
            }
            catch { }
        }

        private void del_chosen_suit(object sender, EventArgs e)
        {
            try
            {
                if (listBox3.SelectedIndex != -1)
                {
                    string s = listBox3.SelectedItem.ToString();
                    DialogResult result = MessageBox.Show("Вы действительно хотите удалить из комплекта\n" + s + "  ?", "Подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string[] s1 = s.Split('.');
                        Ids.Remove(int.Parse(s1[0]));
                        pictureBox3.Image = Image.FromFile("Photos/dress1.jpg");
                        listBox3.Items.RemoveAt(listBox3.SelectedIndex);
                        label15.Text = listBox3.Items.Count.ToString();
                        if (listBox3.Items.Count > 0)
                        {
                            listBox3.SelectedIndex = listBox3.Items.Count - 1;
                            string s2 = listBox3.Items[listBox3.Items.Count - 1].ToString();
                            string[] s3 = s2.Split('.');
                            setId = int.Parse(s3[0]);
                            Change_Photo_Suit?.Invoke(this, new EventArgs());
                        }
                    }
                }
            }
            catch { }
        }

        private void del_chosen_shoe(object sender, EventArgs e)
        {
            try
            {
                if (listBox4.SelectedIndex != -1)
                {
                    string s = listBox4.SelectedItem.ToString();
                    DialogResult result = MessageBox.Show("вы действительно хотите удалить из комплекта\n" + s + "  ?", "подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string[] s1 = s.Split('.');
                        Ids.Remove(int.Parse(s1[0]));
                        pictureBox4.Image = Image.FromFile("Photos/shoe1.jpg");
                        listBox4.Items.RemoveAt(listBox4.SelectedIndex);
                        label16.Text = listBox4.Items.Count.ToString();
                        if (listBox4.Items.Count > 0)
                        {
                            listBox4.SelectedIndex = listBox4.Items.Count - 1;
                            string s2 = listBox4.Items[listBox4.Items.Count - 1].ToString();
                            string[] s3 = s2.Split('.');
                            setId = int.Parse(s3[0]);
                            Change_Photo_Shoe?.Invoke(this, new EventArgs());
                        }
                    }
                }
            }
            catch { }
        }
        private void del_chosen_acc(object sender, EventArgs e)
        {
            try
            {
                if (listBox5.SelectedIndex != -1)
                {
                    string s = listBox5.SelectedItem.ToString();
                    DialogResult result = MessageBox.Show("вы действительно хотите удалить из комплекта\n" + s + "  ?", "подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string[] s1 = s.Split('.');
                        Ids.Remove(int.Parse(s1[0]));
                        pictureBox5.Image = Image.FromFile("Photos/bag.jpg");
                        listBox5.Items.RemoveAt(listBox5.SelectedIndex);
                        label27.Text = listBox5.Items.Count.ToString();
                        if (listBox5.Items.Count > 0)
                        {
                            listBox5.SelectedIndex = listBox5.Items.Count - 1;
                            string s2 = listBox5.Items[listBox5.Items.Count - 1].ToString();
                            string[] s3 = s2.Split('.');
                            setId = int.Parse(s3[0]);
                            Change_Photo_Acc?.Invoke(this, new EventArgs());
                        }
                    }
                }
            }
            catch { }
        }

        private void selectUp(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string s = listBox1.SelectedItem.ToString();
                string[] s1 = s.Split('.');
                setId = int.Parse(s1[0]);
                Change_Photo_Up?.Invoke(this, new EventArgs());
            }
        }

        private void selectBottom(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                string s = listBox2.SelectedItem.ToString();
                string[] s1 = s.Split('.');
                setId = int.Parse(s1[0]);
                Change_Photo_Bottom?.Invoke(this, new EventArgs());
            }
        }

        private void selectSuit(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex != -1)
            {
                string s = listBox3.SelectedItem.ToString();
                string[] s1 = s.Split('.');
                setId = int.Parse(s1[0]);
                Change_Photo_Suit?.Invoke(this, new EventArgs());
            }
        }

        private void selectShoe(object sender, EventArgs e)
        {
            if (listBox4.SelectedIndex != -1)
            {
                string s = listBox4.SelectedItem.ToString();
                string[] s1 = s.Split('.');
                setId = int.Parse(s1[0]);
                Change_Photo_Shoe?.Invoke(this, new EventArgs());
            }
        }
        private void selectAcc(object sender, EventArgs e)
        {
            if (listBox5.SelectedIndex != -1)
            {
                string s = listBox5.SelectedItem.ToString();
                string[] s1 = s.Split('.');
                setId = int.Parse(s1[0]);
                Change_Photo_Acc?.Invoke(this, new EventArgs());
            }
        }

        private void See_Complects(object sender, EventArgs e)
        {
            if (complects_show_form.IsDisposed || complects_show_form.Visible)
            {
                complects_show_form = new Form6();
                NewF6?.Invoke(this, EventArgs.Empty);
            }
            //complects_show_form.MainForm = this;
            complects_show_form.ShowDialog();
        }

        private void color_statistic(object sender, EventArgs e)
        {
            if (colorStat == null)
            {
                colorStat = new Form();
                Icon myIcon = new Icon("Icons/wardrobe_4486.ico");
                colorStat.Icon = myIcon;
                colorStat.Text = "Статистика цветов одежды";
                colorStat.Width = 600;
                colorStat.Height = 500;

                Chart chart = new Chart();
                chart.Dock = DockStyle.Fill;
                chart.ChartAreas.Add(new ChartArea("area"));

                chart.Series.Add(new Series("data"));

                chart.Series["data"].ChartType = SeriesChartType.Column;
                //chart.Series["data"].ChartType = SeriesChartType.Pie;
                // chart.Series["data"]["PieLabelStyle"] = "Outside";
                // chart.Series["data"]["PieLineColor"] = "Black";
                // chart.Series["data"]["PieLineWidth"] = "2";              

                GetNumberColors?.Invoke(this, new EventArgs());
                int x = 0; double x1 = 0.5; double y1 = 1.5;
                for (int i = 0; i < number; i++)
                {
                    categoryId = Ids[i];
                    GetStatColor?.Invoke(this, new EventArgs());
                    if (point > 0)
                    {
                        nameCategory += " -" + point.ToString() + "%";
                        chart.Series["data"].Points.AddXY(nameCategory, point);
                        chart.ChartAreas[0].AxisX.CustomLabels.Add(x1, y1, nameCategory);
                        chart.Series["data"].Points[x].Color = color;
                        x++; x1++; y1++;
                    }
                }
                colorStat.Controls.Add(chart);
                colorStat.FormClosed += colorStatClose;
                colorStat.Show();
                Ids.Clear();
            }
            else
                colorStat.Focus();
        }
        private void colorStatClose(object sender, EventArgs e)
        {
            colorStat = null;
        }
        private void season_statistic(object sender, EventArgs e)
        {
            if (seasonStat == null)
            {
                seasonStat = new Form();
                Icon myIcon = new Icon("Icons/wardrobe_4486.ico");
                seasonStat.Icon = myIcon;
                seasonStat.Text = "Статистика сезонов одежды";
                seasonStat.Width = 600;
                seasonStat.Height = 500;

                Chart chart = new Chart();
                chart.Dock = DockStyle.Fill;
                chart.ChartAreas.Add(new ChartArea("area"));

                chart.Series.Add(new Series("data"));

                chart.Series["data"].ChartType = SeriesChartType.Pie;
                chart.Series["data"]["PieLabelStyle"] = "Outside";
                chart.Series["data"]["PieLineColor"] = "Black";
                chart.Series["data"]["PieLineWidth"] = "2";

                GetNumberSeasons?.Invoke(this, new EventArgs());
                int x = 0;
                for (int i = 0; i < number; i++)
                {
                    categoryId = Ids[i];
                    GetStatSeason?.Invoke(this, new EventArgs());
                    if (point > 0)
                    {
                        nameCategory += " -" + point.ToString() + "%";
                        chart.Series["data"].Points.AddXY(nameCategory, point);
                        chart.Series["data"].Points[x].Color = color;
                        x++;
                    }
                }
                seasonStat.FormClosed += seasonStatClose;
                seasonStat.Controls.Add(chart);
                seasonStat.Show();
                Ids.Clear();
            }
            else
                seasonStat.Focus();
        }
        private void seasonStatClose(object sender, EventArgs e)
        {
            seasonStat = null;
        }
        private void style_statistic(object sender, EventArgs e)
        {
            if (styleStat == null)
            {
                styleStat = new Form();
                Icon myIcon = new Icon("Icons/wardrobe_4486.ico");
                styleStat.Icon = myIcon;
                styleStat.Text = "Статистика стилей одежды";
                styleStat.Width = 600;
                styleStat.Height = 500;

                Chart chart = new Chart();
                chart.Dock = DockStyle.Fill;
                chart.ChartAreas.Add(new ChartArea("area"));

                chart.Series.Add(new Series("data"));

                chart.Series["data"].ChartType = SeriesChartType.Bar;

                GetNumberStyles?.Invoke(this, new EventArgs());
                color = Color.BlueViolet;
                for (int i = 0; i < number; i++)
                {
                    categoryId = Ids[i];
                    GetStatStyle?.Invoke(this, new EventArgs());
                    nameCategory += " -" + point.ToString() + "%";
                    chart.Series["data"].Points.AddXY(nameCategory, point);
                    chart.Series["data"].Points[i].Color = color;

                }
                styleStat.Controls.Add(chart);
                styleStat.FormClosed += styleStatClose;
                styleStat.Show();
                Ids.Clear();
            }
            else
                styleStat.Focus();
        }
        private void styleStatClose(object sender, EventArgs e)
        {
            styleStat = null;
        }
        public void F5Close(object sender, EventArgs e)
        {
            Ids.Clear();
            ComplectClear();
            LabelClear();
            PictureFill();
        }
        void PictureFill()
        {
            pictureBox1.Image = Image.FromFile("Photos/up1.jpg");
            pictureBox2.Image = Image.FromFile("Photos/bottom1.png");
            pictureBox3.Image = Image.FromFile("Photos/dress1.jpg");
            pictureBox4.Image = Image.FromFile("Photos/shoe1.jpg");
            pictureBox5.Image = Image.FromFile("Photos/bag.jpg");
        }
        void LabelClear()
        {
            label13.Text = "0";
            label14.Text = "0";
            label15.Text = "0";
            label16.Text = "0";
            label27.Text = "0";
        }
        void ComplectClear()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
        }

        private void FilterColorBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            itemsColor[e.Index].IsChecked = (e.NewValue == CheckState.Checked);
        }

        private void FilterSeasonBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index >= 0 && e.Index < itemsSeason.Count)
            {
                itemsSeason[e.Index].IsChecked = (e.NewValue == CheckState.Checked);
            }
        }

        private void FilterStyleBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index >= 0 && e.Index < itemsStyle.Count)
            {
                itemsStyle[e.Index].IsChecked = (e.NewValue == CheckState.Checked);
            }
        }

        private void FilterColorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FilterColorBox.Che
        }

        public void Form1Style()
        {
            FilterStyleBox.DataSource = itemsStyle;
            FilterStyleBox.DisplayMember = "Name";
            FilterStyleBox.ValueMember = "Id";
            FilterStyleBox.CheckOnClick = true;
        }
        public void Form1Season()
        {
            FilterSeasonBox.DataSource = itemsSeason;
            FilterSeasonBox.DisplayMember = "Name";
            FilterSeasonBox.ValueMember = "Id";
            FilterSeasonBox.CheckOnClick = true;
        }
        public void Form1Color()
        {
            FilterColorBox.DataSource = itemsColor;
            FilterColorBox.DisplayMember = "Name";
            FilterColorBox.ValueMember = "Id";
            FilterColorBox.CheckOnClick = true;
        }
        private void f_colorInput()
        {
            f_color1.Clear();
            for (int i = 0; i < FilterColorBox.Items.Count; i++)
            {
                if (FilterColorBox.GetItemChecked(i))
                {
                    l = FilterColorBox.Items[i] as ListItem;
                    f_color1.Add(l.Id);
                }
            }
        }
        private void f_styleInput()
        {
            f_style1.Clear();
            for (int i = 0; i < FilterStyleBox.Items.Count; i++)
            {
                if (FilterStyleBox.GetItemChecked(i))
                {
                    l = FilterStyleBox.Items[i] as ListItem;
                    f_style1.Add(l.Id);
                }
            }
        }
        private void f_seasonInput()
        {
            f_season1.Clear();
            for (int i = 0; i < FilterSeasonBox.Items.Count; i++)
            {
                if (FilterSeasonBox.GetItemChecked(i))
                {
                    l = FilterSeasonBox.Items[i] as ListItem;
                    f_season1.Add(l.Id);
                }
            }
        }
        public void SetTypeUpToWardrobe(string puth, string name)
        {
            Image im = Image.FromFile(puth);
            ListViewItem l = new ListViewItem(name);
            l.ImageKey = name;
            listView5.LargeImageList.Images.Add(name, im);
            listView5.Items.Add(l);

        }
        public void SetTypeBottomToWardrobe(string puth, string name)
        {
            Image im = Image.FromFile(puth);
            ListViewItem l = new ListViewItem(name);
            l.ImageKey = name;
            listView6.LargeImageList.Images.Add(name, im);
            listView6.Items.Add(l);

        }
        public void SetTypeSuitToWardrobe(string puth, string name)
        {
            Image im = Image.FromFile(puth);
            ListViewItem l = new ListViewItem(name);
            l.ImageKey = name;
            listView7.LargeImageList.Images.Add(name, im);
            listView7.Items.Add(l);

        }
        public void SetTypeShoeToWardrobe(string puth, string name)
        {
            Image im = Image.FromFile(puth);
            ListViewItem l = new ListViewItem(name);
            l.ImageKey = name;
            listView8.LargeImageList.Images.Add(name, im);
            listView8.Items.Add(l);

        }
        public void SetTypeAccToWardrobe(string puth, string name)
        {
            Image im = Image.FromFile(puth);
            ListViewItem l = new ListViewItem(name);
            l.ImageKey = name;
            listView1.LargeImageList.Images.Add(name, im);
            listView1.Items.Add(l);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void ClearFiltrBox()
        {
            for (int i = 0; i < FilterColorBox.Items.Count; i++)
            {
                FilterColorBox.SetItemChecked(i, false);
            }
            FilterColorBox.SelectedIndex = -1;
            for (int i = 0; i < FilterSeasonBox.Items.Count; i++)
            {
                FilterSeasonBox.SetItemChecked(i, false);
            }
            FilterSeasonBox.SelectedIndex = -1;
            for (int i = 0; i < FilterStyleBox.Items.Count; i++)
            {
                FilterStyleBox.SetItemChecked(i, false);
            }
            FilterStyleBox.SelectedIndex = -1;

        }

        private void UpClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // Проверяем, что это правая кнопка мыши
            {
                // Определяем элемент, на котором был сделан клик
                ListViewItem item = listView5.GetItemAt(e.X, e.Y);

                if (item != null) // Проверяем, что элемент не равен null
                {
                    // Отображаем контекстное меню рядом с элементом
                    contextMenuStrip1.Show(listView5, e.Location);
                }
            }
        }

        private void Load_see_formUpDopA(object sender, EventArgs e)
        {
            Load_see_formUpDop("Add");
        }

        private void Load_see_formUpDopD(object sender, EventArgs e)
        {
            Load_see_formUpDop("Delete");
        }

        private void Load_see_formUpDopE(object sender, EventArgs e)
        {
            Load_see_formUpDop("Edit");
        }
        private void Load_see_formBottomDopA(object sender, EventArgs e)
        {
            Load_see_formBottomDop("Add");
        }

        private void Load_see_formBottomDopD(object sender, EventArgs e)
        {
            Load_see_formBottomDop("Delete");
        }

        private void Load_see_formBottomDopE(object sender, EventArgs e)
        {
            Load_see_formBottomDop("Edit");
        }
        private void Load_see_formSuitDopA(object sender, EventArgs e)
        {
            Load_see_formSuitDop("Add");
        }

        private void Load_see_formSuitDopD(object sender, EventArgs e)
        {
            Load_see_formSuitDop("Delete");
        }

        private void Load_see_formSuitDopE(object sender, EventArgs e)
        {
            Load_see_formSuitDop("Edit");
        }
        private void Load_see_formShoeDopA(object sender, EventArgs e)
        {
            Load_see_formShoeDop("Add");
        }

        private void Load_see_formShoeDopD(object sender, EventArgs e)
        {
            Load_see_formShoeDop("Delete");
        }

        private void Load_see_formShoeDopE(object sender, EventArgs e)
        {
            Load_see_formShoeDop("Edit");
        }
        private void Load_see_formAccDopA(object sender, EventArgs e)
        {
            Load_see_formAccDop("Add");
        }

        private void Load_see_formAccDopD(object sender, EventArgs e)
        {
            Load_see_formAccDop("Delete");
        }

        private void Load_see_formAccDopE(object sender, EventArgs e)
        {
            Load_see_formAccDop("Edit");
        }
        public void ClearStyleBox()
        {
            FilterStyleBox.DataSource = null;
            FilterStyleBox.Items.Clear();
            itemsStyle.Clear();
        }
        public void ClearSeasonBox()
        {
            FilterSeasonBox.DataSource = null;
            FilterSeasonBox.Items.Clear();
            itemsSeason.Clear();
        }
        public void ClearColorBox()
        {
            FilterColorBox.DataSource = null;
            FilterColorBox.Items.Clear();
            itemsColor.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("вы действительно хотите выйти" + "  ?", "Выйти", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void buttonClearComplect_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("вы действительно хотите очистить  комплект ?", "подтвердите", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Ids.Clear();
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    listBox3.Items.Clear();
                    listBox4.Items.Clear();
                    listBox5.Items.Clear();
                    PictureFill();
                    label13.Text = "0";
                    label14.Text = "0";
                    label15.Text = "0";
                    label16.Text = "0";
                    label27.Text = "0";
                }
            }
            catch { }
        }

        private void addAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ClearFiltrBox();
                if (edit_form.IsDisposed || edit_form.Visible)
                {
                    edit_form = new Form4();
                    NewF4?.Invoke(this, EventArgs.Empty);
                }
                edit_form.MainForm = this;
                edit_form.category = "album";
                edit_form.action = "add";
                edit_form.ShowDialog();
            }
            catch { }
        }

        private void альбомыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            album_form.ShowDialog();
        }
    }
}