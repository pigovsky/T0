namespace Filedublicates.NET
{
    partial class Form1
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchFilesWithSameLengthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadInfoAboutFilesWithSameLengthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadInfoAboutFilesWithSameLengthToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportInfoAboutFilesWithSameLengthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findDuplicatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byteByByteComparsionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hashingByteByByteComparsionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.findDuplicatesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchFilesWithSameLengthToolStripMenuItem,
            this.loadInfoAboutFilesWithSameLengthToolStripMenuItem,
            this.loadInfoAboutFilesWithSameLengthToolStripMenuItem1,
            this.exportInfoAboutFilesWithSameLengthToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // searchFilesWithSameLengthToolStripMenuItem
            // 
            this.searchFilesWithSameLengthToolStripMenuItem.Name = "searchFilesWithSameLengthToolStripMenuItem";
            this.searchFilesWithSameLengthToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.searchFilesWithSameLengthToolStripMenuItem.Text = "Search files with same length";
            this.searchFilesWithSameLengthToolStripMenuItem.Click += new System.EventHandler(this.searchFilesWithSameLengthToolStripMenuItem_Click);
            // 
            // loadInfoAboutFilesWithSameLengthToolStripMenuItem
            // 
            this.loadInfoAboutFilesWithSameLengthToolStripMenuItem.Name = "loadInfoAboutFilesWithSameLengthToolStripMenuItem";
            this.loadInfoAboutFilesWithSameLengthToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.loadInfoAboutFilesWithSameLengthToolStripMenuItem.Text = "Save info about files with same length";
            this.loadInfoAboutFilesWithSameLengthToolStripMenuItem.Click += new System.EventHandler(this.saveInfoAboutFilesWithSameLengthToolStripMenuItem_Click);
            // 
            // loadInfoAboutFilesWithSameLengthToolStripMenuItem1
            // 
            this.loadInfoAboutFilesWithSameLengthToolStripMenuItem1.Name = "loadInfoAboutFilesWithSameLengthToolStripMenuItem1";
            this.loadInfoAboutFilesWithSameLengthToolStripMenuItem1.Size = new System.Drawing.Size(292, 22);
            this.loadInfoAboutFilesWithSameLengthToolStripMenuItem1.Text = "Load info about files with same length";
            this.loadInfoAboutFilesWithSameLengthToolStripMenuItem1.Click += new System.EventHandler(this.loadInfoAboutFilesWithSameLengthToolStripMenuItem1_Click);
            // 
            // exportInfoAboutFilesWithSameLengthToolStripMenuItem
            // 
            this.exportInfoAboutFilesWithSameLengthToolStripMenuItem.Name = "exportInfoAboutFilesWithSameLengthToolStripMenuItem";
            this.exportInfoAboutFilesWithSameLengthToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.exportInfoAboutFilesWithSameLengthToolStripMenuItem.Text = "Export info about files with same length...";
            this.exportInfoAboutFilesWithSameLengthToolStripMenuItem.Click += new System.EventHandler(this.exportInfoAboutFilesWithSameLengthToolStripMenuItem_Click);
            // 
            // findDuplicatesToolStripMenuItem
            // 
            this.findDuplicatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byteByByteComparsionToolStripMenuItem,
            this.hashingByteByByteComparsionToolStripMenuItem});
            this.findDuplicatesToolStripMenuItem.Name = "findDuplicatesToolStripMenuItem";
            this.findDuplicatesToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.findDuplicatesToolStripMenuItem.Text = "Find duplicates";
            // 
            // byteByByteComparsionToolStripMenuItem
            // 
            this.byteByByteComparsionToolStripMenuItem.Name = "byteByByteComparsionToolStripMenuItem";
            this.byteByByteComparsionToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.byteByByteComparsionToolStripMenuItem.Text = "Byte by byte comparsion";
            this.byteByByteComparsionToolStripMenuItem.Click += new System.EventHandler(this.byteByByteComparsionToolStripMenuItem_Click);
            // 
            // hashingByteByByteComparsionToolStripMenuItem
            // 
            this.hashingByteByByteComparsionToolStripMenuItem.Name = "hashingByteByByteComparsionToolStripMenuItem";
            this.hashingByteByByteComparsionToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.hashingByteByByteComparsionToolStripMenuItem.Text = "Hashing + byte by byte comparsion";
            this.hashingByteByByteComparsionToolStripMenuItem.Click += new System.EventHandler(this.hashingByteByByteComparsionToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(12, 27);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(260, 209);
            this.treeView1.TabIndex = 1;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchFilesWithSameLengthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadInfoAboutFilesWithSameLengthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadInfoAboutFilesWithSameLengthToolStripMenuItem1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem exportInfoAboutFilesWithSameLengthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findDuplicatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byteByByteComparsionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hashingByteByByteComparsionToolStripMenuItem;
    }
}

