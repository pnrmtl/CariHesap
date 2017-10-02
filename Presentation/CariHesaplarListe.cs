using Entity.Models;
using Entity.ViewModels;
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
    public partial class CariHesaplarListe : Form, IGuncelleyebilme
    {
        public CariHesaplarListe()
        {
            InitializeComponent();
        }

        private void btn_YeniCari_Click(object sender, EventArgs e)
        {
            new YeniCariHesapEkran().Show();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            { //seçili tüm satırları sil
                //item: silinecek datagrid satırı
                string unvan = item.Cells["Unvan"].Value.ToString();
                //..... adlı işletmeyi silmek istediğinize emin misiniz?
                if (MessageBox.Show(unvan + " adlı işletmeyi silmek istediğinize emin misiniz?", "Cari Hesap Sil", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Program.CariRep.Sil((CariHesapViewModel)item.DataBoundItem);
                }
            }
            Program.EkranGuncelle();
        }

        private void btn_YeniHesapHareketi_Click(object sender, EventArgs e)
        { //Cari Hesap Liste > Yeni Hareket
            YeniHesapHareketEkran y = new YeniHesapHareketEkran();
            if (dataGridView1.SelectedRows.Count != 0)
                y.SecilenCariOzet = (CariHesapViewModel)dataGridView1.SelectedRows[0].DataBoundItem;
            y.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new HesapHareketListe().Show();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CariHesap secilen = Program.CariRep.Liste[e.RowIndex];

            HesapHareketListe hForm = new HesapHareketListe();
            hForm.SecilenCariHesap = secilen;
            hForm.Show();
        }
        private void CariHesaplarListe_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Guncelleme();
        }
        public void Guncelleme()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Program.CariRep.CariHesapOzetListe();

            int yuzdeBirim = dataGridView1.Width / 100;

            //Cari Kodu
            dataGridView1.Columns[0].Width = yuzdeBirim * 10;
            dataGridView1.Columns[0].HeaderText = "Kod";

            //Unvan
            dataGridView1.Columns[1].Width = yuzdeBirim * 30;
            dataGridView1.Columns[1].HeaderText = "Ünvan";

            //Resim
            dataGridView1.Columns[2].Width = yuzdeBirim * 10;
            dataGridView1.Columns[2].HeaderText = "Logo";

            //Grup
            dataGridView1.Columns[3].Width = yuzdeBirim * 10;

            //Cep Tel
            dataGridView1.Columns[4].Width = yuzdeBirim * 20;
            dataGridView1.Columns[4].HeaderText = "Cep";

            //İlgili
            dataGridView1.Columns[5].Width = yuzdeBirim * 20;
            dataGridView1.Columns[5].HeaderText = "İlgili Kişi";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 35;
            }
        }

        private void btn_CariAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Program.CariRep.CariHesapOzetListe()
                .Where(x => x.Unvan.ToLower()
                .Contains(txt_Cari.Text.ToLower()))
                .ToList();

            //List<CariHesapViewModel> araListe = new List<CariHesapViewModel>();
            //foreach (var item in Program.CariRep.CariHesapOzetListe())
            //    if (item.Unvan.ToLower().Contains(txt_Cari.Text.ToLower()))
            //        araListe.Add(item);
            //dataGridView1.DataSource = araListe;
            
        }

        private void btn_CariDuzenle_Click(object sender, EventArgs e)
        {
            int c = ((CariHesapViewModel)dataGridView1.SelectedRows[0].DataBoundItem).CariKod;
            YeniCariHesapEkran y = new YeniCariHesapEkran();
            y.SeciliCari = Program.CariRep.Liste
                .Where(x => x.CariKod == c)
                .FirstOrDefault();
            y.Show();
        }

        private void CariHesaplarListe_Resize(object sender, EventArgs e)
        {
            Guncelleme();
        }
    }
}
