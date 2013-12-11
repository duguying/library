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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 书籍查询动作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchBookClick(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// 根据条码精确查找
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindByCode(object sender, EventArgs e)
        {
            string code=textBox3.Text;
            if(""==code){
                MessageBox.Show("条码为空！");
                return;
            }
            Book book = new Book();
            book.bkCode = code;
            DataTable resultTable=BookDAL.FindByKeyword(book);
            dataGridView1.DataSource = resultTable;
        }
        /// <summary>
        /// Enter键触发click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Return){
                this.FindByCode(null,null);
            }
        }

        
    }
}
