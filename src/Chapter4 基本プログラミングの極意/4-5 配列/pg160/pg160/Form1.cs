﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg160
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] nameAry = { "荒俣", "夢野", "沼", "柄谷", "上野" };
            int i;

            if (comboBox1.SelectedIndex == -1)  //選択されていないとき
            {
                label1.Text = "クラスを選択してください。";
                return;
            }
            i = comboBox1.SelectedIndex;        //インデックスを取得
            label1.Text = comboBox1.SelectedItem
                                + "組の担任：" + nameAry[i] + "先生";

        }
    }
}
