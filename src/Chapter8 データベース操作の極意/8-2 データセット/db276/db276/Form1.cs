using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db276
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cn = new System.Data.OleDb.OleDbConnection(
                        "Provider=Microsoft.ACE.OLEDB.12.0;"
                        + "Data Source=C:\\C#2017\\SampleDB.accdb;");

            //データセットに取得する
            var ad = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM 社員", cn);
            var dt = new DataTable();
            ad.Fill(dt);
            //コマンドビルダの作成
            var builder = new System.Data.OleDb.OleDbCommandBuilder(ad);
            //テーブルデータを更新し、データベースに反映する
            dt.Rows[0]["氏名"] = "クラリス";          //氏名フィールド変更
            ad.Update(dt);                          //データベースに反映
            MessageBox.Show("社員テーブルを更新しました。", "通知");
        }
    }
}
