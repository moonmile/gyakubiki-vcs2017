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

namespace wpf391
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

        // 右へ移動
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            double x = Canvas.GetLeft(this.rect);
            Canvas.SetLeft(this.rect, x + 20);
        }
        // 下へ移動
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            double y = Canvas.GetTop(this.rect);
            Canvas.SetTop(this.rect, y + 20);
        }
        // 初期値へ戻す
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(this.rect, 10);
            Canvas.SetTop(this.rect, 10);
        }
    }
}
