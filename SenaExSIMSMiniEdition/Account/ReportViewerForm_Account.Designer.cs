namespace SenaExSIMSMiniEdition.Account
{
    partial class ReportViewerForm_Account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportViewerForm_Account));
            this.grnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.senaexminidbDataSet = new SenaExSIMSMiniEdition.senaexminidbDataSet();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerMain = new Microsoft.Reporting.WinForms.ReportViewer();
            this.grnTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.grnTableAdapter();
            this.invoiceTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.invoiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senaexminidbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grnBindingSource
            // 
            this.grnBindingSource.DataMember = "grn";
            this.grnBindingSource.DataSource = this.senaexminidbDataSet;
            // 
            // senaexminidbDataSet
            // 
            this.senaexminidbDataSet.DataSetName = "senaexminidbDataSet";
            this.senaexminidbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "invoice";
            this.invoiceBindingSource.DataSource = this.senaexminidbDataSet;
            // 
            // reportViewerMain
            // 
            this.reportViewerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_GRN";
            reportDataSource1.Value = this.grnBindingSource;
            reportDataSource2.Name = "DataSet_INV";
            reportDataSource2.Value = this.invoiceBindingSource;
            this.reportViewerMain.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerMain.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerMain.LocalReport.ReportEmbeddedResource = "SenaExSIMSMiniEdition.Account.Report_Account.rdlc";
            this.reportViewerMain.Location = new System.Drawing.Point(5, 5);
            this.reportViewerMain.Name = "reportViewerMain";
            this.reportViewerMain.Size = new System.Drawing.Size(574, 451);
            this.reportViewerMain.TabIndex = 1;
            // 
            // grnTableAdapter
            // 
            this.grnTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // ReportViewerForm_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.reportViewerMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "ReportViewerForm_Account";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportViewerForm_Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senaexminidbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerMain;
        private senaexminidbDataSet senaexminidbDataSet;
        private System.Windows.Forms.BindingSource grnBindingSource;
        private senaexminidbDataSetTableAdapters.grnTableAdapter grnTableAdapter;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private senaexminidbDataSetTableAdapters.invoiceTableAdapter invoiceTableAdapter;
    }
}