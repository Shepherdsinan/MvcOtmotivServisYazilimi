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
    public class KategoriController : Controller
    {
        // GET: Kategori
        MvcTestEntities db = new MvcTestEntities();
        public ActionResult Index(int sayfa=1)
        {
            var degerler = db.tblkategori.ToList().ToPagedList(sayfa, 4);
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniKategori()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult YeniKategori(tblkategori p1)
        {
            if(!ModelState.IsValid)
            {
                return View("YeniKategori");
            }
            db.tblkategori.Add(p1);
            db.SaveChanges();
            return RedirectToAction("INDEX", "KATEGORI");
        }
        public ActionResult SIL(int id)
        {
            var kategori = db.tblkategori.Find(id);
            db.tblkategori.Remove(kategori);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Kategorigetir(int id)
        {
            var ktgr = db.tblkategori.Find(id);
            return View("Kategorigetir", ktgr);
        }
        public ActionResult Guncelle(tblkategori p1)
        {
            var ktg = db.tblkategori.Find(p1.ıd);
            ktg.adı = p1.adı;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}