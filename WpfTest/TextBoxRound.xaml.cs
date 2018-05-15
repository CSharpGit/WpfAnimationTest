using System;
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
using System.Windows.Shapes;

namespace WpfTest
{
    /// <summary>
    /// TextBoxRound.xaml 的交互逻辑
    /// </summary>
    public partial class TextBoxRound : Window
    {
        public TextBoxRound()
        {
            InitializeComponent();
        }

        private void New_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(this.tb1.Text))
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
            }
            e.Handled = true;
        }

        private void New_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.tb2.Text = this.tb1.Text;
            e.Handled = true;
        }
    }
}
