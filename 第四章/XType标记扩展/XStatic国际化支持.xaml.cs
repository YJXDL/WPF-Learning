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
using System.Windows.Shapes;

namespace XType标记扩展
{
    /// <summary>
    /// XStatic国际化支持.xaml 的交互逻辑
    /// </summary>
    public partial class XStatic国际化支持 : Window
    {
        public static string WindowTitle = "山高月小";
        public static string ShowText { get { return "水落石出"; } }
        public XStatic国际化支持()
        {
            InitializeComponent();
        }

    }
}
