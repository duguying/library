using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class BorrowForm : Form
    {
        public int type;//0借书；1-还书；2-续借
        public string userid;
        public string bookcode;
        public BorrowForm(int type,string userid="",string bookcode="")
        {
            this.type = type;
            this.userid = userid;
            this.bookcode = bookcode;
            if (type < 0) { MessageBox.Show("Error!Rex..."); return; }
            InitializeComponent();
        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {
            if(type==2){
                this.Text = label3.Text = button1.Text = "续借";
            }
            else if (type == 1)
            {
                this.Text = label3.Text = button1.Text = "还书";
            }
            else {
                this.Text = label3.Text = button1.Text = "借书";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///提交之前
             if(bookcode==""){
                MessageBox.Show("书籍馆藏条码为空！");
                return;
            }else if(userid==""){
                if(type==0){//借书时用户不能为空
                    MessageBox.Show("用户ID为空！");
                    return;
                }
            }



            ///提交之后
             button1.Enabled = false;
        }
    }
}
