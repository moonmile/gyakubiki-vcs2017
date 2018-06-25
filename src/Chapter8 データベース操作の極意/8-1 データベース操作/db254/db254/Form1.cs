using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace db254
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

            //接続文字列を設定して接続する
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
                            + "Data Source=C:\\C#2017\\SampleDB.accdb;";
            try
            {
                cn.Open();
                MessageBox.Show("接続しました。", "通知");
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "通知");
            }
        }
    }
}
