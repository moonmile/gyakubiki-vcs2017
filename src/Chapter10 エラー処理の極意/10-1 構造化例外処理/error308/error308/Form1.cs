using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace error308
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            try
            {
                a = int.Parse("間違った値");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("引数が無効です", "エラー発生");
            }
            catch (Exception ex)
            {
                MessageBox.Show("予期しないエラーが発生しました", "エラー発生");
            }
        }
    }
}
