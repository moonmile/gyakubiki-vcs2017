using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db272
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ds = new DataSet("t_商品");
            var cn = new System.Data.OleDb.OleDbConnection(
                        "Provider=Microsoft.ACE.OLEDB.12.0;"
                        + "Data Source=C:\\C#2017\\SampleDB.accdb;");

            //データセットに取得する
            var ad = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM 商品", cn);
            ad.Fill(ds, "t_商品");
            //データセットのレコードを並べ替えて表示する
            var view = new DataView(ds.Tables["t_商品"], ""
                , "定価 ASC", DataViewRowState.CurrentRows);
            listBox1.Items.Clear();
            for (int i = 0; i < view.Count - 1; i++)
            {
                var s = "";
                for (int j = 0; j < view.Table.Columns.Count - 1; j++)
                {
                    s += view[i][j] + " ";
                }
                listBox1.Items.Add(s);
            }
        }
    }
}
