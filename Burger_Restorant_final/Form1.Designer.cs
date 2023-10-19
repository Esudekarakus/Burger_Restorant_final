namespace Burger_Restorant_final
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            siparisİslemleriToolStripMenuItem = new ToolStripMenuItem();
            siparisOlusturToolStripMenuItem = new ToolStripMenuItem();
            siparisleriGoruntuleToolStripMenuItem = new ToolStripMenuItem();
            urunIslemleriToolStripMenuItem = new ToolStripMenuItem();
            menuEkleToolStripMenuItem = new ToolStripMenuItem();
            eksToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { siparisİslemleriToolStripMenuItem, urunIslemleriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(869, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // siparisİslemleriToolStripMenuItem
            // 
            siparisİslemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { siparisOlusturToolStripMenuItem, siparisleriGoruntuleToolStripMenuItem });
            siparisİslemleriToolStripMenuItem.Name = "siparisİslemleriToolStripMenuItem";
            siparisİslemleriToolStripMenuItem.Size = new Size(100, 20);
            siparisİslemleriToolStripMenuItem.Text = "Siparis İslemleri";
            // 
            // siparisOlusturToolStripMenuItem
            // 
            siparisOlusturToolStripMenuItem.Name = "siparisOlusturToolStripMenuItem";
            siparisOlusturToolStripMenuItem.Size = new Size(180, 22);
            siparisOlusturToolStripMenuItem.Text = "Siparis Olustur";
            siparisOlusturToolStripMenuItem.Click += siparisOlusturToolStripMenuItem_Click;
            // 
            // siparisleriGoruntuleToolStripMenuItem
            // 
            siparisleriGoruntuleToolStripMenuItem.Name = "siparisleriGoruntuleToolStripMenuItem";
            siparisleriGoruntuleToolStripMenuItem.Size = new Size(180, 22);
            siparisleriGoruntuleToolStripMenuItem.Text = "Siparisleri Goruntule";
            siparisleriGoruntuleToolStripMenuItem.Click += siparisleriGoruntuleToolStripMenuItem_Click;
            // 
            // urunIslemleriToolStripMenuItem
            // 
            urunIslemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuEkleToolStripMenuItem, eksToolStripMenuItem });
            urunIslemleriToolStripMenuItem.Name = "urunIslemleriToolStripMenuItem";
            urunIslemleriToolStripMenuItem.Size = new Size(92, 20);
            urunIslemleriToolStripMenuItem.Text = "Urun Islemleri";
            // 
            // menuEkleToolStripMenuItem
            // 
            menuEkleToolStripMenuItem.Name = "menuEkleToolStripMenuItem";
            menuEkleToolStripMenuItem.Size = new Size(180, 22);
            menuEkleToolStripMenuItem.Text = "Menu Ekle";
            menuEkleToolStripMenuItem.Click += menuEkleToolStripMenuItem_Click;
            // 
            // eksToolStripMenuItem
            // 
            eksToolStripMenuItem.Name = "eksToolStripMenuItem";
            eksToolStripMenuItem.Size = new Size(180, 22);
            eksToolStripMenuItem.Text = "Ekstra Malzeme Ekle";
            eksToolStripMenuItem.Click += eksToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 581);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem siparisİslemleriToolStripMenuItem;
        private ToolStripMenuItem siparisOlusturToolStripMenuItem;
        private ToolStripMenuItem siparisleriGoruntuleToolStripMenuItem;
        private ToolStripMenuItem urunIslemleriToolStripMenuItem;
        private ToolStripMenuItem menuEkleToolStripMenuItem;
        private ToolStripMenuItem eksToolStripMenuItem;
    }
}