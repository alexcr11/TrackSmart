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
    public partial class settingsForm : Form
    {
        private DatabaseHelper dbHelper; // Declare dbHelper at the class level

        public settingsForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper(); // Initialize dbHelper for the settings form
            dbHelper.InitializeDatabase();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveSettings();
            Close();
        }

        public void saveSettings()
        {
            //Save settings that were made

            //Confirm settings has been saved
            MessageBox.Show("Your Settings have been saved.");
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
    }
}
