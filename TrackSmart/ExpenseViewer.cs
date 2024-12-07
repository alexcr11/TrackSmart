using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;


namespace TrackSmart
{
    public partial class ExpenseViewer : Form
    {
        private DatabaseHelper dbHelper;

        private List<Expense> expenses; 

        // Constructor to accept the existing expenses list
        public ExpenseViewer(List<Expense> expenses)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial;
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            dbHelper.InitializeDatabase();
            // Load categories and vendors into ComboBoxes
            LoadCategories();
            LoadVendors();
            this.expenses = expenses; // Use the passed-in expenses list
        }

        private void LoadCategories()
        {
            List<string> categories = dbHelper.GetCategories();
            comboBoxCategory.Items.Clear();
            comboBoxCategory.Items.AddRange(categories.ToArray());
        }

        private void LoadVendors()
        {
            List<string> vendors = dbHelper.GetVendors();
            comboBoxVendor.Items.Clear();
            comboBoxVendor.Items.AddRange(vendors.ToArray());
        }

        private void ExpenseViewer_Load(object sender, EventArgs e)
        {
            // Get the current year
            int currentYear = DateTime.Now.Year;

            // Populate the Year dropdown with years from 2020 to 2030, including 5 years before and 5 years after the current year
            comboBoxYear.Items.Clear();

            // Add years from 5 years before the current year to 5 years after
            for (int year = currentYear - 5; year <= currentYear + 5; year++)
            {
                comboBoxYear.Items.Add(year.ToString());
            }

            // Optionally, add other years to expand the range (like from 2020 to 2030)
            for (int year = 2020; year <= 2030; year++)
            {
                if (!comboBoxYear.Items.Contains(year.ToString())) // Avoid duplicates
                {
                    comboBoxYear.Items.Add(year.ToString());
                }
            }

            // Populate Month dropdown
            comboBoxMonth.Items.Clear();
            comboBoxMonth.Items.AddRange(new string[] {
                "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"
            });

            dataGridViewExpenses.DataSource = expenses; // Display all expenses initially
            SetupDataGridView(); // Set up the columns correctly
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Collect filter criteria
            string selectedYear = comboBoxYear.SelectedItem?.ToString();
            string selectedMonth = comboBoxMonth.SelectedItem?.ToString();
            string selectedCategory = comboBoxCategory.SelectedItem?.ToString();
            string selectedVendor = comboBoxVendor.SelectedItem?.ToString();

            // If selectedYear is null or empty and selectedMonth is not, set selectedYear to the current year.
            if (string.IsNullOrEmpty(selectedYear) && !string.IsNullOrEmpty(selectedMonth) || string.IsNullOrEmpty(selectedYear) && string.IsNullOrEmpty(selectedMonth))
            {
                comboBoxYear.Text = DateTime.Now.Year.ToString();
                selectedYear = DateTime.Now.Year.ToString();
            }

            // Convert selectedMonth to the corresponding numeric value (1-12)
            int selectedMonthNumber = 0;
            if (!string.IsNullOrEmpty(selectedMonth))
            {
                // Ensure the month matches correctly using the Month name
                selectedMonthNumber = DateTime.ParseExact(selectedMonth, "MMMM", System.Globalization.CultureInfo.InvariantCulture).Month;
            }

            // Search filter logic: Filter based on selected year, month, category, and vendor
            var filteredExpenses = expenses
                .Where(exp =>
                    (string.IsNullOrEmpty(selectedYear) || exp.Date.Year.ToString() == selectedYear) &&
                    (selectedMonthNumber == 0 || exp.Date.Month == selectedMonthNumber) &&  // Correctly compare numeric month value
                    (string.IsNullOrEmpty(selectedCategory) || exp.Category == selectedCategory) &&
                    (string.IsNullOrEmpty(selectedVendor) || exp.Vendor == selectedVendor))
                .ToList();

            // Group the filtered expenses by Vendor
            var groupedExpenses = filteredExpenses
                .GroupBy(exp => exp.Vendor)  // First group by Vendor
                .Select(group => new
                {
                    Vendor = group.Key,
                    TotalAmount = group.Sum(exp => exp.Amount),
                    Expenses = group.ToList() // Hold the individual expenses if needed
                })
                .ToList();

            // Now, group by Category within each Vendor (if needed)
            var finalGrouped = groupedExpenses
                .Select(group => new
                {
                    Vendor = group.Vendor,
                    Categories = group.Expenses
                        .GroupBy(exp => exp.Category) // Now group by Category inside Vendor
                        .Select(catGroup => new
                        {
                            Category = catGroup.Key,
                            TotalAmount = catGroup.Sum(exp => exp.Amount)
                        })
                        .ToList()
                })
                .ToList();

            // Display the final grouped data in the DataGridView
            dataGridViewExpenses.DataSource = finalGrouped.SelectMany(vendorGroup =>
                vendorGroup.Categories.Select(catGroup => new
                {
                    Vendor = vendorGroup.Vendor,
                    Category = catGroup.Category,
                    TotalAmount = catGroup.TotalAmount
                })).ToList();
        }


