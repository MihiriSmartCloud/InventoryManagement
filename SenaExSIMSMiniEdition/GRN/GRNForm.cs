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

namespace SenaExSIMSMiniEdition.GRN
{
    internal partial class GRNForm : Form
    {
        string curRole = string.Empty;
        string curUser = string.Empty;
        enum commType { Insert, Update, Delete };
        List<string[,]> lstRemove = new List<string[,]>();

        public GRNForm(string curRole, string curUser)
        {
            InitializeComponent();

            this.curRole = curRole;
            this.curUser = curUser;
            lblGRN_Username.Text = string.Format("{0} : {1}", curRole, curUser);
        }

        /////////////////////////////////////////////////////////////////////////////////////////

        private void loadAllGRN()
        {
            try
            {
                this.grnTableAdapter.Fill_InDesOrder(this.senaexminidbDataSet.grn);
            }
            catch (Exception ex)
            {
                Console.WriteLine("GRN List Loading Failed!...\n" + ex.ToString());
                MessageBox.Show("GRN List Loading Failed!...\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void loadGRNDetails()
        {
            try
            {
                this.grn_detailsTableAdapter.Fill(this.senaexminidbDataSet.grn_details);
            }
            catch (Exception ex)
            {
                Console.WriteLine("GRN Details List Loading Failed!...\n" + ex.ToString());
                MessageBox.Show("GRN Details List Loading Failed!...\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadSupplierList()
        {
            try
            {
                this.suppliersTableAdapter.Fill(this.senaexminidbDataSet.suppliers);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Supplier List Loading Failed!...\n" + ex.ToString());
            }
        }

        private void loadItemList(object sender, EventArgs e)
        {
            try
            {
                string fltrItemID = (!string.IsNullOrEmpty(txtItem_ID.TextResult)) ? txtItem_ID.TextResult : string.Empty;
                this.itemsTableAdapter.FillBy_ItemID(this.senaexminidbDataSet.items, fltrItemID);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Item List Loading Failed!...\n" + ex.ToString());
            }
        }

        private void loadPaymentList(object sender, EventArgs e)
        {
            try
            {
                this.paymentsTableAdapter.FillBy_PMNo(this.senaexminidbDataSet.payments, lblGRNHeader.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Payment List Loading Failed!...\n" + ex.ToString());
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////

        private void GRNForm_Load(object sender, EventArgs e)
        {
            loadAllGRN();
            loadGRNDetails();
            loadSupplierList();
            //loadItemList(sender, e);
            loadPaymentList(sender, e);

        }

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 

        private void makeNewGRN()
        {
            try
            {
                lblGRNHeader.Text = "New GRN";
                lblGRNHeader.Text = string.Empty;
                lblGRN_Username.Text = string.Format("{0} : {1}", curRole, curUser);
                txtGRN_SupID.TextResult = string.Empty;
                txtGRN_SupName.Clear();
                dtpGRN_Date.Value = dtpGRN_RiceivedDate.Value = DateTime.Today;
                txtGRN_PONo.Clear();
                txtGRN_InvNo.Clear();
                //
                nudGRN_SpecDisc.Value = 0.00M;
                lblGRN_TotalDisc.Text = lblGRN_TotalAmount.Text = "0.00";
                txtGRN_Remarks.Clear();
                //
                ItemLineReset();
                //
                lstRemove.Clear();
                //
                dgvGrnDetails.Rows.Clear();
            }
            catch { Console.WriteLine("MakeNewGRN Failed!"); }
        }

        private void btnMakeNewGRN_Click(object sender, EventArgs e)
        {
            makeNewGRN();
            txtSupID_findButton_Click(null, null);
        }

        private void btnLoadPrevGRN_Click(object sender, EventArgs e)
        {
            try
            {
                GRNListForm selPrevGRN = new GRNListForm();
                DialogResult res = selPrevGRN.ShowDialog();
                if (res.Equals(DialogResult.OK))
                {
                    lblGRNHeader.Text = selPrevGRN.selectedGRN;
                    loadPrevGRNData();
                    lstRemove.Clear();
                }
            }
            catch
            {
                Console.WriteLine("Cannot Load GRN List!...\n");
                MessageBox.Show("Cannot Load GRN List!...\n", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewGRNList_Click(object sender, EventArgs e)
        {
            try
            {
                new GRNListForm(btnViewGRNList.Text).ShowDialog();
            }
            catch
            {
                Console.WriteLine("Cannot Load GRN List!...\n");
                MessageBox.Show("Cannot Load GRN List!...\n", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void loadPrevGRNData()
        {
            try
            {
                //load Grn basic entries...                
                lblGRN_Username.Text = grnTableAdapter.GetDataBy_GRNNo(lblGRNHeader.Text)[0].Username;
                txtGRN_SupID.TextResult = grnTableAdapter.GetDataBy_GRNNo(lblGRNHeader.Text)[0].Sup_ID;
                txtGRN_SupName.Text = suppliersTableAdapter.GetData().FindBySup_ID(txtGRN_SupID.TextResult).Sup_Name;
                dtpGRN_Date.Value = grnTableAdapter.GetDataBy_GRNNo(lblGRNHeader.Text)[0].GRN_Date;
                dtpGRN_RiceivedDate.Value = grnTableAdapter.GetDataBy_GRNNo(lblGRNHeader.Text)[0].Received_Date;
                txtGRN_PONo.Text = grnTableAdapter.GetDataBy_GRNNo(lblGRNHeader.Text)[0].PO_No;
                txtGRN_InvNo.Text = grnTableAdapter.GetDataBy_GRNNo(lblGRNHeader.Text)[0].Invoice_No;

                //load Grn item list...
                int rowCount = grn_detailsTableAdapter.GetDataBy_GRNNo(lblGRNHeader.Text).Rows.Count;
                if (rowCount > 0)
                {
                    dgvGrnDetails.Rows.Clear();
                    foreach (DataRow Row in grn_detailsTableAdapter.GetDataBy_GRNNo(lblGRNHeader.Text).Rows)
                    {
                        List<object> lst = Row.ItemArray.ToList<object>();
                        lst.Insert(2, itemsTableAdapter.GetData().FindByItem_ID(Row.ItemArray[1].ToString()).Item_Name);
                        dgvGrnDetails.Rows.Add(lst.ToArray());
                    }
                }
                else { dgvGrnDetails.Rows.Clear(); }

                //load Grn totals...
                nudGRN_SpecDisc.Value = grnTableAdapter.GetDataBy_GRNNo(lblGRNHeader.Text)[0].Special_Discount;
                lblGRN_TotalDisc.Text = grnTableAdapter.GetDataBy_GRNNo(lblGRNHeader.Text)[0].Total_Discount.ToString();
                lblGRN_TotalAmount.Text = grnTableAdapter.GetDataBy_GRNNo(lblGRNHeader.Text)[0].Total_Amount.ToString();
                txtGRN_Remarks.Text = grnTableAdapter.GetDataBy_GRNNo(lblGRNHeader.Text)[0].Remarks;

            }
            catch { Console.WriteLine("Cannot Load GRN List!...\n"); }
        }


        /// <summary>
        /// //////////////GRN Entries/////////////////////////////////////////////////////////////
        /// </summary>
        /// 

        private void txtSupID_findButton_Click(object sender, EventArgs e)
        {
            try
            {
                SupplierListDialogBox supListForm = new SupplierListDialogBox();
                DialogResult res = supListForm.ShowDialog();
                if (res.Equals(DialogResult.OK))
                {
                    string oldSupID = txtGRN_SupID.TextResult;
                    if (oldSupID.Equals(supListForm.selectedSupID))
                    {
                        txtGRN_SupID.TextResult = supListForm.selectedSupID;
                        txtGRN_SupName.Text = supListForm.selectedSupName;
                    }
                    else if (!oldSupID.Equals(supListForm.selectedSupID))
                    {
                        if (dgvGrnDetails.RowCount > 0)
                        {
                            DialogResult msg = MessageBox.Show(string.Format("If you want to continue this GRN with {0}? \nYou must clear the item list, first! \n\nDo you want continue....?", supListForm.selectedSupID), "Confirmation?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (msg.Equals(DialogResult.Yes))
                            {
                                txtGRN_SupID.TextResult = supListForm.selectedSupID;
                                txtGRN_SupName.Text = supListForm.selectedSupName;

                                dgvGrnDetails.Rows.Clear();
                            }
                        }
                        else
                        {
                            txtGRN_SupID.TextResult = supListForm.selectedSupID;
                            txtGRN_SupName.Text = supListForm.selectedSupName;
                        }
                    }
                    ItemLineReset();
                    SelectNextControl(txtGRN_SupID, true, true, true, true);
                }
            }
            catch
            {
                Console.WriteLine("Cannot Load Supplier!...\n");
                MessageBox.Show("Cannot Load Supplier!...\n", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void EnterKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                this.SelectNextControl(sender as Control, true, true, true, true);
            }
        }

        // <summary>
        /// //////////////Item panel////////////////////
        /// </summary>
        ///               

        private void calLineTotalAmount(object sender, EventArgs e)
        {
            try
            {
                nudItem_DiscountValue.Maximum = nudItem_UnitPrice.Value;
                if (nudItem_DiscountValue.Value > nudItem_UnitPrice.Value)
                { nudItem_DiscountValue.Value = nudItem_UnitPrice.Value; }

                decimal qty = nudItem_QTY.Value;
                decimal unitPrice = nudItem_UnitPrice.Value;
                decimal discValue = nudItem_DiscountValue.Value;
                decimal lineTotal = 0.00M;
                lineTotal = (qty * unitPrice) - discValue;
                lblItem_Amount.Text = lineTotal.ToString();
            }
            catch { Console.WriteLine("calLineTotalAmount Failed!..."); }
        }

        private void calTotalDiscount(object sender, EventArgs e)
        {
            try
            {
                decimal linesDisc = 0.00M;
                decimal specDisc = nudGRN_SpecDisc.Value;
                decimal totalDisc = 0.00M;
                if (dgvGrnDetails.RowCount > 0)
                {
                    foreach (DataGridViewRow row in dgvGrnDetails.Rows)
                    {
                        linesDisc += Convert.ToDecimal(row.Cells[7].Value);
                    }
                }
                totalDisc = linesDisc + specDisc;
                lblGRN_TotalDisc.Text = totalDisc.ToString();
            }
            catch { Console.WriteLine("calTotalDiscount Failed!..."); }
        }

        private void calGRNTotalAmount(object sender, EventArgs e)
        {
            try
            {
                decimal linesAmt = 0.00M;
                decimal specDisc = nudGRN_SpecDisc.Value;
                decimal totalAmt = 0.00M;
                if (dgvGrnDetails.RowCount > 0)
                {
                    foreach (DataGridViewRow row in dgvGrnDetails.Rows)
                    {
                        linesAmt += Convert.ToDecimal(row.Cells[8].Value);
                    }
                }
                totalAmt = linesAmt - specDisc;
                lblGRN_TotalAmount.Text = totalAmt.ToString();
            }
            catch { Console.WriteLine("calLineTotalAmount Failed!..."); }
        }



        private void dgvGrnDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 7) { calTotalDiscount(sender, e); }
            //if (e.ColumnIndex == 8) { calGRNTotalAmount(sender, e); }
            calTotalDiscount(sender, e);
            calGRNTotalAmount(sender, e);
        }

        private void dgvGrnDetails_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            calTotalDiscount(sender, e);
            calGRNTotalAmount(sender, e);
        }

        private void nudGRN_SpecDisc_ValueChanged(object sender, EventArgs e)
        {
            calTotalDiscount(sender, e);
            calGRNTotalAmount(sender, e);
        }


        private void ItemLineReset()
        {
            try
            {
                txtItem_ID.TextResult = string.Empty;
                txtItem_Name.Clear();
                cmbItem_Unit.SelectedIndex = -1;
                nudItem_QTY.Value = nudItem_FreeItem.Value = nudItem_UnitPrice.Value = nudItem_DiscountValue.Value = 0.00M;
                lblItem_Amount.Text = "0.00";
                txtItem_Remarks.Clear();
            }
            catch { Console.WriteLine("Item Line Reset Failed!"); }
        }

        private void btnItemReset_Click(object sender, EventArgs e)
        {
            ItemLineReset();
            txtItem_ID.setFocusFindButton();
        }

        private void NumericUpDown_foucusEnterSelect(object sender, EventArgs e)
        {
            NumericUpDown curNud = sender as NumericUpDown;
            curNud.Select(0, curNud.Value.ToString().Length);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

            try
            {
                bool hasItemID = false;
                int rowIndex = -1;
                if (!string.IsNullOrEmpty(txtItem_ID.TextResult))
                {
                    foreach (DataGridViewRow row in dgvGrnDetails.Rows)
                    {
                        if (hasItemID = row.Cells[1].Value.ToString().Equals(txtItem_ID.TextResult))
                        {
                            rowIndex = row.Index;
                            break;
                        }
                    }
                    Console.WriteLine(hasItemID);

                    if (hasItemID == false)
                    {
                        object[] dr = new object[] { null, txtItem_ID.TextResult, txtItem_Name.Text, cmbItem_Unit.SelectedItem, nudItem_QTY.Value, nudItem_FreeItem.Value, nudItem_UnitPrice.Value, nudItem_DiscountValue.Value, decimal.Parse(lblItem_Amount.Text), txtItem_Remarks.Text };
                        dgvGrnDetails.Rows.Add(dr);
                    }
                    else
                    {
                        DialogResult res = MessageBox.Show(string.Format("Do you want to REPLACE this entry to {0}? ", txtItem_ID.TextResult), "Confirm?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        if (res.Equals(DialogResult.Yes))
                        {
                            object[] dr = new object[] { null, txtItem_ID.TextResult, txtItem_Name.Text, cmbItem_Unit.SelectedItem, nudItem_QTY.Value, nudItem_FreeItem.Value, nudItem_UnitPrice.Value, nudItem_DiscountValue.Value, decimal.Parse(lblItem_Amount.Text), txtItem_Remarks.Text };
                            dgvGrnDetails.Rows[rowIndex].SetValues(dr);
                        }
                        else if (res.Equals(DialogResult.No))
                        {
                            decimal oldQTY = 0.00M;
                            decimal.TryParse(dgvGrnDetails.Rows[rowIndex].Cells[4].Value.ToString(), out oldQTY);
                            decimal oldFI = 0.00M;
                            decimal.TryParse(dgvGrnDetails.Rows[rowIndex].Cells[5].Value.ToString(), out oldFI);
                            decimal oldUP = 0.00M;
                            decimal.TryParse(dgvGrnDetails.Rows[rowIndex].Cells[6].Value.ToString(), out oldUP);
                            decimal oldDV = 0.00M;
                            decimal.TryParse(dgvGrnDetails.Rows[rowIndex].Cells[7].Value.ToString(), out oldDV);
                            decimal oldAMT = 0.00M;
                            decimal.TryParse(dgvGrnDetails.Rows[rowIndex].Cells[8].Value.ToString(), out oldAMT);

                            decimal newQTY = 0.00M;
                            decimal.TryParse(nudItem_QTY.Value.ToString(), out newQTY);
                            decimal newFI = 0.00M;
                            decimal.TryParse(nudItem_FreeItem.Value.ToString(), out newFI);
                            decimal newUP = 0.00M;
                            decimal.TryParse(nudItem_UnitPrice.Value.ToString(), out newUP);
                            decimal newDV = 0.00M;
                            decimal.TryParse(nudItem_DiscountValue.Value.ToString(), out newDV);
                            decimal newAMT = 0.00M;
                            decimal.TryParse(lblItem_Amount.Text, out newAMT);

                            object[] dr = new object[] { null, txtItem_ID.TextResult, txtItem_Name.Text, cmbItem_Unit.SelectedItem, (oldQTY + newQTY), (oldFI + newFI), (oldUP + newUP), (oldDV + newDV), (oldAMT + newAMT), txtItem_Remarks.Text };
                            dgvGrnDetails.Rows[rowIndex].SetValues(dr);
                        }
                    }
                }
                else { MessageBox.Show("Please Select Item!...", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

                //
                calTotalDiscount(sender, e);
                calGRNTotalAmount(sender, e);
                //
                btnItemReset_Click(sender, e);
                txtItem_ID.setFocusFindButton();
            }
            catch
            {
                Console.WriteLine("Cannot Add Item!...\n");
                MessageBox.Show("Cannot Add Item!...\n", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvGrnDetails_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex.Equals(0))
                {
                    if ((dgvGrnDetails.RowCount > 0) && (dgvGrnDetails.SelectedRows.Count > 0))
                    {
                        decimal totalQty = decimal.Add(decimal.Parse(dgvGrnDetails.SelectedRows[0].Cells[4].Value.ToString()), decimal.Parse(dgvGrnDetails.SelectedRows[0].Cells[5].Value.ToString()));
                        Console.WriteLine(totalQty);
                        lstRemove.Add(new string[,] { { dgvGrnDetails.SelectedRows[0].Cells[1].Value.ToString(), totalQty.ToString() } });

                        /////////////////
                        dgvGrnDetails.Rows.RemoveAt(dgvGrnDetails.SelectedRows[0].Index);
                    }
                }
                calTotalDiscount(sender, e);
                calGRNTotalAmount(sender, e);
            }
            catch
            { Console.WriteLine(string.Format("Item remove failed!...")); }
        }

        private void dgvGrnDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!e.ColumnIndex.Equals(0))
                {
                    if ((dgvGrnDetails.RowCount > 0) && (dgvGrnDetails.SelectedRows.Count > 0))
                    {
                        txtItem_ID.TextResult = dgvGrnDetails.SelectedRows[0].Cells[1].Value.ToString();
                        txtItem_Name.Text = dgvGrnDetails.SelectedRows[0].Cells[2].Value.ToString();
                        cmbItem_Unit.SelectedItem = dgvGrnDetails.SelectedRows[0].Cells[3].Value;
                        nudItem_QTY.Value = decimal.Parse(dgvGrnDetails.SelectedRows[0].Cells[4].Value.ToString());
                        nudItem_FreeItem.Value = decimal.Parse(dgvGrnDetails.SelectedRows[0].Cells[5].Value.ToString());
                        nudItem_UnitPrice.Value = decimal.Parse(dgvGrnDetails.SelectedRows[0].Cells[6].Value.ToString());
                        nudItem_DiscountValue.Value = decimal.Parse(dgvGrnDetails.SelectedRows[0].Cells[7].Value.ToString());
                        lblItem_Amount.Text = decimal.Parse(dgvGrnDetails.SelectedRows[0].Cells[8].Value.ToString()).ToString();
                        txtItem_Remarks.Text = dgvGrnDetails.SelectedRows[0].Cells[9].Value.ToString();
                    }
                }
                calTotalDiscount(sender, e);
                calGRNTotalAmount(sender, e);
            }
            catch
            { Console.WriteLine(string.Format("Item edit failed!...")); }
        }

        private void txtItem_ID_findButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtGRN_SupID.TextResult))
                {
                    ItemSelectionDialogBox itemListForm = new ItemSelectionDialogBox(txtGRN_SupID.TextResult);
                    DialogResult res = itemListForm.ShowDialog();
                    if (res.Equals(DialogResult.OK))
                    {
                        txtItem_ID.TextResult = itemListForm.selectedItemID;
                        txtItem_Name.Text = itemListForm.selectedItemName;

                        SelectNextControl(txtItem_ID, true, true, true, true);
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Supplier, First!...", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtSupID_findButton_Click(sender, e);
                    if (!string.IsNullOrEmpty(txtGRN_SupID.TextResult))
                    {
                        ItemSelectionDialogBox itemListForm = new ItemSelectionDialogBox(txtGRN_SupID.TextResult);
                        DialogResult res = itemListForm.ShowDialog();
                        if (res.Equals(DialogResult.OK))
                        {
                            txtItem_ID.TextResult = itemListForm.selectedItemID;
                            txtItem_Name.Text = itemListForm.selectedItemName;

                            SelectNextControl(txtItem_ID, true, true, true, true);
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Cannot Load Item!...\n");
                MessageBox.Show("Cannot Load Item!...\n");
            }
        }

        private void txtItem_ID_resultTextbox_TextChanged(object sender, EventArgs e)
        {
            loadItemList(sender, e);
        }

        /// <summary>
        /// //Process buttons...
        /// </summary>
        /// 
        private void btnDeleteGRN_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(lblGRNHeader.Text))
                {
                    DialogResult res = MessageBox.Show("Do you want to Delete this GRN? ", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res.Equals(DialogResult.Yes))
                    {
                        try
                        {
                            if (dgvGrnDetails.RowCount > 0)
                            {
                                foreach (DataGridViewRow row in dgvGrnDetails.Rows)
                                {
                                    decimal totalQty = decimal.Add(decimal.Parse(row.Cells[4].Value.ToString()), decimal.Parse(row.Cells[5].Value.ToString()));
                                    stockUpdate((int)commType.Delete, row.Cells[1].Value.ToString(), 0.00M, totalQty);
                                }
                            }

                            grnTableAdapter.DeleteQuery(lblGRNHeader.Text);
                            paymentsTableAdapter.DeleteQueryBy_PMNo(lblGRNHeader.Text);
                            Console.WriteLine("GRN Deleted!......");
                            MessageBox.Show("GRN Deleted Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (MySqlException ex)
                        {
                            Console.WriteLine("GRN Deleting failed!...\n" + ex);
                            MessageBox.Show("GRN Deleting Failed!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        makeNewGRN();
                    }
                }
                else { MessageBox.Show("Please select a GRN!...\n", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GRN Deleting failed!...\n" + ex);
                MessageBox.Show("GRN Deleting Failed!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGRNSave_Click(object sender, EventArgs e)
        {
            saveGRN();
        }

        private void btnSavePrint_Click(object sender, EventArgs e)
        {
            string supID = txtGRN_SupID.TextResult;
            try
            {
                if ((!string.IsNullOrEmpty(txtGRN_SupID.TextResult)) && (dgvGrnDetails.RowCount > 0) && (dgvPayments.RowCount > 0))
                {
                    DialogResult res = MessageBox.Show("Do you want to Save this GRN? ", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res.Equals(DialogResult.Yes))
                    {
                        if (string.IsNullOrEmpty(lblGRNHeader.Text))
                        {
                            saveNewGNR();
                            int LastMaxID = grnTableAdapter.ScalarQuery_LastMaxID().Value;
                            string GRNno = string.Format("GRN-{0}", LastMaxID.ToString());
                            ReportViewerForm_GRN RVF = new ReportViewerForm_GRN(2, GRNno, supID);
                            RVF.ShowDialog();
                            RVF.BringToFront();
                        }
                        else if (!string.IsNullOrEmpty(lblGRNHeader.Text))
                        {
                            savePreviosGNR();
                            ReportViewerForm_GRN RVF = new ReportViewerForm_GRN(2, lblGRNHeader.Text, supID);
                            RVF.ShowDialog();
                            RVF.BringToFront();
                        }
                        makeNewGRN();                        
                    }
                }
                else { MessageBox.Show("Please Complete The GRN!...\n", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot Save & Print This GRN!...\n" + ex);
                //MessageBox.Show("Cannot Save & Print This GRN!...\n", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblGRNHeader.Text))
            { new ReportViewerForm_GRN(2, lblGRNHeader.Text, txtGRN_SupID.TextResult).ShowDialog(); }
        }
        
        private void saveGRN()
        {
            try
            {

                if ((!string.IsNullOrEmpty(txtGRN_SupID.TextResult)) && (dgvGrnDetails.RowCount > 0) && (dgvPayments.RowCount > 0))
                {
                    DialogResult res = MessageBox.Show("Do you want to Save this GRN? ", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res.Equals(DialogResult.Yes))
                    {
                        if (string.IsNullOrEmpty(lblGRNHeader.Text))
                        {
                            saveNewGNR();
                        }
                        else if (!string.IsNullOrEmpty(lblGRNHeader.Text))
                        {
                            savePreviosGNR();
                        }
                        makeNewGRN();
                    }
                }
                else { MessageBox.Show("Please Complete The GRN!...\n", "Alert!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot Save This GRN!...\n" + ex);
                //MessageBox.Show("Cannot Save This GRN!...\n", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveNewGNR()
        {
            try
            {
                string msg1 = string.Empty;
                string msg2 = string.Empty;
                //grn basic ........            
                try
                {
                    grnTableAdapter.InsertQuery(dtpGRN_Date.Value, dtpGRN_RiceivedDate.Value, string.Format("{0} : {1}", curRole, curUser), txtGRN_SupID.TextResult, txtGRN_PONo.Text, txtGRN_InvNo.Text, nudGRN_SpecDisc.Value, decimal.Parse(lblGRN_TotalDisc.Text), decimal.Parse(lblGRN_TotalAmount.Text), txtGRN_Remarks.Text);
                    msg1 = "Basic GRN entries saved SUCCESSFULLY!";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Grn entries inserting Ex::!...\n" + ex);
                    msg1 = "Basic GRN entries saving FAILED!";
                }

                //grn items.......
                int LastMaxID = grnTableAdapter.ScalarQuery_LastMaxID().Value;
                try
                {
                    if (dgvGrnDetails.RowCount > 0)
                    {
                        int x = 0;
                        foreach (DataGridViewRow Row in dgvGrnDetails.Rows)
                        {
                            decimal totalNewQty = decimal.Add(decimal.Parse(Row.Cells[4].Value.ToString()), decimal.Parse(Row.Cells[5].Value.ToString()));
                            string ItemID = Row.Cells[1].Value.ToString();

                            grn_detailsTableAdapter.InsertQuery(string.Format("GRN-{0}", LastMaxID.ToString()), ItemID, Row.Cells[2].Value.ToString(), Row.Cells[3].Value.ToString(), decimal.Parse(Row.Cells[4].Value.ToString()), decimal.Parse(Row.Cells[5].Value.ToString()), decimal.Parse(Row.Cells[6].Value.ToString()), decimal.Parse(Row.Cells[7].Value.ToString()), decimal.Parse(Row.Cells[8].Value.ToString()), Row.Cells[9].Value.ToString());
                            stockUpdate((int)commType.Insert, ItemID, 0.00M, totalNewQty);

                            x = (dgvGrnDetails.RowCount > 0) ? x + 1 : x += 0;
                        }
                        msg2 = string.Format("Item list entries {0} of {1} saved SUCCESSFULLY!", x, dgvGrnDetails.RowCount);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Grn Details table items inserting Ex::!...\n" + ex);
                    msg2 = "Item list saving FAILED!";
                }

                //Save Payments.....
                foreach (DataRow row in senaexminidbDataSet.payments.Rows)
                {
                    row.SetField<string>(senaexminidbDataSet.payments.PM_NoColumn, string.Format("GRN-{0}", LastMaxID.ToString()));
                }
                savePayments(null, null);

                MessageBox.Show(string.Format("GRN Saving Status:\n\n{0}\n{1}", msg1, msg2), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot Save New GRN!...\n" + ex);
                MessageBox.Show("GRN Saving Failed!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void savePreviosGNR()
        {
            try
            {
                try
                {
                    string msg0 = string.Empty;
                    string msg1 = string.Empty;
                    string msg2 = string.Empty;

                    //remove grn items...
                    msg0 = removeGRNItems();

                    //update (save) basic grn entries...
                    try
                    {
                        string remarksUpdates = (!lblGRN_Username.Text.Equals(string.Format("{0} : {1}", curRole, curUser))) ? txtGRN_Remarks.Text + " \n***Previous updated by:: " + lblGRN_Username.Text : txtGRN_Remarks.Text;
                        grnTableAdapter.UpdateQuery(dtpGRN_Date.Value, dtpGRN_RiceivedDate.Value, string.Format("{0} : {1}", curRole, curUser), txtGRN_SupID.TextResult, txtGRN_PONo.Text, txtGRN_InvNo.Text, nudGRN_SpecDisc.Value, decimal.Parse(lblGRN_TotalDisc.Text), decimal.Parse(lblGRN_TotalAmount.Text), remarksUpdates, lblGRNHeader.Text);
                        msg1 = "Basic GRN entries saved SUCCESSFULLY!";
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Grn entries inserting Ex::!...\n" + ex);
                        msg1 = "Basic GRN entries saving FAILED!";
                    }

                    //insert | update grn items...
                    try
                    {
                        if (dgvGrnDetails.RowCount > 0)
                        {
                            int x = 0;
                            foreach (DataGridViewRow Row in dgvGrnDetails.Rows)
                            {
                                try
                                {
                                    string ItemID = Row.Cells[1].Value.ToString();

                                    decimal totalOldQty = 0.00M;
                                    try
                                    { totalOldQty = grn_detailsTableAdapter.ScalarQuery_getTotalQtyForStock(lblGRNHeader.Text, ItemID).HasValue ? grn_detailsTableAdapter.ScalarQuery_getTotalQtyForStock(lblGRNHeader.Text, ItemID).Value : 0.00M; }
                                    catch { totalOldQty = 0.00M; }
                                    decimal totalNewQty = decimal.Add(decimal.Parse(Row.Cells[4].Value.ToString()), decimal.Parse(Row.Cells[5].Value.ToString()));
                                    try
                                    {
                                        int i = grn_detailsTableAdapter.InsertQuery(lblGRNHeader.Text, ItemID, Row.Cells[2].Value.ToString(), Row.Cells[3].Value.ToString(), decimal.Parse(Row.Cells[4].Value.ToString()), decimal.Parse(Row.Cells[5].Value.ToString()), decimal.Parse(Row.Cells[6].Value.ToString()), decimal.Parse(Row.Cells[7].Value.ToString()), decimal.Parse(Row.Cells[8].Value.ToString()), Row.Cells[9].Value.ToString());
                                        stockUpdate((int)commType.Insert, ItemID, 0.00M, totalNewQty);
                                        x = (i > 0) ? x + 1 : x += 0;
                                    }
                                    catch (MySqlException ex)
                                    {
                                        if (ex.Number.Equals(1062))
                                        {
                                            int i = grn_detailsTableAdapter.UpdateQuery(ItemID, Row.Cells[2].Value.ToString(), Row.Cells[3].Value.ToString(), decimal.Parse(Row.Cells[4].Value.ToString()), decimal.Parse(Row.Cells[5].Value.ToString()), decimal.Parse(Row.Cells[6].Value.ToString()), decimal.Parse(Row.Cells[7].Value.ToString()), decimal.Parse(Row.Cells[8].Value.ToString()), Row.Cells[9].Value.ToString(), lblGRNHeader.Text, ItemID);
                                            stockUpdate((int)commType.Update, ItemID, totalOldQty, totalNewQty);
                                            x = (i > 0) ? x + 1 : x += 0;
                                        }
                                        else { Console.WriteLine("Grn Details table items inserting MySqlEx::!...\n" + ex); }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Grn Details table items inserting Ex::!...\n" + ex);
                                }
                            }
                            msg2 = string.Format("Item list entries {0} of {1} saved SUCCESSFULLY!", x, dgvGrnDetails.RowCount);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Grn Details table items inserting Ex::!...\n" + ex);
                        msg2 = "Item list saving FAILED!";
                    }

                    //
                    savePayments(null, null);
                    MessageBox.Show(string.Format("GRN Saving Status:\n\n{0}\n{1}\n{2}", msg0, msg1, msg2), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Cannot Save Previos GRN!...\n" + ex);
                    MessageBox.Show("GRN Saving Failed!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot Save Previos GRN!...\n" + ex);
                MessageBox.Show("GRN Saving Failed!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string removeGRNItems()
        {
            string msg = string.Empty;
            try
            {
                if (lstRemove.Count > 0)
                {
                    int x = 0;
                    foreach (string[,] item in lstRemove.ToArray())
                    {
                        //Console.WriteLine("Removing item... :: " + item[0, 0].ToString());
                        string itemID = item[0, 0].ToString();
                        int i = grn_detailsTableAdapter.DeleteQuery(lblGRNHeader.Text, itemID);
                        //Console.WriteLine("Removed... :: " + i + " :: " + item[0, 0].ToString());
                        stockUpdate((int)commType.Delete, itemID, 0.00M, decimal.Parse(item[0, 1].ToString()));
                        x = (i > 0) ? x + 1 : x += 0;
                    }
                    msg = string.Format("Removed {0} of {1} items!...", x, lstRemove.Count);
                }
            }
            catch (Exception ex)
            {
                msg = "Some GRN item(s) removing failed!...";
                Console.WriteLine("Some GRN item(s) removing failed!...\n" + ex);
            }
            lstRemove.Clear();
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
                            newStock = curStock + newQty;
                            break;
                        case 1:
                            newStock = curStock - (oldQty - newQty);
                            break;
                        case 2:
                            newStock = curStock - newQty;
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


        /// <summary>
        /// //Payments...
        /// </summary>
        /// 

        private void lblGRNHeader_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.paymentsTableAdapter.FillBy_PMNo(this.senaexminidbDataSet.payments, lblGRNHeader.Text);
            }
            catch (Exception ex)
            { Console.WriteLine("lblGRNHeader TextChanged failed!...\n" + ex); }
            btnDeleteGRN.Enabled = btnPrint.Enabled = (string.IsNullOrEmpty(lblGRNHeader.Text)) ? false : true;
        }

        private void btnPayment_AddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.Parse(lblGRN_TotalAmount.Text) > 0.00M)
                {
                    AddPaymentDialogBox addPayment = new AddPaymentDialogBox(decimal.Parse(lblBalTotal.Text));
                    DialogResult res = addPayment.ShowDialog();
                    if (res.Equals(DialogResult.OK))
                    {
                        if (string.IsNullOrEmpty(lblGRNHeader.Text))
                        {
                            senaexminidbDataSet.payments.AddpaymentsRow(string.Empty, "GRN", addPayment.PaymentMode.ToString(), addPayment.Amount, addPayment.EntryDate, addPayment.PaidDuePostDate, addPayment.ChequeNo, addPayment.Bank, addPayment.Branch, addPayment.Remarks);
                        }
                        else
                        {
                            senaexminidbDataSet.payments.AddpaymentsRow(lblGRNHeader.Text, "GRN", addPayment.PaymentMode.ToString(), addPayment.Amount, addPayment.EntryDate, addPayment.PaidDuePostDate, addPayment.ChequeNo, addPayment.Bank, addPayment.Branch, addPayment.Remarks);
                        }
                    }
                }
                else
                { MessageBox.Show("Total GRN amount is Rs.0.00 or less than Rs.0.00! ", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            catch (Exception ex)
            { Console.WriteLine("Payment adding failed!...\n" + ex); }
        }


        private void savePayments(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.paymentsBindingSource.EndEdit();
                paymentsTableAdapter.Update(senaexminidbDataSet.payments);
            }
            catch (Exception ex)
            { Console.WriteLine("Payments saving failed!...\n" + ex); }
        }

        private void calBal()
        {
            try
            {
                decimal bal = decimal.Parse(lblGRN_TotalAmount.Text);
                decimal pay = 0.00M;
                if (dgvPayments.RowCount > 0)
                {
                    foreach (DataGridViewRow r in dgvPayments.Rows)
                    {
                        decimal.TryParse((r.Cells[4].Value != null) ? r.Cells[4].Value.ToString() : "0.00", out pay);
                        bal -= pay;
                    }
                }
                lblBalTotal.Text = bal.ToString();
            }
            catch (Exception ex) { Console.WriteLine("Cal Bal Ex::\n" + ex); }
        }

        private void lblGRN_TotalAmount_TextChanged(object sender, EventArgs e)
        {
            calBal();
            //Console.WriteLine("lblGRN_TotalAmount_TextChanged");
        }

        private void dgvPayments_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            calBal();
            //Console.WriteLine("dgvPayments_DataBindingComplete");
        }

        private void dgvPayments_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            calBal();
            // Console.WriteLine("dgvPayments_CellEndEdit");
        }

        private void paymentsBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            calBal();
            // Console.WriteLine("paymentsBindingSource_CurrentItemChanged");
        }

        private void paymentsBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            calBal();
            // Console.WriteLine("paymentsBindingSource_AddingNew");
        }

        private void paymentsBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e)
        {
            calBal();
            //  Console.WriteLine("paymentsBindingSource_BindingComplete");
        }

        private void paymentsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            calBal();
            // Console.WriteLine("paymentsBindingSource_CurrentChanged");
        }

        private void dgvPayments_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            calBal();
            // Console.WriteLine("dgvPayments_CellBeginEdit");
        }

        private void dgvPayments_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            calBal();
            // Console.WriteLine("dgvPayments_CellValueNeeded");
        }

        private void dgvGrnDetails_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            calTotalDiscount(sender, e);
            calGRNTotalAmount(sender, e);
        }













        /////////////////////////////////End of the class///////////////////////////////////

    }
}
