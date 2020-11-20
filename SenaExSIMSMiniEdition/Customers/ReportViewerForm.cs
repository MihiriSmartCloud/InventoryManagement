using Microsoft.Reporting.WinForms;
using System;
using System.IO;
using System.Windows.Forms;

namespace SenaExSIMSMiniEdition.Customers
{
    internal partial class ReportViewerForm : Form
    {
        /// 
        string curCustID = string.Empty;
        int reportNo = 0;
        /// 
        public ReportViewerForm(int reportNo)
        {
            InitializeComponent();
            this.reportNo = reportNo;
        }

        public ReportViewerForm(string curCustID, int reportNo)
        {
            InitializeComponent();
            this.curCustID = curCustID;
            this.reportNo = reportNo;
        }

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

        private void selectReport(int repNo)
        {
            try
            {
                switch (repNo)
                {
                    case 1:
                        setReportDataSource("DataSet_Cust", this.customersBindingSource);
                        setReportDataSource("DataSet_Vehicel", this.fKCustIDCustomersBindingSource);
                        this.reportViewerMain.LocalReport.ReportEmbeddedResource = "SenaExSIMSMiniEdition.Customers.Report_CustomerPresonalDetails.rdlc";
                        this.customersTableAdapter.FillBy_CustID(this.senaexminidbDataSet.customers, curCustID);
                        this.vehiclesTableAdapter.Fill(this.senaexminidbDataSet.vehicles);
                        break;
                    case 2:
                        setReportDataSource("DataSet_Cust", this.customersBindingSource);
                        setReportDataSource("DataSet_Vehicel", this.vehiclesBindingSource);
                        this.reportViewerMain.LocalReport.ReportEmbeddedResource = "SenaExSIMSMiniEdition.Customers.Report_AllCustomersDetails.rdlc";
                        this.customersTableAdapter.Fill(this.senaexminidbDataSet.customers);
                        this.vehiclesTableAdapter.Fill(this.senaexminidbDataSet.vehicles);
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
