﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
//using System.Windows.Navigation.NavigationService;
using System.Windows.Shapes;

namespace Library
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
		public void DragWindow(object sender, MouseButtonEventArgs args)
        {
            this.DragMove();
        }
		public void ExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username=this.tb_username.Text;
            string password = this.tb_password.Password;
            bool rst = DAL.DAL.login(username, password);
            if (rst)
            {
                MainForm win = new MainForm(this);
                win.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("登录失败！");
            }
            
        }
		
    }
}
