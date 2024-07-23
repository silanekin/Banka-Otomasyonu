namespace banka_otomasyonu
{
    partial class HesapKapatma
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
            this.btnKapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnMusteriSec = new System.Windows.Forms.LinkLabel();
            this.lblMusteriBaslik = new System.Windows.Forms.Label();
            this.lblMusteriBilgisi = new System.Windows.Forms.Label();
            this.btnHesapSec = new System.Windows.Forms.LinkLabel();
            this.lblHesapBilgisi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpHesapKapat = new System.Windows.Forms.GroupBox();
            this.grpHesapKapat.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Thistle;
            this.btnKapat.Location = new System.Drawing.Point(77, 134);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(116, 44);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "Hesabı Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(84, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Hesap Kapatma Ekranına Hoş Geldiniz";
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Thistle;
            this.btnIptal.Location = new System.Drawing.Point(225, 134);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(2);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(118, 44);
            this.btnIptal.TabIndex = 5;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnMusteriSec
            // 
            this.btnMusteriSec.AutoSize = true;
            this.btnMusteriSec.Location = new System.Drawing.Point(196, 52);
            this.btnMusteriSec.Name = "btnMusteriSec";
            this.btnMusteriSec.Size = new System.Drawing.Size(50, 13);
            this.btnMusteriSec.TabIndex = 2;
            this.btnMusteriSec.TabStop = true;
            this.btnMusteriSec.Text = "Seçiniz...";
            this.btnMusteriSec.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnMusteriSec_LinkClicked);
            // 
            // lblMusteriBaslik
            // 
            this.lblMusteriBaslik.AutoSize = true;
            this.lblMusteriBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblMusteriBaslik.ForeColor = System.Drawing.Color.Indigo;
            this.lblMusteriBaslik.Location = new System.Drawing.Point(133, 49);
            this.lblMusteriBaslik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMusteriBaslik.Name = "lblMusteriBaslik";
            this.lblMusteriBaslik.Size = new System.Drawing.Size(58, 17);
            this.lblMusteriBaslik.TabIndex = 49;
            this.lblMusteriBaslik.Text = "Müşteri:";
            // 
            // lblMusteriBilgisi
            // 
            this.lblMusteriBilgisi.AutoSize = true;
            this.lblMusteriBilgisi.Location = new System.Drawing.Point(252, 52);
            this.lblMusteriBilgisi.Name = "lblMusteriBilgisi";
            this.lblMusteriBilgisi.Size = new System.Drawing.Size(0, 13);
            this.lblMusteriBilgisi.TabIndex = 51;
            // 
            // btnHesapSec
            // 
            this.btnHesapSec.AutoSize = true;
            this.btnHesapSec.Location = new System.Drawing.Point(196, 85);
            this.btnHesapSec.Name = "btnHesapSec";
            this.btnHesapSec.Size = new System.Drawing.Size(50, 13);
            this.btnHesapSec.TabIndex = 3;
            this.btnHesapSec.TabStop = true;
            this.btnHesapSec.Text = "Seçiniz...";
            this.btnHesapSec.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnHesapSec_LinkClicked);
            // 
            // lblHesapBilgisi
            // 
            this.lblHesapBilgisi.AutoSize = true;
            this.lblHesapBilgisi.Location = new System.Drawing.Point(252, 85);
            this.lblHesapBilgisi.Name = "lblHesapBilgisi";
            this.lblHesapBilgisi.Size = new System.Drawing.Size(0, 13);
            this.lblHesapBilgisi.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(138, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Hesap:";
            // 
            // grpHesapKapat
            // 
            this.grpHesapKapat.Controls.Add(this.btnMusteriSec);
            this.grpHesapKapat.Controls.Add(this.btnIptal);
            this.grpHesapKapat.Controls.Add(this.label2);
            this.grpHesapKapat.Controls.Add(this.btnKapat);
            this.grpHesapKapat.Controls.Add(this.lblMusteriBaslik);
            this.grpHesapKapat.Controls.Add(this.lblHesapBilgisi);
            this.grpHesapKapat.Controls.Add(this.lblMusteriBilgisi);
            this.grpHesapKapat.Controls.Add(this.btnHesapSec);
            this.grpHesapKapat.Location = new System.Drawing.Point(89, 82);
            this.grpHesapKapat.Name = "grpHesapKapat";
            this.grpHesapKapat.Size = new System.Drawing.Size(433, 216);
            this.grpHesapKapat.TabIndex = 52;
            this.grpHesapKapat.TabStop = false;
            this.grpHesapKapat.Text = "Hesap Bilgileri";
            // 
            // HesapKapatma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(600, 331);
            this.Controls.Add(this.grpHesapKapat);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HesapKapatma";
            this.Text = "HesapKapatma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HesapKapatma_FormClosing);
            this.grpHesapKapat.ResumeLayout(false);
            this.grpHesapKapat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.LinkLabel btnMusteriSec;
        private System.Windows.Forms.Label lblMusteriBaslik;
        private System.Windows.Forms.Label lblMusteriBilgisi;
        private System.Windows.Forms.LinkLabel btnHesapSec;
        private System.Windows.Forms.Label lblHesapBilgisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpHesapKapat;
    }
}