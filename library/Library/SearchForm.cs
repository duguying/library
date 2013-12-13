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
        DataTable resultTable;
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
            resultTable=BookDAL.FindByKeyword(book);
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

        private void BookDetail(object sender, EventArgs e)
        {
            Book book=new Book();
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Not Exist!");
                return;
            }
            if (resultTable.Rows.Count <= 0)
            {
                MessageBox.Show("Not Exist!");
                return;
            }
            int id=(int)dataGridView1.SelectedRows[0].Cells[0].Value;//书籍编号
            DataTable rt=BookDAL.GetBookById(id);
            book=Book.RowsToBook(rt.Rows);

            BookDetailForm bdf = new BookDetailForm(book);
            bdf.Show();
        }

        
    }
}
