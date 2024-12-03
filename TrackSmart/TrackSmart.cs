using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrackSmart.Properties;

namespace TrackSmart
{
    public partial class TrackSmart : Form
    {
        List<Expense> expenseList = new List<Expense>();
        private int editingIndex = -1;
        private DatabaseHelper dbHelper;

        public TrackSmart()
        {
            InitializeComponent();

            dbHelper = new DatabaseHelper();
            dbHelper.InitializeDatabase();

            SetupListView();
            DisplayExpenses();

            // Load categories and vendors into ComboBoxes
            LoadCategories();
            LoadVendors();

            // Attach the ColumnClick event to the ListView
            listViewExpenses.ColumnClick += new ColumnClickEventHandler(listViewExpenses_ColumnClick);
        }

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

        private int sortColumn = -1;

        private void listViewExpenses_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if the clicked column is the same as the previously clicked column.
            if (e.Column != sortColumn)
            {
                // Set the new sort column.
                sortColumn = e.Column;
                // Set the sort order to ascending by default.
                listViewExpenses.Sorting = SortOrder.Ascending;
            }
            else
            {
                // Toggle the sort order.
                listViewExpenses.Sorting = listViewExpenses.Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            }

            // Set the ListViewItemSorter property to a new ListViewItemComparer object.
            listViewExpenses.ListViewItemSorter = new ListViewItemComparer(e.Column, listViewExpenses.Sorting);

            // Call the sort method to manually sort.
            listViewExpenses.Sort();
        }

        public class ListViewItemComparer : System.Collections.IComparer
        {
            private int col;
            private SortOrder order;

            public ListViewItemComparer(int column, SortOrder sortOrder)
            {
                col = column;
                order = sortOrder;
            }

            public int Compare(object x, object y)
            {
                int returnVal = 0;

                // Parse date or numeric values when necessary
                if (col == 0) // Assuming the first column is the Id (numeric)
                {
                    returnVal = int.Parse(((ListViewItem)x).SubItems[col].Text).CompareTo(
                                int.Parse(((ListViewItem)y).SubItems[col].Text));
                }
                else if (col == 1) // Assuming the Date column (date sorting)
                {
                    returnVal = DateTime.Parse(((ListViewItem)x).SubItems[col].Text).CompareTo(
                                DateTime.Parse(((ListViewItem)y).SubItems[col].Text));
                }
                else // Default to string comparison
                {
                    returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
                                               ((ListViewItem)y).SubItems[col].Text);
                }

                // Return ascending or descending based on order
                if (order == SortOrder.Descending) returnVal = -returnVal;

                return returnVal;
            }
        }


        // Add a new expense when the "Finish" button is clicked
        private void finishButton_Click(object sender, EventArgs e)
        {
            if (!ValidateExpenseFields()) return;

            DateTime selectedDate = date.Value;
            string selectedVendor = vendor.SelectedItem?.ToString();
            string selectedCategory = category.SelectedItem?.ToString();
            decimal amountSpent = decimal.Parse(amount.Text);

            if (editingIndex >= 0)
            {
                // Update the existing expense in the database
                dbHelper.UpdateExpense(editingIndex, selectedDate, selectedCategory, selectedVendor, amountSpent);

                // Reset editingIndex after saving
                editingIndex = -1;
            }
            else
            {
                // Add the expense to the database
                dbHelper.AddExpense(selectedDate, selectedCategory, selectedVendor, amountSpent);
            }

            // Refresh the ListView by retrieving all expenses from the database
            DisplayExpenses();

            // Provide user feedback
            expenseAddConfirmation();
            ClearForm();
        }



        private void expenseAddConfirmation()
        {
            MessageBox.Show("You have created a new expense");
        }

        private void DisplayExpenses()
        {
            // Clear the ListView before adding new items
            listViewExpenses.Items.Clear();

            // Retrieve all expenses from the database
            List<Expense> expenses = dbHelper.GetExpenses();

            // Loop through each expense and add it to the ListView
            foreach (var expense in expenses)
            {
                // Create a new ListViewItem with the Id as the main item
                ListViewItem item = new ListViewItem(expense.Id.ToString());

                // Add subitems for Date, Vendor, Category, and Amount
                item.SubItems.Add(expense.Date.ToString("MM/dd/yyyy"));
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

            // Add columns for Id, Date, Vendor, Category, and Amount
            listViewExpenses.Columns.Add("Id", 50, HorizontalAlignment.Left);  
            listViewExpenses.Columns.Add("Date", 100, HorizontalAlignment.Left);
            listViewExpenses.Columns.Add("Category", 100, HorizontalAlignment.Left);
            listViewExpenses.Columns.Add("Vendor", 150, HorizontalAlignment.Left);
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
                    // Get the Id of the selected item in the ListView
                    int selectedId = int.Parse(listViewExpenses.SelectedItems[0].SubItems[0].Text); // Assuming Id is stored as the first column

                    // Delete the corresponding expense from the database
                    dbHelper.DeleteExpense(selectedId);

                    // Refresh the ListView to reflect the changes
                    DisplayExpenses();
                }
            }
            else
            {
                MessageBox.Show("Please select an expense to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void RefreshData()
        {
            LoadCategories(); // Reload categories into the ComboBox
            LoadVendors();    // Reload vendors into the ComboBox
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
                    // Get the Id of the selected item in the ListView
                    int selectedId = int.Parse(listViewExpenses.SelectedItems[0].SubItems[0].Text); // Assuming Id is stored as the first column

                    // Retrieve the expense with the specified Id from the database
                    Expense selectedExpense = dbHelper.GetExpenseById(selectedId); // You'll need to implement this method

                    if (selectedExpense != null)
                    {
                        // Load selected expense data into the form for editing
                        date.Value = selectedExpense.Date;
                        vendor.SelectedItem = selectedExpense.Vendor;
                        category.SelectedItem = selectedExpense.Category;
                        amount.Text = selectedExpense.Amount.ToString();

                        // Track the Id for saving edits later
                        editingIndex = selectedExpense.Id;
                    }
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
            Settings settingsForm = new Settings();
            settingsForm.Owner = this; // Set MainForm as the owner
            settingsForm.ShowDialog();  
        }

        private void btnYTD_Click(object sender, EventArgs e)
        {
            //this code should send the expense list YTD data to the new form to prefill the details needed in the form
            ExpenseViewer expenseViewer = new ExpenseViewer();
            expenseViewer.Owner = this;
            expenseViewer.ShowDialog();
        }

        private void btnMTD_Click(object sender, EventArgs e)
        {
            //this code should send the expense list data to the new form to prefill the details needed in the form
            ExpenseViewer expenseViewer = new ExpenseViewer();
            expenseViewer.Owner = this;
            expenseViewer.ShowDialog();
        }
    }
}
