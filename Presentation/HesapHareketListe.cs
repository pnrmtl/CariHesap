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
    public partial class HesapHareketListe : Form, IGuncelleyebilme
    {
        public CariHesap SecilenCariHesap { get; set; }

        public HesapHareketListe()
        {
            InitializeComponent();
        }

        void FillDataGrid()
        {
            List<HesapHareketViewModel> ozetListe;
            if (SecilenCariHesap == null)
                ozetListe = Program.HareketRep.HesapHareketOzetListe();
            else
                ozetListe = Program.HareketRep.CariHareketleriOzet(SecilenCariHesap.CariKod);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ozetListe;

            int yuzdebirim = dataGridView1.Width / 100;

            dataGridView1.Columns[0].HeaderText = "Kod";
            dataGridView1.Columns[0].Width = yuzdebirim * 10;

            dataGridView1.Columns[1].HeaderText = "Ünvan";
            dataGridView1.Columns[1].Width = yuzdebirim * 30;

            //Tutar
            dataGridView1.Columns[2].Width = yuzdebirim * 20;

            //IslemTipi
            dataGridView1.Columns[3].Width = yuzdebirim * 20;

            //CariKod
            dataGridView1.Columns[4].Width = yuzdebirim * 10;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 35;
            }
        }

        private void HesapHareketListe_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //dataGridView1.SelectionMode = SelectionMode.FullRowSelect;

            //Silmek istediğiniz hesap hareketini seçiniz.

            // .... İşletmeye ait ..... tutarındaki hesap hareketini silmek istediğinize emin misiniz?

            //Eğer evet derse ilgili rep nesnesinin Sil metodunu çağıralım.

            //seçili satırların sayısı 0 sa
            if (dataGridView1.SelectedRows.Count == 0)
                MessageBox.Show("Silinecek hesap hareketini seçiniz.");
            else
            {   //silinecek şeyler var
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    HesapHareketViewModel silinecek = (HesapHareketViewModel)item.DataBoundItem;
                    Program.HareketRep.Sil(silinecek);
                }
                Program.EkranGuncelle();
            }
        }
        public void Guncelleme()
        {
            FillDataGrid();
        }

        private void btn_YeniHesapHareketi_Click(object sender, EventArgs e)
        {
            YeniHesapHareketEkran y = new YeniHesapHareketEkran();
            if (dataGridView1.SelectedRows.Count != 0)
            {
                int SecilenCariKod = ((HesapHareketViewModel)dataGridView1.SelectedRows[0].DataBoundItem).CariKod;
                y.SecilenCariOzet = new CariHesapViewModel();
                y.SecilenCariOzet.CariKod = SecilenCariKod;
            }
            y.Show();
        }

        private void HesapHareketListe_Resize(object sender, EventArgs e)
        {
            Guncelleme();
        }
    }
}
