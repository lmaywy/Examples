using Examples.MVC.Calculator;
using Examples.MVC.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Examples.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var wcfClient = new CalculatorServiceClient();
            var ret = wcfClient.Add(1, 2);

            var soapClient = new SearchSoapClient();
            var student = soapClient.Serach("zhang san");
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