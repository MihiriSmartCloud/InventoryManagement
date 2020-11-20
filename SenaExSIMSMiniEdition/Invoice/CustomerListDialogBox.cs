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
    internal partial class CustomerListDialogBox : Form
    {
        string selCustID = string.Empty;
        public CustomerListDialogBox()
        {
            InitializeComponent();
        }
        internal string selectedCustID
        {
            get { return selCustID; }
            set { selCustID = value; }
        }
        private void LoadAllCustomers()
        {
            try
            {
                this.customersTableAdapter.Fill(this.senaexminidbDataSet.customers);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Customers List Loading Failed!...\n" + ex.ToString());
            }
        }

        private void CustomerListDialogBox_Load(object sender, EventArgs e)
        {
            LoadAllCustomers();
        }


        private void SearchCustomer(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtSearch.SearchText))
                {
                    string filterText = "%" + txtSearch.SearchText + "%";
                    this.customersTableAdapter.FillBy_CustID_Name(this.senaexminidbDataSet.customers, filterText, filterText);
                }
                else
                {
                    LoadAllCustomers();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Customers List searching failed!...\n" + ex.ToString());
            }
        }

     
        ///////////////////////////////////////////////////////////////////////
       

        ////////////////////////////////////////////////////////////////////////

        private void skFocusSearchBox_Click(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(lblSelCustIDHeader.Text))
                {
                    this.DialogResult = DialogResult.OK;
                    selCustID = lblSelCustIDHeader.Text;
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                    MessageBox.Show("No Selected Customer!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot Load Selected Customer!...\n" + ex.ToString());
                MessageBox.Show("Cannot Load Selected Customer!...\n");
            }
        }

        private void dgvCustList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            { btnOK.Enabled = (string.IsNullOrEmpty(lblSelCustIDHeader.Text)) ? false : true; }
            catch { }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.Equals(Keys.Up))
                {
                    e.SuppressKeyPress = true;
                    customersBindingSource.MovePrevious();
                }
                else if (e.KeyCode.Equals(Keys.Down))
                {
                    e.SuppressKeyPress = true;
                    customersBindingSource.MoveNext();
                }
            }
            catch { }
        }

        private void dgvCustList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOK_Click(null, null);
        }




        //////////////////////////////////////////////////////////////////////
    }
}
