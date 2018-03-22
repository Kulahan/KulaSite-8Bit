using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KulaSite_8Bit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProjectList()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}