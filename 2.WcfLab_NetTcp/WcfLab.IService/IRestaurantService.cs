using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using WCFLab.Domains;

namespace WCFLab.IService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IRestaurantService
    {

        [OperationContract]
        [WebInvoke(Method = "GET")]
        Restaurant GetRestaurant(int id);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat =WebMessageFormat.Json)]
        Restaurant SaveRestaurant(Restaurant restaurant);

    }


}
