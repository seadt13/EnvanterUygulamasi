using EnvanterUygulaması.Models;
using EnvanterUygulaması.Repositories.Abstract;

namespace EnvanterUygulaması.Repositories
{
    public interface IDonanimRepository: IGenericRepository<Donanimlar>
    {
        Task<Donanimlar?> AdetSay(int MarkaID, int UstModelID, int AltModelID);
    }
}
