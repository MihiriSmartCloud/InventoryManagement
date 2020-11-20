using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenaExSIMSMiniEdition.Invoice
{
    internal partial class InvoiceForm : Form
    {

        string curRole = string.Empty;
        string curUser = string.Empty;

        enum commType { Insert, Update, Delete };

        List<string> addedList = new List<string>();

        public InvoiceForm(string curRole, string curUser)
        {
            InitializeComponent();

            this.curRole = curRole;
            this.curUser = curUser;
            lblInv_Username.Text = string.Format("{0} : {1}", curRole, curUser);
        }

        private void loadInvoice()
        {
            try
            {
                this.invoiceTableAdapter.FillBy_InvNo(this.senaexminidbDataSet.invoice, lblInvNoHeader.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invoice List Loading Failed!...\n" + ex.ToString());
                MessageBox.Show("Invoice List Loading Failed!...\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void loadInvoiceService()
        {
            try
            {
                this.invoice_serviceTableAdapter.FillBy_InvNo(this.senaexminidbDataSet.invoice_service, lblInvNoHeader.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invoice Services Details Loading Failed!...\n" + ex.ToString());
                MessageBox.Show("Invoice Services Details Loading Failed!...\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadInvoiceItems()
        {
            try
            {
                invoice_itemsTableAdapter.FillBy_InvNo(this.senaexminidbDataSet.invoice_items, lblInvNoHeader.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invoice Item Details Loading Failed!...\n" + ex.ToString());
                MessageBox.Show("Invoice Item Details Loading Failed!...\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadPayments()
        {
            try
            {
                paymentsTableAdapter.FillBy_PMNo(this.senaexminidbDataSet.payments, lblInvNoHeader.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Payments Details Loading Failed!...\n" + ex.ToString());
                MessageBox.Show("Payments Details Loading Failed!...\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadService_types()
        {
            try
            {
                this.service_typesTableAdapter.Fill(this.senaexminidbDataSet.service_types);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Service_types Details Loading Failed!...\n" + ex.ToString());
                MessageBox.Show("Service_types Details Loading Failed!...\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadItems()
        {
            try
            {
                this.itemsTableAdapter.Fill(this.senaexminidbDataSet.items);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Items Loading Failed!...\n" + ex.ToString());
                MessageBox.Show("Items Loading Failed!...\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            loadService_types();
            loadItems();
        }

        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 
        private void lblInvNo_Header_TextChanged(object sender, EventArgs e)
        {
            try
            {
                loadInvoice();
                //loadCustomersWithVehicles();
                loadInvoiceService();
                loadInvoiceItems();
                loadPayments();
                //
                btnDeleteInvoice.Enabled = btnPrint.Enabled = printToolStripMenuItem.Enabled = deleteInvToolStripMenuItem.Enabled = asCopyToolStripMenuItem.Enabled = asInvoiceToolStripMenuItem.Enabled = asReceiptToolStripMenuItem.Enabled = (string.IsNullOrEmpty(lblInvNoHeader.Text)) ? false : true;
                //addedList clear...
                addedList.Clear();
            }
            catch (Exception ex) { Console.WriteLine("lblInvNo_Header_TextChanged Failed!..." + ex.ToString()); }
        }


        /// <summary>
        /// Invoice data/////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        ///        
        private void btnMakeNewInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                lblInvNoHeader.Text = "New Invoice";
                lblInvNoHeader.Text = txtCustID.TextResult = string.Empty;
                senaexminidbDataSet.invoice_service.Clear();
                lblInv_Username.Text = string.Format("{0} : {1}", curRole, curUser);
                dtpInvDate.Focus();
            }
            catch { }
        }

        private void btnPrevInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                InvoiceListForm selPrevInvoice = new InvoiceListForm();
                DialogResult res = selPrevInvoice.ShowDialog();
                if (res.Equals(DialogResult.OK))
                {
                    lblInvNoHeader.Text = selPrevInvoice.selectedInvoice;
                    //loadPrevData();
                }
            }
            catch
            {
                Console.WriteLine("Cannot Load Invoice List!...\n");
                MessageBox.Show("Cannot Load Invoice List!...\n", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtInv_CustID_resultTextbox_TextChanged(object sender, EventArgs e)
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

        private void txtInv_CustID_findButton_Click(object sender, EventArgs e)
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


        /// <summary>
        ///  invoice_service/////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvInvService.Focus();
                invoice_serviceBindingSource.AddNew();
                if (((DataRowView)invoice_serviceBindingSource.Current).IsNew)
                {
                    if (!string.IsNullOrEmpty(lblInvNoHeader.Text))
                        ((DataRowView)invoice_serviceBindingSource.Current).Row.SetField<string>("Inv_No", lblInvNoHeader.Text);
                }
            }
            catch { Console.WriteLine("Cannot AddNew Servicetypes Row!...\n"); }
        }

        private void btnSerFacilities_Click(object sender, EventArgs e)
        {
            try
            {
                new ServicesFacilitiesForm().ShowDialog();
            }
            catch { Console.WriteLine("cannot show Services Facilities Form!..."); }
            loadService_types();
        }

        private void invoice_serviceDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = false;
        }

        private void ServicesTotalCalculation()
        {
            try
            {
                decimal total = 0.00M;
                foreach (DataGridViewRow r in dgvInvService.Rows)
                {
                    total += decimal.Parse(r.Cells["ColumnSerAmount"].Value.ToString());
                }
                lblServiceSubTotal.Text = total.ToString("N2");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Services total calculation failed!...\n" + ex.Message);
            }
        }

        private void dgvInvService_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ServicesTotalCalculation();
        }

        private void dgvInvService_CancelRowEdit(object sender, QuestionEventArgs e)
        {
            ServicesTotalCalculation();
        }

        private void dgvInvService_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ServicesTotalCalculation();
        }

        private void dgvInvService_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            ServicesTotalCalculation();
        }

        private void dgvInvService_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            ServicesTotalCalculation();
        }

        /// <summary>
        ///  invoice_items/////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 
        private void dgvInvItems_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //Console.WriteLine(e.Exception.HResult);
            try
            {
                if (e.Exception.HResult.Equals(-2146232022))
                {
                    MessageBox.Show("This Item is already exist!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("dgvInvItems_DataError::...\n" + ex.Message);
            }
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            try
            {
                dgvInvItems.Focus();
                invoice_itemsBindingSource.AddNew();
                if (((DataRowView)invoice_itemsBindingSource.Current).IsNew)
                {
                    if (!string.IsNullOrEmpty(lblInvNoHeader.Text))
                    {
                        ((DataRowView)invoice_itemsBindingSource.Current).Row.SetField<string>("Inv_No", lblInvNoHeader.Text);
                    }
                }
            }
            catch { Console.WriteLine("Cannot Add New invoice_items Row!...\n"); }
        }

        private void dgvInvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex.Equals(0))
                {
                    if (string.IsNullOrEmpty(lblInvNoHeader.Text))
                    {
                        ItemSelectionForInvoiceDialogBox itemDialog = new ItemSelectionForInvoiceDialogBox();
                        DialogResult res = itemDialog.ShowDialog();
                        if (res.Equals(DialogResult.OK))
                        {
                            ((DataRowView)invoice_itemsBindingSource.Current).Row.SetField<string>("Item_ID", itemDialog.selectedItemID);
                            ((DataRowView)invoice_itemsBindingSource.Current).Row.SetField<string>("Item_Name", itemDialog.selectedItemName);
                            ((DataRowView)invoice_itemsBindingSource.Current).Row.SetField<string>("Category", itemDialog.selectedCategory);
                            ((DataRowView)invoice_itemsBindingSource.Current).Row.SetField<string>("Unit", itemDialog.selectedUnit);
                            ((DataRowView)invoice_itemsBindingSource.Current).Row.SetField<decimal>("UnitPrice", itemDialog.selectedUnitPrice);
                            calLineTotalAmount();
                            dgvInvItems.Refresh();
                        }
                    }
                    else
                    if (!string.IsNullOrEmpty(lblInvNoHeader.Text))
                    {
                        if ((invoice_itemsBindingSource.Current != null) && (((DataRowView)invoice_itemsBindingSource.Current).IsNew))
                        {
                            ItemSelectionForInvoiceDialogBox itemDialog = new ItemSelectionForInvoiceDialogBox();
                            DialogResult res = itemDialog.ShowDialog();
                            if (res.Equals(DialogResult.OK))
                            {
                                ((DataRowView)invoice_itemsBindingSource.Current).Row.SetField<string>("Item_ID", itemDialog.selectedItemID);
                                ((DataRowView)invoice_itemsBindingSource.Current).Row.SetField<string>("Item_Name", itemDialog.selectedItemName);
                                ((DataRowView)invoice_itemsBindingSource.Current).Row.SetField<string>("Category", itemDialog.selectedCategory);
                                ((DataRowView)invoice_itemsBindingSource.Current).Row.SetField<string>("Unit", itemDialog.selectedUnit);
                                ((DataRowView)invoice_itemsBindingSource.Current).Row.SetField<decimal>("UnitPrice", itemDialog.selectedUnitPrice);
                                calLineTotalAmount();
                                ((DataRowView)invoice_itemsBindingSource.Current).EndEdit();
                                dgvInvItems.Refresh();

                                if (addedList != null)
                                {
                                    if (!addedList.Contains(itemDialog.selectedItemID))
                                    {
                                        addedList.Add(itemDialog.selectedItemID);
                                    }
                                }
                                //Console.WriteLine("====================================");
                                //foreach (string item in addedList.ToArray())
                                //{
                                //    Console.WriteLine(item);
                                //}
                                //Console.WriteLine("====================================");
                                //Console.WriteLine("Done Add new row...");
                            }
                        }
                        else
                        if ((dgvInvItems.CurrentRow != null) && (!dgvInvItems.CurrentRow.IsNewRow))
                        {
                            string curItemID = dgvInvItems.CurrentRow.Cells[2].Value.ToString();
                            //Console.WriteLine("CurID : " + curItemID);
                            if (addedList.Contains(curItemID))
                            {
                                ItemSelectionForInvoiceDialogBox itemDialog = new ItemSelectionForInvoiceDialogBox();
                                DialogResult res = itemDialog.ShowDialog();
                                if (res.Equals(DialogResult.OK))
                                {
                                    ((DataRowView)invoice_itemsBindingSource.Current).Row.SetField<string>("Item_ID", itemDialog.selectedItemID);
                                    ((DataRowView)invoice_itemsBindingSource.Current).Row.SetField<string>("Item_Name", itemDialog.selectedItemName);
                                    ((DataRowView)invoice_itemsBindingSource.Current).Row.SetField<string>("Category", itemDialog.selectedCategory);
                                    ((DataRowView)invoice_itemsBindingSource.Current).Row.SetField<string>("Unit", itemDialog.selectedUnit);
                                    ((DataRowView)invoice_itemsBindingSource.Current).Row.SetField<decimal>("UnitPrice", itemDialog.selectedUnitPrice);
                                    calLineTotalAmount();
                                    dgvInvItems.Refresh();
                                    try
                                    {
                                        addedList.Remove(curItemID);
                                        addedList.Add(itemDialog.selectedItemID);
                                    }
                                    catch { Console.WriteLine("Cannot add list!...."); }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot load Item Choser Form!...\n" + ex.Message);
            }
        }

        private void ItemsTotalCalculation()
        {
            try
            {
                decimal total = 0.00M;
                foreach (DataGridViewRow r in dgvInvItems.Rows)
                {
                    total += decimal.Parse(r.Cells["Column_ItemAmount"].Value.ToString());
                }
                lblItemsSubTotal.Text = total.ToString("N2");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Items total calculation failed!...\n" + ex.Message);
            }
        }

        private void dgvInvItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            calLineTotalAmount();
            ItemsTotalCalculation();
        }

        private void dgvInvItems_CancelRowEdit(object sender, QuestionEventArgs e)
        {
            ItemsTotalCalculation();
        }

        private void dgvInvItems_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            ItemsTotalCalculation();
        }

        private void dgvInvItems_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            ItemsTotalCalculation();
        }

        private void dgvInvItems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            calLineTotalAmount();
            ItemsTotalCalculation();
        }


        /// <summary>
        ///  shortcut keys/////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 
        private void addRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInvService.Focused)
            {
                bindingNavigatorAddNewItem_Click(sender, e);
            }
            else if (dgvInvItems.Focused)
            {
                bindingNavigatorAddNewItem1_Click(sender, e);
            }
            else if (dgvInvPayments.Focused)
            {
                btnPaymentAddNew_Click(sender, e);
            }
        }

        /// <summary>
        ///  Totals calculations/////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 
        private void calLineTotalAmount()
        {
            try
            {
                if (dgvInvItems.RowCount > 0)
                {
                    foreach (DataGridViewRow r in dgvInvItems.Rows)
                    {
                        decimal qty = 0.00M;
                        decimal unitPrice = 0.00M;
                        decimal discValue = 0.00M;

                        decimal.TryParse(r.Cells[Column_ItemQty.Name].Value.ToString(), out qty);
                        decimal.TryParse(r.Cells[Column_ItemUnitPrice.Name].Value.ToString(), out unitPrice);
                        decimal.TryParse(r.Cells[Column_ItemDiscountValue.Name].Value.ToString(), out discValue);

                        decimal lineTotal = 0.00M;
                        lineTotal = (qty * unitPrice) - discValue;
                        r.Cells[Column_ItemAmount.Name].Value = lineTotal;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("calLineTotalAmount Failed!...:: \n" + ex.Message); }
        }

        private void calGrandTotalAmount(object sender, EventArgs e)
        {
            try
            {
                decimal serviceSubTotal = 0.00M;
                decimal itemsSubTotal = 0.00M;
                decimal.TryParse(lblServiceSubTotal.Text, out serviceSubTotal);
                decimal.TryParse(lblItemsSubTotal.Text, out itemsSubTotal);

                decimal specDis = nudDiscount.Value;
                decimal grandTotal = (serviceSubTotal + itemsSubTotal) - specDis;
                txtInv_TotalAmount.Text = grandTotal.ToString("N2");
            }
            catch (Exception ex) { Console.WriteLine("calGrandTotalAmount Failed!...:: \n" + ex.Message); }
        }

        private void calBal()
        {
            try
            {
                decimal bal = 0.00M;
                decimal pay = 0.00M;
                decimal.TryParse(txtInv_TotalAmount.Text, out bal);
                if (dgvInvPayments.RowCount > 0)
                {
                    foreach (DataGridViewRow r in dgvInvPayments.Rows)
                    {
                        decimal.TryParse((r.Cells[4].Value != null) ? r.Cells[4].Value.ToString() : "0.00", out pay);
                        bal -= pay;
                    }
                }
                lblInv_PaymentBal.Text = bal.ToString();
            }
            catch (Exception ex) { Console.WriteLine("Cal Bal Ex::\n" + ex); }
        }

        /// <summary>
        ///  Invoice Payments/////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 
        private void btnPaymentAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.Parse(txtInv_TotalAmount.Text) > 0.00M)
                {
                    dgvInvPayments.Focus();
                    GRN.AddPaymentDialogBox addPayment = new GRN.AddPaymentDialogBox(decimal.Parse(lblInv_PaymentBal.Text));
                    DialogResult res = addPayment.ShowDialog();
                    if (res.Equals(DialogResult.OK))
                    {
                        if (string.IsNullOrEmpty(lblInvNoHeader.Text))
                        {
                            senaexminidbDataSet.payments.AddpaymentsRow(string.Empty, "INV", addPayment.PaymentMode.ToString(), addPayment.Amount, addPayment.EntryDate, addPayment.PaidDuePostDate, addPayment.ChequeNo, addPayment.Bank, addPayment.Branch, addPayment.Remarks);
                        }
                        else
                        {
                            senaexminidbDataSet.payments.AddpaymentsRow(lblInvNoHeader.Text, "INV", addPayment.PaymentMode.ToString(), addPayment.Amount, addPayment.EntryDate, addPayment.PaidDuePostDate, addPayment.ChequeNo, addPayment.Bank, addPayment.Branch, addPayment.Remarks);
                        }
                    }
                }
                else
                { MessageBox.Show("Grand Total is Rs.0.00 or less than Rs.0.00! ", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            catch { Console.WriteLine("Cannot Add New Payments Row!...\n"); }
        }

        private void dgvInvPayments_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = false;
        }

        private void txtInv_TotalAmount_TextChanged(object sender, EventArgs e)
        {
            calBal();
        }

        private void dgvInvPayments_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            calBal();
        }

        private void dgvInvPayments_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            calBal();
        }


        /// <summary>
        ///  Main Buttons/////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 
        private void btnSaveOnly_Click(object sender, EventArgs e)
        {
            saveInvoice();
        }

        private void saveInvoice()
        {
            try
            {

                if ((!string.IsNullOrEmpty(txtCustID.TextResult)) && ((dgvInvService.RowCount > 0) || (dgvInvItems.RowCount > 0)) && (dgvInvPayments.RowCount > 0))
                {
                    DialogResult res = MessageBox.Show("Do you want to Save this Invoice? ", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res.Equals(DialogResult.Yes))
                    {
                        if (string.IsNullOrEmpty(lblInvNoHeader.Text))
                        {
                            saveNewInvoice();
                        }
                        else if (!string.IsNullOrEmpty(lblInvNoHeader.Text))
                        {
                            savePreviosGNR();
                        }
                        btnMakeNewInvoice_Click(null, null);
                    }
                }
                else { MessageBox.Show("Please Complete The Invoice!...", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot Save This Invoice!...\n" + ex);
            }
        }

        private void saveNewInvoice()
        {
            try
            {
                string msg_basic = string.Empty;
                string msg_Services = string.Empty;
                string msg_Items = string.Empty;
                string msg_Payments = string.Empty;

                //Invoice basic ........            
                try
                {
                    invoiceTableAdapter.InsertQuery(dtpInvDate.Value, txtJobNo.Text, string.Format("{0} : {1}", curRole, curUser), txtCustID.TextResult, cmbVehicleNo.SelectedValue.ToString(), nudMeter.Value, nudDiscount.Value, decimal.Parse(txtInv_TotalAmount.Text), txtRemarks.Text);
                    msg_basic = "Basic Invoice entries saved SUCCESSFULLY!";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invoice entries inserting Ex::!...\n" + ex);
                    msg_basic = "Basic Invoice entries saving FAILED!";
                }

                int LastMaxID = invoiceTableAdapter.ScalarQuery_LastMaxID().Value;

                //Invoice Services....
                foreach (DataRow row in senaexminidbDataSet.invoice_service.Rows)
                {
                    row.SetField<string>(senaexminidbDataSet.invoice_service.Inv_NoColumn, string.Format("INV-{0}", LastMaxID.ToString()));
                }
                msg_Services = saveServices(null, null);

                //Invoice items.......
                try
                {
                    if (dgvInvItems.RowCount > 0)
                    {
                        int x = 0;
                        foreach (DataGridViewRow Row in dgvInvItems.Rows)
                        {
                            string ItemID = Row.Cells[2].Value.ToString();

                            //Console.WriteLine(string.Format("INV-{0}", LastMaxID.ToString()));
                            //Console.WriteLine(ItemID);
                            //Console.WriteLine(Row.Cells[3].Value.ToString());
                            //Console.WriteLine(Row.Cells[4].Value.ToString());
                            //Console.WriteLine(Row.Cells[5].Value.ToString());
                            //Console.WriteLine(decimal.Parse(Row.Cells[6].Value.ToString(), NumberStyles.Any));
                            //Console.WriteLine(decimal.Parse(Row.Cells[7].Value.ToString(), NumberStyles.Any));
                            //Console.WriteLine(decimal.Parse(Row.Cells[8].Value.ToString(), NumberStyles.Any));
                            //Console.WriteLine(decimal.Parse(Row.Cells[9].Value.ToString(), NumberStyles.Any));
                            //Console.WriteLine(Row.Cells[10].Value.ToString());

                            invoice_itemsTableAdapter.InsertQuery(
                                string.Format("INV-{0}", LastMaxID.ToString()),
                                ItemID,
                                Row.Cells[3].Value.ToString(),
                                Row.Cells[4].Value.ToString(),
                                Row.Cells[5].Value.ToString(),
                                decimal.Parse(Row.Cells[6].Value.ToString()),
                                decimal.Parse(Row.Cells[7].Value.ToString()),
                                decimal.Parse(Row.Cells[8].Value.ToString()),
                                decimal.Parse(Row.Cells[9].Value.ToString()),
                                Row.Cells[10].Value.ToString());
                            stockUpdate((int)commType.Insert, ItemID, 0.00M, decimal.Parse(Row.Cells[6].Value.ToString()));

                            x = (dgvInvItems.RowCount > 0) ? x + 1 : x += 0;
                        }
                        msg_Items = string.Format("Invoice Item list entries {0} of {1} saved SUCCESSFULLY!", x, dgvInvItems.RowCount);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invoice items inserting Ex::!...\n" + ex);
                    msg_Items = "Invoice Item list saving FAILED!";
                }

                //Save Payments.....
                foreach (DataRow row in senaexminidbDataSet.payments.Rows)
                {
                    row.SetField<string>(senaexminidbDataSet.payments.PM_NoColumn, string.Format("INV-{0}", LastMaxID.ToString()));
                }
                msg_Payments = savePayments(null, null);

                MessageBox.Show(string.Format("Invoice Saving Status:\n\n{0}\n{1}\n{2}\n{3}", msg_basic, msg_Services, msg_Items, msg_Payments), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot Save New Invoice!...\n" + ex);
                MessageBox.Show("Invoice Saving Failed!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void savePreviosGNR()
        {
            try
            {
                try
                {
                    string msg_basic = string.Empty;
                    string msg_Services = string.Empty;
                    string msg_Items = string.Empty;
                    string msg_Payments = string.Empty;

                    //update (save) basic Invoice entries...
                    try
                    {
                        string remarksUpdates = (!lblInv_Username.Text.Equals(string.Format("{0} : {1}", curRole, curUser))) ? txtRemarks.Text + " \n***Previous updated by:: " + lblInv_Username.Text : txtRemarks.Text;
                        invoiceTableAdapter.UpdateQuery(dtpInvDate.Value, txtJobNo.Text, string.Format("{0} : {1}", curRole, curUser), txtCustID.TextResult, cmbVehicleNo.SelectedValue.ToString(), nudMeter.Value, nudDiscount.Value, decimal.Parse(txtInv_TotalAmount.Text), txtRemarks.Text, lblInvNoHeader.Text);
                        msg_basic = "Basic Invoice entries saved SUCCESSFULLY!";
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Invoice entries inserting Ex::!...\n" + ex);
                        msg_basic = "Basic Invoice entries saving FAILED!";
                    }

                    //Invoice Services....
                    msg_Services = msg_Services = saveServices(null, null);

                    //insert | update Invoice items...
                    ////try
                    ////{
                    ////    if (dgvInvItems.RowCount > 0)
                    ////    {
                    ////        int x = 0;
                    ////        foreach (DataGridViewRow Row in dgvInvItems.Rows)
                    ////        {
                    ////            try
                    ////            {
                    ////                string ItemID = Row.Cells[2].Value.ToString();

                    ////                decimal totalOldQty = 0.00M;
                    ////                try
                    ////                { totalOldQty = (!invoice_itemsTableAdapter.GetData().FindByInv_NoItem_ID(lblInvNoHeader.Text, ItemID).IsQtyNull()) ? invoice_itemsTableAdapter.GetData().FindByInv_NoItem_ID(lblInvNoHeader.Text, ItemID).Qty : 0.00M; }
                    ////                catch { totalOldQty = 0.00M; }
                    ////                decimal totalNewQty = decimal.Parse(Row.Cells[6].Value.ToString());
                    ////                try
                    ////                {
                    ////                    int i = invoice_itemsTableAdapter.InsertQuery(
                    ////                        lblInvNoHeader.Text,
                    ////                        ItemID,
                    ////                        Row.Cells[3].Value.ToString(),
                    ////                        Row.Cells[4].Value.ToString(),
                    ////                        Row.Cells[5].Value.ToString(),
                    ////                        decimal.Parse(Row.Cells[6].Value.ToString()),
                    ////                        decimal.Parse(Row.Cells[7].Value.ToString()),
                    ////                        decimal.Parse(Row.Cells[8].Value.ToString()),
                    ////                        decimal.Parse(Row.Cells[9].Value.ToString()),
                    ////                        Row.Cells[10].Value.ToString());

                    ////                    stockUpdate((int)commType.Insert, ItemID, 0.00M, totalNewQty);
                    ////                    x = (i > 0) ? x + 1 : x += 0;
                    ////                }
                    ////                catch (MySqlException ex)
                    ////                {
                    ////                    if (ex.Number.Equals(1062))
                    ////                    {
                    ////                        int i = invoice_itemsTableAdapter.UpdateQuery(
                    ////                        ItemID,
                    ////                        Row.Cells[3].Value.ToString(),
                    ////                        Row.Cells[4].Value.ToString(),
                    ////                        Row.Cells[5].Value.ToString(),
                    ////                        decimal.Parse(Row.Cells[6].Value.ToString()),
                    ////                        decimal.Parse(Row.Cells[7].Value.ToString()),
                    ////                        decimal.Parse(Row.Cells[8].Value.ToString()),
                    ////                        decimal.Parse(Row.Cells[9].Value.ToString()),
                    ////                        Row.Cells[10].Value.ToString(),
                    ////                        lblInvNoHeader.Text,
                    ////                        ItemID);

                    ////                        //(ItemID, Row.Cells[2].Value.ToString(), Row.Cells[3].Value.ToString(), decimal.Parse(Row.Cells[4].Value.ToString()), decimal.Parse(Row.Cells[5].Value.ToString()), decimal.Parse(Row.Cells[6].Value.ToString()), decimal.Parse(Row.Cells[7].Value.ToString()), decimal.Parse(Row.Cells[8].Value.ToString()), Row.Cells[9].Value.ToString(), lblGRNHeader.Text, ItemID);
                    ////                        stockUpdate((int)commType.Update, ItemID, totalOldQty, totalNewQty);
                    ////                        x = (i > 0) ? x + 1 : x += 0;
                    ////                    }
                    ////                    else { Console.WriteLine("Invoice items inserting MySqlEx::!...\n" + ex); }
                    ////                }
                    ////            }
                    ////            catch (Exception ex)
                    ////            {
                    ////                Console.WriteLine("Invoice items inserting Ex::!...\n" + ex);
                    ////            }
                    ////        }
                    ////        msg_Items = string.Format("Invoice Item list entries {0} of {1} saved SUCCESSFULLY!", x, dgvInvItems.RowCount);
                    ////    }
                    ////}
                    ////catch (Exception ex)
                    ////{
                    ////    Console.WriteLine("Invoice items inserting Ex::!...\n" + ex);
                    ////    msg_Items = "Invoice Item list saving FAILED!";
                    ////}

                    //Update stock...
                    UpdateStock();
                    //Save invoice_items....
                    msg_Items = saveItems();

                    //Save Payments...
                    msg_Payments = savePayments(null, null);

                    MessageBox.Show(string.Format("Invoice Saving Status:\n\n{0}\n{1}\n{2}\n{3}", msg_basic, msg_Services, msg_Items, msg_Payments), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Cannot Save Previos Invoice!...\n" + ex);
                    MessageBox.Show("Invoice Saving Failed!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot Save Previos Invoice!...\n" + ex);
                MessageBox.Show("Invoice Saving Failed!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string saveItems()
        {
            string msg = string.Empty;
            try
            {
                this.Validate();
                this.invoice_itemsBindingSource.EndEdit();
                int i = invoice_itemsTableAdapter.Update(senaexminidbDataSet.invoice_items);
                if (i > 0)
                    msg = "Invoice Item entries saved SUCCESSFULLY!";
            }
            catch (Exception ex)
            {
                msg = "Invoice Item entries saving FAILED!";
                Console.WriteLine("Invoice Item saving failed!...\n" + ex);
            }
            return msg;
        }

        private string saveServices(object sender, EventArgs e)
        {
            string msg = string.Empty;
            try
            {
                this.Validate();
                this.invoice_serviceBindingSource.EndEdit();
                int i = invoice_serviceTableAdapter.Update(senaexminidbDataSet.invoice_service);
                if (i > 0)
                    msg = "Services & Facilities entries saved SUCCESSFULLY!";
            }
            catch (Exception ex)
            {
                msg = "Services & Facilities entries saving FAILED!";
                Console.WriteLine("Services saving failed!...\n" + ex);
            }
            return msg;
        }

        private string savePayments(object sender, EventArgs e)
        {
            string msg = string.Empty;
            try
            {
                this.Validate();
                this.paymentsBindingSource.EndEdit();
                int i = paymentsTableAdapter.Update(senaexminidbDataSet.payments);
                if (i > 0)
                    msg = "Payments entries saved SUCCESSFULLY!";
            }
            catch (Exception ex)
            {
                msg = "Payments entries saving FAILED!";
                Console.WriteLine("Payments saving failed!...\n" + ex);
            }
            return msg;
        }

        private void stockUpdate(int commType, string ItemID, decimal oldQty, decimal newQty)
        {
            try
            {
                try
                {
                    DataRowCollection rows = itemsTableAdapter.GetDataBy_ItemID(ItemID).Rows;
                    decimal curStock = (rows.Count > 0) ? rows[0].Field<decimal>("Stock") : 0.00M;
                    decimal newStock = 0.00M;
                    switch (commType)
                    {
                        case 0:
                            newStock = curStock - newQty;
                            break;
                        case 1:
                            newStock = curStock + (oldQty - newQty);
                            break;
                        case 2:
                            newStock = curStock + newQty;
                            break;
                        default:
                            break;
                    }
                    itemsTableAdapter.Update_Stock(newStock, ItemID);
                    Console.WriteLine(String.Format("Stock updated:: {0} -> {1}", ItemID, newStock));
                }
                catch (MySqlException ex)
                { Console.WriteLine("Stock updating failed!...\n" + ex); }
            }
            catch (Exception ex)
            { Console.WriteLine("Stock updating failed!...\n" + ex); }
        }

        private void UpdateStock()
        {
            try
            {
                try
                {
                    DataView dataview = new DataView(senaexminidbDataSet.invoice_items);

                    dataview.RowStateFilter = DataViewRowState.Deleted;
                    printview(dataview, "+++++++++++++++++++Deleted++++++++++++++++");
                    for (int i = 0; i < dataview.Count; i++)
                    {
                        //Console.WriteLine(dataview[i][1]);
                        string ItemID = dataview[i][1].ToString();

                        DataRowCollection rows = itemsTableAdapter.GetDataBy_ItemID(ItemID).Rows;

                        decimal curStock = (rows.Count > 0) ? rows[0].Field<decimal>("Stock") : 0.00M;
                        decimal newQty = 0.00M;
                        decimal newStock = 0.00M;
                        decimal.TryParse(dataview[i][5].ToString(), out newQty);
                        newStock = curStock + newQty;
                        itemsTableAdapter.Update_Stock(newStock, ItemID);
                        Console.WriteLine(String.Format("Stock updated:: {0} -> {1} = {2} + {3}", ItemID, newStock, curStock, newQty));
                    }


                    dataview.RowStateFilter = DataViewRowState.Added;
                    printview(dataview, "+++++++++++++++++++Added++++++++++++++++");
                    for (int i = 0; i < dataview.Count; i++)
                    {
                        //Console.WriteLine(dataview[i][1]);
                        string ItemID = dataview[i][1].ToString();

                        DataRowCollection rows = itemsTableAdapter.GetDataBy_ItemID(ItemID).Rows;

                        decimal curStock = (rows.Count > 0) ? rows[0].Field<decimal>("Stock") : 0.00M;
                        decimal newQty = 0.00M;
                        decimal newStock = 0.00M;
                        decimal.TryParse(dataview[i][5].ToString(), out newQty);
                        newStock = curStock - newQty;
                        itemsTableAdapter.Update_Stock(newStock, ItemID);
                        Console.WriteLine(String.Format("Stock updated:: {0} -> {1} = {2} - {3}", ItemID, newStock, curStock, newQty));
                    }


                    dataview.RowStateFilter = DataViewRowState.ModifiedCurrent;
                    printview(dataview, "+++++++++++++++++++ModifiedCurrent++++++++++++++++");
                    for (int i = 0; i < dataview.Count; i++)
                    {
                        //Console.WriteLine(dataview[i][1]);
                        string InvNo = dataview[i][0].ToString();
                        string ItemID = dataview[i][1].ToString();

                        DataRowCollection rows = itemsTableAdapter.GetDataBy_ItemID(ItemID).Rows;

                        decimal curStock = (rows.Count > 0) ? rows[0].Field<decimal>("Stock") : 0.00M;
                        decimal oldQty, newQty, newStock;
                        newQty = newStock = 0.00M;
                        try { oldQty = (!invoice_itemsTableAdapter.GetData().FindByInv_NoItem_ID(InvNo, ItemID).IsQtyNull()) ? invoice_itemsTableAdapter.GetData().FindByInv_NoItem_ID(InvNo, ItemID).Qty : 0.00M; }
                        catch (Exception ex)
                        {
                            oldQty = 0.00M;
                            Console.WriteLine("OldQty Ex::\n" + ex.Message);
                            try
                            {
                                if (dgvInvItems.RowCount > 0)
                                {
                                    foreach (DataGridViewRow r in dgvInvItems.Rows)
                                    {
                                        if (r.Cells[2].Value.ToString().Contains(ItemID))
                                        {
                                            decimal.TryParse(r.Cells[6].Value.ToString(), out oldQty);
                                            Console.WriteLine("Cell contain :: " + ItemID);
                                        }
                                    }
                                }
                            }
                            catch (Exception e)
                            {
                                oldQty = 0.00M;
                                Console.WriteLine("OldQty inner dgv Ex::\n" + e.Message);
                            }
                        }
                        decimal.TryParse(dataview[i][5].ToString(), out newQty);
                        newStock = curStock + (oldQty - newQty);
                        itemsTableAdapter.Update_Stock(newStock, ItemID);
                        Console.WriteLine(String.Format("Stock updated:: {0} -> {1} = {2} + ({3} - {4})", ItemID, newStock, curStock, oldQty, newQty));
                    }

                    dataview.RowStateFilter = DataViewRowState.ModifiedOriginal;
                    printview(dataview, "+++++++++++++++++++ModifiedOriginal++++++++++++++++");

                }
                catch (MySqlException ex)
                { Console.WriteLine("Stock updating failed!...\n" + ex); }
            }
            catch (Exception ex)
            { Console.WriteLine("Stock updating failed!...\n" + ex); }
        }

        private void printview(DataView dv, string label)
        {
            Console.WriteLine("\n" + label);
            for (int i = 0; i < dv.Count; i++)
            {
                Console.WriteLine(dv[i][1]);
            }
        }

        private void EnterKeyDown(object sender, KeyEventArgs e)
        {
            if (((sender as Control).Name.Equals(txtRemarks.Name)) ||
                ((sender as Control).Name.Equals(dgvInvService.Name)) ||
                ((sender as Control).Name.Equals(dgvInvItems.Name)) ||
                ((sender as Control).Name.Equals(dgvInvPayments.Name)))
            {
                if (e.Control)
                {
                    if (e.KeyCode.Equals(Keys.Enter))
                    {
                        this.SelectNextControl(sender as Control, true, true, true, true);
                    }
                }
            }
            else
            {
                if (e.KeyCode.Equals(Keys.Enter))
                {
                    this.SelectNextControl(sender as Control, true, true, true, true);
                }
            }
        }


        private void btnSavePrint_Receipt_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!string.IsNullOrEmpty(txtCustID.TextResult)) && ((dgvInvService.RowCount > 0) || (dgvInvItems.RowCount > 0)) && (dgvInvPayments.RowCount > 0))
                {
                    DialogResult res = MessageBox.Show("Do you want to Save & Print As Receipt this Invoice? ", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res.Equals(DialogResult.Yes))
                    {
                        if (string.IsNullOrEmpty(lblInvNoHeader.Text))
                        {
                            saveNewInvoice();
                            int LastMaxID = invoiceTableAdapter.ScalarQuery_LastMaxID().Value;
                            ReportViewerForm_Invoice RVF = new ReportViewerForm_Invoice(2, "Receipt", string.Format("INV-{0}", LastMaxID.ToString()), txtCustID.TextResult);
                            RVF.ShowDialog();
                            RVF.BringToFront();
                        }
                        else if (!string.IsNullOrEmpty(lblInvNoHeader.Text))
                        {
                            savePreviosGNR();
                            int LastMaxID = invoiceTableAdapter.ScalarQuery_LastMaxID().Value;
                            ReportViewerForm_Invoice RVF = new ReportViewerForm_Invoice(2, "Receipt", lblInvNoHeader.Text, txtCustID.TextResult);
                            RVF.ShowDialog();
                            RVF.BringToFront();
                        }
                        btnMakeNewInvoice_Click(null, null);
                    }
                }
                else { MessageBox.Show("Please Complete The Invoice!...", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot Save & Print As Receipt This Invoice!...\n" + ex);
            }
        }

        private void btnSavePrint_Invoice_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!string.IsNullOrEmpty(txtCustID.TextResult)) && ((dgvInvService.RowCount > 0) || (dgvInvItems.RowCount > 0)) && (dgvInvPayments.RowCount > 0))
                {
                    DialogResult res = MessageBox.Show("Do you want to Save & Print As Invoice this Invoice? ", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res.Equals(DialogResult.Yes))
                    {
                        if (string.IsNullOrEmpty(lblInvNoHeader.Text))
                        {
                            saveNewInvoice();
                            int LastMaxID = invoiceTableAdapter.ScalarQuery_LastMaxID().Value;
                            ReportViewerForm_Invoice RVF = new ReportViewerForm_Invoice(2, "Invoice", string.Format("INV-{0}", LastMaxID.ToString()), txtCustID.TextResult);
                            RVF.ShowDialog();
                            RVF.BringToFront();
                        }
                        else if (!string.IsNullOrEmpty(lblInvNoHeader.Text))
                        {
                            savePreviosGNR();
                            int LastMaxID = invoiceTableAdapter.ScalarQuery_LastMaxID().Value;
                            ReportViewerForm_Invoice RVF = new ReportViewerForm_Invoice(2, "Invoice", lblInvNoHeader.Text, txtCustID.TextResult);
                            RVF.ShowDialog();
                            RVF.BringToFront();
                        }
                        btnMakeNewInvoice_Click(null, null);
                    }
                }
                else { MessageBox.Show("Please Complete The Invoice!...", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot Save & Print As Invoice This Invoice!...\n" + ex);
            }
        }

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(lblInvNoHeader.Text))
                {
                    DialogResult res = MessageBox.Show("Do you want to Delete this Invoice? ", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res.Equals(DialogResult.Yes))
                    {
                        try
                        {
                            if (dgvInvItems.RowCount > 0)
                            {
                                foreach (DataGridViewRow row in dgvInvItems.Rows)
                                {
                                    string ItemID = row.Cells[2].Value.ToString();
                                    stockUpdate((int)commType.Delete, ItemID, 0.00M, decimal.Parse(row.Cells[6].Value.ToString()));
                                }
                            }
                            invoiceTableAdapter.DeleteQuery(lblInvNoHeader.Text);
                            paymentsTableAdapter.DeleteQueryBy_PMNo(lblInvNoHeader.Text);
                            Console.WriteLine("Invoice Deleted!......");
                            MessageBox.Show("Invoice Deleted Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (MySqlException ex)
                        {
                            Console.WriteLine("Invoice Deleting failed!...\n" + ex);
                            MessageBox.Show("Invoice Deleting Failed!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        btnMakeNewInvoice_Click(null, null);
                    }
                }
                else { MessageBox.Show("Please select a Invoice!...\n", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invoice Deleting failed!...\n" + ex);
                MessageBox.Show("Invoice Deleting Failed!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMnuPrintAsReceipt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblInvNoHeader.Text))
            { new ReportViewerForm_Invoice(2, "Receipt", lblInvNoHeader.Text, txtCustID.TextResult).ShowDialog(); }
        }

        private void btnMnuPrintAsInvoice_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblInvNoHeader.Text))
            { new ReportViewerForm_Invoice(2, "Invoice", lblInvNoHeader.Text, txtCustID.TextResult).ShowDialog(); }
        }

        private void btnMnuPrintAsCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblInvNoHeader.Text))
            { new ReportViewerForm_Invoice(2, "Copy (Invoice | Receipt)", lblInvNoHeader.Text, txtCustID.TextResult).ShowDialog(); }
        }

       





        ////////////////////////////////////End of the class///////////////////////////////////////
    }
}
