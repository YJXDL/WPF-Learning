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

        private void btn_WithoutPathAndSourceStackpanel_Click(object sender, RoutedEventArgs e)
        {
            ShowUserControl.Children.Clear();
            WithoutPathAndSourceStackpanel withoutPathAndSourceStackpanel = new WithoutPathAndSourceStackpanel();
            ShowUserControl.Children.Add(withoutPathAndSourceStackpanel);
        }

        private void btn_PropertiesPassedDown_Click(object sender, RoutedEventArgs e)
        {
            ShowUserControl.Children.Clear();
            PropertiesPassedDown propertiesPassedDown = new PropertiesPassedDown();
            ShowUserControl.Children.Add(propertiesPassedDown);
        }

        private void btn_CollectionAsBindingSource_Click(object sender, RoutedEventArgs e)
        {
            ShowUserControl.Children.Clear();
            CollectionAsBindingSource collectionAsBindingSource = new CollectionAsBindingSource();
            ShowUserControl.Children.Add(collectionAsBindingSource);
        }

        private void btn_DataTableAsBindingSource_Click(object sender, RoutedEventArgs e)
        {
            ShowUserControl.Children.Clear();
            DataTableAsBindingSource dataTableAsBindingSource = new DataTableAsBindingSource();
            ShowUserControl.Children.Add(dataTableAsBindingSource);
        }

        private void btn_XMLASBingingSource_Click(object sender, RoutedEventArgs e)
        {
            ShowUserControl.Children.Clear();
            XMLASBingingSource xMLASBingingSource= new XMLASBingingSource();
            ShowUserControl.Children.Add(xMLASBingingSource);
        }

        private void btn_XMLAsTreeview_Click(object sender, RoutedEventArgs e)
        {
            ShowUserControl.Children.Clear();
            XMLAsTreeview xMLAsTreeview= new XMLAsTreeview();
            ShowUserControl.Children.Add(xMLAsTreeview);
        }

        private void btn_LinqAsBindingSource_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
