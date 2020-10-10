using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Request.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1()
        {
            string Username = Request["username"];
            string Password = Request["password"];
            ViewBag.message = Username +" " + " " + Password;
            return View();
        }

        
    }
}