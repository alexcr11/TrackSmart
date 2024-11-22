using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackSmart
{
    public partial class Settings : Form
    {
        private void LoadCategories()
        {
            List<string> categories = dbHelper.GetCategories();
            category.Items.Clear();
            category.Items.AddRange(categories.ToArray());
        }

        private void LoadVendors()
        {
            List<string> vendors = dbHelper.GetVendors();
            vendor.Items.Clear();
            vendor.Items.AddRange(vendors.ToArray());
        }

        private DatabaseHelper dbHelper; // Declare dbHelper at the class level

        public Settings()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper(); // Initialize dbHelper for the settings form
            dbHelper.InitializeDatabase();

            // Load categories and vendors into ComboBoxes
            LoadCategories();
            LoadVendors();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Check if the owner is the main form and refresh data
            if (Owner is TrackSmart mainForm)
            {
                mainForm.RefreshData();
            }
            Close();
        }

        private void AddExpenseCategoryButton_Click(object sender, EventArgs e)
        {
            string newCategory = CategoryTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(newCategory))
            {
                dbHelper.AddCategory(newCategory); // Call DatabaseHelper method to add category
                MessageBox.Show("Category added successfully.");
                CategoryTextBox.Clear(); // Clear the text box after adding
            }
            else
            {
                MessageBox.Show("Please enter a category name.");
            }
        }

        private void AddExpenseVendorButton_Click(object sender, EventArgs e)
        {
            string newVendor = VendorTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(newVendor))
            {
                dbHelper.AddVendor(newVendor); // Call DatabaseHelper method to add vendor
                MessageBox.Show("Vendor added successfully.");
                VendorTextBox.Clear(); // Clear the text box after adding
            }
            else
            {
                MessageBox.Show("Please enter a vendor name.");
            }
        }

        private void RemoveExpenseCategoryButton_Click(object sender, EventArgs e)
        {
            string selectedCategory = category.Text.Trim();

            if (!string.IsNullOrEmpty(selectedCategory))
            {
                dbHelper.RemoveCategory(selectedCategory); // Call DatabaseHelper method to remove category
                MessageBox.Show("Category removed successfully.");
                category.SelectedIndex = -1; // Reset the ComboBox
                LoadCategories(); // Reload categories to reflect changes
            }
            else
            {
                MessageBox.Show("Please select a Category to delete.");
            }
        }

        private void RemoveExpenseVendorButton_Click(object sender, EventArgs e)
        {
            string selectedVendor = vendor.Text.Trim();


            if (!string.IsNullOrEmpty(selectedVendor))
            {
                dbHelper.RemoveVendor(selectedVendor);
                MessageBox.Show("Vendor removed successfully.");
                vendor.SelectedIndex = -1;
                LoadVendors();
            }
            else
            {
                MessageBox.Show("Please select a Vendor to delete.");
            }
        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddExpenseVendorButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
