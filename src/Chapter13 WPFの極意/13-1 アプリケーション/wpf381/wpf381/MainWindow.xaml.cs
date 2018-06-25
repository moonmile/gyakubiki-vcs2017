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

namespace wpf381
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            if (checkBox1.IsChecked == true)
            {
                InkCanvas1.DefaultDrawingAttributes.Color = Colors.Red;
                InkCanvas1.DefaultDrawingAttributes.Width = 10;
            }
            else
            {
                InkCanvas1.DefaultDrawingAttributes.Color = Colors.Black;
                InkCanvas1.DefaultDrawingAttributes.Width = 2;
            }
        }
    }
}
