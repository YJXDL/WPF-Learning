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

namespace 第六章.Views
{
    /// <summary>
    /// UC_PropertyChanged.xaml 的交互逻辑
    /// </summary>
    public partial class UC_PropertyChanged : UserControl
    {
        public UC_PropertyChanged()
        {
            InitializeComponent();
            stu = new Student();
            //准备Binging 
            Binding binding = new Binding();
            binding.Source = stu;
            binding.Path=new PropertyPath("Name");
            //使用Binging连接数据源与Binding目标
          BindingOperations.SetBinding(this.txtName,TextBox.TextProperty, binding);
        }
        Student stu;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            stu.Name += "YJX ";
        }
    }
}
