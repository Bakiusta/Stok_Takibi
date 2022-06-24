using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcstok1.Models.Entity;

namespace mvcstok1.Controllers
{
    public class urunController : Controller
    {
        mvcstokEntities ra = new mvcstokEntities();
        // GET: urunn
        public ActionResult Index()
        {
            var degerler = ra.urunler.ToList();
            return View(degerler);
        }
        [HttpGet]

        public ActionResult UrunEkle()
        {
            return View();
        }
        [HttpPost]
        
        public ActionResult UrunEkle(urunler s1)
        {
            ra.urunler.Add(s1);
            ra.SaveChanges();
            return View();
        }
        public ActionResult Sil(int id)
        {
            var urun = ra.urunler.Find(id);
            ra.urunler.Remove(urun);
            ra.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunGetir(int id)
        {
            var urun = ra.urunler.Find(id);
            return View("UrunGetir", urun);
        }

        public ActionResult urunGuncelle(urunler p1)
        {
          
            var urun = ra.urunler.Find(p1.URUNID);
            urun.URUNAD = p1.URUNAD;
            urun.URUNKATEGORİ = p1.URUNKATEGORİ;
            urun.FİYAT = p1.FİYAT;
            urun.STOK = p1.STOK;
            ra.SaveChanges();
            return RedirectToAction("Index");
            
        }
    }
}