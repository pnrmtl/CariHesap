using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
    public class YedekViewModel
    {
        public List<CariHesap> CariYedek { get; set; }
        public List<HesapHareket> HesapYedek { get; set; }
        public List<Grup> GrupYedek { get; set; }
    }
}
