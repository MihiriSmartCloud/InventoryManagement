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
    internal partial class GRNListForm : Form
    {
        /////////////////////////////////////////////////////////////////////////////////////////////
        string selectedGRNNo = string.Empty;

        public GRNListForm()
        {
            InitializeComponent();

            btnPrint.Enabled = btnPrint.Visible = skPrint.Enabled = false;
            btnLoad.Enabled = true;
            btnLoad.Show();
        }

        public GRNListForm(string Titel)
        {
            InitializeComponent();

            this.Text = Titel;
            btnPrint.Enabled = btnPrint.Visible = skPrint.Enabled = true;
            btnLoad.Enabled = false;
            btnLoad.Hide();

        }

        private void loadAllGRN(object sender, System.EventArgs e)
        {
            try
            {
                this.grnTableAdapter.Fill_InDesOrder(this.senaexminidbDataSet.grn);
            }
            catch (Exception ex)
            {
                Console.WriteLine("GRN List Loading Faile!...\n" + ex.ToString());
                MessageBox.Show("GRN List Loading Faile!...\n" + ex.Message);
            }
        }

        private void searchGRN(object sender, System.EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtSearch.SearchText))
                {
                    string filterText = "%" + txtSearch.SearchText + "%";
                    this.grnTableAdapter.FillBy_Search_GrnNo_PONo_InvNo(this.senaexminidbDataSet.grn, filterText, filterText, filterText);
                }
                else
                {
                    loadAllGRN(sender, e);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("GRN List searching Fail!...\n" + ex.ToString());
                //MessageBox.Show("GRN List searching Fail!...\n" + ex.Message);
            }
        }

        private void GRNListForm_Load(object sender, EventArgs e)
        {
            loadAllGRN(sender, e);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        internal string selectedGRN
        {
            get { return selectedGRNNo; }
            set { selectedGRNNo = value; }
        }

        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        private void skFocusSrearchBox_Click(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(lblSelGRNHeader.Text))
                {
                    this.DialogResult = DialogResult.OK;
                    selectedGRNNo = lblSelGRNHeader.Text;
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                    MessageBox.Show("No Selected GRN!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot Load Selected GRN!...\n" + ex.ToString());
                MessageBox.Show("Cannot Load Selected GRN!...\n");
            }
        }

        private void dgvGRNList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            { btnLoad.Enabled = (string.IsNullOrEmpty(lblSelGRNHeader.Text)) ? false : true; }
            catch { }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                new ReportViewerForm_GRN(1).Show();
            }
            catch { }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.Equals(Keys.Up))
                {
                    e.SuppressKeyPress = true;
                    grnBindingSource.MovePrevious();
                }
                else if (e.KeyCode.Equals(Keys.Down))
                {
                    e.SuppressKeyPress = true;
                    grnBindingSource.MoveNext();
                }
            }
            catch { }
        }

        private void dgvGRNList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnLoad_Click(null, null);
        }


        ///////////////////////////////////End of the class//////////////////////////////////////
    }
}
