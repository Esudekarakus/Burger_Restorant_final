using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Burger_Restorant_final;

namespace Burger_Restorant_final
{
    public partial class EkstraMalzemeEkle : Form
    {
        public EkstraMalzemeEkle()
        {
            InitializeComponent();
        }

        private void btnEkstraMalzemeEkle_Click(object sender, EventArgs e)
        {
            EkstraMalzeme ekstraMalzeme = new EkstraMalzeme();
            ekstraMalzeme.EkstraMalzemeAdi = txtEkstraMalzemeAd.Text;
            ekstraMalzeme.EkstraMalzemeFiyat = (double)numericUpFiyatEkstraMalzeme.Value;
            Form1.EkstraMalzemeler.Add(ekstraMalzeme);
            MessageBox.Show("Malzeme başarıyla eklendi");
            Temizlik.Temizle(this.Controls);

        }
    }
}
