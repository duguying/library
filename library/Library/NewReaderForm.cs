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
    public partial class NewReaderForm : Form
    {
        public string picturePath;
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
    }
}
