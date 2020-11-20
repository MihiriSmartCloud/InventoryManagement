using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenaExSIMSMiniEdition.Home
{
    public partial class HomeForm : Form
    {
        public HomeForm(string curRole, string curUser)
        {
            InitializeComponent();
            //Clock...
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Today.ToLongDateString();
            timerClock.Start();
            //Current User...
            lblCurUser.Text = string.Format("Role: {0}\nUsername: {1}",curRole,curUser);
        }

        private void windowControlsUC1_closeWindows(object sender, EventArgs e)
        {
            this.Close();
        }

        private void windowControlsUC1_maximizeWindows(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            try
            {
                
                lblTime.Text = DateTime.Now.ToLongTimeString();
                lblDate.Text = DateTime.Today.ToLongDateString();
            }
            catch { }
        }
    }
}
