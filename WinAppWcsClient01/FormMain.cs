﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppWmsLite.LocationMgt;

namespace WinAppWmsLite
{
    public partial class FormMain : Form
    {
        public static int WAREHOUSE_ID = 1;
        public static int USER_ID = 1;
        public static DataSet DS_BC_CUSTOMER = null;
        public static DataSet DS_BC_UOM = null;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            DS_BC_CUSTOMER = Common.CommonDa.ExecuteQuery("select customer_id,customer_desc from bc_customer where void=0 order by customer_id ");
            DS_BC_UOM = Common.CommonDa.ExecuteQuery("select code_id,code_desc from bc_common_code where void=0 and code_type_id=1 order by code_id ");

            DataSet dsWh = Common.CommonDa.ExecuteQuery("select warehouse_id from loc_warehouse where void=0  ");
            if (dsWh != null)
            {
                try
                {
                    WAREHOUSE_ID = int.Parse(dsWh.Tables[0].Rows[0]["warehouse_id"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void tsmiSubExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiHelpAbout_Click(object sender, EventArgs e)
        {
            HelpAbout.FormAbout formAbout = new HelpAbout.FormAbout();
            DialogResult dlgResult = formAbout.ShowDialog(this);
        }

        private void tsmiLocationMapSet_Click(object sender, EventArgs e)
        {
            FormLocationMapSet formLocationMapSet = null;
            foreach (Form ftemp in this.MdiChildren) //查找当前父表单所有子表单
            {
                if (ftemp is FormLocationMapSet)
                {
                    formLocationMapSet = (FormLocationMapSet)ftemp;
                    break;
                }
            }
            if (formLocationMapSet == null || formLocationMapSet.IsDisposed)
            {
                formLocationMapSet = new FormLocationMapSet();
                formLocationMapSet.MdiParent = this;
            }
            formLocationMapSet.Show();
            formLocationMapSet.WindowState = FormWindowState.Maximized;
            formLocationMapSet.Activate();
        }

        private void tsmiItemMaintain_Click(object sender, EventArgs e)
        {
            ItemMaintain.FormItemMaintain formItemMaintain = null;
            foreach (Form ftemp in this.MdiChildren) //查找当前父表单所有子表单
            {
                if (ftemp is ItemMaintain.FormItemMaintain)
                {
                    formItemMaintain = (ItemMaintain.FormItemMaintain)ftemp;
                    break;
                }
            }
            if (formItemMaintain == null || formItemMaintain.IsDisposed)
            {
                formItemMaintain = new ItemMaintain.FormItemMaintain();
                formItemMaintain.MdiParent = this;
            }
            formItemMaintain.Show();
            //formItemMaintain.WindowState = FormWindowState.Maximized;
            formItemMaintain.Activate();
        }

        private void tsmiOpReceiving_Click(object sender, EventArgs e)
        {
            WhOperate.FormOpReceiving formOpReceiving = null;
            foreach (Form ftemp in this.MdiChildren) //查找当前父表单所有子表单
            {
                if (ftemp is WhOperate.FormOpReceiving)
                {
                    formOpReceiving = (WhOperate.FormOpReceiving)ftemp;
                    break;
                }
            }
            if (formOpReceiving == null || formOpReceiving.IsDisposed)
            {
                formOpReceiving = new WhOperate.FormOpReceiving();
                formOpReceiving.MdiParent = this;
            }
            formOpReceiving.Show();
            //formItemMaintain.WindowState = FormWindowState.Maximized;
            formOpReceiving.Activate();
        }

        private void tsmiWmStockQuery_Click(object sender, EventArgs e)
        {
            WhMgt.FormStockQuery formStockQuery = null;
            foreach (Form ftemp in this.MdiChildren) //查找当前父表单所有子表单
            {
                if (ftemp is WhMgt.FormStockQuery)
                {
                    formStockQuery = (WhMgt.FormStockQuery)ftemp;
                    break;
                }
            }
            if (formStockQuery == null || formStockQuery.IsDisposed)
            {
                formStockQuery = new WhMgt.FormStockQuery();
                formStockQuery.MdiParent = this;
            }
            formStockQuery.Show();
            //formItemMaintain.WindowState = FormWindowState.Maximized;
            formStockQuery.Activate();
        }

        private void tsmiOpShipping_Click(object sender, EventArgs e)
        {
            WhOperate.FormOpShipping formOpShipping = null;
            foreach (Form ftemp in this.MdiChildren) //查找当前父表单所有子表单
            {
                if (ftemp is WhOperate.FormOpReceiving)
                {
                    formOpShipping = (WhOperate.FormOpShipping)ftemp;
                    break;
                }
            }
            if (formOpShipping == null || formOpShipping.IsDisposed)
            {
                formOpShipping = new WhOperate.FormOpShipping();
                formOpShipping.MdiParent = this;
            }
            formOpShipping.Show();
            //formItemMaintain.WindowState = FormWindowState.Maximized;
            formOpShipping.Activate();
        }
    }
}
