namespace SenaExSIMSMiniEdition.PetHistory
{
    partial class HistoryForm
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
            System.Windows.Forms.Label job_NoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label makeLabel;
            System.Windows.Forms.Label vehicle_NoLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label customer_NameLabel;
            System.Windows.Forms.Label sup_IDLabel;
            System.Windows.Forms.Label inv_DateLabel;
            System.Windows.Forms.Label usernameLabel;
            this.lblBanner = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcomplain = new System.Windows.Forms.TextBox();
            this.txtlabfind = new System.Windows.Forms.TextBox();
            this.txtprescription = new System.Windows.Forms.TextBox();
            this.txtmedication = new System.Windows.Forms.TextBox();
            this.toolStripButtons = new System.Windows.Forms.ToolStrip();
            this.btnSavePrint_Receipt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSavePrint_Invoice = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator24 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveOnly = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator23 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator25 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeleteInvoice = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrint = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnMnuPrintAsCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMnuPrintAsInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMnuPrintAsReceipt = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBoxInvData = new System.Windows.Forms.GroupBox();
            this.txtJobNo = new System.Windows.Forms.TextBox();
            this.nudMeter = new System.Windows.Forms.NumericUpDown();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.vehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.senaexminidbDataSet = new SenaExSIMSMiniEdition.senaexminidbDataSet();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.cmbVehicleNo = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtCustID = new SenaExSIMSMiniEdition.Util.FindTextBoxUC();
            this.dtpInvDate = new System.Windows.Forms.DateTimePicker();
            this.lblInv_Username = new System.Windows.Forms.Label();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnMakeNewHistory = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrevInvoice = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnViewInvoiceList = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.lblHisNoHeader = new System.Windows.Forms.Label();
            this.vehiclesTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.vehiclesTableAdapter();
            this.tableAdapterManager = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.TableAdapterManager();
            this.customersTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.customersTableAdapter();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.invoiceTableAdapter();
            job_NoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            makeLabel = new System.Windows.Forms.Label();
            vehicle_NoLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            customer_NameLabel = new System.Windows.Forms.Label();
            sup_IDLabel = new System.Windows.Forms.Label();
            inv_DateLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.toolStripButtons.SuspendLayout();
            this.groupBoxInvData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senaexminidbDataSet)).BeginInit();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // job_NoLabel
            // 
            job_NoLabel.AutoSize = true;
            job_NoLabel.Location = new System.Drawing.Point(256, 62);
            job_NoLabel.Name = "job_NoLabel";
            job_NoLabel.Size = new System.Drawing.Size(44, 13);
            job_NoLabel.TabIndex = 0;
            job_NoLabel.Text = "Job No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(256, 166);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 13);
            label1.TabIndex = 0;
            label1.Text = "Weight:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(256, 141);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(28, 13);
            modelLabel.TabIndex = 0;
            modelLabel.Text = "Sex:";
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new System.Drawing.Point(256, 114);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new System.Drawing.Size(38, 13);
            makeLabel.TabIndex = 0;
            makeLabel.Text = "Breed:";
            // 
            // vehicle_NoLabel
            // 
            vehicle_NoLabel.AutoSize = true;
            vehicle_NoLabel.Location = new System.Drawing.Point(256, 88);
            vehicle_NoLabel.Name = "vehicle_NoLabel";
            vehicle_NoLabel.Size = new System.Drawing.Size(57, 13);
            vehicle_NoLabel.TabIndex = 0;
            vehicle_NoLabel.Text = "Pet Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(6, 140);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 0;
            addressLabel.Text = "Address:";
            // 
            // customer_NameLabel
            // 
            customer_NameLabel.AutoSize = true;
            customer_NameLabel.Location = new System.Drawing.Point(6, 114);
            customer_NameLabel.Name = "customer_NameLabel";
            customer_NameLabel.Size = new System.Drawing.Size(85, 13);
            customer_NameLabel.TabIndex = 0;
            customer_NameLabel.Text = "Customer Name:";
            // 
            // sup_IDLabel
            // 
            sup_IDLabel.AutoSize = true;
            sup_IDLabel.Location = new System.Drawing.Point(6, 88);
            sup_IDLabel.Name = "sup_IDLabel";
            sup_IDLabel.Size = new System.Drawing.Size(68, 13);
            sup_IDLabel.TabIndex = 0;
            sup_IDLabel.Text = "Customre ID:";
            // 
            // inv_DateLabel
            // 
            inv_DateLabel.AutoSize = true;
            inv_DateLabel.Location = new System.Drawing.Point(6, 62);
            inv_DateLabel.Name = "inv_DateLabel";
            inv_DateLabel.Size = new System.Drawing.Size(71, 13);
            inv_DateLabel.TabIndex = 0;
            inv_DateLabel.Text = "Invoice Date:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(6, 40);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(58, 13);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username:";
            // 
            // lblBanner
            // 
            this.lblBanner.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBanner.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.ForeColor = System.Drawing.Color.White;
            this.lblBanner.Location = new System.Drawing.Point(0, 0);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(1028, 34);
            this.lblBanner.TabIndex = 1;
            this.lblBanner.Text = "Pet History";
            this.lblBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtcomplain);
            this.groupBox1.Controls.Add(this.txtlabfind);
            this.groupBox1.Controls.Add(this.txtprescription);
            this.groupBox1.Controls.Add(this.txtmedication);
            this.groupBox1.Controls.Add(this.toolStripButtons);
            this.groupBox1.Controls.Add(this.groupBoxInvData);
            this.groupBox1.Controls.Add(this.lblHisNoHeader);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(1028, 629);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process History";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(528, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Prescription";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Medication";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Clinical Signs && Lab finding";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(470, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Complain";
            // 
            // txtcomplain
            // 
            this.txtcomplain.Location = new System.Drawing.Point(462, 68);
            this.txtcomplain.Multiline = true;
            this.txtcomplain.Name = "txtcomplain";
            this.txtcomplain.Size = new System.Drawing.Size(548, 158);
            this.txtcomplain.TabIndex = 0;
            // 
            // txtlabfind
            // 
            this.txtlabfind.Location = new System.Drawing.Point(13, 260);
            this.txtlabfind.Multiline = true;
            this.txtlabfind.Name = "txtlabfind";
            this.txtlabfind.Size = new System.Drawing.Size(997, 139);
            this.txtlabfind.TabIndex = 4;
            // 
            // txtprescription
            // 
            this.txtprescription.Location = new System.Drawing.Point(528, 438);
            this.txtprescription.Multiline = true;
            this.txtprescription.Name = "txtprescription";
            this.txtprescription.Size = new System.Drawing.Size(482, 137);
            this.txtprescription.TabIndex = 0;
            // 
            // txtmedication
            // 
            this.txtmedication.Location = new System.Drawing.Point(9, 438);
            this.txtmedication.Multiline = true;
            this.txtmedication.Name = "txtmedication";
            this.txtmedication.Size = new System.Drawing.Size(493, 137);
            this.txtmedication.TabIndex = 0;
            // 
            // toolStripButtons
            // 
            this.toolStripButtons.AutoSize = false;
            this.toolStripButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSavePrint_Receipt,
            this.toolStripSeparator20,
            this.btnSavePrint_Invoice,
            this.toolStripSeparator24,
            this.btnSaveOnly,
            this.toolStripSeparator23,
            this.toolStripSeparator25,
            this.btnDeleteInvoice,
            this.toolStripSeparator22,
            this.btnPrint,
            this.toolStripSeparator21});
            this.toolStripButtons.Location = new System.Drawing.Point(3, 591);
            this.toolStripButtons.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.toolStripButtons.Name = "toolStripButtons";
            this.toolStripButtons.Size = new System.Drawing.Size(1022, 35);
            this.toolStripButtons.TabIndex = 6;
            this.toolStripButtons.TabStop = true;
            // 
            // btnSavePrint_Receipt
            // 
            this.btnSavePrint_Receipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSavePrint_Receipt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSavePrint_Receipt.Image = global::SenaExSIMSMiniEdition.Properties.Resources.SavePrint;
            this.btnSavePrint_Receipt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSavePrint_Receipt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSavePrint_Receipt.Name = "btnSavePrint_Receipt";
            this.btnSavePrint_Receipt.Size = new System.Drawing.Size(168, 32);
            this.btnSavePrint_Receipt.Text = "Save && Print As Receipt";
            this.btnSavePrint_Receipt.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnSavePrint_Receipt.ToolTipText = "Save & Print As Receipt";
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            this.toolStripSeparator20.Size = new System.Drawing.Size(6, 35);
            // 
            // btnSavePrint_Invoice
            // 
            this.btnSavePrint_Invoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSavePrint_Invoice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSavePrint_Invoice.Image = global::SenaExSIMSMiniEdition.Properties.Resources.SavePrint;
            this.btnSavePrint_Invoice.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSavePrint_Invoice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSavePrint_Invoice.Name = "btnSavePrint_Invoice";
            this.btnSavePrint_Invoice.Size = new System.Drawing.Size(165, 32);
            this.btnSavePrint_Invoice.Text = "Save && Print As History";
            this.btnSavePrint_Invoice.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnSavePrint_Invoice.ToolTipText = "Save & Print As Invoice";
            // 
            // toolStripSeparator24
            // 
            this.toolStripSeparator24.Name = "toolStripSeparator24";
            this.toolStripSeparator24.Size = new System.Drawing.Size(6, 35);
            // 
            // btnSaveOnly
            // 
            this.btnSaveOnly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveOnly.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveOnly.Image = global::SenaExSIMSMiniEdition.Properties.Resources.Save;
            this.btnSaveOnly.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSaveOnly.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveOnly.Name = "btnSaveOnly";
            this.btnSaveOnly.Size = new System.Drawing.Size(91, 32);
            this.btnSaveOnly.Text = "Save Only";
            this.btnSaveOnly.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnSaveOnly.ToolTipText = "Save Only";
            this.btnSaveOnly.Click += new System.EventHandler(this.btnSaveOnly_Click);
            // 
            // toolStripSeparator23
            // 
            this.toolStripSeparator23.Name = "toolStripSeparator23";
            this.toolStripSeparator23.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripSeparator25
            // 
            this.toolStripSeparator25.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator25.Name = "toolStripSeparator25";
            this.toolStripSeparator25.Size = new System.Drawing.Size(6, 35);
            // 
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnDeleteInvoice.Enabled = false;
            this.btnDeleteInvoice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteInvoice.Image = global::SenaExSIMSMiniEdition.Properties.Resources.Delete;
            this.btnDeleteInvoice.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteInvoice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(143, 32);
            this.btnDeleteInvoice.Text = "Delete This Invoice";
            // 
            // toolStripSeparator22
            // 
            this.toolStripSeparator22.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator22.Name = "toolStripSeparator22";
            this.toolStripSeparator22.Size = new System.Drawing.Size(6, 35);
            // 
            // btnPrint
            // 
            this.btnPrint.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnPrint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMnuPrintAsCopy,
            this.btnMnuPrintAsInvoice,
            this.btnMnuPrintAsReceipt});
            this.btnPrint.Enabled = false;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Image = global::SenaExSIMSMiniEdition.Properties.Resources.Print;
            this.btnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(72, 32);
            this.btnPrint.Text = "Print";
            // 
            // btnMnuPrintAsCopy
            // 
            this.btnMnuPrintAsCopy.Name = "btnMnuPrintAsCopy";
            this.btnMnuPrintAsCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.btnMnuPrintAsCopy.Size = new System.Drawing.Size(218, 22);
            this.btnMnuPrintAsCopy.Text = "As Copy";
            // 
            // btnMnuPrintAsInvoice
            // 
            this.btnMnuPrintAsInvoice.Name = "btnMnuPrintAsInvoice";
            this.btnMnuPrintAsInvoice.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.btnMnuPrintAsInvoice.Size = new System.Drawing.Size(218, 22);
            this.btnMnuPrintAsInvoice.Text = "As Invoice";
            // 
            // btnMnuPrintAsReceipt
            // 
            this.btnMnuPrintAsReceipt.Name = "btnMnuPrintAsReceipt";
            this.btnMnuPrintAsReceipt.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.btnMnuPrintAsReceipt.Size = new System.Drawing.Size(218, 22);
            this.btnMnuPrintAsReceipt.Text = "As Receipt";
            // 
            // toolStripSeparator21
            // 
            this.toolStripSeparator21.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator21.Name = "toolStripSeparator21";
            this.toolStripSeparator21.Size = new System.Drawing.Size(6, 35);
            // 
            // groupBoxInvData
            // 
            this.groupBoxInvData.Controls.Add(job_NoLabel);
            this.groupBoxInvData.Controls.Add(this.txtJobNo);
            this.groupBoxInvData.Controls.Add(this.nudMeter);
            this.groupBoxInvData.Controls.Add(label1);
            this.groupBoxInvData.Controls.Add(modelLabel);
            this.groupBoxInvData.Controls.Add(this.txtModel);
            this.groupBoxInvData.Controls.Add(makeLabel);
            this.groupBoxInvData.Controls.Add(this.txtMake);
            this.groupBoxInvData.Controls.Add(vehicle_NoLabel);
            this.groupBoxInvData.Controls.Add(this.cmbVehicleNo);
            this.groupBoxInvData.Controls.Add(this.txtAddress);
            this.groupBoxInvData.Controls.Add(this.txtCustName);
            this.groupBoxInvData.Controls.Add(addressLabel);
            this.groupBoxInvData.Controls.Add(customer_NameLabel);
            this.groupBoxInvData.Controls.Add(this.txtCustID);
            this.groupBoxInvData.Controls.Add(sup_IDLabel);
            this.groupBoxInvData.Controls.Add(inv_DateLabel);
            this.groupBoxInvData.Controls.Add(this.dtpInvDate);
            this.groupBoxInvData.Controls.Add(this.lblInv_Username);
            this.groupBoxInvData.Controls.Add(usernameLabel);
            this.groupBoxInvData.Controls.Add(this.toolStripMain);
            this.groupBoxInvData.Location = new System.Drawing.Point(6, 39);
            this.groupBoxInvData.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBoxInvData.Name = "groupBoxInvData";
            this.groupBoxInvData.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBoxInvData.Size = new System.Drawing.Size(450, 194);
            this.groupBoxInvData.TabIndex = 1;
            this.groupBoxInvData.TabStop = false;
            // 
            // txtJobNo
            // 
            this.txtJobNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtJobNo.Location = new System.Drawing.Point(326, 62);
            this.txtJobNo.Name = "txtJobNo";
            this.txtJobNo.Size = new System.Drawing.Size(118, 20);
            this.txtJobNo.TabIndex = 3;
            // 
            // nudMeter
            // 
            this.nudMeter.DecimalPlaces = 2;
            this.nudMeter.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudMeter.Location = new System.Drawing.Point(326, 167);
            this.nudMeter.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudMeter.Name = "nudMeter";
            this.nudMeter.Size = new System.Drawing.Size(118, 20);
            this.nudMeter.TabIndex = 6;
            this.nudMeter.ThousandsSeparator = true;
            this.nudMeter.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.SystemColors.Window;
            this.txtModel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "Model", true));
            this.txtModel.Location = new System.Drawing.Point(326, 141);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(118, 20);
            this.txtModel.TabIndex = 0;
            this.txtModel.TabStop = false;
            // 
            // vehiclesBindingSource
            // 
            this.vehiclesBindingSource.DataMember = "FK_CustID_Customers";
            this.vehiclesBindingSource.DataSource = this.customersBindingSource;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "customers";
            this.customersBindingSource.DataSource = this.senaexminidbDataSet;
            // 
            // senaexminidbDataSet
            // 
            this.senaexminidbDataSet.DataSetName = "senaexminidbDataSet";
            this.senaexminidbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMake
            // 
            this.txtMake.BackColor = System.Drawing.SystemColors.Window;
            this.txtMake.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMake.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "Make", true));
            this.txtMake.Location = new System.Drawing.Point(326, 114);
            this.txtMake.Name = "txtMake";
            this.txtMake.ReadOnly = true;
            this.txtMake.Size = new System.Drawing.Size(118, 20);
            this.txtMake.TabIndex = 0;
            this.txtMake.TabStop = false;
            // 
            // cmbVehicleNo
            // 
            this.cmbVehicleNo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vehiclesBindingSource, "Vehicle_No", true));
            this.cmbVehicleNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehiclesBindingSource, "Vehicle_No", true));
            this.cmbVehicleNo.DataSource = this.vehiclesBindingSource;
            this.cmbVehicleNo.DisplayMember = "Vehicle_No";
            this.cmbVehicleNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicleNo.FormattingEnabled = true;
            this.cmbVehicleNo.Location = new System.Drawing.Point(326, 88);
            this.cmbVehicleNo.Name = "cmbVehicleNo";
            this.cmbVehicleNo.Size = new System.Drawing.Size(118, 21);
            this.cmbVehicleNo.TabIndex = 5;
            this.cmbVehicleNo.ValueMember = "Vehicle_No";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddress.Location = new System.Drawing.Point(97, 140);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAddress.Size = new System.Drawing.Size(153, 47);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.TabStop = false;
            // 
            // txtCustName
            // 
            this.txtCustName.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Customer_Name", true));
            this.txtCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(97, 114);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.ReadOnly = true;
            this.txtCustName.Size = new System.Drawing.Size(153, 20);
            this.txtCustName.TabIndex = 0;
            this.txtCustName.TabStop = false;
            // 
            // txtCustID
            // 
            this.txtCustID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustID.FindButtonBackColor = System.Drawing.Color.Salmon;
            this.txtCustID.Location = new System.Drawing.Point(97, 88);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.ReadOnlyTextbox = true;
            this.txtCustID.Size = new System.Drawing.Size(153, 20);
            this.txtCustID.TabIndex = 4;
            this.txtCustID.TextResult = "";
            this.txtCustID.resultTextbox_TextChanged += new System.EventHandler(this.txtCustID_resultTextbox_TextChanged);
            this.txtCustID.findButton_Click += new System.EventHandler(this.txtCustID_findButton_Click);
            // 
            // dtpInvDate
            // 
            this.dtpInvDate.CustomFormat = "yyyy-MMM-dd ddd";
            this.dtpInvDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvDate.Location = new System.Drawing.Point(97, 62);
            this.dtpInvDate.Name = "dtpInvDate";
            this.dtpInvDate.Size = new System.Drawing.Size(153, 20);
            this.dtpInvDate.TabIndex = 2;
            // 
            // lblInv_Username
            // 
            this.lblInv_Username.AutoSize = true;
            this.lblInv_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInv_Username.Location = new System.Drawing.Point(94, 40);
            this.lblInv_Username.Margin = new System.Windows.Forms.Padding(3);
            this.lblInv_Username.Name = "lblInv_Username";
            this.lblInv_Username.Size = new System.Drawing.Size(101, 13);
            this.lblInv_Username.TabIndex = 0;
            this.lblInv_Username.Text = "Role : Username";
            // 
            // toolStripMain
            // 
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMakeNewHistory,
            this.toolStripSeparator1,
            this.btnPrevInvoice,
            this.toolStripSeparator2,
            this.btnViewInvoiceList,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.toolStripSeparator5});
            this.toolStripMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripMain.Location = new System.Drawing.Point(3, 13);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(444, 27);
            this.toolStripMain.TabIndex = 1;
            this.toolStripMain.TabStop = true;
            this.toolStripMain.Text = "toolStripMain";
            // 
            // btnMakeNewHistory
            // 
            this.btnMakeNewHistory.Image = global::SenaExSIMSMiniEdition.Properties.Resources.AddNew;
            this.btnMakeNewHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMakeNewHistory.Name = "btnMakeNewHistory";
            this.btnMakeNewHistory.Size = new System.Drawing.Size(128, 24);
            this.btnMakeNewHistory.Text = "Make New History";
            this.btnMakeNewHistory.Click += new System.EventHandler(this.btnMakeNewHistory_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnPrevInvoice
            // 
            this.btnPrevInvoice.Image = global::SenaExSIMSMiniEdition.Properties.Resources.LoadDetails;
            this.btnPrevInvoice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrevInvoice.Name = "btnPrevInvoice";
            this.btnPrevInvoice.Size = new System.Drawing.Size(146, 24);
            this.btnPrevInvoice.Text = "Load Previous History";
            this.btnPrevInvoice.Click += new System.EventHandler(this.btnPrevInvoice_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnViewInvoiceList
            // 
            this.btnViewInvoiceList.Image = global::SenaExSIMSMiniEdition.Properties.Resources.Show_Property;
            this.btnViewInvoiceList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnViewInvoiceList.Name = "btnViewInvoiceList";
            this.btnViewInvoiceList.Size = new System.Drawing.Size(118, 24);
            this.btnViewInvoiceList.Text = "View History List";
            this.btnViewInvoiceList.Click += new System.EventHandler(this.btnViewInvoiceList_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // lblHisNoHeader
            // 
            this.lblHisNoHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHisNoHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHisNoHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHisNoHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHisNoHeader.ForeColor = System.Drawing.Color.White;
            this.lblHisNoHeader.Location = new System.Drawing.Point(3, 13);
            this.lblHisNoHeader.Name = "lblHisNoHeader";
            this.lblHisNoHeader.Size = new System.Drawing.Size(1022, 26);
            this.lblHisNoHeader.TabIndex = 0;
            this.lblHisNoHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vehiclesTableAdapter
            // 
            this.vehiclesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.UpdateOrder = SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.UpdateInsertDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.vehiclesTableAdapter = null;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
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
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 663);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBanner);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStripButtons.ResumeLayout(false);
            this.toolStripButtons.PerformLayout();
            this.groupBoxInvData.ResumeLayout(false);
            this.groupBoxInvData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senaexminidbDataSet)).EndInit();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStripButtons;
        private System.Windows.Forms.ToolStripButton btnSavePrint_Receipt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator20;
        private System.Windows.Forms.ToolStripButton btnSavePrint_Invoice;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator24;
        private System.Windows.Forms.ToolStripButton btnSaveOnly;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator23;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator25;
        private System.Windows.Forms.ToolStripButton btnDeleteInvoice;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator22;
        private System.Windows.Forms.ToolStripDropDownButton btnPrint;
        private System.Windows.Forms.ToolStripMenuItem btnMnuPrintAsCopy;
        private System.Windows.Forms.ToolStripMenuItem btnMnuPrintAsInvoice;
        private System.Windows.Forms.ToolStripMenuItem btnMnuPrintAsReceipt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator21;
        private System.Windows.Forms.TextBox txtprescription;
        private System.Windows.Forms.TextBox txtcomplain;
        private System.Windows.Forms.GroupBox groupBoxInvData;
        private System.Windows.Forms.TextBox txtJobNo;
        private System.Windows.Forms.NumericUpDown nudMeter;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.ComboBox cmbVehicleNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCustName;
        private Util.FindTextBoxUC txtCustID;
        private System.Windows.Forms.DateTimePicker dtpInvDate;
        private System.Windows.Forms.Label lblInv_Username;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton btnMakeNewHistory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPrevInvoice;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnViewInvoiceList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Label lblHisNoHeader;
        private System.Windows.Forms.TextBox txtmedication;
        private System.Windows.Forms.TextBox txtlabfind;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private senaexminidbDataSet senaexminidbDataSet;
        private senaexminidbDataSetTableAdapters.vehiclesTableAdapter vehiclesTableAdapter;
        private senaexminidbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private senaexminidbDataSetTableAdapters.customersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource vehiclesBindingSource;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private senaexminidbDataSetTableAdapters.invoiceTableAdapter invoiceTableAdapter;
    }
}