using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCproje.Models.Entity;
using PagedList;
using PagedList.Mvc;

namespace MVCproje.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        MvcTestEntities db = new MvcTestEntities();
        public ActionResult Index()
        {
            var degerler = db.tblstok.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniUrun()

        {
            List<SelectListItem> degerler = (from i in db.tblkategori.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.adı,
                                                 Value = i.ıd.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }
        [HttpPost]
        public ActionResult YeniUrun(tblstok p1)
        {
            var ktg = db.tblkategori.Where(m => m.ıd == p1.tblkategori.ıd).FirstOrDefault();
            p1.tblkategori = ktg;         
            
            db.tblstok.Add(p1);
            db.SaveChanges();
            return RedirectToAction("INDEX","Urun");
        }
        public ActionResult SIL(int id)
        {
            var urun = db.tblstok.Find(id);
            db.tblstok.Remove(urun);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Urunlerigetir(int id)
        {
            var ktgr = db.tblstok.Find(id);

            List<SelectListItem> degerler = (from i in db.tblkategori.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.adı,
                                                 Value = i.ıd.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View("Urunlerigetir", ktgr);
        }
        public ActionResult Guncelle(tblstok p1)
        {
            var urn = db.tblstok.Find(p1.ıd);
            urn.urunadi = p1.urunadi;
            var ktg = db.tblkategori.Where(m => m.ıd == p1.tblkategori.ıd).FirstOrDefault();

            urn.kategorid = ktg.ıd;
            urn.marka = p1.marka;
            urn.stok = p1.stok;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}