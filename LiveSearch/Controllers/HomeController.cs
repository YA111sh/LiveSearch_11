using LiveSearch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiveSearch.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            LiveDataEntities db = new LiveDataEntities();
            
            return View(db.UserMasters.ToList());
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