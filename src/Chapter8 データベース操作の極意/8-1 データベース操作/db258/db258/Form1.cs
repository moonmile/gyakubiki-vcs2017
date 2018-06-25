using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db258
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

            //［テスト］テーブルを作成する
            cn.Open();
            try
            {
                var cmd = new System.Data.OleDb.OleDbCommand(
                        "CREATE TABLE テスト(コード INT, 商品名 TEXT)", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("テーブルを作成しました。", "通知");
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
