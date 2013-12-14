using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
//using Library.DAL;

namespace Library
{
    public partial class MainForm : Form
    {
        public string USER;
        public Window t_main;
        public static Form main_form;
        //private int childFormNumber = 0;

        public MainForm(Window t_main,string USER)
        {
            this.t_main = t_main;
            this.USER = USER;
            MainForm.main_form = this;
            InitializeComponent();
        }


#region 自动生成的初始化代码
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
#endregion

#region 窗体事件、关闭窗体

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        //退出确认拦截
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.DialogResult confirm=System.Windows.Forms.MessageBox.Show("确认退出？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (System.Windows.Forms.DialogResult.Yes != confirm)
            {
                e.Cancel = true;
                return;
            }
            else
            {
                e.Cancel = false;
                this.t_main.Close();
            }
        }
#endregion

#region 菜单click事件入口
        //新书入库菜单
        private void NewBook(object sender, EventArgs e)
        {
             NewBookForm fnb = new NewBookForm();
            fnb.MdiParent = this;
            fnb.StartPosition = FormStartPosition.CenterScreen;
            fnb.WindowState = FormWindowState.Maximized;
            fnb.Show();
        }

        //办理借书证
        private void CardRegistor(object sender, EventArgs e)
        {
            NewReaderForm nr = new NewReaderForm();
            nr.MdiParent = this;
            nr.StartPosition = FormStartPosition.CenterScreen;
            nr.WindowState = FormWindowState.Maximized;
            nr.Show();
        }

        //借书证信息变更
        private void UpdateCard(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("借书证信息变更", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        //结束证挂失与解除
        private void CardLock(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("结束证挂失与解除", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        //注销借书证
        private void UnregistorCard(object sender, EventArgs e)
        {

        }

        //读者类型管理
        private void ReaderType(object sender, EventArgs e)
        {

        }

        //借书
        private void Borrow(object sender, EventArgs e)
        {
            BorrowForm f = new BorrowForm(0);
            f.Show();
        }

        //续借
        private void Renew(object sender, EventArgs e)
        {
            BorrowForm f = new BorrowForm(2);
            f.Show();
        }

        //还书
        private void ReturnBook(object sender, EventArgs e)
        {
            BorrowForm f = new BorrowForm(1);
            f.Show();
        }

        //权限
        private void Power(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 修改当前用户密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangePSW(object sender, EventArgs e)
        {
            if (this.USER == null)
            {
                System.Windows.MessageBox.Show("Error! No Username!!!");
                return;
            }
            else {
                ChangePWDForm cp = new ChangePWDForm(this.USER);
                cp.Show();
            }
            
            
        }
#endregion

        private void AddUser(object sender, EventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show("添加用户", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
            AdduserForm fau = new AdduserForm();
            fau.MdiParent = this;
            fau.StartPosition = FormStartPosition.CenterScreen;
            fau.WindowState = FormWindowState.Maximized;
            fau.Show();
        }

        private void SearchBook(object sender, EventArgs e)
        {
            SearchForm fsb = new SearchForm();
            fsb.MdiParent = this;
            fsb.StartPosition = FormStartPosition.CenterScreen;
            fsb.WindowState = FormWindowState.Maximized;
            fsb.Show();
        }
        /// <summary>
        /// 查找用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void findUser(object sender, EventArgs e)
        {
            
        }

        private void 查找读者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchUserForm fu = new SearchUserForm();
            fu.MdiParent = this;
            fu.StartPosition = FormStartPosition.CenterScreen;
            fu.WindowState = FormWindowState.Maximized;
            fu.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.MessageBox.Show("计科11101班-李俊-201103233\nAuthor: Rex Lee(李俊)\nEmail:duguying2008@gmail.com\nSite:www.duguying.net");
        }


    }
}
