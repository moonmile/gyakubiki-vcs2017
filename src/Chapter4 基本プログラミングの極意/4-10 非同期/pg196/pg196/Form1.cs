using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg196
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Task _task;
        /// <summary>
        /// タスクを作成する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // ラムダ式を使う場合
            _task = new Task(() =>
            {
                for (int i = 0; i < 60; i++)
                {
                    this.Invoke(new Action(() =>
                    {
                        label1.Text = DateTime.Now.ToString("HH:MM:ss");
                    }));
                    System.Threading.Thread.Sleep(1000);
                }
            });
            _task.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // メソッドを使う場合
            _task = new Task(OnWork);
            _task.Start();
        }
        // バックグラウンドプロセス
        void OnWork()
        {
            for (int i = 0; i < 60; i++)
            {
                this.Invoke(new Action(() =>
                {
                    label1.Text = DateTime.Now.ToString("HH:MM:ss");
                }));
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
