using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoapClient.ServiceReference1;

namespace SoapClient
{
    class Program
    {
        static Service1Client client = new Service1Client();
        static void Main(string[] args)
        {
            // Get all orders
            var allOrders = client.GetallOrders();
        }
    }
}
