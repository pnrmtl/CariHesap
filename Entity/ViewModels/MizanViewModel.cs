using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
    public class MizanViewModel
    {
        public HesapKod HesapKod { get; set; }
        public decimal Tutar { get; set; }
    }

    public enum HesapKod
    {
        Toplam,
        KasaHesabi = 100,
        AlicilarHesabi = 120,
        SaticilarHesabi = 320,
        YurticiSatis = 600
    }
  
    public enum Aylar
    {
        //Key = Value
        //Property = Value
        [Description("Ocak")] //Attribute / Decoration
        Ocak=1,
        [Description("Şubat")]
        Subat,
        [Description("Mart")]
        Mart,
        [Description("Nisan")]
        Nisan,
        [Description("Mayıs")]
        Mayis,
        [Description("Haziran")]
        Haziran,
        [Description("Temmuz")]
        Temmuz,
        [Description("Ağustos")]
        Agustos,
        [Description("Eylül")]
        Eylul,
        [Description("Ekim")]
        Ekim,
        [Description("Kasım")]
        Kasim,
        [Description("Aralık")]
        Aralik
    }
}
                                      