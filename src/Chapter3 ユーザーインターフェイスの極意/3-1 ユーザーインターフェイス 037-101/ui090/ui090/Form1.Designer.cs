namespace ui090
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("新宿営業所");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("青山営業所");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("東京本社", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("大阪支社");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("福岡支社");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode16.Name = "ノード3";
            treeNode16.Text = "新宿営業所";
            treeNode17.Name = "ノード4";
            treeNode17.Text = "青山営業所";
            treeNode18.Name = "ノード0";
            treeNode18.Text = "東京本社";
            treeNode19.Name = "ノード1";
            treeNode19.Text = "大阪支社";
            treeNode20.Name = "ノード2";
            treeNode20.Text = "福岡支社";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20});
            this.treeView1.Size = new System.Drawing.Size(123, 171);
            this.treeView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "選択ノードの取得";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(145, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 30);
            this.label1.TabIndex = 2;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "ノードの追加";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 19);
            this.textBox1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(145, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 30);
            this.button3.TabIndex = 5;
            this.button3.Text = "選択ノードの削除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 204);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
    }
}

