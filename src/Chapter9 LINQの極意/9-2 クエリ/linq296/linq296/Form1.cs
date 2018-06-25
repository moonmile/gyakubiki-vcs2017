using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linq296
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 昇順で検索
        private void button1_Click(object sender, EventArgs e)
        {
            var ent = new Database1Entities();
            // LINQで検索する
            var q = from t in ent.商品
                    orderby t.単価
                    select t;
            // 結果を表示する
            dataGridView1.DataSource = q.ToList();
        }
        // 降順で検索
        private void button2_Click(object sender, EventArgs e)
        {
            var ent = new Database1Entities();
            // LINQで検索する
            var q = from t in ent.商品
                    orderby t.単価 descending
                    select t;
            // 結果を表示する
            dataGridView1.DataSource = q.ToList();
        }
    }
}
