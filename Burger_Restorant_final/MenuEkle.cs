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
    public partial class MenuEkle : Form
    {
        public MenuEkle()
        {
            InitializeComponent();
        }

        private void btnMenuEkle_Click(object sender, EventArgs e)
        {
            Menu menu=new Menu();
            menu.MenuAdi=txtMenuAd.Text;
            menu.MenuFiyat = (double)numericUpFiyatMenu.Value;
            Form1.Menuler.Add(menu);
            Form1.MenuFiyat.Add(menu.MenuFiyat);
            MessageBox.Show("Menu başarıyla eklendi.");

            Temizlik.Temizle(this.Controls);
            
        
        }
    }
}
