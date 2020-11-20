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
    internal partial class CustomOptionBox : Form
    {
        public CustomOptionBox()
        {
            InitializeComponent();
        }

        public CustomOptionBox(string Titel)
        {
            InitializeComponent();
            this.Text = Titel;
        }

        public CustomOptionBox(string[] btnText)
        {
            InitializeComponent();
            btnOp1.Text = btnText[0];
            btnOp2.Text = btnText[1];
        }

        public CustomOptionBox(string Titel, string msg)
        {
            InitializeComponent();
            this.Text = Titel;
            lblMsg.Text = msg;
        }

        public CustomOptionBox(string Titel, string msg, string[] btnText)
        {
            InitializeComponent();
            this.Text = Titel;
            lblMsg.Text = msg;
            btnOp1.Text = btnText[0];
            btnOp2.Text = btnText[1];
        }
        public CustomOptionBox(string Titel, string msg, string[] btnText, Image msgIcon)
        {
            InitializeComponent();
            this.Text = Titel;
            lblMsg.Text = msg;
            btnOp1.Text = btnText[0];
            btnOp2.Text = btnText[1];
            imgIcon.Image = msgIcon;
        }

    }
}
