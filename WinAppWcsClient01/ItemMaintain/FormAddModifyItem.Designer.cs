namespace WinAppWmsLite.ItemMaintain
{
    partial class FormAddModifyItem
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
            this.lbCustomerId = new System.Windows.Forms.Label();
            this.cbCustomeId = new System.Windows.Forms.ComboBox();
            this.tbItemDesc = new System.Windows.Forms.TextBox();
            this.lbItemDesc = new System.Windows.Forms.Label();
            this.tbProductNo = new System.Windows.Forms.TextBox();
            this.lbProductNo = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lbPrintCount = new System.Windows.Forms.Label();
            this.lbTitleDesc = new System.Windows.Forms.Label();
            this.splitterBottom = new System.Windows.Forms.Splitter();
            this.splitterTop = new System.Windows.Forms.Splitter();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.tbPrintCount = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnInsertUpdateItem = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnCopyProductNo = new System.Windows.Forms.Button();
            this.tbItemBarcode = new System.Windows.Forms.TextBox();
            this.cbxIsGenSn = new System.Windows.Forms.CheckBox();
            this.pnlPrint = new System.Windows.Forms.Panel();
            this.pntItemDesc = new System.Windows.Forms.Label();
            this.pntItemNo = new System.Windows.Forms.Label();
            this.pntSnNo = new System.Windows.Forms.Label();
            this.pntBarcode = new System.Windows.Forms.Label();
            this.pntProductNo = new System.Windows.Forms.Label();
            this.pbSnNo = new System.Windows.Forms.PictureBox();
            this.pbItemNo = new System.Windows.Forms.PictureBox();
            this.pbBarcode = new System.Windows.Forms.PictureBox();
            this.pbDmProductNo = new System.Windows.Forms.PictureBox();
            this.pbProductNo = new System.Windows.Forms.PictureBox();
            this.tbLogs = new System.Windows.Forms.TextBox();
            this.cbPrinter = new System.Windows.Forms.ComboBox();
            this.lbSelectPrinter = new System.Windows.Forms.Label();
            this.tbRemarkDesc = new System.Windows.Forms.TextBox();
            this.lbRemarkDesc = new System.Windows.Forms.Label();
            this.tbItemNo = new System.Windows.Forms.TextBox();
            this.lbItemNo = new System.Windows.Forms.Label();
            this.lbItemBarcode = new System.Windows.Forms.Label();
            this.tbSnNo = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnlTitleNo = new System.Windows.Forms.Panel();
            this.pnlTopTitle = new System.Windows.Forms.Panel();
            this.pnlStatus.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDmProductNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductNo)).BeginInit();
            this.pnlTitleNo.SuspendLayout();
            this.pnlTopTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCustomerId
            // 
            this.lbCustomerId.AutoSize = true;
            this.lbCustomerId.Location = new System.Drawing.Point(339, 47);
            this.lbCustomerId.Name = "lbCustomerId";
            this.lbCustomerId.Size = new System.Drawing.Size(32, 17);
            this.lbCustomerId.TabIndex = 15;
            this.lbCustomerId.Text = "客户";
            // 
            // cbCustomeId
            // 
            this.cbCustomeId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbCustomeId.FormattingEnabled = true;
            this.cbCustomeId.Location = new System.Drawing.Point(380, 44);
            this.cbCustomeId.Name = "cbCustomeId";
            this.cbCustomeId.Size = new System.Drawing.Size(170, 25);
            this.cbCustomeId.TabIndex = 98;
            // 
            // tbItemDesc
            // 
            this.tbItemDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbItemDesc.Location = new System.Drawing.Point(117, 123);
            this.tbItemDesc.MaxLength = 80;
            this.tbItemDesc.Multiline = true;
            this.tbItemDesc.Name = "tbItemDesc";
            this.tbItemDesc.Size = new System.Drawing.Size(433, 70);
            this.tbItemDesc.TabIndex = 2;
            // 
            // lbItemDesc
            // 
            this.lbItemDesc.AutoSize = true;
            this.lbItemDesc.Location = new System.Drawing.Point(26, 126);
            this.lbItemDesc.Name = "lbItemDesc";
            this.lbItemDesc.Size = new System.Drawing.Size(32, 17);
            this.lbItemDesc.TabIndex = 0;
            this.lbItemDesc.Text = "描述";
            // 
            // tbProductNo
            // 
            this.tbProductNo.Location = new System.Drawing.Point(117, 15);
            this.tbProductNo.Name = "tbProductNo";
            this.tbProductNo.ReadOnly = true;
            this.tbProductNo.Size = new System.Drawing.Size(154, 23);
            this.tbProductNo.TabIndex = 99;
            // 
            // lbProductNo
            // 
            this.lbProductNo.AutoSize = true;
            this.lbProductNo.Location = new System.Drawing.Point(26, 18);
            this.lbProductNo.Name = "lbProductNo";
            this.lbProductNo.Size = new System.Drawing.Size(56, 17);
            this.lbProductNo.TabIndex = 0;
            this.lbProductNo.Text = "产品编号";
            // 
            // lbMessage
            // 
            this.lbMessage.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbMessage.ForeColor = System.Drawing.Color.Red;
            this.lbMessage.Location = new System.Drawing.Point(0, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(168, 35);
            this.lbMessage.TabIndex = 0;
            this.lbMessage.Text = "...";
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.lbPrintCount);
            this.pnlStatus.Controls.Add(this.lbMessage);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatus.Location = new System.Drawing.Point(160, 0);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(264, 35);
            this.pnlStatus.TabIndex = 9;
            // 
            // lbPrintCount
            // 
            this.lbPrintCount.AutoSize = true;
            this.lbPrintCount.Location = new System.Drawing.Point(174, 9);
            this.lbPrintCount.Name = "lbPrintCount";
            this.lbPrintCount.Size = new System.Drawing.Size(32, 17);
            this.lbPrintCount.TabIndex = 1;
            this.lbPrintCount.Text = "份数";
            // 
            // lbTitleDesc
            // 
            this.lbTitleDesc.AutoSize = true;
            this.lbTitleDesc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitleDesc.Location = new System.Drawing.Point(62, 12);
            this.lbTitleDesc.Name = "lbTitleDesc";
            this.lbTitleDesc.Size = new System.Drawing.Size(86, 17);
            this.lbTitleDesc.TabIndex = 4;
            this.lbTitleDesc.Text = "添加/修改产品";
            // 
            // splitterBottom
            // 
            this.splitterBottom.BackColor = System.Drawing.Color.Navy;
            this.splitterBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterBottom.Location = new System.Drawing.Point(0, 625);
            this.splitterBottom.Name = "splitterBottom";
            this.splitterBottom.Size = new System.Drawing.Size(584, 1);
            this.splitterBottom.TabIndex = 21;
            this.splitterBottom.TabStop = false;
            // 
            // splitterTop
            // 
            this.splitterTop.BackColor = System.Drawing.Color.Navy;
            this.splitterTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterTop.Location = new System.Drawing.Point(0, 40);
            this.splitterTop.Name = "splitterTop";
            this.splitterTop.Size = new System.Drawing.Size(584, 1);
            this.splitterTop.TabIndex = 20;
            this.splitterTop.TabStop = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.tbPrintCount);
            this.pnlBottom.Controls.Add(this.pnlStatus);
            this.pnlBottom.Controls.Add(this.btnPrint);
            this.pnlBottom.Controls.Add(this.btnInsertUpdateItem);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 626);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(584, 35);
            this.pnlBottom.TabIndex = 19;
            // 
            // tbPrintCount
            // 
            this.tbPrintCount.Location = new System.Drawing.Point(372, 6);
            this.tbPrintCount.Name = "tbPrintCount";
            this.tbPrintCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPrintCount.Size = new System.Drawing.Size(46, 23);
            this.tbPrintCount.TabIndex = 5;
            this.tbPrintCount.Text = "1";
            this.tbPrintCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrint.Location = new System.Drawing.Point(424, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(160, 35);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "打印";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnInsertUpdateItem
            // 
            this.btnInsertUpdateItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInsertUpdateItem.Location = new System.Drawing.Point(0, 0);
            this.btnInsertUpdateItem.Name = "btnInsertUpdateItem";
            this.btnInsertUpdateItem.Size = new System.Drawing.Size(160, 35);
            this.btnInsertUpdateItem.TabIndex = 3;
            this.btnInsertUpdateItem.Text = "保存产品";
            this.btnInsertUpdateItem.UseVisualStyleBackColor = true;
            this.btnInsertUpdateItem.Click += new System.EventHandler(this.btnInsertUpdateItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMain.Controls.Add(this.btnCopyProductNo);
            this.pnlMain.Controls.Add(this.tbProductNo);
            this.pnlMain.Controls.Add(this.tbItemBarcode);
            this.pnlMain.Controls.Add(this.cbxIsGenSn);
            this.pnlMain.Controls.Add(this.pnlPrint);
            this.pnlMain.Controls.Add(this.tbLogs);
            this.pnlMain.Controls.Add(this.cbPrinter);
            this.pnlMain.Controls.Add(this.cbCustomeId);
            this.pnlMain.Controls.Add(this.lbSelectPrinter);
            this.pnlMain.Controls.Add(this.lbCustomerId);
            this.pnlMain.Controls.Add(this.tbRemarkDesc);
            this.pnlMain.Controls.Add(this.lbRemarkDesc);
            this.pnlMain.Controls.Add(this.tbItemDesc);
            this.pnlMain.Controls.Add(this.lbItemDesc);
            this.pnlMain.Controls.Add(this.tbItemNo);
            this.pnlMain.Controls.Add(this.lbItemNo);
            this.pnlMain.Controls.Add(this.lbItemBarcode);
            this.pnlMain.Controls.Add(this.tbSnNo);
            this.pnlMain.Controls.Add(this.lbProductNo);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 40);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(584, 621);
            this.pnlMain.TabIndex = 1;
            this.pnlMain.TabStop = true;
            // 
            // btnCopyProductNo
            // 
            this.btnCopyProductNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyProductNo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCopyProductNo.Location = new System.Drawing.Point(233, 43);
            this.btnCopyProductNo.Name = "btnCopyProductNo";
            this.btnCopyProductNo.Size = new System.Drawing.Size(72, 25);
            this.btnCopyProductNo.TabIndex = 105;
            this.btnCopyProductNo.Text = "复制编号";
            this.btnCopyProductNo.UseVisualStyleBackColor = true;
            this.btnCopyProductNo.Click += new System.EventHandler(this.btnCopyProductNo_Click);
            // 
            // tbItemBarcode
            // 
            this.tbItemBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbItemBarcode.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.tbItemBarcode.Location = new System.Drawing.Point(117, 44);
            this.tbItemBarcode.Name = "tbItemBarcode";
            this.tbItemBarcode.Size = new System.Drawing.Size(115, 23);
            this.tbItemBarcode.TabIndex = 1;
            this.tbItemBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbItemBarcode_KeyDown);
            // 
            // cbxIsGenSn
            // 
            this.cbxIsGenSn.AutoSize = true;
            this.cbxIsGenSn.Location = new System.Drawing.Point(309, 16);
            this.cbxIsGenSn.Name = "cbxIsGenSn";
            this.cbxIsGenSn.Size = new System.Drawing.Size(65, 21);
            this.cbxIsGenSn.TabIndex = 104;
            this.cbxIsGenSn.Text = "生成Sn";
            this.cbxIsGenSn.UseVisualStyleBackColor = true;
            this.cbxIsGenSn.CheckedChanged += new System.EventHandler(this.cbxIsGenSn_CheckedChanged);
            // 
            // pnlPrint
            // 
            this.pnlPrint.BackColor = System.Drawing.Color.White;
            this.pnlPrint.Controls.Add(this.pntItemDesc);
            this.pnlPrint.Controls.Add(this.pntItemNo);
            this.pnlPrint.Controls.Add(this.pntSnNo);
            this.pnlPrint.Controls.Add(this.pntBarcode);
            this.pnlPrint.Controls.Add(this.pntProductNo);
            this.pnlPrint.Controls.Add(this.pbSnNo);
            this.pnlPrint.Controls.Add(this.pbItemNo);
            this.pnlPrint.Controls.Add(this.pbBarcode);
            this.pnlPrint.Controls.Add(this.pbDmProductNo);
            this.pnlPrint.Controls.Add(this.pbProductNo);
            this.pnlPrint.Location = new System.Drawing.Point(29, 316);
            this.pnlPrint.Name = "pnlPrint";
            this.pnlPrint.Size = new System.Drawing.Size(467, 245);
            this.pnlPrint.TabIndex = 103;
            // 
            // pntItemDesc
            // 
            this.pntItemDesc.Location = new System.Drawing.Point(9, 56);
            this.pntItemDesc.Name = "pntItemDesc";
            this.pntItemDesc.Size = new System.Drawing.Size(104, 35);
            this.pntItemDesc.TabIndex = 102;
            this.pntItemDesc.Text = "pntItemDesc";
            // 
            // pntItemNo
            // 
            this.pntItemNo.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pntItemNo.Location = new System.Drawing.Point(9, 127);
            this.pntItemNo.Name = "pntItemNo";
            this.pntItemNo.Size = new System.Drawing.Size(47, 19);
            this.pntItemNo.TabIndex = 102;
            this.pntItemNo.Text = "pntItemNo";
            // 
            // pntSnNo
            // 
            this.pntSnNo.AutoSize = true;
            this.pntSnNo.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pntSnNo.Location = new System.Drawing.Point(9, 116);
            this.pntSnNo.Name = "pntSnNo";
            this.pntSnNo.Size = new System.Drawing.Size(50, 16);
            this.pntSnNo.TabIndex = 102;
            this.pntSnNo.Text = "pntSnNo";
            // 
            // pntBarcode
            // 
            this.pntBarcode.AutoSize = true;
            this.pntBarcode.Location = new System.Drawing.Point(9, 40);
            this.pntBarcode.Name = "pntBarcode";
            this.pntBarcode.Size = new System.Drawing.Size(76, 17);
            this.pntBarcode.TabIndex = 102;
            this.pntBarcode.Text = "pntBarcode";
            // 
            // pntProductNo
            // 
            this.pntProductNo.AutoSize = true;
            this.pntProductNo.Location = new System.Drawing.Point(120, 123);
            this.pntProductNo.Name = "pntProductNo";
            this.pntProductNo.Size = new System.Drawing.Size(90, 17);
            this.pntProductNo.TabIndex = 102;
            this.pntProductNo.Text = "pntProductNo";
            // 
            // pbSnNo
            // 
            this.pbSnNo.BackColor = System.Drawing.Color.White;
            this.pbSnNo.Location = new System.Drawing.Point(9, 95);
            this.pbSnNo.Name = "pbSnNo";
            this.pbSnNo.Size = new System.Drawing.Size(104, 20);
            this.pbSnNo.TabIndex = 101;
            this.pbSnNo.TabStop = false;
            // 
            // pbItemNo
            // 
            this.pbItemNo.BackColor = System.Drawing.Color.White;
            this.pbItemNo.Location = new System.Drawing.Point(23, 202);
            this.pbItemNo.Name = "pbItemNo";
            this.pbItemNo.Size = new System.Drawing.Size(200, 40);
            this.pbItemNo.TabIndex = 101;
            this.pbItemNo.TabStop = false;
            // 
            // pbBarcode
            // 
            this.pbBarcode.Location = new System.Drawing.Point(9, 9);
            this.pbBarcode.Name = "pbBarcode";
            this.pbBarcode.Size = new System.Drawing.Size(123, 30);
            this.pbBarcode.TabIndex = 101;
            this.pbBarcode.TabStop = false;
            // 
            // pbDmProductNo
            // 
            this.pbDmProductNo.Location = new System.Drawing.Point(120, 43);
            this.pbDmProductNo.Name = "pbDmProductNo";
            this.pbDmProductNo.Size = new System.Drawing.Size(80, 80);
            this.pbDmProductNo.TabIndex = 101;
            this.pbDmProductNo.TabStop = false;
            // 
            // pbProductNo
            // 
            this.pbProductNo.Location = new System.Drawing.Point(243, 202);
            this.pbProductNo.Name = "pbProductNo";
            this.pbProductNo.Size = new System.Drawing.Size(200, 40);
            this.pbProductNo.TabIndex = 101;
            this.pbProductNo.TabStop = false;
            // 
            // tbLogs
            // 
            this.tbLogs.Location = new System.Drawing.Point(117, 228);
            this.tbLogs.Multiline = true;
            this.tbLogs.Name = "tbLogs";
            this.tbLogs.Size = new System.Drawing.Size(154, 82);
            this.tbLogs.TabIndex = 102;
            // 
            // cbPrinter
            // 
            this.cbPrinter.FormattingEnabled = true;
            this.cbPrinter.Location = new System.Drawing.Point(372, 249);
            this.cbPrinter.Name = "cbPrinter";
            this.cbPrinter.Size = new System.Drawing.Size(178, 25);
            this.cbPrinter.TabIndex = 100;
            // 
            // lbSelectPrinter
            // 
            this.lbSelectPrinter.AutoSize = true;
            this.lbSelectPrinter.Location = new System.Drawing.Point(319, 253);
            this.lbSelectPrinter.Name = "lbSelectPrinter";
            this.lbSelectPrinter.Size = new System.Drawing.Size(44, 17);
            this.lbSelectPrinter.TabIndex = 15;
            this.lbSelectPrinter.Text = "打印机";
            // 
            // tbRemarkDesc
            // 
            this.tbRemarkDesc.Location = new System.Drawing.Point(117, 199);
            this.tbRemarkDesc.MaxLength = 80;
            this.tbRemarkDesc.Name = "tbRemarkDesc";
            this.tbRemarkDesc.Size = new System.Drawing.Size(433, 23);
            this.tbRemarkDesc.TabIndex = 4;
            // 
            // lbRemarkDesc
            // 
            this.lbRemarkDesc.AutoSize = true;
            this.lbRemarkDesc.Location = new System.Drawing.Point(26, 202);
            this.lbRemarkDesc.Name = "lbRemarkDesc";
            this.lbRemarkDesc.Size = new System.Drawing.Size(32, 17);
            this.lbRemarkDesc.TabIndex = 0;
            this.lbRemarkDesc.Text = "备注";
            // 
            // tbItemNo
            // 
            this.tbItemNo.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.tbItemNo.Location = new System.Drawing.Point(117, 94);
            this.tbItemNo.Name = "tbItemNo";
            this.tbItemNo.Size = new System.Drawing.Size(154, 23);
            this.tbItemNo.TabIndex = 5;
            // 
            // lbItemNo
            // 
            this.lbItemNo.AutoSize = true;
            this.lbItemNo.Location = new System.Drawing.Point(26, 97);
            this.lbItemNo.Name = "lbItemNo";
            this.lbItemNo.Size = new System.Drawing.Size(80, 17);
            this.lbItemNo.TabIndex = 0;
            this.lbItemNo.Text = "自定义产品号";
            // 
            // lbItemBarcode
            // 
            this.lbItemBarcode.AutoSize = true;
            this.lbItemBarcode.Location = new System.Drawing.Point(26, 47);
            this.lbItemBarcode.Name = "lbItemBarcode";
            this.lbItemBarcode.Size = new System.Drawing.Size(32, 17);
            this.lbItemBarcode.TabIndex = 0;
            this.lbItemBarcode.Text = "条码";
            // 
            // tbSnNo
            // 
            this.tbSnNo.Location = new System.Drawing.Point(380, 15);
            this.tbSnNo.Name = "tbSnNo";
            this.tbSnNo.ReadOnly = true;
            this.tbSnNo.Size = new System.Drawing.Size(170, 23);
            this.tbSnNo.TabIndex = 99;
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
            this.lbTitle.Text = "IM01";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // pnlTopTitle
            // 
            this.pnlTopTitle.Controls.Add(this.lbTitleDesc);
            this.pnlTopTitle.Controls.Add(this.pnlTitleNo);
            this.pnlTopTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTopTitle.Name = "pnlTopTitle";
            this.pnlTopTitle.Size = new System.Drawing.Size(584, 40);
            this.pnlTopTitle.TabIndex = 18;
            // 
            // FormAddModifyItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.splitterBottom);
            this.Controls.Add(this.splitterTop);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTopTitle);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAddModifyItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddModifyItem";
            this.Load += new System.EventHandler(this.FormAddModifyItem_Load);
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlPrint.ResumeLayout(false);
            this.pnlPrint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDmProductNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductNo)).EndInit();
            this.pnlTitleNo.ResumeLayout(false);
            this.pnlTopTitle.ResumeLayout(false);
            this.pnlTopTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbCustomerId;
        private System.Windows.Forms.ComboBox cbCustomeId;
        private System.Windows.Forms.TextBox tbItemDesc;
        private System.Windows.Forms.Label lbItemDesc;
        private System.Windows.Forms.TextBox tbProductNo;
        private System.Windows.Forms.Label lbProductNo;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lbTitleDesc;
        private System.Windows.Forms.Splitter splitterBottom;
        private System.Windows.Forms.Splitter splitterTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnInsertUpdateItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnlTitleNo;
        private System.Windows.Forms.Panel pnlTopTitle;
        private System.Windows.Forms.TextBox tbItemBarcode;
        private System.Windows.Forms.Label lbItemBarcode;
        private System.Windows.Forms.TextBox tbItemNo;
        private System.Windows.Forms.Label lbItemNo;
        private System.Windows.Forms.TextBox tbRemarkDesc;
        private System.Windows.Forms.Label lbRemarkDesc;
        private System.Windows.Forms.Label lbPrintCount;
        private System.Windows.Forms.TextBox tbPrintCount;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cbPrinter;
        private System.Windows.Forms.Label lbSelectPrinter;
        private System.Windows.Forms.PictureBox pbItemNo;
        private System.Windows.Forms.PictureBox pbBarcode;
        private System.Windows.Forms.PictureBox pbProductNo;
        private System.Windows.Forms.PictureBox pbDmProductNo;
        private System.Windows.Forms.TextBox tbLogs;
        private System.Windows.Forms.Panel pnlPrint;
        private System.Windows.Forms.CheckBox cbxIsGenSn;
        private System.Windows.Forms.TextBox tbSnNo;
        private System.Windows.Forms.PictureBox pbSnNo;
        private System.Windows.Forms.Label pntSnNo;
        private System.Windows.Forms.Label pntBarcode;
        private System.Windows.Forms.Label pntProductNo;
        private System.Windows.Forms.Label pntItemDesc;
        private System.Windows.Forms.Label pntItemNo;
        private System.Windows.Forms.Button btnCopyProductNo;
    }
}