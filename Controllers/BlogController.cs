using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context ctxt = new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            //var values = ctxt.Blogs.ToList();
            by.Deger1 = ctxt.Blogs.ToList();
            by.Deger3 = ctxt.Blogs.OrderByDescending(x => x.blogTarih).Take(3).ToList();
            return View(by);
        }
        public ActionResult BlogDetail(int id)
        {

            //var blogcontext = ctxt.Blogs.Where(x=>x.blogID==id).ToList();
            by.Deger1 = ctxt.Blogs.Where(x => x.blogID == id).ToList();
            by.Deger2 = ctxt.Yorumlars.Where(x => x.blogID == id).ToList();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult PartialYorumEkle(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialYorumEkle(Yorumlar y)
        {
            ctxt.Yorumlars.Add(y);
            ctxt.SaveChanges();
            return PartialView();
        }

    }
}