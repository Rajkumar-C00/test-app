using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            string version = "1.0";
            version = ConfigurationManager.AppSettings["webpages:Version"];

            ViewBag.Message = $"Your Version {version} application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            string version = "1.0";
            version = ConfigurationManager.AppSettings["webpages:Version"];

            ViewBag.Message = $"Your Version {version} contact page.";

            return View();
        }
    }
}