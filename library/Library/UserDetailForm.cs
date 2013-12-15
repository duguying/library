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
using Library.BLL;

namespace Library
{
    public partial class UserDetailForm : Form
    {
        public Reader reader;
        public bool editable=false;

        public UserDetailForm(Reader reader)
        {
            this.reader = reader;

            InitializeComponent();
        }

        private void UserDetailForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = reader.rdID.ToString();
            textBox5.Text = reader.rdUsername;
            textBox3.Text = reader.rdName;
            comboBox2.Text = reader.rdSex;
            comboBox1.Text = reader.rdType.ToString();
            textBox6.Text = reader.rdDept;
            textBox7.Text = reader.rdPhone;
            textBox8.Text = reader.rdEmail;
            dateTimePicker1.Value = reader.rdDateReg;
            textBox10.Text = reader.rdStatus;
            textBox11.Text = reader.rdHaveBorrowNum.ToString();
            pictureBox1.Image = Tools.GetImageByBytes(reader.rdPhoto);

            //label_bkAuthor.Text = book_show.bkAuthor;
            //label_bkBrief.Text = book_show.bkBrief;
            //label_bkCatalog.Text = book_show.bkCatalog;
            //label_bkCode.Text = book_show.bkCode;
            //label_bkId.Text = book_show.bkId.ToString();
            //label_bkISBN.Text = book_show.bkISBN;
            //string _bkLanguage;
            //switch (book_show.bkLanguage)
            //{ //0-中文，1-英文，2-日文，3-俄文，4-德文，5-法文
            //    case 1:
            //        _bkLanguage = "英文"; break;
            //    case 2:
            //        _bkLanguage = "日文"; break;
            //    case 3:
            //        _bkLanguage = "俄文"; break;
            //    case 4:
            //        _bkLanguage = "德文"; break;
            //    case 5:
            //        _bkLanguage = "法文"; break;
            //    default:
            //        _bkLanguage = "中文"; break;
            //}
            //label_bkLanguage.Text = _bkLanguage;
            //label_bkName.Text = book_show.bkName;
            //label_bkName_title.Text = book_show.bkName;
            //label_bkPage.Text = book_show.bkPages.ToString();
            //label_bkPress.Text = book_show.bkPress;
            //label_bkPressDate.Text = book_show.bkDatePress.ToString();
            //label_bkPrice.Text = book_show.bkPrice.ToString();
            //label_bkStatus.Text = book_show.bkStatus;
            //if (book_show.bkCover != null)
            //{
            //    pictureBox1.Image = Tools.GetImageByBytes(book_show.bkCover);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!editable)
            {
                editable = true;
                panel1.Enabled = true;
                textBox5.Enabled = false;
                textBox10.Enabled = false;
                textBox11.Enabled = false;
                dateTimePicker1.Enabled = false;
                this.Text = this.Text + "[修改信息]";
                button1.Text = "完成修改";
            }
            else
            {
                editable = false;
                panel1.Enabled = false;
                this.Text = "读者详细信息";
                button1.Text = "修改用户信息";
                Reader rd;
                {
                    rd = new Reader();
                    rd.rdID = int.Parse(textBox1.Text);
                    rd.rdUsername = textBox5.Text;
                    rd.rdName = textBox3.Text;
                    rd.rdSex = comboBox2.Text;
                    rd.rdType = int.Parse(comboBox1.Text);
                    rd.rdDept = textBox6.Text;
                    rd.rdPhone = textBox7.Text;
                    rd.rdEmail = textBox8.Text;
                    rd.rdDateReg = dateTimePicker1.Value;
                    rd.rdStatus = textBox10.Text;
                    //rd.rdHaveBorrowNum = textBox11.Text;
                }
                try {
                    int rst = ReaderDAL.UpdateInfo(rd);
                    if(rst<=0){
                        MessageBox.Show("修改信息失败！");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("修改信息失败！");
                }
                
            }
        }
    }
}
