using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestServer
{

    public class Service1 : IService1
    {

        private static IList<Order> orderList = new List<Order>();
        private static bool firsttime = true;


        public Service1()
        {
            if (firsttime)
            {
                orderList.Add(new Order { ID = 1, Name = "Hassan", Price = 5, Product = "æble" });
                orderList.Add(new Order { ID = 2, Name = "Gordan", Price = 3, Product = "Pære" });
                orderList.Add(new Order { ID = 3, Name = "Hussain", Price = 2, Product = "Appelsin" });
                orderList.Add(new Order { ID = 4, Name = "Kristoffer", Price = 4, Product = "Banan" });
                orderList.Add(new Order { ID = 5, Name = "Hazem", Price = 15, Product = "Mango" });
                firsttime = false;
            }
        }


        public IList<Order> GetallOrders()
        {
            return orderList;

        }


        public Order FindOrder(string orderID)
        {
            return orderList.Single(x => x.ID.ToString() == orderID);

        }


        public void DeleteOrder(string orderID)
        {

            foreach (var orders in orderList)
            {
                if (orderID == orders.ID.ToString())
                {
                    orderList.Remove(orders);
                }
            }

        }

        public void InsertOrder(Order order)
        {
            foreach (var orders in orderList)
            {
                if (orders.ID.Equals(order.ID))
                {
                    throw new ArgumentException("Duplicated id");
                }
            }

            orderList.Add(order);
        }



        public void UpdateOrder(Order order, string orderID)
        {
            foreach (var orders in orderList)
            {
                var obj = orderList.FirstOrDefault(x => x.ID.ToString() == orderID);
                if (obj != null)
                {
                    orders.Name = order.Name;
                    orders.Price = order.Price;
                    orders.Product = order.Product;
                }
            }
        }

    }
}
