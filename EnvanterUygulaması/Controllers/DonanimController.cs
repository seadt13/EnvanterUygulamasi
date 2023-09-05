using EnvanterUygulaması.Models;
using EnvanterUygulaması.Repositories.Abstract;
using EnvanterUygulaması.Repositories.Concrete;
using EnvanterUygulaması.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;

namespace EnvanterUygulaması.Controllers
{
    public class DonanimController : Controller
    {
        private readonly IDonanimRepository _donanimRepository;
        private readonly IListRepository _listRepository;
        private readonly IDonanimMarkaRepository _donanimMarkaRepository;

        public DonanimController(IDonanimRepository donanimRepository, IListRepository listRepository, IDonanimMarkaRepository donanimMarkaRepository)
        {
            _listRepository = listRepository;
            _donanimRepository = donanimRepository;
            _donanimMarkaRepository = donanimMarkaRepository;
        }
        
        public async Task<IActionResult> DonanimListe()
        {
            var donanimlar = await _donanimRepository.TumunuGetirInclude();
            List<DonanimVM> donanimListesi = donanimlar.Select(x => new DonanimVM()
            {
                Turu = x.donanimTurleri.Adi,
                AltTuru = x.donanimAltTurleri != null ? x.donanimAltTurleri.Adi : null,
                Markasi = x.donanimMarkalari.Adi,
                UstModeli=x.ustModeller.Adi,
                AltModeli=x.altModeller.Adi,
                MacAdresi=x.MacAdresi,
                SeriNo=x.SeriNo,
                Durumu=x.Durumu,
                Aciklama=x.Aciklama,
                AlimTarihi=x.AlimTarihi.ToShortDateString(),
                BolgeId = x.BolgeId,
                EkleyenKullanici=x.kullanicilar.Adi,
                GarantiSuresi=x.GarantiSuresi,
                Poe=x.Poe
            }).ToList();

            return View(donanimListesi);
        }

