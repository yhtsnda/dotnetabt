namespace AUI
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

       
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxTest = new System.Windows.Forms.TextBox();
            this.textBoxPathproject = new System.Windows.Forms.TextBox();
            this.buttonNextline = new System.Windows.Forms.Button();
            this.textBoxlinkopenline = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCurentPath = new System.Windows.Forms.Label();
            this.groupBoxmain = new System.Windows.Forms.GroupBox();
            this.treeView = new AUI.DirectoryTreeview();
            this.tabControlViewData = new AUI.DirectoryTabcontrol();
            this.treeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxmain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.testToolStripMenuItem,
            this.treeViewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(961, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getLineToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // getLineToolStripMenuItem
            // 
            this.getLineToolStripMenuItem.Name = "getLineToolStripMenuItem";
            this.getLineToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.getLineToolStripMenuItem.Text = "GetLine";
            this.getLineToolStripMenuItem.Click += new System.EventHandler(this.getLineToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeView);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 290);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControlViewData);
            this.groupBox2.Location = new System.Drawing.Point(221, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 290);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // textBoxTest
            // 
            this.textBoxTest.Location = new System.Drawing.Point(125, 58);
            this.textBoxTest.Name = "textBoxTest";
            this.textBoxTest.Size = new System.Drawing.Size(282, 20);
            this.textBoxTest.TabIndex = 6;
            // 
            // textBoxPathproject
            // 
            this.textBoxPathproject.Location = new System.Drawing.Point(125, 19);
            this.textBoxPathproject.Name = "textBoxPathproject";
            this.textBoxPathproject.Size = new System.Drawing.Size(349, 20);
            this.textBoxPathproject.TabIndex = 7;
            // 
            // buttonNextline
            // 
            this.buttonNextline.Location = new System.Drawing.Point(413, 55);
            this.buttonNextline.Name = "buttonNextline";
            this.buttonNextline.Size = new System.Drawing.Size(61, 23);
            this.buttonNextline.TabIndex = 9;
            this.buttonNextline.Text = "Next Line";
            this.buttonNextline.UseVisualStyleBackColor = true;
            this.buttonNextline.Click += new System.EventHandler(this.buttonNextline_Click);
            // 
            // textBoxlinkopenline
            // 
            this.textBoxlinkopenline.Location = new System.Drawing.Point(125, 90);
            this.textBoxlinkopenline.Name = "textBoxlinkopenline";
            this.textBoxlinkopenline.Size = new System.Drawing.Size(349, 20);
            this.textBoxlinkopenline.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelCurentPath);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBoxTest);
            this.groupBox3.Controls.Add(this.buttonNextline);
            this.groupBox3.Controls.Add(this.textBoxPathproject);
            this.groupBox3.Controls.Add(this.textBoxlinkopenline);
            this.groupBox3.Location = new System.Drawing.Point(12, 385);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 129);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Option";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Đường Dẫn Project: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Dữ Liệu Dòng: ";
            // 
            // labelCurentPath
            // 
            this.labelCurentPath.AutoSize = true;
            this.labelCurentPath.Location = new System.Drawing.Point(10, 94);
            this.labelCurentPath.Name = "labelCurentPath";
            this.labelCurentPath.Size = new System.Drawing.Size(114, 13);
            this.labelCurentPath.TabIndex = 13;
            this.labelCurentPath.Text = "Đường Dẫn Đang Đọc";
            // 
            // groupBoxmain
            // 
            this.groupBoxmain.Controls.Add(this.groupBox1);
            this.groupBoxmain.Controls.Add(this.groupBox2);
            this.groupBoxmain.Location = new System.Drawing.Point(12, 67);
            this.groupBoxmain.Name = "groupBoxmain";
            this.groupBoxmain.Size = new System.Drawing.Size(937, 312);
            this.groupBoxmain.TabIndex = 12;
            this.groupBoxmain.TabStop = false;
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(7, 16);
            this.treeView.Name = "treeView";
            this.treeView.PathTree = ".\\";
            this.treeView.Size = new System.Drawing.Size(191, 268);
            this.treeView.TabIndex = 3;
            // 
            // tabControlViewData
            // 
            this.tabControlViewData.Dir = null;
            this.tabControlViewData.Location = new System.Drawing.Point(6, 16);
            this.tabControlViewData.Name = "tabControlViewData";
            this.tabControlViewData.SelectedIndex = 0;
            this.tabControlViewData.Size = new System.Drawing.Size(694, 268);
            this.tabControlViewData.TabIndex = 0;
            // 
            // treeViewToolStripMenuItem
            // 
            this.treeViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.treeViewToolStripMenuItem.Name = "treeViewToolStripMenuItem";
            this.treeViewToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.treeViewToolStripMenuItem.Text = "Tree View";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 654);
            this.Controls.Add(this.groupBoxmain);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUI";
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxmain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Khai Bao Bien

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public AUI.DirectoryTreeview treeView;        
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxTest;
        public DirectoryTabcontrol tabControlViewData;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxPathproject;
        private System.Windows.Forms.Button buttonNextline;
        private System.Windows.Forms.TextBox textBoxlinkopenline;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCurentPath;
        private System.Windows.Forms.GroupBox groupBoxmain;
        private System.Windows.Forms.ToolStripMenuItem treeViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
      
    }
}

