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

namespace SenaExSIMSMiniEdition.Account
{
    internal partial class ReportViewerForm_Account : Form
    {
        int repNo = -1;
        string date1;
        string date2;
        DateTime Date1;
        DateTime Date2;

        public ReportViewerForm_Account(int repNo)
        {
            InitializeComponent();
            this.repNo = repNo;
        }
        public ReportViewerForm_Account(int repNo, string date1, string date2)
        {
            InitializeComponent();
            this.repNo = repNo;
            this.date1 = date1;
            this.date2 = date2;
        }
        public ReportViewerForm_Account(int repNo, DateTime Date1, DateTime Date2)
        {
            InitializeComponent();
            this.repNo = repNo;
            this.Date1 = Date1;
            this.Date2 = Date2;
        }


        private void ReportViewerForm_Inventory_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.repNo == 0)
                {
                    this.reportViewerMain.LocalReport.SetParameters(new ReportParameter("date1", DateTime.Today.ToShortDateString()));
                    string date = "%" + DateTime.Today.ToShortDateString() + "%";
                    this.grnTableAdapter.FillBy_Today(this.senaexminidbDataSet.grn, date);
                    this.invoiceTableAdapter.FillBy_Today(this.senaexminidbDataSet.invoice, date);
                }
                else if (this.repNo == 1)
                {
                    this.reportViewerMain.LocalReport.SetParameters(new ReportParameter("date1", date1));
                    string selDate = (this.date1 != null) ? ("%" + this.date1 + "%") : ("%" + DateTime.Today.ToShortDateString() + "%");
                    this.grnTableAdapter.FillBy_Today(this.senaexminidbDataSet.grn, selDate);
                    this.invoiceTableAdapter.FillBy_Today(this.senaexminidbDataSet.invoice, selDate);
                }
                else if (this.repNo == 2)
                {
                    DateTime Date1 = (this.Date1 != null) ? this.Date1 : DateTime.Today;
                    DateTime Date2 = (this.Date2 != null) ? this.Date2 : DateTime.Today;
                    this.reportViewerMain.LocalReport.SetParameters(new ReportParameter("date1", Date1.ToLongDateString()));
                    this.reportViewerMain.LocalReport.SetParameters(new ReportParameter("date2", Date2.ToLongDateString()));
                    this.grnTableAdapter.FillBy_Period(this.senaexminidbDataSet.grn, Date1, Date2);
                    this.invoiceTableAdapter.FillBy_Period(this.senaexminidbDataSet.invoice, Date1, Date2);
                }
                else
                {
                    this.invoiceTableAdapter.Fill(this.senaexminidbDataSet.invoice);
                    this.grnTableAdapter.Fill_InDesOrder(this.senaexminidbDataSet.grn);
                }
                this.reportViewerMain.RefreshReport();
            }
            catch { MessageBox.Show("Cannot View Report!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            this.reportViewerMain.RefreshReport();
        }

        //
    }
}
