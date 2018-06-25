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

namespace wpf392
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

        MyModel _model = new MyModel();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = _model;
        }

        private void clickOutput(object sender, RoutedEventArgs e)
        {
            _model.OutText = "入力:[" + _model.InText + "]";

        }
    }
}
