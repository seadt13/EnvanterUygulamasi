using EnvanterUygulaması.Models;
using EnvanterUygulaması.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EnvanterUygulaması.Controllers
{
    public class DonanimController : Controller
    {
        private readonly IGenericRepository<Donanimlar> _donanimRepository;

        public DonanimController(IGenericRepository<Donanimlar> donanimRepository)
        {
            _donanimRepository = donanimRepository;
        }

        public async Task<IActionResult> DonanimListe()
        {
            var donanimList = await _donanimRepository.GetAllAsync();
            var donanimViewModel = donanimList.Select(d => new DonanimViewModel
            {
                id = d.id,
                Turu = d.DonanimTuru?.Adi,
                AltTuru = d.DonanimAltTuru?.Adi,
                Marka = d.DonanimMarka?.Adi,
                UstModel = d.UstModel?.Adi,
                AltModel = d.AltModel?.Adi,
                MacAdresi = d.MacAdresi,
                SeriNo = d.SeriNo,
                Durumu = d.Durumu,
                AlimTarihi = d.AlimTarihi,
                GarantiSuresi = d.GarantiSuresi,
                Adedi = d.Adedi,
                Poe = d.Poe,
                BaglantiHizi = d.BaglantiHizi,
                Modu = d.Modu,
                Tipi = d.Tipi,
                EkleyenKullanici = d.Kullanici?.Adi,
                Birim = d.Birim,
                Aciklama = d.Aciklama

            }).ToList();
            return View(donanimViewModel);
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
