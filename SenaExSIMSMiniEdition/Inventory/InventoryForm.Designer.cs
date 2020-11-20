namespace SenaExSIMSMiniEdition.Inventory
{
    partial class InventoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.lblBanner = new System.Windows.Forms.Label();
            this.panelBase = new System.Windows.Forms.Panel();
            this.groupBoxItemList = new System.Windows.Forms.GroupBox();
            this.dgvAllItems = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnItemAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minOrderQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxOrderQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reOrderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.senaexminidbDataSet = new SenaExSIMSMiniEdition.senaexminidbDataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new SenaExSIMSMiniEdition.Util.searchBoxUC();
            this.itemsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolAllItemsRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolAllItemsPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.itemsTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.itemsTableAdapter();
            this.panelBase.SuspendLayout();
            this.groupBoxItemList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senaexminidbDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingNavigator)).BeginInit();
            this.itemsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBanner
            // 
            this.lblBanner.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBanner.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.ForeColor = System.Drawing.Color.White;
            this.lblBanner.Location = new System.Drawing.Point(0, 0);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(654, 34);
            this.lblBanner.TabIndex = 0;
            this.lblBanner.Text = "Inventory";
            this.lblBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBase
            // 
            this.panelBase.Controls.Add(this.groupBoxItemList);
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(0, 34);
            this.panelBase.Name = "panelBase";
            this.panelBase.Padding = new System.Windows.Forms.Padding(5);
            this.panelBase.Size = new System.Drawing.Size(654, 428);
            this.panelBase.TabIndex = 1;
            // 
            // groupBoxItemList
            // 
            this.groupBoxItemList.Controls.Add(this.dgvAllItems);
            this.groupBoxItemList.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxItemList.Location = new System.Drawing.Point(5, 5);
            this.groupBoxItemList.Name = "groupBoxItemList";
            this.groupBoxItemList.Padding = new System.Windows.Forms.Padding(3, 3, 3, 7);
            this.groupBoxItemList.Size = new System.Drawing.Size(644, 418);
            this.groupBoxItemList.TabIndex = 2;
            this.groupBoxItemList.TabStop = false;
            this.groupBoxItemList.Text = "Item List";
            // 
            // dgvAllItems
            // 
            this.dgvAllItems.AllowUserToAddRows = false;
            this.dgvAllItems.AllowUserToDeleteRows = false;
            this.dgvAllItems.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnItemAI,
            this.stockDataGridViewTextBoxColumn,
            this.itemIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.purchasePriceDataGridViewTextBoxColumn,
            this.sellingPriceDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.minOrderQtyDataGridViewTextBoxColumn,
            this.maxOrderQtyDataGridViewTextBoxColumn,
            this.reOrderLevelDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn});
            this.dgvAllItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvAllItems.DataSource = this.itemsBindingSource;
            this.dgvAllItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAllItems.Location = new System.Drawing.Point(3, 41);
            this.dgvAllItems.MultiSelect = false;
            this.dgvAllItems.Name = "dgvAllItems";
            this.dgvAllItems.ReadOnly = true;
            this.dgvAllItems.RowHeadersWidth = 25;
            this.dgvAllItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAllItems.RowTemplate.Height = 28;
            this.dgvAllItems.RowTemplate.ReadOnly = true;
            this.dgvAllItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllItems.Size = new System.Drawing.Size(638, 370);
            this.dgvAllItems.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumnItemAI
            // 
            this.dataGridViewTextBoxColumnItemAI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumnItemAI.DataPropertyName = "Item_AI";
            this.dataGridViewTextBoxColumnItemAI.Frozen = true;
            this.dataGridViewTextBoxColumnItemAI.HeaderText = "#";
            this.dataGridViewTextBoxColumnItemAI.MinimumWidth = 10;
            this.dataGridViewTextBoxColumnItemAI.Name = "dataGridViewTextBoxColumnItemAI";
            this.dataGridViewTextBoxColumnItemAI.ReadOnly = true;
            this.dataGridViewTextBoxColumnItemAI.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumnItemAI.Width = 39;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0.00";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            this.stockDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.stockDataGridViewTextBoxColumn.Frozen = true;
            this.stockDataGridViewTextBoxColumn.HeaderText = "Inventory";
            this.stockDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "Item_ID";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.itemIDDataGridViewTextBoxColumn.Frozen = true;
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "Item ID";
            this.itemIDDataGridViewTextBoxColumn.MinimumWidth = 75;
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "Item_Name";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.itemNameDataGridViewTextBoxColumn.Frozen = true;
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.itemNameDataGridViewTextBoxColumn.MinimumWidth = 110;
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemNameDataGridViewTextBoxColumn.Width = 110;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchasePriceDataGridViewTextBoxColumn
            // 
            this.purchasePriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "Purchase_Price";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = "0.00";
            this.purchasePriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "Purchase Price";
            this.purchasePriceDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
            this.purchasePriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.purchasePriceDataGridViewTextBoxColumn.Width = 104;
            // 
            // sellingPriceDataGridViewTextBoxColumn
            // 
            this.sellingPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sellingPriceDataGridViewTextBoxColumn.DataPropertyName = "Selling_Price";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = "0.00";
            this.sellingPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.sellingPriceDataGridViewTextBoxColumn.HeaderText = "Selling Price";
            this.sellingPriceDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.sellingPriceDataGridViewTextBoxColumn.Name = "sellingPriceDataGridViewTextBoxColumn";
            this.sellingPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.sellingPriceDataGridViewTextBoxColumn.Width = 90;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.unitDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.MinimumWidth = 75;
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.unitDataGridViewTextBoxColumn.Width = 75;
            // 
            // minOrderQtyDataGridViewTextBoxColumn
            // 
            this.minOrderQtyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.minOrderQtyDataGridViewTextBoxColumn.DataPropertyName = "Min_Order_Qty";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = "0.00";
            this.minOrderQtyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.minOrderQtyDataGridViewTextBoxColumn.HeaderText = "Min Order Qty";
            this.minOrderQtyDataGridViewTextBoxColumn.MinimumWidth = 75;
            this.minOrderQtyDataGridViewTextBoxColumn.Name = "minOrderQtyDataGridViewTextBoxColumn";
            this.minOrderQtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.minOrderQtyDataGridViewTextBoxColumn.Width = 97;
            // 
            // maxOrderQtyDataGridViewTextBoxColumn
            // 
            this.maxOrderQtyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.maxOrderQtyDataGridViewTextBoxColumn.DataPropertyName = "Max_Order_Qty";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = "0.00";
            this.maxOrderQtyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.maxOrderQtyDataGridViewTextBoxColumn.HeaderText = "Max Order Qty";
            this.maxOrderQtyDataGridViewTextBoxColumn.MinimumWidth = 75;
            this.maxOrderQtyDataGridViewTextBoxColumn.Name = "maxOrderQtyDataGridViewTextBoxColumn";
            this.maxOrderQtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reOrderLevelDataGridViewTextBoxColumn
            // 
            this.reOrderLevelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.reOrderLevelDataGridViewTextBoxColumn.DataPropertyName = "Re_Order_Level";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = "0.00";
            this.reOrderLevelDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.reOrderLevelDataGridViewTextBoxColumn.HeaderText = "Re-Order Level";
            this.reOrderLevelDataGridViewTextBoxColumn.MinimumWidth = 75;
            this.reOrderLevelDataGridViewTextBoxColumn.Name = "reOrderLevelDataGridViewTextBoxColumn";
            this.reOrderLevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.reOrderLevelDataGridViewTextBoxColumn.Width = 104;
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
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "items";
            this.itemsBindingSource.DataSource = this.senaexminidbDataSet;
            // 
            // senaexminidbDataSet
            // 
            this.senaexminidbDataSet.DataSetName = "senaexminidbDataSet";
            this.senaexminidbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 257F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.itemsBindingNavigator, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(638, 25);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.MinimumSize = new System.Drawing.Size(198, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceHolderText = "Type Item ID | Name | Category";
            this.txtSearch.ResetButtonBackColor = System.Drawing.Color.Salmon;
            this.txtSearch.SearchButtonBackColor = System.Drawing.Color.DodgerBlue;
            this.txtSearch.SearchText = "";
            this.txtSearch.Size = new System.Drawing.Size(257, 24);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.searchTextbox_TextChanged += new System.EventHandler(this.SearchItems);
            this.txtSearch.searchButton_Click += new System.EventHandler(this.SearchItems);
            // 
            // itemsBindingNavigator
            // 
            this.itemsBindingNavigator.AddNewItem = null;
            this.itemsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.itemsBindingNavigator.DeleteItem = null;
            this.itemsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.itemsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolAllItemsRefresh,
            this.toolStripSeparator1,
            this.toolAllItemsPrint,
            this.toolStripSeparator2});
            this.itemsBindingNavigator.Location = new System.Drawing.Point(257, 0);
            this.itemsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.itemsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.itemsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.itemsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.itemsBindingNavigator.Name = "itemsBindingNavigator";
            this.itemsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.itemsBindingNavigator.Size = new System.Drawing.Size(381, 25);
            this.itemsBindingNavigator.TabIndex = 2;
            this.itemsBindingNavigator.TabStop = true;
            this.itemsBindingNavigator.Text = "bindingNavigatorItemList";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
            // toolAllItemsRefresh
            // 
            this.toolAllItemsRefresh.Image = global::SenaExSIMSMiniEdition.Properties.Resources.Refresh;
            this.toolAllItemsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAllItemsRefresh.Name = "toolAllItemsRefresh";
            this.toolAllItemsRefresh.Size = new System.Drawing.Size(66, 22);
            this.toolAllItemsRefresh.Text = "Refresh";
            this.toolAllItemsRefresh.ToolTipText = "Refresh (Ctrl+F)";
            this.toolAllItemsRefresh.Click += new System.EventHandler(this.LoadAllItems);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolAllItemsPrint
            // 
            this.toolAllItemsPrint.Image = global::SenaExSIMSMiniEdition.Properties.Resources.Print;
            this.toolAllItemsPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAllItemsPrint.Name = "toolAllItemsPrint";
            this.toolAllItemsPrint.Size = new System.Drawing.Size(100, 22);
            this.toolAllItemsPrint.Text = "Print Item List";
            this.toolAllItemsPrint.ToolTipText = "Print Item List (Ctrl+Alt+P)";
            this.toolAllItemsPrint.Click += new System.EventHandler(this.toolAllItemsPrint_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 462);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.lblBanner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(670, 500);
            this.Name = "InventoryForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.panelBase.ResumeLayout(false);
            this.groupBoxItemList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senaexminidbDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingNavigator)).EndInit();
            this.itemsBindingNavigator.ResumeLayout(false);
            this.itemsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.GroupBox groupBoxItemList;
        private System.Windows.Forms.DataGridView dgvAllItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingNavigator itemsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolAllItemsRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolAllItemsPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private Util.searchBoxUC txtSearch;
        private senaexminidbDataSet senaexminidbDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private senaexminidbDataSetTableAdapters.itemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnItemAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minOrderQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxOrderQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reOrderLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
    }
}