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

namespace SenaExSIMSMiniEdition.GRN
{
    internal partial class ReportViewerForm_GRN : Form
    {
        private int reportNo;
        private string GRNNo = string.Empty;
        private string SupID = string.Empty;

        public ReportViewerForm_GRN(int reportNo)
        {
            InitializeComponent();
            this.reportNo = reportNo;
        }

        public ReportViewerForm_GRN(int reportNo, string GRNNo, string SupID)
        {
            InitializeComponent();
            this.reportNo = reportNo;
            this.GRNNo = GRNNo;
            this.SupID = SupID;
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
                        setReportDataSource("DataSet_GRN", this.grnBindingSource);
                        setReportDataSource("DataSet_Sup", this.suppliersBindingSource);
                        this.reportViewerMain.LocalReport.ReportEmbeddedResource = "SenaExSIMSMiniEdition.GRN.Report_GRNList.rdlc";
                        this.grnTableAdapter.Fill(this.senaexminidbDataSet.grn);
                        this.suppliersTableAdapter.Fill(this.senaexminidbDataSet.suppliers);
                        break;
                    case 2:
                        setReportDataSource("DataSet_Sup", this.suppliersBindingSource);
                        setReportDataSource("DataSet_GRN", this.grnBindingSource);
                        setReportDataSource("DataSet_GRNItems", this.grndetailsBindingSource);
                        setReportDataSource("DataSet_PMT", this.paymentsBindingSource);
                        this.reportViewerMain.LocalReport.ReportEmbeddedResource = "SenaExSIMSMiniEdition.GRN.Report_GRN.rdlc";
                        this.suppliersTableAdapter.FillBySupID_Report(this.senaexminidbDataSet.suppliers, this.SupID);
                        this.grnTableAdapter.FillBy_GRNNo(this.senaexminidbDataSet.grn, this.GRNNo);
                        this.paymentsTableAdapter.FillBy_PMNo(this.senaexminidbDataSet.payments, this.GRNNo);
                        this.grn_detailsTableAdapter.FillBy_GRNNo(this.senaexminidbDataSet.grn_details, this.GRNNo);
                        break;
                }
            }
            catch { }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////// 

        private void ReportViewerForm_GRN_Load(object sender, EventArgs e)
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
