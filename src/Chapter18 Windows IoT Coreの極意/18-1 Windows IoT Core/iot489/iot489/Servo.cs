using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.I2c;

namespace iot489
{
    class PwmServo
    {
        const int PCA9685_SUBADR1 = 0x2;
        const int PCA9685_SUBADR2 = 0x3;
        const int PCA9685_SUBADR3 = 0x4;
        const int PCA9685_MODE1 = 0x0;

        const int PCA9685_PRESCALE = 0xfe;
        const int LED0_ON_L = 0x6;
        const int LED0_ON_H = 0x7;
        const int LED0_OFF_L = 0x8;

        const int LED0_OFF_H = 0x9;
        const int ALLLED_ON_L = 0xfa;
        const int ALLLED_ON_H = 0xfb;
        const int ALLLED_OFF_L = 0xfc;

        const int ALLLED_OFF_H = 0xfd;
        private int _i2caddr;
        private I2cDevice i2c;

        private int _num = 0;
        const int SERVOMIN = 150;

        const int SERVOMAX = 600;

        public PwmServo(I2cDevice i2cDev, int num = 0, int addr = 0x40)
        {
            i2c = i2cDev;
            _i2caddr = addr;
            _num = num;
        }
        public void Begin()
        {
            this.Reset();
        }
        public void Reset()
        {
            write8(PCA9685_MODE1, 0);
        }

        public async void SetPWMFreq(double freq)
        {
            freq *= 0.9;
            double prescaleval = 25000000;
            prescaleval /= 4096;
            prescaleval /= freq;
            prescaleval -= 1;

            int prescale = (int)(prescaleval + 0.5);

            int oldmode = read8(PCA9685_MODE1);
            int newmode = (oldmode & 0x7F) | 0x10;
            //  sleep
            write8(PCA9685_MODE1, newmode);
            write8(PCA9685_PRESCALE, prescale);
            write8(PCA9685_MODE1, oldmode);
            await Task.Delay(5);
            write8(PCA9685_MODE1, oldmode | 0xA1);
        }


        public void SetPWM(int num, int @on, int off)
        {
            dynamic data = new byte[] {
                Convert.ToByte(LED0_ON_L + 4 * num),
                Convert.ToByte(@on & 255),
                Convert.ToByte(@on >> 8),
                Convert.ToByte(off & 255),
                Convert.ToByte(off >> 8)
            };
            i2c.Write(data);
        }
        public void SetPin(int num, int val, bool invert = false)
        {
            // Clamp value between 0 and 4095 inclusive.
            val = Math.Min(val, 4095);
            if (invert)
            {
                if (val == 0)
                {
                    // Special value for signal fully on.
                    SetPWM(num, 4096, 0);
                }
                else if (val == 4095)
                {
                    // Special value for signal fully off.
                    SetPWM(num, 0, 4096);
                }
                else
                {
                    SetPWM(num, 0, 4095 - val);
                }
            }
            else
            {
                if (val == 4095)
                {
                    // Special value for signal fully on.
                    SetPWM(num, 4096, 0);
                }
                else if (val == 0)
                {
                    // Special value for signal fully off.
                    SetPWM(num, 0, 4096);
                }
                else
                {
                    SetPWM(num, 0, val);
                }
            }
        }

        private int read8(int addr)
        {
            dynamic wdata = new byte[] { Convert.ToByte(addr) };
            dynamic rdata = new byte[1];

            i2c.WriteRead(wdata, rdata);
            return Convert.ToInt32(rdata(0));
        }
        private void write8(int addr, int d)
        {
            dynamic data = new byte[] {
                Convert.ToByte(addr),
                Convert.ToByte(d)
            };
            i2c.Write(data);
        }

        private int _position = 0;
        public int Position
        {
            get { return _position; }
            set
            {
                int v = Math.Max(0, value);
                v = Math.Min(value, 180);
                _position = v;
                v = (int)((SERVOMAX - SERVOMIN) * (double)_position / 180.0 + SERVOMIN);
                this.SetPWM(_num, 0, v);
            }
        }
    }
}
