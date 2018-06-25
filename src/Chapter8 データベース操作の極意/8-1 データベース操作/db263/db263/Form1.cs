using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db263
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

            //SQL文を作成して実行する
            cn.Open();
            var cmd = new System.Data.OleDb.OleDbCommand("SELECT * FROM 社員", cn);
            var dr = cmd.ExecuteReader();

            //1番目と2番目のフィールドをリストボックスに出力する
            listBox1.Items.Clear();
            while (dr.Read())
            {
                listBox1.Items.Add($"{dr.GetInt32(0)}：{dr.GetString(1)}");
            }
            dr.Close();
            cn.Close();
        }
    }
}
