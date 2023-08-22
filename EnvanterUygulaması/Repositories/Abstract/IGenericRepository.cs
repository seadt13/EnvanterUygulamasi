using System.Linq.Expressions;

namespace EnvanterUygulaması.Repositories.Abstract
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity?> Getir(int id);
        Task<List<TEntity>> GetAllAsync(); //Listeleme fonksiyonu
        void Sil(int id);
        void Guncelle(TEntity entity);
        void Ekle(TEntity entity);
    }
}