        public async Task<IActionResult> DonanimEkle(int id=0)
        {
            DonanimEkleDuzenleVM donanimEkleDuzenleVM = new DonanimEkleDuzenleVM()
            {
                AlimTarihi = DateTime.Now
            };
    
            if (id != 0)
            {
                var donanim = await _donanimRepository.Getir(id);
                if (donanim == null)
                {
                    RedirectToAction("EkledigimDonanimlar");
                }
                donanimEkleDuzenleVM = new DonanimEkleDuzenleVM
                {
                    Aciklama = donanim.Aciklama,
                    AlimTarihi = donanim.AlimTarihi,
                    AltModelId = donanim.AltModelID,
                    AltTurId = donanim.DonanimAltTuruID,
                    UstModelId = donanim.UstModelID,
                    TurId = donanim.DonanimTuruID,
                    BaglantiHizi = donanim.BaglantiHizi,
                    MacAdres = donanim.MacAdresi,
                    GarantiSuresi = donanim.GarantiSuresi,
                    Guc = donanim.Gucu,
                    Mod = donanim.Modu,
                    MarkaId = donanim.DonanimMarkaID,
                    Poe = donanim.Poe,
                    Tip = donanim.Tipi,
                    SeriNo = donanim.SeriNo,
                    BolgeId = donanim.BolgeId,
                    id=donanim.id
                };
                List<Liste> altTurList = await _listRepository.AltTurListesiGetir(donanim.DonanimTuruID);
                List<Liste> markalist = await _listRepository.DonanimMarkaListesiGetir(donanim.DonanimTuruID);
                List<Liste> ustModelList = await _listRepository.UstModelListesiGetir(donanim.DonanimMarkaID);
                List<Liste> altModelList = await _listRepository.AltModelListesiGetir(donanim.UstModelID);
                donanimEkleDuzenleVM.AltTurList = altTurList;
                donanimEkleDuzenleVM.MarkaList = markalist;
                donanimEkleDuzenleVM.UstModelList = ustModelList;
                donanimEkleDuzenleVM.AltModelList = altModelList;
            }
            List<Liste> turList = await _listRepository.TurListesiGetir();
            donanimEkleDuzenleVM.TurList = turList;
            
            return View(donanimEkleDuzenleVM);
        }
        [HttpPost]
        public async Task<IActionResult> DonanimEkle(DonanimEkleDuzenleVM donanimEkleDuzenleVM)
        {
            try
            {
                if (donanimEkleDuzenleVM.id == 0)
                {
                    var eklenenDonanim = await _donanimRepository.Ekle(new Donanimlar
                    {
                        Aciklama = donanimEkleDuzenleVM.Aciklama,
                        AlimTarihi = donanimEkleDuzenleVM.AlimTarihi,
                        AltModelID = donanimEkleDuzenleVM.AltModelId,
                        UstModelID = donanimEkleDuzenleVM.UstModelId,
                        DonanimTuruID = donanimEkleDuzenleVM.TurId,
                        DonanimAltTuruID = donanimEkleDuzenleVM.AltTurId,
                        DonanimMarkaID = donanimEkleDuzenleVM.MarkaId,
                        MacAdresi = donanimEkleDuzenleVM.MacAdres,
                        BaglantiHizi = donanimEkleDuzenleVM.BaglantiHizi,
                        BolgeId = donanimEkleDuzenleVM.BolgeId,
                        Durumu = donanimEkleDuzenleVM.Durum,
                        GarantiSuresi = donanimEkleDuzenleVM.GarantiSuresi,
                        Gucu = donanimEkleDuzenleVM.Guc,
                        Modu = donanimEkleDuzenleVM.Mod,
                        Poe = donanimEkleDuzenleVM.Poe,
                        SeriNo = donanimEkleDuzenleVM.SeriNo,
                        Tipi = donanimEkleDuzenleVM.Tip,
                        EkleyenID=1
                    });
                    return RedirectToAction("EkledigimDonanimlar");
                }
                else
                {
                    var mevcutDonanim = await _donanimRepository.GetirInclude(donanimEkleDuzenleVM.id);
                    if (mevcutDonanim == null)
                    {
                        return RedirectToAction("EkledigimDonanimlar");
                    }
                    else
                    {
                        mevcutDonanim.Aciklama = donanimEkleDuzenleVM.Aciklama;
                        mevcutDonanim.AlimTarihi = donanimEkleDuzenleVM.AlimTarihi;
                        mevcutDonanim.AltModelID = donanimEkleDuzenleVM.AltModelId;
                        mevcutDonanim.UstModelID = donanimEkleDuzenleVM.UstModelId;
                        mevcutDonanim.DonanimTuruID = donanimEkleDuzenleVM.TurId;
                        mevcutDonanim.DonanimAltTuruID = donanimEkleDuzenleVM.AltTurId;
                        mevcutDonanim.DonanimMarkaID = donanimEkleDuzenleVM.MarkaId;
                        mevcutDonanim.MacAdresi = donanimEkleDuzenleVM.MacAdres;
                        mevcutDonanim.BaglantiHizi = donanimEkleDuzenleVM.BaglantiHizi;
                        mevcutDonanim.BolgeId = donanimEkleDuzenleVM.BolgeId;
                        mevcutDonanim.Durumu = donanimEkleDuzenleVM.Durum;
                        mevcutDonanim.GarantiSuresi = donanimEkleDuzenleVM.GarantiSuresi;
                        mevcutDonanim.Gucu = donanimEkleDuzenleVM.Guc;
                        mevcutDonanim.Modu = donanimEkleDuzenleVM.Mod;
                        mevcutDonanim.Poe = donanimEkleDuzenleVM.Poe;
                        mevcutDonanim.SeriNo = donanimEkleDuzenleVM.SeriNo;
                        mevcutDonanim.Tipi = donanimEkleDuzenleVM.Tip;

                        await _donanimRepository.Guncelle(mevcutDonanim);
                    }
                }
            }
            catch (Exception ex)
            {
                // hata yakalama ve görüntüleme
                TempData["HataMesaji"] = "Bir hata oluştu: " + ex.Message;
                return View(donanimEkleDuzenleVM);
            }



            return RedirectToAction("EkledigimDonanimlar");
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public async Task<IActionResult> EkledigimDonanimlar()
        {
            var donanimlar = await _donanimRepository.TumunuGetirInclude();
            List<DonanimVM> donanimListesi = donanimlar.Select(x => new DonanimVM()
            {
                id = x.id,
                Turu = x.donanimTurleri.Adi,
                AltTuru =x.donanimAltTurleri!=null? x.donanimAltTurleri.Adi:null,
                Markasi = x.donanimMarkalari.Adi,
                UstModeli = x.ustModeller.Adi,
                AltModeli = x.altModeller.Adi,
                MacAdresi = x.MacAdresi,
                SeriNo = x.SeriNo,
                Durumu = x.Durumu,
                Aciklama = x.Aciklama,
                AlimTarihi = x.AlimTarihi.ToShortDateString(),
                BolgeId = x.BolgeId,
                EkleyenKullanici = x.kullanicilar.Adi,
                GarantiSuresi = x.GarantiSuresi,
                Poe = x.Poe
            }).ToList();

            return View(donanimListesi);
        }

        public async Task<IActionResult> MarkaListe()
        {
            var markalar = await _donanimMarkaRepository.TumunuGetir();
            List<DonanimPanelVM> markaListeVM = markalar.Select(x => new DonanimPanelVM()
            {
                id = x.id,
                Adi = x.Adi
            }).ToList();
            return View(markaListeVM);
        }

        public async Task<JsonResult?> DonanimMarkaEkleDuzenle(DonanimPanelVM donanimPanelVM)
        {
            DonanimMarkalari? markaEntity;
            if(donanimPanelVM.id == 0)
            {
                markaEntity=new DonanimMarkalari { Adi= donanimPanelVM.Adi, Durumu="Aktif" };
                var sonuc = await _donanimMarkaRepository.Ekle(markaEntity);
                return Json(sonuc);
            }
            else
            {
                markaEntity = await _donanimMarkaRepository.Getir(donanimPanelVM.id);
                if (markaEntity == null)
                    return null;
                markaEntity.Durumu = "Aktif";
                markaEntity.Adi = donanimPanelVM.Adi;
                await _donanimMarkaRepository.Guncelle(markaEntity);
                return Json(markaEntity);
            }
        }
        
    }
}
