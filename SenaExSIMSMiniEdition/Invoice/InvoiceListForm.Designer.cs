namespace SenaExSIMSMiniEdition.Invoice
{
    partial class InvoiceListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceListForm));
            this.lblSelInvoiceHeader = new System.Windows.Forms.Label();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.senaexminidbDataSet = new SenaExSIMSMiniEdition.senaexminidbDataSet();
            this.groupBoxInvoiceList = new System.Windows.Forms.GroupBox();
            this.dgvInvoiceList = new System.Windows.Forms.DataGridView();
            this.Inv_AI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new SenaExSIMSMiniEdition.Util.searchBoxUC();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.panelBottons = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.menuStripSK = new System.Windows.Forms.MenuStrip();
            this.shortcutKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skFocusSrearchBox = new System.Windows.Forms.ToolStripMenuItem();
            this.skRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.skPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.invoiceTableAdapter();
            this.tableAdapterManager = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senaexminidbDataSet)).BeginInit();
            this.groupBoxInvoiceList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            this.panelBottons.SuspendLayout();
            this.menuStripSK.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelInvoiceHeader
            // 
            this.lblSelInvoiceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSelInvoiceHeader.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "Inv_No", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.lblSelInvoiceHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSelInvoiceHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSelInvoiceHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelInvoiceHeader.ForeColor = System.Drawing.Color.White;
            this.lblSelInvoiceHeader.Location = new System.Drawing.Point(0, 0);
            this.lblSelInvoiceHeader.Name = "lblSelInvoiceHeader";
            this.lblSelInvoiceHeader.Size = new System.Drawing.Size(564, 26);
            this.lblSelInvoiceHeader.TabIndex = 0;
            this.lblSelInvoiceHeader.Text = "Selected Invoice";
            this.lblSelInvoiceHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "invoice";
            this.invoiceBindingSource.DataSource = this.senaexminidbDataSet;
            // 
            // senaexminidbDataSet
            // 
            this.senaexminidbDataSet.DataSetName = "senaexminidbDataSet";
            this.senaexminidbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBoxInvoiceList
            // 
            this.groupBoxInvoiceList.Controls.Add(this.dgvInvoiceList);
            this.groupBoxInvoiceList.Controls.Add(this.txtSearch);
            this.groupBoxInvoiceList.Controls.Add(this.bindingNavigator);
            this.groupBoxInvoiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInvoiceList.Location = new System.Drawing.Point(0, 26);
            this.groupBoxInvoiceList.Name = "groupBoxInvoiceList";
            this.groupBoxInvoiceList.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxInvoiceList.Size = new System.Drawing.Size(564, 396);
            this.groupBoxInvoiceList.TabIndex = 1;
            this.groupBoxInvoiceList.TabStop = false;
            this.groupBoxInvoiceList.Text = "Invoice List";
            // 
            // dgvInvoiceList
            // 
            this.dgvInvoiceList.AllowUserToAddRows = false;
            this.dgvInvoiceList.AllowUserToDeleteRows = false;
            this.dgvInvoiceList.AutoGenerateColumns = false;
            this.dgvInvoiceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoiceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Inv_AI,
            this.invNoDataGridViewTextBoxColumn,
            this.invDateDataGridViewTextBoxColumn,
            this.jobNoDataGridViewTextBoxColumn,
            this.custIDDataGridViewTextBoxColumn,
            this.vehicleNoDataGridViewTextBoxColumn,
            this.meterDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn});
            this.dgvInvoiceList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvInvoiceList.DataSource = this.invoiceBindingSource;
            this.dgvInvoiceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoiceList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInvoiceList.Location = new System.Drawing.Point(5, 42);
            this.dgvInvoiceList.MultiSelect = false;
            this.dgvInvoiceList.Name = "dgvInvoiceList";
            this.dgvInvoiceList.ReadOnly = true;
            this.dgvInvoiceList.RowHeadersWidth = 24;
            this.dgvInvoiceList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInvoiceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoiceList.Size = new System.Drawing.Size(554, 324);
            this.dgvInvoiceList.TabIndex = 2;
            this.dgvInvoiceList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoiceList_CellContentDoubleClick);
            this.dgvInvoiceList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvInvoiceList_DataBindingComplete);
            // 
            // Inv_AI
            // 
            this.Inv_AI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Inv_AI.DataPropertyName = "Inv_AI";
            this.Inv_AI.Frozen = true;
            this.Inv_AI.HeaderText = "#";
            this.Inv_AI.MinimumWidth = 15;
            this.Inv_AI.Name = "Inv_AI";
            this.Inv_AI.ReadOnly = true;
            this.Inv_AI.Width = 39;
            // 
            // invNoDataGridViewTextBoxColumn
            // 
            this.invNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.invNoDataGridViewTextBoxColumn.DataPropertyName = "Inv_No";
            this.invNoDataGridViewTextBoxColumn.Frozen = true;
            this.invNoDataGridViewTextBoxColumn.HeaderText = "Invoice No";
            this.invNoDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.invNoDataGridViewTextBoxColumn.Name = "invNoDataGridViewTextBoxColumn";
            this.invNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.invNoDataGridViewTextBoxColumn.Width = 84;
            // 
            // invDateDataGridViewTextBoxColumn
            // 
            this.invDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.invDateDataGridViewTextBoxColumn.DataPropertyName = "Inv_Date";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.invDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.invDateDataGridViewTextBoxColumn.Frozen = true;
            this.invDateDataGridViewTextBoxColumn.HeaderText = "Invoice Date";
            this.invDateDataGridViewTextBoxColumn.MinimumWidth = 90;
            this.invDateDataGridViewTextBoxColumn.Name = "invDateDataGridViewTextBoxColumn";
            this.invDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.invDateDataGridViewTextBoxColumn.Width = 93;
            // 
            // jobNoDataGridViewTextBoxColumn
            // 
            this.jobNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.jobNoDataGridViewTextBoxColumn.DataPropertyName = "Job_No";
            this.jobNoDataGridViewTextBoxColumn.HeaderText = "Job No";
            this.jobNoDataGridViewTextBoxColumn.MinimumWidth = 65;
            this.jobNoDataGridViewTextBoxColumn.Name = "jobNoDataGridViewTextBoxColumn";
            this.jobNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobNoDataGridViewTextBoxColumn.Width = 66;
            // 
            // custIDDataGridViewTextBoxColumn
            // 
            this.custIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.custIDDataGridViewTextBoxColumn.DataPropertyName = "Cust_ID";
            this.custIDDataGridViewTextBoxColumn.HeaderText = "Customer ID";
            this.custIDDataGridViewTextBoxColumn.MinimumWidth = 90;
            this.custIDDataGridViewTextBoxColumn.Name = "custIDDataGridViewTextBoxColumn";
            this.custIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.custIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // vehicleNoDataGridViewTextBoxColumn
            // 
            this.vehicleNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.vehicleNoDataGridViewTextBoxColumn.DataPropertyName = "Vehicle_No";
            this.vehicleNoDataGridViewTextBoxColumn.HeaderText = "Vehicle No";
            this.vehicleNoDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.vehicleNoDataGridViewTextBoxColumn.Name = "vehicleNoDataGridViewTextBoxColumn";
            this.vehicleNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.vehicleNoDataGridViewTextBoxColumn.Width = 84;
            // 
            // meterDataGridViewTextBoxColumn
            // 
            this.meterDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.meterDataGridViewTextBoxColumn.DataPropertyName = "Meter";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.meterDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.meterDataGridViewTextBoxColumn.HeaderText = "Meter";
            this.meterDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.meterDataGridViewTextBoxColumn.Name = "meterDataGridViewTextBoxColumn";
            this.meterDataGridViewTextBoxColumn.ReadOnly = true;
            this.meterDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.meterDataGridViewTextBoxColumn.Width = 70;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.discountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            this.discountDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "Total_Amount";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = "0.00";
            this.totalAmountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "Total Amount";
            this.totalAmountDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.ReadOnly = true;
            this.remarksDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtSearch
            // 
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Location = new System.Drawing.Point(5, 18);
            this.txtSearch.MinimumSize = new System.Drawing.Size(198, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceHolderText = "Type Invoice No| Job No | Vehicle No";
            this.txtSearch.ResetButtonBackColor = System.Drawing.Color.Salmon;
            this.txtSearch.SearchButtonBackColor = System.Drawing.Color.DodgerBlue;
            this.txtSearch.SearchText = "";
            this.txtSearch.Size = new System.Drawing.Size(554, 24);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.searchTextbox_TextChanged += new System.EventHandler(this.searchInvoice);
            this.txtSearch.searchButton_Click += new System.EventHandler(this.searchInvoice);
            this.txtSearch.searchBox_KeyDownEvent += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = null;
            this.bindingNavigator.BindingSource = this.invoiceBindingSource;
            this.bindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator.DeleteItem = null;
            this.bindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripSeparator1,
            this.btnPrint,
            this.toolStripSeparator2,
            this.btnRefresh,
            this.toolStripSeparator3});
            this.bindingNavigator.Location = new System.Drawing.Point(5, 366);
            this.bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator.Size = new System.Drawing.Size(554, 25);
            this.bindingNavigator.TabIndex = 3;
            this.bindingNavigator.Text = "bindingNavigatorGRNList";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPrint
            // 
            this.btnPrint.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Image = global::SenaExSIMSMiniEdition.Properties.Resources.Print;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(54, 22);
            this.btnPrint.Text = "Print";
            this.btnPrint.ToolTipText = "Print (Ctrl + P)";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Image = global::SenaExSIMSMiniEdition.Properties.Resources.Refresh;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(71, 22);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.ToolTipText = "Refresh (Ctrl + F)";
            this.btnRefresh.Click += new System.EventHandler(this.loadAllInvoice);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // panelBottons
            // 
            this.panelBottons.Controls.Add(this.btnLoad);
            this.panelBottons.Controls.Add(this.btnCancel);
            this.panelBottons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottons.Location = new System.Drawing.Point(0, 422);
            this.panelBottons.Margin = new System.Windows.Forms.Padding(10);
            this.panelBottons.Name = "panelBottons";
            this.panelBottons.Size = new System.Drawing.Size(564, 39);
            this.panelBottons.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.Enabled = false;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(403, 6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(484, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // menuStripSK
            // 
            this.menuStripSK.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shortcutKeyToolStripMenuItem});
            this.menuStripSK.Location = new System.Drawing.Point(0, 0);
            this.menuStripSK.Name = "menuStripSK";
            this.menuStripSK.Size = new System.Drawing.Size(564, 24);
            this.menuStripSK.TabIndex = 0;
            this.menuStripSK.Text = "menuStripSK";
            this.menuStripSK.Visible = false;
            // 
            // shortcutKeyToolStripMenuItem
            // 
            this.shortcutKeyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skFocusSrearchBox,
            this.skRefresh,
            this.skPrint});
            this.shortcutKeyToolStripMenuItem.Name = "shortcutKeyToolStripMenuItem";
            this.shortcutKeyToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.shortcutKeyToolStripMenuItem.Text = "Shortcut Key";
            // 
            // skFocusSrearchBox
            // 
            this.skFocusSrearchBox.Name = "skFocusSrearchBox";
            this.skFocusSrearchBox.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.skFocusSrearchBox.Size = new System.Drawing.Size(209, 22);
            this.skFocusSrearchBox.Text = "Focus Srearch Box";
            this.skFocusSrearchBox.Click += new System.EventHandler(this.skFocusSrearchBox_Click);
            // 
            // skRefresh
            // 
            this.skRefresh.Name = "skRefresh";
            this.skRefresh.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.skRefresh.Size = new System.Drawing.Size(209, 22);
            this.skRefresh.Text = "Refresh";
            this.skRefresh.Click += new System.EventHandler(this.loadAllInvoice);
            // 
            // skPrint
            // 
            this.skPrint.Name = "skPrint";
            this.skPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.skPrint.Size = new System.Drawing.Size(209, 22);
            this.skPrint.Text = "Print";
            this.skPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriesTableAdapter = null;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.grn_detailsTableAdapter = null;
            this.tableAdapterManager.grnTableAdapter = null;
            this.tableAdapterManager.invoice_itemsTableAdapter = null;
            this.tableAdapterManager.invoice_serviceTableAdapter = null;
            this.tableAdapterManager.invoiceTableAdapter = this.invoiceTableAdapter;
            this.tableAdapterManager.itemsTableAdapter = null;
            this.tableAdapterManager.paymentsTableAdapter = null;
            this.tableAdapterManager.rolesTableAdapter = null;
            this.tableAdapterManager.service_typesTableAdapter = null;
            this.tableAdapterManager.suppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.vehiclesTableAdapter = null;
            // 
            // InvoiceListForm
            // 
            this.AcceptButton = this.btnLoad;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(564, 461);
            this.Controls.Add(this.groupBoxInvoiceList);
            this.Controls.Add(this.lblSelInvoiceHeader);
            this.Controls.Add(this.panelBottons);
            this.Controls.Add(this.menuStripSK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripSK;
            this.MinimizeBox = false;
            this.Name = "InvoiceListForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load Previous Invoice";
            this.Load += new System.EventHandler(this.InvoiceListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senaexminidbDataSet)).EndInit();
            this.groupBoxInvoiceList.ResumeLayout(false);
            this.groupBoxInvoiceList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            this.panelBottons.ResumeLayout(false);
            this.menuStripSK.ResumeLayout(false);
            this.menuStripSK.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelInvoiceHeader;
        private System.Windows.Forms.GroupBox groupBoxInvoiceList;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dgvInvoiceList;
        private Util.searchBoxUC txtSearch;
        private System.Windows.Forms.Panel panelBottons;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCancel;
        private senaexminidbDataSet senaexminidbDataSet;
        private System.Windows.Forms.MenuStrip menuStripSK;
        private System.Windows.Forms.ToolStripMenuItem shortcutKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skFocusSrearchBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem skRefresh;
        private System.Windows.Forms.ToolStripMenuItem skPrint;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private senaexminidbDataSetTableAdapters.invoiceTableAdapter invoiceTableAdapter;
        private senaexminidbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv_AI;
        private System.Windows.Forms.DataGridViewTextBoxColumn invNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
    }
}