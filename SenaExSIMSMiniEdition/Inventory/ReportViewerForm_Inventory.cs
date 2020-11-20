using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenaExSIMSMiniEdition.Inventory
{
    internal partial class ReportViewerForm_Inventory : Form
    {
        public ReportViewerForm_Inventory()
        {
            InitializeComponent();
        }

        private void ReportViewerForm_Inventory_Load(object sender, EventArgs e)
        {
            try
            {
                this.itemsTableAdapter.Fill(this.senaexminidbDataSet.items);
                this.reportViewerMain.RefreshReport();
            }
            catch { MessageBox.Show("Cannot View Report!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            this.reportViewerMain.RefreshReport();
        }
    }
}
