namespace WinAppWmsLite
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStripButton = new System.Windows.Forms.StatusStrip();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.tsmiMainFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSubExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMainLocationMgt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLocationMapSet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMainHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMainItemMgt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiItemMaintain = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripButton
            // 
            this.statusStripButton.Location = new System.Drawing.Point(0, 759);
            this.statusStripButton.Name = "statusStripButton";
            this.statusStripButton.Size = new System.Drawing.Size(1184, 22);
            this.statusStripButton.TabIndex = 0;
            this.statusStripButton.Text = "statusStrip1";
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMainFile,
            this.tsmiMainLocationMgt,
            this.tsmiMainItemMgt,
            this.tsmiMainHelp});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1184, 25);
            this.menuStripMain.TabIndex = 2;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // tsmiMainFile
            // 
            this.tsmiMainFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSubExit});
            this.tsmiMainFile.Name = "tsmiMainFile";
            this.tsmiMainFile.Size = new System.Drawing.Size(62, 21);
            this.tsmiMainFile.Text = "文件 (&F)";
            // 
            // tsmiSubExit
            // 
            this.tsmiSubExit.Name = "tsmiSubExit";
            this.tsmiSubExit.Size = new System.Drawing.Size(180, 22);
            this.tsmiSubExit.Text = "退出 (&E)";
            this.tsmiSubExit.Click += new System.EventHandler(this.tsmiSubExit_Click);
            // 
            // tsmiMainLocationMgt
            // 
            this.tsmiMainLocationMgt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLocationMapSet});
            this.tsmiMainLocationMgt.Name = "tsmiMainLocationMgt";
            this.tsmiMainLocationMgt.Size = new System.Drawing.Size(62, 21);
            this.tsmiMainLocationMgt.Text = "库位 (&L)";
            // 
            // tsmiLocationMapSet
            // 
            this.tsmiLocationMapSet.Name = "tsmiLocationMapSet";
            this.tsmiLocationMapSet.Size = new System.Drawing.Size(180, 22);
            this.tsmiLocationMapSet.Text = "库位平面图设置";
            this.tsmiLocationMapSet.Click += new System.EventHandler(this.tsmiLocationMapSet_Click);
            // 
            // tsmiMainHelp
            // 
            this.tsmiMainHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelpAbout});
            this.tsmiMainHelp.Name = "tsmiMainHelp";
            this.tsmiMainHelp.Size = new System.Drawing.Size(65, 21);
            this.tsmiMainHelp.Text = "帮助 (&H)";
            // 
            // tsmiHelpAbout
            // 
            this.tsmiHelpAbout.Name = "tsmiHelpAbout";
            this.tsmiHelpAbout.Size = new System.Drawing.Size(180, 22);
            this.tsmiHelpAbout.Text = "关于 (&A)";
            this.tsmiHelpAbout.Click += new System.EventHandler(this.tsmiHelpAbout_Click);
            // 
            // tsmiMainItemMgt
            // 
            this.tsmiMainItemMgt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiItemMaintain});
            this.tsmiMainItemMgt.Name = "tsmiMainItemMgt";
            this.tsmiMainItemMgt.Size = new System.Drawing.Size(56, 21);
            this.tsmiMainItemMgt.Text = "产品(I)";
            // 
            // tsmiItemMaintain
            // 
            this.tsmiItemMaintain.Name = "tsmiItemMaintain";
            this.tsmiItemMaintain.Size = new System.Drawing.Size(180, 22);
            this.tsmiItemMaintain.Text = "产品管理";
            this.tsmiItemMaintain.Click += new System.EventHandler(this.tsmiItemMaintain_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 781);
            this.Controls.Add(this.statusStripButton);
            this.Controls.Add(this.menuStripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripButton;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiMainFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiSubExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiMainLocationMgt;
        private System.Windows.Forms.ToolStripMenuItem tsmiMainHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiLocationMapSet;
        private System.Windows.Forms.ToolStripMenuItem tsmiMainItemMgt;
        private System.Windows.Forms.ToolStripMenuItem tsmiItemMaintain;
    }
}

