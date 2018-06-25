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

namespace wpf379
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

        private bool _isDrag;   // ドラッグ中
        private Point _offset;  // オフセット
        /// <summary>
        /// マウスダウン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDragMouseDown(object sender, MouseButtonEventArgs e)
        {
            var el = sender as UIElement;
            if (el != null)
            {
                // ドラッグ開始
                _isDrag = true;
                // オフセットを保存
                _offset = e.GetPosition(el);
                // ドラッグ中は半透明に
                ellipse1.Opacity = 0.5;
                // マウスキャプチャ
                el.CaptureMouse();
            }
        }
        /// <summary>
        /// マウス移動
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDragMouseMove(object sender, MouseEventArgs e)
        {
            if (_isDrag)
            {
                var pt = Mouse.GetPosition(board);
                ellipse1.Margin = new Thickness(
                    pt.X - _offset.X, pt.Y - _offset.Y, 0, 0);
            }
        }
        /// <summary>
        /// マウスアップ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDragMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (_isDrag)
            {
                var el = sender as UIElement;
                // ドラッグ終了
                _isDrag = false;
                // 透明度を戻す
                ellipse1.Opacity = 1.0;
                // キャプチャをリリース
                el.ReleaseMouseCapture();
            }
        }
    }
}
