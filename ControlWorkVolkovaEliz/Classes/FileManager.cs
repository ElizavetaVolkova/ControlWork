using BudgetTracker.Classes;
using System.Text.Json;

namespace BudgetTracker.Classes
{
    internal class FileManager
    {
        private static readonly string filePath = "budget.json";

        public static Budget LoadData()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    Budget data = JsonSerializer.Deserialize<Budget>(json);
                    if (data != null)
                    {
                        return data;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"Ошибка загрузки: {ex.Message}");
            }
            return new Budget();
        }

        public static void SaveData(Budget data)
        {
            try
            {
                string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
                Logger.Log("Данные сохранены");
            }
            catch (Exception ex)
            {
                Logger.Log($"Ошибка сохранения: {ex.Message}");
            }
        }
    }
}