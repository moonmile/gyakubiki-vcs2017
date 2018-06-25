using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db277
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet("生物");
            //データセットに新規テーブルを追加する
            var dt = ds.Tables.Add("恐竜");
            //追加したテーブルにフィールドを設定する
            dt.Columns.Add("ID", typeof(System.Int32));
            dt.Columns.Add("名前", typeof(System.String));
            MessageBox.Show($"データセットに[{ds.Tables[0].TableName}]テーブルを追加しました。", "通知");
        }
    }
}
