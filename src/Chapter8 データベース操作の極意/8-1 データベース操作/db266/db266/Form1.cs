using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db266
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

            //DBに接続してレコードを取得し、フィールド名を出力する
            cn.Open();
            var cmd = new System.Data.OleDb.OleDbCommand("SELECT * FROM 社員", cn);
            var dr = cmd.ExecuteReader();
            listBox1.Items.Clear();
            for (int i = 0; i < dr.FieldCount; i++)
            {
                listBox1.Items.Add(i + 1 + "番目のフィールド：" + dr.GetName(i));
            }
            dr.Close();
            cn.Close();
        }
    }
}
