namespace SenaExSIMSMiniEdition.GRN
{
    partial class GRNForm
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
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label sup_IDLabel;
            System.Windows.Forms.Label remarksLabel;
            System.Windows.Forms.Label gRN_DateLabel;
            System.Windows.Forms.Label received_DateLabel;
            System.Windows.Forms.Label special_DiscountLabel;
            System.Windows.Forms.Label total_DiscountLabel;
            System.Windows.Forms.Label item_IDLabel1;
            System.Windows.Forms.Label item_NameLabel1;
            System.Windows.Forms.Label qtyLabel;
            System.Windows.Forms.Label freeItemLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.Windows.Forms.Label discount_ValueLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label sup_NameLabel;
            System.Windows.Forms.Label pO_NoLabel;
            System.Windows.Forms.Label invoice_NoLabel;
            System.Windows.Forms.Label total_AmountLabel;
            System.Windows.Forms.Label unitLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GRNForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBanner = new System.Windows.Forms.Label();
            this.panelBase = new System.Windows.Forms.Panel();
            this.groupBoxGRNData = new System.Windows.Forms.GroupBox();
            this.groupBoxPayments = new System.Windows.Forms.GroupBox();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.PM_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PM_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Source_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.senaexminidbDataSet = new SenaExSIMSMiniEdition.senaexminidbDataSet();
            this.bindingNavigator_Payments = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnPayment_Delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPayment_AddNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblBalTotal = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGRN_SupName = new System.Windows.Forms.TextBox();
            this.txtGRN_SupID = new SenaExSIMSMiniEdition.Util.FindTextBoxUC();
            this.lblGRN_Username = new System.Windows.Forms.Label();
            this.btnMakeNewGRN = new System.Windows.Forms.Button();
            this.txtGRN_InvNo = new System.Windows.Forms.TextBox();
            this.btnViewGRNList = new System.Windows.Forms.Button();
            this.btnLoadPrevGRN = new System.Windows.Forms.Button();
            this.txtGRN_PONo = new System.Windows.Forms.TextBox();
            this.dtpGRN_RiceivedDate = new System.Windows.Forms.DateTimePicker();
            this.dtpGRN_Date = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSavePrint = new System.Windows.Forms.Button();
            this.btnDeleteGRN = new System.Windows.Forms.Button();
            this.btnGRNSave = new System.Windows.Forms.Button();
            this.panelGrnItems = new System.Windows.Forms.Panel();
            this.dgvGrnDetails = new System.Windows.Forms.DataGridView();
            this.dgvGrnItemsColumn_X = new System.Windows.Forms.DataGridViewButtonColumn();
            this.itemIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGrnItemsColumn_ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeItemDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountValueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelItemData = new System.Windows.Forms.Panel();
            this.txtItem_Name = new System.Windows.Forms.TextBox();
            this.txtItem_Remarks = new System.Windows.Forms.TextBox();
            this.txtItem_ID = new SenaExSIMSMiniEdition.Util.FindTextBoxUC();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnItemReset = new System.Windows.Forms.Button();
            this.cmbItem_Unit = new System.Windows.Forms.ComboBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nudItem_QTY = new System.Windows.Forms.NumericUpDown();
            this.lblItem_Amount = new System.Windows.Forms.Label();
            this.nudItem_DiscountValue = new System.Windows.Forms.NumericUpDown();
            this.nudItem_FreeItem = new System.Windows.Forms.NumericUpDown();
            this.nudItem_UnitPrice = new System.Windows.Forms.NumericUpDown();
            this.lblGRNHeader = new System.Windows.Forms.Label();
            this.panelGRN_Amounts = new System.Windows.Forms.Panel();
            this.nudGRN_SpecDisc = new System.Windows.Forms.NumericUpDown();
            this.lblGRN_TotalDisc = new System.Windows.Forms.Label();
            this.lblGRN_TotalAmount = new System.Windows.Forms.Label();
            this.txtGRN_Remarks = new System.Windows.Forms.TextBox();
            this.grnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGRNDetailsColumn_ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRNNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.itemsTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.itemsTableAdapter();
            this.paymentsTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.paymentsTableAdapter();
            this.tableAdapterManager = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.TableAdapterManager();
            this.grn_detailsTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.grn_detailsTableAdapter();
            this.grnTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.grnTableAdapter();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.suppliersTableAdapter();
            this.menuStripSK = new System.Windows.Forms.MenuStrip();
            this.shortcutKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeNewGRNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGRNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selSupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteGRNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fKGrnDeiailsGrnNoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            usernameLabel = new System.Windows.Forms.Label();
            sup_IDLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            gRN_DateLabel = new System.Windows.Forms.Label();
            received_DateLabel = new System.Windows.Forms.Label();
            special_DiscountLabel = new System.Windows.Forms.Label();
            total_DiscountLabel = new System.Windows.Forms.Label();
            item_IDLabel1 = new System.Windows.Forms.Label();
            item_NameLabel1 = new System.Windows.Forms.Label();
            qtyLabel = new System.Windows.Forms.Label();
            freeItemLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            discount_ValueLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            sup_NameLabel = new System.Windows.Forms.Label();
            pO_NoLabel = new System.Windows.Forms.Label();
            invoice_NoLabel = new System.Windows.Forms.Label();
            total_AmountLabel = new System.Windows.Forms.Label();
            unitLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panelBase.SuspendLayout();
            this.groupBoxGRNData.SuspendLayout();
            this.groupBoxPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senaexminidbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Payments)).BeginInit();
            this.bindingNavigator_Payments.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelGrnItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrnDetails)).BeginInit();
            this.panelItemData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItem_QTY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItem_DiscountValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItem_FreeItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItem_UnitPrice)).BeginInit();
            this.panelGRN_Amounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGRN_SpecDisc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            this.menuStripSK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKGrnDeiailsGrnNoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(6, 50);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(58, 13);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username:";
            // 
            // sup_IDLabel
            // 
            sup_IDLabel.AutoSize = true;
            sup_IDLabel.Location = new System.Drawing.Point(6, 74);
            sup_IDLabel.Name = "sup_IDLabel";
            sup_IDLabel.Size = new System.Drawing.Size(62, 13);
            sup_IDLabel.TabIndex = 0;
            sup_IDLabel.Text = "Supplier ID:";
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Location = new System.Drawing.Point(0, 91);
            remarksLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(52, 13);
            remarksLabel.TabIndex = 0;
            remarksLabel.Text = "Remarks:";
            // 
            // gRN_DateLabel
            // 
            gRN_DateLabel.AutoSize = true;
            gRN_DateLabel.Location = new System.Drawing.Point(6, 102);
            gRN_DateLabel.Name = "gRN_DateLabel";
            gRN_DateLabel.Size = new System.Drawing.Size(60, 13);
            gRN_DateLabel.TabIndex = 0;
            gRN_DateLabel.Text = "GRN Date:";
            // 
            // received_DateLabel
            // 
            received_DateLabel.AutoSize = true;
            received_DateLabel.Location = new System.Drawing.Point(182, 102);
            received_DateLabel.Name = "received_DateLabel";
            received_DateLabel.Size = new System.Drawing.Size(82, 13);
            received_DateLabel.TabIndex = 0;
            received_DateLabel.Text = "Received Date:";
            // 
            // special_DiscountLabel
            // 
            special_DiscountLabel.AutoSize = true;
            special_DiscountLabel.Location = new System.Drawing.Point(0, 7);
            special_DiscountLabel.Name = "special_DiscountLabel";
            special_DiscountLabel.Size = new System.Drawing.Size(112, 13);
            special_DiscountLabel.TabIndex = 0;
            special_DiscountLabel.Text = "Special Discount(Rs.):";
            // 
            // total_DiscountLabel
            // 
            total_DiscountLabel.AutoSize = true;
            total_DiscountLabel.Location = new System.Drawing.Point(0, 36);
            total_DiscountLabel.Name = "total_DiscountLabel";
            total_DiscountLabel.Size = new System.Drawing.Size(101, 13);
            total_DiscountLabel.TabIndex = 0;
            total_DiscountLabel.Text = "Total Discount(Rs.):";
            // 
            // item_IDLabel1
            // 
            item_IDLabel1.AutoSize = true;
            item_IDLabel1.Location = new System.Drawing.Point(46, 1);
            item_IDLabel1.Name = "item_IDLabel1";
            item_IDLabel1.Size = new System.Drawing.Size(44, 13);
            item_IDLabel1.TabIndex = 0;
            item_IDLabel1.Text = "Item ID:";
            // 
            // item_NameLabel1
            // 
            item_NameLabel1.AutoSize = true;
            item_NameLabel1.Location = new System.Drawing.Point(137, 1);
            item_NameLabel1.Name = "item_NameLabel1";
            item_NameLabel1.Size = new System.Drawing.Size(61, 13);
            item_NameLabel1.TabIndex = 0;
            item_NameLabel1.Text = "Item Name:";
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Location = new System.Drawing.Point(392, 1);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new System.Drawing.Size(26, 13);
            qtyLabel.TabIndex = 0;
            qtyLabel.Text = "Qty:";
            // 
            // freeItemLabel
            // 
            freeItemLabel.AutoSize = true;
            freeItemLabel.Location = new System.Drawing.Point(467, 1);
            freeItemLabel.Name = "freeItemLabel";
            freeItemLabel.Size = new System.Drawing.Size(54, 13);
            freeItemLabel.TabIndex = 0;
            freeItemLabel.Text = "Free Item:";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Location = new System.Drawing.Point(543, 1);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(56, 13);
            unitPriceLabel.TabIndex = 0;
            unitPriceLabel.Text = "Unit Price:";
            // 
            // discount_ValueLabel
            // 
            discount_ValueLabel.AutoSize = true;
            discount_ValueLabel.Location = new System.Drawing.Point(642, 1);
            discount_ValueLabel.Name = "discount_ValueLabel";
            discount_ValueLabel.Size = new System.Drawing.Size(82, 13);
            discount_ValueLabel.TabIndex = 0;
            discount_ValueLabel.Text = "Discount Value:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(744, 1);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(46, 13);
            amountLabel.TabIndex = 0;
            amountLabel.Text = "Amount:";
            // 
            // sup_NameLabel
            // 
            sup_NameLabel.AutoSize = true;
            sup_NameLabel.Location = new System.Drawing.Point(181, 74);
            sup_NameLabel.Name = "sup_NameLabel";
            sup_NameLabel.Size = new System.Drawing.Size(86, 13);
            sup_NameLabel.TabIndex = 0;
            sup_NameLabel.Text = "Supplier\'s Name:";
            // 
            // pO_NoLabel
            // 
            pO_NoLabel.AutoSize = true;
            pO_NoLabel.Location = new System.Drawing.Point(376, 102);
            pO_NoLabel.Name = "pO_NoLabel";
            pO_NoLabel.Size = new System.Drawing.Size(42, 13);
            pO_NoLabel.TabIndex = 0;
            pO_NoLabel.Text = "PO No:";
            // 
            // invoice_NoLabel
            // 
            invoice_NoLabel.AutoSize = true;
            invoice_NoLabel.Location = new System.Drawing.Point(530, 102);
            invoice_NoLabel.Name = "invoice_NoLabel";
            invoice_NoLabel.Size = new System.Drawing.Size(62, 13);
            invoice_NoLabel.TabIndex = 0;
            invoice_NoLabel.Text = "Invoice No:";
            // 
            // total_AmountLabel
            // 
            total_AmountLabel.AutoSize = true;
            total_AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            total_AmountLabel.Location = new System.Drawing.Point(0, 65);
            total_AmountLabel.Name = "total_AmountLabel";
            total_AmountLabel.Size = new System.Drawing.Size(113, 13);
            total_AmountLabel.TabIndex = 0;
            total_AmountLabel.Text = "Total Amount(Rs.):";
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Location = new System.Drawing.Point(312, 1);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new System.Drawing.Size(29, 13);
            unitLabel.TabIndex = 0;
            unitLabel.Text = "Unit:";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(855, 3);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 13);
            label1.TabIndex = 10;
            label1.Text = "Remarks:";
            // 
            // lblBanner
            // 
            this.lblBanner.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBanner.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.ForeColor = System.Drawing.Color.White;
            this.lblBanner.Location = new System.Drawing.Point(0, 0);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(709, 34);
            this.lblBanner.TabIndex = 0;
            this.lblBanner.Text = "Goods Received Note";
            this.lblBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBase
            // 
            this.panelBase.Controls.Add(this.groupBoxGRNData);
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(0, 34);
            this.panelBase.Name = "panelBase";
            this.panelBase.Padding = new System.Windows.Forms.Padding(5);
            this.panelBase.Size = new System.Drawing.Size(709, 528);
            this.panelBase.TabIndex = 1;
            // 
            // groupBoxGRNData
            // 
            this.groupBoxGRNData.Controls.Add(this.groupBoxPayments);
            this.groupBoxGRNData.Controls.Add(this.groupBox1);
            this.groupBoxGRNData.Controls.Add(this.btnPrint);
            this.groupBoxGRNData.Controls.Add(this.btnSavePrint);
            this.groupBoxGRNData.Controls.Add(this.btnDeleteGRN);
            this.groupBoxGRNData.Controls.Add(this.btnGRNSave);
            this.groupBoxGRNData.Controls.Add(this.panelGrnItems);
            this.groupBoxGRNData.Controls.Add(this.lblGRNHeader);
            this.groupBoxGRNData.Controls.Add(this.panelGRN_Amounts);
            this.groupBoxGRNData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxGRNData.Location = new System.Drawing.Point(5, 5);
            this.groupBoxGRNData.Name = "groupBoxGRNData";
            this.groupBoxGRNData.Size = new System.Drawing.Size(699, 518);
            this.groupBoxGRNData.TabIndex = 1;
            this.groupBoxGRNData.TabStop = false;
            this.groupBoxGRNData.Text = "Process GRN";
            // 
            // groupBoxPayments
            // 
            this.groupBoxPayments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPayments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxPayments.Controls.Add(this.dgvPayments);
            this.groupBoxPayments.Controls.Add(this.bindingNavigator_Payments);
            this.groupBoxPayments.Location = new System.Drawing.Point(6, 333);
            this.groupBoxPayments.Name = "groupBoxPayments";
            this.groupBoxPayments.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.groupBoxPayments.Size = new System.Drawing.Size(435, 143);
            this.groupBoxPayments.TabIndex = 4;
            this.groupBoxPayments.TabStop = false;
            this.groupBoxPayments.Text = "Payments";
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.AutoGenerateColumns = false;
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PM_ID,
            this.PM_No,
            this.Source_Type,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            this.dgvPayments.DataSource = this.paymentsBindingSource;
            this.dgvPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPayments.Location = new System.Drawing.Point(5, 38);
            this.dgvPayments.MultiSelect = false;
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersWidth = 24;
            this.dgvPayments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(425, 100);
            this.dgvPayments.StandardTab = true;
            this.dgvPayments.TabIndex = 2;
            this.dgvPayments.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvPayments_CellBeginEdit);
            this.dgvPayments.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayments_CellEndEdit);
            this.dgvPayments.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvPayments_CellValueNeeded);
            this.dgvPayments.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvPayments_CellValueNeeded);
            this.dgvPayments.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPayments_DataBindingComplete);
            // 
            // PM_ID
            // 
            this.PM_ID.DataPropertyName = "PM_ID";
            this.PM_ID.Frozen = true;
            this.PM_ID.HeaderText = "PM_ID";
            this.PM_ID.Name = "PM_ID";
            this.PM_ID.ReadOnly = true;
            this.PM_ID.Visible = false;
            this.PM_ID.Width = 65;
            // 
            // PM_No
            // 
            this.PM_No.DataPropertyName = "PM_No";
            this.PM_No.Frozen = true;
            this.PM_No.HeaderText = "PM_No";
            this.PM_No.Name = "PM_No";
            this.PM_No.ReadOnly = true;
            this.PM_No.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PM_No.Visible = false;
            this.PM_No.Width = 68;
            // 
            // Source_Type
            // 
            this.Source_Type.DataPropertyName = "Source_Type";
            this.Source_Type.Frozen = true;
            this.Source_Type.HeaderText = "Source_Type";
            this.Source_Type.Name = "Source_Type";
            this.Source_Type.ReadOnly = true;
            this.Source_Type.Visible = false;
            this.Source_Type.Width = 96;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Payment_Mode";
            this.dataGridViewTextBoxColumn12.Frozen = true;
            this.dataGridViewTextBoxColumn12.HeaderText = "Payment Mode";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Amount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0.00";
            this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn13.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn13.Width = 80;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Entry_Date";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn14.HeaderText = "Entry Date";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn14.Width = 80;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Paid_Due_Post_Date";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn15.HeaderText = "Paid/Due/Post Date";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn15.Width = 111;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Cheque_No";
            this.dataGridViewTextBoxColumn16.HeaderText = "Cheque No";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Bank";
            this.dataGridViewTextBoxColumn17.HeaderText = "Bank";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Branch";
            this.dataGridViewTextBoxColumn18.HeaderText = "Branch";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn19.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "payments";
            this.paymentsBindingSource.DataSource = this.senaexminidbDataSet;
            this.paymentsBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.paymentsBindingSource_AddingNew);
            this.paymentsBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.paymentsBindingSource_BindingComplete);
            this.paymentsBindingSource.CurrentChanged += new System.EventHandler(this.paymentsBindingSource_CurrentChanged);
            this.paymentsBindingSource.CurrentItemChanged += new System.EventHandler(this.paymentsBindingSource_CurrentItemChanged);
            // 
            // senaexminidbDataSet
            // 
            this.senaexminidbDataSet.DataSetName = "senaexminidbDataSet";
            this.senaexminidbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator_Payments
            // 
            this.bindingNavigator_Payments.AddNewItem = null;
            this.bindingNavigator_Payments.BindingSource = this.paymentsBindingSource;
            this.bindingNavigator_Payments.CountItem = null;
            this.bindingNavigator_Payments.DeleteItem = this.btnPayment_Delete;
            this.bindingNavigator_Payments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.btnPayment_AddNew,
            this.toolStripSeparator3,
            this.btnPayment_Delete,
            this.toolStripSeparator1,
            this.lblBalTotal,
            this.toolStripLabel1});
            this.bindingNavigator_Payments.Location = new System.Drawing.Point(5, 13);
            this.bindingNavigator_Payments.MoveFirstItem = null;
            this.bindingNavigator_Payments.MoveLastItem = null;
            this.bindingNavigator_Payments.MoveNextItem = null;
            this.bindingNavigator_Payments.MovePreviousItem = null;
            this.bindingNavigator_Payments.Name = "bindingNavigator_Payments";
            this.bindingNavigator_Payments.PositionItem = null;
            this.bindingNavigator_Payments.Size = new System.Drawing.Size(425, 25);
            this.bindingNavigator_Payments.TabIndex = 1;
            this.bindingNavigator_Payments.TabStop = true;
            // 
            // btnPayment_Delete
            // 
            this.btnPayment_Delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPayment_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btnPayment_Delete.Image")));
            this.btnPayment_Delete.Name = "btnPayment_Delete";
            this.btnPayment_Delete.RightToLeftAutoMirrorImage = true;
            this.btnPayment_Delete.Size = new System.Drawing.Size(65, 22);
            this.btnPayment_Delete.Text = "Delete";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPayment_AddNew
            // 
            this.btnPayment_AddNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPayment_AddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnPayment_AddNew.Image")));
            this.btnPayment_AddNew.Name = "btnPayment_AddNew";
            this.btnPayment_AddNew.RightToLeftAutoMirrorImage = true;
            this.btnPayment_AddNew.Size = new System.Drawing.Size(76, 22);
            this.btnPayment_AddNew.Text = "Add new";
            this.btnPayment_AddNew.ToolTipText = "Add New Payment\r\n(Alt+A)";
            this.btnPayment_AddNew.Click += new System.EventHandler(this.btnPayment_AddNew_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lblBalTotal
            // 
            this.lblBalTotal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblBalTotal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblBalTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBalTotal.Name = "lblBalTotal";
            this.lblBalTotal.Size = new System.Drawing.Size(32, 22);
            this.lblBalTotal.Text = "0.00";
            this.lblBalTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(57, 22);
            this.toolStripLabel1.Text = "Balance:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.txtGRN_SupName);
            this.groupBox1.Controls.Add(this.txtGRN_SupID);
            this.groupBox1.Controls.Add(sup_NameLabel);
            this.groupBox1.Controls.Add(this.lblGRN_Username);
            this.groupBox1.Controls.Add(usernameLabel);
            this.groupBox1.Controls.Add(sup_IDLabel);
            this.groupBox1.Controls.Add(this.btnMakeNewGRN);
            this.groupBox1.Controls.Add(this.txtGRN_InvNo);
            this.groupBox1.Controls.Add(this.btnViewGRNList);
            this.groupBox1.Controls.Add(this.btnLoadPrevGRN);
            this.groupBox1.Controls.Add(this.txtGRN_PONo);
            this.groupBox1.Controls.Add(invoice_NoLabel);
            this.groupBox1.Controls.Add(pO_NoLabel);
            this.groupBox1.Controls.Add(received_DateLabel);
            this.groupBox1.Controls.Add(this.dtpGRN_RiceivedDate);
            this.groupBox1.Controls.Add(gRN_DateLabel);
            this.groupBox1.Controls.Add(this.dtpGRN_Date);
            this.groupBox1.Location = new System.Drawing.Point(6, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtGRN_SupName
            // 
            this.txtGRN_SupName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGRN_SupName.BackColor = System.Drawing.Color.White;
            this.txtGRN_SupName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGRN_SupName.Location = new System.Drawing.Point(270, 71);
            this.txtGRN_SupName.Name = "txtGRN_SupName";
            this.txtGRN_SupName.ReadOnly = true;
            this.txtGRN_SupName.Size = new System.Drawing.Size(410, 20);
            this.txtGRN_SupName.TabIndex = 0;
            this.txtGRN_SupName.TabStop = false;
            // 
            // txtGRN_SupID
            // 
            this.txtGRN_SupID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGRN_SupID.FindButtonBackColor = System.Drawing.Color.Salmon;
            this.txtGRN_SupID.Location = new System.Drawing.Point(74, 71);
            this.txtGRN_SupID.Name = "txtGRN_SupID";
            this.txtGRN_SupID.ReadOnlyTextbox = true;
            this.txtGRN_SupID.Size = new System.Drawing.Size(101, 20);
            this.txtGRN_SupID.TabIndex = 4;
            this.txtGRN_SupID.TextResult = "";
            this.toolTip.SetToolTip(this.txtGRN_SupID, "Alt+S");
            this.txtGRN_SupID.findButton_Click += new System.EventHandler(this.txtSupID_findButton_Click);
            this.txtGRN_SupID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // lblGRN_Username
            // 
            this.lblGRN_Username.AutoSize = true;
            this.lblGRN_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRN_Username.Location = new System.Drawing.Point(71, 50);
            this.lblGRN_Username.Margin = new System.Windows.Forms.Padding(5);
            this.lblGRN_Username.Name = "lblGRN_Username";
            this.lblGRN_Username.Size = new System.Drawing.Size(101, 13);
            this.lblGRN_Username.TabIndex = 0;
            this.lblGRN_Username.Text = "Role : Username";
            // 
            // btnMakeNewGRN
            // 
            this.btnMakeNewGRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeNewGRN.Image = global::SenaExSIMSMiniEdition.Properties.Resources.AddNew;
            this.btnMakeNewGRN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMakeNewGRN.Location = new System.Drawing.Point(6, 14);
            this.btnMakeNewGRN.Name = "btnMakeNewGRN";
            this.btnMakeNewGRN.Size = new System.Drawing.Size(154, 33);
            this.btnMakeNewGRN.TabIndex = 1;
            this.btnMakeNewGRN.Text = "Make New GRN";
            this.toolTip.SetToolTip(this.btnMakeNewGRN, "Ctrl+N");
            this.btnMakeNewGRN.UseVisualStyleBackColor = true;
            this.btnMakeNewGRN.Click += new System.EventHandler(this.btnMakeNewGRN_Click);
            // 
            // txtGRN_InvNo
            // 
            this.txtGRN_InvNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGRN_InvNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGRN_InvNo.Location = new System.Drawing.Point(598, 99);
            this.txtGRN_InvNo.Name = "txtGRN_InvNo";
            this.txtGRN_InvNo.Size = new System.Drawing.Size(82, 20);
            this.txtGRN_InvNo.TabIndex = 8;
            this.txtGRN_InvNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // btnViewGRNList
            // 
            this.btnViewGRNList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewGRNList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewGRNList.Image = global::SenaExSIMSMiniEdition.Properties.Resources.Show_Property;
            this.btnViewGRNList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewGRNList.Location = new System.Drawing.Point(326, 14);
            this.btnViewGRNList.Name = "btnViewGRNList";
            this.btnViewGRNList.Size = new System.Drawing.Size(154, 33);
            this.btnViewGRNList.TabIndex = 3;
            this.btnViewGRNList.Text = "View GRN List";
            this.btnViewGRNList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewGRNList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewGRNList.UseVisualStyleBackColor = true;
            this.btnViewGRNList.Click += new System.EventHandler(this.btnViewGRNList_Click);
            // 
            // btnLoadPrevGRN
            // 
            this.btnLoadPrevGRN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadPrevGRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPrevGRN.Image = global::SenaExSIMSMiniEdition.Properties.Resources.LoadDetails;
            this.btnLoadPrevGRN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadPrevGRN.Location = new System.Drawing.Point(166, 14);
            this.btnLoadPrevGRN.Name = "btnLoadPrevGRN";
            this.btnLoadPrevGRN.Size = new System.Drawing.Size(154, 33);
            this.btnLoadPrevGRN.TabIndex = 2;
            this.btnLoadPrevGRN.Text = "Load Previous GRN";
            this.btnLoadPrevGRN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadPrevGRN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnLoadPrevGRN, "Ctrl+L");
            this.btnLoadPrevGRN.UseVisualStyleBackColor = true;
            this.btnLoadPrevGRN.Click += new System.EventHandler(this.btnLoadPrevGRN_Click);
            // 
            // txtGRN_PONo
            // 
            this.txtGRN_PONo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGRN_PONo.Location = new System.Drawing.Point(424, 99);
            this.txtGRN_PONo.Name = "txtGRN_PONo";
            this.txtGRN_PONo.Size = new System.Drawing.Size(100, 20);
            this.txtGRN_PONo.TabIndex = 7;
            this.txtGRN_PONo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // dtpGRN_RiceivedDate
            // 
            this.dtpGRN_RiceivedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGRN_RiceivedDate.Location = new System.Drawing.Point(270, 99);
            this.dtpGRN_RiceivedDate.Name = "dtpGRN_RiceivedDate";
            this.dtpGRN_RiceivedDate.Size = new System.Drawing.Size(100, 20);
            this.dtpGRN_RiceivedDate.TabIndex = 6;
            this.dtpGRN_RiceivedDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // dtpGRN_Date
            // 
            this.dtpGRN_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGRN_Date.Location = new System.Drawing.Point(74, 98);
            this.dtpGRN_Date.Name = "dtpGRN_Date";
            this.dtpGRN_Date.Size = new System.Drawing.Size(101, 20);
            this.dtpGRN_Date.TabIndex = 5;
            this.dtpGRN_Date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrint.Enabled = false;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::SenaExSIMSMiniEdition.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(208, 482);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(78, 30);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnPrint, "Ctrl+P");
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSavePrint
            // 
            this.btnSavePrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSavePrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePrint.Image = global::SenaExSIMSMiniEdition.Properties.Resources.SavePrint;
            this.btnSavePrint.Location = new System.Drawing.Point(7, 482);
            this.btnSavePrint.Name = "btnSavePrint";
            this.btnSavePrint.Size = new System.Drawing.Size(111, 30);
            this.btnSavePrint.TabIndex = 6;
            this.btnSavePrint.Text = "Save && Print";
            this.btnSavePrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnSavePrint, "Ctrl+Shift +N");
            this.btnSavePrint.UseVisualStyleBackColor = true;
            this.btnSavePrint.Click += new System.EventHandler(this.btnSavePrint_Click);
            // 
            // btnDeleteGRN
            // 
            this.btnDeleteGRN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteGRN.Enabled = false;
            this.btnDeleteGRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGRN.Image = global::SenaExSIMSMiniEdition.Properties.Resources.Delete;
            this.btnDeleteGRN.Location = new System.Drawing.Point(325, 482);
            this.btnDeleteGRN.Name = "btnDeleteGRN";
            this.btnDeleteGRN.Size = new System.Drawing.Size(111, 30);
            this.btnDeleteGRN.TabIndex = 9;
            this.btnDeleteGRN.Text = "Delete GRN";
            this.btnDeleteGRN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnDeleteGRN, "Ctrl+D");
            this.btnDeleteGRN.UseVisualStyleBackColor = true;
            this.btnDeleteGRN.Click += new System.EventHandler(this.btnDeleteGRN_Click);
            // 
            // btnGRNSave
            // 
            this.btnGRNSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGRNSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGRNSave.Image = global::SenaExSIMSMiniEdition.Properties.Resources.Save;
            this.btnGRNSave.Location = new System.Drawing.Point(124, 482);
            this.btnGRNSave.Name = "btnGRNSave";
            this.btnGRNSave.Size = new System.Drawing.Size(78, 30);
            this.btnGRNSave.TabIndex = 7;
            this.btnGRNSave.Text = "Save";
            this.btnGRNSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnGRNSave, "Ctrl+S");
            this.btnGRNSave.UseVisualStyleBackColor = true;
            this.btnGRNSave.Click += new System.EventHandler(this.btnGRNSave_Click);
            // 
            // panelGrnItems
            // 
            this.panelGrnItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGrnItems.AutoScroll = true;
            this.panelGrnItems.AutoScrollMinSize = new System.Drawing.Size(1100, 0);
            this.panelGrnItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrnItems.Controls.Add(this.dgvGrnDetails);
            this.panelGrnItems.Controls.Add(this.panelItemData);
            this.panelGrnItems.Location = new System.Drawing.Point(6, 181);
            this.panelGrnItems.Name = "panelGrnItems";
            this.panelGrnItems.Size = new System.Drawing.Size(687, 146);
            this.panelGrnItems.TabIndex = 2;
            // 
            // dgvGrnDetails
            // 
            this.dgvGrnDetails.AllowUserToAddRows = false;
            this.dgvGrnDetails.AllowUserToDeleteRows = false;
            this.dgvGrnDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrnDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGrnDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGrnDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvGrnItemsColumn_X,
            this.itemIDDataGridViewTextBoxColumn1,
            this.dgvGrnItemsColumn_ItemName,
            this.unitDataGridViewTextBoxColumn1,
            this.qtyDataGridViewTextBoxColumn1,
            this.freeItemDataGridViewTextBoxColumn1,
            this.unitPriceDataGridViewTextBoxColumn1,
            this.discountValueDataGridViewTextBoxColumn1,
            this.amountDataGridViewTextBoxColumn1,
            this.remarksDataGridViewTextBoxColumn1});
            this.dgvGrnDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrnDetails.Location = new System.Drawing.Point(0, 42);
            this.dgvGrnDetails.MultiSelect = false;
            this.dgvGrnDetails.Name = "dgvGrnDetails";
            this.dgvGrnDetails.ReadOnly = true;
            this.dgvGrnDetails.RowHeadersWidth = 24;
            this.dgvGrnDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvGrnDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrnDetails.Size = new System.Drawing.Size(1100, 85);
            this.dgvGrnDetails.StandardTab = true;
            this.dgvGrnDetails.TabIndex = 2;
            this.dgvGrnDetails.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrnDetails_CellContentDoubleClick);
            this.dgvGrnDetails.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrnDetails_CellDoubleClick);
            this.dgvGrnDetails.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrnDetails_CellValueChanged);
            this.dgvGrnDetails.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrnDetails_CellValueChanged);
            this.dgvGrnDetails.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvGrnDetails_CellValueNeeded);
            this.dgvGrnDetails.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvGrnDetails_CellValueNeeded);
            this.dgvGrnDetails.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvGrnDetails_DataBindingComplete);
            // 
            // dgvGrnItemsColumn_X
            // 
            this.dgvGrnItemsColumn_X.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Maroon;
            this.dgvGrnItemsColumn_X.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGrnItemsColumn_X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvGrnItemsColumn_X.Frozen = true;
            this.dgvGrnItemsColumn_X.HeaderText = "X";
            this.dgvGrnItemsColumn_X.MinimumWidth = 25;
            this.dgvGrnItemsColumn_X.Name = "dgvGrnItemsColumn_X";
            this.dgvGrnItemsColumn_X.ReadOnly = true;
            this.dgvGrnItemsColumn_X.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrnItemsColumn_X.Text = "X";
            this.dgvGrnItemsColumn_X.UseColumnTextForButtonValue = true;
            this.dgvGrnItemsColumn_X.Width = 25;
            // 
            // itemIDDataGridViewTextBoxColumn1
            // 
            this.itemIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemIDDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.itemIDDataGridViewTextBoxColumn1.Frozen = true;
            this.itemIDDataGridViewTextBoxColumn1.HeaderText = "Item ID";
            this.itemIDDataGridViewTextBoxColumn1.MinimumWidth = 90;
            this.itemIDDataGridViewTextBoxColumn1.Name = "itemIDDataGridViewTextBoxColumn1";
            this.itemIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.itemIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.itemIDDataGridViewTextBoxColumn1.Width = 90;
            // 
            // dgvGrnItemsColumn_ItemName
            // 
            this.dgvGrnItemsColumn_ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrnItemsColumn_ItemName.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvGrnItemsColumn_ItemName.Frozen = true;
            this.dgvGrnItemsColumn_ItemName.HeaderText = "Item Name";
            this.dgvGrnItemsColumn_ItemName.MinimumWidth = 175;
            this.dgvGrnItemsColumn_ItemName.Name = "dgvGrnItemsColumn_ItemName";
            this.dgvGrnItemsColumn_ItemName.ReadOnly = true;
            this.dgvGrnItemsColumn_ItemName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrnItemsColumn_ItemName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvGrnItemsColumn_ItemName.Width = 175;
            // 
            // unitDataGridViewTextBoxColumn1
            // 
            this.unitDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.unitDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle9;
            this.unitDataGridViewTextBoxColumn1.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn1.MinimumWidth = 80;
            this.unitDataGridViewTextBoxColumn1.Name = "unitDataGridViewTextBoxColumn1";
            this.unitDataGridViewTextBoxColumn1.ReadOnly = true;
            this.unitDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unitDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.unitDataGridViewTextBoxColumn1.Width = 80;
            // 
            // qtyDataGridViewTextBoxColumn1
            // 
            this.qtyDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = "0.00";
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.qtyDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle10;
            this.qtyDataGridViewTextBoxColumn1.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn1.MinimumWidth = 75;
            this.qtyDataGridViewTextBoxColumn1.Name = "qtyDataGridViewTextBoxColumn1";
            this.qtyDataGridViewTextBoxColumn1.ReadOnly = true;
            this.qtyDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.qtyDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.qtyDataGridViewTextBoxColumn1.Width = 75;
            // 
            // freeItemDataGridViewTextBoxColumn1
            // 
            this.freeItemDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = "0.00";
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.freeItemDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle11;
            this.freeItemDataGridViewTextBoxColumn1.HeaderText = "Free Item";
            this.freeItemDataGridViewTextBoxColumn1.MinimumWidth = 75;
            this.freeItemDataGridViewTextBoxColumn1.Name = "freeItemDataGridViewTextBoxColumn1";
            this.freeItemDataGridViewTextBoxColumn1.ReadOnly = true;
            this.freeItemDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.freeItemDataGridViewTextBoxColumn1.Width = 76;
            // 
            // unitPriceDataGridViewTextBoxColumn1
            // 
            this.unitPriceDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "C2";
            dataGridViewCellStyle12.NullValue = "0.00";
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.unitPriceDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle12;
            this.unitPriceDataGridViewTextBoxColumn1.HeaderText = "Unit Price";
            this.unitPriceDataGridViewTextBoxColumn1.MinimumWidth = 100;
            this.unitPriceDataGridViewTextBoxColumn1.Name = "unitPriceDataGridViewTextBoxColumn1";
            this.unitPriceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.unitPriceDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unitPriceDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // discountValueDataGridViewTextBoxColumn1
            // 
            this.discountValueDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "C2";
            dataGridViewCellStyle13.NullValue = "0.00";
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.discountValueDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle13;
            this.discountValueDataGridViewTextBoxColumn1.HeaderText = "Disc. Value";
            this.discountValueDataGridViewTextBoxColumn1.MinimumWidth = 100;
            this.discountValueDataGridViewTextBoxColumn1.Name = "discountValueDataGridViewTextBoxColumn1";
            this.discountValueDataGridViewTextBoxColumn1.ReadOnly = true;
            this.discountValueDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            this.amountDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.Format = "C2";
            dataGridViewCellStyle14.NullValue = "0.00";
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.amountDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle14;
            this.amountDataGridViewTextBoxColumn1.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn1.MinimumWidth = 110;
            this.amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
            this.amountDataGridViewTextBoxColumn1.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.amountDataGridViewTextBoxColumn1.Width = 110;
            // 
            // remarksDataGridViewTextBoxColumn1
            // 
            this.remarksDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remarksDataGridViewTextBoxColumn1.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn1.MinimumWidth = 175;
            this.remarksDataGridViewTextBoxColumn1.Name = "remarksDataGridViewTextBoxColumn1";
            this.remarksDataGridViewTextBoxColumn1.ReadOnly = true;
            this.remarksDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panelItemData
            // 
            this.panelItemData.AutoScroll = true;
            this.panelItemData.AutoScrollMinSize = new System.Drawing.Size(725, 0);
            this.panelItemData.Controls.Add(this.txtItem_Name);
            this.panelItemData.Controls.Add(this.txtItem_Remarks);
            this.panelItemData.Controls.Add(this.txtItem_ID);
            this.panelItemData.Controls.Add(label1);
            this.panelItemData.Controls.Add(this.btnAddItem);
            this.panelItemData.Controls.Add(this.btnItemReset);
            this.panelItemData.Controls.Add(item_IDLabel1);
            this.panelItemData.Controls.Add(item_NameLabel1);
            this.panelItemData.Controls.Add(this.cmbItem_Unit);
            this.panelItemData.Controls.Add(amountLabel);
            this.panelItemData.Controls.Add(this.nudItem_QTY);
            this.panelItemData.Controls.Add(this.lblItem_Amount);
            this.panelItemData.Controls.Add(unitLabel);
            this.panelItemData.Controls.Add(qtyLabel);
            this.panelItemData.Controls.Add(discount_ValueLabel);
            this.panelItemData.Controls.Add(this.nudItem_DiscountValue);
            this.panelItemData.Controls.Add(this.nudItem_FreeItem);
            this.panelItemData.Controls.Add(freeItemLabel);
            this.panelItemData.Controls.Add(unitPriceLabel);
            this.panelItemData.Controls.Add(this.nudItem_UnitPrice);
            this.panelItemData.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelItemData.Location = new System.Drawing.Point(0, 0);
            this.panelItemData.Name = "panelItemData";
            this.panelItemData.Size = new System.Drawing.Size(1100, 42);
            this.panelItemData.TabIndex = 1;
            // 
            // txtItem_Name
            // 
            this.txtItem_Name.BackColor = System.Drawing.Color.White;
            this.txtItem_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtItem_Name.Location = new System.Drawing.Point(140, 16);
            this.txtItem_Name.Name = "txtItem_Name";
            this.txtItem_Name.ReadOnly = true;
            this.txtItem_Name.Size = new System.Drawing.Size(169, 20);
            this.txtItem_Name.TabIndex = 2;
            this.txtItem_Name.TabStop = false;
            this.txtItem_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // txtItem_Remarks
            // 
            this.txtItem_Remarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItem_Remarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtItem_Remarks.Location = new System.Drawing.Point(855, 17);
            this.txtItem_Remarks.Name = "txtItem_Remarks";
            this.txtItem_Remarks.Size = new System.Drawing.Size(189, 20);
            this.txtItem_Remarks.TabIndex = 8;
            this.txtItem_Remarks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // txtItem_ID
            // 
            this.txtItem_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtItem_ID.FindButtonBackColor = System.Drawing.Color.Salmon;
            this.txtItem_ID.Location = new System.Drawing.Point(49, 16);
            this.txtItem_ID.Name = "txtItem_ID";
            this.txtItem_ID.ReadOnlyTextbox = true;
            this.txtItem_ID.Size = new System.Drawing.Size(85, 20);
            this.txtItem_ID.TabIndex = 1;
            this.txtItem_ID.TextResult = "";
            this.toolTip.SetToolTip(this.txtItem_ID, "Alt+I");
            this.txtItem_ID.resultTextbox_TextChanged += new System.EventHandler(this.txtItem_ID_resultTextbox_TextChanged);
            this.txtItem_ID.findButton_Click += new System.EventHandler(this.txtItem_ID_findButton_Click);
            this.txtItem_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddItem.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAddItem.FlatAppearance.BorderSize = 3;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddItem.Image")));
            this.btnAddItem.Location = new System.Drawing.Point(1050, 3);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(47, 36);
            this.btnAddItem.TabIndex = 9;
            this.toolTip.SetToolTip(this.btnAddItem, "Add item to list\r\n(Alt+Down)");
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            this.btnAddItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // btnItemReset
            // 
            this.btnItemReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnItemReset.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnItemReset.FlatAppearance.BorderSize = 3;
            this.btnItemReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemReset.Image = global::SenaExSIMSMiniEdition.Properties.Resources.Reset;
            this.btnItemReset.Location = new System.Drawing.Point(3, 3);
            this.btnItemReset.Name = "btnItemReset";
            this.btnItemReset.Size = new System.Drawing.Size(40, 36);
            this.btnItemReset.TabIndex = 0;
            this.toolTip.SetToolTip(this.btnItemReset, "Reset item details entry fields\r\n(Alt+R)");
            this.btnItemReset.UseVisualStyleBackColor = false;
            this.btnItemReset.Click += new System.EventHandler(this.btnItemReset_Click);
            this.btnItemReset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // cmbItem_Unit
            // 
            this.cmbItem_Unit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemsBindingSource, "Unit", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cmbItem_Unit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Unit", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cmbItem_Unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem_Unit.Enabled = false;
            this.cmbItem_Unit.FormattingEnabled = true;
            this.cmbItem_Unit.Items.AddRange(new object[] {
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
            this.cmbItem_Unit.Location = new System.Drawing.Point(315, 16);
            this.cmbItem_Unit.Name = "cmbItem_Unit";
            this.cmbItem_Unit.Size = new System.Drawing.Size(74, 21);
            this.cmbItem_Unit.TabIndex = 3;
            this.cmbItem_Unit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "items";
            this.itemsBindingSource.DataSource = this.senaexminidbDataSet;
            // 
            // nudItem_QTY
            // 
            this.nudItem_QTY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudItem_QTY.DecimalPlaces = 2;
            this.nudItem_QTY.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudItem_QTY.Location = new System.Drawing.Point(395, 17);
            this.nudItem_QTY.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nudItem_QTY.Name = "nudItem_QTY";
            this.nudItem_QTY.Size = new System.Drawing.Size(69, 20);
            this.nudItem_QTY.TabIndex = 4;
            this.nudItem_QTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudItem_QTY.ThousandsSeparator = true;
            this.nudItem_QTY.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudItem_QTY.ValueChanged += new System.EventHandler(this.calLineTotalAmount);
            this.nudItem_QTY.Enter += new System.EventHandler(this.NumericUpDown_foucusEnterSelect);
            this.nudItem_QTY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // lblItem_Amount
            // 
            this.lblItem_Amount.BackColor = System.Drawing.SystemColors.Info;
            this.lblItem_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItem_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem_Amount.Location = new System.Drawing.Point(745, 17);
            this.lblItem_Amount.Name = "lblItem_Amount";
            this.lblItem_Amount.Size = new System.Drawing.Size(104, 20);
            this.lblItem_Amount.TabIndex = 0;
            this.lblItem_Amount.Text = "0.00";
            this.lblItem_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudItem_DiscountValue
            // 
            this.nudItem_DiscountValue.DecimalPlaces = 2;
            this.nudItem_DiscountValue.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudItem_DiscountValue.Location = new System.Drawing.Point(645, 17);
            this.nudItem_DiscountValue.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nudItem_DiscountValue.Name = "nudItem_DiscountValue";
            this.nudItem_DiscountValue.Size = new System.Drawing.Size(94, 20);
            this.nudItem_DiscountValue.TabIndex = 7;
            this.nudItem_DiscountValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudItem_DiscountValue.ThousandsSeparator = true;
            this.nudItem_DiscountValue.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudItem_DiscountValue.ValueChanged += new System.EventHandler(this.calLineTotalAmount);
            this.nudItem_DiscountValue.Enter += new System.EventHandler(this.NumericUpDown_foucusEnterSelect);
            this.nudItem_DiscountValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // nudItem_FreeItem
            // 
            this.nudItem_FreeItem.DecimalPlaces = 2;
            this.nudItem_FreeItem.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudItem_FreeItem.Location = new System.Drawing.Point(470, 17);
            this.nudItem_FreeItem.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nudItem_FreeItem.Name = "nudItem_FreeItem";
            this.nudItem_FreeItem.Size = new System.Drawing.Size(70, 20);
            this.nudItem_FreeItem.TabIndex = 5;
            this.nudItem_FreeItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudItem_FreeItem.ThousandsSeparator = true;
            this.nudItem_FreeItem.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudItem_FreeItem.Enter += new System.EventHandler(this.NumericUpDown_foucusEnterSelect);
            this.nudItem_FreeItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // nudItem_UnitPrice
            // 
            this.nudItem_UnitPrice.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.itemsBindingSource, "Purchase_Price", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.nudItem_UnitPrice.DecimalPlaces = 2;
            this.nudItem_UnitPrice.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudItem_UnitPrice.Location = new System.Drawing.Point(546, 17);
            this.nudItem_UnitPrice.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nudItem_UnitPrice.Name = "nudItem_UnitPrice";
            this.nudItem_UnitPrice.Size = new System.Drawing.Size(93, 20);
            this.nudItem_UnitPrice.TabIndex = 6;
            this.nudItem_UnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudItem_UnitPrice.ThousandsSeparator = true;
            this.nudItem_UnitPrice.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudItem_UnitPrice.ValueChanged += new System.EventHandler(this.calLineTotalAmount);
            this.nudItem_UnitPrice.Enter += new System.EventHandler(this.NumericUpDown_foucusEnterSelect);
            this.nudItem_UnitPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // lblGRNHeader
            // 
            this.lblGRNHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGRNHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGRNHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGRNHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRNHeader.ForeColor = System.Drawing.Color.White;
            this.lblGRNHeader.Location = new System.Drawing.Point(3, 16);
            this.lblGRNHeader.Name = "lblGRNHeader";
            this.lblGRNHeader.Size = new System.Drawing.Size(693, 26);
            this.lblGRNHeader.TabIndex = 0;
            this.lblGRNHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGRNHeader.TextChanged += new System.EventHandler(this.lblGRNHeader_TextChanged);
            // 
            // panelGRN_Amounts
            // 
            this.panelGRN_Amounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGRN_Amounts.Controls.Add(this.nudGRN_SpecDisc);
            this.panelGRN_Amounts.Controls.Add(this.lblGRN_TotalDisc);
            this.panelGRN_Amounts.Controls.Add(total_AmountLabel);
            this.panelGRN_Amounts.Controls.Add(this.lblGRN_TotalAmount);
            this.panelGRN_Amounts.Controls.Add(total_DiscountLabel);
            this.panelGRN_Amounts.Controls.Add(special_DiscountLabel);
            this.panelGRN_Amounts.Controls.Add(remarksLabel);
            this.panelGRN_Amounts.Controls.Add(this.txtGRN_Remarks);
            this.panelGRN_Amounts.Location = new System.Drawing.Point(444, 333);
            this.panelGRN_Amounts.Margin = new System.Windows.Forms.Padding(0);
            this.panelGRN_Amounts.Name = "panelGRN_Amounts";
            this.panelGRN_Amounts.Size = new System.Drawing.Size(249, 179);
            this.panelGRN_Amounts.TabIndex = 3;
            // 
            // nudGRN_SpecDisc
            // 
            this.nudGRN_SpecDisc.DecimalPlaces = 2;
            this.nudGRN_SpecDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGRN_SpecDisc.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudGRN_SpecDisc.Location = new System.Drawing.Point(118, 3);
            this.nudGRN_SpecDisc.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nudGRN_SpecDisc.Name = "nudGRN_SpecDisc";
            this.nudGRN_SpecDisc.Size = new System.Drawing.Size(127, 21);
            this.nudGRN_SpecDisc.TabIndex = 1;
            this.nudGRN_SpecDisc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudGRN_SpecDisc.ThousandsSeparator = true;
            this.nudGRN_SpecDisc.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudGRN_SpecDisc.ValueChanged += new System.EventHandler(this.nudGRN_SpecDisc_ValueChanged);
            this.nudGRN_SpecDisc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKeyDown);
            // 
            // lblGRN_TotalDisc
            // 
            this.lblGRN_TotalDisc.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblGRN_TotalDisc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGRN_TotalDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRN_TotalDisc.Location = new System.Drawing.Point(118, 30);
            this.lblGRN_TotalDisc.Margin = new System.Windows.Forms.Padding(3);
            this.lblGRN_TotalDisc.Name = "lblGRN_TotalDisc";
            this.lblGRN_TotalDisc.Size = new System.Drawing.Size(127, 23);
            this.lblGRN_TotalDisc.TabIndex = 0;
            this.lblGRN_TotalDisc.Text = "0.00";
            this.lblGRN_TotalDisc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGRN_TotalAmount
            // 
            this.lblGRN_TotalAmount.BackColor = System.Drawing.SystemColors.Info;
            this.lblGRN_TotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGRN_TotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGRN_TotalAmount.Location = new System.Drawing.Point(118, 59);
            this.lblGRN_TotalAmount.Margin = new System.Windows.Forms.Padding(3);
            this.lblGRN_TotalAmount.Name = "lblGRN_TotalAmount";
            this.lblGRN_TotalAmount.Size = new System.Drawing.Size(127, 23);
            this.lblGRN_TotalAmount.TabIndex = 0;
            this.lblGRN_TotalAmount.Text = "0.00";
            this.lblGRN_TotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblGRN_TotalAmount.TextChanged += new System.EventHandler(this.lblGRN_TotalAmount_TextChanged);
            // 
            // txtGRN_Remarks
            // 
            this.txtGRN_Remarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtGRN_Remarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGRN_Remarks.Location = new System.Drawing.Point(3, 107);
            this.txtGRN_Remarks.Multiline = true;
            this.txtGRN_Remarks.Name = "txtGRN_Remarks";
            this.txtGRN_Remarks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtGRN_Remarks.Size = new System.Drawing.Size(242, 69);
            this.txtGRN_Remarks.TabIndex = 2;
            // 
            // grnBindingSource
            // 
            this.grnBindingSource.DataMember = "grn";
            this.grnBindingSource.DataSource = this.senaexminidbDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Item_ID";
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Item ID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 90;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvGRNDetailsColumn_ItemName
            // 
            this.dgvGRNDetailsColumn_ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvGRNDetailsColumn_ItemName.Frozen = true;
            this.dgvGRNDetailsColumn_ItemName.HeaderText = "Item Name";
            this.dgvGRNDetailsColumn_ItemName.MinimumWidth = 175;
            this.dgvGRNDetailsColumn_ItemName.Name = "dgvGRNDetailsColumn_ItemName";
            this.dgvGRNDetailsColumn_ItemName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGRNDetailsColumn_ItemName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Unit";
            this.dataGridViewTextBoxColumn5.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Qty";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Format = "N2";
            dataGridViewCellStyle15.NullValue = "0.00";
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn6.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 75;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FreeItem";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Format = "N2";
            dataGridViewCellStyle16.NullValue = "0.00";
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn7.HeaderText = "FreeItem";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 75;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "C2";
            dataGridViewCellStyle17.NullValue = "0.00";
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn8.HeaderText = "UnitPrice";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Discount_Value";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "C2";
            dataGridViewCellStyle18.NullValue = "0.00";
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewTextBoxColumn9.HeaderText = "Disc. Value";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Amount";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.Format = "C2";
            dataGridViewCellStyle19.NullValue = "0.00";
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewTextBoxColumn10.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn11.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 110;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // gRNNoDataGridViewTextBoxColumn
            // 
            this.gRNNoDataGridViewTextBoxColumn.DataPropertyName = "GRN_No";
            this.gRNNoDataGridViewTextBoxColumn.HeaderText = "GRN_No";
            this.gRNNoDataGridViewTextBoxColumn.Name = "gRNNoDataGridViewTextBoxColumn";
            this.gRNNoDataGridViewTextBoxColumn.Width = 76;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "Item_ID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "Item_ID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.Width = 69;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.Width = 51;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.Width = 48;
            // 
            // freeItemDataGridViewTextBoxColumn
            // 
            this.freeItemDataGridViewTextBoxColumn.DataPropertyName = "FreeItem";
            this.freeItemDataGridViewTextBoxColumn.HeaderText = "FreeItem";
            this.freeItemDataGridViewTextBoxColumn.Name = "freeItemDataGridViewTextBoxColumn";
            this.freeItemDataGridViewTextBoxColumn.Width = 73;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.Width = 75;
            // 
            // discountValueDataGridViewTextBoxColumn
            // 
            this.discountValueDataGridViewTextBoxColumn.DataPropertyName = "Discount_Value";
            this.discountValueDataGridViewTextBoxColumn.HeaderText = "Discount_Value";
            this.discountValueDataGridViewTextBoxColumn.Name = "discountValueDataGridViewTextBoxColumn";
            this.discountValueDataGridViewTextBoxColumn.Width = 107;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 68;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.Width = 74;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriesTableAdapter = null;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.grn_detailsTableAdapter = this.grn_detailsTableAdapter;
            this.tableAdapterManager.grnTableAdapter = this.grnTableAdapter;
            this.tableAdapterManager.invoice_itemsTableAdapter = null;
            this.tableAdapterManager.invoice_serviceTableAdapter = null;
            this.tableAdapterManager.invoiceTableAdapter = null;
            this.tableAdapterManager.itemsTableAdapter = this.itemsTableAdapter;
            this.tableAdapterManager.paymentsTableAdapter = this.paymentsTableAdapter;
            this.tableAdapterManager.rolesTableAdapter = null;
            this.tableAdapterManager.service_typesTableAdapter = null;
            this.tableAdapterManager.suppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.vehiclesTableAdapter = null;
            // 
            // grn_detailsTableAdapter
            // 
            this.grn_detailsTableAdapter.ClearBeforeFill = true;
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
            // menuStripSK
            // 
            this.menuStripSK.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shortcutKeyToolStripMenuItem});
            this.menuStripSK.Location = new System.Drawing.Point(0, 34);
            this.menuStripSK.Name = "menuStripSK";
            this.menuStripSK.Size = new System.Drawing.Size(709, 24);
            this.menuStripSK.TabIndex = 5;
            this.menuStripSK.Text = "menuStripSK";
            this.menuStripSK.Visible = false;
            // 
            // shortcutKeyToolStripMenuItem
            // 
            this.shortcutKeyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeNewGRNToolStripMenuItem,
            this.loadGRNToolStripMenuItem,
            this.selSupToolStripMenuItem,
            this.selItemToolStripMenuItem,
            this.resetItemToolStripMenuItem,
            this.addItemToolStripMenuItem,
            this.addPaymentToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.savePrintToolStripMenuItem,
            this.printToolStripMenuItem,
            this.deleteGRNToolStripMenuItem});
            this.shortcutKeyToolStripMenuItem.Name = "shortcutKeyToolStripMenuItem";
            this.shortcutKeyToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.shortcutKeyToolStripMenuItem.Text = "Shortcut Key";
            // 
            // makeNewGRNToolStripMenuItem
            // 
            this.makeNewGRNToolStripMenuItem.Name = "makeNewGRNToolStripMenuItem";
            this.makeNewGRNToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.makeNewGRNToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.makeNewGRNToolStripMenuItem.Text = "MakeNewGRN";
            this.makeNewGRNToolStripMenuItem.Click += new System.EventHandler(this.btnMakeNewGRN_Click);
            // 
            // loadGRNToolStripMenuItem
            // 
            this.loadGRNToolStripMenuItem.Name = "loadGRNToolStripMenuItem";
            this.loadGRNToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadGRNToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.loadGRNToolStripMenuItem.Text = "LoadGRN";
            this.loadGRNToolStripMenuItem.Click += new System.EventHandler(this.btnLoadPrevGRN_Click);
            // 
            // selSupToolStripMenuItem
            // 
            this.selSupToolStripMenuItem.Name = "selSupToolStripMenuItem";
            this.selSupToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.selSupToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.selSupToolStripMenuItem.Text = "Sel Sup";
            this.selSupToolStripMenuItem.Click += new System.EventHandler(this.txtSupID_findButton_Click);
            // 
            // selItemToolStripMenuItem
            // 
            this.selItemToolStripMenuItem.Name = "selItemToolStripMenuItem";
            this.selItemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.selItemToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.selItemToolStripMenuItem.Text = "Sel Item";
            this.selItemToolStripMenuItem.Click += new System.EventHandler(this.txtItem_ID_findButton_Click);
            // 
            // resetItemToolStripMenuItem
            // 
            this.resetItemToolStripMenuItem.Name = "resetItemToolStripMenuItem";
            this.resetItemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.resetItemToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.resetItemToolStripMenuItem.Text = "Reset Item";
            this.resetItemToolStripMenuItem.Click += new System.EventHandler(this.btnItemReset_Click);
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Down)));
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.addItemToolStripMenuItem.Text = "Add Item";
            this.addItemToolStripMenuItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // addPaymentToolStripMenuItem
            // 
            this.addPaymentToolStripMenuItem.Name = "addPaymentToolStripMenuItem";
            this.addPaymentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.addPaymentToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.addPaymentToolStripMenuItem.Text = "Add Payment";
            this.addPaymentToolStripMenuItem.Click += new System.EventHandler(this.btnPayment_AddNew_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.btnGRNSave_Click);
            // 
            // savePrintToolStripMenuItem
            // 
            this.savePrintToolStripMenuItem.Name = "savePrintToolStripMenuItem";
            this.savePrintToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.savePrintToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.savePrintToolStripMenuItem.Text = "Save &&Print";
            this.savePrintToolStripMenuItem.Click += new System.EventHandler(this.btnSavePrint_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // deleteGRNToolStripMenuItem
            // 
            this.deleteGRNToolStripMenuItem.Name = "deleteGRNToolStripMenuItem";
            this.deleteGRNToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deleteGRNToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.deleteGRNToolStripMenuItem.Text = "Delete GRN";
            this.deleteGRNToolStripMenuItem.Click += new System.EventHandler(this.btnDeleteGRN_Click);
            // 
            // fKGrnDeiailsGrnNoBindingSource
            // 
            this.fKGrnDeiailsGrnNoBindingSource.DataMember = "FK_GrnDeiails_GrnNo";
            this.fKGrnDeiailsGrnNoBindingSource.DataSource = this.grnBindingSource;
            // 
            // GRNForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 562);
            this.Controls.Add(this.menuStripSK);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.lblBanner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 600);
            this.Name = "GRNForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goods Received Note";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GRNForm_Load);
            this.panelBase.ResumeLayout(false);
            this.groupBoxGRNData.ResumeLayout(false);
            this.groupBoxPayments.ResumeLayout(false);
            this.groupBoxPayments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senaexminidbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Payments)).EndInit();
            this.bindingNavigator_Payments.ResumeLayout(false);
            this.bindingNavigator_Payments.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelGrnItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrnDetails)).EndInit();
            this.panelItemData.ResumeLayout(false);
            this.panelItemData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItem_QTY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItem_DiscountValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItem_FreeItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItem_UnitPrice)).EndInit();
            this.panelGRN_Amounts.ResumeLayout(false);
            this.panelGRN_Amounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGRN_SpecDisc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            this.menuStripSK.ResumeLayout(false);
            this.menuStripSK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKGrnDeiailsGrnNoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.GroupBox groupBoxGRNData;
        private System.Windows.Forms.Button btnLoadPrevGRN;
        private System.Windows.Forms.Label lblGRNHeader;
        private System.Windows.Forms.TextBox txtGRN_Remarks;
        private System.Windows.Forms.Label lblGRN_Username;
        private System.Windows.Forms.DataGridView dgvGrnDetails;
        private System.Windows.Forms.DateTimePicker dtpGRN_RiceivedDate;
        private System.Windows.Forms.DateTimePicker dtpGRN_Date;
        private System.Windows.Forms.Label lblItem_Amount;
        private System.Windows.Forms.NumericUpDown nudItem_DiscountValue;
        private System.Windows.Forms.NumericUpDown nudItem_UnitPrice;
        private System.Windows.Forms.NumericUpDown nudItem_FreeItem;
        private System.Windows.Forms.NumericUpDown nudItem_QTY;
        private System.Windows.Forms.ComboBox cmbItem_Unit;
        private System.Windows.Forms.Panel panelGrnItems;
        private System.Windows.Forms.Panel panelItemData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGRNDetailsColumn_ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRNNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtGRN_InvNo;
        private System.Windows.Forms.TextBox txtGRN_PONo;
        private System.Windows.Forms.Label lblGRN_TotalAmount;
        private System.Windows.Forms.Button btnMakeNewGRN;
        private System.Windows.Forms.Button btnSavePrint;
        private System.Windows.Forms.Button btnGRNSave;
        private System.Windows.Forms.Button btnDeleteGRN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnViewGRNList;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnItemReset;
        private System.Windows.Forms.TextBox txtItem_Remarks;
        private senaexminidbDataSet senaexminidbDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private senaexminidbDataSetTableAdapters.itemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.Label lblGRN_TotalDisc;
        private System.Windows.Forms.NumericUpDown nudGRN_SpecDisc;
        private System.Windows.Forms.GroupBox groupBoxPayments;
        private System.Windows.Forms.Panel panelGRN_Amounts;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private senaexminidbDataSetTableAdapters.paymentsTableAdapter paymentsTableAdapter;
        private senaexminidbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.BindingSource grnBindingSource;
        private senaexminidbDataSetTableAdapters.grnTableAdapter grnTableAdapter;
        private System.Windows.Forms.BindingSource fKGrnDeiailsGrnNoBindingSource;
        private senaexminidbDataSetTableAdapters.grn_detailsTableAdapter grn_detailsTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn dgvGrnItemsColumn_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGrnItemsColumn_ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeItemDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountValueDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn1;
        private Util.FindTextBoxUC txtGRN_SupID;
        private System.Windows.Forms.TextBox txtGRN_SupName;
        private Util.FindTextBoxUC txtItem_ID;
        private System.Windows.Forms.TextBox txtItem_Name;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private senaexminidbDataSetTableAdapters.suppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator_Payments;
        private System.Windows.Forms.ToolStripButton btnPayment_Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnPayment_AddNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblBalTotal;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.MenuStrip menuStripSK;
        private System.Windows.Forms.ToolStripMenuItem shortcutKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeNewGRNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGRNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selSupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteGRNToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn PM_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PM_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
    }
}