using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db286
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dt = (DataTable)this.dataGridView1.DataSource;  //データソース取得

            //編集された行をコミットする
            foreach (DataRow dRow in dt.Rows)
            {
                if (dRow.RowState != DataRowState.Unchanged)
                {
                    dRow.AcceptChanges();
                }
            }
            //確認のため、行の状態を出力する
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                System.Diagnostics.Debug.WriteLine($"{i}行目：{dt.Rows[i].RowState}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var cn = new System.Data.OleDb.OleDbConnection(
                        "Provider=Microsoft.ACE.OLEDB.12.0;"
                        + "Data Source=C:\\C#2017\\SampleDB.accdb;");

            //データセットに取得してデータを表示する
            var ad = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM 商品", cn);
            var dt = new DataTable();
            ad.Fill(dt);
            this.dataGridView1.DataSource = dt;
        }
    }
}
