using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodResturant.Controllers
{
    public class ResturantController : Controller
    {
        // GET: Resturant
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TajResturant()
        {
            return View("~/Views/Home/Index.cshtml");
        }
    }
}