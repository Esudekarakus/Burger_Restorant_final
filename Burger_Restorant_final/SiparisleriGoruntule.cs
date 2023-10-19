using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burger_Restorant_final
{
    public partial class SiparisleriGoruntule : Form
    {
        public SiparisleriGoruntule()
        {
            InitializeComponent();
        }

        private void SiparisleriGoruntule_Load(object sender, EventArgs e)
        {
            double ciro = 0;
            int toplamSiparis = 0;
            double ekstraMalzemeGeliri = 0;
            int satilanUrunAdedi = 0;
            foreach (string s in Form1.OnayliSiparis)
            {
                lstAlinanTumSiparisler.Items.Add(s);
            }
            foreach (Siparis siparis in Form1.Siparisler)
            {
                
                ciro += siparis.SiparisUcreti;
                foreach (EkstraMalzeme malz in Form1.satilanEkstraMalzemeler)
                {
                    ekstraMalzemeGeliri += malz.EkstraMalzemeFiyat;
                    
                }
                toplamSiparis += Form1.Siparisler.Count;

                

                satilanUrunAdedi += Form1.satilanEkstraMalzemeler.Count+Form1.Siparisler.Count;

                
            }
            lblCiro.Text = ciro.ToString();
            lblEkstraMalzemeGeliri.Text = ekstraMalzemeGeliri.ToString();
            lblSatilanUrunAdedi.Text = satilanUrunAdedi.ToString();
            lblToplamSiparis.Text = toplamSiparis.ToString();
            


        }
    }
}
