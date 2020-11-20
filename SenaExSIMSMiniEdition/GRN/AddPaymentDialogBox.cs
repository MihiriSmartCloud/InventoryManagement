using System;
using System.Windows.Forms;

namespace SenaExSIMSMiniEdition.GRN
{
    internal partial class AddPaymentDialogBox : Form
    {
        public AddPaymentDialogBox(decimal balValue)
        {
            InitializeComponent();
            cmbPaymentMode.SelectedIndex = 0;
            nudAmount.Value = balValue;
        }


        /// <summary>
        /// //Properties...
        /// </summary>
        public DateTime EntryDate
        {
            get { return dtpEntry_Date.Value; }
            set { dtpEntry_Date.Value = value; }
        }
        public object PaymentMode
        {
            get { return cmbPaymentMode.SelectedItem; }
            set { cmbPaymentMode.SelectedItem = value; }
        }
        public decimal Amount
        {
            get { return nudAmount.Value; }
            set { nudAmount.Value = value; }
        }
        public DateTime PaidDuePostDate
        {
            get { return dtpPaidDuePostDate.Value; }
            set { dtpPaidDuePostDate.Value = value; }
        }
        public string ChequeNo
        {
            get { return txtChequeNo.Text; }
            set { txtChequeNo.Text = value; }
        }
        public string Bank
        {
            get { return txtBank.Text; }
            set { txtBank.Text = value; }
        }
        public string Branch
        {
            get { return txtBranch.Text; }
            set { txtBranch.Text = value; }
        }
        public string Remarks
        {
            get { return txtRemarks.Text; }
            set { txtRemarks.Text = value; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EntryDate = dtpEntry_Date.Value;
            PaymentMode = cmbPaymentMode.SelectedItem;
            Amount = nudAmount.Value;
            PaidDuePostDate = dtpPaidDuePostDate.Value;
            ChequeNo = txtChequeNo.Text;
            Bank = txtBank.Text;
            Branch = txtBranch.Text;
            Remarks = txtRemarks.Text;
            //
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void nudAmount_ValueChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = (nudAmount.Value > 0) ? true : false;
        }

        private void cmbPaymentMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelBank.Enabled = (cmbPaymentMode.SelectedIndex == 2) ? true : false;
        }

        //
    }
}
