using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db271
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

            //データテーブルに取得する
            var ad = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM 商品", cn);
            var dt = new DataTable();
            ad.Fill(dt);

            //データセットからデータを抽出して表示する
            var view = new DataView(dt, "定価>=330", "", DataViewRowState.CurrentRows);
            listBox1.Items.Clear();
            for (int i = 0; i < view.Count; i++)
            {
                var s = "";
                for (int j = 0; j < view.Table.Columns.Count; j++)
                {
                    s += view[i][j] + " ";
                }
                listBox1.Items.Add(s);
            }
        }
    }
}
