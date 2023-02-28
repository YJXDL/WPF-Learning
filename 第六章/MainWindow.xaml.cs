using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using 第六章.Views;

namespace 第六章
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_PropertyChanged_Click(object sender, RoutedEventArgs e)
        {
            ShowUserControl.Children.Clear();
            UC_PropertyChanged uC_PropertyChanged = new UC_PropertyChanged();
            
            ShowUserControl.Children.Add(uC_PropertyChanged);
        }

        private void btn_ControlAsSource_Click(object sender, RoutedEventArgs e)
        {
            ShowUserControl.Children.Clear();
            ControlAsSource controlAsSource = new ControlAsSource();
            ShowUserControl.Children.Add(controlAsSource);
        }
    }
}
