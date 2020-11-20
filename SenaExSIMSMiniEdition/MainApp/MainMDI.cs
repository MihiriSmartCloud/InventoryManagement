using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenaExSIMSMiniEdition.MainApp
{
    internal partial class MainMDI : Form
    {

        ///////////////////////////////////////////////////////////
        string uRole = string.Empty;
        string uName = string.Empty;

        Home.HomeForm home;
        Suppliers.SuppliersForm suppliers;
        Categories.CategoriesForm categories;
        Items.ItemsForm items;
        GRN.GRNForm grn;
        Customers.CustomersForm customers;
        Invoice.InvoiceForm invoice;
        Inventory.InventoryForm inventory;
        Account.AccountForm account;
        Users.UsersForm users;
        PetHistory.HistoryForm history;


        ///////////////////////////////////////////////////////////
        public MainMDI(string uRole, string uName)
        {
            InitializeComponent();
            //
            this.uRole = uRole;
            this.uName = uName;

            if (!string.IsNullOrEmpty(uRole) && !string.IsNullOrEmpty(uName))
            {
                mnuLogOutUser.Text = uRole + " : " + uName;
            }
            else { mnuLogOutUser.Text = "User : Unknown User"; }

            //User previlage.....
            userPrevileges();


            //
            //////////////////////////////////////////////////////

            home = new Home.HomeForm(uRole, uName);
            suppliers = new Suppliers.SuppliersForm();
            categories = new Categories.CategoriesForm();
            items = new Items.ItemsForm();
            grn = new GRN.GRNForm(uRole, uName);
            customers = new Customers.CustomersForm();
            invoice = new Invoice.InvoiceForm(uRole, uName);
            inventory = new Inventory.InventoryForm();
            account = new Account.AccountForm(uRole, uName);
            users = new Users.UsersForm(uRole, uName);
            history = new PetHistory.HistoryForm(uRole, uName);
            

            /////////////////////////////////////////////////////
        }

        private void userPrevileges()
        {
            try
            {

                if ((uRole.Equals("ADMINISTRATOR")) || (uRole.Equals("DEVELOPER")) || (uRole.Equals("DOCTOR")) || (uRole.Equals("OFFICE ASSISTANT")))
                {
                    toolSuppliers.Enabled =
                        toolCategories.Enabled =
                        toolItems.Enabled =
                        toolGRN.Enabled =
                        toolCustomers.Enabled =
                        toolInvoice.Enabled =
                        toolInventory.Enabled =
                        toolAccount.Enabled =
                        toolUsers.Enabled = true;
                }
                else if (uRole.Equals("INVENTORY MANAGER"))
                {
                    toolSuppliers.Enabled =
                        toolCategories.Enabled =
                        toolItems.Enabled =
                        toolGRN.Enabled =
                        toolInventory.Enabled =
                        toolAccount.Enabled =
                        toolUsers.Enabled = true;
                    //
                    toolCustomers.Enabled =
                    toolInvoice.Enabled = false;
                }
                else if (uRole.Equals("SALES MANAGER"))
                {
                    toolCustomers.Enabled =
                        toolInvoice.Enabled =
                        toolInventory.Enabled =
                        toolAccount.Enabled =
                        toolUsers.Enabled = true;
                    //
                    toolSuppliers.Enabled =
                        toolCategories.Enabled =
                        toolItems.Enabled =
                        toolGRN.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("User Previleges Ex:: \n" + ex.Message);
            }
        }




        private void MainMDI_Load(object sender, EventArgs e)
        {
            toolHome_Click(sender, e);
        }

              

        private void MainMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mnuLogOut_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show(string.Format("Do you want to Log out? \n{0}", mnuLogOutUser.Text), "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    this.Hide();
                    new Login.LoginForm().Show();
                }
            }
            catch { }
        }

        /// <summary>
        /// Showing child forms...
        /// </summary>
        private void showChildform(Form childForm)
        {
            try
            {
                childForm.MdiParent = this;
                childForm.WindowState = FormWindowState.Maximized;
                childForm.Show();
                childForm.BringToFront();
            }
            catch { MessageBox.Show(string.Format("Cannot Show {0} Screen!", childForm.Text), "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void toolHome_Click(object sender, EventArgs e)
        {
            try
            {
                if ((home.IsDisposed == true) || (home == null))
                {
                    home = new Home.HomeForm(uRole, uName);
                }
                showChildform(home);
            }
            catch { }
        }

        private void toolSuppliers_Click(object sender, EventArgs e)
        {
            try
            {

                if ((suppliers.IsDisposed == true) || (suppliers == null))
                {
                    suppliers = new Suppliers.SuppliersForm();
                }
                showChildform(suppliers);
            }
            catch { }
        }

        private void toolCategories_Click(object sender, EventArgs e)
        {
            try
            {
                if ((categories.IsDisposed == true) || (categories == null))
                {
                    categories = new Categories.CategoriesForm();
                }
                showChildform(categories);
            }
            catch { }
        }

        private void toolItems_Click(object sender, EventArgs e)
        {
            try
            {
                if ((items.IsDisposed == true) || (items == null))
                {
                    items = new Items.ItemsForm();
                }
                showChildform(items);
            }
            catch { }
        }

        private void toolGRN_Click(object sender, EventArgs e)
        {
            try
            {
                if ((grn.IsDisposed == true) || (grn == null))
                {
                    grn = new GRN.GRNForm(uRole, uName);
                }
                showChildform(grn);
            }
            catch { }
        }

        private void toolCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                if ((customers.IsDisposed == true) || (customers == null))
                {
                    customers = new Customers.CustomersForm();
                }
                showChildform(customers);
            }
            catch { }
        }

        private void toolInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                if ((invoice.IsDisposed == true) || (invoice == null))
                {
                    invoice = new Invoice.InvoiceForm(uRole, uName);
                }
                showChildform(invoice);
            }
            catch { }
        }

        private void toolUsers_Click(object sender, EventArgs e)
        {
            try
            {
                if ((users.IsDisposed == true) || (users == null))
                {
                    users = new Users.UsersForm(uRole, uName);
                }
                showChildform(users);
            }
            catch { }
        }

        private void toolInventory_Click(object sender, EventArgs e)
        {
            try
            {
                if ((inventory.IsDisposed == true) || (inventory == null))
                {
                    inventory = new Inventory.InventoryForm();
                }
                showChildform(inventory);
            }
            catch { }
        }

        private void toolAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if ((account.IsDisposed == true) || (account == null))
                {
                    account = new Account.AccountForm(uRole, uName);
                }
                showChildform(account);
            }
            catch { }
        }

        private void toolStripHistory_Click(object sender, EventArgs e)
        {
            try
            {
                if((history.IsDisposed==true) || (history == null))
                {
                    history = new PetHistory.HistoryForm(uRole, uName);
                }
                showChildform(history);
            }
            catch { }
        }










        ///////////////////////////////////////////////////////////////////////////////////////////
    }
}
