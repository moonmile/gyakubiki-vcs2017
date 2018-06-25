using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db289
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

            //DBに接続してトランザクションを開始、適用する
            cn.Open();
            var cmd = new System.Data.OleDb.OleDbCommand(
                    "INSERT INTO 社員 VALUES(100101, '井ノ上真央', 'B-001')", cn);
            var tr = cn.BeginTransaction();     //トランザクションを開始
            cmd.Transaction = tr;               //トランザクションを適用

            //DBを更新し、トランザクションを確定または中止する
            try
            {
                cmd.ExecuteNonQuery();
                tr.Commit();
                MessageBox.Show("終了しました。", "通知");
            }
            catch (Exception ex)
            {
                tr.Rollback();
                MessageBox.Show(ex.Message, "エラー");
                MessageBox.Show("ロールバックしました。", "通知");
            }
            cn.Close();
        }
    }
}
