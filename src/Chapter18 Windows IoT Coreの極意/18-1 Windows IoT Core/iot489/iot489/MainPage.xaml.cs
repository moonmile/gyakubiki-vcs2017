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
using Windows.Devices.I2c;
using Windows.Devices.Enumeration;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace iot489
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
            buttonStop.Click += (_, __) => { pwm1.Reset(); };
            button0.Click += (_, __) => { pwm1.Position = 0; };
            button90.Click += (_, __) => { pwm1.Position = 90; };
            button180.Click += (_, __) => { pwm1.Position = 180; };
        }
        PwmServo pwm1;
        I2cDevice i2cpwm;
        const int PWM_I2C_ADDR = 0x40;
        private async void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                var aqs = I2cDevice.GetDeviceSelector();
                var dis = await DeviceInformation.FindAllAsync(aqs);
                var settings = new I2cConnectionSettings(PWM_I2C_ADDR);
                settings.BusSpeed = I2cBusSpeed.StandardMode;
                i2cpwm = await I2cDevice.FromIdAsync(dis[0].Id, settings);
                pwm1 = new PwmServo(i2cpwm, 0);
            }
            catch ( Exception ex )
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            pwm1.Begin();
            pwm1.SetPWMFreq(60);   // 60Hz 
        }
    }
}
