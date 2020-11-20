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

namespace SenaExSIMSMiniEdition.Customers
{
    internal partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void LoadAllCust()
        {
            try
            {
                this.customersTableAdapter.Fill(this.senaexminidbDataSet.customers);
                lblTotalCust.Text = "Total Customers : " + Convert.ToString(this.customersTableAdapter.GetData().Rows.Count);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Customers List Loading Failed!...\n" + ex.ToString());
                MessageBox.Show("Customers List Loading Failed!...\n" + ex.ToString());
            }
        }

        private void SearchCust(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtSearch.SearchText))
                {
                    string filterText = "%" + txtSearch.SearchText + "%";
                    this.customersTableAdapter.FillBy_CustSearch(this.senaexminidbDataSet.customers, filterText, filterText, filterText, filterText);
                }
                else
                {
                    LoadAllCust();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Customers List searching failed!...\n" + ex.ToString());
                // MessageBox.Show("Customers List searching failed!...");
            }
        }

        private void LoadVehicles(object sender, EventArgs e)
        {
            try
            {
                this.vehiclesTableAdapter.FillBy_CustID(this.senaexminidbDataSet.vehicles, lblCust_ID.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Customer's vehicles List Loading Failed!...\n" + ex.ToString());
                MessageBox.Show("Customer's vehicles List Loading Failed!...");
            }
        }

        private bool checkAlreadyExistCustomers()
        {
            bool hasCust = false;
            try
            {
                long res = this.customersTableAdapter.ScalarQuery_AREC(txtCust_Name.Text).Value;
                hasCust = (res > 0) ? true : false;
                Console.WriteLine("check Already Exist Customers....." + hasCust);
            }
            catch (Exception ex)
            { Console.WriteLine("check Already Exist Customers:: " + ex.Message); }
            return hasCust;
        }


        private void CustomersForm_Load(object sender, EventArgs e)
        {
            LoadAllCust();
            LoadVehicles(sender, e);
        }

        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.fKCustIDCustomersBindingSource.EndEdit();
            this.vehiclesTableAdapter.Update(this.senaexminidbDataSet.vehicles);
        }

        private void itemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.senaexminidbDataSet);
            //this.customersTableAdapter.Update(this.senaexminidbDataSet.customers);
            //this.vehiclesTableAdapter.Update(this.senaexminidbDataSet.vehicles);
        }



        private void vehicleSaveChanges()
        {
            try
            {
                this.Validate();
                this.vehiclesBindingSource.EndEdit();
                this.vehiclesTableAdapter.Update(this.senaexminidbDataSet.vehicles);
            }
            catch (Exception ex)
            { Console.WriteLine("vehicleSaveChanges Customers:: " + ex.Message); }
        }

        private void setVehicelCustIDForNewCust()
        {
            try
            {
                int LastMaxID = customersTableAdapter.ScalarQuery_LastMaxID().Value;
                foreach (DataRow row in senaexminidbDataSet.vehicles.Rows)
                {
                    row.SetField<string>(senaexminidbDataSet.vehicles.Cust_IDColumn, string.Format("CUS-{0}", LastMaxID.ToString()));
                }
            }
            catch { Console.WriteLine("New Customers Vehicle custID Setting Failed!..."); }
        }

        private void addNewVehicel_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!string.IsNullOrEmpty(txtVehicelNo.Text)) && (!string.IsNullOrEmpty(txtMake.Text)) && (!string.IsNullOrEmpty(txtModel.Text)))
                {
                    senaexminidbDataSet.vehicles.Rows.Add(new object[] { lblCustIDHeader.Text, txtVehicelNo.Text, txtMake.Text, txtModel.Text });
                    txtVehicelNo.Clear(); txtMake.Clear(); txtModel.Clear();
                }
                else
                {
                    MessageBox.Show("Please fill in the Vehicle No or Make or Model field(s)!", "Alert!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtVehicelNo.Focus();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Customers Vehicle Adding Failed!...\n" + ex.ToString());
                MessageBox.Show("Customers Vehicle Adding Failed!...\n" + ex.ToString());
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                //Clear All Fields....
                lblCustIDHeader.Text = lblCustNameHeader.Text = lblCust_ID.Text = string.Empty;
                txtCust_Name.Clear();
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
                txtCust_Name.Focus();
                //vehicel fields...
                txtVehicelNo.Clear(); txtMake.Clear(); txtModel.Clear();
            }
            catch { }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCust_Name.Text))
                {
                    //Add new Customer.....
                    string msgText = (checkAlreadyExistCustomers() == false) ? string.Format("Do you want to ADD NEW Customer? :-\n{0}", txtCust_Name.Text) : string.Format("Customer Name \"{0}\" is already exists.\nDo you want to ADD NEW Customer? :-\n{0}", txtCust_Name.Text);
                    DialogResult res = MessageBox.Show(msgText, "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        try
                        {
                            this.customersTableAdapter.InsertQuery(txtCust_Name.Text, txtAddress.Text, txtStreet.Text, txtCity.Text, cmbCountry.SelectedItem.ToString(), txtTelephone.Text, txtMobile.Text, txtFax.Text, txtEmail.Text, txtWeb.Text, txtContactPerson.Text, txtDescription.Text);
                            //
                            setVehicelCustIDForNewCust();
                            vehicleSaveChanges();
                            MessageBox.Show("Customer Added Succesfully!...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (MySqlException ex)
                        {
                            switch (ex.Number)
                            {
                                case 1062:
                                    MessageBox.Show("Customer Adding Failed!...\n Customer ID is already exists.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                                default:
                                    MessageBox.Show("Customer Adding Failed!...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                            }
                        }
                        LoadAllCust();
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Customer Name!", "Alert!...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCust_Name.Focus();
                }
            }
            catch { MessageBox.Show("Customer Adding Failed!...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(lblCustIDHeader.Text))
                {
                    if (!string.IsNullOrEmpty(txtCust_Name.Text))
                    {
                        //Update Customer details.....
                        string msgText = (checkAlreadyExistCustomers() == false) ? string.Format("Do you want to UPDATE Customer's Details? :-\n{0} - {1}", lblCustIDHeader.Text, lblCustNameHeader.Text) : string.Format("Customer Name \"{0}\" is already exists.\nDo you want to UPDATE Customer's Details? :-\n{1} - {2}", txtCust_Name.Text, lblCustIDHeader.Text, lblCustNameHeader.Text);
                        DialogResult res = MessageBox.Show(msgText, "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            this.customersTableAdapter.UpdateQuery(txtCust_Name.Text, txtAddress.Text, txtStreet.Text, txtCity.Text, cmbCountry.SelectedItem.ToString(), txtTelephone.Text, txtMobile.Text, txtFax.Text, txtEmail.Text, txtWeb.Text, txtContactPerson.Text, txtDescription.Text, lblCustIDHeader.Text);
                            vehicleSaveChanges();
                            MessageBox.Show("Customer Details Changed Succesfully!...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadAllCust();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Customer Name!", "Alert!...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCust_Name.Focus();
                    }
                }
                else
                { MessageBox.Show("Please Select Customer!", "Alert!...", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch
            {
                LoadAllCust();
                MessageBox.Show("Customer Details Updating Failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(lblCustIDHeader.Text))
                {
                    //Delete Customer.....
                    DialogResult res = MessageBox.Show("Do you want to DELETE Customer's Details? :-" + '\n' + lblCustIDHeader.Text, "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        try
                        {
                            this.customersTableAdapter.DeleteQuery(lblCustIDHeader.Text);
                            MessageBox.Show("Customer Deleted Succesfully!...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (MySqlException ex)
                        {
                            switch (ex.Number)
                            {
                                case 1451:
                                    MessageBox.Show("Cannot delete \"" + lblCustIDHeader.Text + "\" Customer! \nIt has some record(s). \nIf you want to delete, you must change or delete that record(s) first!", "Customer Deleting Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                default:
                                    MessageBox.Show("Customer Deleting Failed!...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                            }
                        }
                        LoadAllCust();
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Customer!", "Alert!...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadAllCust();
                }
            }
            catch
            {
                LoadAllCust();
                MessageBox.Show("Customer Deleting Failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = new Util.CustomOptionBox(new string[] { "Print Personal Details", "Print Detailed List Of All Customers" }).ShowDialog();
                if (res.Equals(DialogResult.Yes))
                    new ReportViewerForm(lblCustIDHeader.Text, 1).ShowDialog();
                else if (res.Equals(DialogResult.No))
                    new ReportViewerForm(2).ShowDialog();
            }
            catch { }
        }

        private void mnuSK_Search_Click(object sender, EventArgs e)
        {
            txtSearch.setFocusSearchField();
        }









        /////////////////////////////End of the class////////////////////////////////////
    }
}
