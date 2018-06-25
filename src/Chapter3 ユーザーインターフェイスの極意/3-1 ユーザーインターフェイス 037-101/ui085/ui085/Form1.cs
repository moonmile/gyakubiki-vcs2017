using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui085
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 中央揃えToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox myobj = (TextBox)contextMenuStrip1.SourceControl;
            myobj.TextAlign = HorizontalAlignment.Center;
        }

        private void 左揃えToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox myobj = (TextBox)contextMenuStrip1.SourceControl;
            myobj.TextAlign = HorizontalAlignment.Left;
        }

        private void 右揃えToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox myobj = (TextBox)contextMenuStrip1.SourceControl;
            myobj.TextAlign = HorizontalAlignment.Right;
        }
    }
}
