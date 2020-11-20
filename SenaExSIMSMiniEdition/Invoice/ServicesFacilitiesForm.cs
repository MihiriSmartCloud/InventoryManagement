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
    public partial class ServicesFacilitiesForm : Form
    {
        public ServicesFacilitiesForm()
        {
            InitializeComponent();
        }

        private void service_typesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Do you want to Save Changes?", "Confirmation?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res.Equals(DialogResult.Yes))
                {
                    this.Validate();
                    this.service_typesBindingSource.EndEdit();
                    int i = this.tableAdapterManager.UpdateAll(this.senaexminidbDataSet);
                    if (i > 0)
                    {
                        MessageBox.Show("Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ServicesFacilitiesForm_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ServicesFacilitiesForm Saving Failed!...\n" + ex.ToString());
                MessageBox.Show("Services & Facilities Saving Failed!...\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ServicesFacilitiesForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.service_typesTableAdapter.Fill(this.senaexminidbDataSet.service_types);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ServicesFacilitiesForm Loading Failed!...\n" + ex.ToString());
                MessageBox.Show("Services & Facilities Loading Failed!...\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                service_typesBindingSource.AddNew();
            }
            catch { }
        }

        private void service_typesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Console.WriteLine(e.Exception.HResult);
            try
            {
                if (e.Exception.HResult.Equals(-2146232022))
                {
                    MessageBox.Show("This Service type is already exist!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch { }
        }
    }
}
