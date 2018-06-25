using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace error324
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cn = new OleDbConnection();
            // 間違った接続文字列を作成する
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                @"Data Source=C:\C#2017\zyxDB.accdb;";
            try
            {
                cn.Open();
                MessageBox.Show("接続しました。", "通知");
                cn.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "エラー発生");
            }
        }
    }
}
