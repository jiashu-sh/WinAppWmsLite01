using System;
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

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            DS_BC_CUSTOMER = Common.CommonDa.ExecuteQuery("select customer_id,customer_desc from bc_customer where void=0 order by customer_id ");

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

        
    }
}
