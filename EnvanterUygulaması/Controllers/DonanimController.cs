using EnvanterUygulaması.Models;
using EnvanterUygulaması.Repositories;
using EnvanterUygulaması.Repositories.Abstract;
using EnvanterUygulaması.Repositories.Concrete;
using EnvanterUygulaması.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EnvanterUygulaması.Controllers
{
    public class DonanimController : Controller
    {
        IDonanimRepository _donanimRepository;

        public DonanimController(IDonanimRepository donanimRepository)
        {
            _donanimRepository = donanimRepository;
        }
        public IActionResult DonanimEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DonanimEkle(Donanimlar donanim)
        {
            //_donanimRepository.Add(donanim);
            return RedirectToAction("EkledigimDonanimlar");
        }

        public IActionResult EkledigimDonanimlar()
        {
            return View();
        }

        public IActionResult DonanimListe()
        {
            var donanimList = _donanimRepository.TumunuGetir(includeProperties: );
            var donanimViewModelList = donanimList.Select(d => new DonanimViewModel
            {
                id = d.id,
                Turu = d.DonanimTurleri,
                AltTuru = d.DonanimAltTuru,
                Marka = d.DonanimMarka,
                UstModel = d.UstModel,
                AltModel = d.AltModel,
                MacAdresi = d.MacAdresi,
                SeriNo = d.SeriNo,
                Durumu = d.Durumu,
                GarantiSuresi = d.GarantiSuresi,
                AlimTarihi = d.AlimTarihi,
                Adedi = d.Adedi,
                Poe = d.Poe,
                BaglantiHizi = d.BaglantiHizi,
                Modu = d.Modu,
                Tipi = d.Tipi,
                EkleyenKullanici = d.EkleyenKullanici,
                Birim = d.Birim,
                Aciklama = d.Aciklama

            }).ToList();

            return View(donanimViewModelList);
        }
    }
}
