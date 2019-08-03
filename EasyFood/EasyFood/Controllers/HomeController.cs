using EasyFood.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyFood.Controllers
{
    public class HomeController : Controller
    {
        EasyFoodContext db = new EasyFoodContext();

        public ActionResult Index(int? val)
        {
            if(val != null)
            {
                TempData["IDUtilizator"] = null;
                TempData.Keep();
            }

            return View(db.Bucatari.ToList());
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