using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace linq292
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // XMLファイルを読み込む
            var persons = XElement.Load(@"c:\C#2017\persons.xml");
            // クエリを実行
            var q = from p in persons.Descendants("person")
                    where p.Element("name").Value.StartsWith("masuda")
                    select p;

            // クエリ結果を表示
            listBox1.Items.Clear();
            foreach (XElement el in q)
            {
                listBox1.Items.Add(el.Element("name").Value);
            }
        }
    }
}