        private void ExportToExcel()
        {
            // Get the filtered list from the DataGridView, assuming the DataGridView is already populated
            var dataTable = new DataTable();

            // Add columns to DataTable based on DataGridView columns
            foreach (DataGridViewColumn column in dataGridViewExpenses.Columns)
            {
                dataTable.Columns.Add(column.HeaderText);
            }

            // Add rows to DataTable
            foreach (DataGridViewRow row in dataGridViewExpenses.Rows)
            {
                if (!row.IsNewRow) // Avoid adding empty row
                {
                    DataRow dataRow = dataTable.NewRow();
                    for (int i = 0; i < dataGridViewExpenses.Columns.Count; i++)
                    {
                        dataRow[i] = row.Cells[i].Value;
                    }
                    dataTable.Rows.Add(dataRow);
                }
            }

            // File saving logic
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;

            string selectedYear = comboBoxYear.SelectedItem?.ToString();
            string selectedMonth = comboBoxMonth.SelectedItem?.ToString();
            string selectedCategory = comboBoxCategory.SelectedItem?.ToString();
            string selectedVendor = comboBoxVendor.SelectedItem?.ToString();

            // Validate the year input and use current year if invalid or empty
            int filterYear = currentYear;
            if (!string.IsNullOrEmpty(selectedYear) && int.TryParse(selectedYear, out int parsedYear))
            {
                filterYear = parsedYear;
            }

            // Convert the selected month name to a numeric month (1-12)
            int filterMonth = currentMonth;
            if (!string.IsNullOrEmpty(selectedMonth))
            {
                // Ensure the month matches correctly using the Month name
                filterMonth = DateTime.ParseExact(selectedMonth, "MMMM", System.Globalization.CultureInfo.InvariantCulture).Month;
            }

            // Generate the Excel file name based on the selected filters
            string fileName;
            string vendorPart = string.IsNullOrEmpty(selectedVendor) ? "" : $"_{selectedVendor}";
            string categoryPart = string.IsNullOrEmpty(selectedCategory) ? "" : $"_{selectedCategory}";

            if (string.IsNullOrEmpty(selectedMonth) && string.IsNullOrEmpty(selectedCategory) && string.IsNullOrEmpty(selectedVendor))
            {
                // Only year is selected
                fileName = $"Expenses-{filterYear}.xlsx";
            }
            else
            {
                // If a month is selected, include it in the file name
                fileName = $"Expenses{filterMonth:D2}-{filterYear}{vendorPart}{categoryPart}.xlsx";
            }

            if (string.IsNullOrEmpty(selectedYear) && string.IsNullOrEmpty(categoryPart) && string.IsNullOrEmpty(vendorPart) && string.IsNullOrEmpty(selectedMonth))
            {
                fileName = $"AllExpenses.xlsx";
            }

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", fileName);

            // Check if the file already exists in the Downloads folder
            if (File.Exists(path))
            {
                DialogResult result = MessageBox.Show($"A file with the name '{fileName}' already exists. Do you want to overwrite it?", "File Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                // If user chooses 'No', exit the method
                if (result == DialogResult.No)
                {
                    MessageBox.Show("File not saved. Operation canceled.");
                    return; // Exit the method without saving the file
                }
            }

            // Save the Excel file, handling overwrite
            try
            {
                // If the file exists and user wants to overwrite, simply delete it first
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                // Create a new ExcelPackage and add the data to it
                using (var package = new ExcelPackage(new FileInfo(path)))
                {
                    var worksheet = package.Workbook.Worksheets.Add("Expenses");
                    worksheet.Cells.LoadFromDataTable(dataTable, true);  // Load the DataTable into the worksheet

                    // Apply styling to the header row
                    using (var header = worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
                    {
                        header.Style.Font.Bold = true;
                        header.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        header.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                        header.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        header.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                    }

                    // Apply styling to the data rows
                    using (var data = worksheet.Cells[2, 1, worksheet.Dimension.End.Row, worksheet.Dimension.End.Column])
                    {
                        data.Style.Font.Name = "Arial";
                        data.Style.Font.Size = 10;
                        data.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                    }

                    // Auto-fit columns based on content
                    for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                    {
                        worksheet.Column(col).AutoFit();
                    }

                    // Add borders around all the data cells (including header)
                    using (var range = worksheet.Cells[1, 1, worksheet.Dimension.End.Row, worksheet.Dimension.End.Column])
                    {
                        range.Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        range.Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        range.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        range.Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    }

                    // Save the file
                    package.Save();  // Save the file (this will overwrite the file if it exists)
                }

                MessageBox.Show($"Excel file saved successfully to {path}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the file: {ex.Message}");
            }
        }


        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            // Clear the filters
            comboBoxYear.SelectedIndex = -1;
            comboBoxMonth.SelectedIndex = -1;
            comboBoxCategory.SelectedIndex = -1;
            comboBoxVendor.SelectedIndex = -1;

            // Reset DataGridView to show all expenses
            dataGridViewExpenses.DataSource = expenses;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form
            Close();
        }
        private void SetupDataGridView()
        {
            // Clear any existing columns
            dataGridViewExpenses.Columns.Clear();

            // Add columns for Date, Vendor, Category, and Amount in the desired order
            dataGridViewExpenses.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Date",
                DataPropertyName = "Date",
                Width = 100
            });

