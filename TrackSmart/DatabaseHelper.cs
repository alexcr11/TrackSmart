using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using TrackSmart;

public class DatabaseHelper
{
    private string dbFilePath = "expenses.db"; // This points to the database file in the project directory.

    public void InitializeDatabase()
    {
        // Check if the database file exists in the output directory
        if (!File.Exists(dbFilePath))
        {
            SQLiteConnection.CreateFile(dbFilePath);
        }

        // Create the Expenses table if it doesn't exist
        using (var connection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;"))
        {
            connection.Open();

            string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS Expenses (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Date TEXT,
                    Category TEXT,
                    Vendor TEXT,
                    Amount REAL
                )";
            SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);
            command.ExecuteNonQuery();

            // Create the Categories table if it doesn't exist
            string createCategoriesTableQuery = @"
            CREATE TABLE IF NOT EXISTS Categories (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT UNIQUE NOT NULL
            )";
            SQLiteCommand createCategoriesCommand = new SQLiteCommand(createCategoriesTableQuery, connection);
            createCategoriesCommand.ExecuteNonQuery();

            // Create the Vendors table if it doesn't exist
            string createVendorsTableQuery = @"
            CREATE TABLE IF NOT EXISTS Vendors (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT UNIQUE NOT NULL
            )";
            SQLiteCommand createVendorsCommand = new SQLiteCommand(createVendorsTableQuery, connection);
            createVendorsCommand.ExecuteNonQuery();
        }
    }

    public void AddVendor(string vendorName)
    {
        using (var connection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;"))
        {
            connection.Open();
            string insertQuery = "INSERT INTO Vendors (Name) VALUES (@Name)"; // Adjust table/column names if needed

            using (var command = new SQLiteCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@Name", vendorName);
                command.ExecuteNonQuery();
            }
        }
    }

    public List<string> GetVendors()
    {
        List<string> vendors = new List<string>();

        using (var connection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;"))
        {
            connection.Open();
            string selectQuery = "SELECT Name FROM Vendors";

            using (var command = new SQLiteCommand(selectQuery, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    vendors.Add(reader.GetString(0));
                }
            }
        }

        return vendors;
    }

    public void AddCategory(string categoryName)
    {
        using (var connection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;"))
        {
            connection.Open();
            string insertQuery = "INSERT INTO Categories (Name) VALUES (@Name)"; // Adjust table/column names if needed

            using (var command = new SQLiteCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@Name", categoryName);
                command.ExecuteNonQuery();
            }
        }
    }

    public void RemoveCategory(string categoryName)
    {
        using (var connection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;"))
        {
            connection.Open();
            string deleteQuery = "DELETE FROM Categories WHERE Name = @Name";

            using (var command = new SQLiteCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@Name", categoryName);
                command.ExecuteNonQuery();
            }
        }
    }

    public void RemoveVendor(string vendorName)
    {
        using (var connection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;"))
        {
            connection.Open();
            string deleteQuery = "DELETE FROM Vendors WHERE Name = @Name";

            using (var command = new SQLiteCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@Name", vendorName);
                command.ExecuteNonQuery();
            }
        }
    }

    public List<string> GetCategories()
    {
        List<string> categories = new List<string>();

        using (var connection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;"))
        {
            connection.Open();
            string selectQuery = "SELECT Name FROM Categories";

            using (var command = new SQLiteCommand(selectQuery, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    categories.Add(reader.GetString(0));
                }
            }
        }
        return categories;
    }


    public void AddExpense(DateTime date, string category, string vendor, decimal amount)
    {
        using (var connection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;"))
        {
            connection.Open();
            string insertQuery = @"
            INSERT INTO Expenses (Date, Category, Vendor, Amount) 
            VALUES (@Date, @Category, @Vendor, @Amount)";

            SQLiteCommand command = new SQLiteCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@Date", date.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@Category", category);
            command.Parameters.AddWithValue("@Vendor", vendor);
            command.Parameters.AddWithValue("@Amount", amount);

            command.ExecuteNonQuery();
        }
    }

    public List<Expense> GetExpenses()
    {
        List<Expense> expenses = new List<Expense>();

        using (var connection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;"))
        {
            connection.Open();
            string selectQuery = "SELECT * FROM Expenses";

            using (var command = new SQLiteCommand(selectQuery, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Use the constructor that includes all necessary parameters, including Id
                    Expense expense = new Expense(
                        reader.GetInt32(0), // Id
                        DateTime.Parse(reader.GetString(1)), // Date
                        reader.GetString(2), // Category
                        reader.GetString(3), // Vendor
                        reader.GetDecimal(4)  // Amount
                    );

                    expenses.Add(expense);
                }
            }
        }

        return expenses;
    }

    public Expense GetExpenseById(int id)
    {
        Expense expense = null;

        using (var connection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;"))
        {
            connection.Open();
            string selectQuery = "SELECT * FROM Expenses WHERE Id = @Id";

            using (var command = new SQLiteCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        expense = new Expense(
                            reader.GetInt32(0),
                            DateTime.Parse(reader.GetString(1)),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetDecimal(4)
                        );
                    }
                }
            }
        }

        return expense;
    }

    public void UpdateExpense(int id, DateTime date, string category, string vendor, decimal amount)
    {
        using (var connection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;"))
        {
            connection.Open();
            string updateQuery = @"
            UPDATE Expenses 
            SET Date = @Date, Category = @Category, Vendor = @Vendor, Amount = @Amount 
            WHERE Id = @Id";

            using (var command = new SQLiteCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Date", date.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@Category", category);
                command.Parameters.AddWithValue("@Vendor", vendor);
                command.Parameters.AddWithValue("@Amount", amount);

                command.ExecuteNonQuery();
            }
        }
    }

    public void DeleteExpense(int id)
    {
        using (var connection = new SQLiteConnection($"Data Source={dbFilePath};Version=3;"))
        {
            connection.Open();
            string deleteQuery = "DELETE FROM Expenses WHERE Id = @Id";

            using (var command = new SQLiteCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
