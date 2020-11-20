namespace SenaExSIMSMiniEdition.GRN
{
    partial class AddPaymentDialogBox
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
            System.Windows.Forms.Label payment_ModeLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label entry_DateLabel;
            System.Windows.Forms.Label paid_Due_Post_DateLabel;
            System.Windows.Forms.Label cheque_NoLabel;
            System.Windows.Forms.Label bankLabel;
            System.Windows.Forms.Label branchLabel;
            System.Windows.Forms.Label remarksLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelBank = new System.Windows.Forms.Panel();
            this.txtChequeNo = new System.Windows.Forms.TextBox();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.dtpPaidDuePostDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEntry_Date = new System.Windows.Forms.DateTimePicker();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.cmbPaymentMode = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            payment_ModeLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            entry_DateLabel = new System.Windows.Forms.Label();
            paid_Due_Post_DateLabel = new System.Windows.Forms.Label();
            cheque_NoLabel = new System.Windows.Forms.Label();
            bankLabel = new System.Windows.Forms.Label();
            branchLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panelBank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // payment_ModeLabel
            // 
            payment_ModeLabel.AutoSize = true;
            payment_ModeLabel.Location = new System.Drawing.Point(6, 53);
            payment_ModeLabel.Name = "payment_ModeLabel";
            payment_ModeLabel.Size = new System.Drawing.Size(81, 13);
            payment_ModeLabel.TabIndex = 0;
            payment_ModeLabel.Text = "Payment Mode:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(6, 79);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(46, 13);
            amountLabel.TabIndex = 0;
            amountLabel.Text = "Amount:";
            // 
            // entry_DateLabel
            // 
            entry_DateLabel.AutoSize = true;
            entry_DateLabel.Location = new System.Drawing.Point(6, 24);
            entry_DateLabel.Name = "entry_DateLabel";
            entry_DateLabel.Size = new System.Drawing.Size(60, 13);
            entry_DateLabel.TabIndex = 0;
            entry_DateLabel.Text = "Entry Date:";
            // 
            // paid_Due_Post_DateLabel
            // 
            paid_Due_Post_DateLabel.AutoSize = true;
            paid_Due_Post_DateLabel.Location = new System.Drawing.Point(6, 103);
            paid_Due_Post_DateLabel.Name = "paid_Due_Post_DateLabel";
            paid_Due_Post_DateLabel.Size = new System.Drawing.Size(108, 13);
            paid_Due_Post_DateLabel.TabIndex = 0;
            paid_Due_Post_DateLabel.Text = "Paid/Due/Post Date:";
            // 
            // cheque_NoLabel
            // 
            cheque_NoLabel.AutoSize = true;
            cheque_NoLabel.Location = new System.Drawing.Point(-3, 6);
            cheque_NoLabel.Name = "cheque_NoLabel";
            cheque_NoLabel.Size = new System.Drawing.Size(64, 13);
            cheque_NoLabel.TabIndex = 0;
            cheque_NoLabel.Text = "Cheque No:";
            // 
            // bankLabel
            // 
            bankLabel.AutoSize = true;
            bankLabel.Location = new System.Drawing.Point(-3, 32);
            bankLabel.Name = "bankLabel";
            bankLabel.Size = new System.Drawing.Size(35, 13);
            bankLabel.TabIndex = 0;
            bankLabel.Text = "Bank:";
            // 
            // branchLabel
            // 
            branchLabel.AutoSize = true;
            branchLabel.Location = new System.Drawing.Point(-3, 58);
            branchLabel.Name = "branchLabel";
            branchLabel.Size = new System.Drawing.Size(44, 13);
            branchLabel.TabIndex = 0;
            branchLabel.Text = "Branch:";
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Location = new System.Drawing.Point(6, 213);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(52, 13);
            remarksLabel.TabIndex = 0;
            remarksLabel.Text = "Remarks:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelBank);
            this.groupBox1.Controls.Add(remarksLabel);
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Controls.Add(paid_Due_Post_DateLabel);
            this.groupBox1.Controls.Add(this.dtpPaidDuePostDate);
            this.groupBox1.Controls.Add(entry_DateLabel);
            this.groupBox1.Controls.Add(this.dtpEntry_Date);
            this.groupBox1.Controls.Add(amountLabel);
            this.groupBox1.Controls.Add(this.nudAmount);
            this.groupBox1.Controls.Add(payment_ModeLabel);
            this.groupBox1.Controls.Add(this.cmbPaymentMode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 267);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment details";
            // 
            // panelBank
            // 
            this.panelBank.Controls.Add(this.txtChequeNo);
            this.panelBank.Controls.Add(cheque_NoLabel);
            this.panelBank.Controls.Add(this.txtBank);
            this.panelBank.Controls.Add(branchLabel);
            this.panelBank.Controls.Add(bankLabel);
            this.panelBank.Controls.Add(this.txtBranch);
            this.panelBank.Enabled = false;
            this.panelBank.Location = new System.Drawing.Point(9, 129);
            this.panelBank.Name = "panelBank";
            this.panelBank.Size = new System.Drawing.Size(314, 78);
            this.panelBank.TabIndex = 5;
            // 
            // txtChequeNo
            // 
            this.txtChequeNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChequeNo.Location = new System.Drawing.Point(107, 3);
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.Size = new System.Drawing.Size(200, 20);
            this.txtChequeNo.TabIndex = 1;
            // 
            // txtBank
            // 
            this.txtBank.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBank.Location = new System.Drawing.Point(107, 29);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(200, 20);
            this.txtBank.TabIndex = 2;
            // 
            // txtBranch
            // 
            this.txtBranch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBranch.Location = new System.Drawing.Point(107, 55);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(200, 20);
            this.txtBranch.TabIndex = 3;
            // 
            // txtRemarks
            // 
            this.txtRemarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRemarks.Location = new System.Drawing.Point(116, 210);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(200, 49);
            this.txtRemarks.TabIndex = 6;
            // 
            // dtpPaidDuePostDate
            // 
            this.dtpPaidDuePostDate.Location = new System.Drawing.Point(116, 103);
            this.dtpPaidDuePostDate.Name = "dtpPaidDuePostDate";
            this.dtpPaidDuePostDate.Size = new System.Drawing.Size(200, 20);
            this.dtpPaidDuePostDate.TabIndex = 4;
            // 
            // dtpEntry_Date
            // 
            this.dtpEntry_Date.Location = new System.Drawing.Point(116, 24);
            this.dtpEntry_Date.Name = "dtpEntry_Date";
            this.dtpEntry_Date.Size = new System.Drawing.Size(200, 20);
            this.dtpEntry_Date.TabIndex = 1;
            // 
            // nudAmount
            // 
            this.nudAmount.DecimalPlaces = 2;
            this.nudAmount.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.nudAmount.Location = new System.Drawing.Point(116, 77);
            this.nudAmount.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(200, 20);
            this.nudAmount.TabIndex = 3;
            this.nudAmount.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudAmount.ValueChanged += new System.EventHandler(this.nudAmount_ValueChanged);
            // 
            // cmbPaymentMode
            // 
            this.cmbPaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMode.FormattingEnabled = true;
            this.cmbPaymentMode.Items.AddRange(new object[] {
            "CASH",
            "CARD",
            "CREDIT",
            "CHEQUE"});
            this.cmbPaymentMode.Location = new System.Drawing.Point(116, 50);
            this.cmbPaymentMode.Name = "cmbPaymentMode";
            this.cmbPaymentMode.Size = new System.Drawing.Size(200, 21);
            this.cmbPaymentMode.TabIndex = 2;
            this.cmbPaymentMode.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentMode_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(171, 278);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(252, 278);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddPaymentDialogBox
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(335, 312);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPaymentDialogBox";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 40);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Payment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelBank.ResumeLayout(false);
            this.panelBank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpPaidDuePostDate;
        private System.Windows.Forms.DateTimePicker dtpEntry_Date;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.ComboBox cmbPaymentMode;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtBranch;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.TextBox txtChequeNo;
        private System.Windows.Forms.Panel panelBank;
    }
}