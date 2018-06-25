using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg168
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var hash = new System.Collections.Hashtable();

            //コレクションに要素を追加する
            hash["ex"] = "Excel";
            hash["pp"] = "PowerPoint";
            hash.Add("wd", "Word");
            hash.Add("ac", "Access");

            //キーから値を取得し、文字列に変換して表示
            label1.Text = hash["pp"].ToString();

            //キーと値をそれぞれ取得し、リストボックスに表示
            listBox1.Items.Clear();
            foreach (string key in hash.Keys)
            {
                listBox1.Items.Add(key);
            }
            listBox2.Items.Clear();
            foreach (string val in hash.Values)
            {
                listBox2.Items.Add(val);
            }

            //キーと値をセットで取得し、リストボックスに表示
            listBox3.Items.Clear();
            foreach (System.Collections.DictionaryEntry h in hash)
            {
                listBox3.Items.Add($"{h.Key}\t{h.Value}");
            }
        }
    }
}
