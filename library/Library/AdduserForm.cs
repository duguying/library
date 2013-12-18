using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.DAL;
using Library.Model;
using Library.BLL;

namespace Library
{
    public partial class AdduserForm : Form
    {
        public AdduserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string pwd = maskedTextBox1.Text;
            string email = textBox2.Text;
            if(username==""){
                MessageBox.Show("管理员用户名不能为空");
                return;
            }
            if(pwd==""||maskedTextBox2.Text==""){
                MessageBox.Show("管理员密码不能为空");
                return;
            }
            if (maskedTextBox1.Text != maskedTextBox2.Text) {
                MessageBox.Show("两次输入的密码不一致");
                return;
            }
            Admin adm = new Admin();
            adm.adminEmail = email;
            adm.adminPassword = pwd;
            adm.adminUsername = username;
            adm.adminLastLoginDate = DateTime.Now;
            try {
                AdminDAL.Add(adm);
                MessageBox.Show("添加成功");
            }catch(Exception ex){
                MessageBox.Show("添加失败！");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Control c in  panel1.Controls){
                c.Text = "";
            }
        }
    }
}
