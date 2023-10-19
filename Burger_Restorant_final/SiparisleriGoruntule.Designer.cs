namespace Burger_Restorant_final
{
    partial class SiparisleriGoruntule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lstAlinanTumSiparisler = new ListBox();
            label2 = new Label();
            lblCiro = new Label();
            label3 = new Label();
            lblToplamSiparis = new Label();
            label4 = new Label();
            lblEkstraMalzemeGeliri = new Label();
            label5 = new Label();
            lblSatilanUrunAdedi = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 30);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 1;
            label1.Text = "Alınan Tüm Siparişler";
            // 
            // lstAlinanTumSiparisler
            // 
            lstAlinanTumSiparisler.FormattingEnabled = true;
            lstAlinanTumSiparisler.ItemHeight = 15;
            lstAlinanTumSiparisler.Location = new Point(28, 54);
            lstAlinanTumSiparisler.Name = "lstAlinanTumSiparisler";
            lstAlinanTumSiparisler.Size = new Size(481, 349);
            lstAlinanTumSiparisler.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(524, 54);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 3;
            label2.Text = "Ciro";
            // 
            // lblCiro
            // 
            lblCiro.AutoSize = true;
            lblCiro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCiro.ForeColor = Color.Red;
            lblCiro.Location = new Point(547, 99);
            lblCiro.Name = "lblCiro";
            lblCiro.RightToLeft = RightToLeft.No;
            lblCiro.Size = new Size(31, 15);
            lblCiro.TabIndex = 4;
            lblCiro.Text = "0.00";
            lblCiro.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(524, 144);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 5;
            label3.Text = "Toplam Sipariş";
            // 
            // lblToplamSiparis
            // 
            lblToplamSiparis.AutoSize = true;
            lblToplamSiparis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamSiparis.ForeColor = Color.Red;
            lblToplamSiparis.Location = new Point(547, 189);
            lblToplamSiparis.Name = "lblToplamSiparis";
            lblToplamSiparis.Size = new Size(14, 15);
            lblToplamSiparis.TabIndex = 6;
            lblToplamSiparis.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(524, 234);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 7;
            label4.Text = "Ekstra  Malzeme Geliri";
            // 
            // lblEkstraMalzemeGeliri
            // 
            lblEkstraMalzemeGeliri.AutoSize = true;
            lblEkstraMalzemeGeliri.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEkstraMalzemeGeliri.ForeColor = Color.Red;
            lblEkstraMalzemeGeliri.Location = new Point(547, 279);
            lblEkstraMalzemeGeliri.Name = "lblEkstraMalzemeGeliri";
            lblEkstraMalzemeGeliri.RightToLeft = RightToLeft.No;
            lblEkstraMalzemeGeliri.Size = new Size(31, 15);
            lblEkstraMalzemeGeliri.TabIndex = 8;
            lblEkstraMalzemeGeliri.Text = "0.00";
            lblEkstraMalzemeGeliri.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(524, 324);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 9;
            label5.Text = "Satılan Ürün Adedi";
            // 
            // lblSatilanUrunAdedi
            // 
            lblSatilanUrunAdedi.AutoSize = true;
            lblSatilanUrunAdedi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSatilanUrunAdedi.ForeColor = Color.Red;
            lblSatilanUrunAdedi.Location = new Point(547, 369);
            lblSatilanUrunAdedi.Name = "lblSatilanUrunAdedi";
            lblSatilanUrunAdedi.Size = new Size(14, 15);
            lblSatilanUrunAdedi.TabIndex = 10;
            lblSatilanUrunAdedi.Text = "0";
            // 
            // SiparisleriGoruntule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(705, 457);
            Controls.Add(lblSatilanUrunAdedi);
            Controls.Add(label5);
            Controls.Add(lblEkstraMalzemeGeliri);
            Controls.Add(label4);
            Controls.Add(lblToplamSiparis);
            Controls.Add(label3);
            Controls.Add(lblCiro);
            Controls.Add(label2);
            Controls.Add(lstAlinanTumSiparisler);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SiparisleriGoruntule";
            Text = "SiparisleriGoruntule";
            Load += SiparisleriGoruntule_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstAlinanTumSiparisler;
        private Label label2;
        private Label lblCiro;
        private Label label3;
        private Label lblToplamSiparis;
        private Label label4;
        private Label lblEkstraMalzemeGeliri;
        private Label label5;
        private Label lblSatilanUrunAdedi;
    }
}