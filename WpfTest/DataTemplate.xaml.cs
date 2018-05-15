using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using System.Globalization;
using WpfTest.Models;
using System.Collections.Generic;

namespace WpfTest
{
    /// <summary>
    /// DataTemplate.xaml 的交互逻辑
    /// </summary>
    public partial class DataTemplate : Window
    {
        public DataTemplate()
        {
            InitializeComponent();
            InitialCarList();
        }

        //初始化ListBox
        private void InitialCarList()
        {
            List<Car> carList = new List<Car>()
            {
                new Car() {Automaker="宝马",Name="宝马V5",Year="1990",TopSpeed="360"},
                new Car() {Automaker="大众",Name="上海大众12",Year="1998",TopSpeed="300"},
                new Car() {Automaker="东风日产",Name="东风A2",Year="2001",TopSpeed="320"},
                new Car() {Automaker="海马",Name="海马2代",Year="1995",TopSpeed="340"},
            };
            //填充数据源
            this.ListBoxCars.ItemsSource = carList;
        }
    }

    //厂商名称转换为Logo图片路径
    public class AutomakerToLogoPathConverter : IValueConverter
    {
        //正向转换
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string uriStr = string.Format(@"/Resources/Car_Logo/{0}.jpg", (string)value);
            return new BitmapImage(new Uri(uriStr, UriKind.Relative));
        }

        //未被用到
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    //汽车名称转换为汽车图片路径
    public class NameToLogoPathConverter : IValueConverter
    {
        //正向转换
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string uriStr = string.Format(@"/Resources/Car_Image/{0}.jpg", (string)value);
            return new BitmapImage(new Uri(uriStr, UriKind.Relative));
        }

        //未被用到
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
