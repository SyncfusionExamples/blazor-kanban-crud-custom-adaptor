using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace BlazorApp1.Data
{
    public class OrderService
    {
        string baseUrl = "https://localhost:44311/";
        public async Task<List<Order>> GetOrdersAsync()
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/Default");
            return JsonConvert.DeserializeObject<List<Order>>(json);
        }
    }
}
