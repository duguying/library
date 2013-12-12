using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.Model;

namespace Library
{
    public partial class BookDetailForm : Form
    {
        Book book_show;
        public BookDetailForm(Book book)
        {
            this.book_show = book;
            InitializeComponent();
        }

        private void BookDetailLoad(object sender, EventArgs e)
        {
            label_bkAuthor.Text = book_show.bkAuthor;
            label_bkBrief.Text = book_show.bkBrief;
            label_bkCatalog.Text = book_show.bkCatalog;
            label_bkCode.Text = book_show.bkCode;
            label_bkId.Text = book_show.bkId.ToString();
            label_bkISBN.Text = book_show.bkISBN;
            string _bkLanguage;
            switch (book_show.bkLanguage) { //0-中文，1-英文，2-日文，3-俄文，4-德文，5-法文
                case 1:
                    _bkLanguage = "英文";break;
                case 2:
                    _bkLanguage = "日文";break;
                case 3:
                    _bkLanguage = "俄文";break;
                case 4:
                    _bkLanguage = "德文";break;
                case 5:
                    _bkLanguage = "法文";break;
                default:
                    _bkLanguage = "中文";break;
            }
            label_bkLanguage.Text = _bkLanguage;
            label_bkName.Text = book_show.bkName;
            label_bkName_title.Text = book_show.bkName;
            label_bkPage.Text = book_show.bkPages.ToString();
            label_bkPress.Text = book_show.bkPress;
            label_bkPressDate.Text = book_show.bkDatePress.ToString();
            label_bkPrice.Text = book_show.bkPrice.ToString();
            label_bkStatus.Text = book_show.bkStatus;
            if (book_show.bkCover!=null) {
                pictureBox1.Image = Tools.GetImageByBytes(book_show.bkCover);
            }
            
        }
    }
}
