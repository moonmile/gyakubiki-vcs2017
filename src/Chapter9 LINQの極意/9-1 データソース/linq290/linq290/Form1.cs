using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linq290
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // コントロールを取得
            var lst = new List<Control>();
            foreach (Control c in this.Controls)
            {
                lst.Add(c);
            }
            // ボタンコントロールのみ取得
            var q = from c in lst
                    where c is Button
                    select c.Name;
            // リストボックスに表示する
            listBox1.Items.Clear();
            listBox1.Items.AddRange(q.ToArray());
        }
    }
}
