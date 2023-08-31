using EnvanterUygulaması.Context;
using EnvanterUygulaması.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace EnvanterUygulaması.Repositories.Concrete
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private DataContext _context;
        private DbSet<TEntity> _entity;

        public GenericRepository(DataContext context)
        {
            _context = context;
            _entity= _context.Set<TEntity>();
        }
        public async Task<List<TEntity>> TumunuGetir()
        {
            return await _entity.ToListAsync();
        }

        public async Task<TEntity> Ekle(TEntity entity)
        {
            _entity.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        Task<TEntity?> IGenericRepository<TEntity>.Getir(int id)
        {
            throw new NotImplementedException();
        }

        Task IGenericRepository<TEntity>.Sil(int id)
        {
            throw new NotImplementedException();
        }

        Task IGenericRepository<TEntity>.Guncelle(TEntity entity)
        {
            throw new NotImplementedException();
        }

        Task IGenericRepository<TEntity>.TopluEkle(List<TEntity> entities)
        {
            throw new NotImplementedException();
        }
    }
}
