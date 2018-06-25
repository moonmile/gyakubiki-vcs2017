using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui080
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TimeSpan startTime = new TimeSpan(0, 0, 0);
        TimeSpan addSecond = new TimeSpan(0, 0, 1);

        private void timer1_Tick(object sender, EventArgs e)
        {
            startTime = startTime + addSecond;
            label1.Text = startTime.ToString();
            if (startTime == new TimeSpan(3, 0, 0))
            {
                timer1.Stop();
                MessageBox.Show("3分経過しました。");
                label1.Text = new TimeSpan(0, 0, 0).ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            startTime = new TimeSpan(0, 0, 0);
            label1.Text = startTime.ToString();
        }
    }
}
