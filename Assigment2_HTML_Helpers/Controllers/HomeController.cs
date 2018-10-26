using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assigment2_HTML_Helpers.Classes;

namespace Assigment2_HTML_Helpers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var age1 = new DateTime(1990, 01, 01).ToAge();
            var age2 = new DateTime(1987, 05, 07).ToAge();
            var age3 = new DateTime(1975, 10, 10).ToAge();


            var dig1 = "abc123".ToDigitsOnly();
            var dig2 = "z1x2c3v4".ToDigitsOnly();
            var dig3 = "#$ss223%^".ToDigitsOnly();


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
    }
}