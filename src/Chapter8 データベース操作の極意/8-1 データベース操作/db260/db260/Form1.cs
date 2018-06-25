using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db260
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

            //社員番号100091のレコードを追加する（既にある場合はエラー表示）
            cn.Open();
            try
            {
                var cmd = new System.Data.OleDb.OleDbCommand(
                        "INSERT INTO 社員 VALUES(100091, '百田かなこ', 'C-001')", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("追加しました。", "通知");
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
