using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SoapServer
{

    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<Order> GetallOrders();

        [OperationContract]
        Order FindOrder(int id);

        [OperationContract]
        void DeleteOrder(int id);

        [OperationContract]
        void AddOrder(int id, string name, string product, int price);

        [OperationContract]
        void UpdateOrder(int id, string name, string product, int price);
    }

}
