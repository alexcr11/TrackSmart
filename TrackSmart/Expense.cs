using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackSmart
{
    public class Expense
    {
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
    }
}
