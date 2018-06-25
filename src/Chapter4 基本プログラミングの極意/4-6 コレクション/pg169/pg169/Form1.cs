using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg169
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lst = new List<string>();

            //lstに要素を追加する。
            lst.AddRange(new string[] { "味噌", "醤油", "味醂" });
            //lstの各要素の値を表示する。
            label1.Text = "";
            for (int i = 0; i < lst.Count; i++)
            {
                label1.Text += $"{lst[i]}\n";
            }
        }
    }
}
