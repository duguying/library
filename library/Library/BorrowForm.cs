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
using Library.DAL;
using Library.BLL;

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
            textBox1.Text = userid;
            textBox2.Text = bookcode;

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
             if(textBox2.Text==""){
                MessageBox.Show("书籍ID为空！");
                return;
            }else if(textBox1.Text==""){
                if(type==0){//借书时用户不能为空
                    MessageBox.Show("用户ID为空！");
                    return;
                }
            }

             Borrow br = new Borrow();
             br.bkId = int.Parse(textBox2.Text);
             br.rdId = int.Parse(textBox1.Text);

             try { 
             
                 if (type == 2)
                 {
                     if (BorrowAction.Renew(br) > 0)
                     {
                         MessageBox.Show("续借成功！");
                     }
                     else {
                         MessageBox.Show("续借失败");
                         return;
                     }
                 }
                 else if (type == 1)
                 {
                     if (BorrowAction.Back(br) > 0)
                     {
                         MessageBox.Show("续借成功！");
                     }
                     else
                     {
                         MessageBox.Show("续借失败");
                         return;
                     }
                 }
                 else
                 {
                     if (BorrowAction.Borrow(br) > 0)
                     {
                         MessageBox.Show("续借成功！");
                     }
                     else
                     {
                         MessageBox.Show("续借失败");
                         return;
                     }
                 }

             }catch(Exception ex){
                 MessageBox.Show("借书失败！请检查读者ID或书籍ID信息！");
             }

            ///提交之后
             button1.Enabled = false;
        }
    }
}
