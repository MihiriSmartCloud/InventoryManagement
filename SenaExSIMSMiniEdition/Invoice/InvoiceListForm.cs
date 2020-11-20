using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenaExSIMSMiniEdition.Invoice
{
    internal partial class InvoiceListForm : Form
    {
        /////////////////////////////////////////////////////////////////////////////////////////////
        string selectedInvNo = string.Empty;

        public InvoiceListForm()
        {
            InitializeComponent();

            btnPrint.Enabled = btnPrint.Visible = skPrint.Enabled = false;
            btnLoad.Enabled = true;
            btnLoad.Show();
        }

        public InvoiceListForm(string Titel)
        {
            InitializeComponent();

            this.Text = Titel;
            btnPrint.Enabled = btnPrint.Visible = skPrint.Enabled = true;
            btnLoad.Enabled = false;
            btnLoad.Hide();

        }

        private void loadAllInvoice(object sender, System.EventArgs e)
        {
            try
            {
                this.invoiceTableAdapter.Fill(this.senaexminidbDataSet.invoice);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invoice List Loading Faile!...\n" + ex.ToString());
                MessageBox.Show("Invoice List Loading Faile!...\n" + ex.Message);
            }
        }

        private void searchInvoice(object sender, System.EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtSearch.SearchText))
                {
                    string filterText = "%" + txtSearch.SearchText + "%";
                    this.invoiceTableAdapter.FillBy_InvNo_JobNo_VNo(this.senaexminidbDataSet.invoice, filterText, filterText, filterText);
                }
                else
                {
                    loadAllInvoice(sender, e);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invoice List searching Fail!...\n" + ex.ToString());
            }
        }

        private void InvoiceListForm_Load(object sender, EventArgs e)
        {
            loadAllInvoice(sender, e);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        internal string selectedInvoice
        {
            get { return selectedInvNo; }
            set { selectedInvNo = value; }
        }

        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        private void skFocusSrearchBox_Click(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(lblSelInvoiceHeader.Text))
                {
                    this.DialogResult = DialogResult.OK;
                    selectedInvNo = lblSelInvoiceHeader.Text;
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                    MessageBox.Show("No Selected Invoice!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot Load Selected Invoice!...\n" + ex.ToString());
                MessageBox.Show("Cannot Load Selected Invoice!...\n");
            }
        }

        private void dgvInvoiceList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            { btnLoad.Enabled = (string.IsNullOrEmpty(lblSelInvoiceHeader.Text)) ? false : true; }
            catch { }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                new ReportViewerForm_Invoice(1).Show();
            }
            catch { }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.Equals(Keys.Up))
                {
                    e.SuppressKeyPress = true;
                    invoiceBindingSource.MovePrevious();
                }
                else if (e.KeyCode.Equals(Keys.Down))
                {
                    e.SuppressKeyPress = true;
                    invoiceBindingSource.MoveNext();
                }
            }
            catch { }
        }

        private void dgvInvoiceList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnLoad_Click(null, null);
        }


        ///////////////////////////////////End of the class//////////////////////////////////////
    }
}
