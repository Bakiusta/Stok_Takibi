using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcstok1.Models.Entity;

namespace mvcstok1.Controllers
{
    public class kategoriController : Controller
    {
        mvcstokEntities ra = new mvcstokEntities();

        // GET: kategori
        public ActionResult Index()
        {
            var degerler = ra.kategoriler.ToList();
            return View(degerler);
        }
        [HttpGet]

        public ActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]

        public ActionResult KategoriEkle(kategoriler s1)
        {
            ra.kategoriler.Add(s1);
            ra.SaveChanges();
            return View();
        }
        public ActionResult Sil(int id)
        {
            var kategori = ra.kategoriler.Find(id);
            ra.kategoriler.Remove(kategori);
            ra.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}