using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用标签的Attribute属性为对象赋值
{
    [TypeConverter(typeof(StringToHumanTypeConverter))]
    internal class Human
    {
        public string Name { get; set; }
        public Human Child { get; set; }
    }
}
