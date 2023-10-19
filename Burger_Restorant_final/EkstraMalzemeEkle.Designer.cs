namespace Burger_Restorant_final
{
    partial class EkstraMalzemeEkle
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
            btnEkstraMalzemeEkle = new Button();
            numericUpFiyatEkstraMalzeme = new NumericUpDown();
            txtEkstraMalzemeAd = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpFiyatEkstraMalzeme).BeginInit();
            SuspendLayout();
            // 
            // btnEkstraMalzemeEkle
            // 
            btnEkstraMalzemeEkle.Location = new Point(54, 168);
            btnEkstraMalzemeEkle.Name = "btnEkstraMalzemeEkle";
            btnEkstraMalzemeEkle.Size = new Size(170, 23);
            btnEkstraMalzemeEkle.TabIndex = 16;
            btnEkstraMalzemeEkle.Text = "Ekle";
            btnEkstraMalzemeEkle.UseVisualStyleBackColor = true;
            btnEkstraMalzemeEkle.Click += btnEkstraMalzemeEkle_Click;
            // 
            // numericUpFiyatEkstraMalzeme
            // 
            numericUpFiyatEkstraMalzeme.Location = new Point(54, 116);
            numericUpFiyatEkstraMalzeme.Name = "numericUpFiyatEkstraMalzeme";
            numericUpFiyatEkstraMalzeme.Size = new Size(170, 23);
            numericUpFiyatEkstraMalzeme.TabIndex = 15;
            // 
            // txtEkstraMalzemeAd
            // 
            txtEkstraMalzemeAd.Location = new Point(54, 80);
            txtEkstraMalzemeAd.Name = "txtEkstraMalzemeAd";
            txtEkstraMalzemeAd.Size = new Size(170, 23);
            txtEkstraMalzemeAd.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 12;
            label3.Text = "Fiyat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 13;
            label2.Text = "Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 11;
            label1.Text = "Ekstra Malzeme Ekle";
            // 
            // EkstraMalzemeEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(347, 278);
            Controls.Add(btnEkstraMalzemeEkle);
            Controls.Add(numericUpFiyatEkstraMalzeme);
            Controls.Add(txtEkstraMalzemeAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EkstraMalzemeEkle";
            Text = "EkstraMalzemeEkle";
            ((System.ComponentModel.ISupportInitialize)numericUpFiyatEkstraMalzeme).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkstraMalzemeEkle;
        private NumericUpDown numericUpFiyatEkstraMalzeme;
        private TextBox txtEkstraMalzemeAd;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}