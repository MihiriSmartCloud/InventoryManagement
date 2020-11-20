using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenaExSIMSMiniEdition.Inventory
{
    internal partial class InventoryForm : Form
    {
        public InventoryForm()
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

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            LoadAllItems(sender, e);
        }

        private void toolAllItemsPrint_Click(object sender, EventArgs e)
        {
            try
            {
                new ReportViewerForm_Inventory().ShowDialog();
            }
            catch { Console.WriteLine("Inventory Report loading failed!..."); }
        }






        //////////////////////////////////////////End of the class//////////////////////////////////////////////
    }
}
