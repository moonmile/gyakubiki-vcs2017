using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg202
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 非同期処理
        Task<int> onWork()
        {
            var task = new Task<int>(() =>
            {
                // 合計値を1秒ごとに計算する
                int sum = 0;
                for (int i = 1; i <= 10; i++)
                {
                    this.Invoke(new Action(() =>
                    {
                        label1.Text = $"{i}秒経過";
                    }));
                    sum += i;
                    System.Threading.Thread.Sleep(1000);
                }
                return sum;
            });
            task.Start();
            task.ContinueWith((t) =>
            {
                int res = t.Result;
                this.Invoke(new Action(() =>
                {
                    label2.Text = $"合計値 {res}";
                }));
            });


            return task;
        }

        // 非同期処理を呼び出す
        private async void button1_Click(object sender, EventArgs e)
        {
            await onWork();
        }
    }
}
