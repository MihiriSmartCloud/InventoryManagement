using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenaExSIMSMiniEdition.Util
{
    public partial class searchBoxUC : UserControl
    {
        public searchBoxUC()
        {
            InitializeComponent();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////



        /////////////////////////////////////////////////////////////////////////////////////////////////////

        /*
        Searching....
        */
        private void txtSearch_Enter(object sender, System.EventArgs e)
        {
            try
            {
                txtSearch.Focus();
                lblTxtPlaceHolder.Hide();
            }
            catch { }

        }

        private void txtSearch_Leave(object sender, System.EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                    lblTxtPlaceHolder.Show();
            }
            catch { }
        }

        private void btnReset_Click(object sender, System.EventArgs e)
        {
            try
            {
                txtSearch.Clear();
                lblTxtPlaceHolder.Show();
            }
            catch { }
        }


        /*
        Poperties
        */


        public string PlaceHolderText
        {
            get { return lblTxtPlaceHolder.Text; }
            set { lblTxtPlaceHolder.Text = value; }
        }

        public CharacterCasing CharacterCasing
        {
            get { return txtSearch.CharacterCasing; }
            set { txtSearch.CharacterCasing = value; }
        }

        public string SearchText
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }

        public Color SearchButtonBackColor
        {
            get { return btnSearch.BackColor; }
            set { btnSearch.BackColor = value; }
        }

        public Color ResetButtonBackColor
        {
            get { return btnReset.BackColor; }
            set { btnReset.BackColor = value; }
        }

        /*
        Public Methodes
        */
        public void setFocusSearchField()
        {
            txtSearch.Focus();
        }


        /*
        Events
        */
        public event EventHandler searchTextbox_TextChanged, searchButton_Click;
        public event KeyEventHandler searchBox_KeyDownEvent;

        private void searchTextboxTextChanged(object sender, EventArgs e)
        {
            if (this.searchTextbox_TextChanged != null) this.searchTextbox_TextChanged(sender, e);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.searchBox_KeyDownEvent != null) this.searchBox_KeyDownEvent(sender, e);
        }

        private void searchButtonClick(object sender, EventArgs e)
        {
            if (this.searchButton_Click != null) this.searchButton_Click(sender, e);

        }

        /////////////////////////////End of the class///////////////////////////////////////////
    }
}
