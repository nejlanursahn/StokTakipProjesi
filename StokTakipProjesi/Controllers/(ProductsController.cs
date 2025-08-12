using Microsoft.AspNetCore.Mvc;
using StokTakipProjesi.Models;
using System.Linq;
using StokTakipProjesi.Data;
using StokTakipProjesi.Models;

namespace StokTakipProjesi.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }
    }
}
