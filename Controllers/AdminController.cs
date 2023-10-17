using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Siniflar;
namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context ctxt=new Context();
        [Authorize]
        public ActionResult Index()
        {
            var values = ctxt.Blogs.ToList();
            return View(values);
        }
        [HttpGet][Authorize]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public ActionResult YeniBlog(Blog b)
        {
            ctxt.Blogs.Add(b);
            ctxt.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult BlogSil(int id)
        {
            var values = ctxt.Blogs.Find(id);
            ctxt.Blogs.Remove(values);
            ctxt.SaveChanges();
            return RedirectToAction("Index");

        }
        [Authorize]
        public ActionResult BlogGetir(int id)
        {
            var values = ctxt.Blogs.Find(id);
            return View("BlogGetir",values);
        }
        [Authorize]
        public ActionResult BlogGuncelle(Blog b)
        {
            var value = ctxt.Blogs.Find(b.blogID);
            value.blogBaslik = b.blogBaslik;
            value.blogAciklama = b.blogAciklama;
            value.blogTarih=b.blogTarih;
            value.blogImage=b.blogImage;
            ctxt.SaveChanges();
            return RedirectToAction("Index");

        }
        [Authorize]
        public ActionResult AdminYorum()
        {
            var values = ctxt.Yorumlars.ToList();
            return View(values);
        }
        [Authorize]
        public ActionResult YorumSil(int id)
        {
            var values = ctxt.Yorumlars.Find(id);
            ctxt.Yorumlars.Remove(values);
            ctxt.SaveChanges();
            return RedirectToAction("AdminYorum");
        }
    }
}