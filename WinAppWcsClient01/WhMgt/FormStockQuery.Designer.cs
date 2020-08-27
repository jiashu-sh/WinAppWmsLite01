namespace WinAppWmsLite.WhMgt
{
    partial class FormStockQuery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitterBottom = new System.Windows.Forms.Splitter();
            this.tbItemDesc = new System.Windows.Forms.TextBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lbTipAreaNo = new System.Windows.Forms.Label();
            this.gvListItems = new System.Windows.Forms.DataGridView();
            this.cbCustomeId = new System.Windows.Forms.ComboBox();
            this.lbCustomerNo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gvListItemLocations = new System.Windows.Forms.DataGridView();
            this.splitterTop = new System.Windows.Forms.Splitter();
            this.lbItemDesc = new System.Windows.Forms.Label();
            this.pnlTopTitle = new System.Windows.Forms.Panel();
            this.lbTitleDesc = new System.Windows.Forms.Label();
            this.pnlTitleNo = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tbItemBarcode = new System.Windows.Forms.TextBox();
            this.lbItemNo = new System.Windows.Forms.Label();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.cbListAllItem = new System.Windows.Forms.CheckBox();
            this.col_product_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_customer_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_s1Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PoQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SoQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_StockQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBottom.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListItems)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListItemLocations)).BeginInit();
            this.pnlTopTitle.SuspendLayout();
            this.pnlTitleNo.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitterBottom
            // 
            this.splitterBottom.BackColor = System.Drawing.Color.Navy;
            this.splitterBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterBottom.Location = new System.Drawing.Point(0, 525);
            this.splitterBottom.Name = "splitterBottom";
            this.splitterBottom.Size = new System.Drawing.Size(884, 1);
            this.splitterBottom.TabIndex = 21;
            this.splitterBottom.TabStop = false;
            // 
            // tbItemDesc
            // 
            this.tbItemDesc.Location = new System.Drawing.Point(124, 44);
            this.tbItemDesc.MaxLength = 50;
            this.tbItemDesc.Name = "tbItemDesc";
            this.tbItemDesc.Size = new System.Drawing.Size(433, 23);
            this.tbItemDesc.TabIndex = 1;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.pnlStatus);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 526);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(884, 35);
            this.pnlBottom.TabIndex = 19;
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.lbTipAreaNo);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStatus.Location = new System.Drawing.Point(0, 0);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(557, 35);
            this.pnlStatus.TabIndex = 9;
            // 
            // lbTipAreaNo
            // 
            this.lbTipAreaNo.AutoSize = true;
            this.lbTipAreaNo.Location = new System.Drawing.Point(12, 9);
            this.lbTipAreaNo.Name = "lbTipAreaNo";
            this.lbTipAreaNo.Size = new System.Drawing.Size(17, 17);
            this.lbTipAreaNo.TabIndex = 0;
            this.lbTipAreaNo.Text = "...";
            // 
            // gvListItems
            // 
            this.gvListItems.AllowUserToAddRows = false;
            this.gvListItems.AllowUserToDeleteRows = false;
            this.gvListItems.AllowUserToOrderColumns = true;
            this.gvListItems.ColumnHeadersHeight = 30;
            this.gvListItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_product_no,
            this.col_item_no,
            this.col_customer_desc,
            this.col_customer_id,
            this.col_s1Qty,
            this.col_PoQty,
            this.col_SoQty,
            this.col_StockQty,
            this.col_item_desc});
            this.gvListItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvListItems.Location = new System.Drawing.Point(0, 157);
            this.gvListItems.Name = "gvListItems";
            this.gvListItems.ReadOnly = true;
            this.gvListItems.RowHeadersWidth = 20;
            this.gvListItems.RowTemplate.Height = 23;
            this.gvListItems.Size = new System.Drawing.Size(704, 368);
            this.gvListItems.TabIndex = 23;
            // 
            // cbCustomeId
            // 
            this.cbCustomeId.FormattingEnabled = true;
            this.cbCustomeId.Location = new System.Drawing.Point(404, 15);
            this.cbCustomeId.Name = "cbCustomeId";
            this.cbCustomeId.Size = new System.Drawing.Size(153, 25);
            this.cbCustomeId.TabIndex = 16;
            // 
            // lbCustomerNo
            // 
            this.lbCustomerNo.AutoSize = true;
            this.lbCustomerNo.Location = new System.Drawing.Point(357, 19);
            this.lbCustomerNo.Name = "lbCustomerNo";
            this.lbCustomerNo.Size = new System.Drawing.Size(32, 17);
            this.lbCustomerNo.TabIndex = 15;
            this.lbCustomerNo.Text = "客户";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnExportExcel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 35);
            this.panel1.TabIndex = 14;
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
            // gvListItemLocations
            // 
            this.gvListItemLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListItemLocations.Dock = System.Windows.Forms.DockStyle.Right;
            this.gvListItemLocations.Location = new System.Drawing.Point(704, 157);
            this.gvListItemLocations.Name = "gvListItemLocations";
            this.gvListItemLocations.RowTemplate.Height = 23;
            this.gvListItemLocations.Size = new System.Drawing.Size(180, 368);
            this.gvListItemLocations.TabIndex = 24;
            this.gvListItemLocations.Visible = false;
            // 
            // splitterTop
            // 
            this.splitterTop.BackColor = System.Drawing.Color.Navy;
            this.splitterTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterTop.Location = new System.Drawing.Point(0, 156);
            this.splitterTop.Name = "splitterTop";
            this.splitterTop.Size = new System.Drawing.Size(884, 1);
            this.splitterTop.TabIndex = 20;
            this.splitterTop.TabStop = false;
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
            // pnlTopTitle
            // 
            this.pnlTopTitle.Controls.Add(this.lbTitleDesc);
            this.pnlTopTitle.Controls.Add(this.pnlTitleNo);
            this.pnlTopTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTopTitle.Name = "pnlTopTitle";
            this.pnlTopTitle.Size = new System.Drawing.Size(884, 40);
            this.pnlTopTitle.TabIndex = 18;
            // 
            // lbTitleDesc
            // 
            this.lbTitleDesc.AutoSize = true;
            this.lbTitleDesc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTitleDesc.Location = new System.Drawing.Point(62, 12);
            this.lbTitleDesc.Name = "lbTitleDesc";
            this.lbTitleDesc.Size = new System.Drawing.Size(56, 17);
            this.lbTitleDesc.TabIndex = 4;
            this.lbTitleDesc.Text = "库存查询";
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
            this.lbTitle.Text = "WM01";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.cbListAllItem);
            this.pnlMain.Controls.Add(this.cbCustomeId);
            this.pnlMain.Controls.Add(this.lbCustomerNo);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.tbItemDesc);
            this.pnlMain.Controls.Add(this.lbItemDesc);
            this.pnlMain.Controls.Add(this.tbItemBarcode);
            this.pnlMain.Controls.Add(this.lbItemNo);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 40);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(884, 116);
            this.pnlMain.TabIndex = 22;
            // 
            // tbItemBarcode
            // 
            this.tbItemBarcode.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.tbItemBarcode.Location = new System.Drawing.Point(124, 16);
            this.tbItemBarcode.MaxLength = 50;
            this.tbItemBarcode.Name = "tbItemBarcode";
            this.tbItemBarcode.Size = new System.Drawing.Size(154, 23);
            this.tbItemBarcode.TabIndex = 1;
            // 
            // lbItemNo
            // 
            this.lbItemNo.AutoSize = true;
            this.lbItemNo.Location = new System.Drawing.Point(26, 19);
            this.lbItemNo.Name = "lbItemNo";
            this.lbItemNo.Size = new System.Drawing.Size(76, 17);
            this.lbItemNo.TabIndex = 0;
            this.lbItemNo.Text = "产品(号)条码";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExportExcel.Location = new System.Drawing.Point(704, 0);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(180, 35);
            this.btnExportExcel.TabIndex = 11;
            this.btnExportExcel.Text = "导出Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Visible = false;
            // 
            // cbListAllItem
            // 
            this.cbListAllItem.AutoSize = true;
            this.cbListAllItem.Location = new System.Drawing.Point(593, 17);
            this.cbListAllItem.Name = "cbListAllItem";
            this.cbListAllItem.Size = new System.Drawing.Size(111, 21);
            this.cbListAllItem.TabIndex = 17;
            this.cbListAllItem.Text = "包括无库存产品";
            this.cbListAllItem.UseVisualStyleBackColor = true;
            // 
            // col_product_no
            // 
            this.col_product_no.DataPropertyName = "product_no";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.col_product_no.DefaultCellStyle = dataGridViewCellStyle9;
            this.col_product_no.HeaderText = "产品号";
            this.col_product_no.Name = "col_product_no";
            this.col_product_no.ReadOnly = true;
            this.col_product_no.Width = 80;
            // 
            // col_item_no
            // 
            this.col_item_no.DataPropertyName = "item_no";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Navy;
            this.col_item_no.DefaultCellStyle = dataGridViewCellStyle10;
            this.col_item_no.HeaderText = "产品编码 (主条码)";
            this.col_item_no.Name = "col_item_no";
            this.col_item_no.ReadOnly = true;
            this.col_item_no.Width = 120;
            // 
            // col_customer_desc
            // 
            this.col_customer_desc.DataPropertyName = "customer_desc";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Teal;
            this.col_customer_desc.DefaultCellStyle = dataGridViewCellStyle11;
            this.col_customer_desc.HeaderText = "货主";
            this.col_customer_desc.Name = "col_customer_desc";
            this.col_customer_desc.ReadOnly = true;
            this.col_customer_desc.Visible = false;
            this.col_customer_desc.Width = 80;
            // 
            // col_customer_id
            // 
            this.col_customer_id.DataPropertyName = "customer_id";
            this.col_customer_id.HeaderText = "customer_id";
            this.col_customer_id.Name = "col_customer_id";
            this.col_customer_id.ReadOnly = true;
            this.col_customer_id.Visible = false;
            // 
            // col_s1Qty
            // 
            this.col_s1Qty.DataPropertyName = "s1Qty";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.DarkGreen;
            this.col_s1Qty.DefaultCellStyle = dataGridViewCellStyle12;
            this.col_s1Qty.HeaderText = "初始库存";
            this.col_s1Qty.Name = "col_s1Qty";
            this.col_s1Qty.ReadOnly = true;
            this.col_s1Qty.Width = 80;
            // 
            // col_PoQty
            // 
            this.col_PoQty.DataPropertyName = "PoQty";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Navy;
            this.col_PoQty.DefaultCellStyle = dataGridViewCellStyle13;
            this.col_PoQty.HeaderText = "入库数";
            this.col_PoQty.Name = "col_PoQty";
            this.col_PoQty.ReadOnly = true;
            this.col_PoQty.Width = 70;
            // 
            // col_SoQty
            // 
            this.col_SoQty.DataPropertyName = "SoQty";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.col_SoQty.DefaultCellStyle = dataGridViewCellStyle14;
            this.col_SoQty.HeaderText = "出库数";
            this.col_SoQty.Name = "col_SoQty";
            this.col_SoQty.ReadOnly = true;
            this.col_SoQty.Width = 70;
            // 
            // col_StockQty
            // 
            this.col_StockQty.DataPropertyName = "StockQty";
            dataGridViewCellStyle15.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.col_StockQty.DefaultCellStyle = dataGridViewCellStyle15;
            this.col_StockQty.HeaderText = "库存量";
            this.col_StockQty.Name = "col_StockQty";
            this.col_StockQty.ReadOnly = true;
            this.col_StockQty.Width = 80;
            // 
            // col_item_desc
            // 
            this.col_item_desc.DataPropertyName = "item_desc";
            dataGridViewCellStyle16.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.col_item_desc.DefaultCellStyle = dataGridViewCellStyle16;
            this.col_item_desc.HeaderText = "产品描述";
            this.col_item_desc.Name = "col_item_desc";
            this.col_item_desc.ReadOnly = true;
            this.col_item_desc.Width = 250;
            // 
            // FormStockQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.gvListItems);
            this.Controls.Add(this.gvListItemLocations);
            this.Controls.Add(this.splitterBottom);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.splitterTop);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTopTitle);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormStockQuery";
            this.Text = "FormStockQuery";
            this.Load += new System.EventHandler(this.FormStockQuery_Load);
            this.pnlBottom.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListItems)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvListItemLocations)).EndInit();
            this.pnlTopTitle.ResumeLayout(false);
            this.pnlTopTitle.PerformLayout();
            this.pnlTitleNo.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitterBottom;
        private System.Windows.Forms.TextBox tbItemDesc;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lbTipAreaNo;
        private System.Windows.Forms.DataGridView gvListItems;
        private System.Windows.Forms.ComboBox cbCustomeId;
        private System.Windows.Forms.Label lbCustomerNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView gvListItemLocations;
        private System.Windows.Forms.Splitter splitterTop;
        private System.Windows.Forms.Label lbItemDesc;
        private System.Windows.Forms.Panel pnlTopTitle;
        private System.Windows.Forms.Label lbTitleDesc;
        private System.Windows.Forms.Panel pnlTitleNo;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox tbItemBarcode;
        private System.Windows.Forms.Label lbItemNo;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.CheckBox cbListAllItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_product_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_customer_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_s1Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PoQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_StockQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_desc;
    }
}