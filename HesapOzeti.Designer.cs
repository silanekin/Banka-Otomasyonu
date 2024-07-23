namespace banka_otomasyonu
{
    partial class HesapOzeti
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
            this.btnHesapSec = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.grdHesapOzeti = new System.Windows.Forms.DataGridView();
            this.txtBaslangicTarih = new System.Windows.Forms.DateTimePicker();
            this.txtBitisTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHesapOzetiGetir = new System.Windows.Forms.Button();
            this.lblHesapBilgisi = new System.Windows.Forms.Label();
            this.txtBaslangicSaat = new System.Windows.Forms.DateTimePicker();
            this.txtBitisSaat = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.grdHesapOzeti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHesapSec
            // 
            this.btnHesapSec.AutoSize = true;
            this.btnHesapSec.Location = new System.Drawing.Point(8, 13);
            this.btnHesapSec.Name = "btnHesapSec";
            this.btnHesapSec.Size = new System.Drawing.Size(84, 13);
            this.btnHesapSec.TabIndex = 27;
            this.btnHesapSec.TabStop = true;
            this.btnHesapSec.Text = "Hesap Seçiniz...";
            this.btnHesapSec.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnHesapSec_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Hesap Bilgisi:";
            // 
            // grdHesapOzeti
            // 
            this.grdHesapOzeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHesapOzeti.Location = new System.Drawing.Point(11, 66);
            this.grdHesapOzeti.Margin = new System.Windows.Forms.Padding(2);
            this.grdHesapOzeti.Name = "grdHesapOzeti";
            this.grdHesapOzeti.ReadOnly = true;
            this.grdHesapOzeti.RowHeadersWidth = 51;
            this.grdHesapOzeti.RowTemplate.Height = 24;
            this.grdHesapOzeti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdHesapOzeti.Size = new System.Drawing.Size(715, 361);
            this.grdHesapOzeti.TabIndex = 25;
            // 
            // txtBaslangicTarih
            // 
            this.txtBaslangicTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtBaslangicTarih.Location = new System.Drawing.Point(185, 9);
            this.txtBaslangicTarih.Name = "txtBaslangicTarih";
            this.txtBaslangicTarih.Size = new System.Drawing.Size(95, 20);
            this.txtBaslangicTarih.TabIndex = 2;
            // 
            // txtBitisTarih
            // 
            this.txtBitisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtBitisTarih.Location = new System.Drawing.Point(413, 9);
            this.txtBitisTarih.Name = "txtBitisTarih";
            this.txtBitisTarih.Size = new System.Drawing.Size(95, 20);
            this.txtBitisTarih.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Başlangıç:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(370, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Bitiş:";
            // 
            // btnHesapOzetiGetir
            // 
            this.btnHesapOzetiGetir.BackColor = System.Drawing.Color.Thistle;
            this.btnHesapOzetiGetir.Location = new System.Drawing.Point(607, 5);
            this.btnHesapOzetiGetir.Margin = new System.Windows.Forms.Padding(2);
            this.btnHesapOzetiGetir.Name = "btnHesapOzetiGetir";
            this.btnHesapOzetiGetir.Size = new System.Drawing.Size(119, 28);
            this.btnHesapOzetiGetir.TabIndex = 6;
            this.btnHesapOzetiGetir.Text = "Hesap Özetini Getir";
            this.btnHesapOzetiGetir.UseVisualStyleBackColor = false;
            this.btnHesapOzetiGetir.Click += new System.EventHandler(this.btnHesapOzetiGetir_Click);
            // 
            // lblHesapBilgisi
            // 
            this.lblHesapBilgisi.AutoSize = true;
            this.lblHesapBilgisi.Location = new System.Drawing.Point(106, 38);
            this.lblHesapBilgisi.Name = "lblHesapBilgisi";
            this.lblHesapBilgisi.Size = new System.Drawing.Size(87, 13);
            this.lblHesapBilgisi.TabIndex = 33;
            this.lblHesapBilgisi.Text = "Hesap seçilmedi.";
            // 
            // txtBaslangicSaat
            // 
            this.txtBaslangicSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtBaslangicSaat.Location = new System.Drawing.Point(286, 9);
            this.txtBaslangicSaat.Name = "txtBaslangicSaat";
            this.txtBaslangicSaat.Size = new System.Drawing.Size(79, 20);
            this.txtBaslangicSaat.TabIndex = 3;
            // 
            // txtBitisSaat
            // 
            this.txtBitisSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtBitisSaat.Location = new System.Drawing.Point(514, 9);
            this.txtBitisSaat.Name = "txtBitisSaat";
            this.txtBitisSaat.Size = new System.Drawing.Size(79, 20);
            this.txtBitisSaat.TabIndex = 5;
            // 
            // HesapOzeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(735, 438);
            this.Controls.Add(this.txtBitisSaat);
            this.Controls.Add(this.txtBaslangicSaat);
            this.Controls.Add(this.lblHesapBilgisi);
            this.Controls.Add(this.btnHesapOzetiGetir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBitisTarih);
            this.Controls.Add(this.txtBaslangicTarih);
            this.Controls.Add(this.btnHesapSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grdHesapOzeti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HesapOzeti";
            this.Text = "Hesap Özeti";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HesapOzeti_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grdHesapOzeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel btnHesapSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdHesapOzeti;
        private System.Windows.Forms.DateTimePicker txtBaslangicTarih;
        private System.Windows.Forms.DateTimePicker txtBitisTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHesapOzetiGetir;
        private System.Windows.Forms.Label lblHesapBilgisi;
        private System.Windows.Forms.DateTimePicker txtBaslangicSaat;
        private System.Windows.Forms.DateTimePicker txtBitisSaat;
    }
}