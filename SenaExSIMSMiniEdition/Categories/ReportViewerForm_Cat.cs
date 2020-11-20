using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace SenaExSIMSMiniEdition.Categories
{
    internal partial class ReportViewerForm_Cat : Form
    {
        int reportNo = 0;
        string curCategory = string.Empty;

        public ReportViewerForm_Cat(int reportNo, string curCategory)
        {
            InitializeComponent();

            this.reportNo = reportNo;
            this.curCategory = curCategory;
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
                setReportDataSource("DataSet_Categories", this.categoriesBindingSource);
                setReportDataSource("DataSet_CatItems", this.itemsBindingSource);
                setReportDataSource("DataSet_CatItemsSup", this.suppliersBindingSource);
                this.reportViewerMain.LocalReport.ReportEmbeddedResource = "SenaExSIMSMiniEdition.Categories.Report_Categories.rdlc";
                this.reportViewerMain.LocalReport.SetParameters(new ReportParameter("repType", reportNo.ToString()));
                this.reportViewerMain.LocalReport.SetParameters(new ReportParameter("curCategory", curCategory));
                this.categoriesTableAdapter.Fill(this.senaexminidbDataSet.categories);
                this.itemsTableAdapter.Fill(this.senaexminidbDataSet.items);
                this.suppliersTableAdapter.Fill(this.senaexminidbDataSet.suppliers);
            }
            catch { }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////// 

        private void ReportViewerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'senaexminidbDataSet.suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.senaexminidbDataSet.suppliers);
            // TODO: This line of code loads data into the 'senaexminidbDataSet.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.senaexminidbDataSet.items);
            try
            {
                setReport();
                this.reportViewerMain.RefreshReport();
            }
            catch { MessageBox.Show("Cannot View Report!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }




        //////////////////////////////////////////End of the Class///////////////////////////////////////////
    }
}
