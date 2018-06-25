using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linq297
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            var ent = new Database1Entities();
            // LINQで検索する
            var q = (
                    from t in ent.商品
                    orderby t.Id
                    select t
                ).Skip(n).Take(1);
            // 結果を表示する
            dataGridView1.DataSource = q.ToList();
        }
    }
}
