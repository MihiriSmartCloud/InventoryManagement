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

namespace SenaExSIMSMiniEdition.Suppliers
{
    internal partial class SuppliersForm : Form
    {
        public SuppliersForm()
        {
            InitializeComponent();
        }

        private void LoadAllSuppliers()
        {
            try
            {
                this.suppliersTableAdapter.Fill(this.senaexminidbDataSet.suppliers);
                lblTotalSup.Text = "Total Suppliers : " + Convert.ToString(this.suppliersTableAdapter.GetData().Rows.Count);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Suppliers List Loading Failed!...\n" + ex.ToString());
                MessageBox.Show("Suppliers List Loading Failed!...");
            }
        }

        private void SearchSuppliers(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtSearch.SearchText))
                {
                    string filterText = "%" + txtSearch.SearchText + "%";
                    this.suppliersTableAdapter.FillBy_SupSearch(this.senaexminidbDataSet.suppliers, filterText, filterText, filterText, filterText);
                }
                else
                {
                    LoadAllSuppliers();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Suppliers List searching failed!...\n" + ex.ToString());
                // MessageBox.Show("Suppliers List searching failed!...");
            }
        }

        private void SuppliersForm_Load(object sender, EventArgs e)
        {
            LoadAllSuppliers();
        }

        private bool checkAlreadyExistSupplier()
        {
            bool hasSup = false;
            try
            {
                long res = this.suppliersTableAdapter.ScalarQuery_checkAlreadyExistSup(txtSup_Name.Text).Value;
                //Console.WriteLine(res);
                hasSup = (res > 0) ? true : false;
                Console.WriteLine("check Already Exist Supplier....." + hasSup);
            }
            catch (Exception ex)
            {
                Console.WriteLine("check Already Exist Supplier:: " + ex.Message);
            }
            return hasSup;
        }

        ////////////////////////////////////////////////////////////////////////////

        private void setSelected_Sup_Header(object sender, EventArgs e)
        {
            try
            {
                lblSupHeader.Text = "( " + lblSup_ID.Text + " )  " + txtSup_Name.Text;
            }
            catch { }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                //Clear All Fields....
                lblSup_ID.Text = string.Empty; ;
                txtSup_Name.Clear();
                txtAddress.Clear();
                txtStreet.Clear();
                txtCity.Clear();
                cmbCountry.SelectedItem = "SRI LANKA";
                txtTelephone.Clear();
                txtMobile.Clear();
                txtFax.Clear();
                txtEmail.Clear();
                txtWeb.Clear();
                txtContactPerson.Clear();
                txtDescription.Clear();
                //Focus cursor...
                txtSup_Name.Focus();
            }
            catch { }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtSup_Name.Text))
                {
                    //Add new supplier.....
                    string msgText = (checkAlreadyExistSupplier() == false) ? string.Format("Do you want to ADD NEW Supplier? :-\n{0}", txtSup_Name.Text) : string.Format("Supplier Name \"{0}\" is already exists.\nDo you want to ADD NEW Supplier? :-\n{0}", txtSup_Name.Text);
                    DialogResult res = MessageBox.Show(msgText, "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        try
                        {
                            this.suppliersTableAdapter.InsertQuery_Supplier(txtSup_Name.Text, txtAddress.Text, txtStreet.Text, txtCity.Text, cmbCountry.SelectedItem.ToString(), txtTelephone.Text, txtMobile.Text, txtFax.Text, txtEmail.Text, txtWeb.Text, txtContactPerson.Text, txtDescription.Text);
                            MessageBox.Show("Supplier Added Succesfully!...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (MySqlException ex)
                        {
                            switch (ex.Number)
                            {
                                case 1062:
                                    MessageBox.Show("Supplier Adding Failed!...\n Supplier ID is already exists.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                                default:
                                    MessageBox.Show("Supplier Adding Failed!...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                            }
                        }
                        LoadAllSuppliers();
                    }
                }
                else { MessageBox.Show("Please Enter Supplier Name!", "Alert!...", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch { MessageBox.Show("Supplier Adding Failed!...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(lblSup_ID.Text))
                {
                    if (!string.IsNullOrEmpty(txtSup_Name.Text))
                    {
                        //Update supplier details.....
                        string msgText = (checkAlreadyExistSupplier() == false) ? string.Format("Do you want to UPDATE Supplier's Details? :-\n{0}", lblSupHeader.Text) : string.Format("Supplier Name \"{0}\" is already exists.\nDo you want to UPDATE Supplier's Details? :-\n{1}", txtSup_Name.Text, lblSupHeader.Text);
                        DialogResult res = MessageBox.Show(msgText, "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            this.suppliersTableAdapter.UpdateQuery_Supplier(txtSup_Name.Text, txtAddress.Text, txtStreet.Text, txtCity.Text, cmbCountry.SelectedItem.ToString(), txtTelephone.Text, txtMobile.Text, txtFax.Text, txtEmail.Text, txtWeb.Text, txtContactPerson.Text, txtDescription.Text, lblSup_ID.Text);
                            MessageBox.Show("Supplier Details Changed Succesfully!...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadAllSuppliers();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Supplier Name!", "Alert!...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSup_Name.Focus();
                    }
                }
                else
                { MessageBox.Show("Please Select Supplier!", "Alert!...", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch
            {
                LoadAllSuppliers();
                MessageBox.Show("Supplier Details Updating Failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(lblSup_ID.Text))
                {
                    //Delete supplier.....
                    DialogResult res = MessageBox.Show("Do you want to DELETE Supplier's Details? :-" + '\n' + lblSupHeader.Text, "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        try
                        {
                            this.suppliersTableAdapter.DeleteQuery_Supplier(lblSup_ID.Text);
                            MessageBox.Show("Supplier Deleted Succesfully!...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (MySqlException ex)
                        {
                            switch (ex.Number)
                            {
                                case 1451:
                                    MessageBox.Show("Cannot delete \"" + lblSupHeader.Text + "\" supplier! \nIt has some record(s). \nIf you want to delete, you must change or delete that record(s) first!", "Supplier Deleting Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                default:
                                    MessageBox.Show("Supplier Deleting Failed!...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                            }
                        }
                        LoadAllSuppliers();
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Supplier!", "Alert!...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadAllSuppliers();
                }
            }
            catch
            {
                LoadAllSuppliers();
                MessageBox.Show("Supplier Deleting Failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = new Util.CustomOptionBox(new string[] { "Print Personal Details Of The Supplier", "Print Detailed List Of All Suppliers" }).ShowDialog();
                if (res.Equals(DialogResult.Yes))
                    new ReportViewerForm(lblSup_ID.Text, 1).ShowDialog();
                else if (res.Equals(DialogResult.No))
                    new ReportViewerForm(2).ShowDialog();
            }
            catch { }
        }

        private void mnuSK_Search_Click(object sender, EventArgs e)
        {
            txtSearch.setFocusSearchField();
        }








        ///////////////////////////End of the class///////////////////////////////
    }
}
