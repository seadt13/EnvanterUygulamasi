using EnvanterUygulaması.Models;
using EnvanterUygulaması.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EnvanterUygulaması.Repositories.Concrete
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private DataContext _context;
        private DbSet<TEntity> _dbSet;
        public GenericRepository(DataContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public void Ekle(TEntity entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public async Task<TEntity?> Getir(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public void Guncelle(TEntity entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }

        public async void Sil(int id)
        {
            var entity = await Getir(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();
            }

        }
    }
}
