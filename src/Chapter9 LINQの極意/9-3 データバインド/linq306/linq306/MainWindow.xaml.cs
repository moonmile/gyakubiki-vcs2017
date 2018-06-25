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

namespace linq306
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

        private void clickButton(object sender, RoutedEventArgs e)
        {
            var ent = new Database1Entities();
            // 検索対象のレコードを検索する
            var q = from t in ent.商品
                    select t;
            // ComboBoxにバインド
            comboBox1.DisplayMemberPath = "商品名";
            comboBox1.ItemsSource = q.ToList();
            // Listview にバインド
            listView1.ItemsSource = q.ToList();
        }
    }
}
