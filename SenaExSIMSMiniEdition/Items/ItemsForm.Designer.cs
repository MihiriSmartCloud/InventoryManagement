namespace SenaExSIMSMiniEdition.Items
{
    partial class ItemsForm
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
            System.Windows.Forms.Label item_IDLabel;
            System.Windows.Forms.Label item_NameLabel;
            System.Windows.Forms.Label sup_IDLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label purchase_PriceLabel;
            System.Windows.Forms.Label selling_PriceLabel;
            System.Windows.Forms.Label unitLabel;
            System.Windows.Forms.Label min_Order_QtyLabel;
            System.Windows.Forms.Label max_Order_QtyLabel;
            System.Windows.Forms.Label re_Order_LevelLabel;
            System.Windows.Forms.Label remarksLabel;
            System.Windows.Forms.Label stockLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBanner = new System.Windows.Forms.Label();
            this.groupBoxCurSel = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBoxSupButtons = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBoxItemFields = new System.Windows.Forms.GroupBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.senaexminidbDataSet = new SenaExSIMSMiniEdition.senaexminidbDataSet();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.nudReorderLevel = new System.Windows.Forms.NumericUpDown();
            this.lblItem_ID = new System.Windows.Forms.Label();
            this.txtItem_Name = new System.Windows.Forms.TextBox();
            this.nudMaxQty = new System.Windows.Forms.NumericUpDown();
            this.cmbSup_ID = new System.Windows.Forms.ComboBox();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nudMinQty = new System.Windows.Forms.NumericUpDown();
            this.lblSup_Name = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nudPchsPrice = new System.Windows.Forms.NumericUpDown();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.nudSellingPrice = new System.Windows.Forms.NumericUpDown();
            this.lblItemHeader = new System.Windows.Forms.Label();
            this.lblItemIDHeader = new System.Windows.Forms.Label();
            this.dgvAllItems = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnItemAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBoxItemList = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new SenaExSIMSMiniEdition.Util.searchBoxUC();
            this.panelBase = new System.Windows.Forms.Panel();
            this.itemsTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.itemsTableAdapter();
            this.tableAdapterManager = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.TableAdapterManager();
            this.suppliersTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.suppliersTableAdapter();
            this.categoriesTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.categoriesTableAdapter();
            this.menuStrip_SK = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSK_Reset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrintAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSK_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            item_IDLabel = new System.Windows.Forms.Label();
            item_NameLabel = new System.Windows.Forms.Label();
            sup_IDLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            purchase_PriceLabel = new System.Windows.Forms.Label();
            selling_PriceLabel = new System.Windows.Forms.Label();
            unitLabel = new System.Windows.Forms.Label();
            min_Order_QtyLabel = new System.Windows.Forms.Label();
            max_Order_QtyLabel = new System.Windows.Forms.Label();
            re_Order_LevelLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            this.groupBoxCurSel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxSupButtons.SuspendLayout();
            this.groupBoxItemFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senaexminidbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReorderLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPchsPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSellingPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingNavigator)).BeginInit();
            this.itemsBindingNavigator.SuspendLayout();
            this.groupBoxItemList.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelBase.SuspendLayout();
            this.menuStrip_SK.SuspendLayout();
            this.SuspendLayout();
            // 
            // item_IDLabel
            // 
            item_IDLabel.AutoSize = true;
            item_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            item_IDLabel.Location = new System.Drawing.Point(113, 11);
            item_IDLabel.Name = "item_IDLabel";
            item_IDLabel.Size = new System.Drawing.Size(44, 13);
            item_IDLabel.TabIndex = 0;
            item_IDLabel.Text = "Item ID:";
            // 
            // item_NameLabel
            // 
            item_NameLabel.AutoSize = true;
            item_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            item_NameLabel.Location = new System.Drawing.Point(113, 38);
            item_NameLabel.Name = "item_NameLabel";
            item_NameLabel.Size = new System.Drawing.Size(61, 13);
            item_NameLabel.TabIndex = 0;
            item_NameLabel.Text = "Item Name:";
            // 
            // sup_IDLabel
            // 
            sup_IDLabel.AutoSize = true;
            sup_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sup_IDLabel.Location = new System.Drawing.Point(113, 64);
            sup_IDLabel.Name = "sup_IDLabel";
            sup_IDLabel.Size = new System.Drawing.Size(62, 13);
            sup_IDLabel.TabIndex = 0;
            sup_IDLabel.Text = "Supplier ID:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoryLabel.Location = new System.Drawing.Point(113, 91);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(52, 13);
            categoryLabel.TabIndex = 0;
            categoryLabel.Text = "Category:";
            // 
            // purchase_PriceLabel
            // 
            purchase_PriceLabel.AutoSize = true;
            purchase_PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            purchase_PriceLabel.Location = new System.Drawing.Point(113, 119);
            purchase_PriceLabel.Name = "purchase_PriceLabel";
            purchase_PriceLabel.Size = new System.Drawing.Size(82, 13);
            purchase_PriceLabel.TabIndex = 0;
            purchase_PriceLabel.Text = "Purchase Price:";
            // 
            // selling_PriceLabel
            // 
            selling_PriceLabel.AutoSize = true;
            selling_PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            selling_PriceLabel.Location = new System.Drawing.Point(113, 147);
            selling_PriceLabel.Name = "selling_PriceLabel";
            selling_PriceLabel.Size = new System.Drawing.Size(68, 13);
            selling_PriceLabel.TabIndex = 0;
            selling_PriceLabel.Text = "Selling Price:";
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            unitLabel.Location = new System.Drawing.Point(113, 173);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new System.Drawing.Size(29, 13);
            unitLabel.TabIndex = 0;
            unitLabel.Text = "Unit:";
            // 
            // min_Order_QtyLabel
            // 
            min_Order_QtyLabel.AutoSize = true;
            min_Order_QtyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            min_Order_QtyLabel.Location = new System.Drawing.Point(311, 92);
            min_Order_QtyLabel.Name = "min_Order_QtyLabel";
            min_Order_QtyLabel.Size = new System.Drawing.Size(75, 13);
            min_Order_QtyLabel.TabIndex = 0;
            min_Order_QtyLabel.Text = "Min Order Qty:";
            // 
            // max_Order_QtyLabel
            // 
            max_Order_QtyLabel.AutoSize = true;
            max_Order_QtyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            max_Order_QtyLabel.Location = new System.Drawing.Point(311, 119);
            max_Order_QtyLabel.Name = "max_Order_QtyLabel";
            max_Order_QtyLabel.Size = new System.Drawing.Size(78, 13);
            max_Order_QtyLabel.TabIndex = 0;
            max_Order_QtyLabel.Text = "Max Order Qty:";
            // 
            // re_Order_LevelLabel
            // 
            re_Order_LevelLabel.AutoSize = true;
            re_Order_LevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            re_Order_LevelLabel.Location = new System.Drawing.Point(311, 147);
            re_Order_LevelLabel.Name = "re_Order_LevelLabel";
            re_Order_LevelLabel.Size = new System.Drawing.Size(82, 13);
            re_Order_LevelLabel.TabIndex = 0;
            re_Order_LevelLabel.Text = "Re Order Level:";
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            remarksLabel.Location = new System.Drawing.Point(483, 92);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(52, 13);
            remarksLabel.TabIndex = 22;
            remarksLabel.Text = "Remarks:";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stockLabel.Location = new System.Drawing.Point(311, 173);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(79, 13);
            stockLabel.TabIndex = 0;
            stockLabel.Text = "Stock In Hand:";
            // 
            // lblBanner
            // 
            this.lblBanner.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBanner.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.ForeColor = System.Drawing.Color.White;
            this.lblBanner.Location = new System.Drawing.Point(0, 0);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(644, 34);
            this.lblBanner.TabIndex = 0;
            this.lblBanner.Text = "Items";
            this.lblBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBanner.Click += new System.EventHandler(this.lblBanner_Click);
            // 
            // groupBoxCurSel
            // 
            this.groupBoxCurSel.Controls.Add(this.groupBox3);
            this.groupBoxCurSel.Controls.Add(this.lblItemHeader);
            this.groupBoxCurSel.Controls.Add(this.lblItemIDHeader);
            this.groupBoxCurSel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxCurSel.Location = new System.Drawing.Point(5, 256);
            this.groupBoxCurSel.Name = "groupBoxCurSel";
            this.groupBoxCurSel.Size = new System.Drawing.Size(634, 286);
            this.groupBoxCurSel.TabIndex = 2;
            this.groupBoxCurSel.TabStop = false;
            this.groupBoxCurSel.Text = "Current Selection";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBoxSupButtons);
            this.groupBox3.Controls.Add(this.groupBoxItemFields);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.groupBox3.Size = new System.Drawing.Size(628, 216);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details of Item";
            // 
            // groupBoxSupButtons
            // 
            this.groupBoxSupButtons.Controls.Add(this.btnPrint);
            this.groupBoxSupButtons.Controls.Add(this.btnDelete);
            this.groupBoxSupButtons.Controls.Add(this.btnUpdate);
            this.groupBoxSupButtons.Controls.Add(this.btnAddNew);
            this.groupBoxSupButtons.Controls.Add(this.btnReset);
            this.groupBoxSupButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxSupButtons.Location = new System.Drawing.Point(5, 13);
            this.groupBoxSupButtons.Name = "groupBoxSupButtons";
            this.groupBoxSupButtons.Size = new System.Drawing.Size(107, 198);
            this.groupBoxSupButtons.TabIndex = 1;
            this.groupBoxSupButtons.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::SenaExSIMSMiniEdition.Properties.Resources.Print;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(6, 154);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(95, 33);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnPrint, "Ctrl+P");
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::SenaExSIMSMiniEdition.Properties.Resources.Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(6, 118);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 33);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnDelete, "Ctrl+D");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::SenaExSIMSMiniEdition.Properties.Resources.Edit;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(6, 82);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 33);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnUpdate, "Ctrl+U");
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Image = global::SenaExSIMSMiniEdition.Properties.Resources.AddNew;
            this.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.Location = new System.Drawing.Point(6, 46);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(95, 33);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnAddNew, "Ctrl+N");
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(6, 10);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 33);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnReset, "Ctrl+R");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBoxItemFields
            // 
            this.groupBoxItemFields.Controls.Add(stockLabel);
            this.groupBoxItemFields.Controls.Add(this.lblStock);
            this.groupBoxItemFields.Controls.Add(this.txtRemarks);
            this.groupBoxItemFields.Controls.Add(this.nudReorderLevel);
            this.groupBoxItemFields.Controls.Add(re_Order_LevelLabel);
            this.groupBoxItemFields.Controls.Add(remarksLabel);
            this.groupBoxItemFields.Controls.Add(this.lblItem_ID);
            this.groupBoxItemFields.Controls.Add(item_IDLabel);
            this.groupBoxItemFields.Controls.Add(this.txtItem_Name);
            this.groupBoxItemFields.Controls.Add(this.nudMaxQty);
            this.groupBoxItemFields.Controls.Add(max_Order_QtyLabel);
            this.groupBoxItemFields.Controls.Add(item_NameLabel);
            this.groupBoxItemFields.Controls.Add(this.cmbSup_ID);
            this.groupBoxItemFields.Controls.Add(min_Order_QtyLabel);
            this.groupBoxItemFields.Controls.Add(this.nudMinQty);
            this.groupBoxItemFields.Controls.Add(sup_IDLabel);
            this.groupBoxItemFields.Controls.Add(this.lblSup_Name);
            this.groupBoxItemFields.Controls.Add(this.cmbCategory);
            this.groupBoxItemFields.Controls.Add(categoryLabel);
            this.groupBoxItemFields.Controls.Add(this.nudPchsPrice);
            this.groupBoxItemFields.Controls.Add(purchase_PriceLabel);
            this.groupBoxItemFields.Controls.Add(this.cmbUnit);
            this.groupBoxItemFields.Controls.Add(unitLabel);
            this.groupBoxItemFields.Controls.Add(this.nudSellingPrice);
            this.groupBoxItemFields.Controls.Add(selling_PriceLabel);
            this.groupBoxItemFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxItemFields.Location = new System.Drawing.Point(5, 13);
            this.groupBoxItemFields.Name = "groupBoxItemFields";
            this.groupBoxItemFields.Size = new System.Drawing.Size(618, 198);
            this.groupBoxItemFields.TabIndex = 2;
            this.groupBoxItemFields.TabStop = false;
            // 
            // lblStock
            // 
            this.lblStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Stock", true, System.Windows.Forms.DataSourceUpdateMode.Never, "0.00", "N2"));
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.DarkRed;
            this.lblStock.Location = new System.Drawing.Point(392, 171);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(220, 18);
            this.lblStock.TabIndex = 24;
            this.lblStock.Text = "Stock";
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
            // txtRemarks
            // 
            this.txtRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRemarks.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Remarks", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtRemarks.Location = new System.Drawing.Point(483, 108);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRemarks.Size = new System.Drawing.Size(129, 56);
            this.txtRemarks.TabIndex = 10;
            // 
            // nudReorderLevel
            // 
            this.nudReorderLevel.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.itemsBindingSource, "Re_Order_Level", true, System.Windows.Forms.DataSourceUpdateMode.Never, "0.00", "N2"));
            this.nudReorderLevel.DecimalPlaces = 2;
            this.nudReorderLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.nudReorderLevel.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudReorderLevel.Location = new System.Drawing.Point(392, 144);
            this.nudReorderLevel.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudReorderLevel.Name = "nudReorderLevel";
            this.nudReorderLevel.Size = new System.Drawing.Size(85, 20);
            this.nudReorderLevel.TabIndex = 9;
            this.nudReorderLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblItem_ID
            // 
            this.lblItem_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItem_ID.BackColor = System.Drawing.SystemColors.Info;
            this.lblItem_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItem_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Item_ID", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.lblItem_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem_ID.Location = new System.Drawing.Point(197, 10);
            this.lblItem_ID.Name = "lblItem_ID";
            this.lblItem_ID.Size = new System.Drawing.Size(415, 20);
            this.lblItem_ID.TabIndex = 0;
            // 
            // txtItem_Name
            // 
            this.txtItem_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItem_Name.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtItem_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtItem_Name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Item_Name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtItem_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem_Name.Location = new System.Drawing.Point(197, 33);
            this.txtItem_Name.Name = "txtItem_Name";
            this.txtItem_Name.Size = new System.Drawing.Size(415, 22);
            this.txtItem_Name.TabIndex = 1;
            // 
            // nudMaxQty
            // 
            this.nudMaxQty.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.itemsBindingSource, "Max_Order_Qty", true, System.Windows.Forms.DataSourceUpdateMode.Never, "0.00", "N2"));
            this.nudMaxQty.DecimalPlaces = 2;
            this.nudMaxQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.nudMaxQty.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudMaxQty.Location = new System.Drawing.Point(392, 117);
            this.nudMaxQty.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudMaxQty.Name = "nudMaxQty";
            this.nudMaxQty.Size = new System.Drawing.Size(85, 20);
            this.nudMaxQty.TabIndex = 8;
            this.nudMaxQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbSup_ID
            // 
            this.cmbSup_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbSup_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSup_ID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.suppliersBindingSource, "Sup_ID", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cmbSup_ID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.suppliersBindingSource, "Sup_ID", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cmbSup_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Sup_ID", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cmbSup_ID.DataSource = this.suppliersBindingSource;
            this.cmbSup_ID.DisplayMember = "Sup_ID";
            this.cmbSup_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSup_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSup_ID.FormattingEnabled = true;
            this.cmbSup_ID.Location = new System.Drawing.Point(197, 61);
            this.cmbSup_ID.Name = "cmbSup_ID";
            this.cmbSup_ID.Size = new System.Drawing.Size(108, 21);
            this.cmbSup_ID.TabIndex = 2;
            this.cmbSup_ID.ValueMember = "Sup_ID";
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "suppliers";
            this.suppliersBindingSource.DataSource = this.senaexminidbDataSet;
            // 
            // nudMinQty
            // 
            this.nudMinQty.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.itemsBindingSource, "Min_Order_Qty", true, System.Windows.Forms.DataSourceUpdateMode.Never, "0.00", "N2"));
            this.nudMinQty.DecimalPlaces = 2;
            this.nudMinQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.nudMinQty.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudMinQty.Location = new System.Drawing.Point(392, 90);
            this.nudMinQty.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudMinQty.Name = "nudMinQty";
            this.nudMinQty.Size = new System.Drawing.Size(85, 20);
            this.nudMinQty.TabIndex = 7;
            this.nudMinQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSup_Name
            // 
            this.lblSup_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSup_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSup_Name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Sup_Name", true, System.Windows.Forms.DataSourceUpdateMode.Never, "No Supplier\'s Name"));
            this.lblSup_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSup_Name.ForeColor = System.Drawing.Color.Blue;
            this.lblSup_Name.Location = new System.Drawing.Point(311, 61);
            this.lblSup_Name.Name = "lblSup_Name";
            this.lblSup_Name.Size = new System.Drawing.Size(301, 21);
            this.lblSup_Name.TabIndex = 0;
            this.lblSup_Name.Text = "Supplier\'s Name";
            this.lblSup_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbCategory
            // 
            this.cmbCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.categoriesBindingSource, "Category", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cmbCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoriesBindingSource, "Category", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cmbCategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Category", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cmbCategory.DataSource = this.categoriesBindingSource;
            this.cmbCategory.DisplayMember = "Category";
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(197, 88);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(108, 21);
            this.cmbCategory.TabIndex = 3;
            this.cmbCategory.ValueMember = "Category";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "categories";
            this.categoriesBindingSource.DataSource = this.senaexminidbDataSet;
            // 
            // nudPchsPrice
            // 
            this.nudPchsPrice.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.itemsBindingSource, "Purchase_Price", true, System.Windows.Forms.DataSourceUpdateMode.Never, "0.00", "C2"));
            this.nudPchsPrice.DecimalPlaces = 2;
            this.nudPchsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPchsPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudPchsPrice.Location = new System.Drawing.Point(197, 117);
            this.nudPchsPrice.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudPchsPrice.Name = "nudPchsPrice";
            this.nudPchsPrice.Size = new System.Drawing.Size(108, 20);
            this.nudPchsPrice.TabIndex = 4;
            this.nudPchsPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbUnit
            // 
            this.cmbUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Unit", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Items.AddRange(new object[] {
            "Piece (pcs)",
            "NOS",
            "Box",
            "Package",
            "Packet",
            "Bag",
            "Bottle",
            "Can",
            "Tin",
            "Liter (l)",
            "Milliliter (ml)",
            "Pint",
            "Gallon",
            "Millimeter (mm)",
            "Centimeter (cm)",
            "Meter (m)",
            "Kilometer (km)",
            "Inch",
            "Feet",
            "Yard",
            "Milligram (mg)",
            "Centigram (cg)",
            "Gram (g)",
            "Kilogram (kg)",
            "Ounce",
            "Others"});
            this.cmbUnit.Location = new System.Drawing.Point(197, 170);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(108, 21);
            this.cmbUnit.TabIndex = 6;
            // 
            // nudSellingPrice
            // 
            this.nudSellingPrice.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.itemsBindingSource, "Selling_Price", true, System.Windows.Forms.DataSourceUpdateMode.Never, "0.00", "C2"));
            this.nudSellingPrice.DecimalPlaces = 2;
            this.nudSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSellingPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudSellingPrice.Location = new System.Drawing.Point(197, 144);
            this.nudSellingPrice.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudSellingPrice.Name = "nudSellingPrice";
            this.nudSellingPrice.Size = new System.Drawing.Size(108, 20);
            this.nudSellingPrice.TabIndex = 5;
            this.nudSellingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblItemHeader
            // 
            this.lblItemHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblItemHeader.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Item_Name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.lblItemHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblItemHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblItemHeader.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemHeader.ForeColor = System.Drawing.Color.White;
            this.lblItemHeader.Location = new System.Drawing.Point(3, 39);
            this.lblItemHeader.Name = "lblItemHeader";
            this.lblItemHeader.Size = new System.Drawing.Size(628, 28);
            this.lblItemHeader.TabIndex = 0;
            this.lblItemHeader.Text = "Selected Item Name";
            this.lblItemHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblItemIDHeader
            // 
            this.lblItemIDHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblItemIDHeader.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Item_ID", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.lblItemIDHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblItemIDHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblItemIDHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemIDHeader.ForeColor = System.Drawing.Color.White;
            this.lblItemIDHeader.Location = new System.Drawing.Point(3, 16);
            this.lblItemIDHeader.Name = "lblItemIDHeader";
            this.lblItemIDHeader.Size = new System.Drawing.Size(628, 23);
            this.lblItemIDHeader.TabIndex = 0;
            this.lblItemIDHeader.Text = "Selected Item ID";
            this.lblItemIDHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
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
            this.dgvAllItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllItems.Size = new System.Drawing.Size(628, 203);
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Item_ID";
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Item ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 60;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn2.Width = 66;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Item_Name";
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Sup_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "Supplier ID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 60;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 84;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn5.HeaderText = "Category";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 75;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Purchase_Price";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn6.HeaderText = "Purchase Price";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 110;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 110;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Selling_Price";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "0.00";
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn7.HeaderText = "Selling Price";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 110;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 110;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Unit";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn8.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 51;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Min_Order_Qty";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0.00";
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn9.HeaderText = "Min Order Qty";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 97;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Max_Order_Qty";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0.00";
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn10.HeaderText = "Max Order Qty";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Re_Order_Level";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "0.00";
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn11.HeaderText = "Re Order Level";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 104;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Stock";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = "0.00";
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn12.HeaderText = "Stock In Hand";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 75;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 101;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn13.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // itemsBindingNavigator
            // 
            this.itemsBindingNavigator.AddNewItem = null;
            this.itemsBindingNavigator.BindingSource = this.itemsBindingSource;
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
            this.itemsBindingNavigator.Size = new System.Drawing.Size(378, 25);
            this.itemsBindingNavigator.TabIndex = 2;
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
            // groupBoxItemList
            // 
            this.groupBoxItemList.Controls.Add(this.dgvAllItems);
            this.groupBoxItemList.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxItemList.Location = new System.Drawing.Point(5, 5);
            this.groupBoxItemList.Name = "groupBoxItemList";
            this.groupBoxItemList.Padding = new System.Windows.Forms.Padding(3, 3, 3, 7);
            this.groupBoxItemList.Size = new System.Drawing.Size(634, 251);
            this.groupBoxItemList.TabIndex = 1;
            this.groupBoxItemList.TabStop = false;
            this.groupBoxItemList.Text = "Item List";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(628, 25);
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
            this.toolTip.SetToolTip(this.txtSearch, "Ctrl+S");
            this.txtSearch.searchTextbox_TextChanged += new System.EventHandler(this.SearchItems);
            this.txtSearch.searchButton_Click += new System.EventHandler(this.SearchItems);
            // 
            // panelBase
            // 
            this.panelBase.Controls.Add(this.groupBoxItemList);
            this.panelBase.Controls.Add(this.groupBoxCurSel);
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(0, 34);
            this.panelBase.Name = "panelBase";
            this.panelBase.Padding = new System.Windows.Forms.Padding(5);
            this.panelBase.Size = new System.Drawing.Size(644, 547);
            this.panelBase.TabIndex = 1;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.grn_detailsTableAdapter = null;
            this.tableAdapterManager.grnTableAdapter = null;
            this.tableAdapterManager.invoice_itemsTableAdapter = null;
            this.tableAdapterManager.invoice_serviceTableAdapter = null;
            this.tableAdapterManager.invoiceTableAdapter = null;
            this.tableAdapterManager.itemsTableAdapter = null;
            this.tableAdapterManager.paymentsTableAdapter = null;
            this.tableAdapterManager.rolesTableAdapter = null;
            this.tableAdapterManager.service_typesTableAdapter = null;
            this.tableAdapterManager.suppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.vehiclesTableAdapter = null;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip_SK
            // 
            this.menuStrip_SK.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.menuStrip_SK.Location = new System.Drawing.Point(0, 34);
            this.menuStrip_SK.Name = "menuStrip_SK";
            this.menuStrip_SK.Size = new System.Drawing.Size(644, 24);
            this.menuStrip_SK.TabIndex = 9;
            this.menuStrip_SK.Text = "menuStrip";
            this.menuStrip_SK.Visible = false;
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSK_Reset,
            this.mnuAdd,
            this.mnuUpdate,
            this.mnuDelete,
            this.mnuPrint,
            this.mnuPrintAll,
            this.mnuSK_Search,
            this.mnuRefresh});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Visible = false;
            // 
            // mnuSK_Reset
            // 
            this.mnuSK_Reset.CheckOnClick = true;
            this.mnuSK_Reset.Name = "mnuSK_Reset";
            this.mnuSK_Reset.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnuSK_Reset.Size = new System.Drawing.Size(177, 22);
            this.mnuSK_Reset.Text = "Reset";
            this.mnuSK_Reset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // mnuAdd
            // 
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuAdd.Size = new System.Drawing.Size(177, 22);
            this.mnuAdd.Text = "Add New";
            this.mnuAdd.Visible = false;
            this.mnuAdd.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // mnuUpdate
            // 
            this.mnuUpdate.Name = "mnuUpdate";
            this.mnuUpdate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.mnuUpdate.Size = new System.Drawing.Size(177, 22);
            this.mnuUpdate.Text = "Update";
            this.mnuUpdate.Visible = false;
            this.mnuUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuDelete.Size = new System.Drawing.Size(177, 22);
            this.mnuDelete.Text = "Delete";
            this.mnuDelete.Visible = false;
            this.mnuDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // mnuPrint
            // 
            this.mnuPrint.Name = "mnuPrint";
            this.mnuPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnuPrint.Size = new System.Drawing.Size(177, 22);
            this.mnuPrint.Text = "Print";
            this.mnuPrint.Visible = false;
            this.mnuPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // mnuPrintAll
            // 
            this.mnuPrintAll.Name = "mnuPrintAll";
            this.mnuPrintAll.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.P)));
            this.mnuPrintAll.Size = new System.Drawing.Size(177, 22);
            this.mnuPrintAll.Text = "PrintAll";
            this.mnuPrintAll.Visible = false;
            this.mnuPrintAll.Click += new System.EventHandler(this.toolAllItemsPrint_Click);
            // 
            // mnuSK_Search
            // 
            this.mnuSK_Search.Name = "mnuSK_Search";
            this.mnuSK_Search.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSK_Search.Size = new System.Drawing.Size(177, 22);
            this.mnuSK_Search.Text = "Search";
            this.mnuSK_Search.Click += new System.EventHandler(this.mnuSK_Search_Click);
            // 
            // mnuRefresh
            // 
            this.mnuRefresh.Name = "mnuRefresh";
            this.mnuRefresh.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuRefresh.Size = new System.Drawing.Size(177, 22);
            this.mnuRefresh.Text = "Refresh";
            this.mnuRefresh.Click += new System.EventHandler(this.LoadAllItems);
            // 
            // ItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 581);
            this.Controls.Add(this.menuStrip_SK);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.lblBanner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 550);
            this.Name = "ItemsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ItemsForm_Load);
            this.groupBoxCurSel.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBoxSupButtons.ResumeLayout(false);
            this.groupBoxItemFields.ResumeLayout(false);
            this.groupBoxItemFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senaexminidbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReorderLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPchsPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSellingPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingNavigator)).EndInit();
            this.itemsBindingNavigator.ResumeLayout(false);
            this.itemsBindingNavigator.PerformLayout();
            this.groupBoxItemList.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelBase.ResumeLayout(false);
            this.menuStrip_SK.ResumeLayout(false);
            this.menuStrip_SK.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBanner;
        private senaexminidbDataSet senaexminidbDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private senaexminidbDataSetTableAdapters.itemsTableAdapter itemsTableAdapter;
        private senaexminidbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.DataGridView dgvAllItems;
        private System.Windows.Forms.ToolStripButton toolAllItemsRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolAllItemsPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private Util.searchBoxUC txtSearch;
        private System.Windows.Forms.GroupBox groupBoxCurSel;
        private System.Windows.Forms.Label lblItemHeader;
        private System.Windows.Forms.Label lblItemIDHeader;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblItem_ID;
        private System.Windows.Forms.TextBox txtItem_Name;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private senaexminidbDataSetTableAdapters.suppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.Label lblSup_Name;
        private System.Windows.Forms.ComboBox cmbSup_ID;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private senaexminidbDataSetTableAdapters.categoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.NumericUpDown nudSellingPrice;
        private System.Windows.Forms.NumericUpDown nudPchsPrice;
        private System.Windows.Forms.NumericUpDown nudReorderLevel;
        private System.Windows.Forms.NumericUpDown nudMaxQty;
        private System.Windows.Forms.NumericUpDown nudMinQty;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.GroupBox groupBoxItemList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.GroupBox groupBoxSupButtons;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBoxItemFields;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnItemAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.MenuStrip menuStrip_SK;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSK_Reset;
        private System.Windows.Forms.ToolStripMenuItem mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuPrint;
        private System.Windows.Forms.ToolStripMenuItem mnuSK_Search;
        private System.Windows.Forms.ToolStripMenuItem mnuPrintAll;
        private System.Windows.Forms.ToolStripMenuItem mnuRefresh;
        private System.Windows.Forms.ToolTip toolTip;
    }
}