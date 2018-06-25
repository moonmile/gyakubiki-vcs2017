using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db256
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
            //データベースに接続してテーブル名を取得する
            cn.Open();
            var dt = cn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables
                            , new object[] { null, null, null, "TABLE" });
            cn.Close();

            //テーブル名をリストボックスに表示する
            listBox1.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr[2]);   //3番目のフィールドを表示
            }
        }
    }
}
