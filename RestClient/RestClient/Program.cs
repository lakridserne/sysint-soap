using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RestClient
{
    class Order
    {
        private int _id;
        private string _name;
        private string _product;
        private int _price;

        public int ID { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Product { get => _product; set => _product = value; }
        public int Price { get => _price; set => _price = value; }
    }
    class Program
    {
        static HttpClient client = new HttpClient();
        static void ShowOrder(Order order)
        {
            Console.WriteLine($"Product: {order.Product}\tPrice: " +
                $"{order.Price}\tBought by: {order.Name}");
        }

        static async Task<Uri> CreateOrderAsync(Order order)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "/order/", order);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        static async Task<Order> GetOrderAsync(string path)
        {
            Order order = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                order = await response.Content.ReadAsAsync<Order>();
            }
            return order;
        }

        static async Task<Order> UpdateOrderAsync(Order order)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"/order/{order.ID}", order);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            order = await response.Content.ReadAsAsync<Order>();
            return order;
        }

        static async Task<HttpStatusCode> DeleteOrderAsync(string id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"/order/{id}");
            return response.StatusCode;
        }
        static async Task<List<Order>> GetOrdersAsync()
        {
            HttpResponseMessage response = await client.GetAsync(
                $"/getall/");
            var responsecontent = HttpResponseMessage.Content.ReadAsAsync<List<Order>>;
        }
        static void Main(string[] args)
        {
            RunAsync().GetAwaiter().GetResult();
        }


        static async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("https://restserversysint.azurewebsites.net/Service1.svc");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
             new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                // Get orders
                String orders = GetOrdersAsync();
                // Create a new order
                Order order = new Order
                {
                    ID = 6,
                    Name = "Hjalte",
                    Product = "Mango",
                    Price = 100
                };

                var url = await CreateOrderAsync(order);
                Console.WriteLine($"Created at {url}");

                // Get the order
                order = await GetOrderAsync(url.PathAndQuery);
                ShowOrder(order);

                // Update the order
                Console.WriteLine("Updating price...");
                order.Price = 80;
                await UpdateOrderAsync(order);

                // Get the updated order
                order = await GetOrderAsync(url.PathAndQuery);
                ShowOrder(order);

                // Delete the order
                var statusCode = await DeleteOrderAsync(order.ID.ToString());
                Console.WriteLine($"Deleted (HTTP Status = {(int)statusCode})");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
