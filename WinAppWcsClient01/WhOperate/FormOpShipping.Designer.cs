namespace WinAppWmsLite.WhOperate
{
    partial class FormOpShipping
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbPoNo = new System.Windows.Forms.Label();
            this.rbSn = new System.Windows.Forms.RadioButton();
            this.tbProductNo = new System.Windows.Forms.TextBox();
            this.lbContainerNo = new System.Windows.Forms.Label();
            this.cbUomId = new System.Windows.Forms.ComboBox();
            this.lbQty = new System.Windows.Forms.Label();
            this.lbUom = new System.Windows.Forms.Label();
            this.tbContainerNo = new System.Windows.Forms.TextBox();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.lbItemNoBarcode = new System.Windows.Forms.Label();
            this.gvListItem = new System.Windows.Forms.DataGridView();
            this.col_product_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_customer_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvListIoLogs = new System.Windows.Forms.DataGridView();
            this.colIoTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIndexNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContainerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbLot = new System.Windows.Forms.RadioButton();
            this.tbLotSn = new System.Windows.Forms.TextBox();
            this.splitterBottom = new System.Windows.Forms.Splitter();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lbMessage = new System.Windows.Forms.Label();
            this.cbCustomeId = new System.Windows.Forms.ComboBox();
            this.lbCustomerNo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearInput = new System.Windows.Forms.Button();
            this.btnInsertShippingItem = new System.Windows.Forms.Button();
            this.btnSaveCommit = new System.Windows.Forms.Button();
            this.tbSoNo = new System.Windows.Forms.TextBox();
            this.lbItemDesc = new System.Windows.Forms.Label();
            this.pnlTopTitle = new System.Windows.Forms.Panel();
            this.lbTitleDesc = new System.Windows.Forms.Label();
            this.pnlTitleNo = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.cbInputSnLot = new System.Windows.Forms.CheckBox();
            this.pnlLotSn = new System.Windows.Forms.Panel();
            this.splitterTop = new System.Windows.Forms.Splitter();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvListItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListIoLogs)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTopTitle.SuspendLayout();
            this.pnlTitleNo.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlLotSn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPoNo
            // 
            this.lbPoNo.AutoSize = true;
            this.lbPoNo.Location = new System.Drawing.Point(29, 19);
            this.lbPoNo.Name = "lbPoNo";
            this.lbPoNo.Size = new System.Drawing.Size(56, 17);
            this.lbPoNo.TabIndex = 100;
            this.lbPoNo.Text = "出库单号";
            // 
            // rbSn
            // 
            this.rbSn.AutoSize = true;
            this.rbSn.Location = new System.Drawing.Point(87, 8);
            this.rbSn.Name = "rbSn";
            this.rbSn.Size = new System.Drawing.Size(52, 21);
            this.rbSn.TabIndex = 2;
            this.rbSn.Text = "Sn：";
            this.rbSn.UseVisualStyleBackColor = true;
            // 
            // tbProductNo
            // 
            this.tbProductNo.Location = new System.Drawing.Point(273, 55);
            this.tbProductNo.Name = "tbProductNo";
            this.tbProductNo.ReadOnly = true;
            this.tbProductNo.Size = new System.Drawing.Size(90, 23);
            this.tbProductNo.TabIndex = 101;
            // 
            // lbContainerNo
            // 
            this.lbContainerNo.AutoSize = true;
            this.lbContainerNo.Location = new System.Drawing.Point(93, 155);
            this.lbContainerNo.Name = "lbContainerNo";
            this.lbContainerNo.Size = new System.Drawing.Size(44, 17);
            this.lbContainerNo.TabIndex = 100;
            this.lbContainerNo.Text = "容器号";
            // 
            // cbUomId
            // 
            this.cbUomId.FormattingEnabled = true;
            this.cbUomId.Location = new System.Drawing.Point(481, 54);
            this.cbUomId.Name = "cbUomId";
            this.cbUomId.Size = new System.Drawing.Size(46, 25);
            this.cbUomId.TabIndex = 16;
            // 
            // lbQty
            // 
            this.lbQty.AutoSize = true;
            this.lbQty.Location = new System.Drawing.Point(369, 58);
            this.lbQty.Name = "lbQty";
            this.lbQty.Size = new System.Drawing.Size(14, 17);
            this.lbQty.TabIndex = 15;
            this.lbQty.Text = "x";
            // 
            // lbUom
            // 
            this.lbUom.AutoSize = true;
            this.lbUom.Location = new System.Drawing.Point(445, 58);
            this.lbUom.Name = "lbUom";
            this.lbUom.Size = new System.Drawing.Size(32, 17);
            this.lbUom.TabIndex = 15;
            this.lbUom.Text = "单位";
            // 
            // tbContainerNo
            // 
            this.tbContainerNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbContainerNo.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.tbContainerNo.Location = new System.Drawing.Point(150, 152);
            this.tbContainerNo.MaxLength = 20;
            this.tbContainerNo.Name = "tbContainerNo";
            this.tbContainerNo.Size = new System.Drawing.Size(120, 23);
            this.tbContainerNo.TabIndex = 2;
            // 
            // tbBarcode
            // 
            this.tbBarcode.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.tbBarcode.Location = new System.Drawing.Point(150, 55);
            this.tbBarcode.MaxLength = 20;
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(120, 23);
            this.tbBarcode.TabIndex = 0;
            this.tbBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBarcode_KeyDown);
            // 
            // lbItemNoBarcode
            // 
            this.lbItemNoBarcode.AutoSize = true;
            this.lbItemNoBarcode.Location = new System.Drawing.Point(29, 58);
            this.lbItemNoBarcode.Name = "lbItemNoBarcode";
            this.lbItemNoBarcode.Size = new System.Drawing.Size(108, 17);
            this.lbItemNoBarcode.TabIndex = 0;
            this.lbItemNoBarcode.Text = "产品(号)条码  数量";
            // 
            // gvListItem
            // 
            this.gvListItem.AllowUserToAddRows = false;
            this.gvListItem.AllowUserToDeleteRows = false;
            this.gvListItem.AllowUserToOrderColumns = true;
            this.gvListItem.ColumnHeadersHeight = 30;
            this.gvListItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_product_no,
            this.col_item_no,
            this.col_item_barcode,
            this.col_item_desc,
            this.col_customer_desc});
            this.gvListItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvListItem.Location = new System.Drawing.Point(0, 266);
            this.gvListItem.Name = "gvListItem";
            this.gvListItem.ReadOnly = true;
            this.gvListItem.RowHeadersWidth = 20;
            this.gvListItem.RowTemplate.Height = 23;
            this.gvListItem.Size = new System.Drawing.Size(424, 259);
            this.gvListItem.TabIndex = 30;
            // 
            // col_product_no
            // 
            this.col_product_no.DataPropertyName = "product_no";
            this.col_product_no.HeaderText = "产品号";
            this.col_product_no.Name = "col_product_no";
            this.col_product_no.ReadOnly = true;
            this.col_product_no.Width = 80;
            // 
            // col_item_no
            // 
            this.col_item_no.DataPropertyName = "item_no";
            this.col_item_no.HeaderText = "产品编码";
            this.col_item_no.Name = "col_item_no";
            this.col_item_no.ReadOnly = true;
            // 
            // col_item_barcode
            // 
            this.col_item_barcode.DataPropertyName = "item_barcode";
            this.col_item_barcode.HeaderText = "产品条码";
            this.col_item_barcode.Name = "col_item_barcode";
            this.col_item_barcode.ReadOnly = true;
            this.col_item_barcode.Width = 110;
            // 
            // col_item_desc
            // 
            this.col_item_desc.DataPropertyName = "item_desc";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.col_item_desc.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_item_desc.HeaderText = "产品描述";
            this.col_item_desc.Name = "col_item_desc";
            this.col_item_desc.ReadOnly = true;
            this.col_item_desc.Width = 250;
            // 
            // col_customer_desc
            // 
            this.col_customer_desc.DataPropertyName = "customer_desc";
            this.col_customer_desc.HeaderText = "货主";
            this.col_customer_desc.Name = "col_customer_desc";
            this.col_customer_desc.ReadOnly = true;
            this.col_customer_desc.Width = 80;
            // 
            // gvListIoLogs
            // 
            this.gvListIoLogs.AllowUserToAddRows = false;
            this.gvListIoLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListIoLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIoTypeId,
            this.colOrderId,
            this.colIndexNo,
            this.colItemBarcode,
            this.colItemDesc,
            this.colQty,
            this.colContainerId});
            this.gvListIoLogs.Dock = System.Windows.Forms.DockStyle.Right;
            this.gvListIoLogs.Location = new System.Drawing.Point(424, 266);
            this.gvListIoLogs.Name = "gvListIoLogs";
            this.gvListIoLogs.RowHeadersWidth = 5;
            this.gvListIoLogs.RowTemplate.Height = 23;
            this.gvListIoLogs.Size = new System.Drawing.Size(360, 259);
            this.gvListIoLogs.TabIndex = 31;
            // 
            // colIoTypeId
            // 
            this.colIoTypeId.DataPropertyName = "IoTypeId";
            this.colIoTypeId.HeaderText = "IoTypeId";
            this.colIoTypeId.Name = "colIoTypeId";
            this.colIoTypeId.Visible = false;
            // 
            // colOrderId
            // 
            this.colOrderId.DataPropertyName = "OrderId";
            this.colOrderId.HeaderText = "OrderId";
            this.colOrderId.Name = "colOrderId";
            this.colOrderId.Visible = false;
            // 
            // colIndexNo
            // 
            this.colIndexNo.DataPropertyName = "IndexNo";
            this.colIndexNo.HeaderText = "#";
            this.colIndexNo.Name = "colIndexNo";
            this.colIndexNo.Width = 50;
            // 
            // colItemBarcode
            // 
            this.colItemBarcode.DataPropertyName = "ItemBarcode";
            this.colItemBarcode.HeaderText = "条码";
            this.colItemBarcode.Name = "colItemBarcode";
            // 
            // colItemDesc
            // 
            this.colItemDesc.DataPropertyName = "ItemDesc";
            this.colItemDesc.HeaderText = "描述";
            this.colItemDesc.Name = "colItemDesc";
            this.colItemDesc.Visible = false;
            // 
            // colQty
            // 
            this.colQty.DataPropertyName = "Qty";
            this.colQty.HeaderText = "数量";
            this.colQty.Name = "colQty";
            this.colQty.Width = 70;
            // 
            // colContainerId
            // 
            this.colContainerId.DataPropertyName = "ContainerId";
            this.colContainerId.HeaderText = "容器";
            this.colContainerId.Name = "colContainerId";
            // 
            // rbLot
            // 
            this.rbLot.AutoSize = true;
            this.rbLot.Location = new System.Drawing.Point(7, 8);
            this.rbLot.Name = "rbLot";
            this.rbLot.Size = new System.Drawing.Size(74, 21);
            this.rbLot.TabIndex = 2;
            this.rbLot.Text = "输入批号";
            this.rbLot.UseVisualStyleBackColor = true;
            // 
            // tbLotSn
            // 
            this.tbLotSn.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.tbLotSn.Location = new System.Drawing.Point(142, 7);
            this.tbLotSn.MaxLength = 20;
            this.tbLotSn.Name = "tbLotSn";
            this.tbLotSn.Size = new System.Drawing.Size(164, 23);
            this.tbLotSn.TabIndex = 1;
            this.tbLotSn.TabStop = false;
            // 
            // splitterBottom
            // 
            this.splitterBottom.BackColor = System.Drawing.Color.Navy;
            this.splitterBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterBottom.Location = new System.Drawing.Point(0, 525);
            this.splitterBottom.Name = "splitterBottom";
            this.splitterBottom.Size = new System.Drawing.Size(784, 1);
            this.splitterBottom.TabIndex = 28;
            this.splitterBottom.TabStop = false;
            // 
            // tbQty
            // 
            this.tbQty.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.tbQty.Location = new System.Drawing.Point(387, 55);
            this.tbQty.MaxLength = 10;
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(50, 23);
            this.tbQty.TabIndex = 1;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.pnlStatus);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 526);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(784, 35);
            this.pnlBottom.TabIndex = 26;
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.lbMessage);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStatus.Location = new System.Drawing.Point(0, 0);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(424, 35);
            this.pnlStatus.TabIndex = 9;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(12, 9);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(17, 17);
            this.lbMessage.TabIndex = 0;
            this.lbMessage.Text = "...";
            // 
            // cbCustomeId
            // 
            this.cbCustomeId.FormattingEnabled = true;
            this.cbCustomeId.Location = new System.Drawing.Point(473, 16);
            this.cbCustomeId.Name = "cbCustomeId";
            this.cbCustomeId.Size = new System.Drawing.Size(154, 25);
            this.cbCustomeId.TabIndex = 16;
            // 
            // lbCustomerNo
            // 
            this.lbCustomerNo.AutoSize = true;
            this.lbCustomerNo.Location = new System.Drawing.Point(401, 20);
            this.lbCustomerNo.Name = "lbCustomerNo";
            this.lbCustomerNo.Size = new System.Drawing.Size(61, 17);
            this.lbCustomerNo.TabIndex = 15;
            this.lbCustomerNo.Text = "客户/货主";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClearInput);
            this.panel1.Controls.Add(this.btnInsertShippingItem);
            this.panel1.Controls.Add(this.btnSaveCommit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 35);
            this.panel1.TabIndex = 14;
            // 
            // btnClearInput
            // 
            this.btnClearInput.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearInput.Location = new System.Drawing.Point(424, 0);
            this.btnClearInput.Name = "btnClearInput";
            this.btnClearInput.Size = new System.Drawing.Size(180, 35);
            this.btnClearInput.TabIndex = 13;
            this.btnClearInput.Text = "清空";
            this.btnClearInput.UseVisualStyleBackColor = true;
            this.btnClearInput.Click += new System.EventHandler(this.btnClearInput_Click);
            // 
            // btnInsertShippingItem
            // 
            this.btnInsertShippingItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInsertShippingItem.Location = new System.Drawing.Point(0, 0);
            this.btnInsertShippingItem.Name = "btnInsertShippingItem";
            this.btnInsertShippingItem.Size = new System.Drawing.Size(180, 35);
            this.btnInsertShippingItem.TabIndex = 12;
            this.btnInsertShippingItem.Text = "增加 (继续出库...)";
            this.btnInsertShippingItem.UseVisualStyleBackColor = true;
            this.btnInsertShippingItem.Click += new System.EventHandler(this.btnInsertShippingItem_Click);
            // 
            // btnSaveCommit
            // 
            this.btnSaveCommit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSaveCommit.Location = new System.Drawing.Point(604, 0);
            this.btnSaveCommit.Name = "btnSaveCommit";
            this.btnSaveCommit.Size = new System.Drawing.Size(180, 35);
            this.btnSaveCommit.TabIndex = 11;
            this.btnSaveCommit.Text = "提交保存";
            this.btnSaveCommit.UseVisualStyleBackColor = true;
            this.btnSaveCommit.Click += new System.EventHandler(this.btnSaveCommit_Click);
            // 
            // tbSoNo
            // 
            this.tbSoNo.Location = new System.Drawing.Point(150, 17);
            this.tbSoNo.Name = "tbSoNo";
            this.tbSoNo.ReadOnly = true;
            this.tbSoNo.Size = new System.Drawing.Size(120, 23);
            this.tbSoNo.TabIndex = 101;
            // 
            // lbItemDesc
            // 
            this.lbItemDesc.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbItemDesc.ForeColor = System.Drawing.Color.Green;
            this.lbItemDesc.Location = new System.Drawing.Point(147, 82);
            this.lbItemDesc.Name = "lbItemDesc";
            this.lbItemDesc.Size = new System.Drawing.Size(380, 19);
            this.lbItemDesc.TabIndex = 0;
            this.lbItemDesc.Text = "产品描述";
            // 
            // pnlTopTitle
            // 
            this.pnlTopTitle.Controls.Add(this.btnExit);
            this.pnlTopTitle.Controls.Add(this.lbTitleDesc);
            this.pnlTopTitle.Controls.Add(this.pnlTitleNo);
            this.pnlTopTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTopTitle.Name = "pnlTopTitle";
            this.pnlTopTitle.Size = new System.Drawing.Size(784, 40);
            this.pnlTopTitle.TabIndex = 25;
            // 
            // lbTitleDesc
            // 
            this.lbTitleDesc.AutoSize = true;
            this.lbTitleDesc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitleDesc.Location = new System.Drawing.Point(62, 12);
            this.lbTitleDesc.Name = "lbTitleDesc";
            this.lbTitleDesc.Size = new System.Drawing.Size(56, 17);
            this.lbTitleDesc.TabIndex = 4;
            this.lbTitleDesc.Text = "出库操作";
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
            this.lbTitle.Text = "WO21";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.cbInputSnLot);
            this.pnlMain.Controls.Add(this.pnlLotSn);
            this.pnlMain.Controls.Add(this.tbSoNo);
            this.pnlMain.Controls.Add(this.lbPoNo);
            this.pnlMain.Controls.Add(this.tbProductNo);
            this.pnlMain.Controls.Add(this.lbContainerNo);
            this.pnlMain.Controls.Add(this.cbUomId);
            this.pnlMain.Controls.Add(this.cbCustomeId);
            this.pnlMain.Controls.Add(this.lbQty);
            this.pnlMain.Controls.Add(this.lbUom);
            this.pnlMain.Controls.Add(this.lbCustomerNo);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.tbQty);
            this.pnlMain.Controls.Add(this.lbItemDesc);
            this.pnlMain.Controls.Add(this.tbContainerNo);
            this.pnlMain.Controls.Add(this.tbBarcode);
            this.pnlMain.Controls.Add(this.lbItemNoBarcode);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 41);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(784, 225);
            this.pnlMain.TabIndex = 29;
            // 
            // cbInputSnLot
            // 
            this.cbInputSnLot.AutoSize = true;
            this.cbInputSnLot.Location = new System.Drawing.Point(32, 112);
            this.cbInputSnLot.Name = "cbInputSnLot";
            this.cbInputSnLot.Size = new System.Drawing.Size(94, 21);
            this.cbInputSnLot.TabIndex = 2;
            this.cbInputSnLot.TabStop = false;
            this.cbInputSnLot.Text = "输入批号/Sn";
            this.cbInputSnLot.UseVisualStyleBackColor = true;
            this.cbInputSnLot.CheckedChanged += new System.EventHandler(this.cbInputSnLot_CheckedChanged);
            // 
            // pnlLotSn
            // 
            this.pnlLotSn.Controls.Add(this.rbSn);
            this.pnlLotSn.Controls.Add(this.rbLot);
            this.pnlLotSn.Controls.Add(this.tbLotSn);
            this.pnlLotSn.Location = new System.Drawing.Point(147, 104);
            this.pnlLotSn.Name = "pnlLotSn";
            this.pnlLotSn.Size = new System.Drawing.Size(315, 40);
            this.pnlLotSn.TabIndex = 1;
            this.pnlLotSn.Visible = false;
            // 
            // splitterTop
            // 
            this.splitterTop.BackColor = System.Drawing.Color.Navy;
            this.splitterTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterTop.Location = new System.Drawing.Point(0, 40);
            this.splitterTop.Name = "splitterTop";
            this.splitterTop.Size = new System.Drawing.Size(784, 1);
            this.splitterTop.TabIndex = 27;
            this.splitterTop.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(664, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 40);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // FormOpShipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gvListItem);
            this.Controls.Add(this.gvListIoLogs);
            this.Controls.Add(this.splitterBottom);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.splitterTop);
            this.Controls.Add(this.pnlTopTitle);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormOpShipping";
            this.Text = "FormOpShipping";
            this.Load += new System.EventHandler(this.FormOpShipping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvListItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListIoLogs)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlTopTitle.ResumeLayout(false);
            this.pnlTopTitle.PerformLayout();
            this.pnlTitleNo.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlLotSn.ResumeLayout(false);
            this.pnlLotSn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbPoNo;
        private System.Windows.Forms.RadioButton rbSn;
        private System.Windows.Forms.TextBox tbProductNo;
        private System.Windows.Forms.Label lbContainerNo;
        private System.Windows.Forms.ComboBox cbUomId;
        private System.Windows.Forms.Label lbQty;
        private System.Windows.Forms.Label lbUom;
        private System.Windows.Forms.TextBox tbContainerNo;
        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.Label lbItemNoBarcode;
        private System.Windows.Forms.DataGridView gvListItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_customer_desc;
        private System.Windows.Forms.DataGridView gvListIoLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIoTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndexNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContainerId;
        private System.Windows.Forms.RadioButton rbLot;
        private System.Windows.Forms.TextBox tbLotSn;
        private System.Windows.Forms.Splitter splitterBottom;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.ComboBox cbCustomeId;
        private System.Windows.Forms.Label lbCustomerNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearInput;
        private System.Windows.Forms.Button btnInsertShippingItem;
        private System.Windows.Forms.Button btnSaveCommit;
        private System.Windows.Forms.TextBox tbSoNo;
        private System.Windows.Forms.Label lbItemDesc;
        private System.Windows.Forms.Panel pnlTopTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbTitleDesc;
        private System.Windows.Forms.Panel pnlTitleNo;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.CheckBox cbInputSnLot;
        private System.Windows.Forms.Panel pnlLotSn;
        private System.Windows.Forms.Splitter splitterTop;
    }
}