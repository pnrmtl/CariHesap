using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class AylikMizanEkran : Form, IGuncelleyebilme
    {
        public AylikMizanEkran()
        {
            InitializeComponent();
        }

        public void Guncelleme()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = Program.CariRep.Liste;
            comboBox1.DisplayMember = "Unvan";
            comboBox1.ValueMember = "CariKod";

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Program.HareketRep.AylikMizanGetir((int)comboBox1.SelectedValue, comboBox2.SelectedIndex+1, Convert.ToInt32(comboBox3.SelectedItem));
        }

        private void AylikMizanEkran_Load(object sender, EventArgs e)
        {
            //c# değişken tipleri : class, struct, enum, delegate, interface
           Type tanim = typeof(Aylar);
            //orjinal isimler : Ocak Subat ...
            //string[] aylar =  tanim.GetEnumNames();
            //comboBox2.DataSource = aylar;

            //Normal Türkçe İsimler
            FieldInfo[] fi = tanim.GetFields();
            foreach (var item in fi)
                if(!item.Name.StartsWith("value"))
                comboBox2.Items.Add(item.Name);

            for (int i = DateTime.Today.Year; i > DateTime.Today.Year - 50; i--)
                comboBox3.Items.Add(i);

            Guncelleme();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guncelleme();
        }
    }
}
