using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace StokTakipProjesi.Controllers
{
    public class UrunController : Controller
    {
        static List<Urun> urunler = new List<Urun>()
        {
            new Urun{Id=1, Ad="Laptop", Stok=10, Fiyat=15000},
            new Urun{Id=2, Ad="Mouse", Stok=50, Fiyat=150}
        };

        public ActionResult Index()
        {
            return View(urunler);
        }

        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(Urun yeniUrun)
        {
            yeniUrun.Id = urunler.Max(u => u.Id) + 1;
            urunler.Add(yeniUrun);
            return RedirectToAction("Index");
        }

        public ActionResult Guncelle(int id)
        {
            var urun = urunler.FirstOrDefault(u => u.Id == id);
            return View(urun);
        }

        [HttpPost]
        public ActionResult Guncelle(Urun guncelUrun)
        {
            var urun = urunler.FirstOrDefault(u => u.Id == guncelUrun.Id);
            if (urun != null)
            {
                urun.Ad = guncelUrun.Ad;
                urun.Stok = guncelUrun.Stok;
                urun.Fiyat = guncelUrun.Fiyat;
            }
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            var urun = urunler.FirstOrDefault(u => u.Id == id);
            return View(urun);
        }

        [HttpPost, ActionName("Sil")]
        public ActionResult SilOnay(int id)
        {
            var urun = urunler.FirstOrDefault(u => u.Id == id);
            if (urun != null)
                urunler.Remove(urun);
            return RedirectToAction("Index");
        }
    }
}
