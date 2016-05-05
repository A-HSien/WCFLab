using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Text;
using System.Web.Script.Serialization;
using System.ServiceModel;

using WCFLab.Domains;
using WCFLab.IService;

namespace WCFLab.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var client = new HttpClient();
            var serializer= new JavaScriptSerializer();

            var getResult = client.GetAsync("http://localhost/WCFLabService/RestaurantService.svc/GetRestaurant?id=12").Result;

            var restaurant = new Restaurant() { Id = 123, Name = "水餃王", Address = "你家旁邊", PhoneNumber = "23456789" };

            var jsonString= serializer.Serialize(new { restaurant= restaurant });
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var postResponse = client.PostAsync("http://localhost/WCFLabService/RestaurantService.svc/SaveRestaurant", content).Result;
            var postContent = postResponse.Content.ReadAsStringAsync().Result;
            var postResult = serializer.Deserialize<dynamic>(postContent)["SaveRestaurantResult"];
            var newRestaurant = new Restaurant(postResult);


            var factory = new ChannelFactory<IRestaurantService>("IRestaurantService");
            var channel = factory.CreateChannel();
            var resultFromTcpCall = channel.GetRestaurant(9);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}