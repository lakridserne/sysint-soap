using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SoapServer
{

    [DataContract]
    public class Order

    {

        private int _id;
        private string _name;
        private string _product;
        private int _price;


        [DataMember]
        public int ID
        { get { return _id; } set { _id = value; } }
        [DataMember]
        public string Name
        { get { return _name; } set { _name = value; } }
        [DataMember]
        public string Product
        { get { return _product; } set { _product = value; } }

        [DataMember]
        public int Price
        { get { return _price; } set { _price = value; } }


        public Order(int id, string name, string product, int price)
        {
            _id = id;
            _name = name;
            _product = product;
            _price = price;

        }


        public Order()
        {

        }

    }
}