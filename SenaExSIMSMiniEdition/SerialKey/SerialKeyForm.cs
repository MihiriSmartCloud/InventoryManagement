using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenaExSIMSMiniEdition.SerialKey
{
    public partial class SerialKeyForm : Form
    {
        public SerialKeyForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.UserKey = txtKey.Text;
                Properties.Settings.Default.Save();
                Application.Restart();
            }
            catch (Exception ex)
            { MessageBox.Show("Cannot apply serial key!...\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
