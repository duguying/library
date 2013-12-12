using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.BLL;

namespace Library
{
    public partial class SearchUserForm : Form
    {
        public DataTable tmpTbl;
        public SearchUserForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 通过用户名查找用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetUserByUsername(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            if(username==""){
                MessageBox.Show("用户名为空！");
                return;
            }
            this.tmpTbl=ReaderAction.getUserByUsername(username);
            dataGridView1.DataSource = tmpTbl;
        }
        /// <summary>
        /// 通过姓名查找用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetUserByName(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            if (name == "")
            {
                MessageBox.Show("姓名为空！");
                return;
            }
            this.tmpTbl = ReaderAction.getUserByName(name);
            dataGridView1.DataSource = tmpTbl;
        }

        private void FilterBySex(object sender, EventArgs e)
        {
            tmpTbl.DefaultView.RowFilter = "性别='" + comboBox1.Text+"'";
            dataGridView1.DataSource = tmpTbl;
        }
    }
}
