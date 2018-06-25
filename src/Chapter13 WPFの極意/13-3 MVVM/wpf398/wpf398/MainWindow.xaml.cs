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

namespace wpf398
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        MyModel _model = new MyModel();
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _model.Items.Add(new MyItem() { ID = 1, Name = "増田 智明", Addr = "東京" });
            _model.Items.Add(new MyItem() { ID = 2, Name = "山田 太郎", Addr = "北海道" });
            _model.Items.Add(new MyItem() { ID = 3, Name = "岸和田 次郎", Addr = "大阪" });
            _model.Items.Add(new MyItem() { ID = 4, Name = "林 三郎", Addr = "沖縄" });
            this.DataContext = _model;
        }
    }
}
