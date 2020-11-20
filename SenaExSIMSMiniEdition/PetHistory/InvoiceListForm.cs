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
    public partial class InvoiceListForm : Form
    {
        string selectedHisNo = string.Empty;
        public InvoiceListForm()
        {
            InitializeComponent();
        }

        internal string selectedInvoice
        {
            get { return selectedHisNo; }
            set { selectedHisNo = value; }
        }

        public InvoiceListForm(string Titel)
        {
            InitializeComponent();

            this.Text = Titel;
            btnPrint.Enabled = btnPrint.Visible = btnPrint.Enabled = true;
            btnLoad.Enabled = false;
            btnLoad.Hide();

        }
    }

   
}
