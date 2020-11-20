using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenaExSIMSMiniEdition.Util
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }
        

        private void TestForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'senaexminidbDataSet.suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.senaexminidbDataSet.suppliers);
            // TODO: This line of code loads data into the 'senaexminidbDataSet.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.senaexminidbDataSet.items);

        }

        private void itemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.senaexminidbDataSet);

        }
    }
}
