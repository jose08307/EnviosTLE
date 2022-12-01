using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnviosTLE.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegistroEnvio()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

       
        
    }
}