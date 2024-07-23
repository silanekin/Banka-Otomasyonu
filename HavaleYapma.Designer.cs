namespace banka_otomasyonu
{
    partial class HavaleYapma
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
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnOnay = new System.Windows.Forms.Button();
            this.btnGonderenMusteriSec = new System.Windows.Forms.LinkLabel();
            this.lblMusteriBaslik = new System.Windows.Forms.Label();
            this.lblGonderenMusteriBilgisi = new System.Windows.Forms.Label();
            this.btnGonderenHesapSec = new System.Windows.Forms.LinkLabel();
            this.lblGonderenHesapBilgisi = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAliciMusteriSec = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAliciMusteriBilgisi = new System.Windows.Forms.Label();
            this.btnAliciHesapSec = new System.Windows.Forms.LinkLabel();
            this.lblAliciHesapBilgisi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHavaleUcreti = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToplamGonderilecekTutar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grpHavale = new System.Windows.Forms.GroupBox();
            this.grpHavale.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(70, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Havale Yapma Ekranına Hoş Geldiniz";
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Thistle;
            this.btnIptal.Location = new System.Drawing.Point(239, 263);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(2);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(118, 44);
            this.btnIptal.TabIndex = 4;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnOnay
            // 
            this.btnOnay.BackColor = System.Drawing.Color.Thistle;
            this.btnOnay.Location = new System.Drawing.Point(102, 263);
            this.btnOnay.Margin = new System.Windows.Forms.Padding(2);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(118, 44);
            this.btnOnay.TabIndex = 3;
            this.btnOnay.Text = "Onay";
            this.btnOnay.UseVisualStyleBackColor = false;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // btnGonderenMusteriSec
            // 
            this.btnGonderenMusteriSec.AutoSize = true;
            this.btnGonderenMusteriSec.Location = new System.Drawing.Point(236, 29);
            this.btnGonderenMusteriSec.Name = "btnGonderenMusteriSec";
            this.btnGonderenMusteriSec.Size = new System.Drawing.Size(50, 13);
            this.btnGonderenMusteriSec.TabIndex = 40;
            this.btnGonderenMusteriSec.TabStop = true;
            this.btnGonderenMusteriSec.Text = "Seçiniz...";
            this.btnGonderenMusteriSec.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnGonderenMusteriSec_LinkClicked);
            // 
            // lblMusteriBaslik
            // 
            this.lblMusteriBaslik.AutoSize = true;
            this.lblMusteriBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblMusteriBaslik.ForeColor = System.Drawing.Color.Indigo;
            this.lblMusteriBaslik.Location = new System.Drawing.Point(105, 26);
            this.lblMusteriBaslik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMusteriBaslik.Name = "lblMusteriBaslik";
            this.lblMusteriBaslik.Size = new System.Drawing.Size(126, 17);
            this.lblMusteriBaslik.TabIndex = 39;
            this.lblMusteriBaslik.Text = "Gönderen Müşteri:";
            // 
            // lblGonderenMusteriBilgisi
            // 
            this.lblGonderenMusteriBilgisi.AutoSize = true;
            this.lblGonderenMusteriBilgisi.Location = new System.Drawing.Point(292, 29);
            this.lblGonderenMusteriBilgisi.Name = "lblGonderenMusteriBilgisi";
            this.lblGonderenMusteriBilgisi.Size = new System.Drawing.Size(0, 13);
            this.lblGonderenMusteriBilgisi.TabIndex = 41;
            // 
            // btnGonderenHesapSec
            // 
            this.btnGonderenHesapSec.AutoSize = true;
            this.btnGonderenHesapSec.Location = new System.Drawing.Point(236, 61);
            this.btnGonderenHesapSec.Name = "btnGonderenHesapSec";
            this.btnGonderenHesapSec.Size = new System.Drawing.Size(50, 13);
            this.btnGonderenHesapSec.TabIndex = 37;
            this.btnGonderenHesapSec.TabStop = true;
            this.btnGonderenHesapSec.Text = "Seçiniz...";
            this.btnGonderenHesapSec.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnGonderenHesapSec_LinkClicked);
            // 
            // lblGonderenHesapBilgisi
            // 
            this.lblGonderenHesapBilgisi.AutoSize = true;
            this.lblGonderenHesapBilgisi.Location = new System.Drawing.Point(292, 61);
            this.lblGonderenHesapBilgisi.Name = "lblGonderenHesapBilgisi";
            this.lblGonderenHesapBilgisi.Size = new System.Drawing.Size(0, 13);
            this.lblGonderenHesapBilgisi.TabIndex = 38;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(239, 155);
            this.txtTutar.Margin = new System.Windows.Forms.Padding(2);
            this.txtTutar.MaxLength = 15;
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(141, 20);
            this.txtTutar.TabIndex = 2;
            this.txtTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTutar_KeyPress);
            this.txtTutar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTutar_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(185, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Tutar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(110, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Gönderen Hesap:";
            // 
            // btnAliciMusteriSec
            // 
            this.btnAliciMusteriSec.AutoSize = true;
            this.btnAliciMusteriSec.Location = new System.Drawing.Point(236, 93);
            this.btnAliciMusteriSec.Name = "btnAliciMusteriSec";
            this.btnAliciMusteriSec.Size = new System.Drawing.Size(50, 13);
            this.btnAliciMusteriSec.TabIndex = 46;
            this.btnAliciMusteriSec.TabStop = true;
            this.btnAliciMusteriSec.Text = "Seçiniz...";
            this.btnAliciMusteriSec.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnAliciMusteriSec_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(144, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Alıcı Müşteri:";
            // 
            // lblAliciMusteriBilgisi
            // 
            this.lblAliciMusteriBilgisi.AutoSize = true;
            this.lblAliciMusteriBilgisi.Location = new System.Drawing.Point(292, 93);
            this.lblAliciMusteriBilgisi.Name = "lblAliciMusteriBilgisi";
            this.lblAliciMusteriBilgisi.Size = new System.Drawing.Size(0, 13);
            this.lblAliciMusteriBilgisi.TabIndex = 47;
            // 
            // btnAliciHesapSec
            // 
            this.btnAliciHesapSec.AutoSize = true;
            this.btnAliciHesapSec.Location = new System.Drawing.Point(236, 125);
            this.btnAliciHesapSec.Name = "btnAliciHesapSec";
            this.btnAliciHesapSec.Size = new System.Drawing.Size(50, 13);
            this.btnAliciHesapSec.TabIndex = 43;
            this.btnAliciHesapSec.TabStop = true;
            this.btnAliciHesapSec.Text = "Seçiniz...";
            this.btnAliciHesapSec.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnAliciHesapSec_LinkClicked);
            // 
            // lblAliciHesapBilgisi
            // 
            this.lblAliciHesapBilgisi.AutoSize = true;
            this.lblAliciHesapBilgisi.Location = new System.Drawing.Point(292, 125);
            this.lblAliciHesapBilgisi.Name = "lblAliciHesapBilgisi";
            this.lblAliciHesapBilgisi.Size = new System.Drawing.Size(0, 13);
            this.lblAliciHesapBilgisi.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(149, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "Alıcı Hesap:";
            // 
            // txtHavaleUcreti
            // 
            this.txtHavaleUcreti.Location = new System.Drawing.Point(239, 189);
            this.txtHavaleUcreti.Margin = new System.Windows.Forms.Padding(2);
            this.txtHavaleUcreti.MaxLength = 15;
            this.txtHavaleUcreti.Name = "txtHavaleUcreti";
            this.txtHavaleUcreti.ReadOnly = true;
            this.txtHavaleUcreti.Size = new System.Drawing.Size(141, 20);
            this.txtHavaleUcreti.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(134, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Havale Ücreti:";
            // 
            // txtToplamGonderilecekTutar
            // 
            this.txtToplamGonderilecekTutar.Location = new System.Drawing.Point(239, 224);
            this.txtToplamGonderilecekTutar.Margin = new System.Windows.Forms.Padding(2);
            this.txtToplamGonderilecekTutar.MaxLength = 15;
            this.txtToplamGonderilecekTutar.Name = "txtToplamGonderilecekTutar";
            this.txtToplamGonderilecekTutar.ReadOnly = true;
            this.txtToplamGonderilecekTutar.Size = new System.Drawing.Size(141, 20);
            this.txtToplamGonderilecekTutar.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(46, 224);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 17);
            this.label6.TabIndex = 50;
            this.label6.Text = "Toplam Gönderilecek Tutar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(384, 155);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 17);
            this.label8.TabIndex = 52;
            this.label8.Text = "TL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Indigo;
            this.label9.Location = new System.Drawing.Point(384, 192);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 17);
            this.label9.TabIndex = 53;
            this.label9.Text = "TL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Indigo;
            this.label10.Location = new System.Drawing.Point(384, 227);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 17);
            this.label10.TabIndex = 54;
            this.label10.Text = "TL";
            // 
            // grpHavale
            // 
            this.grpHavale.Controls.Add(this.lblMusteriBaslik);
            this.grpHavale.Controls.Add(this.btnOnay);
            this.grpHavale.Controls.Add(this.btnIptal);
            this.grpHavale.Controls.Add(this.label10);
            this.grpHavale.Controls.Add(this.label2);
            this.grpHavale.Controls.Add(this.label9);
            this.grpHavale.Controls.Add(this.label5);
            this.grpHavale.Controls.Add(this.label8);
            this.grpHavale.Controls.Add(this.txtTutar);
            this.grpHavale.Controls.Add(this.txtToplamGonderilecekTutar);
            this.grpHavale.Controls.Add(this.lblGonderenHesapBilgisi);
            this.grpHavale.Controls.Add(this.label6);
            this.grpHavale.Controls.Add(this.btnGonderenHesapSec);
            this.grpHavale.Controls.Add(this.txtHavaleUcreti);
            this.grpHavale.Controls.Add(this.lblGonderenMusteriBilgisi);
            this.grpHavale.Controls.Add(this.label4);
            this.grpHavale.Controls.Add(this.btnGonderenMusteriSec);
            this.grpHavale.Controls.Add(this.btnAliciMusteriSec);
            this.grpHavale.Controls.Add(this.label7);
            this.grpHavale.Controls.Add(this.label3);
            this.grpHavale.Controls.Add(this.lblAliciHesapBilgisi);
            this.grpHavale.Controls.Add(this.lblAliciMusteriBilgisi);
            this.grpHavale.Controls.Add(this.btnAliciHesapSec);
            this.grpHavale.Location = new System.Drawing.Point(76, 63);
            this.grpHavale.Name = "grpHavale";
            this.grpHavale.Size = new System.Drawing.Size(460, 323);
            this.grpHavale.TabIndex = 55;
            this.grpHavale.TabStop = false;
            this.grpHavale.Text = "Havale Bilgileri";
            // 
            // HavaleYapma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(612, 409);
            this.Controls.Add(this.grpHavale);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Indigo;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HavaleYapma";
            this.Text = "Havale Yapma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HavaleYapma_FormClosing);
            this.grpHavale.ResumeLayout(false);
            this.grpHavale.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.LinkLabel btnGonderenMusteriSec;
        private System.Windows.Forms.Label lblMusteriBaslik;
        private System.Windows.Forms.Label lblGonderenMusteriBilgisi;
        private System.Windows.Forms.LinkLabel btnGonderenHesapSec;
        private System.Windows.Forms.Label lblGonderenHesapBilgisi;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel btnAliciMusteriSec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAliciMusteriBilgisi;
        private System.Windows.Forms.LinkLabel btnAliciHesapSec;
        private System.Windows.Forms.Label lblAliciHesapBilgisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHavaleUcreti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToplamGonderilecekTutar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grpHavale;
    }
}