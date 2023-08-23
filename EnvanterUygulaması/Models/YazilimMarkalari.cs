using Microsoft.EntityFrameworkCore;
using EnvanterUygulaması.Context;

namespace EnvanterUygulaması.Models
{
    public class YazilimMarkalari
    {
        public int id { get; set; }
        public string Adi { get; set; }
        public string Durumu { get; set; }
        public Yazilimlar yazilimlar { get; set; } 
    }
}
