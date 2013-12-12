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

        private void BookDetail(object sender, EventArgs e)
        {
            Book book=new Book();
            if(dataGridView1.SelectedRows.Count<=0){
                return;
            }
            int id=(int)dataGridView1.SelectedRows[0].Cells[0].Value;//书籍编号
            //book.bkCode=dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //book.bkName=dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            //book.bkAuthor=dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            //book.bkPress=dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            //book.bkDatePress=(DateTime)dataGridView1.SelectedRows[0].Cells[5].Value;
            //book.bkISBN=dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            //book.bkCatalog=dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            //book.bkLanguage=(short)dataGridView1.SelectedRows[0].Cells[8].Value;
            //book.bkPages=(int)dataGridView1.SelectedRows[0].Cells[9].Value;
            //book.bkPrice = float.Parse(dataGridView1.SelectedRows[0].Cells[10].Value.ToString());
            //book.bkDateIn = (DateTime)dataGridView1.SelectedRows[0].Cells[11].Value;
            //book.bkBrief=dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            //book.bkStatus=dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            //book.dataGridView1.SelectedRows[0].Cells[13];
            DataTable rt=BookDAL.GetBookById(id);
            book=Book.RowsToBook(rt.Rows);

            BookDetailForm bdf = new BookDetailForm(book);
            bdf.Show();
        }

        
    }
}
