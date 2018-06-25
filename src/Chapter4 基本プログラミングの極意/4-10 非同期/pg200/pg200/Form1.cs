using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg200
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void onTask1()
        {
            for (int i = 0; i < 5; i++)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                this.Invoke(new Action(() => { label3.Text = "タスク開始"; }));
                var task1 = Task.Factory.StartNew(() => onTask1());
                var task2 = Task.Factory.StartNew(() => onTask2());
                // 複数のタスクの完了を待つ
                Task.WaitAll(task1, task2);
                this.Invoke(new Action(() => { label3.Text = "タスク終了"; }));
            });
        }
    }
}