            dataGridViewExpenses.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Vendor",
                DataPropertyName = "Vendor", // Vendor is displayed here
                Width = 150
            });

            dataGridViewExpenses.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Category",
                DataPropertyName = "Category", // Category is displayed here
                Width = 150
            });

            dataGridViewExpenses.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Amount",
                DataPropertyName = "Amount",
                Width = 100
            });
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            // Filtered expenses from the search results
            var filteredExpenses = expenses
                .Where(exp =>
                    (string.IsNullOrEmpty(comboBoxYear.SelectedItem?.ToString()) || exp.Date.Year.ToString() == comboBoxYear.SelectedItem?.ToString()) &&
                    (string.IsNullOrEmpty(comboBoxMonth.SelectedItem?.ToString()) || exp.Date.ToString("MMMM") == comboBoxMonth.SelectedItem?.ToString()) &&
                    (string.IsNullOrEmpty(comboBoxCategory.SelectedItem?.ToString()) || exp.Category == comboBoxCategory.SelectedItem?.ToString()) &&
                    (string.IsNullOrEmpty(comboBoxVendor.SelectedItem?.ToString()) || exp.Vendor == comboBoxVendor.SelectedItem?.ToString()))
                .ToList();

            // Call the ExportToExcel method with the filtered expenses
            if (filteredExpenses.Any())
            {
                ExportToExcel();
            }
            else
            {
                MessageBox.Show("No expenses to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
