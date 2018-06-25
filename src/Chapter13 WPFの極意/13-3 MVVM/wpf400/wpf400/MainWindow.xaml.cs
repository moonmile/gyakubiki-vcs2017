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

namespace wpf400
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
        private void clickBind(object sender, RoutedEventArgs e)
        {
            _model.Person = new Person() { ID = 10, Name = "Tomoaki", Addr = "Tokyo" };
            _model.Login = new Login() { ID = "xyz", Pass = "p@ssw0rd", Mail = "masuda@mail.com" };
            this.DataContext = _model;
        }
    }
}
