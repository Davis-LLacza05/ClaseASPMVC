using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClaseASPMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult CreaVista1()
        {
            ViewBag.Message = "Creación de Vista Número 1";

            return View();
        }

        public ActionResult CreaVista2()
        {
            ViewBag.Message = "Creación de Vista Número 2";

            return View();
        }
    }
}