using _17032022_DataAnnotations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17032022_DataAnnotations.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(new Kullanici());
        }

        [HttpPost]
        public ActionResult Index(Kullanici kullanici)
        {
            if(kullanici.KullaniciAdi=="elif1")
            {
                ModelState.AddModelError("", "Bu kullanıcı adı sistemde kayıtlı");
            }
            return View(kullanici);
        }
    }
}