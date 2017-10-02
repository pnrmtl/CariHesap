﻿using Entity.Models;
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
    public partial class GrupListe : Form
    {
        public GrupListe()
        {
            InitializeComponent();
        }

        private void btn_GrupEkle_Click(object sender, EventArgs e)
        {
            Grup g = new Grup();
            g.GrupAdi = txt_GrupAdi.Text;
            Program.GrupRep.Ekle(g);
            ListeYenile();
            txt_GrupAdi.Clear();

            Program.EkranGuncelle();
        }

        private void GrupListe_Load(object sender, EventArgs e)
        {
            ListeYenile();
        }

        void ListeYenile()
        {
            lst_GrupListe.DataSource = null;
            lst_GrupListe.DataSource = Program.GrupRep.Liste;
            lst_GrupListe.DisplayMember = "GrupAdi";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lst_GrupListe.SelectedIndex == -1)
                MessageBox.Show("Silinecek grup seçiniz.");
            else
            {
                DialogResult secilenBtn = MessageBox.Show("Silmek istediğinize emin misiniz?", "Grup Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (secilenBtn == DialogResult.Yes)
                {
                    Program.GrupRep.Sil((Grup)lst_GrupListe.SelectedItem);
                    ListeYenile();
                    Program.EkranGuncelle();
                }
            }
        }

        Grup duzenlenecekGrup { get; set; }
        private void btn_Duzenle_Click(object sender, EventArgs e)
        {
            if (btn_Duzenle.Text == "Düzenle")
            { //ilk defa düzenleye tıklandığında
                grp_EkleDuzenle.Text = "Grup Düzenle";
                txt_GrupAdi.Text = lst_GrupListe.Text;
                btn_GrupEkle.Enabled = false;
                btn_Duzenle.Text = "Kaydet";
                duzenlenecekGrup = (Grup)lst_GrupListe.SelectedItem;
                btn_Sil.Enabled = false;
            } else
            { //düzenlemeyi kaydederken
                duzenlenecekGrup.GrupAdi = txt_GrupAdi.Text;
                Program.GrupRep.Duzenle(duzenlenecekGrup);
                grp_EkleDuzenle.Text = "Yeni Grup Ekle";
                txt_GrupAdi.Clear();
                btn_GrupEkle.Enabled = true;
                btn_Duzenle.Text = "Düzenle";
                ListeYenile();
                Program.EkranGuncelle();
                btn_Sil.Enabled = true;
            }
        }
    }
}
