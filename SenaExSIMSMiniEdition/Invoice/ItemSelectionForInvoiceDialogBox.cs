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
    internal partial class ItemSelectionForInvoiceDialogBox : Form
    {
        string selItemID = string.Empty;
        string selItemName = string.Empty;
        string selCategory = string.Empty;
        string selUnit = string.Empty;
        decimal selUPrice = 0.00M;

        public ItemSelectionForInvoiceDialogBox()
        {
            InitializeComponent();
        }

        private void LoadAllItems(object sender, EventArgs e)
        {
            try
            {
                this.itemsTableAdapter.Fill(this.senaexminidbDataSet.items);
            }
            catch (Exception ex)
            {
                if (ex.HResult.Equals(-2146232022))
                {
                    //Console.WriteLine("Items List Loading Failed!...ex.HResult.Equals(-2146232022):: \n" + ex.Message);
                }
                else
                {
                    Console.WriteLine("Items List Loading Failed!...\n" + ex.Message);
                    MessageBox.Show("Items List Loading Failed!...");
                }
            }
        }

        private void SearchItems(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtSearch.SearchText))
                {
                    string filterText = "%" + txtSearch.SearchText + "%";
                    this.itemsTableAdapter.FillBy_ItemID_or_Name_or_Cat(this.senaexminidbDataSet.items, filterText, filterText, filterText);
                }
                else
                {
                    LoadAllItems(sender, e);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Items List searching failed!...\n" + ex.ToString());
            }
        }

        private void ItemSelectionDialogBox_Load(object sender, EventArgs e)
        {
            LoadAllItems(sender, e);
        }

        ///////////////////////////////////////////////////////////////////////
        internal string selectedItemID
        {
            get { return selItemID; }
            set { selItemID = value; }
        }
        internal string selectedItemName
        {
            get { return selItemName; }
            set { selItemName = value; }
        }
        internal string selectedCategory
        {
            get { return selCategory; }
            set { selCategory = value; }
        }
        internal string selectedUnit
        {
            get { return selUnit; }
            set { selUnit = value; }
        }
        internal decimal selectedUnitPrice
        {
            get { return selUPrice; }
            set { selUPrice = value; }
        }
        ////////////////////////////////////////////////////////////////////////

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.Equals(Keys.Up))
                {
                    e.SuppressKeyPress = true;
                    itemsBindingSource.MovePrevious();
                }
                else if (e.KeyCode.Equals(Keys.Down))
                {
                    e.SuppressKeyPress = true;
                    itemsBindingSource.MoveNext();
                }
            }
            catch { }
        }

        private void dgvItemList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            { btnOK.Enabled = (string.IsNullOrEmpty(lblSelItemIDHeader.Text)) ? false : true; }
            catch { }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(lblSelItemIDHeader.Text))
                {
                    this.DialogResult = DialogResult.OK;
                    selItemID = lblSelItemIDHeader.Text;
                    selItemName = lblSelItemNameHeader.Text;
                    selCategory = (itemsTableAdapter.GetDataBy_ItemID(selItemID).Rows.Count > 0) ? itemsTableAdapter.GetDataBy_ItemID(selItemID).Rows[0].Field<string>("Category") : String.Empty;
                    selUnit = (itemsTableAdapter.GetDataBy_ItemID(selItemID).Rows.Count > 0) ? itemsTableAdapter.GetDataBy_ItemID(selItemID).Rows[0].Field<string>("Unit") : String.Empty;
                    selUPrice = (itemsTableAdapter.GetDataBy_ItemID(selItemID).Rows.Count > 0) ? itemsTableAdapter.GetDataBy_ItemID(selItemID).Rows[0].Field<decimal>("Selling_Price") : 0.00M;
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                    MessageBox.Show("No Selected Item!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot Load Selected Item!...\n" + ex.ToString());
                MessageBox.Show("Cannot Load Selected Item!...\n");
            }
        }

        private void skFocusSearchBox_Click(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void dgvItemList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOK_Click(null, null);
        }


        ///////////////////////////////////End of the class////////////////////////////////////////
    }
}
