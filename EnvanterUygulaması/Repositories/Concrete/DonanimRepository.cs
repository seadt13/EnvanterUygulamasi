﻿using EnvanterUygulaması.Context;
using EnvanterUygulaması.Models;
using EnvanterUygulaması.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace EnvanterUygulaması.Repositories.Concrete
{
    public class DonanimRepository : GenericRepository<Donanimlar> ,IDonanimRepository
    {
        private readonly DataContext _context;

        public DonanimRepository(DataContext context): base(context)
        {
            _context = context;
        }
        public async Task DonanimEkle(Donanimlar donanim)
        {
            _context.Donanimlar.Add(donanim);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Donanimlar>> TumunuGetirInclude()
        {
            var donanimList = await _context.Donanimlar
                .Include(d => d.donanimTurleri)
                .Include(d => d.donanimAltTurleri)
                .Include(d => d.donanimMarkalari)
                .Include(d => d.ustModeller)
                .Include(d => d.altModeller)
                .Include(d => d.kullanicilar)
                .Include(d=>d.bolgeler)
                .ToListAsync();

            return donanimList;
        }

        public async Task<Donanimlar?> GetirInclude(int id)
        {
            return await _context.Donanimlar.Include(d => d.donanimTurleri)
                .Include(d => d.donanimAltTurleri)
                .Include(d => d.donanimMarkalari)
                .Include(d => d.ustModeller)
                .Include(d => d.altModeller)
                .Include(d => d.kullanicilar).
                Where(d=>d.id==id).FirstOrDefaultAsync();
        }
    }
}
