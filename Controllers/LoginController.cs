using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context ctxt = new Context();
        public ActionResult GirisYap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GirisYap(Admin a)
        {
            var values = ctxt.Admins.FirstOrDefault(x=>x.adminKullanici==a.adminKullanici && x.adminSifre==a.adminSifre);
            if (values!=null)
            {
                FormsAuthentication.SetAuthCookie(values.adminKullanici, false);
                Session["Kullanici"] = values.adminKullanici.ToString();
                return RedirectToAction("Index","Admin");
            }
            else
            {
                return View();
            }
  
        }

        public ActionResult CikisYap()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("GirisYap","Login");
        }
    }
}