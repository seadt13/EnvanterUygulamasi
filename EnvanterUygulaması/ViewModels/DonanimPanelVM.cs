using EnvanterUygulaması.Models;

namespace EnvanterUygulaması.ViewModels
{
    public class DonanimPanelVM
    {
        public DonanimPanelVM()
        {
            MarkaList = new List<Liste>();
        }
        public int id { get; set; }
        public string Adi { get; set; }

        public List<Liste> MarkaList { get; set; }
    }
}
