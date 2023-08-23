using EnvanterUygulaması.Context;
using EnvanterUygulaması.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EnvanterUygulaması.Controllers
{
    public class DonanimController : Controller
    {
        private readonly DataContext _context;

        public DonanimController(DataContext context)
        {
            _context = context;
        }
        
        public IActionResult DonanimListe()
        {
            var donanimList= _context.Donanimlar
                .Include(d=>d.donanimTurleri)
                .Include(d=>d.donanimAltTurleri)
                .Include(d=>d.donanimMarkalari)
                .Include(d=>d.ustModeller)
                .Include(d=>d.altModeller)
                .Include(d=>d.kullanicilar)
                .ToList();
            return View(donanimList);
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult EkledigimDonanimlar()
        {
            return View();
        }
        public IActionResult DonanimEkle()
        {
            return View();
        }
    }
}
