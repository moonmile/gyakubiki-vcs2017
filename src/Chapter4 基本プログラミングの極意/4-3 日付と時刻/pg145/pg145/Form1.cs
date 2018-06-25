using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg145
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dt = DateTime.Today;   //今日の日付を取得

            switch (dt.DayOfWeek)           //曜日を取得
            {
                case DayOfWeek.Sunday:
                    label1.Text = "日曜日";
                    break;
                case DayOfWeek.Monday:
                    label1.Text = "月曜日";
                    break;
                case DayOfWeek.Tuesday:
                    label1.Text = "火曜日";
                    break;
                case DayOfWeek.Wednesday:
                    label1.Text = "水曜日";
                    break;
                case DayOfWeek.Thursday:
                    label1.Text = "木曜日";
                    break;
                case DayOfWeek.Friday:
                    label1.Text = "金曜日";
                    break;
                case DayOfWeek.Saturday:
                    label1.Text = "土曜日";
                    break;
            }
        }
    }
}
