namespace Burger_Restorant_final
{
    partial class SiparisEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisEkle));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            comboMenu = new ComboBox();
            flowLayoutEkstraMalzeme = new FlowLayoutPanel();
            label3 = new Label();
            groupBox1 = new GroupBox();
            rBuyuk = new RadioButton();
            rOrta = new RadioButton();
            rKucuk = new RadioButton();
            label4 = new Label();
            numSiparisAdeti = new NumericUpDown();
            btnSiparisEkle = new Button();
            lstSiparisler = new ListBox();
            label5 = new Label();
            lblToplamUcret = new Label();
            btnSiparisiOnayla = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSiparisAdeti).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 140);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 3;
            label1.Text = "Menu Seciniz";
            // 
            // comboMenu
            // 
            comboMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            comboMenu.FormattingEnabled = true;
            comboMenu.Location = new Point(12, 176);
            comboMenu.Name = "comboMenu";
            comboMenu.Size = new Size(200, 23);
            comboMenu.TabIndex = 4;
            // 
            // flowLayoutEkstraMalzeme
            // 
            flowLayoutEkstraMalzeme.Location = new Point(12, 221);
            flowLayoutEkstraMalzeme.Name = "flowLayoutEkstraMalzeme";
            flowLayoutEkstraMalzeme.Size = new Size(200, 93);
            flowLayoutEkstraMalzeme.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 331);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 16;
            label3.Text = "Boyu Seçiniz";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rBuyuk);
            groupBox1.Controls.Add(rOrta);
            groupBox1.Controls.Add(rKucuk);
            groupBox1.Location = new Point(12, 349);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 68);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // rBuyuk
            // 
            rBuyuk.AutoSize = true;
            rBuyuk.Location = new Point(124, 34);
            rBuyuk.Name = "rBuyuk";
            rBuyuk.Size = new Size(58, 19);
            rBuyuk.TabIndex = 2;
            rBuyuk.TabStop = true;
            rBuyuk.Text = "Büyük";
            rBuyuk.UseVisualStyleBackColor = true;
            // 
            // rOrta
            // 
            rOrta.AutoSize = true;
            rOrta.Location = new Point(70, 34);
            rOrta.Name = "rOrta";
            rOrta.Size = new Size(48, 19);
            rOrta.TabIndex = 1;
            rOrta.TabStop = true;
            rOrta.Text = "Orta";
            rOrta.UseVisualStyleBackColor = true;
            // 
            // rKucuk
            // 
            rKucuk.AutoSize = true;
            rKucuk.Location = new Point(6, 34);
            rKucuk.Name = "rKucuk";
            rKucuk.Size = new Size(58, 19);
            rKucuk.TabIndex = 0;
            rKucuk.TabStop = true;
            rKucuk.Text = "Küçük";
            rKucuk.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 451);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 18;
            label4.Text = "Adet";
            // 
            // numSiparisAdeti
            // 
            numSiparisAdeti.Location = new Point(65, 449);
            numSiparisAdeti.Name = "numSiparisAdeti";
            numSiparisAdeti.Size = new Size(147, 23);
            numSiparisAdeti.TabIndex = 19;
            // 
            // btnSiparisEkle
            // 
            btnSiparisEkle.Location = new Point(12, 490);
            btnSiparisEkle.Name = "btnSiparisEkle";
            btnSiparisEkle.Size = new Size(200, 36);
            btnSiparisEkle.TabIndex = 20;
            btnSiparisEkle.Text = "Siparişi Ekle";
            btnSiparisEkle.UseVisualStyleBackColor = true;
            btnSiparisEkle.Click += btnSiparisEkle_Click;
            // 
            // lstSiparisler
            // 
            lstSiparisler.FormattingEnabled = true;
            lstSiparisler.ItemHeight = 15;
            lstSiparisler.Location = new Point(297, 25);
            lstSiparisler.Name = "lstSiparisler";
            lstSiparisler.Size = new Size(515, 409);
            lstSiparisler.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(278, 451);
            label5.Name = "label5";
            label5.Size = new Size(67, 21);
            label5.TabIndex = 22;
            label5.Text = "Toplam";
            // 
            // lblToplamUcret
            // 
            lblToplamUcret.AutoSize = true;
            lblToplamUcret.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamUcret.ForeColor = Color.Red;
            lblToplamUcret.Location = new Point(351, 451);
            lblToplamUcret.Name = "lblToplamUcret";
            lblToplamUcret.Size = new Size(41, 21);
            lblToplamUcret.TabIndex = 23;
            lblToplamUcret.Text = "0.00";
            // 
            // btnSiparisiOnayla
            // 
            btnSiparisiOnayla.Location = new Point(651, 490);
            btnSiparisiOnayla.Name = "btnSiparisiOnayla";
            btnSiparisiOnayla.Size = new Size(200, 36);
            btnSiparisiOnayla.TabIndex = 24;
            btnSiparisiOnayla.Text = "Siparişi Onayla";
            btnSiparisiOnayla.UseVisualStyleBackColor = true;
            btnSiparisiOnayla.Click += btnSiparisiOnayla_Click;
            // 
            // SiparisEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(885, 608);
            Controls.Add(btnSiparisiOnayla);
            Controls.Add(lblToplamUcret);
            Controls.Add(label5);
            Controls.Add(lstSiparisler);
            Controls.Add(btnSiparisEkle);
            Controls.Add(numSiparisAdeti);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(flowLayoutEkstraMalzeme);
            Controls.Add(comboMenu);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SiparisEkle";
            Text = "SiparisEkle";
            Load += SiparisEkle_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSiparisAdeti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox comboMenu;
        private FlowLayoutPanel flowLayoutEkstraMalzeme;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton rBuyuk;
        private RadioButton rOrta;
        private RadioButton rKucuk;
        private Label label4;
        private NumericUpDown numSiparisAdeti;
        private Button btnSiparisEkle;
        private ListBox lstSiparisler;
        private Label label5;
        private Label lblToplamUcret;
        private Button btnSiparisiOnayla;
    }
}