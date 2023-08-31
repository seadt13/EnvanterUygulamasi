using EnvanterUygulaması.Models;
using EnvanterUygulaması.Repositories.Abstract;
using EnvanterUygulaması.Repositories.Concrete;
using EnvanterUygulaması.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EnvanterUygulaması.Controllers
{
    public class DonanimController : Controller
    {
        private readonly IDonanimRepository _donanimRepository;
        private readonly IListRepository _listRepository;

        public DonanimController(IDonanimRepository donanimRepository, IListRepository listRepository)
        {
            _listRepository = listRepository;
            _donanimRepository = donanimRepository;
        }
        
        public async Task<IActionResult> DonanimListe()
        {
            var donanimlar = await _donanimRepository.TumunuGetirInclude();
            List<DonanimVM> donanimListesi = donanimlar.Select(x => new DonanimVM()
            {
                Turu = x.donanimTurleri.Adi,
                AltTuru=x.donanimAltTurleri.Adi,
                Markasi=x.donanimMarkalari.Adi,
                UstModeli=x.ustModeller.Adi,
                AltModeli=x.altModeller.Adi,
                MacAdresi=x.MacAdresi,
                SeriNo=x.SeriNo,
                Durumu=x.Durumu,
                Aciklama=x.Aciklama,
                Adedi=x.Adedi,
                AlimTarihi=x.AlimTarihi,
                Birimi=x.Birim,
                EkleyenKullanici=x.kullanicilar.Adi,
                GarantiSuresi=x.GarantiSuresi,
                Poe=x.Poe
            }).ToList();

            return View(donanimListesi);
        }

        public async Task<IActionResult> DonanimEkle(int id=0)
        {
            DonanimEkleDuzenleVM donanimEkleDuzenleVM = new DonanimEkleDuzenleVM();
            List<Liste> markaList =await _listRepository.MarkaListesiGetir();
            donanimEkleDuzenleVM.MarkaList = markaList;

            if (id!=0)
            {
                //var donanim =await _donanimRepository.Getir(id);
                //donanimEkleDuzenleVM.id = donanim.id;
                //var altModelListe = _donanimRepository.TumunuGetir;

            }
            //ViewBag.MarkaList = new SelectList(donanimMarkalari, "id", "Adi");

            return View(donanimEkleDuzenleVM);
        }
        [HttpPost]
        public async Task<IActionResult> DonanimEkle(Donanimlar donanim)
        {
            await _donanimRepository.DonanimEkle(donanim);

            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult EkledigimDonanimlar()
        {
            return View();
        }
        
    }
}
