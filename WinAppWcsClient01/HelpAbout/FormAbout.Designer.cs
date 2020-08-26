namespace WinAppWmsLite.HelpAbout
{
    partial class FormAbout
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
            this.pnlTopTitle = new System.Windows.Forms.Panel();
            this.pnlTitleNo = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.splitterBottom = new System.Windows.Forms.Splitter();
            this.splitterTop = new System.Windows.Forms.Splitter();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnInitWh = new System.Windows.Forms.Button();
            this.pnlTopTitle.SuspendLayout();
            this.pnlTitleNo.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopTitle
            // 
            this.pnlTopTitle.Controls.Add(this.pnlTitleNo);
            this.pnlTopTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopTitle.Location = new System.Drawing.Point(0, 1);
            this.pnlTopTitle.Name = "pnlTopTitle";
            this.pnlTopTitle.Size = new System.Drawing.Size(434, 40);
            this.pnlTopTitle.TabIndex = 7;
            // 
            // pnlTitleNo
            // 
            this.pnlTitleNo.BackColor = System.Drawing.Color.Navy;
            this.pnlTitleNo.Controls.Add(this.lbTitle);
            this.pnlTitleNo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTitleNo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleNo.Name = "pnlTitleNo";
            this.pnlTitleNo.Size = new System.Drawing.Size(40, 40);
            this.pnlTitleNo.TabIndex = 2;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(40, 40);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "HA01";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 1);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(434, 474);
            this.pnlMain.TabIndex = 11;
            // 
            // splitterBottom
            // 
            this.splitterBottom.BackColor = System.Drawing.Color.Navy;
            this.splitterBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterBottom.Location = new System.Drawing.Point(0, 475);
            this.splitterBottom.Name = "splitterBottom";
            this.splitterBottom.Size = new System.Drawing.Size(434, 1);
            this.splitterBottom.TabIndex = 10;
            this.splitterBottom.TabStop = false;
            // 
            // splitterTop
            // 
            this.splitterTop.BackColor = System.Drawing.Color.Navy;
            this.splitterTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterTop.Location = new System.Drawing.Point(0, 0);
            this.splitterTop.Name = "splitterTop";
            this.splitterTop.Size = new System.Drawing.Size(434, 1);
            this.splitterTop.TabIndex = 9;
            this.splitterTop.TabStop = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnInitWh);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 476);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(434, 35);
            this.pnlBottom.TabIndex = 8;
            // 
            // btnInitWh
            // 
            this.btnInitWh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInitWh.Location = new System.Drawing.Point(0, 0);
            this.btnInitWh.Name = "btnInitWh";
            this.btnInitWh.Size = new System.Drawing.Size(121, 35);
            this.btnInitWh.TabIndex = 0;
            this.btnInitWh.Text = "Init Warehouse";
            this.btnInitWh.UseVisualStyleBackColor = true;
            this.btnInitWh.Click += new System.EventHandler(this.btnInitWh_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.pnlTopTitle);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.splitterBottom);
            this.Controls.Add(this.splitterTop);
            this.Controls.Add(this.pnlBottom);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAbout";
            this.pnlTopTitle.ResumeLayout(false);
            this.pnlTitleNo.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopTitle;
        private System.Windows.Forms.Panel pnlTitleNo;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Splitter splitterBottom;
        private System.Windows.Forms.Splitter splitterTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnInitWh;
    }
}