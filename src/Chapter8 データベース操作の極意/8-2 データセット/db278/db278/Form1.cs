using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db278
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ds = new DataSet("生物");
            object[] colData = { 2, "ブラキオサウルス" };

            //データセットに新規テーブルを追加し、フィールドを設定する
            var dt = ds.Tables.Add("恐竜");
            dt.Columns.Add("ID", typeof(System.Int32));
            dt.Columns.Add("名前", typeof(System.String));

            //作成したテーブルに新しいレコードを追加する
            var row = dt.NewRow();
            row["ID"] = 1;
            row["名前"] = "ティラノサウルス";
            dt.Rows.Add(row);       //DataRowオブジェクトとして追加
            dt.Rows.Add(colData);   //object型の配列として追加

            //最初のレコードを表示する
            MessageBox.Show("追加したレコード：  "
                        + ds.Tables[0].Rows[0][0] + "  "
                        + ds.Tables[0].Rows[0][1], "結果通知");
        }
    }
}
