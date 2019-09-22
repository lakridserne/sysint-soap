using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SoapServer
{
    
    public class Service1 : IService1
    {
        private static List<Order> orderList = new List<Order>();
        private static bool firsttime = true;

   

        public Service1()
        {
            if (firsttime)
            {
                orderList.Add(new Order { ID = 1, Name = "Hassan", Price = 5, Product = "æble" });
                orderList.Add(new Order { ID = 2, Name = "Gordan", Price = 3, Product = "Pære" });
                orderList.Add(new Order { ID = 3, Name = "Hussain", Price = 2, Product = "Appelsin" });
                orderList.Add(new Order { ID = 4, Name = "Christoffer", Price = 4, Product = "Banan" });
                orderList.Add(new Order { ID = 5, Name = "Hazem", Price = 15, Product = "Mango" });
                firsttime = false;
            }
        }
        

        public List<Order> GetallOrders()
        {
            return orderList;

        }


        public Order FindOrder(int id)
        {
            return orderList.Single(x => x.ID == id);

        }


        public void DeleteOrder(int id)
        {

            orderList.Remove(FindOrder(id));

        }


        public void AddOrder(int id, string name, string product , int price)
        {
            Order o1 = new Order { Name = name, ID = id, Product = product, Price = price };

            orderList.Add(o1);

        }


        public void UpdateOrder(int id, string name, string product, int price)
        {

            var Order = this.FindOrder(id);
            Order.Name = name;
            Order.Product = product;
            Order.Price = price;
        }
    }
}
