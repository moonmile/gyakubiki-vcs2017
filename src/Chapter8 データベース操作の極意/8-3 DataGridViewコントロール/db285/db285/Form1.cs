using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db285
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var cn = new System.Data.OleDb.OleDbConnection(
                        "Provider=Microsoft.ACE.OLEDB.12.0;"
                        + "Data Source=C:\\C#2017\\SampleDB.accdb;");

            //データセットに取得してDataGridViewに表示する
            var ad = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM 商品", cn);
            var dt = new DataTable();
            ad.Fill(dt);
            this.dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DataGridViewからデータソースを取得する
            var dt = (DataTable)this.dataGridView1.DataSource;
            //行の編集状態をイミディエイトウィンドウに出力する
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                System.Diagnostics.Debug.WriteLine($"{i}\t{dt.Rows[i].RowState}");
            }
        }
    }
}
