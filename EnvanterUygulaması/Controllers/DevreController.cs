using EnvanterUygulaması.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EnvanterUygulaması.Controllers
{
    public class DevreController : Controller
    {
        private readonly DataContext _context;

        public DevreController(DataContext context)
        {
            _context = context;
        }

        public ActionResult DevreListe() 
        {
            var devreList= _context.Devreler
                .Include(d=>d.bulutlar)
                .Include(d=>d.kullanicilar)
                .ToList();
            return View(devreList);
        }

        public IActionResult DevreEkle() 
        {
            return View();
        }
        public IActionResult EkledigimDevreler()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
