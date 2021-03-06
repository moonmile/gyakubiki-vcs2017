﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg170
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lst = new List<string>
                {"ティラノサウルス", "アパトサウルス"
                , "マイアサウラ", "プテラノドン", "ブラキオサウルス"};

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox1.Items.AddRange(lst.ToArray());     //ソート前
            lst.Sort();                                 //昇順でソート
            listBox2.Items.AddRange(lst.ToArray());
            lst.Reverse();                              //逆順でソート
            listBox3.Items.AddRange(lst.ToArray());
        }
    }
}
