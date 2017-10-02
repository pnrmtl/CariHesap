using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class YeniHesapHareketEkran : Form, IGuncelleyebilme
    {
        public CariHesapViewModel SecilenCariOzet { get; set; }
        private void YeniHesapHareketEkran_Load(object sender, EventArgs e)
        {
            Guncelleme();
            if(SecilenCariOzet != null)
            {
                // CariHesap gercek = Program.CariRep.Liste.Where(x => x.CariKod == SecilenCariOzet.CariKod).FirstOrDefault();

                CariHesap gercek = new CariHesap();
                foreach (var item in Program.CariRep.Liste)
                    if (item.CariKod == SecilenCariOzet.CariKod)
                        gercek = item;

                cmb_CariHesap.SelectedItem = gercek;
            }
        }

        public YeniHesapHareketEkran()
        {
            InitializeComponent();
        }

        public void Guncelleme()
        {
            cmb_CariHesap.DataSource = null;
            cmb_CariHesap.DataSource = Program.CariRep.Liste;
            cmb_CariHesap.DisplayMember = "Unvan";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HesapHareket hh = new HesapHareket();
            hh.Carihesap = (CariHesap)cmb_CariHesap.SelectedItem;
            hh.Evrak = new Evrak()
            {
                EvrakCinsi = cmb_EvrakCins.Text,
                EvrakNo = txt_EvrakNo.Text,
                EvrakTipi = cmb_EvrakTip.Text
            };
            hh.Tutar = nm_Tutar.Value;
            hh.IslemTipi = rb_NakitTahsilat.Checked ? IslemTipi.NakitTahsilat : IslemTipi.NakitTediye;
            hh.IslemTarihi = dtp_islemtarih.Value;
            hh.VadeTarihi = dtp_vadetarih.Value;
            hh.VadeGunu = (int)nm_vadegun.Value;

            Program.HareketRep.Ekle(hh);
            Program.EkranGuncelle();
        }

        
    }
}
