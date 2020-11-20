namespace SenaExSIMSMiniEdition.Suppliers
{
    partial class SuppliersForm
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
            System.Windows.Forms.Label sup_IDLabel;
            System.Windows.Forms.Label sup_NameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label teleLabel;
            System.Windows.Forms.Label mobileLabel;
            System.Windows.Forms.Label faxLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label webLabel;
            System.Windows.Forms.Label contactPersonLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppliersForm));
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBoxSupDetails = new System.Windows.Forms.GroupBox();
            this.groupBoxsupData = new System.Windows.Forms.GroupBox();
            this.txtFax = new System.Windows.Forms.MaskedTextBox();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.senaexminidbDataSet = new SenaExSIMSMiniEdition.senaexminidbDataSet();
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
            this.txtSup_Name = new System.Windows.Forms.TextBox();
            this.lblSup_ID = new System.Windows.Forms.Label();
            this.groupBoxSupButtons = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblSupHeader = new System.Windows.Forms.Label();
            this.lblBanner = new System.Windows.Forms.Label();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.groupBoxSupList = new System.Windows.Forms.GroupBox();
            this.txtSearch = new SenaExSIMSMiniEdition.Util.searchBoxUC();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.supAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.bindingNavigatorSUP = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblTotalSup = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.tableAdapterManager = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.TableAdapterManager();
            this.suppliersTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.suppliersTableAdapter();
            this.menuStripMain_ShctKey = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSK_Reset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSK_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSK_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSK_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSK_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSK_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipSKey = new System.Windows.Forms.ToolTip(this.components);
            sup_IDLabel = new System.Windows.Forms.Label();
            sup_NameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            teleLabel = new System.Windows.Forms.Label();
            mobileLabel = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            webLabel = new System.Windows.Forms.Label();
            contactPersonLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            this.groupBoxSupDetails.SuspendLayout();
            this.groupBoxsupData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senaexminidbDataSet)).BeginInit();
            this.groupBoxSupButtons.SuspendLayout();
            this.groupBoxSupList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorSUP)).BeginInit();
            this.bindingNavigatorSUP.SuspendLayout();
            this.menuStripMain_ShctKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // sup_IDLabel
            // 
            sup_IDLabel.AutoSize = true;
            sup_IDLabel.Location = new System.Drawing.Point(6, 42);
            sup_IDLabel.Name = "sup_IDLabel";
            sup_IDLabel.Size = new System.Drawing.Size(62, 13);
            sup_IDLabel.TabIndex = 0;
            sup_IDLabel.Text = "Supplier ID:";
            // 
            // sup_NameLabel
            // 
            sup_NameLabel.AutoSize = true;
            sup_NameLabel.Location = new System.Drawing.Point(6, 17);
            sup_NameLabel.Name = "sup_NameLabel";
            sup_NameLabel.Size = new System.Drawing.Size(86, 13);
            sup_NameLabel.TabIndex = 0;
            sup_NameLabel.Text = "Supplier\'s Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(6, 71);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 0;
            addressLabel.Text = "Address:";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(6, 97);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(38, 13);
            streetLabel.TabIndex = 0;
            streetLabel.Text = "Street:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(6, 123);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 0;
            cityLabel.Text = "City:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(6, 149);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(46, 13);
            countryLabel.TabIndex = 0;
            countryLabel.Text = "Country:";
            // 
            // teleLabel
            // 
            teleLabel.AutoSize = true;
            teleLabel.Location = new System.Drawing.Point(229, 44);
            teleLabel.Name = "teleLabel";
            teleLabel.Size = new System.Drawing.Size(31, 13);
            teleLabel.TabIndex = 0;
            teleLabel.Text = "Tele:";
            // 
            // mobileLabel
            // 
            mobileLabel.AutoSize = true;
            mobileLabel.Location = new System.Drawing.Point(229, 70);
            mobileLabel.Name = "mobileLabel";
            mobileLabel.Size = new System.Drawing.Size(31, 13);
            mobileLabel.TabIndex = 0;
            mobileLabel.Text = "Mob:";
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(229, 96);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(27, 13);
            faxLabel.TabIndex = 0;
            faxLabel.Text = "Fax:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(343, 44);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Email:";
            // 
            // webLabel
            // 
            webLabel.AutoSize = true;
            webLabel.Location = new System.Drawing.Point(343, 70);
            webLabel.Name = "webLabel";
            webLabel.Size = new System.Drawing.Size(33, 13);
            webLabel.TabIndex = 0;
            webLabel.Text = "Web:";
            // 
            // contactPersonLabel
            // 
            contactPersonLabel.AutoSize = true;
            contactPersonLabel.Location = new System.Drawing.Point(263, 123);
            contactPersonLabel.Name = "contactPersonLabel";
            contactPersonLabel.Size = new System.Drawing.Size(83, 13);
            contactPersonLabel.TabIndex = 0;
            contactPersonLabel.Text = "Contact Person:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(263, 149);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // groupBoxSupDetails
            // 
            this.groupBoxSupDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSupDetails.Controls.Add(this.groupBoxsupData);
            this.groupBoxSupDetails.Controls.Add(this.groupBoxSupButtons);
            this.groupBoxSupDetails.Controls.Add(this.lblSupHeader);
            this.groupBoxSupDetails.Location = new System.Drawing.Point(5, 335);
            this.groupBoxSupDetails.Name = "groupBoxSupDetails";
            this.groupBoxSupDetails.Size = new System.Drawing.Size(633, 241);
            this.groupBoxSupDetails.TabIndex = 2;
            this.groupBoxSupDetails.TabStop = false;
            this.groupBoxSupDetails.Text = "Supplier\'s Details";
            // 
            // groupBoxsupData
            // 
            this.groupBoxsupData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxsupData.Controls.Add(this.txtFax);
            this.groupBoxsupData.Controls.Add(this.txtMobile);
            this.groupBoxsupData.Controls.Add(this.txtTelephone);
            this.groupBoxsupData.Controls.Add(descriptionLabel);
            this.groupBoxsupData.Controls.Add(this.txtDescription);
            this.groupBoxsupData.Controls.Add(contactPersonLabel);
            this.groupBoxsupData.Controls.Add(this.txtContactPerson);
            this.groupBoxsupData.Controls.Add(webLabel);
            this.groupBoxsupData.Controls.Add(this.txtWeb);
            this.groupBoxsupData.Controls.Add(emailLabel);
            this.groupBoxsupData.Controls.Add(this.txtEmail);
            this.groupBoxsupData.Controls.Add(faxLabel);
            this.groupBoxsupData.Controls.Add(mobileLabel);
            this.groupBoxsupData.Controls.Add(teleLabel);
            this.groupBoxsupData.Controls.Add(countryLabel);
            this.groupBoxsupData.Controls.Add(this.cmbCountry);
            this.groupBoxsupData.Controls.Add(cityLabel);
            this.groupBoxsupData.Controls.Add(this.txtCity);
            this.groupBoxsupData.Controls.Add(streetLabel);
            this.groupBoxsupData.Controls.Add(this.txtStreet);
            this.groupBoxsupData.Controls.Add(addressLabel);
            this.groupBoxsupData.Controls.Add(this.txtAddress);
            this.groupBoxsupData.Controls.Add(sup_NameLabel);
            this.groupBoxsupData.Controls.Add(this.txtSup_Name);
            this.groupBoxsupData.Controls.Add(sup_IDLabel);
            this.groupBoxsupData.Controls.Add(this.lblSup_ID);
            this.groupBoxsupData.Location = new System.Drawing.Point(120, 42);
            this.groupBoxsupData.Name = "groupBoxsupData";
            this.groupBoxsupData.Size = new System.Drawing.Size(507, 193);
            this.groupBoxsupData.TabIndex = 2;
            this.groupBoxsupData.TabStop = false;
            // 
            // txtFax
            // 
            this.txtFax.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtFax.BeepOnError = true;
            this.txtFax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Fax", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtFax.Location = new System.Drawing.Point(266, 93);
            this.txtFax.Mask = "000-0000000";
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(71, 20);
            this.txtFax.TabIndex = 8;
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
            // txtMobile
            // 
            this.txtMobile.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtMobile.BeepOnError = true;
            this.txtMobile.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Mobile", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtMobile.Location = new System.Drawing.Point(266, 67);
            this.txtMobile.Mask = "000-0000000";
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(71, 20);
            this.txtMobile.TabIndex = 7;
            // 
            // txtTelephone
            // 
            this.txtTelephone.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtTelephone.BeepOnError = true;
            this.txtTelephone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Tele", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtTelephone.Location = new System.Drawing.Point(266, 41);
            this.txtTelephone.Mask = "000-0000000";
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(71, 20);
            this.txtTelephone.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtDescription.Location = new System.Drawing.Point(346, 146);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(155, 33);
            this.txtDescription.TabIndex = 12;
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContactPerson.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtContactPerson.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContactPerson.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "ContactPerson", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtContactPerson.Location = new System.Drawing.Point(346, 120);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(155, 20);
            this.txtContactPerson.TabIndex = 11;
            // 
            // txtWeb
            // 
            this.txtWeb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWeb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Web", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtWeb.Location = new System.Drawing.Point(384, 67);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(117, 20);
            this.txtWeb.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Email", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtEmail.Location = new System.Drawing.Point(384, 41);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(117, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // cmbCountry
            // 
            this.cmbCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCountry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Country", true, System.Windows.Forms.DataSourceUpdateMode.Never));
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
            this.cmbCountry.Location = new System.Drawing.Point(98, 146);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(121, 21);
            this.cmbCountry.TabIndex = 5;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "City", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtCity.Location = new System.Drawing.Point(98, 120);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(121, 20);
            this.txtCity.TabIndex = 4;
            // 
            // txtStreet
            // 
            this.txtStreet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStreet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Street", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtStreet.Location = new System.Drawing.Point(98, 94);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(121, 20);
            this.txtStreet.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Address", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtAddress.Location = new System.Drawing.Point(98, 68);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(121, 20);
            this.txtAddress.TabIndex = 2;
            // 
            // txtSup_Name
            // 
            this.txtSup_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSup_Name.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtSup_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSup_Name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Sup_Name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtSup_Name.Location = new System.Drawing.Point(98, 14);
            this.txtSup_Name.Name = "txtSup_Name";
            this.txtSup_Name.Size = new System.Drawing.Size(403, 20);
            this.txtSup_Name.TabIndex = 1;
            this.txtSup_Name.TextChanged += new System.EventHandler(this.setSelected_Sup_Header);
            // 
            // lblSup_ID
            // 
            this.lblSup_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSup_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSup_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliersBindingSource, "Sup_ID", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.lblSup_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.lblSup_ID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSup_ID.Location = new System.Drawing.Point(98, 41);
            this.lblSup_ID.Name = "lblSup_ID";
            this.lblSup_ID.Size = new System.Drawing.Size(121, 20);
            this.lblSup_ID.TabIndex = 0;
            this.lblSup_ID.TextChanged += new System.EventHandler(this.setSelected_Sup_Header);
            // 
            // groupBoxSupButtons
            // 
            this.groupBoxSupButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxSupButtons.Controls.Add(this.btnPrint);
            this.groupBoxSupButtons.Controls.Add(this.btnDelete);
            this.groupBoxSupButtons.Controls.Add(this.btnUpdate);
            this.groupBoxSupButtons.Controls.Add(this.btnAddNew);
            this.groupBoxSupButtons.Controls.Add(this.btnReset);
            this.groupBoxSupButtons.Location = new System.Drawing.Point(7, 42);
            this.groupBoxSupButtons.Name = "groupBoxSupButtons";
            this.groupBoxSupButtons.Size = new System.Drawing.Size(107, 193);
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
            this.btnDelete.Location = new System.Drawing.Point(6, 118);
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
            this.btnUpdate.Location = new System.Drawing.Point(6, 82);
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
            this.btnAddNew.Location = new System.Drawing.Point(6, 46);
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
            this.btnReset.Location = new System.Drawing.Point(6, 10);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 33);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipSKey.SetToolTip(this.btnReset, "Ctrl+R");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblSupHeader
            // 
            this.lblSupHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSupHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSupHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSupHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupHeader.ForeColor = System.Drawing.Color.White;
            this.lblSupHeader.Location = new System.Drawing.Point(3, 16);
            this.lblSupHeader.Name = "lblSupHeader";
            this.lblSupHeader.Size = new System.Drawing.Size(627, 23);
            this.lblSupHeader.TabIndex = 0;
            this.lblSupHeader.Text = "Selected Supplier\'s ID && Name";
            this.lblSupHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblBanner.Size = new System.Drawing.Size(644, 34);
            this.lblBanner.TabIndex = 0;
            this.lblBanner.Text = "Suppliers";
            this.lblBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // groupBoxSupList
            // 
            this.groupBoxSupList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSupList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxSupList.Controls.Add(this.txtSearch);
            this.groupBoxSupList.Controls.Add(this.dgvSuppliers);
            this.groupBoxSupList.Controls.Add(this.bindingNavigatorSUP);
            this.groupBoxSupList.Location = new System.Drawing.Point(5, 37);
            this.groupBoxSupList.Name = "groupBoxSupList";
            this.groupBoxSupList.Size = new System.Drawing.Size(633, 299);
            this.groupBoxSupList.TabIndex = 1;
            this.groupBoxSupList.TabStop = false;
            this.groupBoxSupList.Text = "Suppliers List";
            // 
            // txtSearch
            // 
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Location = new System.Drawing.Point(7, 17);
            this.txtSearch.MinimumSize = new System.Drawing.Size(198, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceHolderText = "Type Sup ID| Name| City| ContactPerson ";
            this.txtSearch.ResetButtonBackColor = System.Drawing.Color.Salmon;
            this.txtSearch.SearchButtonBackColor = System.Drawing.Color.DodgerBlue;
            this.txtSearch.SearchText = "";
            this.txtSearch.Size = new System.Drawing.Size(306, 24);
            this.txtSearch.TabIndex = 1;
            this.toolTipSKey.SetToolTip(this.txtSearch, "Ctrl+S (Focus search field)");
            this.txtSearch.searchTextbox_TextChanged += new System.EventHandler(this.SearchSuppliers);
            this.txtSearch.searchButton_Click += new System.EventHandler(this.SearchSuppliers);
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSuppliers.AutoGenerateColumns = false;
            this.dgvSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supAIDataGridViewTextBoxColumn,
            this.supIDDataGridViewTextBoxColumn,
            this.supNameDataGridViewTextBoxColumn,
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
            this.dgvSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvSuppliers.DataSource = this.suppliersBindingSource;
            this.dgvSuppliers.Location = new System.Drawing.Point(6, 45);
            this.dgvSuppliers.MultiSelect = false;
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.RowHeadersWidth = 25;
            this.dgvSuppliers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.Size = new System.Drawing.Size(621, 248);
            this.dgvSuppliers.TabIndex = 3;
            // 
            // supAIDataGridViewTextBoxColumn
            // 
            this.supAIDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.supAIDataGridViewTextBoxColumn.DataPropertyName = "Sup_AI";
            this.supAIDataGridViewTextBoxColumn.Frozen = true;
            this.supAIDataGridViewTextBoxColumn.HeaderText = "#";
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
            this.supIDDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.supIDDataGridViewTextBoxColumn.Name = "supIDDataGridViewTextBoxColumn";
            this.supIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.supIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.supIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // supNameDataGridViewTextBoxColumn
            // 
            this.supNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.supNameDataGridViewTextBoxColumn.DataPropertyName = "Sup_Name";
            this.supNameDataGridViewTextBoxColumn.Frozen = true;
            this.supNameDataGridViewTextBoxColumn.HeaderText = "Supplier\'s Name";
            this.supNameDataGridViewTextBoxColumn.MinimumWidth = 175;
            this.supNameDataGridViewTextBoxColumn.Name = "supNameDataGridViewTextBoxColumn";
            this.supNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.supNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.supNameDataGridViewTextBoxColumn.Width = 175;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.ReadOnly = true;
            this.streetDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.streetDataGridViewTextBoxColumn.Width = 80;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cityDataGridViewTextBoxColumn.Width = 80;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            this.countryDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.countryDataGridViewTextBoxColumn.Width = 80;
            // 
            // teleDataGridViewTextBoxColumn
            // 
            this.teleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.teleDataGridViewTextBoxColumn.DataPropertyName = "Tele";
            this.teleDataGridViewTextBoxColumn.HeaderText = "Tele";
            this.teleDataGridViewTextBoxColumn.MinimumWidth = 75;
            this.teleDataGridViewTextBoxColumn.Name = "teleDataGridViewTextBoxColumn";
            this.teleDataGridViewTextBoxColumn.ReadOnly = true;
            this.teleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.teleDataGridViewTextBoxColumn.Width = 75;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.MinimumWidth = 75;
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            this.mobileDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.mobileDataGridViewTextBoxColumn.Width = 75;
            // 
            // faxDataGridViewTextBoxColumn
            // 
            this.faxDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.faxDataGridViewTextBoxColumn.DataPropertyName = "Fax";
            this.faxDataGridViewTextBoxColumn.HeaderText = "Fax";
            this.faxDataGridViewTextBoxColumn.MinimumWidth = 75;
            this.faxDataGridViewTextBoxColumn.Name = "faxDataGridViewTextBoxColumn";
            this.faxDataGridViewTextBoxColumn.ReadOnly = true;
            this.faxDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.faxDataGridViewTextBoxColumn.Width = 75;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 125;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // webDataGridViewTextBoxColumn
            // 
            this.webDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.webDataGridViewTextBoxColumn.DataPropertyName = "Web";
            this.webDataGridViewTextBoxColumn.HeaderText = "Web";
            this.webDataGridViewTextBoxColumn.MinimumWidth = 125;
            this.webDataGridViewTextBoxColumn.Name = "webDataGridViewTextBoxColumn";
            this.webDataGridViewTextBoxColumn.ReadOnly = true;
            this.webDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.webDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactPersonDataGridViewTextBoxColumn
            // 
            this.contactPersonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.contactPersonDataGridViewTextBoxColumn.DataPropertyName = "ContactPerson";
            this.contactPersonDataGridViewTextBoxColumn.HeaderText = "ContactPerson";
            this.contactPersonDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.contactPersonDataGridViewTextBoxColumn.Name = "contactPersonDataGridViewTextBoxColumn";
            this.contactPersonDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactPersonDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.contactPersonDataGridViewTextBoxColumn.Width = 150;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // bindingNavigatorSUP
            // 
            this.bindingNavigatorSUP.AddNewItem = null;
            this.bindingNavigatorSUP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bindingNavigatorSUP.AutoSize = false;
            this.bindingNavigatorSUP.BackColor = System.Drawing.Color.Transparent;
            this.bindingNavigatorSUP.BindingSource = this.suppliersBindingSource;
            this.bindingNavigatorSUP.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorSUP.DeleteItem = null;
            this.bindingNavigatorSUP.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigatorSUP.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigatorSUP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator2,
            this.lblTotalSup,
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
            this.bindingNavigatorSUP.Location = new System.Drawing.Point(316, 18);
            this.bindingNavigatorSUP.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorSUP.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorSUP.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorSUP.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorSUP.Name = "bindingNavigatorSUP";
            this.bindingNavigatorSUP.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorSUP.Size = new System.Drawing.Size(340, 23);
            this.bindingNavigatorSUP.TabIndex = 2;
            this.bindingNavigatorSUP.Text = "bindingNavigator1";
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
            // lblTotalSup
            // 
            this.lblTotalSup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalSup.Name = "lblTotalSup";
            this.lblTotalSup.Size = new System.Drawing.Size(105, 20);
            this.lblTotalSup.Text = "Total Suppliers : 0";
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriesTableAdapter = null;
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
            this.tableAdapterManager.suppliersTableAdapter = this.suppliersTableAdapter;
            this.tableAdapterManager.UpdateOrder = SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.vehiclesTableAdapter = null;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // menuStripMain_ShctKey
            // 
            this.menuStripMain_ShctKey.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripMain_ShctKey.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain_ShctKey.Name = "menuStripMain_ShctKey";
            this.menuStripMain_ShctKey.Size = new System.Drawing.Size(644, 24);
            this.menuStripMain_ShctKey.TabIndex = 0;
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
            this.mnuSK_Search});
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
            this.mnuSK_Reset.Size = new System.Drawing.Size(166, 22);
            this.mnuSK_Reset.Text = "Reset";
            this.mnuSK_Reset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // mnuSK_Add
            // 
            this.mnuSK_Add.CheckOnClick = true;
            this.mnuSK_Add.Name = "mnuSK_Add";
            this.mnuSK_Add.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuSK_Add.Size = new System.Drawing.Size(166, 22);
            this.mnuSK_Add.Text = "Add New";
            this.mnuSK_Add.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // mnuSK_Update
            // 
            this.mnuSK_Update.Name = "mnuSK_Update";
            this.mnuSK_Update.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.mnuSK_Update.Size = new System.Drawing.Size(166, 22);
            this.mnuSK_Update.Text = "Update";
            this.mnuSK_Update.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // mnuSK_Delete
            // 
            this.mnuSK_Delete.Name = "mnuSK_Delete";
            this.mnuSK_Delete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuSK_Delete.Size = new System.Drawing.Size(166, 22);
            this.mnuSK_Delete.Text = "Delete";
            this.mnuSK_Delete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // mnuSK_Print
            // 
            this.mnuSK_Print.Name = "mnuSK_Print";
            this.mnuSK_Print.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnuSK_Print.Size = new System.Drawing.Size(166, 22);
            this.mnuSK_Print.Text = "Print";
            this.mnuSK_Print.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // mnuSK_Search
            // 
            this.mnuSK_Search.Name = "mnuSK_Search";
            this.mnuSK_Search.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSK_Search.Size = new System.Drawing.Size(166, 22);
            this.mnuSK_Search.Text = "Search";
            this.mnuSK_Search.Click += new System.EventHandler(this.mnuSK_Search_Click);
            // 
            // SuppliersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 581);
            this.Controls.Add(this.groupBoxSupDetails);
            this.Controls.Add(this.lblBanner);
            this.Controls.Add(this.groupBoxSupList);
            this.Controls.Add(this.menuStripMain_ShctKey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 550);
            this.Name = "SuppliersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suppliers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SuppliersForm_Load);
            this.groupBoxSupDetails.ResumeLayout(false);
            this.groupBoxsupData.ResumeLayout(false);
            this.groupBoxsupData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senaexminidbDataSet)).EndInit();
            this.groupBoxSupButtons.ResumeLayout(false);
            this.groupBoxSupList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorSUP)).EndInit();
            this.bindingNavigatorSUP.ResumeLayout(false);
            this.bindingNavigatorSUP.PerformLayout();
            this.menuStripMain_ShctKey.ResumeLayout(false);
            this.menuStripMain_ShctKey.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox groupBoxSupDetails;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private senaexminidbDataSet senaexminidbDataSet;
        private System.Windows.Forms.Label lblSupHeader;
        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private senaexminidbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private senaexminidbDataSetTableAdapters.suppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.GroupBox groupBoxSupList;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.BindingNavigator bindingNavigatorSUP;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel lblTotalSup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private Util.searchBoxUC txtSearch;
        private System.Windows.Forms.GroupBox groupBoxSupButtons;
        private System.Windows.Forms.GroupBox groupBoxsupData;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblSup_ID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtTelephone;
        private System.Windows.Forms.MaskedTextBox txtFax;
        private System.Windows.Forms.MaskedTextBox txtMobile;
        private System.Windows.Forms.TextBox txtSup_Name;
        private System.Windows.Forms.MenuStrip menuStripMain_ShctKey;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSK_Reset;
        private System.Windows.Forms.ToolStripMenuItem mnuSK_Add;
        private System.Windows.Forms.ToolStripMenuItem mnuSK_Update;
        private System.Windows.Forms.ToolStripMenuItem mnuSK_Delete;
        private System.Windows.Forms.ToolStripMenuItem mnuSK_Print;
        private System.Windows.Forms.ToolTip toolTipSKey;
        private System.Windows.Forms.ToolStripMenuItem mnuSK_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn supAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supNameDataGridViewTextBoxColumn;
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
    }
}