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
            BookListForm blf=new BookListForm();
            blf.MdiParent = MainForm.main_form;
            blf.StartPosition = FormStartPosition.CenterScreen;
            blf.WindowState = FormWindowState.Maximized;
            blf.Show();
        }
    }
}
