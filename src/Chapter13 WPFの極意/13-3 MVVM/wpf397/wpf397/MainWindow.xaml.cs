﻿using System;
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

namespace wpf397
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
            _model.Items.Add("さる");
            _model.Items.Add("きじ");
            _model.Items.Add("いぬ");
            _model.Items.Add("桃太郎");
            _model.Items.Add("赤おに");
            _model.Items.Add("青おに");
            this.DataContext = _model;
        }
    }
}
