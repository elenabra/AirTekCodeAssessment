using System.Text.Json;

namespace AirFreightService
{
    public class JsonOrdersLoader : IOrdersLoader
    {
        /// <summary>
        /// Path to Json file of orders
        /// </summary>
        private string _jsonFilePath;

        public JsonOrdersLoader(string jsonFilePath) 
        { 
            _jsonFilePath = jsonFilePath;
        }

        /// <summary>
        /// Load list of orders from a json file
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, Order> LoadOrders()
        {
            try
            {
                string json = File.ReadAllText(_jsonFilePath);
                return JsonSerializer.Deserialize<Dictionary<string,Order>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to load orders from json file: {ex.Message}");
                return new Dictionary<string,Order>();
            }
        }   
    }
}
