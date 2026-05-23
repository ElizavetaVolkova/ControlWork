namespace BudgetTracker.Classes
{
    public static class Logger
    {
        private static readonly string logFile = "budget_log.txt";

        public static void Log(string message)
        {
            string logEntry = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - " + message;
                File.AppendAllText(logFile, logEntry + "\r\n");
        }
    }
}