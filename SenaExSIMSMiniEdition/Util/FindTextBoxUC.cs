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
    public partial class FindTextBoxUC : UserControl
    {
        public FindTextBoxUC()
        {
            InitializeComponent();
        }

        /*
       Poperties
       */
        public CharacterCasing CharacterCasing
        {
            get { return textBox.CharacterCasing; }
            set { textBox.CharacterCasing = value; }
        }

        public string TextResult
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        public Color FindButtonBackColor
        {
            get { return btnFind.BackColor; }
            set { btnFind.BackColor = value; }
        }

        public bool ReadOnlyTextbox
        {
            get { return textBox.ReadOnly; }
            set
            {
                textBox.ReadOnly = value;
                textBox.BackColor = Color.White;
            }
        }

        /*
        Public Methodes
        */
        public void setFocusFindButton()
        {
            btnFind.Focus();
        }

        /*
        Events
        */
        public event EventHandler resultTextbox_TextChanged, findButton_Click;

        private void resultTextboxTextChanged(object sender, EventArgs e)
        {
            if (this.resultTextbox_TextChanged != null) this.resultTextbox_TextChanged(sender, e);
        }
        private void findButtonClick(object sender, EventArgs e)
        {
            if (this.findButton_Click != null) this.findButton_Click(sender, e);
        }

        /////////////////////////////End of the class///////////////////////////////////////////





    }
}
