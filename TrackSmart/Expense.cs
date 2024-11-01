using System;

namespace TrackSmart
{
    public class Expense
    {
        public int Id { get; set; } // New Id property
        public DateTime Date { get; set; }
        public string Vendor { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }

        public Expense(DateTime date, string vendor, string category, decimal amount)
        {
            Date = date;
            Vendor = vendor;
            Category = category;
            Amount = amount;
        }

        // Optional overloaded constructor for setting Id if needed
        public Expense(int id, DateTime date, string vendor, string category, decimal amount)
        {
            Id = id;
            Date = date;
            Vendor = vendor;
            Category = category;
            Amount = amount;
        }
    }
}
