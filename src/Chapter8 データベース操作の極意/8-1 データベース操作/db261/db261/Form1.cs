using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db261
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

            //社員番号100091のレコードを変更する
            cn.Open();
            try
            {
                var cmd = new System.Data.OleDb.OleDbCommand(
                    "UPDATE 社員 SET 氏名='高城かなこ' WHERE 社員番号=100091", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("変更しました。", "通知");
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
