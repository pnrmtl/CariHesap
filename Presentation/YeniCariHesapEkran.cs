using Entity.Models;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Presentation
{
    public partial class YeniCariHesapEkran : Form, IGuncelleyebilme
    {
        public CariHesap SeciliCari { get; set; }
        private void YeniCariHesapEkran_Load(object sender, EventArgs e)
        {
            Guncelleme();
            chk_SahisFirma_CheckedChanged(chk_SahisFirma, e);
            if (SeciliCari != null)
                DuzenlemeIcinFormuDoldur(); //FillForm
        }

        private void DuzenlemeIcinFormuDoldur()
        {
            this.Text = "Cari Hesap Düzenle";

            #region Genel
            txt_Unvan.Text = SeciliCari.Unvan;
            cmb_Grup.SelectedItem = SeciliCari.Grup;

            try
            {
                byte[] resimDizi = SeciliCari.FirmaLogo;
                using (MemoryStream m = new MemoryStream(resimDizi))
                    p_Resim.Image = Image.FromStream(m);
            }
            catch { }

            #endregion

            #region Banka
            txt_BankaAd.Text = SeciliCari.Banka.BankaAdi;
            txt_BankaHesapNo.Text = SeciliCari.Banka.HesapNo;
            txt_BankaSubeAd.Text = SeciliCari.Banka.SubeAdi;
            txt_BankaSubeKod.Text = SeciliCari.Banka.SubeKodu;
            cmb_BankaIlce.SelectedItem = SeciliCari.Banka.Ilce;
            cmb_BankaSehir.SelectedItem = SeciliCari.Banka.Sehir;
            msk_BankaIban.Text = SeciliCari.Banka.IBAN;
            #endregion

            #region Iletisim
            txt_IletisimAdres.Text = SeciliCari.Iletisim.Adres;
            txt_IletisimEmail.Text = SeciliCari.Iletisim.Eposta;
            txt_IletisimWeb.Text = SeciliCari.Iletisim.Web;
            txt_Ilgili1.Text = SeciliCari.Iletisim.Ilgili1;
            txt_Ilgili2.Text = SeciliCari.Iletisim.Ilgili2;
            cmb_IletisimIlce.SelectedItem = SeciliCari.Iletisim.Ilce;
            cmb_IletisimSehir.SelectedItem = SeciliCari.Iletisim.Sehir;
            msk_IletisimCep.Text = SeciliCari.Iletisim.CepTel;
            msk_IletisimTel.Text = SeciliCari.Iletisim.Tel;
            #endregion

            #region Kefil
            txt_KefilAdres.Text = SeciliCari.Kefil.Adres;
            txt_KefilAdSoyad.Text = SeciliCari.Kefil.AdSoyad;
            cmb_KefilIlce.SelectedItem = SeciliCari.Kefil.Ilce;
            cmb_KefilSehir.SelectedItem = SeciliCari.Kefil.Sehir;
            msk_KefilCep.Text = SeciliCari.Kefil.CepTel;
            msk_KefilTel.Text = SeciliCari.Kefil.Tel;
            #endregion

            #region Ticari
            txt_KDVNo.Text = SeciliCari.Ticari.KDVNo;
            txt_VergiDairesi.Text = SeciliCari.Ticari.VergiDairesi;
            msk_TC.Text = SeciliCari.Ticari.TCKimlikNo.ToString();
            msk_VergiNo.Text = SeciliCari.Ticari.VergiNo.ToString();
            if (SeciliCari.Ticari.SahisFirmasi)
                chk_SahisFirma.Checked = true;

            if (SeciliCari.Ticari.YabanciUyruk)
                chk_YabanciUyruk.Checked = true;
            #endregion

        }

        public void Guncelleme()
        {
            // cmb_Grup.Items.Add(g);
            cmb_Grup.DataSource = null;
            cmb_Grup.DataSource = Program.GrupRep.Liste;
            cmb_Grup.DisplayMember = "GrupAdi";
        }

        public YeniCariHesapEkran()
        {
            InitializeComponent();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            CariHesap yeniHesap = new CariHesap();
            if (SeciliCari != null) yeniHesap.CariKod = SeciliCari.CariKod;

            #region Genel
            yeniHesap.Unvan = txt_Unvan.Text;
            yeniHesap.Grup = (Grup)cmb_Grup.SelectedItem;
        
            if (p_Resim.Image!=null)
            {
                using (MemoryStream m = new MemoryStream())
                {
                    p_Resim.Image.Save(m, p_Resim.Image.RawFormat);
                    yeniHesap.FirmaLogo = m.ToArray();
                }
            }

            #endregion

            #region Ticari
            /*
            yeniHesap.Ticari = new Ticari();
            yeniHesap.Ticari.SahisFirmasi = chk_SahisFirma.Checked;
            */

            Ticari t = new Ticari();
            t.SahisFirmasi = chk_SahisFirma.Checked;
            t.YabanciUyruk = chk_YabanciUyruk.Checked;
            try //Scope içindeki kodları çalıştırmayı dene
            {
                t.VergiNo = Convert.ToInt64(msk_VergiNo.Text);
            }
            catch { } //hata çıkarsa hiçbir iş yapma

            //çevir ve aktar
            // t.TCKimlikNo = Convert.ToInt64(msk_TC.Text);
            long gecici;
            long.TryParse(msk_TC.Text, out gecici);
            t.TCKimlikNo = gecici;

            t.KDVNo = txt_KDVNo.Text;
            yeniHesap.Ticari = t;
            #endregion

            #region Iletisim
            yeniHesap.Iletisim = new Iletisim();
            yeniHesap.Iletisim.Adres = txt_IletisimAdres.Text;
            yeniHesap.Iletisim.CepTel = msk_IletisimCep.Text;
            yeniHesap.Iletisim.Tel = msk_IletisimTel.Text;
            yeniHesap.Iletisim.Eposta = txt_IletisimEmail.Text;
            yeniHesap.Iletisim.Web = txt_IletisimWeb.Text;
            yeniHesap.Iletisim.Ilgili1 = txt_Ilgili1.Text;
            yeniHesap.Iletisim.Ilgili2 = txt_Ilgili2.Text;
            #endregion

            #region Kefil 
            yeniHesap.Kefil = new Kefil();
            yeniHesap.Kefil.Adres = txt_KefilAdres.Text;
            yeniHesap.Kefil.AdSoyad = txt_KefilAdSoyad.Text;
            yeniHesap.Kefil.CepTel = msk_KefilCep.Text;
            yeniHesap.Kefil.Tel = msk_KefilTel.Text;
            #endregion

            #region Banka
            yeniHesap.Banka = new Banka();
            yeniHesap.Banka.BankaAdi = txt_BankaAd.Text;
            yeniHesap.Banka.HesapNo = txt_BankaHesapNo.Text;
            yeniHesap.Banka.IBAN = msk_BankaIban.Text;
            yeniHesap.Banka.SubeAdi = txt_BankaSubeAd.Text;
            yeniHesap.Banka.SubeKodu = txt_BankaSubeKod.Text;
            #endregion

            if (SeciliCari == null)
                Program.CariRep.Ekle(yeniHesap);
            else
                Program.CariRep.Duzenle(yeniHesap);
            Program.EkranGuncelle();
        }

        private void btn_ResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog o1 = new OpenFileDialog();
            o1.Title = "Firma logosu seç";
            o1.Filter = "Resim (.png, .jpg) |*.png;*.jpg";
            o1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (o1.ShowDialog() == DialogResult.OK)
            {
                p_Resim.Image = Image.FromFile(o1.FileName);
            }

        }



        private void chk_SahisFirma_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_SahisFirma.Checked)
            {
                msk_TC.Enabled = true;
                msk_VergiNo.Enabled = false; //disabled
            }
            else
            {
                msk_TC.Enabled = false;
                msk_VergiNo.Enabled = true;
            }
        }


    }
}
