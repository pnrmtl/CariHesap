using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class GirisEkran : Form, IGuncelleyebilme
    {
        public GirisEkran()
        {
            InitializeComponent();
        }
        private void btn_CariHesaplar_Click(object sender, EventArgs e)
        {
            new CariHesaplarListe().Show();

            string b = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if(!Directory.Exists(b + "/Yedekler"))
            Directory.CreateDirectory(b+"/Yedekler");

            //Masaüstünde Yedekler klasörü olsun
            //Ekrandaki textbox'a yazılan değer yedek.txt 
            //adıyla bu klasöre kaydedilsin.

        }
        private void menu_Gruplar_Click(object sender, EventArgs e)
        {
            new GrupListe().Show();
        }
        private void GirisEkran_Load(object sender, EventArgs e)
        {
            Guncelleme();
        }
        public void Guncelleme()
        {
            /*
            lbl_BorcToplam.Text = Program.HareketRep.Liste.Where(x => x.IslemTipi == Entity.Models.IslemTipi.NakitTediye).Sum(x => x.Tutar).ToString();

            lbl_AlacakToplam.Text = Program.HareketRep.Liste.Where(x => x.IslemTipi == Entity.Models.IslemTipi.NakitTahsilat).Sum(x => x.Tutar).ToString();
            */
            decimal tediyeToplam = 0;
            decimal tahsilatToplam = 0;
            foreach (var item in Program.HareketRep.Liste)
                if (item.IslemTipi == Entity.Models.IslemTipi.NakitTediye)
                    tediyeToplam += item.Tutar;
                else
                    tahsilatToplam += item.Tutar;

            lbl_AlacakToplam.Text = tahsilatToplam.ToString();
            lbl_BorcToplam.Text = tediyeToplam.ToString();

            decimal toplam = tediyeToplam - tahsilatToplam;
            lbl_nakitToplam.Text = toplam.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new YeniCariHesapEkran().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new YeniHesapHareketEkran().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new GrupListe().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //istediği bir yere
            //yedek_29.06.2017.json
            //dosyasını kaydedelim
            //içinde bütün listeler (CariHesaplar, Gruplar, Hesap hareketleri) bulunsun
            //listeleri tek bir nesnede toplayabilmek için bir viewmodel yazalım

            using (SaveFileDialog s = new SaveFileDialog())
            {
                s.Title = "Yedek alınacak yeri seçiniz";
                s.Filter = "Yedek | *.yaz5";
                if (s.ShowDialog() == DialogResult.OK)
                    MessageBox.Show(Yedek.YedekAl(s.FileName));
                //using kullandığımızdan aşağıdakiler yapılır
                //s.Dispose();
                //s = null;
            }

                
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new YedektenYukle().Show();
        }

        private void cariHesapListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CariHesaplarListe().Show();
        }

        private void yeniCariHesapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new YeniCariHesapEkran().Show();
        }

        private void tümHesapHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HesapHareketListe().Show();
        }

        private void yedektenYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new YedektenYukle().Show();
        }

        private void yedekAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button7.PerformClick();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new GunlukMizanEkran().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new AylikMizanEkran().Show();
        }
    }
}
