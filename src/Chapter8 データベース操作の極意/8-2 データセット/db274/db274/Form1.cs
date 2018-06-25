using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db274
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

            //データテーブルに取得し、テーブルから3行目のレコードを取得する
            var ad = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM 商品", cn);
            var dt = new DataTable();
            ad.Fill(dt);
            var row = dt.Rows[2];
            MessageBox.Show(row[0] + "\t" + row[1], "通知");
        }
    }
}
