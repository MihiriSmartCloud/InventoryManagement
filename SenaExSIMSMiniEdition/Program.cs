using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenaExSIMSMiniEdition
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login.LoginForm());
            //Application.Run(new MainApp.MainMDI("DEVELOPER", "APPSPOINT"));

            string appkey = Properties.Settings.Default.AppKey;
            string userkey = Properties.Settings.Default.UserKey;
            if (appkey.Equals(userkey))
            {
                Application.Run(new Login.LoginForm());
            }
            else
            {
                Application.Run(new SerialKey.SerialKeyForm());
            }


        }
    }
}
