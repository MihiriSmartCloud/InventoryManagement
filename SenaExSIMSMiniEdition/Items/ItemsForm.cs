using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenaExSIMSMiniEdition.Items
{
    public partial class ItemsForm : Form
    {
        public ItemsForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        private void LoadAllItems(object sender, EventArgs e)
        {
            try
            {
                this.itemsTableAdapter.Fill_InOrder(this.senaexminidbDataSet.items);//lblTotalItems.Text = "Total Items : " + Convert.ToString(this.itemsTableAdapter.GetData().Rows.Count);
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
                // MessageBox.Show("Items List searching failed!...");
            }
        }

        private void loadSuppliersList(object sender, EventArgs e)
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

        private void loadCategoriesList(object sender, EventArgs e)
        {
            try
            {
                this.categoriesTableAdapter.Fill(this.senaexminidbDataSet.categories);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Categories List Loading Failed!...\n" + ex.ToString());
            }
        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            LoadAllItems(sender, e);
            //Combo Box loading...
            loadSuppliersList(sender, e);
            loadCategoriesList(sender, e);

        }

        /// <summary>
        /// Other Events...
        /// </summary>
        private void toolAllItemsPrint_Click(object sender, EventArgs e)
        {
            try
            {
                new ReportViewerForm_Items(1).ShowDialog();
            }
            catch { }
        }

        private void mnuSK_Search_Click(object sender, EventArgs e)
        {
            txtSearch.setFocusSearchField();
        }


        /// <summary>
        /// Main Items Modifing Events...
        /// </summary>

        private bool checkAlreadyExistItem()
        {
            bool hasItem = false;
            try
            {
                long res = this.itemsTableAdapter.ScalarQuery_CheckAlreadyExistItem(txtItem_Name.Text).Value;
                //Console.WriteLine(res);
                hasItem = (res > 0) ? true : false;
                Console.WriteLine("check Already Exist Supplier....." + hasItem);
            }
            catch (Exception ex)
            {
                Console.WriteLine("check Already Exist Supplier:: " + ex.Message);
            }
            return hasItem;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                lblItem_ID.Text = lblSup_Name.Text = lblStock.Text = string.Empty;
                txtItem_Name.Clear();
                cmbSup_ID.SelectedIndex = (cmbSup_ID.Items.Count > 0) ? 0 : -1;
                cmbCategory.SelectedIndex = (cmbCategory.Items.Count > 0) ? 0 : -1;
                cmbUnit.SelectedIndex = (cmbUnit.Items.Count > 0) ? 0 : -1;
                nudPchsPrice.Value = nudSellingPrice.Value = nudMinQty.Value = nudMaxQty.Value = nudReorderLevel.Value = 0.00M;
                txtRemarks.Clear();
                //Focus txtItemName...
                txtItem_Name.Focus();
            }
            catch { }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                //Add New Items.....
                if (!string.IsNullOrEmpty(txtItem_Name.Text))
                {
                    string msgText = (checkAlreadyExistItem() == false) ? string.Format("Do you want to ADD NEW Item? :-\n{0}", txtItem_Name.Text) : string.Format("Item Name \"{0}\" is already exists.\nDo you want to ADD NEW Item? :-\n{0}", txtItem_Name.Text);

                    DialogResult res = MessageBox.Show(msgText, "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        try
                        {
                            //Console.WriteLine(txtItem_Name.Text + "\n" + cmbSup_ID.SelectedValue.ToString() + "\n" + cmbCategory.SelectedValue.ToString() + "\n" + nudPchsPrice.Value + "\n" + nudSellingPrice.Value + "\n" + cmbUnit.SelectedItem.ToString() + "\n" + nudMinQty.Value + "\n" + nudMaxQty.Value + "\n" + nudReorderLevel.Value + "\n" + 0.00M + "\n" + txtRemarks.Text);
                            this.itemsTableAdapter.InsertQuery(txtItem_Name.Text, cmbSup_ID.SelectedValue.ToString(), cmbCategory.SelectedValue.ToString(), nudPchsPrice.Value, nudSellingPrice.Value, cmbUnit.SelectedItem.ToString(), nudMinQty.Value, nudMaxQty.Value, nudReorderLevel.Value, 0.00M, txtRemarks.Text);
                            MessageBox.Show("Item Added Succesfully!...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (MySqlException ex)
                        {
                            switch (ex.Number)
                            {
                                case 1062:
                                    MessageBox.Show("Item Adding Failed!...\n Item ID is already exists.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                                default:
                                    MessageBox.Show("Item Adding Failed!...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                            }
                        }
                        LoadAllItems(sender, e);
                    }
                }
                else
                    MessageBox.Show("Please Enter Item Name!", "Alert!...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Items Adding Failed!...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Items Adding Failed!...\n" + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(lblItemIDHeader.Text))
                {
                    if (!string.IsNullOrEmpty(txtItem_Name.Text))
                    {

                        //Update Item details.....
                        string msgText = (checkAlreadyExistItem() == false) ? string.Format("Do you want to UPDATE Item Details? :-\n{0}", lblItemIDHeader.Text) : string.Format("Item Name \"{0}\" is already exists.\nDo you want to UPDATE Item Details? :-\n{1}", txtItem_Name.Text, lblItemIDHeader.Text);
                        DialogResult res = MessageBox.Show(msgText, "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            this.itemsTableAdapter.UpdateQuery(txtItem_Name.Text, cmbSup_ID.SelectedValue.ToString(), cmbCategory.SelectedValue.ToString(), nudPchsPrice.Value, nudSellingPrice.Value, cmbUnit.SelectedItem.ToString(), nudMinQty.Value, nudMaxQty.Value, nudReorderLevel.Value, 0.00M, txtRemarks.Text, lblItemIDHeader.Text);
                            MessageBox.Show("Item Details Changed Succesfully!...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadAllItems(sender, e);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Item Name!", "Alert!...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtItem_Name.Focus();
                    }
                }
                else
                { MessageBox.Show("Please Select Item!", "Alert!...", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch
            {
                LoadAllItems(sender, e);
                MessageBox.Show("Item Details Updating Failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(lblItemIDHeader.Text))
                {
                    //Delete Item.....
                    DialogResult res = MessageBox.Show("Do you want to DELETE Item? :-" + '\n' + lblItemIDHeader.Text, "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        try
                        {
                            this.itemsTableAdapter.DeleteQuery(lblItemIDHeader.Text);
                            MessageBox.Show("Item Deleted Succesfully!...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (MySqlException ex)
                        {
                            switch (ex.Number)
                            {
                                case 1451:
                                    MessageBox.Show("Cannot delete \"" + lblItemIDHeader.Text + "\" Item! \nIt has some record(s). \nIf you want to delete, you must change or delete that record(s) first!", "Item Deleting Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                default:
                                    MessageBox.Show("Item Deleting Failed!...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                            }
                        }
                        LoadAllItems(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Item!", "Alert!...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadAllItems(sender, e);
                }
            }
            catch
            {
                LoadAllItems(sender, e);
                MessageBox.Show("Item Deleting Failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                new ReportViewerForm_Items(2, lblItemIDHeader.Text,lblSup_Name.Text).ShowDialog();
            }
            catch { }
        }

        private void lblBanner_Click(object sender, EventArgs e)
        {

        }







        ////////////////////////////////End of the class/////////////////////////////////////
    }
}