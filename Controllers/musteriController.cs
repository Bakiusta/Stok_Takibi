using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcstok1.Models.Entity;

namespace mvcstok1.Controllers
{
    public class musteriController : Controller
    {
        mvcstokEntities ra = new mvcstokEntities();

        // GET: musteri
        public ActionResult Index()
        {

             var degerler = ra.musteriler.ToList();
             return View(degerler);
   
        }
        [HttpGet]

        public ActionResult MusteriEkle()
        {
            return View();
        }
        [HttpPost]

        public ActionResult MusteriEkle(musteriler s1)
        {
            ra.musteriler.Add(s1);
            ra.SaveChanges();
            return View();
        }
        public ActionResult Sil(int id)
        {
            var urun = ra.musteriler.Find(id);
            ra.musteriler.Remove(urun);
            ra.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MusteriGetir(int id)
        {
            var musteri  = ra.musteriler.Find(id);
            return View("MusteriGetir", musteri);
        }

        public ActionResult MusteriGuncelle(musteriler p1)
        {

            var musteri = ra.musteriler.Find(p1.MUSTERİID);
            musteri.MUSTERİAD = p1.MUSTERİAD;
            musteri.MUSTERİSOYAD = p1.MUSTERİSOYAD;
            ra.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}