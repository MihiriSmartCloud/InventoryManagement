using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenaExSIMSMiniEdition.Account
{
    public partial class AccountForm : Form
    {
        string curRole = string.Empty;
        string curUser = string.Empty;
        public AccountForm(string curRole, string curUser)
        {
            InitializeComponent();

            this.curRole = curRole;
            this.curUser = curUser;

            //User previlage.....
            if ((curRole.Equals("ADMINISTRATOR")) || (curRole.Equals("DEVELOPER")))
            {
                groupBoxIncome.Show();
                groupBoxExpenses.Show();
                groupBoxProfit.Show();
                btnPrint.Enabled = true;
            }
            else if ((curRole.Equals("OFFICE ASSISTANT")) || (curRole.Equals("SALES MANAGER")))
            {
                groupBoxIncome.Show();
                groupBoxExpenses.Hide();
                groupBoxProfit.Hide();
                btnPrint.Enabled = false;
            }
            else if (curRole.Equals("INVENTORY MANAGER"))
            {
                groupBoxExpenses.Show();
                groupBoxIncome.Hide();
                groupBoxProfit.Hide();
                btnPrint.Enabled = false;
            }
            
            //
        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////
        /// </summary>

        private void cmbFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ((cmbFilterType.SelectedIndex == 0) || (cmbFilterType.SelectedIndex == 3))
                { dtpDate1.Enabled = dtpDate2.Enabled = label2.Enabled = label3.Enabled = false; }
                else if (cmbFilterType.SelectedIndex == 1)
                {
                    dtpDate1.Enabled = label2.Enabled = true;
                    dtpDate2.Enabled = label3.Enabled = false;
                }
                else if (cmbFilterType.SelectedIndex == 2)
                { dtpDate1.Enabled = dtpDate2.Enabled = label2.Enabled = label3.Enabled = true; }
                else
                { dtpDate1.Enabled = dtpDate2.Enabled = label2.Enabled = label3.Enabled = false; }
                //
                Review(sender, e);
            }
            catch { Console.WriteLine("Cannot change filter type!..."); }
        }

        private void LoadAll(object sender, EventArgs e)
        {
            try
            {
                this.grnTableAdapter.Fill_InDesOrder(this.senaexminidbDataSet.grn);
                this.invoiceTableAdapter.Fill(this.senaexminidbDataSet.invoice);
            }
            catch (Exception ex)
            {
                if (ex.HResult.Equals(-2146232022)) { }
                else
                {
                    Console.WriteLine("Transactions Loading Failed!...\n" + ex.Message);
                    MessageBox.Show("Transactions Loading Failed!...");
                }
            }
        }

        private void Review(object sender, EventArgs e)
        {
            try
            {
                decimal income = 0.00M;
                decimal expense = 0.00M;
                if (cmbFilterType.SelectedIndex == 0)
                {
                    string date = "%" + DateTime.Today.ToShortDateString() + "%";
                    this.grnTableAdapter.FillBy_Today(this.senaexminidbDataSet.grn, date);
                    this.invoiceTableAdapter.FillBy_Today(this.senaexminidbDataSet.invoice, date);
                    try
                    { lblExpensesTotal.Text = (!this.grnTableAdapter.ScalarQuery_TodayTotalExpenses(date).Value.Equals(null)) ? this.grnTableAdapter.ScalarQuery_TodayTotalExpenses(date).Value.ToString("C2") : "0.00"; }
                    catch { lblExpensesTotal.Text = "0.00"; }
                    try
                    { lblIncomeTotal.Text = (!this.invoiceTableAdapter.ScalarQuery_TodayTotalIncome(date).Value.Equals(null)) ? this.invoiceTableAdapter.ScalarQuery_TodayTotalIncome(date).Value.ToString("C2") : "0.00"; }
                    catch { lblIncomeTotal.Text = "0.00"; }

                }
                else if (cmbFilterType.SelectedIndex == 1)
                {
                    string selDate = (dtpDate1.Value != null) ? ("%" + dtpDate1.Value.ToShortDateString() + "%") : ("%" + DateTime.Today.ToShortDateString() + "%");
                    this.grnTableAdapter.FillBy_Today(this.senaexminidbDataSet.grn, selDate);
                    this.invoiceTableAdapter.FillBy_Today(this.senaexminidbDataSet.invoice, selDate);
                    try
                    { lblExpensesTotal.Text = (!this.grnTableAdapter.ScalarQuery_TodayTotalExpenses(selDate).Value.Equals(null)) ? this.grnTableAdapter.ScalarQuery_TodayTotalExpenses(selDate).Value.ToString("C2") : "0.00"; }
                    catch { lblExpensesTotal.Text = "0.00"; }
                    try
                    { lblIncomeTotal.Text = (!this.invoiceTableAdapter.ScalarQuery_TodayTotalIncome(selDate).Value.Equals(null)) ? this.invoiceTableAdapter.ScalarQuery_TodayTotalIncome(selDate).Value.ToString("C2") : "0.00"; }
                    catch { lblIncomeTotal.Text = "0.00"; }

                }
                else if (cmbFilterType.SelectedIndex == 2)
                {
                    DateTime Date1 = (dtpDate1.Value != null) ? dtpDate1.Value : DateTime.Today;
                    DateTime Date2 = (dtpDate2.Value != null) ? dtpDate2.Value : DateTime.Today;
                    this.grnTableAdapter.FillBy_Period(this.senaexminidbDataSet.grn, Date1, Date2);
                    this.invoiceTableAdapter.FillBy_Period(this.senaexminidbDataSet.invoice, Date1, Date2);
                    try
                    { lblExpensesTotal.Text = (!this.grnTableAdapter.ScalarQuery_PeriodTotalExpenses(Date1, Date2).Value.Equals(null)) ? this.grnTableAdapter.ScalarQuery_PeriodTotalExpenses(Date1, Date2).Value.ToString("C2") : "0.00"; }
                    catch { lblExpensesTotal.Text = "0.00"; }
                    try
                    { lblIncomeTotal.Text = (!this.invoiceTableAdapter.ScalarQuery_PeriodTotalIncome(Date1, Date2).Value.Equals(null)) ? this.invoiceTableAdapter.ScalarQuery_PeriodTotalIncome(Date1, Date2).Value.ToString("C2") : "0.00"; }
                    catch { lblIncomeTotal.Text = "0.00"; }

                }
                else if (cmbFilterType.SelectedIndex == 3)
                {
                    LoadAll(sender, e);
                    try
                    { lblExpensesTotal.Text = (!this.grnTableAdapter.ScalarQuery_TotalExpenses().Value.Equals(null)) ? this.grnTableAdapter.ScalarQuery_TotalExpenses().Value.ToString("C2") : "0.00"; }
                    catch { lblExpensesTotal.Text = "0.00"; }
                    try
                    { lblIncomeTotal.Text = (!this.invoiceTableAdapter.ScalarQuery_TotalIncome().Value.Equals(null)) ? this.invoiceTableAdapter.ScalarQuery_TotalIncome().Value.ToString("C2") : "0.00"; }
                    catch { lblIncomeTotal.Text = "0.00"; }

                }
                else
                {
                    LoadAll(sender, e);
                    cmbFilterType.SelectedIndex = 3;
                    lblExpensesTotal.Text = "0.00";
                    lblIncomeTotal.Text = "0.00";
                    lblGrossProfit.Text = "0.00";
                }
                if (lblExpensesTotal.Text.StartsWith("-")) { decimal.TryParse(lblExpensesTotal.Text.Substring(4), out expense); }
                else { decimal.TryParse(lblExpensesTotal.Text.Substring(3), out expense); }
                if (lblIncomeTotal.Text.StartsWith("-")) { decimal.TryParse(lblIncomeTotal.Text.Substring(4), out income); }
                else { decimal.TryParse(lblIncomeTotal.Text.Substring(3), out income); }
                decimal profit = decimal.Subtract(income, expense);
                Console.WriteLine("Profit= " + profit);
                lblGrossProfit.Text = profit.ToString("C2");
            }
            catch (Exception ex)
            {
                LoadAll(sender, e);
                cmbFilterType.SelectedIndex = 3;
                lblExpensesTotal.Text = "0.00";
                lblIncomeTotal.Text = "0.00";
                lblGrossProfit.Text = "0.00";
                Console.WriteLine("Transactions searching failed!...\n" + ex.ToString());
                // MessageBox.Show("Transactions searching failed!...");
            }
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            LoadAll(sender, e);
        }

        private void btmPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFilterType.SelectedIndex == 0)
                {
                    new ReportViewerForm_Account(0, null, null).ShowDialog();
                }
                else if (cmbFilterType.SelectedIndex == 1)
                {
                    new ReportViewerForm_Account(1, dtpDate1.Value.ToShortDateString(), null).ShowDialog();
                }
                else if (cmbFilterType.SelectedIndex == 2)
                {
                    new ReportViewerForm_Account(2, dtpDate1.Value, dtpDate2.Value).ShowDialog();
                }
                else
                {
                    new ReportViewerForm_Account(-1).ShowDialog();
                }
            }
            catch { Console.WriteLine("Account Report loading failed!..."); }
        }














        ///////////////////////////////////End of the class////////////////////////////////////
    }
}
