using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg172
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dic = new Dictionary<string, string>();

            //要素を追加する
            dic["ex"] = "Excel";
            dic["pp"] = "PowerPoint";
            dic.Add("wd", "Word");
            dic.Add("ac", "Access");

            //キーから値を取得して表示する
            label1.Text = dic["wd"];
            //キーと値をそれぞれ取得し、リストボックスに表示
            listBox1.Items.Clear();
            foreach (string myKey in dic.Keys)
            {
                listBox1.Items.Add(myKey);
            }
            listBox2.Items.Clear();
            foreach (string myVal in dic.Values)
            {
                listBox2.Items.Add(myVal);
            }
            //キーと値をセットで取得し、リストボックスに表示
            listBox3.Items.Clear();
            foreach (var myPair in dic)
            {
                listBox3.Items.Add($"{myPair.Key}\t{myPair.Value}");
            }
        }
    }
}
