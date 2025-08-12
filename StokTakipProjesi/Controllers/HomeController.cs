using Microsoft.AspNetCore.Mvc;

namespace StokTakipProjesi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Urunler()
        {
            return View(); // "Urunler" view'ýný otomatik bulur
        }

        public IActionResult Iletisim()
        {
            return View();
        }
       

        public ActionResult Recete()
        {
            return View();
        }

        public ActionResult Rapor()
        {
            return View();
        }

       













    }
}

