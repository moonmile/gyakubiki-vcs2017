using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg199
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void onTask1()
        {
            for (int i = 0; i < 10; i++)
            {
                this.Invoke(new Action(() =>
                {
                    label1.Text = string.Format("{0}秒経過", i);
                }));
                System.Threading.Thread.Sleep(1000);
            }
        }
        void onTask2()
        {
            for (int i = 0; i < 10; i++)
            {
                this.Invoke(new Action(() =>
                {
                    label2.Text = string.Format("{0}秒経過", i);
                }));
                System.Threading.Thread.Sleep(1000);
            }
        }
        // タスクの完了を待つ
        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() => onTask1());
            await Task.Run(() => onTask2());
        }

        // タスクの完了を待たない
        private void button2_Click(object sender, EventArgs e)
        {
            Task.Run(() => onTask1());
            Task.Run(() => onTask2());
        }
    }
}
