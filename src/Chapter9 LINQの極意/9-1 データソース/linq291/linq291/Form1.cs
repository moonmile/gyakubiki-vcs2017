using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linq291
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // データソース
            string[] persons = {
                "masuda tomoaki", "masuda yumi", "masuda kaho",
                "shinohara hayato", "shinohara shouta"};

            /// クエリを実行
            var q = from p in persons
                    where p.StartsWith("masuda")
                    select p;

            // クエリ結果を表示
            listBox1.Items.Clear();
            listBox1.Items.AddRange(q.ToArray());
        }
    }
}
