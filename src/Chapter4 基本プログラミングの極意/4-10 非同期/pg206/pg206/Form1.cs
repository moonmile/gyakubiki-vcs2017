using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg206
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CancellationTokenSource cts
            = new CancellationTokenSource();
        private async void button1_Click(object sender, EventArgs e)
        {
            var res = await Task.Factory.StartNew<bool>(() =>
            {

                for (int i = 1; i <= 10; i++)
                {
                    if (cts.Token.IsCancellationRequested)
                    {
                        return false;
                    }
                    this.Invoke(new Action(() =>
                    {
                        label1.Text = $"{i}秒経過";
                    }));
                    System.Threading.Thread.Sleep(1000);
                }
                return true;
            }, cts.Token);

            if (res)
            {
                label1.Text = "タスク正常終了";
            }
            else
            {
                label1.Text = "タスクがキャンセルされました";
            }
        }

        // キャンセルする
        private void button2_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }
    }
}
