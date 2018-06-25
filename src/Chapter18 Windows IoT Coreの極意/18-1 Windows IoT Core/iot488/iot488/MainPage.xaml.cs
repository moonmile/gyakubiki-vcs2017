using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Devices.Gpio;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace iot488
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            var gpio = GpioController.GetDefault();
            var buttonPin = gpio.OpenPin(12);
            buttonPin.SetDriveMode(GpioPinDriveMode.InputPullDown);
            buttonPin.ValueChanged += ButtonPin_ValueChanged;
        }

        SolidColorBrush red = new SolidColorBrush(Windows.UI.Colors.Red);
        SolidColorBrush gray = new SolidColorBrush(Windows.UI.Colors.LightGray);

        private async void ButtonPin_ValueChanged(GpioPin sender, GpioPinValueChangedEventArgs args)
        {
            if ( args.Edge == GpioPinEdge.FallingEdge )
            {
                await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
                    () => {
                        if ( ell.Fill.Equals( red))
                        {
                            ell.Fill = gray;
                        }
                        else
                        {
                            ell.Fill = red;
                        }
                    });
            }
        }
    }
}
