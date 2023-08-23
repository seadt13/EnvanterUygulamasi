using Microsoft.EntityFrameworkCore;
using EnvanterUygulaması.Context;

namespace EnvanterUygulaması.Models
{
    public class Kullanicilar
    {
        public int id { get; set; }
        public string Adi { get; set; }
        public string Sifresi { get; set; }
        public ICollection<KullaniciRolleri> kullaniciRolleri { get; set; }
        public Donanimlar donanimlar { get; set; }
        public Yazilimlar yazilimlar { get; set; }
        public Devreler devreler { get; set; }
    }
}
