using EnvanterUygulaması.Models;

namespace EnvanterUygulaması.Repositories.Abstract
{
    public interface IDevreRepository: IGenericRepository<Devreler>
    {
        Task<List<Devreler>> TumunuGetirInclude();
    }
}
