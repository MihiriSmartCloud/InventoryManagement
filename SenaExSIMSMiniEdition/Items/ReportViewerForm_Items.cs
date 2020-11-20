using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenaExSIMSMiniEdition.Items
{
    internal partial class ReportViewerForm_Items : Form
    {
        private int reportNo;
        private string curItemID;
        private string curSupName;

        public ReportViewerForm_Items(int reportNo)
        {
            InitializeComponent();
            this.reportNo = reportNo;

        }
        public ReportViewerForm_Items(int reportNo, string curItemID, string curSupName)
        {
            InitializeComponent();
            this.reportNo = reportNo;
            this.curItemID = curItemID;
            this.curSupName = curSupName;
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void setReportDataSource(string dsName, object BindingSource)
        {
            try
            {
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = dsName;
                reportDataSource.Value = BindingSource;
                this.reportViewerMain.LocalReport.DataSources.Add(reportDataSource);
            }
            catch { }
        }

        private void setReport()
        {
            try
            {
                switch (reportNo)
                {
                    case 1:
                        setReportDataSource("DataSet_Items", this.itemsBindingSource);
                        setReportDataSource("DataSet_Sup", this.suppliersBindingSource);
                        this.reportViewerMain.LocalReport.ReportEmbeddedResource = "SenaExSIMSMiniEdition.Items.Report_ItemList.rdlc";
                        this.itemsTableAdapter.Fill(this.senaexminidbDataSet.items);
                        this.suppliersTableAdapter.Fill(this.senaexminidbDataSet.suppliers);
                        break;
                    case 2:
                        setReportDataSource("DataSet_Items", this.itemsBindingSource);
                        this.reportViewerMain.LocalReport.ReportEmbeddedResource = "SenaExSIMSMiniEdition.Items.Report_ItemDetails.rdlc";
                        this.reportViewerMain.LocalReport.SetParameters(new ReportParameter("curItemID", curItemID));
                        this.reportViewerMain.LocalReport.SetParameters(new ReportParameter("curSupName", curSupName));
                        this.itemsTableAdapter.FillBy_ItemID(this.senaexminidbDataSet.items, curItemID);
                        break;
                }
            }
            catch { }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////// 

        private void ReportViewerForm_Items_Load(object sender, EventArgs e)
        {
            try
            {
                setReport();
                this.reportViewerMain.RefreshReport();
            }
            catch { MessageBox.Show("Cannot View Report!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            this.reportViewerMain.RefreshReport();
        }




        //////////////////////////////////////////End of the Class///////////////////////////////////////////
    }
}
