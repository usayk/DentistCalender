using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DentistCalender.Models;
using System.Web.Mvc;

namespace DentistCalender.Controllers
{
          
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        //localhost.8080/home/index

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Deneme()
        {
            List<string> colors = new List<string>() { "Black", "Blue" };
            
            DenemeViewModel model = new DenemeViewModel()
            {
                Colors = colors
            }
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
    }
}