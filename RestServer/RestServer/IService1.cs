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
        [WebInvoke(Method="GET", ResponseFormat = WebMessageFormat.Json, UriTemplate ="getall/")]
        IList<Order> GetallOrders();

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "getorder/{id}")]
        Order FindOrder(string id);

        [OperationContract]
        [WebInvoke(Method = "DELETE",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "order/{id}")]
        void DeleteOrder(string id);


        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "order/")]
        void InsertOrder(Order order);

        [OperationContract]
        [WebInvoke(Method = "PUT",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare, UriTemplate = "order/{id}")]
        void UpdateOrder(Order order, string id);

    }
}


 
