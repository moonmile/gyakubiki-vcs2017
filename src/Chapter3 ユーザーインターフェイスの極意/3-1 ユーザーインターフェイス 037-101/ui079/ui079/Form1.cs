using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui079
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.MaxSelectionCount = 15;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startDay;
            DateTime endDay;
            startDay = monthCalendar1.SelectionStart;
            endDay = monthCalendar1.SelectionEnd;
            int myDays = endDay.Subtract(startDay).Days + 1;

            label4.Text = startDay.ToLongDateString();
            label5.Text = endDay.ToLongDateString();
            label6.Text = myDays.ToString();
        }
    }
}
