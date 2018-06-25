using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db273
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

            //データテーブルに取得し、テーブルの最初のフィールドの型を表示する
            var ad = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM 社員", cn);
            var dt = new DataTable();
            ad.Fill(dt);
            var name = dt.Columns[0].DataType.ToString();
            MessageBox.Show($"フィールドの型名：{name}", "通知");
        }
    }
}
