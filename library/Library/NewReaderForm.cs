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
    public partial class NewReaderForm : Form
    {
        public string picturePath;
        DataTable TypeTmpTable;

        public NewReaderForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FileDialog cc = new OpenFileDialog();
            cc.Filter = "图片文件(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png|所有文件(*.*)|*.*";
            if (cc.ShowDialog() != DialogResult.Cancel)
            {
                pictureBox1.ImageLocation = cc.FileName;
                this.picturePath = cc.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls) {
                if (c.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    c.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string pwd = textBox2.Text;
            if(textBox2.Text!=textBox3.Text){
                MessageBox.Show("密码不一致，请重新输入！");
                return;
            }
            string name = textBox4.Text;
            string sex = comboBox1.Text;
            string type = comboBox2.Text;
            string dept = textBox5.Text;
            string phone = textBox6.Text;
            string email = textBox7.Text;
            Reader rd = new Reader();
            rd.rdDateReg = DateTime.Now;
            rd.rdDept = dept;
            rd.rdEmail = email;
            rd.rdHaveBorrowNum = 0;
            //rd.rdID
            rd.rdName = name;
            rd.rdPassword = pwd;
            rd.rdPhone = phone;

            byte[] picbyte;
            if (this.picturePath != null)
            {
                picbyte = Tools.GetBytesByImagePath(this.picturePath);
            }
            else
            {
                picbyte = Tools.GetBytesByImage(pictureBox1);
            };

            string tpid = "0";
            #region
            if (comboBox2.Text == "--请选择类型--" || comboBox2.Text == "")
            {
                MessageBox.Show("请选择类型");
                return;
            }
            else
            {

                int rows = TypeTmpTable.Rows.Count;
                bool exist_flag = false;
                
                for (int i = 0; i < rows; i++)
                {
                    tpid = TypeTmpTable.Rows[i].ItemArray[0].ToString().Trim();
                    string tp_name = TypeTmpTable.Rows[i].ItemArray[1].ToString().Trim();
                    string index = (tp_name + "-" + tpid).Trim();
                    if (index == comboBox2.Text.Trim())
                    {
                        exist_flag = true;
                        break;
                    }
                }
                if (!exist_flag)
                {
                    MessageBox.Show("选择的类型不存在!");
                    return;
                }
            }
            #endregion

            rd.rdPhoto = picbyte;
            rd.rdSex = sex;
            rd.rdStatus = "正常";
            rd.rdType = short.Parse(tpid);
            rd.rdUsername = username;
            try
            {
                ReaderDAL.Add(rd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加失败");
                return;
            }
            
        }

        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewReaderForm_Load(object sender, EventArgs e)
        {
            TypeTmpTable = ReaderTypeDAL.GetAllReadertype();
            int rows = TypeTmpTable.Rows.Count;
            for (int i = 0; i < rows; i++)
            {
                string id = TypeTmpTable.Rows[i].ItemArray[0].ToString().Trim();
                string name = TypeTmpTable.Rows[i].ItemArray[1].ToString().Trim();
                comboBox2.Items.Add(name + "-" + id);
            }
        }
    }
}
