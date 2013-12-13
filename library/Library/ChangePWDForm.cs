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
    public partial class ChangePWDForm : Form
    {
        public string username;
        public ChangePWDForm(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void ChangePWDForm_Load(object sender, EventArgs e)
        {
            if (username == null)
            {
                MessageBox.Show("Error!");
                this.Close();
                return;
            }
            else {
                label5.Text = username;
            }
        }
    }
}
