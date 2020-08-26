namespace WinAppWmsLite.ItemMaintain
{
    partial class FormItemMaintain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTopTitle = new System.Windows.Forms.Panel();
            this.lbTitleDesc = new System.Windows.Forms.Label();
            this.pnlTitleNo = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbCustomerNo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMsg = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddBarcode = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.tbItemDesc = new System.Windows.Forms.TextBox();
            this.lbItemDesc = new System.Windows.Forms.Label();
            this.tbItemNo = new System.Windows.Forms.TextBox();
            this.lbItemNo = new System.Windows.Forms.Label();
            this.splitterBottom = new System.Windows.Forms.Splitter();
            this.splitterTop = new System.Windows.Forms.Splitter();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lbTipAreaNo = new System.Windows.Forms.Label();
            this.lbYVal = new System.Windows.Forms.Label();
            this.lbYTip = new System.Windows.Forms.Label();
            this.lbXVal = new System.Windows.Forms.Label();
            this.lbXTip = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.gvListItem = new System.Windows.Forms.DataGridView();
            this.gvListItemBarcode = new System.Windows.Forms.DataGridView();
            this.col_product_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_customer_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTopTitle.SuspendLayout();
            this.pnlTitleNo.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlMsg.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListItemBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopTitle
            // 
            this.pnlTopTitle.Controls.Add(this.lbTitleDesc);
            this.pnlTopTitle.Controls.Add(this.pnlTitleNo);
            this.pnlTopTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTopTitle.Name = "pnlTopTitle";
            this.pnlTopTitle.Size = new System.Drawing.Size(784, 40);
            this.pnlTopTitle.TabIndex = 12;
            // 
            // lbTitleDesc
            // 
            this.lbTitleDesc.AutoSize = true;
            this.lbTitleDesc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitleDesc.Location = new System.Drawing.Point(62, 12);
            this.lbTitleDesc.Name = "lbTitleDesc";
            this.lbTitleDesc.Size = new System.Drawing.Size(56, 17);
            this.lbTitleDesc.TabIndex = 4;
            this.lbTitleDesc.Text = "产品维护";
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
            this.lbTitle.Text = "IM01";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.comboBox1);
            this.pnlMain.Controls.Add(this.lbCustomerNo);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.tbItemDesc);
            this.pnlMain.Controls.Add(this.lbItemDesc);
            this.pnlMain.Controls.Add(this.tbItemNo);
            this.pnlMain.Controls.Add(this.lbItemNo);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 40);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(784, 116);
            this.pnlMain.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(404, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 25);
            this.comboBox1.TabIndex = 16;
            // 
            // lbCustomerNo
            // 
            this.lbCustomerNo.AutoSize = true;
            this.lbCustomerNo.Location = new System.Drawing.Point(357, 18);
            this.lbCustomerNo.Name = "lbCustomerNo";
            this.lbCustomerNo.Size = new System.Drawing.Size(32, 17);
            this.lbCustomerNo.TabIndex = 15;
            this.lbCustomerNo.Text = "客户";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlMsg);
            this.panel1.Controls.Add(this.btnAddBarcode);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnAddItem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 35);
            this.panel1.TabIndex = 14;
            // 
            // pnlMsg
            // 
            this.pnlMsg.Controls.Add(this.label1);
            this.pnlMsg.Controls.Add(this.label2);
            this.pnlMsg.Controls.Add(this.label3);
            this.pnlMsg.Controls.Add(this.label4);
            this.pnlMsg.Controls.Add(this.label5);
            this.pnlMsg.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMsg.Location = new System.Drawing.Point(198, 0);
            this.pnlMsg.Name = "pnlMsg";
            this.pnlMsg.Size = new System.Drawing.Size(226, 35);
            this.pnlMsg.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "y : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "x : ";
            // 
            // btnAddBarcode
            // 
            this.btnAddBarcode.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddBarcode.Location = new System.Drawing.Point(424, 0);
            this.btnAddBarcode.Name = "btnAddBarcode";
            this.btnAddBarcode.Size = new System.Drawing.Size(180, 35);
            this.btnAddBarcode.TabIndex = 12;
            this.btnAddBarcode.Text = "添加产品条码";
            this.btnAddBarcode.UseVisualStyleBackColor = true;
            this.btnAddBarcode.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.Location = new System.Drawing.Point(0, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(169, 35);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddItem.Location = new System.Drawing.Point(604, 0);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(180, 35);
            this.btnAddItem.TabIndex = 11;
            this.btnAddItem.Text = "添加产品";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // tbItemDesc
            // 
            this.tbItemDesc.Location = new System.Drawing.Point(124, 44);
            this.tbItemDesc.Name = "tbItemDesc";
            this.tbItemDesc.Size = new System.Drawing.Size(433, 23);
            this.tbItemDesc.TabIndex = 1;
            // 
            // lbItemDesc
            // 
            this.lbItemDesc.AutoSize = true;
            this.lbItemDesc.Location = new System.Drawing.Point(26, 47);
            this.lbItemDesc.Name = "lbItemDesc";
            this.lbItemDesc.Size = new System.Drawing.Size(32, 17);
            this.lbItemDesc.TabIndex = 0;
            this.lbItemDesc.Text = "描述";
            // 
            // tbItemNo
            // 
            this.tbItemNo.Location = new System.Drawing.Point(124, 15);
            this.tbItemNo.Name = "tbItemNo";
            this.tbItemNo.Size = new System.Drawing.Size(154, 23);
            this.tbItemNo.TabIndex = 1;
            // 
            // lbItemNo
            // 
            this.lbItemNo.AutoSize = true;
            this.lbItemNo.Location = new System.Drawing.Point(26, 18);
            this.lbItemNo.Name = "lbItemNo";
            this.lbItemNo.Size = new System.Drawing.Size(76, 17);
            this.lbItemNo.TabIndex = 0;
            this.lbItemNo.Text = "产品(号)条码";
            // 
            // splitterBottom
            // 
            this.splitterBottom.BackColor = System.Drawing.Color.Navy;
            this.splitterBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterBottom.Location = new System.Drawing.Point(0, 525);
            this.splitterBottom.Name = "splitterBottom";
            this.splitterBottom.Size = new System.Drawing.Size(784, 1);
            this.splitterBottom.TabIndex = 15;
            this.splitterBottom.TabStop = false;
            // 
            // splitterTop
            // 
            this.splitterTop.BackColor = System.Drawing.Color.Navy;
            this.splitterTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterTop.Location = new System.Drawing.Point(0, 156);
            this.splitterTop.Name = "splitterTop";
            this.splitterTop.Size = new System.Drawing.Size(784, 1);
            this.splitterTop.TabIndex = 14;
            this.splitterTop.TabStop = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.pnlStatus);
            this.pnlBottom.Controls.Add(this.btnInsert);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 526);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(784, 35);
            this.pnlBottom.TabIndex = 13;
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
            this.pnlStatus.TabIndex = 9;
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
            this.btnInsert.Location = new System.Drawing.Point(586, 0);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(198, 35);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "保存产品";
            this.btnInsert.UseVisualStyleBackColor = true;
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
            this.gvListItem.Location = new System.Drawing.Point(0, 157);
            this.gvListItem.Name = "gvListItem";
            this.gvListItem.ReadOnly = true;
            this.gvListItem.RowHeadersWidth = 20;
            this.gvListItem.RowTemplate.Height = 23;
            this.gvListItem.Size = new System.Drawing.Size(604, 368);
            this.gvListItem.TabIndex = 17;
            this.gvListItem.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvListItem_CellMouseDoubleClick);
            // 
            // gvListItemBarcode
            // 
            this.gvListItemBarcode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListItemBarcode.Dock = System.Windows.Forms.DockStyle.Right;
            this.gvListItemBarcode.Location = new System.Drawing.Point(604, 157);
            this.gvListItemBarcode.Name = "gvListItemBarcode";
            this.gvListItemBarcode.RowTemplate.Height = 23;
            this.gvListItemBarcode.Size = new System.Drawing.Size(180, 368);
            this.gvListItemBarcode.TabIndex = 17;
            this.gvListItemBarcode.Visible = false;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.col_item_desc.DefaultCellStyle = dataGridViewCellStyle1;
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
            // FormItemMaintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gvListItem);
            this.Controls.Add(this.gvListItemBarcode);
            this.Controls.Add(this.splitterBottom);
            this.Controls.Add(this.splitterTop);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTopTitle);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormItemMaintain";
            this.Text = "FormItemMaintain";
            this.pnlTopTitle.ResumeLayout(false);
            this.pnlTopTitle.PerformLayout();
            this.pnlTitleNo.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlMsg.ResumeLayout(false);
            this.pnlMsg.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListItemBarcode)).EndInit();
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
        private System.Windows.Forms.Label lbTitleDesc;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lbTipAreaNo;
        private System.Windows.Forms.Label lbYVal;
        private System.Windows.Forms.Label lbYTip;
        private System.Windows.Forms.Label lbXVal;
        private System.Windows.Forms.Label lbXTip;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView gvListItem;
        private System.Windows.Forms.DataGridView gvListItemBarcode;
        private System.Windows.Forms.TextBox tbItemDesc;
        private System.Windows.Forms.Label lbItemDesc;
        private System.Windows.Forms.TextBox tbItemNo;
        private System.Windows.Forms.Label lbItemNo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbCustomerNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnAddBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_customer_desc;
    }
}