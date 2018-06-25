using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg171
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lst = new List<string> { "東京", "品川", "新横浜" };
            //リストボックスの項目をlstに追加する
            foreach (object val in listBox1.Items)
            {
                lst.Add($"{val}");
            }
            //テキストボックスの文字列をlstから検索して結果を表示する
            int ret = lst.IndexOf(textBox1.Text);
            if (ret == -1)
            {
                label1.Text = "コレクション内に存在しません。";
            }
            else
            {
                label1.Text = textBox1.Text + $"のインデックス： {ret}";
            }
        }
    }
}
