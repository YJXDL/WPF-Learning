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

namespace ItemControl使用说明
{
    /// <summary>
    /// ListBoxEmplyee.xaml 的交互逻辑
    /// </summary>
    public partial class ListBoxEmplyee : UserControl
    {
        public ListBoxEmplyee()
        {
            InitializeComponent();
        }

        List<Employee> employees = new List<Employee>()
        {
            new Employee() { Id=1,Name="Tim1",Age=30},
            new Employee() { Id=2,Name="Tim2",Age=30},
            new Employee() { Id=3,Name="Tim3",Age=30},
            new Employee() { Id=4,Name="Tim4",Age=30},
            new Employee() { Id=5,Name="Tim5",Age=30},
            new Employee() { Id=6,Name="Tim6",Age=30},
            new Employee() { Id=7,Name="Tim7",Age=30},
        };
        private void listemp_Load(object sender, RoutedEventArgs e)
        {
            this.listBoxemp1.DisplayMemberPath = "Name";
            this.listBoxemp1.SelectedValuePath = "Id";
            this.listBoxemp1.ItemsSource = employees;
        }

        private void showId_Click(object sender, RoutedEventArgs e)
        {
            string val1 = this.listBoxemp1.SelectedValue.ToString();
            MessageBox.Show(val1);
        }
    }
}
