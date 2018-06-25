using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db288
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
                        + "Data Source=C:\\C#2018\\SampleDB.accdb;");

            //DBに接続してトランザクションを開始する
            cn.Open();
            var cmd = cn.CreateCommand();
            var tr = cn.BeginTransaction();

            //トランザクションを適用し、レコードを追加する
            cmd.Connection = cn;
            cmd.Transaction = tr;
            cmd.CommandText =
                "INSERT INTO 社員 VALUES(100101, '井ノ上真央', 'B-001')";
            cmd.ExecuteNonQuery();            //レコードを追加

            //トランザクションを確定して接続を閉じる
            tr.Commit();
            MessageBox.Show("処理を終了しました。", "通知");
            cn.Close();
        }
    }
}
