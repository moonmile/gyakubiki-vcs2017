using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db255
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

            try
            {
                cn.Open();         //接続する
                MessageBox.Show($"接続状態　：　{cn.State}", "通知");
                cn.Close();        //切断する
                MessageBox.Show($"接続状態　：　{cn.State}", "通知");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "通知");
            }
        }
    }
}
