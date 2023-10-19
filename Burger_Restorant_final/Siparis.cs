using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Burger_Restorant_final;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Burger_Restorant_final
{
    public class Siparis
    {
        public Siparis()
        {
            EkstraMalzemeler = new List<EkstraMalzeme>();
        }
        //Sipariş Oluştur
        public Menu Menu { get; set; }

        public List<EkstraMalzeme> EkstraMalzemeler { get; set; }


        public string SiparisBoyu { get; set; }
        public int SiparisAdeti { get; set; }

        

        public double SiparisUcreti { get; set; }
        

        ////Alınan Tüm Siparişler
        //public double Ciro { get; set; }
        //public int ToplamSiparisSayisi { get; set; }

        //private double toplamMalzemeGeliri = 0;
        //public double EkstraMalzemeGeliri 
        //{
        //    get 
        //    {
        //      foreach (EkstraMalzeme malzeme in this.EkstraMalzemeler)
        //        {
        //             toplamMalzemeGeliri +=  malzeme.EkstraMalzemeFiyat;
        //        }

        //      return toplamMalzemeGeliri;   
        //    }


        //}
        //public int SatilanUrunAdedi { get; set; }
        public override string ToString()
        {
            string ekstraMalzemelerIsimleri = string.Empty;
            foreach (EkstraMalzeme malzeme in this.EkstraMalzemeler)
            {
                ekstraMalzemelerIsimleri += malzeme.EkstraMalzemeAdi + " ";
            }

            string bilgi = $"{this.SiparisAdeti} adet {this.Menu.MenuAdi} , {ekstraMalzemelerIsimleri} , {this.SiparisBoyu} Boyu ==> Toplam : {this.SiparisUcreti} ";

            return bilgi;
        }

    }
}
