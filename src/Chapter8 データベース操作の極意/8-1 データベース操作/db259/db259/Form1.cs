using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db259
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

            //テストテーブルを削除する
            try
            {
                cn.Open();
                var cmd = new System.Data.OleDb.OleDbCommand("DROP TABLE テスト", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("削除しました。", "通知");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "通知");
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
