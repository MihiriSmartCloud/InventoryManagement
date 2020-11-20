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
    public partial class WindowControlsUC : UserControl
    {
        public WindowControlsUC()
        {
            InitializeComponent();
        }

        /*
        Events
        */
        public event EventHandler maximizeWindows, closeWindows;
        
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.maximizeWindows != null) this.maximizeWindows(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (this.closeWindows != null) this.closeWindows(sender, e);
        }
        




    }
}
