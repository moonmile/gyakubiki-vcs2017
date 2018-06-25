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

namespace iot490
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            RPi.Gpio = GpioController.GetDefault();
            _motor = new Motor(23, 24);
            buttonForword.Click += (_,__) => { _motor.Direction = 1; };
            buttonBack.Click += (_, __) => { _motor.Direction = -1; };
            buttonStop.Click += (_, __) => { _motor.Direction = 0; };
        }
        Motor _motor;
    }
    public class RPi
    {
        public static GpioController Gpio { get; set; }
    }
    public class Motor
    {
        private GpioPin _out1;
        private GpioPin _out2;
        public Motor( int pin1, int pin2 )
        {
            _out1 = RPi.Gpio.OpenPin(pin1);
            _out2 = RPi.Gpio.OpenPin(pin2);
            _out1.Write(GpioPinValue.Low);
            _out2.Write(GpioPinValue.Low);
            _out1.SetDriveMode(GpioPinDriveMode.Output);
            _out2.SetDriveMode(GpioPinDriveMode.Output);
        }
        private int _dir = 0;
        public int Direction
        {
            get { return _dir; }
            set
            {
                if ( _dir != value )
                {
                    _dir = value;
                    if ( _dir == 0 )
                    {
                        _out1.Write(GpioPinValue.Low);
                        _out2.Write(GpioPinValue.Low);
                    }
                    else if ( _dir > 0 )
                    {
                        _out1.Write(GpioPinValue.High);
                        _out2.Write(GpioPinValue.Low);
                    }
                    else
                    {
                        _out1.Write(GpioPinValue.Low);
                        _out2.Write(GpioPinValue.High);
                    }
                }
            }
        }
    }
}
