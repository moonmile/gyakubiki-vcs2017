using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Gpio;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace iot487
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
            ledPin = gpio.OpenPin(4);
            ledPin.SetDriveMode(GpioPinDriveMode.Output);
        }
        GpioPin ledPin;
        private void toggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            if ( toggleSwitch.IsOn )
            {
                ledPin.Write(GpioPinValue.High);
            }
            else
            {
                ledPin.Write(GpioPinValue.Low);
            }
        }
    }
}
