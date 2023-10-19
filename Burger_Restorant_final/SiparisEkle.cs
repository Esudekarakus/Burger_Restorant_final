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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Burger_Restorant_final
{
    public partial class SiparisEkle : Form
    {
        public SiparisEkle()
        {
            InitializeComponent();
        }


        double siparisUcreti = 0;
        string siparisBilgi = string.Empty;

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();

            Menu menu = new Menu();
            EkstraMalzeme malzeme = new EkstraMalzeme();
            if (comboMenu.SelectedIndex!=-1 ) 
            {
                menu.MenuAdi = comboMenu.SelectedItem.ToString();
            }
            
            int secilenIndex = comboMenu.SelectedIndex;
            menu.MenuFiyat = Form1.MenuFiyat[secilenIndex];






            foreach (CheckBox cbox in flowLayoutEkstraMalzeme.Controls)
            {
                if (cbox.Checked)
                {
                    siparis.EkstraMalzemeler.Add((EkstraMalzeme)cbox.Tag);
                    foreach(EkstraMalzeme malze in Form1.EkstraMalzemeler)
                    {
                        Form1.satilanEkstraMalzemeler.Add(malze);

                    }

                }
            }
            siparis.SiparisAdeti = (int)numSiparisAdeti.Value;
            //foreach (Control control in this.Controls)
            //{
            //    if (control is RadioButton)
            //    {
            //        RadioButton rb = new RadioButton();
            //        if (rb.Checked)
            //        {
            //            siparis.SiparisBoyu = rb.Text;


            //        }
            //    }
            //}
            if (rBuyuk.Checked)
            {
                siparis.SiparisBoyu = "Büyük";
            }
            else if (rOrta.Checked)
            {
                siparis.SiparisBoyu = "Orta";
            }
            else
            {
                siparis.SiparisBoyu = "Küçük";
            }
            switch (siparis.SiparisBoyu)
            {
                case ("Küçük"):
                    siparisUcreti = menu.MenuFiyat;
                    break;
                case ("Orta"):
                    siparisUcreti = menu.MenuFiyat * 1.5;
                    break;
                case ("Büyük"):
                    siparisUcreti = menu.MenuFiyat * 2;
                    break;
            }



            foreach (EkstraMalzeme malz in Form1.EkstraMalzemeler)
            {
                siparisUcreti += malz.EkstraMalzemeFiyat;
            }
            siparis.SiparisUcreti=siparisUcreti = siparisUcreti * siparis.SiparisAdeti;
            
            siparisBilgi = $"{siparis.SiparisAdeti} adet {siparis.SiparisBoyu} Boy {menu.MenuAdi} Menü,Ekstra Malzemeler: ";
            foreach (CheckBox cbox in flowLayoutEkstraMalzeme.Controls)
            {
                if (cbox.Checked)
                {
                    siparisBilgi += cbox.Text + " ";

                }
            }

            siparisBilgi += $"=> Toplam: {siparisUcreti} ";
            lstSiparisler.Items.Add(siparisBilgi);


            Form1.Siparisler.Add(siparis);


            lblToplamUcret.Text = siparisUcreti.ToString();















        }

        private void SiparisEkle_Load(object sender, EventArgs e)
        {
            foreach (EkstraMalzeme ekstraMalzeme in Form1.EkstraMalzemeler)
            {
                int i = 1;
                i++;
                if (i == 5)
                {
                    flowLayoutEkstraMalzeme.FlowDirection = FlowDirection.LeftToRight;
                    CheckBox cb = new CheckBox();
                    cb.Text = ekstraMalzeme.EkstraMalzemeAdi.ToString();
                    flowLayoutEkstraMalzeme.Controls.Add(cb);

                }
                else
                {
                    flowLayoutEkstraMalzeme.FlowDirection = FlowDirection.TopDown;
                    CheckBox cb = new CheckBox();
                    cb.Text = ekstraMalzeme.EkstraMalzemeAdi.ToString();
                    flowLayoutEkstraMalzeme.Controls.Add(cb);

                }
            }

            foreach (Menu menu in Form1.Menuler)
            {
                comboMenu.Items.Add(menu.MenuAdi.ToString());
            }


        }

        private void btnSiparisiOnayla_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("siparişi onaylıyor musunu?","Onay Mesajı",MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Temizlik.Temizle(this.Controls);
                Form1.OnayliSiparis.Add(siparisBilgi);
                
                lstSiparisler.Items.Clear();
                
            }
            else
            {
                Form1.Siparisler.Clear();
                Form1.satilanEkstraMalzemeler.Clear();
            }
        }
    }

}

