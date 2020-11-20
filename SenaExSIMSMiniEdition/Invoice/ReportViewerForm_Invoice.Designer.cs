namespace SenaExSIMSMiniEdition.Invoice
{
    partial class ReportViewerForm_Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportViewerForm_Invoice));
            this.reportViewerMain = new Microsoft.Reporting.WinForms.ReportViewer();
            this.senaexminidbDataSet = new SenaExSIMSMiniEdition.senaexminidbDataSet();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.paymentsTableAdapter();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.invoiceTableAdapter();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.customersTableAdapter();
            this.fKInvItemsInvIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoice_itemsTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.invoice_itemsTableAdapter();
            this.fKInvSerInvNoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoice_serviceTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.invoice_serviceTableAdapter();
            this.vehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiclesTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.vehiclesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.senaexminidbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKInvItemsInvIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKInvSerInvNoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerMain
            // 
            this.reportViewerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerMain.Location = new System.Drawing.Point(5, 5);
            this.reportViewerMain.Name = "reportViewerMain";
            this.reportViewerMain.Size = new System.Drawing.Size(574, 452);
            this.reportViewerMain.TabIndex = 1;
            // 
            // senaexminidbDataSet
            // 
            this.senaexminidbDataSet.DataSetName = "senaexminidbDataSet";
            this.senaexminidbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "payments";
            this.paymentsBindingSource.DataSource = this.senaexminidbDataSet;
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "invoice";
            this.invoiceBindingSource.DataSource = this.senaexminidbDataSet;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "customers";
            this.customersBindingSource.DataSource = this.senaexminidbDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // fKInvItemsInvIDBindingSource
            // 
            this.fKInvItemsInvIDBindingSource.DataMember = "FK_InvItems_InvID";
            this.fKInvItemsInvIDBindingSource.DataSource = this.invoiceBindingSource;
            // 
            // invoice_itemsTableAdapter
            // 
            this.invoice_itemsTableAdapter.ClearBeforeFill = true;
            // 
            // fKInvSerInvNoBindingSource
            // 
            this.fKInvSerInvNoBindingSource.DataMember = "FK_InvSer_InvNo";
            this.fKInvSerInvNoBindingSource.DataSource = this.invoiceBindingSource;
            // 
            // invoice_serviceTableAdapter
            // 
            this.invoice_serviceTableAdapter.ClearBeforeFill = true;
            // 
            // vehiclesBindingSource
            // 
            this.vehiclesBindingSource.DataMember = "vehicles";
            this.vehiclesBindingSource.DataSource = this.senaexminidbDataSet;
            // 
            // vehiclesTableAdapter
            // 
            this.vehiclesTableAdapter.ClearBeforeFill = true;
            // 
            // ReportViewerForm_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.reportViewerMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "ReportViewerForm_Invoice";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportViewerForm_Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.senaexminidbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKInvItemsInvIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKInvSerInvNoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerMain;
        private senaexminidbDataSet senaexminidbDataSet;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private senaexminidbDataSetTableAdapters.paymentsTableAdapter paymentsTableAdapter;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private senaexminidbDataSetTableAdapters.invoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private senaexminidbDataSetTableAdapters.customersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource fKInvItemsInvIDBindingSource;
        private senaexminidbDataSetTableAdapters.invoice_itemsTableAdapter invoice_itemsTableAdapter;
        private System.Windows.Forms.BindingSource fKInvSerInvNoBindingSource;
        private senaexminidbDataSetTableAdapters.invoice_serviceTableAdapter invoice_serviceTableAdapter;
        private System.Windows.Forms.BindingSource vehiclesBindingSource;
        private senaexminidbDataSetTableAdapters.vehiclesTableAdapter vehiclesTableAdapter;
    }
}