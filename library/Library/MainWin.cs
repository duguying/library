using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace Library
{
    public partial class MainWin : Form
    {
        public Window t_main;
        public MainWin(Window t_main)
        {
            this.t_main = t_main;
            InitializeComponent();
        }

        private void MainWin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void MainWin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.t_main.Close();
        }
    }
}
