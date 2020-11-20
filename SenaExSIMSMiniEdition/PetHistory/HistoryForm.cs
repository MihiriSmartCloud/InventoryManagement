using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenaExSIMSMiniEdition.PetHistory
{
    public partial class HistoryForm : Form
    {
        string curRole = string.Empty;
        string curUser = string.Empty;
        public HistoryForm(string curRole, string curUser)
        {
            InitializeComponent();
            this.curRole = curRole;
            this.curUser = curUser;
            lblInv_Username.Text = string.Format("{0} : {1}", curRole, curUser);
        }

        private void btnMakeNewHistory_Click(object sender, EventArgs e)
        {
            try
            {
                lblHisNoHeader.Text = "New Invoice";
                lblHisNoHeader.Text = txtCustID.TextResult = string.Empty;
                //senaexminidbDataSet.invoice_service.Clear();
                lblInv_Username.Text = string.Format("{0} : {1}", curRole, curUser);
                dtpInvDate.Focus();
            }
            catch { }
        }

        private void btnPrevInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                InvoiceListForm selPrevHistory = new InvoiceListForm();
                DialogResult res = selPrevHistory.ShowDialog();
                if (res.Equals(DialogResult.OK))
                {
                    lblHisNoHeader.Text = selPrevHistory.selectedInvoice;
                    //loadPrevData();
                }
            }
            catch
            {
                Console.WriteLine("Cannot Load History List!...\n");
                MessageBox.Show("Cannot Load History List!...\n", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewInvoiceList_Click(object sender, EventArgs e)
        {
            try
            {
                new InvoiceListForm(btnViewInvoiceList.Text).ShowDialog();
            }
            catch
            {
                Console.WriteLine("Cannot Load Invoice List!...\n");
                MessageBox.Show("Cannot Load Invoice List!...\n", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCustID_findButton_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerListDialogBox custListForm = new CustomerListDialogBox();
                DialogResult res = custListForm.ShowDialog();
                if (res.Equals(DialogResult.OK))
                {
                    txtCustID.TextResult = string.Empty;
                    txtCustID.TextResult = custListForm.selectedCustID;
                    SelectNextControl(txtCustID, true, true, true, true);
                }
            }
            catch
            {
                Console.WriteLine("Cannot Load Customers!...\n");
                MessageBox.Show("Cannot Load Customers!...\n", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadCustomersWithVehicles()
        {
            try
            {
                customersTableAdapter.FillBy_CustID(senaexminidbDataSet.customers, txtCustID.TextResult);
                vehiclesTableAdapter.Fill(this.senaexminidbDataSet.vehicles);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Customers With Vehicles List Loading Failed!...\n" + ex.ToString());
                MessageBox.Show("Customers With Vehicles List Loading Failed!...\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCustID_resultTextbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                loadCustomersWithVehicles();
                txtAddress.Text = (customersTableAdapter.GetDataBy_CustID(txtCustID.TextResult).Rows.Count > 0) ? string.Format("{0}, \n{1}, \n{2}, \n{3}.",
                    customersTableAdapter.GetDataBy_CustID(txtCustID.TextResult).Rows[0].Field<string>("Address"),
                    customersTableAdapter.GetDataBy_CustID(txtCustID.TextResult).Rows[0].Field<string>("Street"),
                    customersTableAdapter.GetDataBy_CustID(txtCustID.TextResult).Rows[0].Field<string>("City"),
                    customersTableAdapter.GetDataBy_CustID(txtCustID.TextResult).Rows[0].Field<string>("Country")) : string.Empty;
            }
            catch (Exception ex) { Console.WriteLine("txtInv_CustID_resultTextbox_TextChanged Failed!..." + ex.ToString()); }
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'senaexminidbDataSet.invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.senaexminidbDataSet.invoice);

        }

        private void btnSaveOnly_Click(object sender, EventArgs e)
        {
            saveHistory();
        }

        public void saveHistory()
        {
            try
            {
                if ((!string.IsNullOrEmpty(txtCustID.TextResult)) && ((txtcomplain.Text !=null) || (txtlabfind.Text!=null)) || (txtmedication.Text!=null) || (txtprescription.Text!=null))
                {
                    DialogResult res = MessageBox.Show("Do you want to Save this History? ", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res.Equals(DialogResult.Yes))
                    {
                        if (string.IsNullOrEmpty(lblHisNoHeader.Text))
                        {
                            saveNewHistory();
                        }
                        else if (!string.IsNullOrEmpty(lblHisNoHeader.Text))
                        {
                            savePreviosHistory();
                        }
                        btnMakeNewHistory_Click(null, null);
                    }
                }
                else { MessageBox.Show("Please Complete The History!...", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Cannot Save This History!...\n" + ex);
            }
           
        }

        public void saveNewHistory()
        {
            try
            {
                string msg_basic = string.Empty;
                try
                {
                    //invoiceTableAdapter.InsertQuery(dtpInvDate.Value, txtJobNo.Text, string.Format("{0} : {1}", curRole, curUser), txtCustID.TextResult, cmbVehicleNo.SelectedValue.ToString(), nudMeter.Value, txtcomplain.Text, txtlabfind.Text ,txtmedication.Text, txtprescription.Text);
                    msg_basic = "Basic History entries saved SUCCESSFULLY!";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("History entries inserting Ex::!...\n" + ex);
                    msg_basic = "Basic History entries saving FAILED!";
                }
                //int LastMaxID = invoiceTableAdapter.ScalarQuery_LastMaxID().Value;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot Save New History!...\n" + ex);
                MessageBox.Show("Histroy Saving Failed!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void savePreviosHistory()
        {
            try
            {
                try 
                {

                    string msg_basic = string.Empty;
                    try
                    {
                        //string remarksUpdates = (!lblInv_Username.Text.Equals(string.Format("{0} : {1}", curRole, curUser))) ? txtRemarks.Text + " \n***Previous updated by:: " + lblInv_Username.Text : txtRemarks.Text;
                        //invoiceTableAdapter.UpdateQuery(dtpInvDate.Value, txtJobNo.Text, string.Format("{0} : {1}", curRole, curUser), txtCustID.TextResult, cmbVehicleNo.SelectedValue.ToString(), nudMeter.Value, txtcomplain.Text, txtlabfind.Text, txtmedication.Text,txtprescription.Text, lblHisNoHeader.Text);
                        msg_basic = "Basic Invoice entries saved SUCCESSFULLY!";
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Invoice entries inserting Ex::!...\n" + ex);
                        msg_basic = "Basic Invoice entries saving FAILED!";
                    }
                    MessageBox.Show(string.Format("History Saving Status:\n\n{0}\n{1}\n{2}\n{3}", msg_basic), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Cannot Save Previos History!...\n" + ex);
                    MessageBox.Show("History Saving Failed!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot Save Previos History!...\n" + ex);
                MessageBox.Show("History Saving Failed!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
