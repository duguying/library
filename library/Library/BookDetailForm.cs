using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.Model;
using Library.DAL;

namespace Library
{
    public partial class BookDetailForm : Form
    {
        Book book_show;
        bool editable = false;
        public BookDetailForm(Book book)
        {
            this.book_show = book;
            InitializeComponent();
        }

        private void BookDetailLoad(object sender, EventArgs e)
        {
            textBox4.Text = book_show.bkAuthor;
            textBox9.Text = book_show.bkBrief;
            comboBox1.Text = book_show.bkCatalog;
            textBox2.Text = book_show.bkCode;
            textBox1.Text = book_show.bkId.ToString();
            textBox6.Text = book_show.bkISBN;
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
            comboBox2.Text = _bkLanguage;
            textBox3.Text = book_show.bkName;
            label_bkName_title.Text = book_show.bkName;
            textBox7.Text = book_show.bkPages.ToString();
            textBox5.Text = book_show.bkPress;
            dateTimePicker1.Value = book_show.bkDatePress;
            textBox8.Text = book_show.bkPrice.ToString();
            comboBox3.Text = book_show.bkStatus;
            if (book_show.bkCover!=null) {
                pictureBox1.Image = Tools.GetImageByBytes(book_show.bkCover);
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book bk = new Book();
            if (!this.editable)
            {
                panel2.Enabled = true;
                foreach (Control c in panel2.Controls)
                {
                    c.Enabled = true;
                }
                textBox9.Enabled = true;

                textBox1.Enabled = false;
                comboBox3.Enabled = false;

                

                button1.Text = "完成修改";
                this.editable = !this.editable;
            }
            else {
                panel2.Enabled = false;
                foreach (Control c in panel2.Controls)
                {
                    c.Enabled = false;
                }
                textBox9.Enabled = false;

                #region Data Store
                bk.bkAuthor = textBox4.Text;
                bk.bkBrief = textBox9.Text;
                bk.bkCatalog = comboBox1.Text;
                bk.bkCode = textBox2.Text;
                bk.bkDatePress = dateTimePicker1.Value;
                bk.bkId = int.Parse(textBox1.Text);
                bk.bkISBN = textBox6.Text;

                short _bkLanguage;
                switch (comboBox2.Text)
                { //0-中文，1-英文，2-日文，3-俄文，4-德文，5-法文
                    case "英文":
                        _bkLanguage = 1; break;
                    case "日文":
                        _bkLanguage = 2; break;
                    case "俄文":
                        _bkLanguage = 3; break;
                    case "德文":
                        _bkLanguage = 4; break;
                    case "法文":
                        _bkLanguage = 5; break;
                    default:
                        _bkLanguage = 0; break;
                }
                bk.bkLanguage = _bkLanguage;
                bk.bkName = textBox3.Text;
                bk.bkPages = int.Parse(textBox7.Text);
                bk.bkPress = textBox5.Text;
                bk.bkPrice = float.Parse(textBox8.Text);

                //try
                {
                    BookDAL.Update(bk);
                }
                //catch (Exception ex)
                //{
                //    MessageBox.Show("修改失败！");
                //    return;
                //}
                #endregion

                button1.Text = "修改书籍信息";
                this.editable = !this.editable;
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
