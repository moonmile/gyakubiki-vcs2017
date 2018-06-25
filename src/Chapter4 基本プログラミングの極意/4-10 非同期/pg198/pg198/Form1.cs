using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg198
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var ret =
                await Task.Factory.StartNew(() =>
                {
                    for (int i = 0; i < 10; i++)
                    {
                        this.Invoke(new Action(() =>
                        {
                            label1.Text = $"{i}秒経過";
                        }));
                        System.Threading.Thread.Sleep(1000);
                    }
                    return DateTime.Now;
                });
            label1.Text = $"最終時刻:{ret}";
        }
    }
}
