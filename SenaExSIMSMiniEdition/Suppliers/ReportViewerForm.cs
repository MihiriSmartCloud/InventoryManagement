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

namespace SenaExSIMSMiniEdition.Suppliers
{
    internal partial class ReportViewerForm : Form
    {
        /// 
        string curSupID = string.Empty;
        int reportNo = 0;
        /// 
        public ReportViewerForm(int reportNo)
        {
            InitializeComponent();
            this.reportNo = reportNo;
        }

        public ReportViewerForm(string curSupID, int reportNo)
        {
            InitializeComponent();
            this.curSupID = curSupID;
            this.reportNo = reportNo;
        }

        private void setReportDataSource(object BindingSource)
        {
            try
            {
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet_Sup";
                reportDataSource.Value = BindingSource;
                this.reportViewerMain.LocalReport.DataSources.Add(reportDataSource);
            }
            catch { }
        }

        private void selectReport(int repNo)
        {
            try
            {
                switch (repNo)
                {
                    case 1:
                        setReportDataSource(this.suppliersBindingSource);
                        this.reportViewerMain.LocalReport.ReportEmbeddedResource = "SenaExSIMSMiniEdition.Suppliers.Report_supPresonalDetails.rdlc";
                        this.suppliersTableAdapter.FillBySupID_Report(this.senaexminidbDataSet.suppliers, curSupID);
                        break;
                    case 2:
                        setReportDataSource(this.suppliersBindingSource);
                        this.reportViewerMain.LocalReport.ReportEmbeddedResource = "SenaExSIMSMiniEdition.Suppliers.Report_AllSupliersDetails.rdlc";
                        this.suppliersTableAdapter.Fill(this.senaexminidbDataSet.suppliers);
                        break;
                }
            }
            catch { }
        }



        private void ReportViewerForm_Load(object sender, EventArgs e)
        {
            try
            {
                selectReport(reportNo);
                this.reportViewerMain.RefreshReport();
            }
            catch { MessageBox.Show("Cannot View Report!", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


        //////////////////////////////////////////End of the Class///////////////////////////////////////////
    }
}
