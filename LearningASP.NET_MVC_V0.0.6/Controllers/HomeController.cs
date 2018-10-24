using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace LearningASP.NET_MVC_V0._0._6.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public string GetTime()
        {
            Thread.Sleep(2000);
            return DateTime.Now.ToLongTimeString();
        }
    }
}