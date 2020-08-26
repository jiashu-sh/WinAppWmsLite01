namespace WinAppWmsLite.LocationMgt
{
    partial class FormLocationMapSet
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
            this.components = new System.ComponentModel.Container();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlAreaSel = new System.Windows.Forms.Panel();
            this.cbRunStatistics = new System.Windows.Forms.CheckBox();
            this.cbViewABCClass = new System.Windows.Forms.CheckBox();
            this.cbViewPickingPRI = new System.Windows.Forms.CheckBox();
            this.lbAreaGroupNo = new System.Windows.Forms.Label();
            this.cbAreaGroupNo = new System.Windows.Forms.ComboBox();
            this.pnlSettingLock = new System.Windows.Forms.Panel();
            this.cbSettingLock = new System.Windows.Forms.CheckBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbShowGrid = new System.Windows.Forms.CheckBox();
            this.lbAreaNo = new System.Windows.Forms.Label();
            this.cbAreaNo = new System.Windows.Forms.ComboBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lbSelectedUnitMacAddress = new System.Windows.Forms.Label();
            this.cbShowShelfMap = new System.Windows.Forms.CheckBox();
            this.cbViewMotion = new System.Windows.Forms.CheckBox();
            this.lbElapsedTime = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lbGridYVal = new System.Windows.Forms.Label();
            this.lbGridY = new System.Windows.Forms.Label();
            this.lbGridXVal = new System.Windows.Forms.Label();
            this.lbGirdX = new System.Windows.Forms.Label();
            this.lbYVal = new System.Windows.Forms.Label();
            this.lbYTip = new System.Windows.Forms.Label();
            this.lbXVal = new System.Windows.Forms.Label();
            this.lbXTip = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.splitterTop = new System.Windows.Forms.Splitter();
            this.splitterBottom = new System.Windows.Forms.Splitter();
            this.ctxmsMapRight = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddLane = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSetRoadDisable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetStartPosition = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetEndPosition = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStartWayfinding = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSendCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlInput.SuspendLayout();
            this.pnlAreaSel.SuspendLayout();
            this.pnlSettingLock.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.ctxmsMapRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.btnRefresh);
            this.pnlInput.Controls.Add(this.pnlAreaSel);
            this.pnlInput.Controls.Add(this.pnlSettingLock);
            this.pnlInput.Controls.Add(this.pnlTitle);
            this.pnlInput.Controls.Add(this.btnExit);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.Location = new System.Drawing.Point(0, 0);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(984, 40);
            this.pnlInput.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.Location = new System.Drawing.Point(744, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 40);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlAreaSel
            // 
            this.pnlAreaSel.Controls.Add(this.cbRunStatistics);
            this.pnlAreaSel.Controls.Add(this.cbViewABCClass);
            this.pnlAreaSel.Controls.Add(this.cbViewPickingPRI);
            this.pnlAreaSel.Controls.Add(this.lbAreaGroupNo);
            this.pnlAreaSel.Controls.Add(this.cbAreaGroupNo);
            this.pnlAreaSel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAreaSel.Location = new System.Drawing.Point(150, 0);
            this.pnlAreaSel.Name = "pnlAreaSel";
            this.pnlAreaSel.Size = new System.Drawing.Size(549, 40);
            this.pnlAreaSel.TabIndex = 3;
            // 
            // cbRunStatistics
            // 
            this.cbRunStatistics.AutoSize = true;
            this.cbRunStatistics.Location = new System.Drawing.Point(441, 9);
            this.cbRunStatistics.Name = "cbRunStatistics";
            this.cbRunStatistics.Size = new System.Drawing.Size(99, 21);
            this.cbRunStatistics.TabIndex = 2;
            this.cbRunStatistics.Text = "查看库存分析";
            this.cbRunStatistics.UseVisualStyleBackColor = true;
            // 
            // cbViewABCClass
            // 
            this.cbViewABCClass.AutoSize = true;
            this.cbViewABCClass.Location = new System.Drawing.Point(336, 9);
            this.cbViewABCClass.Name = "cbViewABCClass";
            this.cbViewABCClass.Size = new System.Drawing.Size(99, 21);
            this.cbViewABCClass.TabIndex = 2;
            this.cbViewABCClass.Text = "查看ABC分类";
            this.cbViewABCClass.UseVisualStyleBackColor = true;
            // 
            // cbViewPickingPRI
            // 
            this.cbViewPickingPRI.AutoSize = true;
            this.cbViewPickingPRI.Location = new System.Drawing.Point(219, 9);
            this.cbViewPickingPRI.Name = "cbViewPickingPRI";
            this.cbViewPickingPRI.Size = new System.Drawing.Size(111, 21);
            this.cbViewPickingPRI.TabIndex = 2;
            this.cbViewPickingPRI.Text = "查看库位优先级";
            this.cbViewPickingPRI.UseVisualStyleBackColor = true;
            // 
            // lbAreaGroupNo
            // 
            this.lbAreaGroupNo.AutoSize = true;
            this.lbAreaGroupNo.Location = new System.Drawing.Point(16, 11);
            this.lbAreaGroupNo.Name = "lbAreaGroupNo";
            this.lbAreaGroupNo.Size = new System.Drawing.Size(44, 17);
            this.lbAreaGroupNo.TabIndex = 1;
            this.lbAreaGroupNo.Text = "库区组";
            // 
            // cbAreaGroupNo
            // 
            this.cbAreaGroupNo.FormattingEnabled = true;
            this.cbAreaGroupNo.Location = new System.Drawing.Point(66, 7);
            this.cbAreaGroupNo.Name = "cbAreaGroupNo";
            this.cbAreaGroupNo.Size = new System.Drawing.Size(130, 25);
            this.cbAreaGroupNo.TabIndex = 0;
            // 
            // pnlSettingLock
            // 
            this.pnlSettingLock.Controls.Add(this.cbSettingLock);
            this.pnlSettingLock.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSettingLock.Location = new System.Drawing.Point(40, 0);
            this.pnlSettingLock.Name = "pnlSettingLock";
            this.pnlSettingLock.Size = new System.Drawing.Size(110, 40);
            this.pnlSettingLock.TabIndex = 2;
            // 
            // cbSettingLock
            // 
            this.cbSettingLock.AutoSize = true;
            this.cbSettingLock.Checked = true;
            this.cbSettingLock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSettingLock.Location = new System.Drawing.Point(23, 11);
            this.cbSettingLock.Name = "cbSettingLock";
            this.cbSettingLock.Size = new System.Drawing.Size(79, 21);
            this.cbSettingLock.TabIndex = 0;
            this.cbSettingLock.Text = "解锁 设置";
            this.cbSettingLock.UseVisualStyleBackColor = true;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Navy;
            this.pnlTitle.Controls.Add(this.lbTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(40, 40);
            this.pnlTitle.TabIndex = 1;
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
            this.lbTitle.Text = "LM01";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(864, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 40);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbShowGrid
            // 
            this.cbShowGrid.AutoSize = true;
            this.cbShowGrid.Location = new System.Drawing.Point(351, 7);
            this.cbShowGrid.Name = "cbShowGrid";
            this.cbShowGrid.Size = new System.Drawing.Size(75, 21);
            this.cbShowGrid.TabIndex = 2;
            this.cbShowGrid.Text = "显示网格";
            this.cbShowGrid.UseVisualStyleBackColor = true;
            this.cbShowGrid.CheckedChanged += new System.EventHandler(this.cbShowGrid_CheckedChanged);
            // 
            // lbAreaNo
            // 
            this.lbAreaNo.AutoSize = true;
            this.lbAreaNo.Location = new System.Drawing.Point(537, 9);
            this.lbAreaNo.Name = "lbAreaNo";
            this.lbAreaNo.Size = new System.Drawing.Size(32, 17);
            this.lbAreaNo.TabIndex = 1;
            this.lbAreaNo.Text = "库区";
            // 
            // cbAreaNo
            // 
            this.cbAreaNo.FormattingEnabled = true;
            this.cbAreaNo.Location = new System.Drawing.Point(575, 5);
            this.cbAreaNo.Name = "cbAreaNo";
            this.cbAreaNo.Size = new System.Drawing.Size(70, 25);
            this.cbAreaNo.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.lbSelectedUnitMacAddress);
            this.pnlBottom.Controls.Add(this.cbShowShelfMap);
            this.pnlBottom.Controls.Add(this.cbViewMotion);
            this.pnlBottom.Controls.Add(this.lbElapsedTime);
            this.pnlBottom.Controls.Add(this.cbShowGrid);
            this.pnlBottom.Controls.Add(this.lbAreaNo);
            this.pnlBottom.Controls.Add(this.pnlStatus);
            this.pnlBottom.Controls.Add(this.cbAreaNo);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 576);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(984, 35);
            this.pnlBottom.TabIndex = 1;
            // 
            // lbSelectedUnitMacAddress
            // 
            this.lbSelectedUnitMacAddress.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbSelectedUnitMacAddress.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbSelectedUnitMacAddress.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSelectedUnitMacAddress.ForeColor = System.Drawing.Color.White;
            this.lbSelectedUnitMacAddress.Location = new System.Drawing.Point(844, 0);
            this.lbSelectedUnitMacAddress.Name = "lbSelectedUnitMacAddress";
            this.lbSelectedUnitMacAddress.Size = new System.Drawing.Size(140, 35);
            this.lbSelectedUnitMacAddress.TabIndex = 6;
            this.lbSelectedUnitMacAddress.Text = "28-3A-4D-5A-C9-8F";
            this.lbSelectedUnitMacAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbShowShelfMap
            // 
            this.cbShowShelfMap.AutoSize = true;
            this.cbShowShelfMap.Checked = true;
            this.cbShowShelfMap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowShelfMap.Location = new System.Drawing.Point(432, 7);
            this.cbShowShelfMap.Name = "cbShowShelfMap";
            this.cbShowShelfMap.Size = new System.Drawing.Size(99, 21);
            this.cbShowShelfMap.TabIndex = 5;
            this.cbShowShelfMap.Text = "显示设置货位";
            this.cbShowShelfMap.UseVisualStyleBackColor = true;
            // 
            // cbViewMotion
            // 
            this.cbViewMotion.AutoSize = true;
            this.cbViewMotion.Location = new System.Drawing.Point(664, 7);
            this.cbViewMotion.Name = "cbViewMotion";
            this.cbViewMotion.Size = new System.Drawing.Size(99, 21);
            this.cbViewMotion.TabIndex = 4;
            this.cbViewMotion.Text = "显示寻路效果";
            this.cbViewMotion.UseVisualStyleBackColor = true;
            // 
            // lbElapsedTime
            // 
            this.lbElapsedTime.AutoSize = true;
            this.lbElapsedTime.Location = new System.Drawing.Point(782, 9);
            this.lbElapsedTime.Name = "lbElapsedTime";
            this.lbElapsedTime.Size = new System.Drawing.Size(15, 17);
            this.lbElapsedTime.TabIndex = 3;
            this.lbElapsedTime.Text = "0";
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.lbGridYVal);
            this.pnlStatus.Controls.Add(this.lbGridY);
            this.pnlStatus.Controls.Add(this.lbGridXVal);
            this.pnlStatus.Controls.Add(this.lbGirdX);
            this.pnlStatus.Controls.Add(this.lbYVal);
            this.pnlStatus.Controls.Add(this.lbYTip);
            this.pnlStatus.Controls.Add(this.lbXVal);
            this.pnlStatus.Controls.Add(this.lbXTip);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStatus.Location = new System.Drawing.Point(0, 0);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(328, 35);
            this.pnlStatus.TabIndex = 0;
            // 
            // lbGridYVal
            // 
            this.lbGridYVal.AutoSize = true;
            this.lbGridYVal.Location = new System.Drawing.Point(283, 9);
            this.lbGridYVal.Name = "lbGridYVal";
            this.lbGridYVal.Size = new System.Drawing.Size(15, 17);
            this.lbGridYVal.TabIndex = 1;
            this.lbGridYVal.Text = "0";
            // 
            // lbGridY
            // 
            this.lbGridY.AutoSize = true;
            this.lbGridY.Location = new System.Drawing.Point(252, 9);
            this.lbGridY.Name = "lbGridY";
            this.lbGridY.Size = new System.Drawing.Size(33, 17);
            this.lbGridY.TabIndex = 2;
            this.lbGridY.Text = "gy : ";
            // 
            // lbGridXVal
            // 
            this.lbGridXVal.AutoSize = true;
            this.lbGridXVal.Location = new System.Drawing.Point(205, 9);
            this.lbGridXVal.Name = "lbGridXVal";
            this.lbGridXVal.Size = new System.Drawing.Size(15, 17);
            this.lbGridXVal.TabIndex = 3;
            this.lbGridXVal.Text = "0";
            // 
            // lbGirdX
            // 
            this.lbGirdX.AutoSize = true;
            this.lbGirdX.Location = new System.Drawing.Point(174, 9);
            this.lbGirdX.Name = "lbGirdX";
            this.lbGirdX.Size = new System.Drawing.Size(33, 17);
            this.lbGirdX.TabIndex = 4;
            this.lbGirdX.Text = "gx : ";
            // 
            // lbYVal
            // 
            this.lbYVal.AutoSize = true;
            this.lbYVal.Location = new System.Drawing.Point(121, 7);
            this.lbYVal.Name = "lbYVal";
            this.lbYVal.Size = new System.Drawing.Size(15, 17);
            this.lbYVal.TabIndex = 0;
            this.lbYVal.Text = "0";
            // 
            // lbYTip
            // 
            this.lbYTip.AutoSize = true;
            this.lbYTip.Location = new System.Drawing.Point(90, 7);
            this.lbYTip.Name = "lbYTip";
            this.lbYTip.Size = new System.Drawing.Size(25, 17);
            this.lbYTip.TabIndex = 0;
            this.lbYTip.Text = "y : ";
            // 
            // lbXVal
            // 
            this.lbXVal.AutoSize = true;
            this.lbXVal.Location = new System.Drawing.Point(43, 7);
            this.lbXVal.Name = "lbXVal";
            this.lbXVal.Size = new System.Drawing.Size(15, 17);
            this.lbXVal.TabIndex = 0;
            this.lbXVal.Text = "0";
            // 
            // lbXTip
            // 
            this.lbXTip.AutoSize = true;
            this.lbXTip.Location = new System.Drawing.Point(12, 7);
            this.lbXTip.Name = "lbXTip";
            this.lbXTip.Size = new System.Drawing.Size(25, 17);
            this.lbXTip.TabIndex = 0;
            this.lbXTip.Text = "x : ";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 41);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(984, 534);
            this.pnlMain.TabIndex = 2;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            this.pnlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMain_MouseDown);
            // 
            // splitterTop
            // 
            this.splitterTop.BackColor = System.Drawing.Color.Navy;
            this.splitterTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterTop.Location = new System.Drawing.Point(0, 40);
            this.splitterTop.Name = "splitterTop";
            this.splitterTop.Size = new System.Drawing.Size(984, 1);
            this.splitterTop.TabIndex = 3;
            this.splitterTop.TabStop = false;
            // 
            // splitterBottom
            // 
            this.splitterBottom.BackColor = System.Drawing.Color.Navy;
            this.splitterBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterBottom.Location = new System.Drawing.Point(0, 575);
            this.splitterBottom.Name = "splitterBottom";
            this.splitterBottom.Size = new System.Drawing.Size(984, 1);
            this.splitterBottom.TabIndex = 4;
            this.splitterBottom.TabStop = false;
            // 
            // ctxmsMapRight
            // 
            this.ctxmsMapRight.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddLane,
            this.toolStripMenuItem1,
            this.tsmiSetRoadDisable,
            this.tsmiSetStartPosition,
            this.tsmiSetEndPosition,
            this.tsmiStartWayfinding,
            this.toolStripMenuItem2,
            this.tsmiSendCommand});
            this.ctxmsMapRight.Name = "ctxmsMapRight";
            this.ctxmsMapRight.Size = new System.Drawing.Size(161, 148);
            // 
            // tsmiAddLane
            // 
            this.tsmiAddLane.Name = "tsmiAddLane";
            this.tsmiAddLane.Size = new System.Drawing.Size(160, 22);
            this.tsmiAddLane.Text = "增加货架排...";
            this.tsmiAddLane.Click += new System.EventHandler(this.tsmiAddLane_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 6);
            // 
            // tsmiSetRoadDisable
            // 
            this.tsmiSetRoadDisable.Name = "tsmiSetRoadDisable";
            this.tsmiSetRoadDisable.Size = new System.Drawing.Size(160, 22);
            this.tsmiSetRoadDisable.Text = "设置道路不可用";
            this.tsmiSetRoadDisable.Click += new System.EventHandler(this.tsmiSetRoadDisable_Click);
            // 
            // tsmiSetStartPosition
            // 
            this.tsmiSetStartPosition.Name = "tsmiSetStartPosition";
            this.tsmiSetStartPosition.Size = new System.Drawing.Size(160, 22);
            this.tsmiSetStartPosition.Text = "设置起点";
            this.tsmiSetStartPosition.Click += new System.EventHandler(this.tsmiSetStartPosition_Click);
            // 
            // tsmiSetEndPosition
            // 
            this.tsmiSetEndPosition.Name = "tsmiSetEndPosition";
            this.tsmiSetEndPosition.Size = new System.Drawing.Size(160, 22);
            this.tsmiSetEndPosition.Text = "设置终点";
            this.tsmiSetEndPosition.Click += new System.EventHandler(this.tsmiSetEndPosition_Click);
            // 
            // tsmiStartWayfinding
            // 
            this.tsmiStartWayfinding.Name = "tsmiStartWayfinding";
            this.tsmiStartWayfinding.Size = new System.Drawing.Size(160, 22);
            this.tsmiStartWayfinding.Text = "开始寻路...";
            this.tsmiStartWayfinding.Click += new System.EventHandler(this.tsmiStartWayfinding_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(157, 6);
            // 
            // tsmiSendCommand
            // 
            this.tsmiSendCommand.Name = "tsmiSendCommand";
            this.tsmiSendCommand.Size = new System.Drawing.Size(160, 22);
            this.tsmiSendCommand.Text = "发送任务";
            this.tsmiSendCommand.Click += new System.EventHandler(this.tsmiSendCommand_Click);
            // 
            // FormLocationMapSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.splitterBottom);
            this.Controls.Add(this.splitterTop);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlInput);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLocationMapSet";
            this.Text = "FormLocationMapSet";
            this.Load += new System.EventHandler(this.FormLocationMapSet_Load);
            this.pnlInput.ResumeLayout(false);
            this.pnlAreaSel.ResumeLayout(false);
            this.pnlAreaSel.PerformLayout();
            this.pnlSettingLock.ResumeLayout(false);
            this.pnlSettingLock.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.ctxmsMapRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Splitter splitterTop;
        private System.Windows.Forms.Splitter splitterBottom;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnlAreaSel;
        private System.Windows.Forms.Panel pnlSettingLock;
        private System.Windows.Forms.CheckBox cbSettingLock;
        private System.Windows.Forms.Label lbAreaNo;
        private System.Windows.Forms.ComboBox cbAreaNo;
        private System.Windows.Forms.Label lbAreaGroupNo;
        private System.Windows.Forms.ComboBox cbAreaGroupNo;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lbYVal;
        private System.Windows.Forms.Label lbYTip;
        private System.Windows.Forms.Label lbXVal;
        private System.Windows.Forms.Label lbXTip;
        private System.Windows.Forms.ContextMenuStrip ctxmsMapRight;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddLane;
        private System.Windows.Forms.CheckBox cbShowGrid;
        private System.Windows.Forms.CheckBox cbViewPickingPRI;
        private System.Windows.Forms.CheckBox cbViewABCClass;
        private System.Windows.Forms.CheckBox cbRunStatistics;
        private System.Windows.Forms.Label lbGridYVal;
        private System.Windows.Forms.Label lbGridY;
        private System.Windows.Forms.Label lbGridXVal;
        private System.Windows.Forms.Label lbGirdX;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetRoadDisable;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetStartPosition;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetEndPosition;
        private System.Windows.Forms.ToolStripMenuItem tsmiStartWayfinding;
        private System.Windows.Forms.Label lbElapsedTime;
        private System.Windows.Forms.CheckBox cbViewMotion;
        private System.Windows.Forms.CheckBox cbShowShelfMap;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiSendCommand;
        private System.Windows.Forms.Label lbSelectedUnitMacAddress;
    }
}