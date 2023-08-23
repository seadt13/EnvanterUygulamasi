using Microsoft.EntityFrameworkCore;
using EnvanterUygulaması.Context;

namespace EnvanterUygulaması.Models
{
    public class DonanimMarkalari
    {
        public int id { get; set; }
        public string Adi { get; set; }
        public string Durumu { get; set; }
        public Donanimlar donanimlar { get; set; }
    }
}
