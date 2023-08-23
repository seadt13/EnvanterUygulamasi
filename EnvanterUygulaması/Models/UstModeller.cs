using Microsoft.EntityFrameworkCore;
using EnvanterUygulaması.Context;

namespace EnvanterUygulaması.Models
{
    public class UstModeller
    {
        public int id { get; set; }
        public string Adi { get; set; }
        public string Durumu { get; set; }
        public Donanimlar donanimlar { get; set; }
        public ICollection<AltModeller> altModeller { get; set; }
    }
}
