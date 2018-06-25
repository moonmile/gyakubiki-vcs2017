using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace debug344
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tLis = new TextWriterTraceListener(@"C:\C#2017\DebugAuto.txt");
            Debug.Listeners.Add(tLis); // 出力先を追加する
            Debug.AutoFlush = true;  // 自動的に出力する
            for (int i = 0; i < 10; i++)
            {
                Debug.WriteLine($"{i}回目");

            }
            MessageBox.Show("ファイルに出力しました。", "通知");
        }
    }
}
