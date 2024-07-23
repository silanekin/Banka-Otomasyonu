using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business = BankaOtomasyonu.Business;

namespace banka_otomasyonu
{
    public partial class HesapKapatma : Form
    {
        private Business.Musteri MusteriBusiness;

        public HesapKapatma()
        {
            InitializeComponent();
            MusteriBusiness = new Business.Musteri();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            try
            {
                string hesapNo = lblHesapBilgisi.Tag != null ? lblHesapBilgisi.Tag.ToString() : "";
                MusteriBusiness.HesapKapat(hesapNo);

                lblMusteriBilgisi.Tag = null;
                lblMusteriBilgisi.Text = string.Empty;
                lblHesapBilgisi.Tag = null;
                lblHesapBilgisi.Text = string.Empty;
                MessageBox.Show("Hesap kapatma işlemi başarıyla gerçekleştirilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMusteriSec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Musteriler frmMusteriler = new Musteriler();
            frmMusteriler.lblBaslik.Text = "Lütfen çift tıklayarak bir müşteri seçiniz.";
            frmMusteriler.ShowDialog();
            if (frmMusteriler.SecilenMusteriId != 0)
            {
                lblMusteriBilgisi.Tag = frmMusteriler.SecilenMusteriId;
                lblMusteriBilgisi.Text = string.Format("Adı Soyadı: {0} {1}", frmMusteriler.SecilenMusteriAdi, frmMusteriler.SecilenMusteriSoyadi);
                lblHesapBilgisi.Tag = null;
                lblHesapBilgisi.Text = string.Empty;
            }
        }

        private void btnHesapSec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblMusteriBilgisi.Tag == null)
            {
                MessageBox.Show("Lütfen müşteri seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int musteriNo = Convert.ToInt32(lblMusteriBilgisi.Tag);
            Hesaplar frmHesaplar = new Hesaplar(musteriNo);
            frmHesaplar.lblBaslik.Text = "Lütfen çift tıklayarak bir hesap seçiniz.";
            frmHesaplar.ShowDialog();
            if (!string.IsNullOrWhiteSpace(frmHesaplar.SecilenHesapNo))
            {
                lblHesapBilgisi.Tag = frmHesaplar.SecilenHesapNo;
                lblHesapBilgisi.Text = string.Format("Hesap No: {0} Bakiye: {1} TL", frmHesaplar.SecilenHesapNo, frmHesaplar.SecilenHesapBakiyesi);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HesapKapatma_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 2 && Application.OpenForms[this.Name] != null)
            {
                var lblBaslik = Form1.ActiveForm.Controls["lblBaslik"];
                var lblAciklama = Form1.ActiveForm.Controls["lblAciklama"];
                lblBaslik.BringToFront();
                lblAciklama.BringToFront();
            }
        }
    }
}
