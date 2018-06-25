using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg147
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime sTime;     //開始時刻
        DateTime eTime;     //終了時刻

        private void button1_Click(object sender, EventArgs e)
        {
            sTime = DateTime.Now;       //開始時の時刻を取得
            label1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eTime = DateTime.Now;       //終了時の時刻を取得
            var ts = eTime.Subtract(sTime); //時刻の差分を求める
            if (ts.Seconds == 10)       //10秒台のとき
            {
                label1.Text = "Congraturations!  "
                    + ts.TotalSeconds.ToString("##.##") + "秒です。";
            }
            else
            {
                label1.Text = "残念！　"
                    + ts.TotalSeconds.ToString("##.##") + "秒でした。";
            }
        }
    }
}
