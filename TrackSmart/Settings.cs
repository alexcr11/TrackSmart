using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace TrackSmart
{
    public partial class Settings : Form
    {
        private void LoadCategories()
        {
            List<string> categories = dbHelper.GetCategories();

            // Check if no categories exist
            if (categories == null || categories.Count == 0)
            {
                category.Items.Clear();
                category.Items.Add("There are no Categories");
                category.SelectedIndex = 0;

                // Disable the dropdown
                category.Enabled = false;  
                // Disable the Remove button 
                RemoveExpenseCategoryButton.Enabled = false;
            }
            else
            {
                category.Items.Clear();
                category.Items.AddRange(categories.ToArray()); 

                // Enable the dropdown
                category.Enabled = true;

                // Enable the Remove button
                RemoveExpenseCategoryButton.Enabled= true;
            }
        }

        private void LoadVendors()
        {
            List<string> vendors = dbHelper.GetVendors();

            // Check if no vendors exist
            if (vendors == null || vendors.Count == 0) 
            {
                vendor.Items.Clear();
                vendor.Items.Add("There are no Vendors.");
                vendor.SelectedIndex = 0;

                // Disable the dropdown
                vendor.Enabled = false;  

                // Disable the Remove button 
                RemoveExpenseVendorButton.Enabled= false;
            }
            else
            {
                vendor.Items.Clear();
                vendor.Items.AddRange(vendors.ToArray());

                // Enable the dropdown
                vendor.Enabled = true; 

                // Enable the Remove button
                RemoveExpenseVendorButton.Enabled= true;
            }
        }

        private DatabaseHelper dbHelper;

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
        private async Task CheckForUpdatesAsync()
        {
            string currentVersion = "1.0.0"; // Replace with your app's version
            string latestReleaseUrl = "https://api.github.com/repos/alexcr11/TrackSmart/releases/latest";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "TrackSmartApp"); // Required for GitHub API

                try
                {
                    // Fetch the latest release data from GitHub
                    string response = await client.GetStringAsync(latestReleaseUrl);
                    Console.WriteLine(response); // Log the raw response

                    var releaseData = JObject.Parse(response);

                    // Parse the latest version and download URL
                    string latestVersion = releaseData["tag_name"].ToString();
                    string downloadUrl = releaseData["assets"][0]["browser_download_url"].ToString();

                    if (latestVersion != currentVersion)
                    {
                        // Notify the user about the update
                        DialogResult result = MessageBox.Show(
                            $"A new version ({latestVersion}) is available! Would you like to download it?",
                            "Update Available",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);

                        if (result == DialogResult.Yes)
                        {
                            // Open the download URL in the user's default browser
                            Process.Start(new ProcessStartInfo
                            {
                                FileName = downloadUrl,
                                UseShellExecute = true
                            });
                        }
                    }
                    else
                    {
                        MessageBox.Show("You are using the latest version.", "No Updates", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error checking for updates: {ex.Message}", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnUpdateChecker_Click(object sender, EventArgs e)
        {
            await CheckForUpdatesAsync();
        }
    }
}
