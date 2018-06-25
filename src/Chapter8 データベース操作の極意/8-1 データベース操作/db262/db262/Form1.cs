using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db262
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

            //社員番号が100091のレコードを削除する
            cn.Open();
            var cmd = new System.Data.OleDb.OleDbCommand(
                            "DELETE FROM 社員 WHERE 社員番号=100091", cn);
            try
            {
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
