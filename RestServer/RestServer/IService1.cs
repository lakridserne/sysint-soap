using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestServer
{

    //[OperationContract]
    //[WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "Getorder/{id}")]
    //Order FindOrder(string id);


    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebInvoke(Method="GET", ResponseFormat = WebMessageFormat.Json, UriTemplate ="Getall/")]
        IList<Order> GetallOrder();

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "Getorder/{id}")]
        Order FindOrder(string id);

        //[OperationContract]
        //void DeleteOrder(int id);

        //[OperationContract]
        //void AddOrder(int id, string name, string product, int price);

        //[OperationContract]
        //void UpdateOrder(int id, string name, string product, int price);
    }
}


 
