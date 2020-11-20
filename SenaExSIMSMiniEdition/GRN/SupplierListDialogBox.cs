using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenaExSIMSMiniEdition.GRN
{
    internal partial class SupplierListDialogBox : Form
    {
        string selSupID = string.Empty;
        string selSupName = string.Empty;

        public SupplierListDialogBox()
        {
            InitializeComponent();
        }

        private void LoadAllSuppliers()
        {
            try
            {
                this.suppliersTableAdapter.Fill(this.senaexminidbDataSet.suppliers);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Suppliers List Loading Failed!...\n" + ex.ToString());
            }
        }

        private void SearchSuppliers(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtSearch.SearchText))
                {
                    string filterText = "%" + txtSearch.SearchText + "%";
                    this.suppliersTableAdapter.FillBy_SupID_Name(this.senaexminidbDataSet.suppliers, filterText, filterText);
                }
                else
                {
                    LoadAllSuppliers();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Suppliers List searching failed!...\n" + ex.ToString());
            }
        }

        private void SupplierListDialogBox_Load(object sender, EventArgs e)
        {
            LoadAllSuppliers();
        }

        ///////////////////////////////////////////////////////////////////////
        internal string selectedSupID
        {
            get { return selSupID; }
            set { selSupID = value; }
        }

        internal string selectedSupName
        {
            get { return selSupName; }
            set { selSupName = value; }
        }
        ////////////////////////////////////////////////////////////////////////

        private void skFocusSearchBox_Click(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(lblSelSupIDHeader.Text))
                {
                    this.DialogResult = DialogResult.OK;
                    selSupID = lblSelSupIDHeader.Text;
                    selSupName = lblSelSupNameHeader.Text;
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                    MessageBox.Show("No Selected Supplier!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot Load Selected Supplier!...\n" + ex.ToString());
                MessageBox.Show("Cannot Load Selected Supplier!...\n");
            }
        }

        private void dgvSupList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            { btnOK.Enabled = (string.IsNullOrEmpty(lblSelSupIDHeader.Text)) ? false : true; }
            catch { }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.Equals(Keys.Up))
                {
                    e.SuppressKeyPress = true;
                    suppliersBindingSource.MovePrevious();
                }
                else if (e.KeyCode.Equals(Keys.Down))
                {
                    e.SuppressKeyPress = true;
                    suppliersBindingSource.MoveNext();
                }
            }
            catch { }
        }

        private void dgvSupList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOK_Click(null, null);
        }




        //////////////////////////////////////////////////////////////////////
    }
}
