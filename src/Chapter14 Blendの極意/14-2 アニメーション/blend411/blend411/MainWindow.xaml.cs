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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace blend411
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
        Storyboard _sb = null;

        private void regularPolygon_MouseEnter(object sender, MouseEventArgs e)
        {
            _sb = this.Resources["Storyboard1"] as Storyboard;
            // アニメーションを繰り返す
            _sb.RepeatBehavior = RepeatBehavior.Forever;
            _sb.Begin();

        }

        private void regularPolygon_MouseLeave(object sender, MouseEventArgs e)
        {
            if (_sb != null)
            {
                _sb.Stop();
                _sb.BeginTime = new TimeSpan(0);
                _sb = null;
            }
        }
    }
}
