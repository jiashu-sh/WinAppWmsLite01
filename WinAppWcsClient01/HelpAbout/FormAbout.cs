using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppWmsLite.HelpAbout
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void btnInitWh_Click(object sender, EventArgs e)
        {
            try
            {
                if (DaAbout.InsertInitWarehouse())
                    MessageBox.Show("Init warehouse 01 success.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
