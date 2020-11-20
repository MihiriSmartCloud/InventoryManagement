using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SenaExSIMSMiniEdition.Login
{
    internal partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        ///////////////////////////////////////////////////////////
        private string connStr = "server=localhost;user id=root;password=7010850;persistsecurityinfo=True;database=senaexminidb";
        ///////////////////////////////////////////////////////////

        private void openDBConnection()
        {
            try
            {
                try
                {
                    Console.WriteLine("Connecting to Database...");
                    using (MySqlConnection conn = new MySqlConnection(connStr))
                        Console.WriteLine("Database is Connected ...");
                    //MessageBox.Show("Database is Connected ...");
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 0)
                    {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show("Cannot connect to server.  Please check your database connection and Restart the application!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadRoles()
        {
            try
            {
                Console.WriteLine("Connecting DB...");
                Console.WriteLine("Loading Roles...");
                this.rolesTableAdapter.Fill(this.senaexminidbDataSet.roles);
                Console.WriteLine("Roles loaded!...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Roles Loading Ex:: " + ex.Message);
                MessageBox.Show("Roles Loading Failed!. \nPlease check your database connection and Restart the application!:: ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkLogin()
        {
            try
            {
                Console.WriteLine("Checking inputs...");
                int i = usersTableAdapter.FillBy_Role_UN_PW(senaexminidbDataSet.users, cmbRole.SelectedValue.ToString(), txtUName.Text, txtPassword.Text);
                Console.WriteLine(i);
                if (i > 0)
                {
                    //MessageBox.Show("Login Successfull", "Login Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    MainApp.MainMDI mainApp = new MainApp.MainMDI(cmbRole.SelectedValue.ToString(), txtUName.Text);
                    mainApp.Show();
                    try
                    {
                        DateTime curLogin = DateTime.Now;
                        usersTableAdapter.UpdateQuery_LastLogin(curLogin, cmbRole.SelectedValue.ToString(), txtUName.Text);
                        Console.WriteLine(string.Format("Update Last Login:: {0} - {1} - {2}", cmbRole.SelectedValue.ToString(), txtUName.Text, curLogin));
                    }
                    catch { Console.WriteLine("Cannot update last login..."); }
                }
                else
                {
                    MessageBox.Show("Access Denied", "Login Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Error with the database connection", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            openDBConnection();
            loadRoles();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            checkLogin();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.Equals(Keys.Enter))
                {
                    SelectNextControl(txtUName, true, true, true, true);
                }
            }
            catch { }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.Equals(Keys.Enter))
                {
                    btnLogin_Click(sender, e);
                }
            }
            catch { }
        }





        //////////////////////////////////
    }
}
