using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCart.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Home()
        {
            return PartialView();
        }
        public ActionResult ItemsList()
        {
            return PartialView();
        }
        public ActionResult ItemsDetails()
        {
            return PartialView();
        }
        public ActionResult Cart()
        {
            return PartialView();
        }
    }
}