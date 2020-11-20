﻿namespace SenaExSIMSMiniEdition.GRN
{
    partial class SupplierListDialogBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierListDialogBox));
            this.groupBoxSupList = new System.Windows.Forms.GroupBox();
            this.dgvSupList = new System.Windows.Forms.DataGridView();
            this.supAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.senaexminidbDataSet = new SenaExSIMSMiniEdition.senaexminidbDataSet();
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
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lblSelSupIDHeader = new System.Windows.Forms.Label();
            this.panelBottons = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.suppliersTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.suppliersTableAdapter();
            this.menuStripSK = new System.Windows.Forms.MenuStrip();
            this.shortcutKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skFocusSearchBox = new System.Windows.Forms.ToolStripMenuItem();
            this.skRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSelSupNameHeader = new System.Windows.Forms.Label();
            this.groupBoxSupList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senaexminidbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            this.panelBottons.SuspendLayout();
            this.menuStripSK.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSupList
            // 
            this.groupBoxSupList.Controls.Add(this.dgvSupList);
            this.groupBoxSupList.Controls.Add(this.txtSearch);
            this.groupBoxSupList.Controls.Add(this.bindingNavigator);
            this.groupBoxSupList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSupList.Location = new System.Drawing.Point(0, 52);
            this.groupBoxSupList.Name = "groupBoxSupList";
            this.groupBoxSupList.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxSupList.Size = new System.Drawing.Size(359, 325);
            this.groupBoxSupList.TabIndex = 0;
            this.groupBoxSupList.TabStop = false;
            this.groupBoxSupList.Text = "Supplier List";
            // 
            // dgvSupList
            // 
            this.dgvSupList.AllowUserToAddRows = false;
            this.dgvSupList.AllowUserToDeleteRows = false;
            this.dgvSupList.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSupList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supAIDataGridViewTextBoxColumn,
            this.supIDDataGridViewTextBoxColumn,
            this.supNameDataGridViewTextBoxColumn});
            this.dgvSupList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvSupList.DataSource = this.suppliersBindingSource;
            this.dgvSupList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSupList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSupList.Location = new System.Drawing.Point(5, 42);
            this.dgvSupList.MultiSelect = false;
            this.dgvSupList.Name = "dgvSupList";
            this.dgvSupList.ReadOnly = true;
            this.dgvSupList.RowHeadersWidth = 24;
            this.dgvSupList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSupList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupList.Size = new System.Drawing.Size(349, 253);
            this.dgvSupList.StandardTab = true;
            this.dgvSupList.TabIndex = 2;
            this.dgvSupList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupList_CellContentDoubleClick);
            this.dgvSupList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSupList_DataBindingComplete);
            // 
            // supAIDataGridViewTextBoxColumn
            // 
            this.supAIDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.supAIDataGridViewTextBoxColumn.DataPropertyName = "Sup_AI";
            this.supAIDataGridViewTextBoxColumn.Frozen = true;
            this.supAIDataGridViewTextBoxColumn.HeaderText = "#";
            this.supAIDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.supAIDataGridViewTextBoxColumn.Name = "supAIDataGridViewTextBoxColumn";
            this.supAIDataGridViewTextBoxColumn.ReadOnly = true;
            this.supAIDataGridViewTextBoxColumn.Width = 39;
            // 
            // supIDDataGridViewTextBoxColumn
            // 
            this.supIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.supIDDataGridViewTextBoxColumn.DataPropertyName = "Sup_ID";
            this.supIDDataGridViewTextBoxColumn.Frozen = true;
            this.supIDDataGridViewTextBoxColumn.HeaderText = "Supplier ID";
            this.supIDDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.supIDDataGridViewTextBoxColumn.Name = "supIDDataGridViewTextBoxColumn";
            this.supIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.supIDDataGridViewTextBoxColumn.Width = 84;
            // 
            // supNameDataGridViewTextBoxColumn
            // 
            this.supNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.supNameDataGridViewTextBoxColumn.DataPropertyName = "Sup_Name";
            this.supNameDataGridViewTextBoxColumn.HeaderText = "Supplier\'s Name";
            this.supNameDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.supNameDataGridViewTextBoxColumn.Name = "supNameDataGridViewTextBoxColumn";
            this.supNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "suppliers";
            this.suppliersBindingSource.DataSource = this.senaexminidbDataSet;
            // 
            // senaexminidbDataSet
            // 
            this.senaexminidbDataSet.DataSetName = "senaexminidbDataSet";
            this.senaexminidbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSearch
            // 
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Location = new System.Drawing.Point(5, 18);
            this.txtSearch.MinimumSize = new System.Drawing.Size(198, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceHolderText = "Type Supplies ID | Name";
            this.txtSearch.ResetButtonBackColor = System.Drawing.Color.Salmon;
            this.txtSearch.SearchButtonBackColor = System.Drawing.Color.DodgerBlue;
            this.txtSearch.SearchText = "";
            this.txtSearch.Size = new System.Drawing.Size(349, 24);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.searchTextbox_TextChanged += new System.EventHandler(this.SearchSuppliers);
            this.txtSearch.searchButton_Click += new System.EventHandler(this.SearchSuppliers);
            this.txtSearch.searchBox_KeyDownEvent += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = null;
            this.bindingNavigator.BindingSource = this.suppliersBindingSource;
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
            this.btnRefresh,
            this.toolStripSeparator3});
            this.bindingNavigator.Location = new System.Drawing.Point(5, 295);
            this.bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator.Size = new System.Drawing.Size(349, 25);
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
            this.btnRefresh.Click += new System.EventHandler(this.SupplierListDialogBox_Load);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // lblSelSupIDHeader
            // 
            this.lblSelSupIDHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSelSupIDHeader.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Sup_ID", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.lblSelSupIDHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSelSupIDHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSelSupIDHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelSupIDHeader.ForeColor = System.Drawing.Color.White;
            this.lblSelSupIDHeader.Location = new System.Drawing.Point(0, 0);
            this.lblSelSupIDHeader.Name = "lblSelSupIDHeader";
            this.lblSelSupIDHeader.Size = new System.Drawing.Size(359, 26);
            this.lblSelSupIDHeader.TabIndex = 0;
            this.lblSelSupIDHeader.Text = "Supplier ID";
            this.lblSelSupIDHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBottons
            // 
            this.panelBottons.Controls.Add(this.btnOK);
            this.panelBottons.Controls.Add(this.btnCancel);
            this.panelBottons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottons.Location = new System.Drawing.Point(0, 377);
            this.panelBottons.Margin = new System.Windows.Forms.Padding(10);
            this.panelBottons.Name = "panelBottons";
            this.panelBottons.Size = new System.Drawing.Size(359, 39);
            this.panelBottons.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Enabled = false;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(198, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(279, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // menuStripSK
            // 
            this.menuStripSK.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shortcutKeyToolStripMenuItem});
            this.menuStripSK.Location = new System.Drawing.Point(0, 52);
            this.menuStripSK.Name = "menuStripSK";
            this.menuStripSK.Size = new System.Drawing.Size(359, 24);
            this.menuStripSK.TabIndex = 3;
            this.menuStripSK.Text = "menuStripSK";
            this.menuStripSK.Visible = false;
            // 
            // shortcutKeyToolStripMenuItem
            // 
            this.shortcutKeyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skFocusSearchBox,
            this.skRefresh});
            this.shortcutKeyToolStripMenuItem.Name = "shortcutKeyToolStripMenuItem";
            this.shortcutKeyToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.shortcutKeyToolStripMenuItem.Text = "Shortcut Key";
            // 
            // skFocusSearchBox
            // 
            this.skFocusSearchBox.Name = "skFocusSearchBox";
            this.skFocusSearchBox.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.skFocusSearchBox.Size = new System.Drawing.Size(205, 22);
            this.skFocusSearchBox.Text = "Focus Search Box";
            this.skFocusSearchBox.Click += new System.EventHandler(this.skFocusSearchBox_Click);
            // 
            // skRefresh
            // 
            this.skRefresh.Name = "skRefresh";
            this.skRefresh.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.skRefresh.Size = new System.Drawing.Size(205, 22);
            this.skRefresh.Text = "Refresh";
            this.skRefresh.Click += new System.EventHandler(this.SupplierListDialogBox_Load);
            // 
            // lblSelSupNameHeader
            // 
            this.lblSelSupNameHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSelSupNameHeader.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Sup_Name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.lblSelSupNameHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSelSupNameHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSelSupNameHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelSupNameHeader.ForeColor = System.Drawing.Color.White;
            this.lblSelSupNameHeader.Location = new System.Drawing.Point(0, 26);
            this.lblSelSupNameHeader.Name = "lblSelSupNameHeader";
            this.lblSelSupNameHeader.Size = new System.Drawing.Size(359, 26);
            this.lblSelSupNameHeader.TabIndex = 0;
            this.lblSelSupNameHeader.Text = "Supplier\'s Name";
            this.lblSelSupNameHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SupplierListDialogBox
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(359, 416);
            this.Controls.Add(this.menuStripSK);
            this.Controls.Add(this.groupBoxSupList);
            this.Controls.Add(this.panelBottons);
            this.Controls.Add(this.lblSelSupNameHeader);
            this.Controls.Add(this.lblSelSupIDHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SupplierListDialogBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Supplier";
            this.Load += new System.EventHandler(this.SupplierListDialogBox_Load);
            this.groupBoxSupList.ResumeLayout(false);
            this.groupBoxSupList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senaexminidbDataSet)).EndInit();
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

        private System.Windows.Forms.GroupBox groupBoxSupList;
        private System.Windows.Forms.DataGridView dgvSupList;
        private Util.searchBoxUC txtSearch;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label lblSelSupIDHeader;
        private System.Windows.Forms.Panel panelBottons;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private senaexminidbDataSet senaexminidbDataSet;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private senaexminidbDataSetTableAdapters.suppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn supAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStripSK;
        private System.Windows.Forms.ToolStripMenuItem shortcutKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skFocusSearchBox;
        private System.Windows.Forms.ToolStripMenuItem skRefresh;
        private System.Windows.Forms.Label lblSelSupNameHeader;
    }
}