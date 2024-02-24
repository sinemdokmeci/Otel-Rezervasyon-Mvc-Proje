using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OtelMvcProje.Models.Entity;
namespace OtelMvcProje.Controllers
{
    public class KayıtController : Controller
    {
        DbOtelYeniEntities db = new DbOtelYeniEntities();
        // GET: Kayıt
        [HttpGet]
        public ActionResult KayıtOl()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KayıtOl(TblYeniKayit p)
        {
            db.TblYeniKayit.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index","Login");
        }
    }
}