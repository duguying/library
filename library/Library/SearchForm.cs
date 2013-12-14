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

        private void 删除书籍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book book = new Book();
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
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;//书籍编号
            string bkname=(string)dataGridView1.SelectedRows[0].Cells[2].Value;
            book.bkId = id;
            book.bkName = bkname;

            DialogResult dr = MessageBox.Show("确认删除" + bkname + "？", "对话框标题", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                //点确定的代码
                try {
                    BookDAL.Delete(book);
                }catch(Exception ex){
                    MessageBox.Show("删除失败！");
                    return;
                }
                MessageBox.Show("删除成功");
                FindByCode(null, null);//刷新当前列表
            }
            else
            {   //点取消的代码 
                return;
            }
        }

        
    }
}
