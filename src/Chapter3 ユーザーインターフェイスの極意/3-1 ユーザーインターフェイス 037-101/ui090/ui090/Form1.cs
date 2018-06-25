using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui090
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ノードのフルパス
            label1.Text = treeView1.SelectedNode.FullPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TreeNode selectNode = treeView1.SelectedNode;
            if (textBox1.Text == "")
            {
                return;
            }
            if (selectNode == null)
            {
                MessageBox.Show("追加場所を選択してください", "通知");
                return;
            }
            //ノードの追加
            selectNode.Nodes.Add(new TreeNode(textBox1.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TreeNode selectNode = treeView1.SelectedNode;
            if (selectNode == null)
            {
                MessageBox.Show("削除項目を選択してください", "通知");
                return;
            }
            if (selectNode.Parent == null)
            {
                MessageBox.Show("親ノードは削除できません", "通知");
                return;
            }
            else
            {
                //ノードの削除
                selectNode.Remove();
            }

        }
    }
}
