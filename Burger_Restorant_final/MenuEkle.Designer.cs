namespace Burger_Restorant_final
{
    partial class MenuEkle
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
            btnMenuEkle = new Button();
            numericUpFiyatMenu = new NumericUpDown();
            txtMenuAd = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpFiyatMenu).BeginInit();
            SuspendLayout();
            // 
            // btnMenuEkle
            // 
            btnMenuEkle.Location = new Point(54, 168);
            btnMenuEkle.Name = "btnMenuEkle";
            btnMenuEkle.Size = new Size(170, 23);
            btnMenuEkle.TabIndex = 10;
            btnMenuEkle.Text = "Ekle";
            btnMenuEkle.UseVisualStyleBackColor = true;
            btnMenuEkle.Click += btnMenuEkle_Click;
            // 
            // numericUpFiyatMenu
            // 
            numericUpFiyatMenu.Location = new Point(54, 116);
            numericUpFiyatMenu.Name = "numericUpFiyatMenu";
            numericUpFiyatMenu.Size = new Size(170, 23);
            numericUpFiyatMenu.TabIndex = 9;
            // 
            // txtMenuAd
            // 
            txtMenuAd.Location = new Point(54, 80);
            txtMenuAd.Name = "txtMenuAd";
            txtMenuAd.Size = new Size(170, 23);
            txtMenuAd.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 6;
            label3.Text = "Fiyat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 7;
            label2.Text = "Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 5;
            label1.Text = "Menu Ekleme Ekrani";
            // 
            // MenuEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(347, 278);
            Controls.Add(btnMenuEkle);
            Controls.Add(numericUpFiyatMenu);
            Controls.Add(txtMenuAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuEkle";
            Text = "MenuEkle";
            ((System.ComponentModel.ISupportInitialize)numericUpFiyatMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMenuEkle;
        private NumericUpDown numericUpFiyatMenu;
        private TextBox txtMenuAd;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}