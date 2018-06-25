using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linq302
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

            // 削除対象のレコードを検索する
            var q = from t in ent.商品 where t.Id == 2 select t;
            if (q.Count() > 0)
            {
                // テーブルから削除する
                ent.商品.Remove(q.First());
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
