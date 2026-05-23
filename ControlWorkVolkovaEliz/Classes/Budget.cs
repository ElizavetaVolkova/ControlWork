namespace BudgetTracker.Classes
{
    internal class Budget
    {
        public decimal MonthlyLimit { get; set; }
        public List<Consumption> Consumptions { get; set; }
        public int NextId { get; set; }

        public Budget()
        {
            MonthlyLimit = 0;
            Consumptions = new List<Consumption>();
            NextId = 1;
        }
    }
}
