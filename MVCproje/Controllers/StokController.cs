using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCproje.Models.oto;

namespace MVCproje.Controllers
{

    public class StokController : Controller
    {
        // GET: Stok
        OTOSOLFTSINAN2019Entities1 database = new OTOSOLFTSINAN2019Entities1();
        public ActionResult Index()
        {
            var stoklist = database.STOK.ToList();
            return View(stoklist);
        }
    }
}