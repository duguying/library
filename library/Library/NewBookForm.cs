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
    public partial class NewBookForm : Form
    {
        public string picturePath;
        public NewBookForm()
        {
            InitializeComponent();
        }

        private void AddBook(object sender, EventArgs e)
        {
            //语言，0-中文，1-英文，2-日文，3-俄文，4-德文，5-法文
            int lang=0;
            switch (comboBox1.Text)
            {
                case "中文":
                    lang = 0;break;
                case "英文":
                    lang = 1;break;
                case "日文":
                    lang = 2;break;
                case "俄文":
                    lang = 3;break;
                case "德文":
                    lang = 4;break;
                case "法文":
                    lang = 5;break;
            }

            byte[] picbyte;
            if(this.picturePath!=null) {
                picbyte=Tools.GetBytesByImagePath(this.picturePath);
            }else {
                picbyte = Tools.GetBytesByImage(pictureBox1);
            };

            Book book = new Book();
            book.bkAuthor=textBox2.Text;
            book.bkBrief=textBox6.Text;
            book.bkCatalog=textBox7.Text;
            book.bkCode=textBox8.Text;
            book.bkCover = picbyte;
            book.bkDateIn=DateTime.Now;
            book.bkDatePress=dateTimePicker1.Value;
            book.bkISBN=textBox5.Text;
            book.bkLanguage = lang;
            book.bkName=textBox1.Text;
            book.bkPages=int.Parse(textBox9.Text);
            book.bkPress=textBox3.Text;
            book.bkPrice=float.Parse(textBox4.Text);
            book.bkStatus="在馆";

            try {
                if (BookDAL.Add(book) > 0) {
                    MessageBox.Show("添加成功！");
                }
            }catch(Exception ex){
                throw new Exception(ex.Message+"\n添加失败！");
            }
        }

        private void ChooseCover(object sender, EventArgs e)
        {
            FileDialog cc = new OpenFileDialog();
            cc.Filter = "图片文件(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png|所有文件(*.*)|*.*";
            if (cc.ShowDialog() != DialogResult.Cancel)
            {
                pictureBox1.ImageLocation= cc.FileName;
                this.picturePath = cc.FileName;
            }
        }
    }
}
