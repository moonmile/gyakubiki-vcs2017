using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg173
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lst = new SortedList<string, string>();

            //コレクションに要素を追加する
            lst["vc"] = "Visual C#";
            lst["pp"] = "PowerPoint";
            lst.Add("wd", "Word");
            lst.Add("ac", "Access");

            //lstの要素を順に表示する
            listBox1.Items.Clear();
            for (int i = 0; i < lst.Count; i++)
            {
                listBox1.Items.Add($"{i} ： {lst.Keys[i]} ： {lst.Values[i]}");
            }
            //lstに要素を追加後、要素を順に表示する
            lst.Add("ex", "Excel");           //要素を追加
            listBox2.Items.Clear();
            for (int i = 0; i < lst.Count; i++)
            {
                listBox2.Items.Add($"{i} ： {lst.Keys[i]} ： {lst.Values[i]}");
            }
        }
    }
}
