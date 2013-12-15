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
    public partial class SearchUserForm : Form
    {
        public DataTable tmpTbl;
        public DataTable TypeTmpTable;

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
        /// <summary>
        /// 性别过滤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterBySex(object sender, EventArgs e)
        {
            if (tmpTbl==null) {
                return;
            }
            tmpTbl.DefaultView.RowFilter = "性别='" + comboBox1.Text+"'";
            dataGridView1.DataSource = tmpTbl;
        }
        /// <summary>
        /// Load事件函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchUserForm_Load(object sender, EventArgs e)
        {
            TypeTmpTable=ReaderTypeDAL.GetAllReadertype();
            int rows=TypeTmpTable.Rows.Count;
            for (int i = 0; i < rows;i++ ) {
                string id=TypeTmpTable.Rows[i].ItemArray[0].ToString().Trim();
                string name=TypeTmpTable.Rows[i].ItemArray[1].ToString().Trim();
                comboBox2.Items.Add(name+"-"+id);
            }

        }
        /// <summary>
        /// 按读者类型过滤
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TypeFilter(object sender, EventArgs e)
        {
            if (tmpTbl == null)
            {
                return;
            }
            if (comboBox2.Text == "--请选择类型--" || comboBox2.Text == "")
            {
                MessageBox.Show("请选择类型");
                return;
            }
            else {
                
                int rows = TypeTmpTable.Rows.Count;
                bool exist_flag = false;
                for (int i = 0; i < rows; i++)
                {
                    string id = TypeTmpTable.Rows[i].ItemArray[0].ToString().Trim();
                    string name = TypeTmpTable.Rows[i].ItemArray[1].ToString().Trim();
                    string index=(name + "-" + id).Trim();
                    if (index == comboBox2.Text.Trim())
                    {
                        exist_flag = true;
                        tmpTbl.DefaultView.RowFilter = "类型='" + id + "'";
                        object o=this.tmpTbl;
                        dataGridView1.DataSource = tmpTbl;
                        break;
                    }
                }
                if (!exist_flag)
                {
                    MessageBox.Show("选择的类型不存在!");
                    return;
                }
            }
        }
        /// <summary>
        /// 窗口大小调整
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchUserForm_Resize(object sender, EventArgs e)
        {
            dataGridView1.Width=splitContainer1.Panel1.Width-10;
        }
        /// <summary>
        /// 读者详情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReaderDetail(object sender, EventArgs e)
        {
            Reader reader = new Reader();
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Not Exist!");
                return;
            }
            if (tmpTbl.Rows.Count<=0) {
                MessageBox.Show("Not Exist!");
                return;
            }
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;//书籍编号
            DataTable rt;
            try {
                rt = ReaderDAL.GetReaderByID(id);
            }catch(Exception ex){
                MessageBox.Show("获取详细信息失败，当前用户非法！"+ex.Message);
                return;
            }
            
            reader = Reader.RowsToReader(rt.Rows);

            UserDetailForm bdf = new UserDetailForm(reader);
            bdf.Show();
        }
    }
}
