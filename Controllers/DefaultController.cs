using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context ctxt = new Context();
        public ActionResult Index()
        {
            var values = ctxt.Blogs.Take(4).ToList(); 
            return View(values);
        }

        public ActionResult About()
        {

            return View();
        }

        public PartialViewResult Partial1()
        {
            var values = ctxt.Blogs.Take(10).ToList();
            return PartialView(values);
        }

        public PartialViewResult Partial2()
        {
            var values = ctxt.Blogs.Take(3).ToList();
            return PartialView(values);
        }

        public PartialViewResult Partial3()
        {
            var values = ctxt.Blogs.OrderByDescending(x=>x.blogID).Take(3).ToList();
            return PartialView(values);
        }
    }
}