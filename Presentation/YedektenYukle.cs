using BusinessLogic;
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
    public partial class YedektenYukle : Form
    {
        public YedektenYukle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msj = rd_silAktar.Checked ? "Bu işlem yedekte olmayan tüm kayıtlarınızı silecektir." : "Bu işlem şimdiki kayıtlarla yedekteki kayıtları birleştirecektir.";

            msj += " Devam etmek istiyor musunuz?";
            DialogResult s = MessageBox.Show(msj, "Yedekten Yükle", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (s == DialogResult.Yes)
            {
                OpenFileDialog o = new OpenFileDialog();
                o.Title = "Yüklenecek yedek dosyasını seçiniz";
                o.Filter = "Yedek | *.yaz5";
                if (o.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(Yedek.YedektenYukle(o.FileName, rd_silAktar.Checked));
                    Program.EkranGuncelle();
                }
            }
        }
    }
}
