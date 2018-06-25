using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg197
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // タスク生成と同時に実行
        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Factory.StartNew((() =>
            {
                for (int i = 0; i < 60; i++)
                {
                    this.Invoke(new Action(() =>
                    {
                        label1.Text = DateTime.Now.ToString("HH:MM:ss");
                    }));
                    System.Threading.Thread.Sleep(1000);
                }
            }));
        }

        // 数秒後に実行
        private async void button2_Click(object sender, EventArgs e)
        {
            Task task = new Task((() =>
            {
                for (int i = 0; i < 60; i++)
                {
                    this.Invoke(new Action(() =>
                    {
                        label1.Text = DateTime.Now.ToString("HH:MM:ss");
                    }));
                    System.Threading.Thread.Sleep(1000);
                }
            }));
            await Task.Delay(5000);
            task.Start();
        }
    }
}
