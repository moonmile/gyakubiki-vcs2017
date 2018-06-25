using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linq305
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ent = new Database1Entities();
            // LINQで検索する
            var q = from t in ent.商品
                    select t;
            // 列を自動では作成しない
            dataGridView1.AutoGenerateColumns = false;
            // 結果を表示する
            dataGridView1.DataSource = q.ToList();
        }
    }
}
