using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db282
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

            var ad = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM 商品", cn);
            var dt = new DataTable();
            ad.Fill(dt);
            //DataGridViewの最初の列を読み取り専用にしてデータを表示
            this.dataGridView1.DataSource = dt;
            this.dataGridView1.Columns[0].ReadOnly = true;
        }
    }
}
