namespace Burger_Restorant_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SiparisOlusturmaEkraniniGetir();
        }

        public static List<Menu> Menuler = new List<Menu>();
        public static List<EkstraMalzeme> EkstraMalzemeler = new List<EkstraMalzeme>();
        public static List <double>MenuFiyat = new List<double>();
        public static List <string > OnayliSiparis= new List<string>();
        public static List <Siparis>Siparisler= new List<Siparis>();
        public static List <EkstraMalzeme>satilanEkstraMalzemeler=new List<EkstraMalzeme>();
        public void SiparisOlusturmaEkraniniGetir()
        {
            FormlariKapat();
            SiparisEkle siparisEkle = new SiparisEkle();
            siparisEkle.MdiParent = this;
            siparisEkle.Dock = DockStyle.Fill;
            siparisEkle.Show();
        }
        public void FormlariKapat()
        {
            Form[] forms = this.MdiChildren;
            foreach (Form form in forms)
            {
                form.Close();
            }
        }

        private void siparisleriGoruntuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariKapat();
            SiparisleriGoruntule siparisleriGoruntule = new SiparisleriGoruntule();
            siparisleriGoruntule.MdiParent = this;
            siparisleriGoruntule.Dock = DockStyle.Fill;
            siparisleriGoruntule.Show();

        }

        private void siparisOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariKapat();
            SiparisOlusturmaEkraniniGetir();

        }

        private void menuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariKapat();
            MenuEkle menuEkle = new MenuEkle();
            menuEkle.MdiParent = this;
            menuEkle.Dock = DockStyle.Fill;
            menuEkle.Show();
        }

        private void eksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EkstraMalzemeEkle ekstraMalzemeEkle = new EkstraMalzemeEkle();
            ekstraMalzemeEkle.MdiParent = this;
            ekstraMalzemeEkle.Dock = DockStyle.Fill;
            ekstraMalzemeEkle.Show();

        }
    }
}