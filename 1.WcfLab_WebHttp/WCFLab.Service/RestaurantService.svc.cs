using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFLab.Domains;

namespace WCFLab.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class RestaurantService : IRestaurantService
    {
        public Restaurant GetRestaurant(int id)
        {
            var result = new Restaurant { Id = id, Name = "DumplingKing", Address = "Just next to your home.", PhoneNumber = "23456789" };
            return result;
        }

        public Restaurant SaveRestaurant(Restaurant restaurant)
        {
            return restaurant;
        }
    }
    
}
