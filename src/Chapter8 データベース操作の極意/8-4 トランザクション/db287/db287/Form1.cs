using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db287
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

            //DBに接続してトランザクションを開始する
            cn.Open();
            var tr = cn.BeginTransaction();
            MessageBox.Show("トランザクションを開始しました。", "通知");
            //トランザクションを終了して接続を閉じる
            tr.Commit();
            MessageBox.Show("トランザクションを終了しました。", "通知");
            cn.Close();
        }
    }
}
