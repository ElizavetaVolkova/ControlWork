using System;
namespace BudgetTracker.Classes
{
    public class Consumption
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; } 
        public bool IsEssential { get; set; }

        public Consumption() { }

        public Consumption(string title, decimal amount, string category, DateTime date, bool isEssential)
        {
            Title = title;
            Amount = amount;
            Category = category;
            Date = date;
            IsEssential = isEssential;
        }
    }
}