namespace banka_otomasyonu
{
    partial class HesapActirma
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtHesapAdi = new System.Windows.Forms.TextBox();
            this.kaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.lblMusteriBaslik = new System.Windows.Forms.Label();
            this.btnMusteriSec = new System.Windows.Forms.LinkLabel();
            this.lblMusteriBilgisi = new System.Windows.Forms.Label();
            this.grpHesapAc = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.grpHesapAc.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(72, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap Açma Ekranına Hoş Geldiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(110, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hesap Adı:";
            // 
            // txtHesapAdi
            // 
            this.txtHesapAdi.Location = new System.Drawing.Point(201, 75);
            this.txtHesapAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtHesapAdi.Name = "txtHesapAdi";
            this.txtHesapAdi.Size = new System.Drawing.Size(159, 20);
            this.txtHesapAdi.TabIndex = 2;
            // 
            // kaydet
            // 
            this.kaydet.BackColor = System.Drawing.Color.Thistle;
            this.kaydet.Location = new System.Drawing.Point(77, 127);
            this.kaydet.Margin = new System.Windows.Forms.Padding(2);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(109, 37);
            this.kaydet.TabIndex = 3;
            this.kaydet.Text = "Kaydet";
            this.kaydet.UseVisualStyleBackColor = false;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Thistle;
            this.btnIptal.Location = new System.Drawing.Point(201, 127);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(2);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(109, 37);
            this.btnIptal.TabIndex = 4;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // lblMusteriBaslik
            // 
            this.lblMusteriBaslik.AutoSize = true;
            this.lblMusteriBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblMusteriBaslik.ForeColor = System.Drawing.Color.Indigo;
            this.lblMusteriBaslik.Location = new System.Drawing.Point(129, 46);
            this.lblMusteriBaslik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMusteriBaslik.Name = "lblMusteriBaslik";
            this.lblMusteriBaslik.Size = new System.Drawing.Size(58, 17);
            this.lblMusteriBaslik.TabIndex = 12;
            this.lblMusteriBaslik.Text = "Müşteri:";
            // 
            // btnMusteriSec
            // 
            this.btnMusteriSec.AutoSize = true;
            this.btnMusteriSec.Location = new System.Drawing.Point(198, 49);
            this.btnMusteriSec.Name = "btnMusteriSec";
            this.btnMusteriSec.Size = new System.Drawing.Size(50, 13);
            this.btnMusteriSec.TabIndex = 13;
            this.btnMusteriSec.TabStop = true;
            this.btnMusteriSec.Text = "Seçiniz...";
            this.btnMusteriSec.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnMusteriSec_LinkClicked);
            // 
            // lblMusteriBilgisi
            // 
            this.lblMusteriBilgisi.AutoSize = true;
            this.lblMusteriBilgisi.Location = new System.Drawing.Point(254, 49);
            this.lblMusteriBilgisi.Name = "lblMusteriBilgisi";
            this.lblMusteriBilgisi.Size = new System.Drawing.Size(0, 13);
            this.lblMusteriBilgisi.TabIndex = 14;
            // 
            // grpHesapAc
            // 
            this.grpHesapAc.Controls.Add(this.lblMusteriBaslik);
            this.grpHesapAc.Controls.Add(this.btnMusteriSec);
            this.grpHesapAc.Controls.Add(this.lblMusteriBilgisi);
            this.grpHesapAc.Controls.Add(this.label2);
            this.grpHesapAc.Controls.Add(this.btnIptal);
            this.grpHesapAc.Controls.Add(this.txtHesapAdi);
            this.grpHesapAc.Controls.Add(this.kaydet);
            this.grpHesapAc.Location = new System.Drawing.Point(78, 75);
            this.grpHesapAc.Name = "grpHesapAc";
            this.grpHesapAc.Size = new System.Drawing.Size(438, 245);
            this.grpHesapAc.TabIndex = 15;
            this.grpHesapAc.TabStop = false;
            this.grpHesapAc.Text = "Hesap Bilgileri";
            // 
            // HesapActirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(595, 353);
            this.Controls.Add(this.grpHesapAc);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HesapActirma";
            this.Text = "Hesap Açma Ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HesapActirma_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.grpHesapAc.ResumeLayout(false);
            this.grpHesapAc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtHesapAdi;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label lblMusteriBaslik;
        private System.Windows.Forms.LinkLabel btnMusteriSec;
        private System.Windows.Forms.Label lblMusteriBilgisi;
        private System.Windows.Forms.GroupBox grpHesapAc;
    }
}