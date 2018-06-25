using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db267
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ds = new DataSet("t_社員");
            var cn = new System.Data.OleDb.OleDbConnection(
                        "Provider=Microsoft.ACE.OLEDB.12.0;"
                        + "Data Source=C:\\C#2017\\SampleDB.accdb;");

            //データセットに取得する
            var ad = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM 社員", cn);
            ad.Fill(ds, "t_社員");
            MessageBox.Show("データセットに取得しました。", "通知");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dt = new DataTable();
            var cn = new System.Data.OleDb.OleDbConnection(
                        "Provider=Microsoft.ACE.OLEDB.12.0;"
                        + "Data Source=C:\\C#2017\\SampleDB.accdb;");

            //データセットに取得する
            var ad = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM 社員", cn);
            ad.Fill(dt);
            MessageBox.Show("データテーブルに取得しました。", "通知");
        }
    }
}
