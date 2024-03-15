using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace KanbanWithCrudCustomAdaptor.Models
{
    public class OrderService
    {
        string baseUrl = "https://localhost:44308/";
        public async Task<List<OrderDetail>> GetOrdersAsync()
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/Default");
            return JsonConvert.DeserializeObject<List<OrderDetail>>(json);
        }
    }
}
