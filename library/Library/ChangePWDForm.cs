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
    public partial class ChangePWDForm : Form
    {
        public string username;
        public ChangePWDForm(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void ChangePWDForm_Load(object sender, EventArgs e)
        {
            if (username == null)
            {
                MessageBox.Show("Error!");
                this.Close();
                return;
            }
            else {
                label5.Text = username;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""||textBox2.Text==""||textBox3.Text==""){
                MessageBox.Show("不允许有空字段！");
                return;
            }
            if (textBox2.Text != textBox3.Text) {
                MessageBox.Show("两次输入的密码不一致！");
                return;
            }
            try {
                if (AdminAction.ChangePWD(username, textBox1.Text, textBox2.Text) > 0) {
                    MessageBox.Show("修改成功！");
                    this.Close();
                };
            }catch(Exception ex){
                MessageBox.Show("修改失败！\n"+ex.Message);
            }
        }
    }
}
