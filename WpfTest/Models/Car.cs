using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace WpfTest.Models
{
    public class Car
    {
        public string Automaker { get; set; }//厂商名称

        public string Name { get; set; }//车名

        public string Year { get; set; }//生产日期

        public string TopSpeed { get; set; }//最高提速
    }
}
