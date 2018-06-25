using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linq293
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // データベースに接続
            var ad = new DataSet1TableAdapters.商品TableAdapter();
            var ta = ad.GetData();
            // 商品名を検索
            var q = from t in ta select t.商品名;
            listBox1.DataSource = q.ToList();
        }
    }
}
