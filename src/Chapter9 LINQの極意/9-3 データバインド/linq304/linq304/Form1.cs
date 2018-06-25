using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linq304
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
            // リストボックスにフォーマットを設定
            listBox1.FormattingEnabled = true;
            listBox1.Format += (_s, _e) => {
                var it = _e.Value as 商品;
                _e.Value = $"{it.商品名} {it.単価}円";
            };
            // 結果を表示する
            listBox1.DataSource = q.ToList();
        }
    }
}
