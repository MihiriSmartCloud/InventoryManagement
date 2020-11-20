namespace SenaExSIMSMiniEdition.Users
{
    partial class UsersForm
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
            System.Windows.Forms.Label roleLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label lastLoginLabel0;
            System.Windows.Forms.Label label0;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.lblBanner = new System.Windows.Forms.Label();
            this.groupBoxUserList = new System.Windows.Forms.GroupBox();
            this.tvUsers = new System.Windows.Forms.TreeView();
            this.imageListNode = new System.Windows.Forms.ImageList(this.components);
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.panelBase = new System.Windows.Forms.Panel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.groupBoxSelUser = new System.Windows.Forms.GroupBox();
            this.groupBoxSupButtons = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lastLoginLabel = new System.Windows.Forms.Label();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.senaexminidbDataSet = new SenaExSIMSMiniEdition.senaexminidbDataSet();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblSelUserNameHeader = new System.Windows.Forms.Label();
            this.lblSelRoleHeader = new System.Windows.Forms.Label();
            this.groupBoxCurUser = new System.Windows.Forms.GroupBox();
            this.lblLastLogin = new System.Windows.Forms.Label();
            this.groupBoxChangePW = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNewPW = new System.Windows.Forms.TextBox();
            this.lblCurUserNameHeader = new System.Windows.Forms.Label();
            this.lblCurRoleHeader = new System.Windows.Forms.Label();
            this.usersTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.usersTableAdapter();
            this.rolesTableAdapter = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.rolesTableAdapter();
            this.tableAdapterManager = new SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.TableAdapterManager();
            this.toolTipSKey = new System.Windows.Forms.ToolTip(this.components);
            this.menuStripMain_ShctKey = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSK_Reset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSK_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSK_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSK_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSK_SavePW = new System.Windows.Forms.ToolStripMenuItem();
            roleLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            lastLoginLabel0 = new System.Windows.Forms.Label();
            label0 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBoxUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            this.panelBase.SuspendLayout();
            this.panelColor.SuspendLayout();
            this.groupBoxSelUser.SuspendLayout();
            this.groupBoxSupButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senaexminidbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            this.groupBoxCurUser.SuspendLayout();
            this.groupBoxChangePW.SuspendLayout();
            this.menuStripMain_ShctKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Location = new System.Drawing.Point(11, 80);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new System.Drawing.Size(32, 13);
            roleLabel.TabIndex = 0;
            roleLabel.Text = "Role:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(11, 107);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(58, 13);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(11, 133);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "Password:";
            // 
            // lastLoginLabel0
            // 
            lastLoginLabel0.AutoSize = true;
            lastLoginLabel0.Location = new System.Drawing.Point(11, 156);
            lastLoginLabel0.Name = "lastLoginLabel0";
            lastLoginLabel0.Size = new System.Drawing.Size(59, 13);
            lastLoginLabel0.TabIndex = 0;
            lastLoginLabel0.Text = "Last Login:";
            // 
            // label0
            // 
            label0.AutoSize = true;
            label0.Location = new System.Drawing.Point(6, 22);
            label0.Name = "label0";
            label0.Size = new System.Drawing.Size(81, 13);
            label0.TabIndex = 0;
            label0.Text = "New Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 69);
            label1.Margin = new System.Windows.Forms.Padding(5);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 13);
            label1.TabIndex = 0;
            label1.Text = "Last Login:";
            // 
            // lblBanner
            // 
            this.lblBanner.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBanner.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.ForeColor = System.Drawing.Color.White;
            this.lblBanner.Location = new System.Drawing.Point(0, 0);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(586, 34);
            this.lblBanner.TabIndex = 0;
            this.lblBanner.Text = "Users";
            this.lblBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxUserList
            // 
            this.groupBoxUserList.Controls.Add(this.tvUsers);
            this.groupBoxUserList.Controls.Add(this.bindingNavigator);
            this.groupBoxUserList.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxUserList.Location = new System.Drawing.Point(5, 5);
            this.groupBoxUserList.Name = "groupBoxUserList";
            this.groupBoxUserList.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxUserList.Size = new System.Drawing.Size(200, 418);
            this.groupBoxUserList.TabIndex = 1;
            this.groupBoxUserList.TabStop = false;
            this.groupBoxUserList.Text = "User List";
            // 
            // tvUsers
            // 
            this.tvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvUsers.FullRowSelect = true;
            this.tvUsers.ImageIndex = 0;
            this.tvUsers.ImageList = this.imageListNode;
            this.tvUsers.Indent = 20;
            this.tvUsers.Location = new System.Drawing.Point(6, 44);
            this.tvUsers.Name = "tvUsers";
            this.tvUsers.SelectedImageIndex = 0;
            this.tvUsers.Size = new System.Drawing.Size(188, 368);
            this.tvUsers.TabIndex = 0;
            this.tvUsers.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvUsers_AfterSelect);
            // 
            // imageListNode
            // 
            this.imageListNode.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListNode.ImageStream")));
            this.imageListNode.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListNode.Images.SetKeyName(0, "Add Filled.png");
            this.imageListNode.Images.SetKeyName(1, "User-icon.png");
            this.imageListNode.Images.SetKeyName(2, "UserTick.png");
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = null;
            this.bindingNavigator.CountItem = null;
            this.bindingNavigator.DeleteItem = null;
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh});
            this.bindingNavigator.Location = new System.Drawing.Point(6, 19);
            this.bindingNavigator.MoveFirstItem = null;
            this.bindingNavigator.MoveLastItem = null;
            this.bindingNavigator.MoveNextItem = null;
            this.bindingNavigator.MovePreviousItem = null;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = null;
            this.bindingNavigator.Size = new System.Drawing.Size(188, 25);
            this.bindingNavigator.TabIndex = 1;
            this.bindingNavigator.Text = "bindingNavigator1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::SenaExSIMSMiniEdition.Properties.Resources.Refresh;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(66, 22);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.UsersForm_Load);
            // 
            // panelBase
            // 
            this.panelBase.Controls.Add(this.panelColor);
            this.panelBase.Controls.Add(this.groupBoxUserList);
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(0, 34);
            this.panelBase.Name = "panelBase";
            this.panelBase.Padding = new System.Windows.Forms.Padding(5);
            this.panelBase.Size = new System.Drawing.Size(586, 428);
            this.panelBase.TabIndex = 1;
            // 
            // panelColor
            // 
            this.panelColor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelColor.BackColor = System.Drawing.Color.SteelBlue;
            this.panelColor.Controls.Add(this.groupBoxSelUser);
            this.panelColor.Controls.Add(this.groupBoxCurUser);
            this.panelColor.Location = new System.Drawing.Point(211, 6);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(367, 417);
            this.panelColor.TabIndex = 3;
            // 
            // groupBoxSelUser
            // 
            this.groupBoxSelUser.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxSelUser.Controls.Add(this.groupBoxSupButtons);
            this.groupBoxSelUser.Controls.Add(lastLoginLabel0);
            this.groupBoxSelUser.Controls.Add(this.lastLoginLabel);
            this.groupBoxSelUser.Controls.Add(passwordLabel);
            this.groupBoxSelUser.Controls.Add(this.passwordTextBox);
            this.groupBoxSelUser.Controls.Add(usernameLabel);
            this.groupBoxSelUser.Controls.Add(this.usernameTextBox);
            this.groupBoxSelUser.Controls.Add(roleLabel);
            this.groupBoxSelUser.Controls.Add(this.roleComboBox);
            this.groupBoxSelUser.Controls.Add(this.lblSelUserNameHeader);
            this.groupBoxSelUser.Controls.Add(this.lblSelRoleHeader);
            this.groupBoxSelUser.Location = new System.Drawing.Point(0, 145);
            this.groupBoxSelUser.Name = "groupBoxSelUser";
            this.groupBoxSelUser.Size = new System.Drawing.Size(367, 241);
            this.groupBoxSelUser.TabIndex = 2;
            this.groupBoxSelUser.TabStop = false;
            this.groupBoxSelUser.Text = "Setup Another User Account";
            // 
            // groupBoxSupButtons
            // 
            this.groupBoxSupButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxSupButtons.Controls.Add(this.btnDelete);
            this.groupBoxSupButtons.Controls.Add(this.btnUpdate);
            this.groupBoxSupButtons.Controls.Add(this.btnAddNew);
            this.groupBoxSupButtons.Controls.Add(this.btnReset);
            this.groupBoxSupButtons.Location = new System.Drawing.Point(6, 185);
            this.groupBoxSupButtons.Name = "groupBoxSupButtons";
            this.groupBoxSupButtons.Size = new System.Drawing.Size(355, 50);
            this.groupBoxSupButtons.TabIndex = 4;
            this.groupBoxSupButtons.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::SenaExSIMSMiniEdition.Properties.Resources.Remove_User_Male_25;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(269, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 33);
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
            this.btnUpdate.Image = global::SenaExSIMSMiniEdition.Properties.Resources.Edit_User_Male_25;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(184, 10);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(79, 33);
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
            this.btnAddNew.Image = global::SenaExSIMSMiniEdition.Properties.Resources.Add_User_Male_25;
            this.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.Location = new System.Drawing.Point(89, 10);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(89, 33);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipSKey.SetToolTip(this.btnAddNew, "Ctrl+A");
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(4, 10);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(79, 33);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipSKey.SetToolTip(this.btnReset, "Ctrl+R");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lastLoginLabel
            // 
            this.lastLoginLabel.BackColor = System.Drawing.SystemColors.Window;
            this.lastLoginLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastLoginLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "LastLogin", true));
            this.lastLoginLabel.Location = new System.Drawing.Point(76, 156);
            this.lastLoginLabel.Margin = new System.Windows.Forms.Padding(3);
            this.lastLoginLabel.Name = "lastLoginLabel";
            this.lastLoginLabel.Size = new System.Drawing.Size(194, 23);
            this.lastLoginLabel.TabIndex = 0;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.senaexminidbDataSet;
            // 
            // senaexminidbDataSet
            // 
            this.senaexminidbDataSet.DataSetName = "senaexminidbDataSet";
            this.senaexminidbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(76, 130);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(194, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.usernameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(76, 104);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(194, 20);
            this.usernameTextBox.TabIndex = 2;
            // 
            // roleComboBox
            // 
            this.roleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rolesBindingSource, "Role", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.roleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Role", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.roleComboBox.DataSource = this.rolesBindingSource;
            this.roleComboBox.DisplayMember = "Role";
            this.roleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(76, 77);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(194, 21);
            this.roleComboBox.TabIndex = 1;
            this.roleComboBox.ValueMember = "Role";
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "roles";
            this.rolesBindingSource.DataSource = this.senaexminidbDataSet;
            // 
            // lblSelUserNameHeader
            // 
            this.lblSelUserNameHeader.BackColor = System.Drawing.Color.Gray;
            this.lblSelUserNameHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSelUserNameHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSelUserNameHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSelUserNameHeader.ForeColor = System.Drawing.Color.White;
            this.lblSelUserNameHeader.Location = new System.Drawing.Point(3, 40);
            this.lblSelUserNameHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblSelUserNameHeader.Name = "lblSelUserNameHeader";
            this.lblSelUserNameHeader.Size = new System.Drawing.Size(361, 24);
            this.lblSelUserNameHeader.TabIndex = 0;
            this.lblSelUserNameHeader.Text = "Sel Username";
            this.lblSelUserNameHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSelUserNameHeader.TextChanged += new System.EventHandler(this.lblRoleHeader_TextChanged);
            // 
            // lblSelRoleHeader
            // 
            this.lblSelRoleHeader.BackColor = System.Drawing.Color.Gray;
            this.lblSelRoleHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSelRoleHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSelRoleHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSelRoleHeader.ForeColor = System.Drawing.Color.White;
            this.lblSelRoleHeader.Location = new System.Drawing.Point(3, 16);
            this.lblSelRoleHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblSelRoleHeader.Name = "lblSelRoleHeader";
            this.lblSelRoleHeader.Size = new System.Drawing.Size(361, 24);
            this.lblSelRoleHeader.TabIndex = 0;
            this.lblSelRoleHeader.Text = "Sel Role";
            this.lblSelRoleHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSelRoleHeader.TextChanged += new System.EventHandler(this.lblRoleHeader_TextChanged);
            // 
            // groupBoxCurUser
            // 
            this.groupBoxCurUser.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxCurUser.Controls.Add(this.lblLastLogin);
            this.groupBoxCurUser.Controls.Add(label1);
            this.groupBoxCurUser.Controls.Add(this.groupBoxChangePW);
            this.groupBoxCurUser.Controls.Add(this.lblCurUserNameHeader);
            this.groupBoxCurUser.Controls.Add(this.lblCurRoleHeader);
            this.groupBoxCurUser.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCurUser.Name = "groupBoxCurUser";
            this.groupBoxCurUser.Size = new System.Drawing.Size(367, 145);
            this.groupBoxCurUser.TabIndex = 0;
            this.groupBoxCurUser.TabStop = false;
            this.groupBoxCurUser.Text = "Currently Loged User";
            // 
            // lblLastLogin
            // 
            this.lblLastLogin.AutoSize = true;
            this.lblLastLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastLogin.Location = new System.Drawing.Point(73, 69);
            this.lblLastLogin.Margin = new System.Windows.Forms.Padding(5);
            this.lblLastLogin.Name = "lblLastLogin";
            this.lblLastLogin.Size = new System.Drawing.Size(62, 13);
            this.lblLastLogin.TabIndex = 0;
            this.lblLastLogin.Text = "LastLogin";
            // 
            // groupBoxChangePW
            // 
            this.groupBoxChangePW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxChangePW.Controls.Add(this.btnSave);
            this.groupBoxChangePW.Controls.Add(label0);
            this.groupBoxChangePW.Controls.Add(this.txtNewPW);
            this.groupBoxChangePW.Location = new System.Drawing.Point(7, 90);
            this.groupBoxChangePW.Name = "groupBoxChangePW";
            this.groupBoxChangePW.Size = new System.Drawing.Size(354, 48);
            this.groupBoxChangePW.TabIndex = 1;
            this.groupBoxChangePW.TabStop = false;
            this.groupBoxChangePW.Text = "Change Your Password";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::SenaExSIMSMiniEdition.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(314, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(34, 30);
            this.btnSave.TabIndex = 2;
            this.toolTipSKey.SetToolTip(this.btnSave, "Ctrl+S");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNewPW
            // 
            this.txtNewPW.BackColor = System.Drawing.SystemColors.Window;
            this.txtNewPW.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNewPW.Location = new System.Drawing.Point(93, 19);
            this.txtNewPW.Name = "txtNewPW";
            this.txtNewPW.Size = new System.Drawing.Size(213, 20);
            this.txtNewPW.TabIndex = 1;
            // 
            // lblCurUserNameHeader
            // 
            this.lblCurUserNameHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCurUserNameHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCurUserNameHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCurUserNameHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCurUserNameHeader.ForeColor = System.Drawing.Color.White;
            this.lblCurUserNameHeader.Location = new System.Drawing.Point(3, 40);
            this.lblCurUserNameHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblCurUserNameHeader.Name = "lblCurUserNameHeader";
            this.lblCurUserNameHeader.Size = new System.Drawing.Size(361, 24);
            this.lblCurUserNameHeader.TabIndex = 0;
            this.lblCurUserNameHeader.Text = "Cur Username";
            this.lblCurUserNameHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurRoleHeader
            // 
            this.lblCurRoleHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCurRoleHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCurRoleHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCurRoleHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCurRoleHeader.ForeColor = System.Drawing.Color.White;
            this.lblCurRoleHeader.Location = new System.Drawing.Point(3, 16);
            this.lblCurRoleHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblCurRoleHeader.Name = "lblCurRoleHeader";
            this.lblCurRoleHeader.Size = new System.Drawing.Size(361, 24);
            this.lblCurRoleHeader.TabIndex = 0;
            this.lblCurRoleHeader.Text = "Cur Role";
            this.lblCurRoleHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.rolesTableAdapter = this.rolesTableAdapter;
            this.tableAdapterManager.service_typesTableAdapter = null;
            this.tableAdapterManager.suppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SenaExSIMSMiniEdition.senaexminidbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = this.usersTableAdapter;
            this.tableAdapterManager.vehiclesTableAdapter = null;
            // 
            // menuStripMain_ShctKey
            // 
            this.menuStripMain_ShctKey.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripMain_ShctKey.Location = new System.Drawing.Point(0, 34);
            this.menuStripMain_ShctKey.Name = "menuStripMain_ShctKey";
            this.menuStripMain_ShctKey.Size = new System.Drawing.Size(586, 24);
            this.menuStripMain_ShctKey.TabIndex = 2;
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
            this.mnuSK_SavePW});
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
            // mnuSK_SavePW
            // 
            this.mnuSK_SavePW.Name = "mnuSK_SavePW";
            this.mnuSK_SavePW.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSK_SavePW.Size = new System.Drawing.Size(166, 22);
            this.mnuSK_SavePW.Text = "SavePW";
            this.mnuSK_SavePW.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 462);
            this.Controls.Add(this.menuStripMain_ShctKey);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.lblBanner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.groupBoxUserList.ResumeLayout(false);
            this.groupBoxUserList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            this.panelBase.ResumeLayout(false);
            this.panelColor.ResumeLayout(false);
            this.groupBoxSelUser.ResumeLayout(false);
            this.groupBoxSelUser.PerformLayout();
            this.groupBoxSupButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senaexminidbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            this.groupBoxCurUser.ResumeLayout(false);
            this.groupBoxCurUser.PerformLayout();
            this.groupBoxChangePW.ResumeLayout(false);
            this.groupBoxChangePW.PerformLayout();
            this.menuStripMain_ShctKey.ResumeLayout(false);
            this.menuStripMain_ShctKey.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.GroupBox groupBoxUserList;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.GroupBox groupBoxSelUser;
        private System.Windows.Forms.Label lblSelUserNameHeader;
        private System.Windows.Forms.Label lblSelRoleHeader;
        private System.Windows.Forms.TreeView tvUsers;
        private senaexminidbDataSet senaexminidbDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private senaexminidbDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private senaexminidbDataSetTableAdapters.rolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ImageList imageListNode;
        private System.Windows.Forms.Label lastLoginLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.ComboBox roleComboBox;
        private senaexminidbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBoxCurUser;
        private System.Windows.Forms.TextBox txtNewPW;
        private System.Windows.Forms.Label lblCurUserNameHeader;
        private System.Windows.Forms.Label lblCurRoleHeader;
        private System.Windows.Forms.GroupBox groupBoxChangePW;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Label lblLastLogin;
        private System.Windows.Forms.GroupBox groupBoxSupButtons;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ToolTip toolTipSKey;
        private System.Windows.Forms.MenuStrip menuStripMain_ShctKey;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSK_Reset;
        private System.Windows.Forms.ToolStripMenuItem mnuSK_Add;
        private System.Windows.Forms.ToolStripMenuItem mnuSK_Update;
        private System.Windows.Forms.ToolStripMenuItem mnuSK_Delete;
        private System.Windows.Forms.ToolStripMenuItem mnuSK_SavePW;
    }
}