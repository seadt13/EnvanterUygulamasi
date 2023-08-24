using EnvanterUygulaması.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EnvanterUygulaması.Controllers
{
    public class YazilimController : Controller
    {
        public readonly DataContext _context;

        public YazilimController(DataContext context)
        {
            _context = context;
        }

        public ActionResult YazilimListe() 
        {
            var yazilimList=_context.Yazilimlar
                .Include(y=>y.yazilimMarkalari)
                .Include(y=>y.kullanicilar)
                .ToList();
            return View(yazilimList);
        }
        public IActionResult YazilimEkle()
        {
            return View();
        }
        public IActionResult EkledigimYazilimlar()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
