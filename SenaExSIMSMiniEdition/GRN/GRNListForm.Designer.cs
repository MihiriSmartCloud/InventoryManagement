namespace SenaExSIMSMiniEdition.GRN
{
    partial class GRNListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GRNListForm));
            this.lblSelGRNHeader = new System.Windows.Forms.Label();
            this.grnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.senaexminidbDataSet = new SenaExSIMSMiniEdition.senaexminidbDataSet();
            this.groupBoxGRNList = new System.Windows.Forms.GroupBox();
            this.dgvGRNList = new System.Windows.Forms.DataGridView();
            this.gRNAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRNNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRN_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Received_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PO_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invoice_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialDiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new SenaExSIMSMiniEdition.Util.searchBoxUC();
            this.bindingNavigatorGRNList = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.grnTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.grnTableAdapter();
            this.menuStripSK = new System.Windows.Forms.MenuStrip();
            this.shortcutKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skFocusSrearchBox = new System.Windows.Forms.ToolStripMenuItem();
            this.skRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.skPrint = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senaexminidbDataSet)).BeginInit();
            this.groupBoxGRNList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGRNList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorGRNList)).BeginInit();
            this.bindingNavigatorGRNList.SuspendLayout();
            this.panelBottons.SuspendLayout();
            this.menuStripSK.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelGRNHeader
            // 
            this.lblSelGRNHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSelGRNHeader.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grnBindingSource, "GRN_No", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.lblSelGRNHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSelGRNHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSelGRNHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelGRNHeader.ForeColor = System.Drawing.Color.White;
            this.lblSelGRNHeader.Location = new System.Drawing.Point(0, 0);
            this.lblSelGRNHeader.Name = "lblSelGRNHeader";
            this.lblSelGRNHeader.Size = new System.Drawing.Size(564, 26);
            this.lblSelGRNHeader.TabIndex = 0;
            this.lblSelGRNHeader.Text = "Selected GRN";
            this.lblSelGRNHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // groupBoxGRNList
            // 
            this.groupBoxGRNList.Controls.Add(this.dgvGRNList);
            this.groupBoxGRNList.Controls.Add(this.txtSearch);
            this.groupBoxGRNList.Controls.Add(this.bindingNavigatorGRNList);
            this.groupBoxGRNList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxGRNList.Location = new System.Drawing.Point(0, 26);
            this.groupBoxGRNList.Name = "groupBoxGRNList";
            this.groupBoxGRNList.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxGRNList.Size = new System.Drawing.Size(564, 396);
            this.groupBoxGRNList.TabIndex = 1;
            this.groupBoxGRNList.TabStop = false;
            this.groupBoxGRNList.Text = "GRN List";
            // 
            // dgvGRNList
            // 
            this.dgvGRNList.AllowUserToAddRows = false;
            this.dgvGRNList.AllowUserToDeleteRows = false;
            this.dgvGRNList.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGRNList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGRNList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gRNAIDataGridViewTextBoxColumn,
            this.gRNNoDataGridViewTextBoxColumn,
            this.GRN_Date,
            this.Received_Date,
            this.PO_No,
            this.Invoice_No,
            this.supIDDataGridViewTextBoxColumn,
            this.specialDiscountDataGridViewTextBoxColumn,
            this.totalDiscountDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn});
            this.dgvGRNList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvGRNList.DataSource = this.grnBindingSource;
            this.dgvGRNList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGRNList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGRNList.Location = new System.Drawing.Point(5, 42);
            this.dgvGRNList.MultiSelect = false;
            this.dgvGRNList.Name = "dgvGRNList";
            this.dgvGRNList.ReadOnly = true;
            this.dgvGRNList.RowHeadersWidth = 24;
            this.dgvGRNList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvGRNList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGRNList.Size = new System.Drawing.Size(554, 324);
            this.dgvGRNList.TabIndex = 2;
            this.dgvGRNList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGRNList_CellContentDoubleClick);
            this.dgvGRNList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvGRNList_DataBindingComplete);
            // 
            // gRNAIDataGridViewTextBoxColumn
            // 
            this.gRNAIDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.gRNAIDataGridViewTextBoxColumn.DataPropertyName = "GRN_AI";
            this.gRNAIDataGridViewTextBoxColumn.Frozen = true;
            this.gRNAIDataGridViewTextBoxColumn.HeaderText = "#";
            this.gRNAIDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.gRNAIDataGridViewTextBoxColumn.Name = "gRNAIDataGridViewTextBoxColumn";
            this.gRNAIDataGridViewTextBoxColumn.ReadOnly = true;
            this.gRNAIDataGridViewTextBoxColumn.Width = 10;
            // 
            // gRNNoDataGridViewTextBoxColumn
            // 
            this.gRNNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gRNNoDataGridViewTextBoxColumn.DataPropertyName = "GRN_No";
            this.gRNNoDataGridViewTextBoxColumn.Frozen = true;
            this.gRNNoDataGridViewTextBoxColumn.HeaderText = "GRN No";
            this.gRNNoDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.gRNNoDataGridViewTextBoxColumn.Name = "gRNNoDataGridViewTextBoxColumn";
            this.gRNNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.gRNNoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gRNNoDataGridViewTextBoxColumn.Width = 70;
            // 
            // GRN_Date
            // 
            this.GRN_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GRN_Date.DataPropertyName = "GRN_Date";
            this.GRN_Date.HeaderText = "GRN Date";
            this.GRN_Date.MinimumWidth = 60;
            this.GRN_Date.Name = "GRN_Date";
            this.GRN_Date.ReadOnly = true;
            this.GRN_Date.Width = 82;
            // 
            // Received_Date
            // 
            this.Received_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Received_Date.DataPropertyName = "Received_Date";
            this.Received_Date.HeaderText = "Received Date";
            this.Received_Date.MinimumWidth = 60;
            this.Received_Date.Name = "Received_Date";
            this.Received_Date.ReadOnly = true;
            this.Received_Date.Width = 104;
            // 
            // PO_No
            // 
            this.PO_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PO_No.DataPropertyName = "PO_No";
            this.PO_No.HeaderText = "PO No";
            this.PO_No.MinimumWidth = 90;
            this.PO_No.Name = "PO_No";
            this.PO_No.ReadOnly = true;
            this.PO_No.Width = 90;
            // 
            // Invoice_No
            // 
            this.Invoice_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Invoice_No.DataPropertyName = "Invoice_No";
            this.Invoice_No.HeaderText = "Invoice No";
            this.Invoice_No.MinimumWidth = 90;
            this.Invoice_No.Name = "Invoice_No";
            this.Invoice_No.ReadOnly = true;
            this.Invoice_No.Width = 90;
            // 
            // supIDDataGridViewTextBoxColumn
            // 
            this.supIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.supIDDataGridViewTextBoxColumn.DataPropertyName = "Sup_ID";
            this.supIDDataGridViewTextBoxColumn.HeaderText = "Sup ID";
            this.supIDDataGridViewTextBoxColumn.MinimumWidth = 60;
            this.supIDDataGridViewTextBoxColumn.Name = "supIDDataGridViewTextBoxColumn";
            this.supIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.supIDDataGridViewTextBoxColumn.Width = 65;
            // 
            // specialDiscountDataGridViewTextBoxColumn
            // 
            this.specialDiscountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.specialDiscountDataGridViewTextBoxColumn.DataPropertyName = "Special_Discount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.specialDiscountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.specialDiscountDataGridViewTextBoxColumn.HeaderText = "Special Discount";
            this.specialDiscountDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.specialDiscountDataGridViewTextBoxColumn.Name = "specialDiscountDataGridViewTextBoxColumn";
            this.specialDiscountDataGridViewTextBoxColumn.ReadOnly = true;
            this.specialDiscountDataGridViewTextBoxColumn.Width = 112;
            // 
            // totalDiscountDataGridViewTextBoxColumn
            // 
            this.totalDiscountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.totalDiscountDataGridViewTextBoxColumn.DataPropertyName = "Total_Discount";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.totalDiscountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalDiscountDataGridViewTextBoxColumn.HeaderText = "Total Discount";
            this.totalDiscountDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.totalDiscountDataGridViewTextBoxColumn.Name = "totalDiscountDataGridViewTextBoxColumn";
            this.totalDiscountDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDiscountDataGridViewTextBoxColumn.Width = 101;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "Total_Amount";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = "0.00";
            this.totalAmountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "Total Amount";
            this.totalAmountDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalAmountDataGridViewTextBoxColumn.Width = 95;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 80;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Location = new System.Drawing.Point(5, 18);
            this.txtSearch.MinimumSize = new System.Drawing.Size(198, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceHolderText = "Type GRN No| Invoice No| PO No";
            this.txtSearch.ResetButtonBackColor = System.Drawing.Color.Salmon;
            this.txtSearch.SearchButtonBackColor = System.Drawing.Color.DodgerBlue;
            this.txtSearch.SearchText = "";
            this.txtSearch.Size = new System.Drawing.Size(554, 24);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.searchTextbox_TextChanged += new System.EventHandler(this.searchGRN);
            this.txtSearch.searchButton_Click += new System.EventHandler(this.searchGRN);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // bindingNavigatorGRNList
            // 
            this.bindingNavigatorGRNList.AddNewItem = null;
            this.bindingNavigatorGRNList.BindingSource = this.grnBindingSource;
            this.bindingNavigatorGRNList.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorGRNList.DeleteItem = null;
            this.bindingNavigatorGRNList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigatorGRNList.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigatorGRNList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorGRNList.Location = new System.Drawing.Point(5, 366);
            this.bindingNavigatorGRNList.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorGRNList.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorGRNList.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorGRNList.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorGRNList.Name = "bindingNavigatorGRNList";
            this.bindingNavigatorGRNList.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorGRNList.Size = new System.Drawing.Size(554, 25);
            this.bindingNavigatorGRNList.TabIndex = 3;
            this.bindingNavigatorGRNList.Text = "bindingNavigatorGRNList";
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
            this.btnRefresh.Click += new System.EventHandler(this.loadAllGRN);
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
            // grnTableAdapter
            // 
            this.grnTableAdapter.ClearBeforeFill = true;
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
            this.skRefresh.Click += new System.EventHandler(this.loadAllGRN);
            // 
            // skPrint
            // 
            this.skPrint.Name = "skPrint";
            this.skPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.skPrint.Size = new System.Drawing.Size(209, 22);
            this.skPrint.Text = "Print";
            this.skPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // GRNListForm
            // 
            this.AcceptButton = this.btnLoad;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(564, 461);
            this.Controls.Add(this.groupBoxGRNList);
            this.Controls.Add(this.lblSelGRNHeader);
            this.Controls.Add(this.panelBottons);
            this.Controls.Add(this.menuStripSK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripSK;
            this.MinimizeBox = false;
            this.Name = "GRNListForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load Previous GRN";
            this.Load += new System.EventHandler(this.GRNListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senaexminidbDataSet)).EndInit();
            this.groupBoxGRNList.ResumeLayout(false);
            this.groupBoxGRNList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGRNList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorGRNList)).EndInit();
            this.bindingNavigatorGRNList.ResumeLayout(false);
            this.bindingNavigatorGRNList.PerformLayout();
            this.panelBottons.ResumeLayout(false);
            this.menuStripSK.ResumeLayout(false);
            this.menuStripSK.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelGRNHeader;
        private System.Windows.Forms.GroupBox groupBoxGRNList;
        private System.Windows.Forms.BindingNavigator bindingNavigatorGRNList;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dgvGRNList;
        private Util.searchBoxUC txtSearch;
        private System.Windows.Forms.Panel panelBottons;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCancel;
        private senaexminidbDataSet senaexminidbDataSet;
        private System.Windows.Forms.BindingSource grnBindingSource;
        private senaexminidbDataSetTableAdapters.grnTableAdapter grnTableAdapter;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn gRNAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRNNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRN_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Received_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn PO_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invoice_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn supIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialDiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
    }
}