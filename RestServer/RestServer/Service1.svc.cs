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

        private static IList<Order> order = new List<Order>();
        private static bool firsttime = true;


        public Service1()
        {
            if (firsttime)
            {
                order.Add(new Order { ID = 1, Name = "Hassan", Price = 5, Product = "æble" });
                order.Add(new Order { ID = 2, Name = "Gordan", Price = 3, Product = "Pære" });
                order.Add(new Order { ID = 3, Name = "Hussain", Price = 2, Product = "Appelsin" });
                order.Add(new Order { ID = 4, Name = "Christoffer", Price = 4, Product = "Banan" });
                order.Add(new Order { ID = 5, Name = "Hazem", Price = 15, Product = "Mango" });
                firsttime = false;
            }
        }


        public IList<Order> GetallOrder()
        {
            return order;

        }


        public Order FindOrder(string id)
        {
            return order.Single(x => x.ID.ToString() == id);

        }


        public void DeleteOrder(int id)
        {

            order.Remove(FindOrder(id.ToString()));

        }


        //public void AddOrder(int id, string name, string product, int price)
        //{
        //    Order o1 = new Order { Name = name, ID = id, Product = product, Price = price };

        //    order.Add(o1);

        //}


        //public void UpdateOrder(int id, string name, string product, int price)
        //{

        //    var Order = this.FindOrder(id);
        //    Order.Name = name;
        //    Order.Product = product;
        //    Order.Price = price;


        //}

    }
}
