namespace banka_otomasyonu
{
    partial class ParaCekme
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
            this.btnHesapSec = new System.Windows.Forms.LinkLabel();
            this.lblHesapBilgisi = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOnay = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMusteriSec = new System.Windows.Forms.LinkLabel();
            this.lblMusteriBaslik = new System.Windows.Forms.Label();
            this.lblMusteriBilgisi = new System.Windows.Forms.Label();
            this.grpParaCekme = new System.Windows.Forms.GroupBox();
            this.grpParaCekme.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(67, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Para Çekme Ekranına Hoş Geldiniz";
            // 
            // btnHesapSec
            // 
            this.btnHesapSec.AutoSize = true;
            this.btnHesapSec.Location = new System.Drawing.Point(207, 74);
            this.btnHesapSec.Name = "btnHesapSec";
            this.btnHesapSec.Size = new System.Drawing.Size(50, 13);
            this.btnHesapSec.TabIndex = 29;
            this.btnHesapSec.TabStop = true;
            this.btnHesapSec.Text = "Seçiniz...";
            this.btnHesapSec.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnHesapSec_LinkClicked);
            // 
            // lblHesapBilgisi
            // 
            this.lblHesapBilgisi.AutoSize = true;
            this.lblHesapBilgisi.Location = new System.Drawing.Point(263, 74);
            this.lblHesapBilgisi.Name = "lblHesapBilgisi";
            this.lblHesapBilgisi.Size = new System.Drawing.Size(0, 13);
            this.lblHesapBilgisi.TabIndex = 30;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(206, 106);
            this.txtTutar.Margin = new System.Windows.Forms.Padding(2);
            this.txtTutar.MaxLength = 15;
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(141, 20);
            this.txtTutar.TabIndex = 2;
            this.txtTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTutar_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(92, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Çekilecek Tutar:";
            // 
            // btnOnay
            // 
            this.btnOnay.BackColor = System.Drawing.Color.Thistle;
            this.btnOnay.Location = new System.Drawing.Point(91, 161);
            this.btnOnay.Margin = new System.Windows.Forms.Padding(2);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(118, 44);
            this.btnOnay.TabIndex = 3;
            this.btnOnay.Text = "Onay";
            this.btnOnay.UseVisualStyleBackColor = false;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.BackColor = System.Drawing.Color.Thistle;
            this.btnİptal.Location = new System.Drawing.Point(229, 161);
            this.btnİptal.Margin = new System.Windows.Forms.Padding(2);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(118, 44);
            this.btnİptal.TabIndex = 4;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = false;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(149, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Hesap:";
            // 
            // btnMusteriSec
            // 
            this.btnMusteriSec.AutoSize = true;
            this.btnMusteriSec.Location = new System.Drawing.Point(207, 42);
            this.btnMusteriSec.Name = "btnMusteriSec";
            this.btnMusteriSec.Size = new System.Drawing.Size(50, 13);
            this.btnMusteriSec.TabIndex = 32;
            this.btnMusteriSec.TabStop = true;
            this.btnMusteriSec.Text = "Seçiniz...";
            this.btnMusteriSec.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnMusteriSec_LinkClicked);
            // 
            // lblMusteriBaslik
            // 
            this.lblMusteriBaslik.AutoSize = true;
            this.lblMusteriBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblMusteriBaslik.ForeColor = System.Drawing.Color.Indigo;
            this.lblMusteriBaslik.Location = new System.Drawing.Point(144, 39);
            this.lblMusteriBaslik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMusteriBaslik.Name = "lblMusteriBaslik";
            this.lblMusteriBaslik.Size = new System.Drawing.Size(58, 17);
            this.lblMusteriBaslik.TabIndex = 31;
            this.lblMusteriBaslik.Text = "Müşteri:";
            // 
            // lblMusteriBilgisi
            // 
            this.lblMusteriBilgisi.AutoSize = true;
            this.lblMusteriBilgisi.Location = new System.Drawing.Point(263, 42);
            this.lblMusteriBilgisi.Name = "lblMusteriBilgisi";
            this.lblMusteriBilgisi.Size = new System.Drawing.Size(0, 13);
            this.lblMusteriBilgisi.TabIndex = 33;
            // 
            // grpParaCekme
            // 
            this.grpParaCekme.Controls.Add(this.btnMusteriSec);
            this.grpParaCekme.Controls.Add(this.label2);
            this.grpParaCekme.Controls.Add(this.lblMusteriBaslik);
            this.grpParaCekme.Controls.Add(this.btnİptal);
            this.grpParaCekme.Controls.Add(this.lblMusteriBilgisi);
            this.grpParaCekme.Controls.Add(this.btnOnay);
            this.grpParaCekme.Controls.Add(this.btnHesapSec);
            this.grpParaCekme.Controls.Add(this.label5);
            this.grpParaCekme.Controls.Add(this.lblHesapBilgisi);
            this.grpParaCekme.Controls.Add(this.txtTutar);
            this.grpParaCekme.Location = new System.Drawing.Point(73, 72);
            this.grpParaCekme.Name = "grpParaCekme";
            this.grpParaCekme.Size = new System.Drawing.Size(433, 242);
            this.grpParaCekme.TabIndex = 34;
            this.grpParaCekme.TabStop = false;
            this.grpParaCekme.Text = "Müşteri ve Hesap Bilgileri";
            // 
            // ParaCekme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(575, 366);
            this.Controls.Add(this.grpParaCekme);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ParaCekme";
            this.Text = "Para Çekme Ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ParaCekme_FormClosing);
            this.grpParaCekme.ResumeLayout(false);
            this.grpParaCekme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel btnHesapSec;
        private System.Windows.Forms.Label lblHesapBilgisi;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel btnMusteriSec;
        private System.Windows.Forms.Label lblMusteriBaslik;
        private System.Windows.Forms.Label lblMusteriBilgisi;
        private System.Windows.Forms.GroupBox grpParaCekme;
    }
}