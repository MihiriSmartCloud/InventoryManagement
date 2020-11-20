using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SenaExSIMSMiniEdition.Categories
{
    internal partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }

        /////////////////////////////////////////////////////////////////////////////////////////

        private void loadAllCategories()
        {
            try
            {
                this.categoriesTableAdapter.Fill(this.senaexminidbDataSet.categories);
                this.itemsTableAdapter.Fill(this.senaexminidbDataSet.items);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Categories List Loading Faile!...\n" + ex.ToString());
                MessageBox.Show("Categories List Loading Faile!...\n" + ex.Message);
            }
        }

        private void searchCategories(object sender, System.EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtSearchBoxUC.SearchText))
                {
                    string filterText = "%" + txtSearchBoxUC.SearchText + "%";
                    this.categoriesTableAdapter.FillBy_Cat(this.senaexminidbDataSet.categories, filterText);
                }
                else
                {
                    loadAllCategories();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Categories List searching Fail!...\n" + ex.ToString());
                //MessageBox.Show("Categories List searching Fail!...\n" + ex.Message);
            }
        }


        /////////////////////////////////////////////////////////////////////////////////////////

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            loadAllCategories();
        }

        /*
        Add|Update|Delete|Clear|SearchFocus Categories
        */
        private void btnCatReset_Click(object sender, EventArgs e)
        {
            txtCategory.Clear();
            txtCategory.Focus();
        }

        private void btnCatAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCategory.Text))
                {
                    //Add new Category.....
                    DialogResult res = MessageBox.Show("Do you want to ADD NEW Category? :-" + '\n' + txtCategory.Text, "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        try
                        {
                            this.categoriesTableAdapter.Insert(txtCategory.Text);
                            MessageBox.Show("New Category Added Succesfully!...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCategory.Clear();
                        }
                        catch (MySqlException ex)
                        {
                            if (ex.Number.Equals(1062))
                                MessageBox.Show("Category Saving Failed!...\n \"" + txtCategory.Text + "\" is  already exists.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        loadAllCategories();
                    }
                }
                else
                    MessageBox.Show("Please Enter Category Name.", "Alert!...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategory.Focus();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Category Saving Failed!...\n" + ex.ToString());
                MessageBox.Show("Category Saving Failed!...", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCatUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(lblCatHeader.Text))
                {
                    if (!string.IsNullOrEmpty(txtCategory.Text))
                    {
                        //Update Category.....
                        DialogResult res = MessageBox.Show("Do you want to UPDATE Category? :- " + lblCatHeader.Text + " to \n" + txtCategory.Text, "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            try
                            {
                                this.categoriesTableAdapter.Update(txtCategory.Text, lblCatHeader.Text);
                                MessageBox.Show("Category Updated Succesfully!...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtCategory.Clear();
                            }
                            catch (MySqlException ex)
                            {
                                switch (ex.Number)
                                {
                                    case 1062:
                                        MessageBox.Show("Category Updating Failed!...\n \"" + txtCategory.Text + "\" is  already exists.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        break;
                                    default:
                                        Console.WriteLine("Categories Updating Failed!...\n" + ex.ToString());
                                        MessageBox.Show("Categories Updating Failed!...", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;
                                }
                            }
                            loadAllCategories();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Category Name!", "Alert!...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCategory.Focus();
                    }
                }
                else
                { MessageBox.Show("Please Select Category!", "Alert!...", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Categories Updating Failed!...\n" + ex.ToString());
                MessageBox.Show("Categories Updating Failed!...", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCatDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(lblCatHeader.Text))
                {
                    //Delete Category.....
                    DialogResult res = MessageBox.Show("Do you want to DELETE Category? :- " + lblCatHeader.Text, "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        try
                        {
                            this.categoriesTableAdapter.Delete(lblCatHeader.Text);
                            MessageBox.Show("Category Deleted Succesfully!...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCategory.Clear();
                        }
                        catch (MySqlException ex)
                        {
                            switch (ex.Number)
                            {
                                case 1451:
                                    MessageBox.Show("Cannot delete \"" + lblCatHeader.Text + "\" category! \nIt has some record(s). \nIf you want to delete, you must change or delete that record(s) first!", "Category Deleting Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                default:
                                    Console.WriteLine("Category Deleting Failed!...\n" + ex.ToString());
                                    MessageBox.Show("Category Deleting Failed!...", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                            }
                        }
                        loadAllCategories();
                    }
                }
                else
                    MessageBox.Show("Please Select Category.", "Alert!...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Category Deleting Failed!...\n" + ex.ToString());
                MessageBox.Show("Category Deleting Failed!...", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
        Print Reports
        */
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdoCatOnly.Checked)
                    new ReportViewerForm_Cat(1, lblCatHeader.Text).ShowDialog();
                else if (rdoSelCatProdList.Checked)
                    new ReportViewerForm_Cat(2, lblCatHeader.Text).ShowDialog();
                else if (rdoCatWithProducts.Checked)
                    new ReportViewerForm_Cat(3, lblCatHeader.Text).ShowDialog();
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }

        private void mnuSK_Search_Click(object sender, EventArgs e)
        {
            txtSearchBoxUC.setFocusSearchField();
        }









        ////////////////////////////////////End of the class///////////////////////////////////////
    }
}
