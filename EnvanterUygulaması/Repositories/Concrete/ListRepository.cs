using EnvanterUygulaması.Context;
using EnvanterUygulaması.Models;
using EnvanterUygulaması.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace EnvanterUygulaması.Repositories.Concrete
{
    public class ListRepository : IListRepository
    {
        private readonly DataContext _context;

        public ListRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Liste>> MarkaListesiGetir()
        {
            var markalar = await _context.DonanimMarkalari.ToListAsync();
            var markaListesi = markalar.Select(x => new Liste { Adi = x.Adi, id = x.id }).ToList();
            return markaListesi;
        }
        public async Task<List<Liste>> UstModelListesiGetir(int markaId)
        {
            var ustModeller = await _context.UstModeller.Where(x=>x.DonanimMarkaId==markaId).ToListAsync();
            var ustModelListesi= ustModeller.Select(x=> new Liste {Adi=x.Adi,id=x.id}).ToList();
            return ustModelListesi;
        }
        public async Task<List<Liste>> AltModelListesiGetir(int ustModelId)
        {
            var altModeller = await _context.AltModeller.Where(x=>x.UstModelID==ustModelId).ToListAsync();
            var altModelListesi = altModeller.Select(x=>new Liste { Adi=x.Adi,id = x.id}).ToList();
            return altModelListesi;
        }
        
    }
}
