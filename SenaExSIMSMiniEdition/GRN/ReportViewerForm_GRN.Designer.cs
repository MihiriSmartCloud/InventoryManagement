namespace SenaExSIMSMiniEdition.GRN
{
    partial class ReportViewerForm_GRN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportViewerForm_GRN));
            this.reportViewerMain = new Microsoft.Reporting.WinForms.ReportViewer();
            this.senaexminidbDataSet = new SenaExSIMSMiniEdition.senaexminidbDataSet();
            this.grnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grnTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.grnTableAdapter();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.suppliersTableAdapter();
            this.grndetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grn_detailsTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.grn_detailsTableAdapter();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.paymentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.senaexminidbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grndetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
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
            // grnBindingSource
            // 
            this.grnBindingSource.DataMember = "grn";
            this.grnBindingSource.DataSource = this.senaexminidbDataSet;
            // 
            // grnTableAdapter
            // 
            this.grnTableAdapter.ClearBeforeFill = true;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "suppliers";
            this.suppliersBindingSource.DataSource = this.senaexminidbDataSet;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // grndetailsBindingSource
            // 
            this.grndetailsBindingSource.DataMember = "grn_details";
            this.grndetailsBindingSource.DataSource = this.senaexminidbDataSet;
            // 
            // grn_detailsTableAdapter
            // 
            this.grn_detailsTableAdapter.ClearBeforeFill = true;
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
            // ReportViewerForm_GRN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.reportViewerMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "ReportViewerForm_GRN";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportViewerForm_GRN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.senaexminidbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grndetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerMain;
        private senaexminidbDataSet senaexminidbDataSet;
        private System.Windows.Forms.BindingSource grnBindingSource;
        private senaexminidbDataSetTableAdapters.grnTableAdapter grnTableAdapter;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private senaexminidbDataSetTableAdapters.suppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.BindingSource grndetailsBindingSource;
        private senaexminidbDataSetTableAdapters.grn_detailsTableAdapter grn_detailsTableAdapter;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private senaexminidbDataSetTableAdapters.paymentsTableAdapter paymentsTableAdapter;
    }
}