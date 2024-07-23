namespace banka_otomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.islemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapActirmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraCekmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraYatirmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesabaHavaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirGiderRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapOzetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapKapatmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.islemlerToolStripMenuItem,
            this.cikisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // islemlerToolStripMenuItem
            // 
            this.islemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musteriEklemeToolStripMenuItem,
            this.hesapActirmaToolStripMenuItem,
            this.paraCekmeToolStripMenuItem,
            this.paraYatirmaToolStripMenuItem,
            this.hesabaHavaleToolStripMenuItem,
            this.gelirGiderRaporuToolStripMenuItem,
            this.hesapOzetiToolStripMenuItem,
            this.hesapKapatmaToolStripMenuItem});
            this.islemlerToolStripMenuItem.Name = "islemlerToolStripMenuItem";
            this.islemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.islemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // musteriEklemeToolStripMenuItem
            // 
            this.musteriEklemeToolStripMenuItem.Name = "musteriEklemeToolStripMenuItem";
            this.musteriEklemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.musteriEklemeToolStripMenuItem.Text = "Müşteri Ekleme";
            this.musteriEklemeToolStripMenuItem.Click += new System.EventHandler(this.musteriEklemeToolStripMenuItem_Click);
            // 
            // hesapActirmaToolStripMenuItem
            // 
            this.hesapActirmaToolStripMenuItem.Name = "hesapActirmaToolStripMenuItem";
            this.hesapActirmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hesapActirmaToolStripMenuItem.Text = "Hesap Açtırma";
            this.hesapActirmaToolStripMenuItem.Click += new System.EventHandler(this.hesapActirmaToolStripMenuItem_Click);
            // 
            // paraCekmeToolStripMenuItem
            // 
            this.paraCekmeToolStripMenuItem.Name = "paraCekmeToolStripMenuItem";
            this.paraCekmeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paraCekmeToolStripMenuItem.Text = "Para Çekme";
            this.paraCekmeToolStripMenuItem.Click += new System.EventHandler(this.paraCekmeToolStripMenuItem_Click);
            // 
            // paraYatirmaToolStripMenuItem
            // 
            this.paraYatirmaToolStripMenuItem.Name = "paraYatirmaToolStripMenuItem";
            this.paraYatirmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paraYatirmaToolStripMenuItem.Text = "Para Yatırma";
            this.paraYatirmaToolStripMenuItem.Click += new System.EventHandler(this.paraYatirmaToolStripMenuItem_Click);
            // 
            // hesabaHavaleToolStripMenuItem
            // 
            this.hesabaHavaleToolStripMenuItem.Name = "hesabaHavaleToolStripMenuItem";
            this.hesabaHavaleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hesabaHavaleToolStripMenuItem.Text = "Hesaba Havale";
            this.hesabaHavaleToolStripMenuItem.Click += new System.EventHandler(this.hesabaHavaleToolStripMenuItem_Click);
            // 
            // gelirGiderRaporuToolStripMenuItem
            // 
            this.gelirGiderRaporuToolStripMenuItem.Name = "gelirGiderRaporuToolStripMenuItem";
            this.gelirGiderRaporuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gelirGiderRaporuToolStripMenuItem.Text = "Gelir-Gider Raporu";
            this.gelirGiderRaporuToolStripMenuItem.Click += new System.EventHandler(this.gelirGiderRaporuToolStripMenuItem_Click);
            // 
            // hesapOzetiToolStripMenuItem
            // 
            this.hesapOzetiToolStripMenuItem.Name = "hesapOzetiToolStripMenuItem";
            this.hesapOzetiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hesapOzetiToolStripMenuItem.Text = "Hesap Özeti";
            this.hesapOzetiToolStripMenuItem.Click += new System.EventHandler(this.hesapOzetiToolStripMenuItem_Click);
            // 
            // hesapKapatmaToolStripMenuItem
            // 
            this.hesapKapatmaToolStripMenuItem.Name = "hesapKapatmaToolStripMenuItem";
            this.hesapKapatmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hesapKapatmaToolStripMenuItem.Text = "Hesap Kapatma";
            this.hesapKapatmaToolStripMenuItem.Click += new System.EventHandler(this.hesapKapatmaToolStripMenuItem_Click);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.cikisToolStripMenuItem.Text = "Çıkış";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaslik.Location = new System.Drawing.Point(310, 38);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(287, 26);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Banka Otomasyon Programı";
            // 
            // lblAciklama
            // 
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAciklama.Location = new System.Drawing.Point(156, 73);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(609, 56);
            this.lblAciklama.TabIndex = 3;
            this.lblAciklama.Text = "Programdaki tüm akış Şube (Admin) yapısına göre çalışmaktadır. Dolayısıyla işleml" +
    "eri yapan kişi Admin rolündeki kişi olarak kabul edilmiştir.";
            this.lblAciklama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(934, 524);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka Giriş Ekranı";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem islemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraCekmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musteriEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapActirmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraYatirmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesabaHavaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirGiderRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapOzetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapKapatmaToolStripMenuItem;
        public System.Windows.Forms.Label lblBaslik;
        public System.Windows.Forms.Label lblAciklama;
    }
}

