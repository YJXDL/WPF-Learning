﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ItemControl使用说明
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            //stackpanel1.Children.Add(new UserControl1());
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            stackpanel1.Children.Clear();
            UserControl1 showuserControl = new UserControl1();
           stackpanel1
            stackpanel1.Children.Add(showuserControl);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            stackpanel1.Children.Clear();
            stackpanel1.Children.Add(new ListBoxEmplyee());
        }
    }
}
