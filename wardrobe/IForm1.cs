using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wardrobe
{
    public interface IForm1
    {
        public ListItem l {  get; set; }
        public List<ListItem> itemsSeason { set; get; }
        public   List<ListItem> itemsStyle { set; get; }
        public List<ListItem> itemsColor { set; get; }
        public void SetSeasonToWardrobe(string s,int i);
        public void SetStyleToWardrobe(string s,int i);
        public void SetTypeUpToWardrobe(string puth, string name);
        public void SetTypeBottomToWardrobe(string puth, string name);
        public void SetTypeSuitToWardrobe(string puth, string name);
        public void SetTypeShoeToWardrobe(string puth, string name);
        public void SetColorToWardrobe(string s, int i);
        public void ClearUp();
        public void ClearBottom();
        public void ClearSuit();
        public void ClearShoe();
        public int setId { get; set; }
        public List<int> Ids { get; set; }
       // public List<string> f_color { get; set; }
       // public List<string> f_style { get; set; }
      //  public List<string> f_season { get; set; }
        public int point { get; set; }
        public int categoryId { get; set; }
        public string nameCategory { get; set; }
        public int number { get; set; }
        public Color color { get; set; }
        public void SetChoseItemUp(string s);
        public void SetPhotoItemUp(string s);
        public void SetChoseItemBottom(string s);
        public void SetPhotoItemBottom(string s);
        public void SetChoseItemSuit(string s);
        public void SetPhotoItemSuit(string s);
        public void SetChoseItemShoe(string s);
        public void SetPhotoItemShoe(string s);

        public event EventHandler<EventArgs> LoadF;
        public event EventHandler<EventArgs> LoadUp;
        public event EventHandler<EventArgs> LoadBottom;
        public event EventHandler<EventArgs> LoadSuit;
        public event EventHandler<EventArgs> LoadShoe;
        public event EventHandler<EventArgs> NewF2;
        public event EventHandler<EventArgs> NewF3;
        public event EventHandler<EventArgs> NewF4;
        public event EventHandler<EventArgs> NewF5;
        public event EventHandler<EventArgs> NewF6;
        public event EventHandler<EventArgs> Filtr;
        public event EventHandler<EventArgs> Clear_Filtr;
        public event EventHandler<EventArgs> Change_Photo_Up;
        public event EventHandler<EventArgs> Change_Photo_Bottom;
        public event EventHandler<EventArgs> Change_Photo_Suit;
        public event EventHandler<EventArgs> Change_Photo_Shoe;
        public event EventHandler<EventArgs> SeeComplects;
        public event EventHandler<EventArgs> GetNumberColors;
        public event EventHandler<EventArgs> GetStatColor;
        public event EventHandler<EventArgs> GetNumberSeasons;
        public event EventHandler<EventArgs> GetStatSeason;
        public event EventHandler<EventArgs> GetNumberStyles;
        public event EventHandler<EventArgs> GetStatStyle;
        public Form2 add_clothe { get; set; }
        public Form3 see_clothe { get; set; }
        public Form4 edit_form { get; set; }
        public Form5 complect_form { get; set; }
        public Form6 complects_show_form { get; set; }
      //  public void ClearStyleBox();
      //  public void ClearSeasonBox();
      //  public void ClearColorBox();
        public List<int> f_color1 { get; set; }
        public List<int> f_style1 { get; set; } 
        public List<int> f_season1 { get; set; }
       // void ListViewUpInput(string puth, string name);
       // void ListViewBottomInput(string puth, string name);
       // void ListViewSuitInput(string puth, string name);
        //void ListViewShoeInput(string puth, string name);
    }

    public class ListItem
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public bool IsChecked { get; set; }
    }
}
