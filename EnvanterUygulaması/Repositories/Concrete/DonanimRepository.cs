using Microsoft.EntityFrameworkCore;
using EnvanterUygulaması.Models;
using EnvanterUygulaması.Repositories.Abstract;

namespace EnvanterUygulaması.Repositories.Concrete
{
    public class DonanimRepository : GenericRepository<Donanimlar> , IDonanimRepository
    {
        private DataContext _context;
        private DbSet<Donanimlar> _dbSet;
        public DonanimRepository(DataContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Donanimlar;
        }

        public Task<Donanimlar> AdetSay(int MarkaID, int UstModelID, int AltModelID)
        {
            //return 
        }
    }

}
