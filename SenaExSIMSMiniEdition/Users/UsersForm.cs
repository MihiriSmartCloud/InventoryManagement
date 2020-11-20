using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenaExSIMSMiniEdition.Users
{
    internal partial class UsersForm : Form
    {

        string curRole = string.Empty;
        string curUser = string.Empty;

        public UsersForm(string curRole, string curUser)
        {
            InitializeComponent();

            this.curRole = curRole;
            this.curUser = curUser;

            //User previlage.....
            if ((curRole.Equals("ADMINISTRATOR")) || (curRole.Equals("DEVELOPER")))
            {
                groupBoxSelUser.Enabled = mnuSK_Reset.Enabled = mnuSK_Add.Enabled = mnuSK_Delete.Enabled = mnuSK_Update.Enabled = true;
                groupBoxSelUser.Show();
            }
            else
            {
                groupBoxSelUser.Enabled = mnuSK_Reset.Enabled = mnuSK_Add.Enabled = mnuSK_Delete.Enabled = mnuSK_Update.Enabled = false;
                groupBoxSelUser.Hide();
            }
        }

        private void LoadRole()
        {
            try
            {
                this.rolesTableAdapter.Fill(this.senaexminidbDataSet.roles);
            }
            catch (Exception ex)
            { Console.WriteLine("Role Loading Failed!...\n" + ex.ToString()); }
        }

        private void LoadUsers()
        {
            try
            {
                this.usersTableAdapter.Fill(this.senaexminidbDataSet.users);
            }
            catch (Exception ex)
            { Console.WriteLine("Users Loading Failed!...\n" + ex.ToString()); }
        }

        private void setUserTreeView()
        {
            try
            {
                tvUsers.Nodes.Clear();
                foreach (DataRow roles in rolesTableAdapter.GetData().Rows)
                {
                    string curRole = roles.Field<string>(0);
                    TreeNode nodeMain = new TreeNode(curRole);
                    nodeMain.ImageIndex = 0;

                    foreach (DataRow users in usersTableAdapter.GetDataBy_Role(curRole))
                    {
                        TreeNode childNode = new TreeNode(users.Field<string>(1));
                        childNode.ImageIndex = 1;
                        childNode.SelectedImageIndex = 2;
                        nodeMain.Nodes.Add(childNode);
                    }
                    tvUsers.Nodes.Add(nodeMain);
                }
                tvUsers.ExpandAll();
            }
            catch (Exception ex)
            { Console.WriteLine("Tree view data loading Ex:: \n" + ex.Message); }
        }

        private void loadLastLoginOfCurUser()
        {
            try
            {
                lblLastLogin.Text = (this.usersTableAdapter.GetDataBy_Role_Username(lblCurRoleHeader.Text, lblCurUserNameHeader.Text).Rows.Count > 0) ? this.usersTableAdapter.GetDataBy_Role_Username(lblCurRoleHeader.Text, lblCurUserNameHeader.Text).Rows[0].Field<DateTime>(3).ToString() : string.Empty;
            }
            catch (Exception ex)
            { Console.WriteLine("Selected User Details Loading Failed!...\n" + ex.ToString()); }
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            LoadRole();
            LoadUsers();
            setUserTreeView();

            lblCurRoleHeader.Text = this.curRole;
            lblCurUserNameHeader.Text = this.curUser;
            loadLastLoginOfCurUser();
        }

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!string.IsNullOrEmpty(lblCurRoleHeader.Text)) && (!string.IsNullOrEmpty(lblCurUserNameHeader.Text)))
                {
                    //Update PW.....
                    DialogResult res = MessageBox.Show("Do You Want To Change Your Password?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        try
                        {
                            int i = this.usersTableAdapter.UpdateQuery_ChangePW(txtNewPW.Text, lblCurRoleHeader.Text, lblCurUserNameHeader.Text);
                            if (i > 0)
                            { MessageBox.Show("Password Changed Succesfully!...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                            else { MessageBox.Show("Cannot change your password!...", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            txtNewPW.Clear();
                        }
                        catch (MySqlException ex)
                        {
                            Console.WriteLine("Your password changing Failed!...\n" + ex.ToString());
                            MessageBox.Show("Your password changing Failed!...", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                { MessageBox.Show("Current user's data is null!\nPlease relogin your account!", "Alert!...", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Your password changing Failed!...\n" + ex.ToString());
                MessageBox.Show("Your password changing Failed!...", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 

        private void tvUsers_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvUsers.SelectedNode.Index != -1)
            {
                if (tvUsers.SelectedNode.Parent != null)
                {
                    lblSelRoleHeader.Text = tvUsers.SelectedNode.Parent.Text;
                    lblSelUserNameHeader.Text = tvUsers.SelectedNode.Text;
                }
                else
                { lblSelUserNameHeader.Text = lblSelRoleHeader.Text = string.Empty; }
            }
            else
            { lblSelUserNameHeader.Text = lblSelRoleHeader.Text = string.Empty; }
        }

        private void lblRoleHeader_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.usersTableAdapter.FillBy_Role_Username(this.senaexminidbDataSet.users, lblSelRoleHeader.Text, lblSelUserNameHeader.Text);
            }
            catch (Exception ex)
            { Console.WriteLine("Selected User Details Loading Failed!...\n" + ex.ToString()); }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                lblSelRoleHeader.Text = lblSelUserNameHeader.Text = string.Empty;
                usernameTextBox.Clear();
                passwordTextBox.Clear();
                lastLoginLabel.Text = string.Empty;
            }
            catch { }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (!roleComboBox.SelectedIndex.Equals(-1))
                {
                    if (!string.IsNullOrEmpty(usernameTextBox.Text))
                    {
                        //Add new USER.....
                        DialogResult res = MessageBox.Show("Do you want to ADD NEW User? :-" + '\n' + usernameTextBox.Text, "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            try
                            {
                                int i = this.usersTableAdapter.Insert(roleComboBox.SelectedValue.ToString(), usernameTextBox.Text, passwordTextBox.Text, null);
                                if (i > 0)
                                    MessageBox.Show("New User Added Succesfully!...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else
                                    MessageBox.Show("Cannot Add New User!...", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (MySqlException ex)
                            {
                                if (ex.Number.Equals(1062))
                                    MessageBox.Show("User Adding Failed!...\n \"" + usernameTextBox.Text + "\" is  already exists.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                else
                                    MessageBox.Show("User Adding Failed!...", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            btnReset_Click(sender, e);
                            setUserTreeView();
                        }
                    }
                    else
                    { MessageBox.Show("Please fill User Username!...", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                }
                else
                { MessageBox.Show("Please fill User Role!...", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            catch (Exception ex)
            {
                Console.WriteLine("New user adding Failed!...\n" + ex.ToString());
                MessageBox.Show("New user adding Failed!...", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!string.IsNullOrEmpty(lblSelRoleHeader.Text)) && (!string.IsNullOrEmpty(lblSelUserNameHeader.Text)))
                {
                    if (!roleComboBox.SelectedIndex.Equals(-1))
                    {
                        if (!string.IsNullOrEmpty(usernameTextBox.Text))
                        {
                            //Update new USER.....
                            DialogResult res = MessageBox.Show("Do you want to UPDATE User? :-" + '\n' + usernameTextBox.Text, "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (res == DialogResult.Yes)
                            {
                                try
                                {
                                    int i = this.usersTableAdapter.Update(roleComboBox.SelectedValue.ToString(), usernameTextBox.Text, passwordTextBox.Text, lblSelRoleHeader.Text, lblSelUserNameHeader.Text);
                                    if (i > 0)
                                        MessageBox.Show("User Details Updated Succesfully!...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    else
                                        MessageBox.Show("Cannot Update User Details!...", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                catch (MySqlException ex)
                                {
                                    if (ex.Number.Equals(1062))
                                        MessageBox.Show("User Details Updating Failed!...\n\"" + usernameTextBox.Text + "\" is  already exists.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    else
                                        MessageBox.Show("User Details Updating Failed!...", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                btnReset_Click(sender, e);
                                setUserTreeView();
                            }
                        }
                        else
                        { MessageBox.Show("Please Fill User Username!...", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                    }
                    else
                    { MessageBox.Show("Please Fill User Role!...", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                }
                else
                { MessageBox.Show("Please select a user!...", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            catch (Exception ex)
            {
                Console.WriteLine("User Updating Failed!...\n" + ex.ToString());
                MessageBox.Show("User Updating Failed!...", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!string.IsNullOrEmpty(lblSelRoleHeader.Text)) && (!string.IsNullOrEmpty(lblSelUserNameHeader.Text)))
                {
                    //Delete User.....
                    DialogResult res = MessageBox.Show("Do you want to DELETE User? :- \n" + lblSelRoleHeader.Text + " : " + lblSelUserNameHeader.Text, "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        try
                        {
                            int i = this.usersTableAdapter.Delete(lblSelRoleHeader.Text, lblSelUserNameHeader.Text);
                            if (i > 0)
                                MessageBox.Show("User Deleted Succesfully!...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Cannot Delete User!...", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (MySqlException ex)
                        {
                            switch (ex.Number)
                            {
                                case 1451:
                                    MessageBox.Show("Cannot delete \"" + lblSelRoleHeader.Text + " : " + lblSelUserNameHeader.Text + "\" User! \nIt has some record(s). \nIf you want to delete, you must change or delete that record(s) first!", "User Deleting Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                default:
                                    Console.WriteLine("User Deleting Failed!...\n" + ex.ToString());
                                    MessageBox.Show("User Deleting Failed!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                            }
                        }
                        btnReset_Click(sender, e);
                        setUserTreeView();
                    }
                }
                else
                { MessageBox.Show("Please select a user!...", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            catch (Exception ex)
            {
                Console.WriteLine("User Deleting Failed!...\n" + ex.ToString());
                MessageBox.Show("User Deleting Failed!...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



















        //////////////////////////////End of the class//////////////////////////////
    }
}
