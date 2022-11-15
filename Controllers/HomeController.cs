using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_AtoZ.Controllers
{
    public class HomeController : Controller
    {
        //controller action 
        public string Index(string id, string name )
        {
            // Insead of using Request.QueryString["name"] we can simply use query string name to index parameter ;
            return "id = " + id + "  Name = " + name; 
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