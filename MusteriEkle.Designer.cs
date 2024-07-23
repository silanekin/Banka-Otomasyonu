namespace banka_otomasyonu
{
    partial class MusteriEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.txt_tcKimlikNo = new System.Windows.Forms.TextBox();
            this.lbl_tcKimlikNo = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.txt_sifreTekrar = new System.Windows.Forms.TextBox();
            this.lbl_sifre2 = new System.Windows.Forms.Label();
            this.btn_kaydol = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblTip = new System.Windows.Forms.Label();
            this.rdBireysel = new System.Windows.Forms.RadioButton();
            this.rdKurumsal = new System.Windows.Forms.RadioButton();
            this.grpMusteriler = new System.Windows.Forms.GroupBox();
            this.grpMusteriler.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(99, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Ekleme Paneline Hoş Geldiniz";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_ad.Location = new System.Drawing.Point(56, 38);
            this.lbl_ad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(23, 13);
            this.lbl_ad.TabIndex = 1;
            this.lbl_ad.Text = "Ad:";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(81, 35);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(126, 20);
            this.txt_ad.TabIndex = 2;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(322, 38);
            this.txt_soyad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(126, 20);
            this.txt_soyad.TabIndex = 3;
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_soyad.Location = new System.Drawing.Point(280, 38);
            this.lbl_soyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(40, 13);
            this.lbl_soyad.TabIndex = 3;
            this.lbl_soyad.Text = "Soyad:";
            // 
            // txt_tcKimlikNo
            // 
            this.txt_tcKimlikNo.Location = new System.Drawing.Point(81, 72);
            this.txt_tcKimlikNo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tcKimlikNo.MaxLength = 11;
            this.txt_tcKimlikNo.Name = "txt_tcKimlikNo";
            this.txt_tcKimlikNo.Size = new System.Drawing.Size(126, 20);
            this.txt_tcKimlikNo.TabIndex = 4;
            // 
            // lbl_tcKimlikNo
            // 
            this.lbl_tcKimlikNo.AutoSize = true;
            this.lbl_tcKimlikNo.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_tcKimlikNo.Location = new System.Drawing.Point(11, 75);
            this.lbl_tcKimlikNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tcKimlikNo.Name = "lbl_tcKimlikNo";
            this.lbl_tcKimlikNo.Size = new System.Drawing.Size(71, 13);
            this.lbl_tcKimlikNo.TabIndex = 5;
            this.lbl_tcKimlikNo.Text = "TC Kimlik No:";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(81, 131);
            this.txt_sifre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sifre.MaxLength = 20;
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(126, 20);
            this.txt_sifre.TabIndex = 8;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_sifre.Location = new System.Drawing.Point(19, 136);
            this.lbl_sifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(62, 13);
            this.lbl_sifre.TabIndex = 7;
            this.lbl_sifre.Text = "Şifre Giriniz:";
            // 
            // txt_sifreTekrar
            // 
            this.txt_sifreTekrar.Location = new System.Drawing.Point(322, 131);
            this.txt_sifreTekrar.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sifreTekrar.MaxLength = 20;
            this.txt_sifreTekrar.Name = "txt_sifreTekrar";
            this.txt_sifreTekrar.PasswordChar = '*';
            this.txt_sifreTekrar.Size = new System.Drawing.Size(126, 20);
            this.txt_sifreTekrar.TabIndex = 9;
            // 
            // lbl_sifre2
            // 
            this.lbl_sifre2.AutoSize = true;
            this.lbl_sifre2.ForeColor = System.Drawing.Color.Indigo;
            this.lbl_sifre2.Location = new System.Drawing.Point(228, 134);
            this.lbl_sifre2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sifre2.Name = "lbl_sifre2";
            this.lbl_sifre2.Size = new System.Drawing.Size(96, 13);
            this.lbl_sifre2.TabIndex = 9;
            this.lbl_sifre2.Text = "Tekrar Şifre Giriniz:";
            // 
            // btn_kaydol
            // 
            this.btn_kaydol.BackColor = System.Drawing.Color.Thistle;
            this.btn_kaydol.Location = new System.Drawing.Point(185, 175);
            this.btn_kaydol.Margin = new System.Windows.Forms.Padding(2);
            this.btn_kaydol.Name = "btn_kaydol";
            this.btn_kaydol.Size = new System.Drawing.Size(116, 49);
            this.btn_kaydol.TabIndex = 10;
            this.btn_kaydol.Text = "Kaydol";
            this.btn_kaydol.UseVisualStyleBackColor = false;
            this.btn_kaydol.Click += new System.EventHandler(this.btn_kaydol_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(249, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Doğum Tarihi:";
            // 
            // txtDogumTarihi
            // 
            this.txtDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDogumTarihi.Location = new System.Drawing.Point(322, 69);
            this.txtDogumTarihi.Name = "txtDogumTarihi";
            this.txtDogumTarihi.Size = new System.Drawing.Size(126, 20);
            this.txtDogumTarihi.TabIndex = 5;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.ForeColor = System.Drawing.Color.Indigo;
            this.lblTip.Location = new System.Drawing.Point(8, 108);
            this.lblTip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(64, 13);
            this.lblTip.TabIndex = 15;
            this.lblTip.Text = "Müşteri Tipi:";
            // 
            // rdBireysel
            // 
            this.rdBireysel.AutoSize = true;
            this.rdBireysel.Location = new System.Drawing.Point(81, 107);
            this.rdBireysel.Name = "rdBireysel";
            this.rdBireysel.Size = new System.Drawing.Size(98, 17);
            this.rdBireysel.TabIndex = 6;
            this.rdBireysel.TabStop = true;
            this.rdBireysel.Text = "Bireysel Müşteri";
            this.rdBireysel.UseVisualStyleBackColor = true;
            // 
            // rdKurumsal
            // 
            this.rdKurumsal.AutoSize = true;
            this.rdKurumsal.Location = new System.Drawing.Point(185, 106);
            this.rdKurumsal.Name = "rdKurumsal";
            this.rdKurumsal.Size = new System.Drawing.Size(105, 17);
            this.rdKurumsal.TabIndex = 7;
            this.rdKurumsal.TabStop = true;
            this.rdKurumsal.Text = "Kurumsal Müşteri";
            this.rdKurumsal.UseVisualStyleBackColor = true;
            // 
            // grpMusteriler
            // 
            this.grpMusteriler.Controls.Add(this.txt_ad);
            this.grpMusteriler.Controls.Add(this.btn_kaydol);
            this.grpMusteriler.Controls.Add(this.rdKurumsal);
            this.grpMusteriler.Controls.Add(this.lbl_ad);
            this.grpMusteriler.Controls.Add(this.rdBireysel);
            this.grpMusteriler.Controls.Add(this.lbl_soyad);
            this.grpMusteriler.Controls.Add(this.lblTip);
            this.grpMusteriler.Controls.Add(this.txt_soyad);
            this.grpMusteriler.Controls.Add(this.txtDogumTarihi);
            this.grpMusteriler.Controls.Add(this.lbl_tcKimlikNo);
            this.grpMusteriler.Controls.Add(this.label2);
            this.grpMusteriler.Controls.Add(this.txt_tcKimlikNo);
            this.grpMusteriler.Controls.Add(this.lbl_sifre);
            this.grpMusteriler.Controls.Add(this.txt_sifreTekrar);
            this.grpMusteriler.Controls.Add(this.txt_sifre);
            this.grpMusteriler.Controls.Add(this.lbl_sifre2);
            this.grpMusteriler.Location = new System.Drawing.Point(60, 78);
            this.grpMusteriler.Name = "grpMusteriler";
            this.grpMusteriler.Size = new System.Drawing.Size(499, 242);
            this.grpMusteriler.TabIndex = 16;
            this.grpMusteriler.TabStop = false;
            this.grpMusteriler.Text = "Müşteri Bilgileri";
            // 
            // MusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(616, 366);
            this.Controls.Add(this.grpMusteriler);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MusteriEkle";
            this.Text = "MusteriEkle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MusteriEkle_FormClosing);
            this.grpMusteriler.ResumeLayout(false);
            this.grpMusteriler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.TextBox txt_tcKimlikNo;
        private System.Windows.Forms.Label lbl_tcKimlikNo;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox txt_sifreTekrar;
        private System.Windows.Forms.Label lbl_sifre2;
        private System.Windows.Forms.Button btn_kaydol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtDogumTarihi;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.RadioButton rdBireysel;
        private System.Windows.Forms.RadioButton rdKurumsal;
        private System.Windows.Forms.GroupBox grpMusteriler;
    }
}