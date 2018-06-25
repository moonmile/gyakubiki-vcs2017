using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linq303
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
            // 更新対象のレコードを検索する
            var q = from t in ent.商品 where t.Id == 2 select t;
            if (q.Count() > 0)
            {
                // データを更新する
                q.First().商品名 = "商品名を更新";
            }
            // データベースに反映する
            ent.SaveChanges();
            // 結果を表示する
            q = from t in ent.商品
                select t;
            dataGridView1.DataSource = q.ToList();
        }
    }
}
