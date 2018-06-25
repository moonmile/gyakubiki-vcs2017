using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg203
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 10;

            await Task.Factory.StartNew(() =>
            {
                for (int i = 1; i <= 10; i++)
                {
                    this.Invoke(new Action(() =>
                    {
                        label1.Text = $"{i}秒経過";
                    }));
                    this.Invoke(new Action(() =>
                    {
                        progressBar1.Value = i;
                    }));
                    System.Threading.Thread.Sleep(1000);
                }
            });
            MessageBox.Show("10秒経過しました");
        }
    }
}
