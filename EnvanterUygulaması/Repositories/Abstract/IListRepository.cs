using EnvanterUygulaması.Models;

namespace EnvanterUygulaması.Repositories.Abstract
{
    public interface IListRepository
    {
        Task<List<Liste>> MarkaListesiGetir();
        Task<List<Liste>> UstModelListesiGetir(int id);
        Task<List<Liste>> AltModelListesiGetir(int id);
    }
}
