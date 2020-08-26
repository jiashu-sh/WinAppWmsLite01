namespace WinAppWmsLite.LocationMgt
{
    partial class FormLaneMgt
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
            this.lbTitleDesc = new System.Windows.Forms.Label();
            this.pnlTitleNo = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lbTipAreaNo = new System.Windows.Forms.Label();
            this.lbYVal = new System.Windows.Forms.Label();
            this.lbYTip = new System.Windows.Forms.Label();
            this.lbXVal = new System.Windows.Forms.Label();
            this.lbXTip = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.splitterTop = new System.Windows.Forms.Splitter();
            this.splitterBottom = new System.Windows.Forms.Splitter();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.cbGenRule = new System.Windows.Forms.CheckBox();
            this.cbStorageType = new System.Windows.Forms.ComboBox();
            this.cbLaneOrder = new System.Windows.Forms.ComboBox();
            this.cbOddEven = new System.Windows.Forms.ComboBox();
            this.cbLaneDirection = new System.Windows.Forms.ComboBox();
            this.lstboxLaneNos = new System.Windows.Forms.ListBox();
            this.lstboxShelfNos = new System.Windows.Forms.ListBox();
            this.lstboxLocationNos = new System.Windows.Forms.ListBox();
            this.btnGenLocationNo = new System.Windows.Forms.Button();
            this.lbMultiply = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbS1 = new System.Windows.Forms.Label();
            this.lbTo2 = new System.Windows.Forms.Label();
            this.lbTo1 = new System.Windows.Forms.Label();
            this.lbFrom2 = new System.Windows.Forms.Label();
            this.lbFrom1 = new System.Windows.Forms.Label();
            this.lbStorageType = new System.Windows.Forms.Label();
            this.lbGenLoc = new System.Windows.Forms.Label();
            this.lbGenTier = new System.Windows.Forms.Label();
            this.lbShelf = new System.Windows.Forms.Label();
            this.lbLaneToGen = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.lbShelfToGen = new System.Windows.Forms.Label();
            this.lbLocaitonToGen = new System.Windows.Forms.Label();
            this.lbToInsertLocCount = new System.Windows.Forms.Label();
            this.lbLane = new System.Windows.Forms.Label();
            this.lbLaneOrder = new System.Windows.Forms.Label();
            this.lbLaneDirection = new System.Windows.Forms.Label();
            this.lbArea = new System.Windows.Forms.Label();
            this.tbShelfNoEnd = new System.Windows.Forms.TextBox();
            this.tbGenLocCount = new System.Windows.Forms.TextBox();
            this.tbGenTierCount = new System.Windows.Forms.TextBox();
            this.tbShelfNoStart = new System.Windows.Forms.TextBox();
            this.tbLaneNoEnd = new System.Windows.Forms.TextBox();
            this.tbLaneNoStart = new System.Windows.Forms.TextBox();
            this.tbAreaNo = new System.Windows.Forms.TextBox();
            this.pnlTopTitle.SuspendLayout();
            this.pnlTitleNo.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopTitle
            // 
            this.pnlTopTitle.Controls.Add(this.lbTitleDesc);
            this.pnlTopTitle.Controls.Add(this.pnlTitleNo);
            this.pnlTopTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTopTitle.Name = "pnlTopTitle";
            this.pnlTopTitle.Size = new System.Drawing.Size(434, 40);
            this.pnlTopTitle.TabIndex = 0;
            // 
            // lbTitleDesc
            // 
            this.lbTitleDesc.AutoSize = true;
            this.lbTitleDesc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitleDesc.Location = new System.Drawing.Point(60, 12);
            this.lbTitleDesc.Name = "lbTitleDesc";
            this.lbTitleDesc.Size = new System.Drawing.Size(78, 17);
            this.lbTitleDesc.TabIndex = 3;
            this.lbTitleDesc.Text = "货架(排)维护";
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
            this.lbTitle.Text = "LM01-01";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.pnlStatus);
            this.pnlBottom.Controls.Add(this.btnInsert);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 576);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(434, 35);
            this.pnlBottom.TabIndex = 1;
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.lbTipAreaNo);
            this.pnlStatus.Controls.Add(this.lbYVal);
            this.pnlStatus.Controls.Add(this.lbYTip);
            this.pnlStatus.Controls.Add(this.lbXVal);
            this.pnlStatus.Controls.Add(this.lbXTip);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStatus.Location = new System.Drawing.Point(0, 0);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(226, 35);
            this.pnlStatus.TabIndex = 1;
            // 
            // lbTipAreaNo
            // 
            this.lbTipAreaNo.AutoSize = true;
            this.lbTipAreaNo.Location = new System.Drawing.Point(186, 7);
            this.lbTipAreaNo.Name = "lbTipAreaNo";
            this.lbTipAreaNo.Size = new System.Drawing.Size(17, 17);
            this.lbTipAreaNo.TabIndex = 0;
            this.lbTipAreaNo.Text = "...";
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
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInsert.Location = new System.Drawing.Point(265, 0);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(169, 35);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "保存货位";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // splitterTop
            // 
            this.splitterTop.BackColor = System.Drawing.Color.Navy;
            this.splitterTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterTop.Location = new System.Drawing.Point(0, 40);
            this.splitterTop.Name = "splitterTop";
            this.splitterTop.Size = new System.Drawing.Size(434, 1);
            this.splitterTop.TabIndex = 4;
            this.splitterTop.TabStop = false;
            // 
            // splitterBottom
            // 
            this.splitterBottom.BackColor = System.Drawing.Color.Navy;
            this.splitterBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterBottom.Location = new System.Drawing.Point(0, 575);
            this.splitterBottom.Name = "splitterBottom";
            this.splitterBottom.Size = new System.Drawing.Size(434, 1);
            this.splitterBottom.TabIndex = 5;
            this.splitterBottom.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.cbGenRule);
            this.pnlMain.Controls.Add(this.cbStorageType);
            this.pnlMain.Controls.Add(this.cbLaneOrder);
            this.pnlMain.Controls.Add(this.cbOddEven);
            this.pnlMain.Controls.Add(this.cbLaneDirection);
            this.pnlMain.Controls.Add(this.lstboxLaneNos);
            this.pnlMain.Controls.Add(this.lstboxShelfNos);
            this.pnlMain.Controls.Add(this.lstboxLocationNos);
            this.pnlMain.Controls.Add(this.btnGenLocationNo);
            this.pnlMain.Controls.Add(this.lbMultiply);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.lbS1);
            this.pnlMain.Controls.Add(this.lbTo2);
            this.pnlMain.Controls.Add(this.lbTo1);
            this.pnlMain.Controls.Add(this.lbFrom2);
            this.pnlMain.Controls.Add(this.lbFrom1);
            this.pnlMain.Controls.Add(this.lbStorageType);
            this.pnlMain.Controls.Add(this.lbGenLoc);
            this.pnlMain.Controls.Add(this.lbGenTier);
            this.pnlMain.Controls.Add(this.lbShelf);
            this.pnlMain.Controls.Add(this.lbLaneToGen);
            this.pnlMain.Controls.Add(this.lbMessage);
            this.pnlMain.Controls.Add(this.lbShelfToGen);
            this.pnlMain.Controls.Add(this.lbLocaitonToGen);
            this.pnlMain.Controls.Add(this.lbToInsertLocCount);
            this.pnlMain.Controls.Add(this.lbLane);
            this.pnlMain.Controls.Add(this.lbLaneOrder);
            this.pnlMain.Controls.Add(this.lbLaneDirection);
            this.pnlMain.Controls.Add(this.lbArea);
            this.pnlMain.Controls.Add(this.tbShelfNoEnd);
            this.pnlMain.Controls.Add(this.tbGenLocCount);
            this.pnlMain.Controls.Add(this.tbGenTierCount);
            this.pnlMain.Controls.Add(this.tbShelfNoStart);
            this.pnlMain.Controls.Add(this.tbLaneNoEnd);
            this.pnlMain.Controls.Add(this.tbLaneNoStart);
            this.pnlMain.Controls.Add(this.tbAreaNo);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 41);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(434, 534);
            this.pnlMain.TabIndex = 6;
            // 
            // cbGenRule
            // 
            this.cbGenRule.AutoSize = true;
            this.cbGenRule.Location = new System.Drawing.Point(211, 140);
            this.cbGenRule.Name = "cbGenRule";
            this.cbGenRule.Size = new System.Drawing.Size(164, 21);
            this.cbGenRule.TabIndex = 12;
            this.cbGenRule.Text = "自定义 生成规则(单/双面)";
            this.cbGenRule.UseVisualStyleBackColor = true;
            this.cbGenRule.CheckedChanged += new System.EventHandler(this.cbGenRule_CheckedChanged);
            // 
            // cbStorageType
            // 
            this.cbStorageType.FormattingEnabled = true;
            this.cbStorageType.Location = new System.Drawing.Point(312, 47);
            this.cbStorageType.Name = "cbStorageType";
            this.cbStorageType.Size = new System.Drawing.Size(77, 25);
            this.cbStorageType.TabIndex = 11;
            this.cbStorageType.SelectedIndexChanged += new System.EventHandler(this.cbStorageType_SelectedIndexChanged);
            // 
            // cbLaneOrder
            // 
            this.cbLaneOrder.FormattingEnabled = true;
            this.cbLaneOrder.Items.AddRange(new object[] {
            "MIN",
            "MAX"});
            this.cbLaneOrder.Location = new System.Drawing.Point(102, 161);
            this.cbLaneOrder.Name = "cbLaneOrder";
            this.cbLaneOrder.Size = new System.Drawing.Size(86, 25);
            this.cbLaneOrder.TabIndex = 10;
            // 
            // cbOddEven
            // 
            this.cbOddEven.Enabled = false;
            this.cbOddEven.FormattingEnabled = true;
            this.cbOddEven.Items.AddRange(new object[] {
            "全部(奇偶面同时创建)",
            "奇数面",
            "偶数面"});
            this.cbOddEven.Location = new System.Drawing.Point(211, 161);
            this.cbOddEven.Name = "cbOddEven";
            this.cbOddEven.Size = new System.Drawing.Size(178, 25);
            this.cbOddEven.TabIndex = 10;
            // 
            // cbLaneDirection
            // 
            this.cbLaneDirection.FormattingEnabled = true;
            this.cbLaneDirection.Items.AddRange(new object[] {
            "N",
            "E",
            "S",
            "W"});
            this.cbLaneDirection.Location = new System.Drawing.Point(46, 161);
            this.cbLaneDirection.Name = "cbLaneDirection";
            this.cbLaneDirection.Size = new System.Drawing.Size(53, 25);
            this.cbLaneDirection.TabIndex = 10;
            // 
            // lstboxLaneNos
            // 
            this.lstboxLaneNos.FormattingEnabled = true;
            this.lstboxLaneNos.ItemHeight = 17;
            this.lstboxLaneNos.Location = new System.Drawing.Point(265, 435);
            this.lstboxLaneNos.Name = "lstboxLaneNos";
            this.lstboxLaneNos.Size = new System.Drawing.Size(124, 89);
            this.lstboxLaneNos.TabIndex = 9;
            // 
            // lstboxShelfNos
            // 
            this.lstboxShelfNos.FormattingEnabled = true;
            this.lstboxShelfNos.ItemHeight = 17;
            this.lstboxShelfNos.Location = new System.Drawing.Point(265, 265);
            this.lstboxShelfNos.Name = "lstboxShelfNos";
            this.lstboxShelfNos.Size = new System.Drawing.Size(124, 140);
            this.lstboxShelfNos.TabIndex = 9;
            // 
            // lstboxLocationNos
            // 
            this.lstboxLocationNos.FormattingEnabled = true;
            this.lstboxLocationNos.ItemHeight = 17;
            this.lstboxLocationNos.Location = new System.Drawing.Point(46, 265);
            this.lstboxLocationNos.Name = "lstboxLocationNos";
            this.lstboxLocationNos.Size = new System.Drawing.Size(142, 259);
            this.lstboxLocationNos.TabIndex = 9;
            // 
            // btnGenLocationNo
            // 
            this.btnGenLocationNo.Location = new System.Drawing.Point(46, 201);
            this.btnGenLocationNo.Name = "btnGenLocationNo";
            this.btnGenLocationNo.Size = new System.Drawing.Size(142, 35);
            this.btnGenLocationNo.TabIndex = 8;
            this.btnGenLocationNo.Text = "预览 生成货位";
            this.btnGenLocationNo.UseVisualStyleBackColor = true;
            this.btnGenLocationNo.Click += new System.EventHandler(this.btnGenLocationNo_Click);
            // 
            // lbMultiply
            // 
            this.lbMultiply.AutoSize = true;
            this.lbMultiply.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMultiply.ForeColor = System.Drawing.Color.DimGray;
            this.lbMultiply.Location = new System.Drawing.Point(247, 47);
            this.lbMultiply.Name = "lbMultiply";
            this.lbMultiply.Size = new System.Drawing.Size(16, 20);
            this.lbMultiply.TabIndex = 1;
            this.lbMultiply.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(192, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "-";
            // 
            // lbS1
            // 
            this.lbS1.AutoSize = true;
            this.lbS1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbS1.Location = new System.Drawing.Point(130, 47);
            this.lbS1.Name = "lbS1";
            this.lbS1.Size = new System.Drawing.Size(15, 19);
            this.lbS1.TabIndex = 1;
            this.lbS1.Text = "-";
            // 
            // lbTo2
            // 
            this.lbTo2.AutoSize = true;
            this.lbTo2.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTo2.ForeColor = System.Drawing.Color.DimGray;
            this.lbTo2.Location = new System.Drawing.Point(175, 72);
            this.lbTo2.Name = "lbTo2";
            this.lbTo2.Size = new System.Drawing.Size(18, 16);
            this.lbTo2.TabIndex = 1;
            this.lbTo2.Text = "至";
            // 
            // lbTo1
            // 
            this.lbTo1.AutoSize = true;
            this.lbTo1.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTo1.ForeColor = System.Drawing.Color.DimGray;
            this.lbTo1.Location = new System.Drawing.Point(113, 72);
            this.lbTo1.Name = "lbTo1";
            this.lbTo1.Size = new System.Drawing.Size(18, 16);
            this.lbTo1.TabIndex = 1;
            this.lbTo1.Text = "至";
            // 
            // lbFrom2
            // 
            this.lbFrom2.AutoSize = true;
            this.lbFrom2.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbFrom2.ForeColor = System.Drawing.Color.DimGray;
            this.lbFrom2.Location = new System.Drawing.Point(175, 28);
            this.lbFrom2.Name = "lbFrom2";
            this.lbFrom2.Size = new System.Drawing.Size(18, 16);
            this.lbFrom2.TabIndex = 1;
            this.lbFrom2.Text = "起";
            // 
            // lbFrom1
            // 
            this.lbFrom1.AutoSize = true;
            this.lbFrom1.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbFrom1.ForeColor = System.Drawing.Color.DimGray;
            this.lbFrom1.Location = new System.Drawing.Point(113, 28);
            this.lbFrom1.Name = "lbFrom1";
            this.lbFrom1.Size = new System.Drawing.Size(18, 16);
            this.lbFrom1.TabIndex = 1;
            this.lbFrom1.Text = "起";
            // 
            // lbStorageType
            // 
            this.lbStorageType.AutoSize = true;
            this.lbStorageType.Location = new System.Drawing.Point(309, 27);
            this.lbStorageType.Name = "lbStorageType";
            this.lbStorageType.Size = new System.Drawing.Size(80, 17);
            this.lbStorageType.TabIndex = 1;
            this.lbStorageType.Text = "货架存储类型";
            // 
            // lbGenLoc
            // 
            this.lbGenLoc.AutoSize = true;
            this.lbGenLoc.Location = new System.Drawing.Point(262, 27);
            this.lbGenLoc.Name = "lbGenLoc";
            this.lbGenLoc.Size = new System.Drawing.Size(20, 17);
            this.lbGenLoc.TabIndex = 1;
            this.lbGenLoc.Text = "列";
            // 
            // lbGenTier
            // 
            this.lbGenTier.AutoSize = true;
            this.lbGenTier.Location = new System.Drawing.Point(208, 27);
            this.lbGenTier.Name = "lbGenTier";
            this.lbGenTier.Size = new System.Drawing.Size(20, 17);
            this.lbGenTier.TabIndex = 1;
            this.lbGenTier.Text = "层";
            // 
            // lbShelf
            // 
            this.lbShelf.AutoSize = true;
            this.lbShelf.Location = new System.Drawing.Point(146, 27);
            this.lbShelf.Name = "lbShelf";
            this.lbShelf.Size = new System.Drawing.Size(32, 17);
            this.lbShelf.TabIndex = 1;
            this.lbShelf.Text = "货架";
            // 
            // lbLaneToGen
            // 
            this.lbLaneToGen.AutoSize = true;
            this.lbLaneToGen.Location = new System.Drawing.Point(266, 415);
            this.lbLaneToGen.Name = "lbLaneToGen";
            this.lbLaneToGen.Size = new System.Drawing.Size(96, 17);
            this.lbLaneToGen.TabIndex = 1;
            this.lbLaneToGen.Text = "待增加货架 预览";
            // 
            // lbMessage
            // 
            this.lbMessage.ForeColor = System.Drawing.Color.Navy;
            this.lbMessage.Location = new System.Drawing.Point(194, 201);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(195, 35);
            this.lbMessage.TabIndex = 1;
            this.lbMessage.Text = "msg";
            // 
            // lbShelfToGen
            // 
            this.lbShelfToGen.AutoSize = true;
            this.lbShelfToGen.Location = new System.Drawing.Point(266, 245);
            this.lbShelfToGen.Name = "lbShelfToGen";
            this.lbShelfToGen.Size = new System.Drawing.Size(96, 17);
            this.lbShelfToGen.TabIndex = 1;
            this.lbShelfToGen.Text = "待增加货架 预览";
            // 
            // lbLocaitonToGen
            // 
            this.lbLocaitonToGen.AutoSize = true;
            this.lbLocaitonToGen.Location = new System.Drawing.Point(46, 245);
            this.lbLocaitonToGen.Name = "lbLocaitonToGen";
            this.lbLocaitonToGen.Size = new System.Drawing.Size(96, 17);
            this.lbLocaitonToGen.TabIndex = 1;
            this.lbLocaitonToGen.Text = "待增加货位 预览";
            // 
            // lbToInsertLocCount
            // 
            this.lbToInsertLocCount.AutoSize = true;
            this.lbToInsertLocCount.Location = new System.Drawing.Point(173, 245);
            this.lbToInsertLocCount.Name = "lbToInsertLocCount";
            this.lbToInsertLocCount.Size = new System.Drawing.Size(15, 17);
            this.lbToInsertLocCount.TabIndex = 1;
            this.lbToInsertLocCount.Text = "0";
            // 
            // lbLane
            // 
            this.lbLane.AutoSize = true;
            this.lbLane.Location = new System.Drawing.Point(84, 27);
            this.lbLane.Name = "lbLane";
            this.lbLane.Size = new System.Drawing.Size(32, 17);
            this.lbLane.TabIndex = 1;
            this.lbLane.Text = "通道";
            // 
            // lbLaneOrder
            // 
            this.lbLaneOrder.AutoSize = true;
            this.lbLaneOrder.Location = new System.Drawing.Point(102, 140);
            this.lbLaneOrder.Name = "lbLaneOrder";
            this.lbLaneOrder.Size = new System.Drawing.Size(93, 17);
            this.lbLaneOrder.TabIndex = 1;
            this.lbLaneOrder.Text = "排序(递增/递减)";
            // 
            // lbLaneDirection
            // 
            this.lbLaneDirection.AutoSize = true;
            this.lbLaneDirection.Location = new System.Drawing.Point(46, 140);
            this.lbLaneDirection.Name = "lbLaneDirection";
            this.lbLaneDirection.Size = new System.Drawing.Size(32, 17);
            this.lbLaneDirection.TabIndex = 1;
            this.lbLaneDirection.Text = "方向";
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.Location = new System.Drawing.Point(46, 27);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(20, 17);
            this.lbArea.TabIndex = 1;
            this.lbArea.Text = "区";
            // 
            // tbShelfNoEnd
            // 
            this.tbShelfNoEnd.Location = new System.Drawing.Point(149, 91);
            this.tbShelfNoEnd.Name = "tbShelfNoEnd";
            this.tbShelfNoEnd.Size = new System.Drawing.Size(39, 23);
            this.tbShelfNoEnd.TabIndex = 4;
            this.tbShelfNoEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbGenLocCount
            // 
            this.tbGenLocCount.Location = new System.Drawing.Point(265, 47);
            this.tbGenLocCount.Name = "tbGenLocCount";
            this.tbGenLocCount.Size = new System.Drawing.Size(30, 23);
            this.tbGenLocCount.TabIndex = 6;
            this.tbGenLocCount.Text = "1";
            this.tbGenLocCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbGenTierCount
            // 
            this.tbGenTierCount.Location = new System.Drawing.Point(211, 47);
            this.tbGenTierCount.Name = "tbGenTierCount";
            this.tbGenTierCount.Size = new System.Drawing.Size(30, 23);
            this.tbGenTierCount.TabIndex = 5;
            this.tbGenTierCount.Text = "1";
            this.tbGenTierCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbShelfNoStart
            // 
            this.tbShelfNoStart.Location = new System.Drawing.Point(149, 47);
            this.tbShelfNoStart.Name = "tbShelfNoStart";
            this.tbShelfNoStart.Size = new System.Drawing.Size(39, 23);
            this.tbShelfNoStart.TabIndex = 3;
            this.tbShelfNoStart.TabStop = false;
            this.tbShelfNoStart.Text = "1";
            this.tbShelfNoStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbLaneNoEnd
            // 
            this.tbLaneNoEnd.Location = new System.Drawing.Point(87, 91);
            this.tbLaneNoEnd.Name = "tbLaneNoEnd";
            this.tbLaneNoEnd.Size = new System.Drawing.Size(39, 23);
            this.tbLaneNoEnd.TabIndex = 2;
            this.tbLaneNoEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbLaneNoStart
            // 
            this.tbLaneNoStart.Location = new System.Drawing.Point(87, 47);
            this.tbLaneNoStart.Name = "tbLaneNoStart";
            this.tbLaneNoStart.Size = new System.Drawing.Size(39, 23);
            this.tbLaneNoStart.TabIndex = 1;
            this.tbLaneNoStart.TabStop = false;
            this.tbLaneNoStart.Text = "1";
            this.tbLaneNoStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbAreaNo
            // 
            this.tbAreaNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbAreaNo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbAreaNo.ForeColor = System.Drawing.Color.Yellow;
            this.tbAreaNo.Location = new System.Drawing.Point(46, 47);
            this.tbAreaNo.Name = "tbAreaNo";
            this.tbAreaNo.ReadOnly = true;
            this.tbAreaNo.Size = new System.Drawing.Size(39, 23);
            this.tbAreaNo.TabIndex = 0;
            this.tbAreaNo.TabStop = false;
            this.tbAreaNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormLaneMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 611);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.splitterBottom);
            this.Controls.Add(this.splitterTop);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTopTitle);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLaneMgt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormLaneMgt";
            this.Load += new System.EventHandler(this.FormLaneMgt_Load);
            this.pnlTopTitle.ResumeLayout(false);
            this.pnlTopTitle.PerformLayout();
            this.pnlTitleNo.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopTitle;
        private System.Windows.Forms.Panel pnlTitleNo;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Splitter splitterTop;
        private System.Windows.Forms.Splitter splitterBottom;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lbYVal;
        private System.Windows.Forms.Label lbYTip;
        private System.Windows.Forms.Label lbXVal;
        private System.Windows.Forms.Label lbXTip;
        private System.Windows.Forms.Label lbTipAreaNo;
        private System.Windows.Forms.Label lbTitleDesc;
        private System.Windows.Forms.Label lbLane;
        private System.Windows.Forms.Label lbArea;
        private System.Windows.Forms.TextBox tbLaneNoStart;
        private System.Windows.Forms.TextBox tbAreaNo;
        private System.Windows.Forms.Label lbS1;
        private System.Windows.Forms.Label lbTo1;
        private System.Windows.Forms.Label lbFrom1;
        private System.Windows.Forms.TextBox tbLaneNoEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTo2;
        private System.Windows.Forms.Label lbFrom2;
        private System.Windows.Forms.Label lbGenTier;
        private System.Windows.Forms.Label lbShelf;
        private System.Windows.Forms.TextBox tbShelfNoEnd;
        private System.Windows.Forms.TextBox tbGenTierCount;
        private System.Windows.Forms.TextBox tbShelfNoStart;
        private System.Windows.Forms.Label lbMultiply;
        private System.Windows.Forms.Label lbGenLoc;
        private System.Windows.Forms.TextBox tbGenLocCount;
        private System.Windows.Forms.Button btnGenLocationNo;
        private System.Windows.Forms.Label lbStorageType;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ListBox lstboxShelfNos;
        private System.Windows.Forms.ListBox lstboxLocationNos;
        private System.Windows.Forms.Label lbShelfToGen;
        private System.Windows.Forms.Label lbLocaitonToGen;
        private System.Windows.Forms.Label lbToInsertLocCount;
        private System.Windows.Forms.ComboBox cbLaneOrder;
        private System.Windows.Forms.ComboBox cbOddEven;
        private System.Windows.Forms.ComboBox cbLaneDirection;
        private System.Windows.Forms.Label lbLaneOrder;
        private System.Windows.Forms.Label lbLaneDirection;
        private System.Windows.Forms.ComboBox cbStorageType;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.ListBox lstboxLaneNos;
        private System.Windows.Forms.Label lbLaneToGen;
        private System.Windows.Forms.CheckBox cbGenRule;
    }
}