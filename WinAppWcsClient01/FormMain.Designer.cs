﻿namespace WinAppWmsLite
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
            this.tsmiMainOperate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpReceiving = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpShipping = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMainWhManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWmStockQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMainLocationMgt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLocationMapSet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMainItemMgt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiItemMaintain = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMainHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tsmiMainOperate,
            this.tsmiMainWhManagement,
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
            this.tsmiSubExit.Size = new System.Drawing.Size(119, 22);
            this.tsmiSubExit.Text = "退出 (&E)";
            this.tsmiSubExit.Click += new System.EventHandler(this.tsmiSubExit_Click);
            // 
            // tsmiMainOperate
            // 
            this.tsmiMainOperate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpReceiving,
            this.tsmiOpShipping});
            this.tsmiMainOperate.Name = "tsmiMainOperate";
            this.tsmiMainOperate.Size = new System.Drawing.Size(62, 21);
            this.tsmiMainOperate.Text = "操作(&O)";
            // 
            // tsmiOpReceiving
            // 
            this.tsmiOpReceiving.Name = "tsmiOpReceiving";
            this.tsmiOpReceiving.Size = new System.Drawing.Size(180, 22);
            this.tsmiOpReceiving.Text = "入库(&R)";
            this.tsmiOpReceiving.Click += new System.EventHandler(this.tsmiOpReceiving_Click);
            // 
            // tsmiOpShipping
            // 
            this.tsmiOpShipping.Name = "tsmiOpShipping";
            this.tsmiOpShipping.Size = new System.Drawing.Size(180, 22);
            this.tsmiOpShipping.Text = "出库(&S)";
            this.tsmiOpShipping.Click += new System.EventHandler(this.tsmiOpShipping_Click);
            // 
            // tsmiMainWhManagement
            // 
            this.tsmiMainWhManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiWmStockQuery});
            this.tsmiMainWhManagement.Name = "tsmiMainWhManagement";
            this.tsmiMainWhManagement.Size = new System.Drawing.Size(64, 21);
            this.tsmiMainWhManagement.Text = "管理(&M)";
            // 
            // tsmiWmStockQuery
            // 
            this.tsmiWmStockQuery.Name = "tsmiWmStockQuery";
            this.tsmiWmStockQuery.Size = new System.Drawing.Size(180, 22);
            this.tsmiWmStockQuery.Text = "库存查询";
            this.tsmiWmStockQuery.Click += new System.EventHandler(this.tsmiWmStockQuery_Click);
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
            this.tsmiLocationMapSet.Size = new System.Drawing.Size(160, 22);
            this.tsmiLocationMapSet.Text = "库位平面图设置";
            this.tsmiLocationMapSet.Click += new System.EventHandler(this.tsmiLocationMapSet_Click);
            // 
            // tsmiMainItemMgt
            // 
            this.tsmiMainItemMgt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiItemMaintain});
            this.tsmiMainItemMgt.Name = "tsmiMainItemMgt";
            this.tsmiMainItemMgt.Size = new System.Drawing.Size(56, 21);
            this.tsmiMainItemMgt.Text = "产品(&I)";
            // 
            // tsmiItemMaintain
            // 
            this.tsmiItemMaintain.Name = "tsmiItemMaintain";
            this.tsmiItemMaintain.Size = new System.Drawing.Size(124, 22);
            this.tsmiItemMaintain.Text = "产品管理";
            this.tsmiItemMaintain.Click += new System.EventHandler(this.tsmiItemMaintain_Click);
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
            this.tsmiHelpAbout.Size = new System.Drawing.Size(120, 22);
            this.tsmiHelpAbout.Text = "关于 (&A)";
            this.tsmiHelpAbout.Click += new System.EventHandler(this.tsmiHelpAbout_Click);
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
        private System.Windows.Forms.ToolStripMenuItem tsmiMainOperate;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpReceiving;
        private System.Windows.Forms.ToolStripMenuItem tsmiMainWhManagement;
        private System.Windows.Forms.ToolStripMenuItem tsmiWmStockQuery;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpShipping;
    }
}

