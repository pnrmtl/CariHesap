using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.ViewModels;
using System.Web.Script.Serialization;
using System.IO;
using DAL;
using Entity.Models;

namespace BusinessLogic
{
    public static class Yedek
    {
        public static string YedekAl(string dosyaYolu)
        {
            try
            {
                string bugun = DateTime.Today.ToShortDateString();
                dosyaYolu = dosyaYolu.Replace(".yaz5", bugun + ".yaz5");

                #region Versiyon1
                //YedekViewModel y = new YedekViewModel();
                //y.CariYedek = new CariRepository().Liste;
                //y.GrupYedek = new GrupRepository().Liste;
                //y.HesapYedek = new HareketRepository().Liste;
                //Kayit<YedekViewModel>.Kaydet(y, dosyaYolu);
                #endregion

                #region Versiyon2
                List<object> y2 = new List<object>();
                y2.Add(new CariRepository().Liste);
                y2.Add(new GrupRepository().Liste);
                y2.Add(new HareketRepository().Liste);
                Kayit<object>.Kaydet(y2, dosyaYolu);
                #endregion
                return "Yedek alındı";
            }
            catch
            {
                return "Bir hata oluştu";
            }
        }

        public static string YedektenYukle(string dosyaYolu, bool eskiyiSil)
        {
            try
            {
                CariRepository cr = new CariRepository();
                GrupRepository gr = new GrupRepository();
                HareketRepository hr = new HareketRepository();
                if (eskiyiSil)
                {
                    cr.TumunuSil();
                    gr.TumunuSil();
                    hr.TumunuSil();
                }

                #region Versiyon1
                var yedek = Kayit<YedekViewModel>.YedektenOku(dosyaYolu);
                // cr.Liste ve yedek.CariYedek listelerini birleştir
                cr.YedektenYukle(yedek.CariYedek);
                gr.YedektenYukle(yedek.GrupYedek);
                hr.YedektenYukle(yedek.HesapYedek);
                #endregion

                #region Versiyon2
                //var yedek2 = Kayit<List<object>>.YedektenOku(dosyaYolu);
                //cr.Liste.AddRange((List<CariHesap>)yedek2[0]);
                //gr.Liste.AddRange((List<Grup>)yedek2[1]);
                //hr.Liste.AddRange((List<HesapHareket>)yedek2[2]);
                #endregion

                return "Yedekteki kayıtlar başarıyla yüklendi";
            }
            catch (Exception ex)
            {
                return "Bir hata oluştu. "+ ex.Message;
            }
        }
    }


}
