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
        public Window t_main;
        public static Form main_form;
        //private int childFormNumber = 0;

        public MainForm(Window t_main)
        {
            this.t_main = t_main;
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

        //更新图书信息
        private void UpdateBook(object sender, EventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show("新书入库菜单", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
            UpdateBookForm fub = new UpdateBookForm();
            fub.MdiParent = this;
            fub.StartPosition = FormStartPosition.CenterScreen;
            fub.WindowState = FormWindowState.Maximized;
            fub.Show();
        }

        //办理借书证
        private void CardRegistor(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("办理借书证", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
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

        }

        //续借
        private void Renew(object sender, EventArgs e)
        {

        }

        //还书
        private void ReturnBook(object sender, EventArgs e)
        {

        }

        //权限
        private void Power(object sender, EventArgs e)
        {

        }

        //修改密码
        private void ChangePSW(object sender, EventArgs e)
        {

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
            SearchUserForm fu = new SearchUserForm();
            fu.MdiParent = this;
            fu.StartPosition = FormStartPosition.CenterScreen;
            fu.WindowState = FormWindowState.Maximized;
            fu.Show();
        }


    }
}
