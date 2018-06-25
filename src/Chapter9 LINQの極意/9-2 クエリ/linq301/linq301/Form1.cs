using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linq301
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
            var item = new 商品()
            {
                Id = 10,
                商品名 = "追加した商品",
                分類 = "食品",
                単価 = 999,
                数量 = 100
            };
            // テーブルに追加する
            ent.商品.Add(item);
            // データベースに反映する
            ent.SaveChanges();
            // 結果を表示する
            var q = from t in ent.商品
                    select t;
            dataGridView1.DataSource = q.ToList();
        }
    }
}
