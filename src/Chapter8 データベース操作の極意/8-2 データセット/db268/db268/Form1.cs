using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db268
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

            //DataTableオブジェクトに取得する
            var ad = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM 社員", cn);
            var dt = new DataTable();
            ad.Fill(dt);
            //すべてのレコードのすべてのフィールドの値を出力する
            foreach (DataRow dRow in dt.Rows)
            {
                this.listBox1.Items.Add(string.Join(" ", dRow.ItemArray));
            }
        }
    }
}
