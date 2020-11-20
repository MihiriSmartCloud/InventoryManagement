namespace SenaExSIMSMiniEdition.Customers
{
    partial class CustomersForm
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label contactPersonLabel;
            System.Windows.Forms.Label webLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label faxLabel;
            System.Windows.Forms.Label mobileLabel;
            System.Windows.Forms.Label teleLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label Cust_NameLabel;
            System.Windows.Forms.Label Cust_IDLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBanner = new System.Windows.Forms.Label();
            this.groupBoxCustDetails = new System.Windows.Forms.GroupBox();
            this.groupBoxCustData = new System.Windows.Forms.GroupBox();
            this.groupBoxCustVehicels = new System.Windows.Forms.GroupBox();
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.custIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehicle_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Make = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.senaexminidbDataSet = new SenaExSIMSMiniEdition.senaexminidbDataSet();
            this.navVehicels = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtVehicelNo = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtMake = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.txtModel = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.txtFax = new System.Windows.Forms.MaskedTextBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMobile = new System.Windows.Forms.MaskedTextBox();
            this.txtTelephone = new System.Windows.Forms.MaskedTextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCust_Name = new System.Windows.Forms.TextBox();
            this.lblCust_ID = new System.Windows.Forms.Label();
            this.groupBoxCustButtons = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblCustNameHeader = new System.Windows.Forms.Label();
            this.lblCustIDHeader = new System.Windows.Forms.Label();
            this.groupBoxSupList = new System.Windows.Forms.GroupBox();
            this.txtSearch = new SenaExSIMSMiniEdition.Util.searchBoxUC();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.custAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorCUST = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblTotalCust = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStripMain_ShctKey = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSK_Reset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSK_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSK_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSK_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSK_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSK_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.addVehicelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipSKey = new System.Windows.Forms.ToolTip(this.components);
            this.customersTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.customersTableAdapter();
            this.tableAdapterManager = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.TableAdapterManager();
            this.vehiclesTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.vehiclesTableAdapter();
            descriptionLabel = new System.Windows.Forms.Label();
            contactPersonLabel = new System.Windows.Forms.Label();
            webLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            mobileLabel = new System.Windows.Forms.Label();
            teleLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            Cust_NameLabel = new System.Windows.Forms.Label();
            Cust_IDLabel = new System.Windows.Forms.Label();
            this.groupBoxCustDetails.SuspendLayout();
            this.groupBoxCustData.SuspendLayout();
            this.groupBoxCustVehicels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senaexminidbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navVehicels)).BeginInit();
            this.navVehicels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.groupBoxCustButtons.SuspendLayout();
            this.groupBoxSupList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorCUST)).BeginInit();
            this.bindingNavigatorCUST.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStripMain_ShctKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(237, 119);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // contactPersonLabel
            // 
            contactPersonLabel.AutoSize = true;
            contactPersonLabel.Location = new System.Drawing.Point(237, 93);
            contactPersonLabel.Name = "contactPersonLabel";
            contactPersonLabel.Size = new System.Drawing.Size(71, 13);
            contactPersonLabel.TabIndex = 0;
            contactPersonLabel.Text = "Cont. Person:";
            // 
            // webLabel
            // 
            webLabel.AutoSize = true;
            webLabel.Location = new System.Drawing.Point(237, 67);
            webLabel.Name = "webLabel";
            webLabel.Size = new System.Drawing.Size(33, 13);
            webLabel.TabIndex = 0;
            webLabel.Text = "Web:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(237, 41);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Email:";
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(312, 173);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(27, 13);
            faxLabel.TabIndex = 0;
            faxLabel.Text = "Fax:";
            // 
            // mobileLabel
            // 
            mobileLabel.AutoSize = true;
            mobileLabel.Location = new System.Drawing.Point(198, 173);
            mobileLabel.Name = "mobileLabel";
            mobileLabel.Size = new System.Drawing.Size(31, 13);
            mobileLabel.TabIndex = 0;
            mobileLabel.Text = "Mob:";
            // 
            // teleLabel
            // 
            teleLabel.AutoSize = true;
            teleLabel.Location = new System.Drawing.Point(84, 173);
            teleLabel.Name = "teleLabel";
            teleLabel.Size = new System.Drawing.Size(31, 13);
            teleLabel.TabIndex = 0;
            teleLabel.Text = "Tele:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(6, 148);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(46, 13);
            countryLabel.TabIndex = 0;
            countryLabel.Text = "Country:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(6, 122);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 0;
            cityLabel.Text = "City:";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(6, 96);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(38, 13);
            streetLabel.TabIndex = 0;
            streetLabel.Text = "Street:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(6, 70);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 0;
            addressLabel.Text = "Address:";
            // 
            // Cust_NameLabel
            // 
            Cust_NameLabel.AutoSize = true;
            Cust_NameLabel.Location = new System.Drawing.Point(6, 15);
            Cust_NameLabel.Name = "Cust_NameLabel";
            Cust_NameLabel.Size = new System.Drawing.Size(65, 13);
            Cust_NameLabel.TabIndex = 0;
            Cust_NameLabel.Text = "Cust. Name:";
            // 
            // Cust_IDLabel
            // 
            Cust_IDLabel.AutoSize = true;
            Cust_IDLabel.Location = new System.Drawing.Point(6, 41);
            Cust_IDLabel.Name = "Cust_IDLabel";
            Cust_IDLabel.Size = new System.Drawing.Size(48, 13);
            Cust_IDLabel.TabIndex = 0;
            Cust_IDLabel.Text = "Cust. ID:";
            // 
            // lblBanner
            // 
            this.lblBanner.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBanner.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.ForeColor = System.Drawing.Color.White;
            this.lblBanner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBanner.Location = new System.Drawing.Point(0, 0);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(724, 34);
            this.lblBanner.TabIndex = 0;
            this.lblBanner.Text = "Customers";
            this.lblBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxCustDetails
            // 
            this.groupBoxCustDetails.Controls.Add(this.groupBoxCustData);
            this.groupBoxCustDetails.Controls.Add(this.groupBoxCustButtons);
            this.groupBoxCustDetails.Controls.Add(this.lblCustNameHeader);
            this.groupBoxCustDetails.Controls.Add(this.lblCustIDHeader);
            this.groupBoxCustDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxCustDetails.Location = new System.Drawing.Point(5, 166);
            this.groupBoxCustDetails.Name = "groupBoxCustDetails";
            this.groupBoxCustDetails.Size = new System.Drawing.Size(714, 316);
            this.groupBoxCustDetails.TabIndex = 2;
            this.groupBoxCustDetails.TabStop = false;
            this.groupBoxCustDetails.Text = "Customer\'s Details";
            // 
            // groupBoxCustData
            // 
            this.groupBoxCustData.Controls.Add(this.groupBoxCustVehicels);
            this.groupBoxCustData.Controls.Add(this.txtFax);
            this.groupBoxCustData.Controls.Add(this.txtMobile);
            this.groupBoxCustData.Controls.Add(this.txtTelephone);
            this.groupBoxCustData.Controls.Add(descriptionLabel);
            this.groupBoxCustData.Controls.Add(this.txtDescription);
            this.groupBoxCustData.Controls.Add(contactPersonLabel);
            this.groupBoxCustData.Controls.Add(this.txtContactPerson);
            this.groupBoxCustData.Controls.Add(webLabel);
            this.groupBoxCustData.Controls.Add(this.txtWeb);
            this.groupBoxCustData.Controls.Add(emailLabel);
            this.groupBoxCustData.Controls.Add(this.txtEmail);
            this.groupBoxCustData.Controls.Add(faxLabel);
            this.groupBoxCustData.Controls.Add(mobileLabel);
            this.groupBoxCustData.Controls.Add(teleLabel);
            this.groupBoxCustData.Controls.Add(countryLabel);
            this.groupBoxCustData.Controls.Add(this.cmbCountry);
            this.groupBoxCustData.Controls.Add(cityLabel);
            this.groupBoxCustData.Controls.Add(this.txtCity);
            this.groupBoxCustData.Controls.Add(streetLabel);
            this.groupBoxCustData.Controls.Add(this.txtStreet);
            this.groupBoxCustData.Controls.Add(addressLabel);
            this.groupBoxCustData.Controls.Add(this.txtAddress);
            this.groupBoxCustData.Controls.Add(Cust_NameLabel);
            this.groupBoxCustData.Controls.Add(this.txtCust_Name);
            this.groupBoxCustData.Controls.Add(Cust_IDLabel);
            this.groupBoxCustData.Controls.Add(this.lblCust_ID);
            this.groupBoxCustData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCustData.Location = new System.Drawing.Point(3, 62);
            this.groupBoxCustData.Name = "groupBoxCustData";
            this.groupBoxCustData.Size = new System.Drawing.Size(708, 197);
            this.groupBoxCustData.TabIndex = 1;
            this.groupBoxCustData.TabStop = false;
            // 
            // groupBoxCustVehicels
            // 
            this.groupBoxCustVehicels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCustVehicels.Controls.Add(this.dgvVehicles);
            this.groupBoxCustVehicels.Controls.Add(this.navVehicels);
            this.groupBoxCustVehicels.Location = new System.Drawing.Point(486, 38);
            this.groupBoxCustVehicels.Name = "groupBoxCustVehicels";
            this.groupBoxCustVehicels.Size = new System.Drawing.Size(219, 153);
            this.groupBoxCustVehicels.TabIndex = 13;
            this.groupBoxCustVehicels.TabStop = false;
            this.groupBoxCustVehicels.Text = "Pets";
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.AllowUserToAddRows = false;
            this.dgvVehicles.AllowUserToDeleteRows = false;
            this.dgvVehicles.AutoGenerateColumns = false;
            this.dgvVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custIDDataGridViewTextBoxColumn1,
            this.Vehicle_No,
            this.Make,
            this.Model});
            this.dgvVehicles.DataSource = this.vehiclesBindingSource;
            this.dgvVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVehicles.Location = new System.Drawing.Point(3, 41);
            this.dgvVehicles.MultiSelect = false;
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.ReadOnly = true;
            this.dgvVehicles.RowHeadersWidth = 25;
            this.dgvVehicles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVehicles.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicles.Size = new System.Drawing.Size(213, 109);
            this.dgvVehicles.StandardTab = true;
            this.dgvVehicles.TabIndex = 1;
            // 
            // custIDDataGridViewTextBoxColumn1
            // 
            this.custIDDataGridViewTextBoxColumn1.DataPropertyName = "Cust_ID";
            this.custIDDataGridViewTextBoxColumn1.HeaderText = "Cust_ID";
            this.custIDDataGridViewTextBoxColumn1.Name = "custIDDataGridViewTextBoxColumn1";
            this.custIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.custIDDataGridViewTextBoxColumn1.Visible = false;
            this.custIDDataGridViewTextBoxColumn1.Width = 70;
            // 
            // Vehicle_No
            // 
            this.Vehicle_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.Vehicle_No.DataPropertyName = "Vehicle_No";
            this.Vehicle_No.HeaderText = "Pet Name";
            this.Vehicle_No.MinimumWidth = 100;
            this.Vehicle_No.Name = "Vehicle_No";
            this.Vehicle_No.ReadOnly = true;
            this.Vehicle_No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Make
            // 
            this.Make.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Make.DataPropertyName = "Make";
            this.Make.HeaderText = "Breed";
            this.Make.MinimumWidth = 60;
            this.Make.Name = "Make";
            this.Make.ReadOnly = true;
            this.Make.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Make.Width = 60;
            // 
            // Model
            // 
            this.Model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Sex";
            this.Model.MinimumWidth = 60;
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Model.Width = 60;
            // 
            // vehiclesBindingSource
            // 
            this.vehiclesBindingSource.DataMember = "vehicles";
            this.vehiclesBindingSource.DataSource = this.senaexminidbDataSet;
            // 
            // senaexminidbDataSet
            // 
            this.senaexminidbDataSet.DataSetName = "senaexminidbDataSet";
            this.senaexminidbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // navVehicels
            // 
            this.navVehicels.AddNewItem = null;
            this.navVehicels.BindingSource = this.vehiclesBindingSource;
            this.navVehicels.CountItem = null;
            this.navVehicels.DeleteItem = this.bindingNavigatorDeleteItem;
            this.navVehicels.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtVehicelNo,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.txtMake,
            this.toolStripSeparator4,
            this.toolStripLabel3,
            this.txtModel,
            this.toolStripSeparator5,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorDeleteItem});
            this.navVehicels.Location = new System.Drawing.Point(3, 16);
            this.navVehicels.MoveFirstItem = null;
            this.navVehicels.MoveLastItem = null;
            this.navVehicels.MoveNextItem = null;
            this.navVehicels.MovePreviousItem = null;
            this.navVehicels.Name = "navVehicels";
            this.navVehicels.PositionItem = null;
            this.navVehicels.Size = new System.Drawing.Size(213, 25);
            this.navVehicels.TabIndex = 0;
            this.navVehicels.TabStop = true;
            this.navVehicels.Text = "bindingNavigator1";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(60, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(65, 22);
            this.toolStripLabel1.Text = "Pet Name: ";
            // 
            // txtVehicelNo
            // 
            this.txtVehicelNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehicelNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVehicelNo.Name = "txtVehicelNo";
            this.txtVehicelNo.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(43, 15);
            this.toolStripLabel2.Text = "Breed: ";
            // 
            // txtMake
            // 
            this.txtMake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMake.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 6);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(30, 15);
            this.toolStripLabel3.Text = "Sex: ";
            // 
            // txtModel
            // 
            this.txtModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(69, 20);
            this.bindingNavigatorAddNewItem.Text = "Add Pet";
            this.bindingNavigatorAddNewItem.ToolTipText = "Add Vehicle \r\n( Alt+A )";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.addNewVehicel_Click);
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // txtFax
            // 
            this.txtFax.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtFax.BeepOnError = true;
            this.txtFax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Fax", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtFax.Location = new System.Drawing.Point(345, 170);
            this.txtFax.Mask = "000-0000000";
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(71, 20);
            this.txtFax.TabIndex = 8;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "customers";
            this.customersBindingSource.DataSource = this.senaexminidbDataSet;
            // 
            // txtMobile
            // 
            this.txtMobile.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtMobile.BeepOnError = true;
            this.txtMobile.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Mobile", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtMobile.Location = new System.Drawing.Point(235, 170);
            this.txtMobile.Mask = "000-0000000";
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(71, 20);
            this.txtMobile.TabIndex = 7;
            // 
            // txtTelephone
            // 
            this.txtTelephone.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtTelephone.BeepOnError = true;
            this.txtTelephone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Tele", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtTelephone.Location = new System.Drawing.Point(121, 170);
            this.txtTelephone.Mask = "000-0000000";
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(71, 20);
            this.txtTelephone.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtDescription.Location = new System.Drawing.Point(309, 116);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(170, 49);
            this.txtDescription.TabIndex = 12;
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtContactPerson.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContactPerson.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ContactPerson", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtContactPerson.Location = new System.Drawing.Point(309, 90);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(170, 20);
            this.txtContactPerson.TabIndex = 11;
            // 
            // txtWeb
            // 
            this.txtWeb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Web", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtWeb.Location = new System.Drawing.Point(309, 64);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(170, 20);
            this.txtWeb.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Email", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtEmail.Location = new System.Drawing.Point(309, 38);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(170, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // cmbCountry
            // 
            this.cmbCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCountry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Country", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Items.AddRange(new object[] {
            "ARUBA",
            "AFGHANISTAN",
            "ANGOLA",
            "ANGUILLA",
            "ALBANIA",
            "ANDORRA",
            "NETHERLANDS ANTILLES",
            "UNITED ARAB EMIRATES",
            "ARGENTINA",
            "ARMENIA",
            "AMERICAN SAMOA",
            "ANTARCTICA",
            "FRENCH SOUTHERN TERRITORIES",
            "ANTIGUA AND BARBUDA",
            "AUSTRALIA",
            "AUSTRIA",
            "AZERBAIJAN",
            "BURUNDI",
            "BELGIUM",
            "BENIN",
            "BURKINA FASO",
            "BANGLADESH",
            "BULGARIA",
            "BAHRAIN",
            "BAHAMAS",
            "BOSNIA AND HERZEGOVINA",
            "BELARUS",
            "BELIZE",
            "BERMUDA",
            "BOLIVIA",
            "BRAZIL",
            "BARBADOS",
            "BRUNEI",
            "BHUTAN",
            "BOUVET ISLAND",
            "BOTSWANA",
            "CENTRAL AFRICAN REPUBLIC",
            "CANADA",
            "COCOS (KEELING) ISLANDS",
            "SWITZERLAND",
            "CHILE",
            "CHINA",
            "CÃ´TE DÂ’IVOIRE",
            "CAMEROON",
            "CONGO, THE DEMOCRATIC REPUBLIC OF THE",
            "CONGO",
            "COOK ISLANDS",
            "COLOMBIA",
            "COMOROS",
            "CAPE VERDE",
            "COSTA RICA",
            "CUBA",
            "CHRISTMAS ISLAND",
            "CAYMAN ISLANDS",
            "CYPRUS",
            "CZECH REPUBLIC",
            "GERMANY",
            "DJIBOUTI",
            "DOMINICA",
            "DENMARK",
            "DOMINICAN REPUBLIC",
            "ALGERIA",
            "ECUADOR",
            "EGYPT",
            "ERITREA",
            "WESTERN SAHARA",
            "SPAIN",
            "ESTONIA",
            "ETHIOPIA",
            "FINLAND",
            "FIJI ISLANDS",
            "FALKLAND ISLANDS",
            "FRANCE",
            "FAROE ISLANDS",
            "MICRONESIA, FEDERATED STATES OF",
            "GABON",
            "UNITED KINGDOM",
            "GEORGIA",
            "GHANA",
            "GIBRALTAR",
            "GUINEA",
            "GUADELOUPE",
            "GAMBIA",
            "GUINEA-BISSAU",
            "EQUATORIAL GUINEA",
            "GREECE",
            "GRENADA",
            "GREENLAND",
            "GUATEMALA",
            "FRENCH GUIANA",
            "GUAM",
            "GUYANA",
            "HONG KONG",
            "HEARD ISLAND AND MCDONALD ISLANDS",
            "HONDURAS",
            "CROATIA",
            "HAITI",
            "HUNGARY",
            "INDONESIA",
            "INDIA",
            "BRITISH INDIAN OCEAN TERRITORY",
            "IRELAND",
            "IRAN",
            "IRAQ",
            "ICELAND",
            "ISRAEL",
            "ITALY",
            "JAMAICA",
            "JORDAN",
            "JAPAN",
            "KAZAKSTAN",
            "KENYA",
            "KYRGYZSTAN",
            "CAMBODIA",
            "KIRIBATI",
            "SAINT KITTS AND NEVIS",
            "SOUTH KOREA",
            "KUWAIT",
            "LAOS",
            "LEBANON",
            "LIBERIA",
            "LIBYAN ARAB JAMAHIRIYA",
            "SAINT LUCIA",
            "LIECHTENSTEIN",
            "SRI LANKA",
            "LESOTHO",
            "LITHUANIA",
            "LUXEMBOURG",
            "LATVIA",
            "MACAO",
            "MOROCCO",
            "MONACO",
            "MOLDOVA",
            "MADAGASCAR",
            "MALDIVES",
            "MEXICO",
            "MARSHALL ISLANDS",
            "MACEDONIA",
            "MALI",
            "MALTA",
            "MYANMAR",
            "MONGOLIA",
            "NORTHERN MARIANA ISLANDS",
            "MOZAMBIQUE",
            "MAURITANIA",
            "MONTSERRAT",
            "MARTINIQUE",
            "MAURITIUS",
            "MALAWI",
            "MALAYSIA",
            "MAYOTTE",
            "NAMIBIA",
            "NEW CALEDONIA",
            "NIGER",
            "NORFOLK ISLAND",
            "NIGERIA",
            "NICARAGUA",
            "NIUE",
            "NETHERLANDS",
            "NORWAY",
            "NEPAL",
            "NAURU",
            "NEW ZEALAND",
            "OMAN",
            "PAKISTAN",
            "PANAMA",
            "PITCAIRN",
            "PERU",
            "PHILIPPINES",
            "PALAU",
            "PAPUA NEW GUINEA",
            "POLAND",
            "PUERTO RICO",
            "NORTH KOREA",
            "PORTUGAL",
            "PARAGUAY",
            "PALESTINE",
            "FRENCH POLYNESIA",
            "QATAR",
            "RÃ©UNION",
            "ROMANIA",
            "RUSSIAN FEDERATION",
            "RWANDA",
            "SAUDI ARABIA",
            "SUDAN",
            "SENEGAL",
            "SINGAPORE",
            "SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS",
            "SAINT HELENA",
            "SVALBARD AND JAN MAYEN",
            "SOLOMON ISLANDS",
            "SIERRA LEONE",
            "EL SALVADOR",
            "SAN MARINO",
            "SOMALIA",
            "SAINT PIERRE AND MIQUELON",
            "SAO TOME AND PRINCIPE",
            "SURINAME",
            "SLOVAKIA",
            "SLOVENIA",
            "SWEDEN",
            "SWAZILAND",
            "SEYCHELLES",
            "SYRIA",
            "TURKS AND CAICOS ISLANDS",
            "CHAD",
            "TOGO",
            "THAILAND",
            "TAJIKISTAN",
            "TOKELAU",
            "TURKMENISTAN",
            "EAST TIMOR",
            "TONGA",
            "TRINIDAD AND TOBAGO",
            "TUNISIA",
            "TURKEY",
            "TUVALU",
            "TAIWAN",
            "TANZANIA",
            "UGANDA",
            "UKRAINE",
            "UNITED STATES MINOR OUTLYING ISLANDS",
            "URUGUAY",
            "UNITED STATES",
            "UZBEKISTAN",
            "HOLY SEE (VATICAN CITY STATE)",
            "SAINT VINCENT AND THE GRENADINES",
            "VENEZUELA",
            "VIRGIN ISLANDS, BRITISH",
            "VIRGIN ISLANDS, U.S.",
            "VIETNAM",
            "VANUATU",
            "WALLIS AND FUTUNA",
            "SAMOA",
            "YEMEN",
            "YUGOSLAVIA",
            "SOUTH AFRICA",
            "ZAMBIA",
            "ZIMBABWE"});
            this.cmbCountry.Location = new System.Drawing.Point(77, 143);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(154, 21);
            this.cmbCountry.TabIndex = 5;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "City", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtCity.Location = new System.Drawing.Point(77, 117);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(154, 20);
            this.txtCity.TabIndex = 4;
            // 
            // txtStreet
            // 
            this.txtStreet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStreet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Street", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtStreet.Location = new System.Drawing.Point(77, 91);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(154, 20);
            this.txtStreet.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Address", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtAddress.Location = new System.Drawing.Point(77, 65);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(154, 20);
            this.txtAddress.TabIndex = 2;
            // 
            // txtCust_Name
            // 
            this.txtCust_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCust_Name.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtCust_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCust_Name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Customer_Name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtCust_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCust_Name.Location = new System.Drawing.Point(77, 12);
            this.txtCust_Name.Name = "txtCust_Name";
            this.txtCust_Name.Size = new System.Drawing.Size(628, 20);
            this.txtCust_Name.TabIndex = 1;
            // 
            // lblCust_ID
            // 
            this.lblCust_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCust_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCust_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Cust_ID", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.lblCust_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.lblCust_ID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCust_ID.Location = new System.Drawing.Point(77, 38);
            this.lblCust_ID.Name = "lblCust_ID";
            this.lblCust_ID.Size = new System.Drawing.Size(154, 20);
            this.lblCust_ID.TabIndex = 0;
            // 
            // groupBoxCustButtons
            // 
            this.groupBoxCustButtons.Controls.Add(this.btnPrint);
            this.groupBoxCustButtons.Controls.Add(this.btnDelete);
            this.groupBoxCustButtons.Controls.Add(this.btnUpdate);
            this.groupBoxCustButtons.Controls.Add(this.btnAddNew);
            this.groupBoxCustButtons.Controls.Add(this.btnReset);
            this.groupBoxCustButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxCustButtons.Location = new System.Drawing.Point(3, 259);
            this.groupBoxCustButtons.Name = "groupBoxCustButtons";
            this.groupBoxCustButtons.Size = new System.Drawing.Size(708, 54);
            this.groupBoxCustButtons.TabIndex = 2;
            this.groupBoxCustButtons.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = global::SenaExSIMSMiniEdition.Properties.Resources.Print;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(410, 13);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(95, 33);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipSKey.SetToolTip(this.btnPrint, "Ctrl+P");
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::SenaExSIMSMiniEdition.Properties.Resources.Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(309, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 33);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipSKey.SetToolTip(this.btnDelete, "Ctrl+D");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::SenaExSIMSMiniEdition.Properties.Resources.Edit;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(208, 13);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 33);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipSKey.SetToolTip(this.btnUpdate, "Ctrl+U");
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Image = global::SenaExSIMSMiniEdition.Properties.Resources.AddNew;
            this.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.Location = new System.Drawing.Point(107, 13);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(95, 33);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipSKey.SetToolTip(this.btnAddNew, "Ctrl+N");
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(6, 13);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 33);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipSKey.SetToolTip(this.btnReset, "Ctrl+R");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblCustNameHeader
            // 
            this.lblCustNameHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustNameHeader.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Customer_Name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.lblCustNameHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCustNameHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCustNameHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustNameHeader.ForeColor = System.Drawing.Color.White;
            this.lblCustNameHeader.Location = new System.Drawing.Point(3, 39);
            this.lblCustNameHeader.Name = "lblCustNameHeader";
            this.lblCustNameHeader.Size = new System.Drawing.Size(708, 23);
            this.lblCustNameHeader.TabIndex = 0;
            this.lblCustNameHeader.Text = "Selected Customer\'s Name";
            this.lblCustNameHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustIDHeader
            // 
            this.lblCustIDHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustIDHeader.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Cust_ID", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.lblCustIDHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCustIDHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCustIDHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustIDHeader.ForeColor = System.Drawing.Color.White;
            this.lblCustIDHeader.Location = new System.Drawing.Point(3, 16);
            this.lblCustIDHeader.Name = "lblCustIDHeader";
            this.lblCustIDHeader.Size = new System.Drawing.Size(708, 23);
            this.lblCustIDHeader.TabIndex = 0;
            this.lblCustIDHeader.Text = "Selected Customer ID";
            this.lblCustIDHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCustIDHeader.TextChanged += new System.EventHandler(this.LoadVehicles);
            // 
            // groupBoxSupList
            // 
            this.groupBoxSupList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxSupList.Controls.Add(this.txtSearch);
            this.groupBoxSupList.Controls.Add(this.dgvCustomers);
            this.groupBoxSupList.Controls.Add(this.bindingNavigatorCUST);
            this.groupBoxSupList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSupList.Location = new System.Drawing.Point(5, 5);
            this.groupBoxSupList.Name = "groupBoxSupList";
            this.groupBoxSupList.Size = new System.Drawing.Size(714, 161);
            this.groupBoxSupList.TabIndex = 1;
            this.groupBoxSupList.TabStop = false;
            this.groupBoxSupList.Text = "Customers List";
            // 
            // txtSearch
            // 
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Location = new System.Drawing.Point(7, 17);
            this.txtSearch.MinimumSize = new System.Drawing.Size(198, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceHolderText = "Type Cust ID| Name| City| Cont.Person ";
            this.txtSearch.ResetButtonBackColor = System.Drawing.Color.Salmon;
            this.txtSearch.SearchButtonBackColor = System.Drawing.Color.DodgerBlue;
            this.txtSearch.SearchText = "";
            this.txtSearch.Size = new System.Drawing.Size(306, 24);
            this.txtSearch.TabIndex = 1;
            this.toolTipSKey.SetToolTip(this.txtSearch, "Ctrl+S");
            this.txtSearch.searchTextbox_TextChanged += new System.EventHandler(this.SearchCust);
            this.txtSearch.searchButton_Click += new System.EventHandler(this.SearchCust);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomers.AutoGenerateColumns = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custAIDataGridViewTextBoxColumn,
            this.custIDDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.teleDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.faxDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.webDataGridViewTextBoxColumn,
            this.contactPersonDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dgvCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvCustomers.DataSource = this.customersBindingSource;
            this.dgvCustomers.Location = new System.Drawing.Point(6, 45);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersWidth = 25;
            this.dgvCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(702, 110);
            this.dgvCustomers.StandardTab = true;
            this.dgvCustomers.TabIndex = 3;
            // 
            // custAIDataGridViewTextBoxColumn
            // 
            this.custAIDataGridViewTextBoxColumn.DataPropertyName = "Cust_AI";
            this.custAIDataGridViewTextBoxColumn.Frozen = true;
            this.custAIDataGridViewTextBoxColumn.HeaderText = "Cust_AI";
            this.custAIDataGridViewTextBoxColumn.Name = "custAIDataGridViewTextBoxColumn";
            this.custAIDataGridViewTextBoxColumn.ReadOnly = true;
            this.custAIDataGridViewTextBoxColumn.Visible = false;
            this.custAIDataGridViewTextBoxColumn.Width = 69;
            // 
            // custIDDataGridViewTextBoxColumn
            // 
            this.custIDDataGridViewTextBoxColumn.DataPropertyName = "Cust_ID";
            this.custIDDataGridViewTextBoxColumn.Frozen = true;
            this.custIDDataGridViewTextBoxColumn.HeaderText = "Customer ID";
            this.custIDDataGridViewTextBoxColumn.Name = "custIDDataGridViewTextBoxColumn";
            this.custIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.custIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "Customer_Name";
            this.customerNameDataGridViewTextBoxColumn.Frozen = true;
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer\'s Name";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNameDataGridViewTextBoxColumn.Width = 114;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 70;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.ReadOnly = true;
            this.streetDataGridViewTextBoxColumn.Width = 60;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn.Width = 49;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            this.countryDataGridViewTextBoxColumn.Width = 68;
            // 
            // teleDataGridViewTextBoxColumn
            // 
            this.teleDataGridViewTextBoxColumn.DataPropertyName = "Tele";
            this.teleDataGridViewTextBoxColumn.HeaderText = "Tele";
            this.teleDataGridViewTextBoxColumn.Name = "teleDataGridViewTextBoxColumn";
            this.teleDataGridViewTextBoxColumn.ReadOnly = true;
            this.teleDataGridViewTextBoxColumn.Width = 53;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            this.mobileDataGridViewTextBoxColumn.Width = 63;
            // 
            // faxDataGridViewTextBoxColumn
            // 
            this.faxDataGridViewTextBoxColumn.DataPropertyName = "Fax";
            this.faxDataGridViewTextBoxColumn.HeaderText = "Fax";
            this.faxDataGridViewTextBoxColumn.Name = "faxDataGridViewTextBoxColumn";
            this.faxDataGridViewTextBoxColumn.ReadOnly = true;
            this.faxDataGridViewTextBoxColumn.Width = 49;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 57;
            // 
            // webDataGridViewTextBoxColumn
            // 
            this.webDataGridViewTextBoxColumn.DataPropertyName = "Web";
            this.webDataGridViewTextBoxColumn.HeaderText = "Web";
            this.webDataGridViewTextBoxColumn.Name = "webDataGridViewTextBoxColumn";
            this.webDataGridViewTextBoxColumn.ReadOnly = true;
            this.webDataGridViewTextBoxColumn.Width = 55;
            // 
            // contactPersonDataGridViewTextBoxColumn
            // 
            this.contactPersonDataGridViewTextBoxColumn.DataPropertyName = "ContactPerson";
            this.contactPersonDataGridViewTextBoxColumn.HeaderText = "ContactPerson";
            this.contactPersonDataGridViewTextBoxColumn.Name = "contactPersonDataGridViewTextBoxColumn";
            this.contactPersonDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactPersonDataGridViewTextBoxColumn.Width = 102;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 85;
            // 
            // bindingNavigatorCUST
            // 
            this.bindingNavigatorCUST.AddNewItem = null;
            this.bindingNavigatorCUST.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bindingNavigatorCUST.AutoSize = false;
            this.bindingNavigatorCUST.BackColor = System.Drawing.Color.Transparent;
            this.bindingNavigatorCUST.BindingSource = this.customersBindingSource;
            this.bindingNavigatorCUST.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorCUST.DeleteItem = null;
            this.bindingNavigatorCUST.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigatorCUST.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigatorCUST.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator2,
            this.lblTotalCust,
            this.toolStripSeparator1,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.toolStripSeparator3});
            this.bindingNavigatorCUST.Location = new System.Drawing.Point(316, 18);
            this.bindingNavigatorCUST.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorCUST.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorCUST.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorCUST.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorCUST.Name = "bindingNavigatorCUST";
            this.bindingNavigatorCUST.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorCUST.Size = new System.Drawing.Size(392, 23);
            this.bindingNavigatorCUST.TabIndex = 2;
            this.bindingNavigatorCUST.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // lblTotalCust
            // 
            this.lblTotalCust.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalCust.Name = "lblTotalCust";
            this.lblTotalCust.Size = new System.Drawing.Size(113, 20);
            this.lblTotalCust.Text = "Total Customers : 0";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 23);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxSupList);
            this.panel1.Controls.Add(this.groupBoxCustDetails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(724, 487);
            this.panel1.TabIndex = 5;
            // 
            // menuStripMain_ShctKey
            // 
            this.menuStripMain_ShctKey.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripMain_ShctKey.Location = new System.Drawing.Point(0, 34);
            this.menuStripMain_ShctKey.Name = "menuStripMain_ShctKey";
            this.menuStripMain_ShctKey.Size = new System.Drawing.Size(724, 24);
            this.menuStripMain_ShctKey.TabIndex = 6;
            this.menuStripMain_ShctKey.Text = "menuStripMain";
            this.menuStripMain_ShctKey.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSK_Reset,
            this.mnuSK_Add,
            this.mnuSK_Update,
            this.mnuSK_Delete,
            this.mnuSK_Print,
            this.mnuSK_Search,
            this.addVehicelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Visible = false;
            // 
            // mnuSK_Reset
            // 
            this.mnuSK_Reset.CheckOnClick = true;
            this.mnuSK_Reset.Name = "mnuSK_Reset";
            this.mnuSK_Reset.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnuSK_Reset.Size = new System.Drawing.Size(175, 22);
            this.mnuSK_Reset.Text = "Reset";
            this.mnuSK_Reset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // mnuSK_Add
            // 
            this.mnuSK_Add.CheckOnClick = true;
            this.mnuSK_Add.Name = "mnuSK_Add";
            this.mnuSK_Add.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuSK_Add.Size = new System.Drawing.Size(175, 22);
            this.mnuSK_Add.Text = "Add New";
            this.mnuSK_Add.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // mnuSK_Update
            // 
            this.mnuSK_Update.Name = "mnuSK_Update";
            this.mnuSK_Update.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.mnuSK_Update.Size = new System.Drawing.Size(175, 22);
            this.mnuSK_Update.Text = "Update";
            this.mnuSK_Update.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // mnuSK_Delete
            // 
            this.mnuSK_Delete.Name = "mnuSK_Delete";
            this.mnuSK_Delete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuSK_Delete.Size = new System.Drawing.Size(175, 22);
            this.mnuSK_Delete.Text = "Delete";
            this.mnuSK_Delete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // mnuSK_Print
            // 
            this.mnuSK_Print.Name = "mnuSK_Print";
            this.mnuSK_Print.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnuSK_Print.Size = new System.Drawing.Size(175, 22);
            this.mnuSK_Print.Text = "Print";
            this.mnuSK_Print.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // mnuSK_Search
            // 
            this.mnuSK_Search.Name = "mnuSK_Search";
            this.mnuSK_Search.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSK_Search.Size = new System.Drawing.Size(175, 22);
            this.mnuSK_Search.Text = "Search";
            this.mnuSK_Search.Click += new System.EventHandler(this.mnuSK_Search_Click);
            // 
            // addVehicelToolStripMenuItem
            // 
            this.addVehicelToolStripMenuItem.Name = "addVehicelToolStripMenuItem";
            this.addVehicelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.addVehicelToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.addVehicelToolStripMenuItem.Text = "Add Vehicle";
            this.addVehicelToolStripMenuItem.Click += new System.EventHandler(this.addNewVehicel_Click);
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
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
            // vehiclesTableAdapter
            // 
            this.vehiclesTableAdapter.ClearBeforeFill = true;
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 521);
            this.Controls.Add(this.menuStripMain_ShctKey);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBanner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "CustomersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            this.groupBoxCustDetails.ResumeLayout(false);
            this.groupBoxCustData.ResumeLayout(false);
            this.groupBoxCustData.PerformLayout();
            this.groupBoxCustVehicels.ResumeLayout(false);
            this.groupBoxCustVehicels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senaexminidbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navVehicels)).EndInit();
            this.navVehicels.ResumeLayout(false);
            this.navVehicels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.groupBoxCustButtons.ResumeLayout(false);
            this.groupBoxSupList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorCUST)).EndInit();
            this.bindingNavigatorCUST.ResumeLayout(false);
            this.bindingNavigatorCUST.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.menuStripMain_ShctKey.ResumeLayout(false);
            this.menuStripMain_ShctKey.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.GroupBox groupBoxCustDetails;
        private System.Windows.Forms.GroupBox groupBoxCustData;
        private System.Windows.Forms.MaskedTextBox txtFax;
        private System.Windows.Forms.MaskedTextBox txtMobile;
        private System.Windows.Forms.MaskedTextBox txtTelephone;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCust_Name;
        private System.Windows.Forms.Label lblCust_ID;
        private System.Windows.Forms.GroupBox groupBoxCustButtons;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblCustIDHeader;
        private System.Windows.Forms.GroupBox groupBoxSupList;
        private Util.searchBoxUC txtSearch;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.BindingNavigator bindingNavigatorCUST;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel lblTotalCust;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private senaexminidbDataSet senaexminidbDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private senaexminidbDataSetTableAdapters.customersTableAdapter customersTableAdapter;
        private senaexminidbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.DataGridViewTextBoxColumn custAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn webDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBoxCustVehicels;
        private System.Windows.Forms.BindingNavigator navVehicels;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.Label lblCustNameHeader;
        private System.Windows.Forms.BindingSource vehiclesBindingSource;
        private senaexminidbDataSetTableAdapters.vehiclesTableAdapter vehiclesTableAdapter;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtVehicelNo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txtMake;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox txtModel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.MenuStrip menuStripMain_ShctKey;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSK_Reset;
        private System.Windows.Forms.ToolStripMenuItem mnuSK_Add;
        private System.Windows.Forms.ToolStripMenuItem mnuSK_Update;
        private System.Windows.Forms.ToolStripMenuItem mnuSK_Delete;
        private System.Windows.Forms.ToolStripMenuItem mnuSK_Print;
        private System.Windows.Forms.ToolStripMenuItem mnuSK_Search;
        private System.Windows.Forms.ToolTip toolTipSKey;
        private System.Windows.Forms.ToolStripMenuItem addVehicelToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehicle_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Make;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
    }
}