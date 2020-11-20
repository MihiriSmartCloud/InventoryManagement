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

namespace SenaExSIMSMiniEdition.Invoice
{
    internal partial class ReportViewerForm_Invoice : Form
    {
        private int reportNo;
        private string reportType = string.Empty;
        private string InvNo = string.Empty;
        private string CustID = string.Empty;

        public ReportViewerForm_Invoice(int reportNo)
        {
            InitializeComponent();
            this.reportNo = reportNo;
        }

        public ReportViewerForm_Invoice(int reportNo, string reportType, string InvNo, string CustID)
        {
            InitializeComponent();
            this.reportNo = reportNo;
            this.reportType = reportType;
            this.InvNo = InvNo;
            this.CustID = CustID;
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
                        setReportDataSource("DataSet_INV", this.invoiceBindingSource);
                        this.reportViewerMain.LocalReport.ReportEmbeddedResource = "SenaExSIMSMiniEdition.Invoice.Report_InvoiceList.rdlc";
                        this.invoiceTableAdapter.Fill(this.senaexminidbDataSet.invoice);
                        break;
                    case 2:
                        setReportDataSource("DataSet_INV", this.invoiceBindingSource);
                        setReportDataSource("DataSet_Services", this.fKInvSerInvNoBindingSource);
                        setReportDataSource("DataSet_Items", this.fKInvItemsInvIDBindingSource);
                        setReportDataSource("DataSet_PMT", this.paymentsBindingSource);
                        setReportDataSource("DataSet_Cust", this.customersBindingSource);
                        setReportDataSource("DataSet_Vehicle", this.vehiclesBindingSource);
                        this.reportViewerMain.LocalReport.ReportEmbeddedResource = "SenaExSIMSMiniEdition.Invoice.Report_Invoice.rdlc";
                        this.reportViewerMain.LocalReport.SetParameters(new ReportParameter("ReportType", reportType));
                        this.reportViewerMain.LocalReport.SetParameters(new ReportParameter("InvNo", this.InvNo));
                        this.invoiceTableAdapter.FillBy_InvNo(this.senaexminidbDataSet.invoice, this.InvNo);
                        this.paymentsTableAdapter.Fill(this.senaexminidbDataSet.payments);
                        this.invoice_serviceTableAdapter.Fill(this.senaexminidbDataSet.invoice_service);
                        this.invoice_itemsTableAdapter.Fill(this.senaexminidbDataSet.invoice_items);
                        this.customersTableAdapter.Fill(this.senaexminidbDataSet.customers);
                        this.vehiclesTableAdapter.Fill(this.senaexminidbDataSet.vehicles);
                        break;
                        //case 2:
                        //    setReportDataSource("DataSet_INV", this.invoiceBindingSource);
                        //    setReportDataSource("DataSet_Services", this.invoiceserviceBindingSource);
                        //    setReportDataSource("DataSet_Items", this.invoiceitemsBindingSource);
                        //    setReportDataSource("DataSet_PMT", this.paymentsBindingSource);
                        //    setReportDataSource("DataSet_Cust", this.customersBindingSource);
                        //    this.reportViewerMain.LocalReport.ReportEmbeddedResource = "SenaExSIMSMiniEdition.Invoice.Report_Invoice.rdlc";
                        //    this.reportViewerMain.LocalReport.SetParameters(new ReportParameter("ReportType", reportType));
                        //    this.invoiceTableAdapter.FillBy_InvNo(this.senaexminidbDataSet.invoice, this.InvNo);
                        //    this.paymentsTableAdapter.FillBy_PMNo(this.senaexminidbDataSet.payments, this.InvNo);
                        //    this.invoice_serviceTableAdapter.FillBy_InvNo(this.senaexminidbDataSet.invoice_service, this.InvNo);
                        //    this.invoice_itemsTableAdapter.FillBy_InvNo(this.senaexminidbDataSet.invoice_items, this.InvNo);
                        //    this.customersTableAdapter.FillBy_CustID(this.senaexminidbDataSet.customers, this.CustID);
                        //    break;
                }
            }
            catch { }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////// 

        private void ReportViewerForm_Invoice_Load(object sender, EventArgs e)
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
