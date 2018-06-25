using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db284
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] row1 = { "001", "ライオン" };
            string[] row2 = { "002", "トラ" };
            string[] row3 = { "003", "ヒョウ" };

            dataGridView1.Columns.Clear();          //列を削除
                                                    //列を追加する
            dataGridView1.Columns.Add("No", "No.");
            dataGridView1.Columns.Add("Name", "名前");
            //行を追加する
            dataGridView1.Rows.Add(row1);
            dataGridView1.Rows.Add(row2);
            dataGridView1.Rows.Add(row3);
        }
    }
}
