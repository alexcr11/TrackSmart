using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TrackSmart
{
    public partial class Form1 : Form
    {
        List<Expense> expenseList = new List<Expense>();
        private int editingIndex = -1;  

        public Form1()
        {
            InitializeComponent();

            // Setup the ListView columns
            SetupListView();

            // Display any pre-existing expenses (if needed)
            DisplayExpenses();
        }

        // Add a new expense when the "Finish" button is clicked
        private void finishButton_Click(object sender, EventArgs e)
        {
            if (!ValidateExpenseFields()) return;

            DateTime selectedDate = date.Value;
            string selectedVendor = vendor.SelectedItem?.ToString();
            string selectedCategory = category.SelectedItem?.ToString();
            decimal amountSpent = decimal.Parse(amount.Text);

            Expense expense = new Expense(selectedDate, selectedVendor, selectedCategory, amountSpent);

            // Check if we are editing an existing expense
            if (editingIndex >= 0)
            {
                // Update the existing expense
                expenseList[editingIndex] = expense;

                // Reset editingIndex
                editingIndex = -1;

                // Update the ListView with the new expense
                DisplayExpenses();
            }
            else
            {
                // Add a new expense
                expenseList.Add(expense);
                DisplayNewExpense(expense);
            }

            expenseAddConfirmation();
            ClearForm();
        }



        private void expenseAddConfirmation()
        {
            MessageBox.Show("You have created a new expense");
        }

        // Display expenses in the ListView
        private void DisplayExpenses()
        {
            listViewExpenses.Items.Clear(); // Clear the ListView before adding new items

            foreach (var expense in expenseList)
            {
                // Create a new ListViewItem with the date as the main item
                ListViewItem item = new ListViewItem(expense.Date.ToString("MM/dd/yyyy"));

                // Add subitems for Vendor, Category, and Amount
                item.SubItems.Add(expense.Vendor);
                item.SubItems.Add(expense.Category);
                item.SubItems.Add(expense.Amount.ToString("C")); // "C" formats as currency

                // Add the ListViewItem to the ListView
                listViewExpenses.Items.Add(item);
            }
        }

        // Set up the ListView with columns
        private void SetupListView()
        {
            // Clear any existing columns
            listViewExpenses.Columns.Clear();

            // Add columns for Date, Vendor, Category, and Amount
            listViewExpenses.Columns.Add("Date", 100, HorizontalAlignment.Left);
            listViewExpenses.Columns.Add("Vendor", 150, HorizontalAlignment.Left);
            listViewExpenses.Columns.Add("Category", 100, HorizontalAlignment.Left);
            listViewExpenses.Columns.Add("Amount", 100, HorizontalAlignment.Right);

            // Ensure ListView is in Details view
            listViewExpenses.View = View.Details;

            // Enable full row selection for easier selection and deletion
            listViewExpenses.FullRowSelect = true;
        }

        // Clear the form after an expense is added
        private void ClearForm()
        {
            category.SelectedIndex = -1;
            vendor.SelectedIndex = -1;
            amount.Clear();
            date.Value = DateTime.Now;
        }

        // Delete the selected expense from the ListView and expense list
        private void btnDeleteExpense_Click(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (listViewExpenses.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this expense?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Get the index of the selected item in the ListView
                    int selectedIndex = listViewExpenses.SelectedItems[0].Index;

                    // Remove the corresponding expense from the expenseList
                    expenseList.RemoveAt(selectedIndex);

                    // Refresh the ListView to reflect the changes
                    DisplayExpenses();
                }
            }
            else
            {
                MessageBox.Show("Please select an expense to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DisplayNewExpense(Expense expense)
        {
            ListViewItem item = new ListViewItem(expense.Date.ToString("MM/dd/yyyy"));
            item.SubItems.Add(expense.Vendor);
            item.SubItems.Add(expense.Category);
            item.SubItems.Add(expense.Amount.ToString("C"));
            listViewExpenses.Items.Add(item);
        }

        private void btnEditSelected_Click(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (listViewExpenses.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to edit this expense?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Get the index of the selected item in the ListView
                    editingIndex = listViewExpenses.SelectedItems[0].Index;  // Track the index being edited
                    Expense selectedExpense = expenseList[editingIndex];

                    // Load selected expense data into the form for editing
                    date.Value = selectedExpense.Date;
                    vendor.SelectedItem = selectedExpense.Vendor;
                    category.SelectedItem = selectedExpense.Category;
                    amount.Text = selectedExpense.Amount.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please select an expense to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidateExpenseFields()
        {
            if (string.IsNullOrWhiteSpace(vendor.SelectedItem?.ToString()) ||
                string.IsNullOrWhiteSpace(category.SelectedItem?.ToString()) ||
                string.IsNullOrWhiteSpace(amount.Text))
            {
                MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(amount.Text, out _))
            {
                MessageBox.Show("Invalid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            settingsForm settingsForm = new settingsForm();
            settingsForm.ShowDialog();  // Use ShowDialog() for a modal window
        }

        private void btnYTD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Year-To-Date report feature not yet implemented.", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMTD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Month-To-Date report feature not yet implemented.", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
