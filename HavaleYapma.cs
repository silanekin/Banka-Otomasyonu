using Business = BankaOtomasyonu.Business;
using Model = BankaOtomasyonu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankaOtomasyonu.Model.ViewModels;

namespace banka_otomasyonu
{
    public partial class HavaleYapma : Form
    {
        private Business.Musteri MusteriBusiness;

        public HavaleYapma()
        {
            InitializeComponent();
            MusteriBusiness = new Business.Musteri();
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            try
            {
                var havale = new HavaleInputModel()
                {
                    GonderenHesapNo = lblGonderenHesapBilgisi.Tag != null ? lblGonderenHesapBilgisi.Tag.ToString() : "",
                    AliciHesapNo = lblAliciHesapBilgisi.Tag != null ? lblAliciHesapBilgisi.Tag.ToString() : "",
                    Tutar = txtTutar.Text
                };

                MusteriBusiness.HavaleYap(havale);

                lblGonderenMusteriBilgisi.Tag = null;
                lblGonderenMusteriBilgisi.Text = string.Empty;
                lblGonderenHesapBilgisi.Tag = null;
                lblGonderenHesapBilgisi.Text = string.Empty;
                lblAliciMusteriBilgisi.Tag = null;
                lblAliciMusteriBilgisi.Text = string.Empty;
                lblAliciHesapBilgisi.Tag = null;
                lblAliciHesapBilgisi.Text = string.Empty;
                txtTutar.Text = string.Empty;
                txtHavaleUcreti.Text = string.Empty;
                txtToplamGonderilecekTutar.Text = string.Empty;
                MessageBox.Show("Havale işlemi başarıyla gerçekleştirilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGonderenMusteriSec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Musteriler frmMusteriler = new Musteriler();
            frmMusteriler.lblBaslik.Text = "Lütfen çift tıklayarak bir müşteri seçiniz.";
            frmMusteriler.ShowDialog();
            if (frmMusteriler.SecilenMusteriId != 0)
            {
                if (lblAliciMusteriBilgisi.Tag != null)
                {
                    int aliciMusteriNo = Convert.ToInt32(lblAliciMusteriBilgisi.Tag);
                    if (frmMusteriler.SecilenMusteriId == aliciMusteriNo)
                    {
                        MessageBox.Show("Gönderen ve alıcı müşteri birbirinden farklı olmalıdır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                lblGonderenMusteriBilgisi.Tag = frmMusteriler.SecilenMusteriId;
                lblGonderenMusteriBilgisi.Text = string.Format("Adı Soyadı: {0} {1}", frmMusteriler.SecilenMusteriAdi, frmMusteriler.SecilenMusteriSoyadi);
                lblGonderenHesapBilgisi.Tag = null;
                lblGonderenHesapBilgisi.Text = string.Empty;
            }
        }

        private void btnGonderenHesapSec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblGonderenMusteriBilgisi.Tag == null)
            {
                MessageBox.Show("Lütfen gönderen müşteri seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int musteriNo = Convert.ToInt32(lblGonderenMusteriBilgisi.Tag);
            Hesaplar frmHesaplar = new Hesaplar(musteriNo);
            frmHesaplar.lblBaslik.Text = "Lütfen çift tıklayarak bir hesap seçiniz.";
            frmHesaplar.ShowDialog();
            if (!string.IsNullOrWhiteSpace(frmHesaplar.SecilenHesapNo))
            {
                lblGonderenHesapBilgisi.Tag = frmHesaplar.SecilenHesapNo;
                lblGonderenHesapBilgisi.Text = string.Format("Hesap No: {0} Bakiye: {1} TL", frmHesaplar.SecilenHesapNo, frmHesaplar.SecilenHesapBakiyesi);
            }
        }

        private void btnAliciMusteriSec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Musteriler frmMusteriler = new Musteriler();
            frmMusteriler.lblBaslik.Text = "Lütfen çift tıklayarak bir müşteri seçiniz.";
            frmMusteriler.ShowDialog();
            if (frmMusteriler.SecilenMusteriId != 0)
            {
                if (lblGonderenMusteriBilgisi.Tag != null)
                {
                    int gonderenMusteriNo = Convert.ToInt32(lblGonderenMusteriBilgisi.Tag);
                    if (frmMusteriler.SecilenMusteriId == gonderenMusteriNo)
                    {
                        MessageBox.Show("Gönderen ve alıcı müşteri birbirinden farklı olmalıdır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                lblAliciMusteriBilgisi.Tag = frmMusteriler.SecilenMusteriId;
                lblAliciMusteriBilgisi.Text = string.Format("Adı Soyadı: {0} {1}", frmMusteriler.SecilenMusteriAdi, frmMusteriler.SecilenMusteriSoyadi);
                lblAliciHesapBilgisi.Tag = null;
                lblAliciHesapBilgisi.Text = string.Empty;
            }
        }

        private void btnAliciHesapSec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblAliciMusteriBilgisi.Tag == null)
            {
                MessageBox.Show("Lütfen alıcı müşteri seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int musteriNo = Convert.ToInt32(lblAliciMusteriBilgisi.Tag);
            Hesaplar frmHesaplar = new Hesaplar(musteriNo);
            frmHesaplar.lblBaslik.Text = "Lütfen çift tıklayarak bir hesap seçiniz.";
            frmHesaplar.ShowDialog();
            if (!string.IsNullOrWhiteSpace(frmHesaplar.SecilenHesapNo))
            {
                lblAliciHesapBilgisi.Tag = frmHesaplar.SecilenHesapNo;
                lblAliciHesapBilgisi.Text = string.Format("Hesap No: {0} Bakiye: {1} TL", frmHesaplar.SecilenHesapNo, frmHesaplar.SecilenHesapBakiyesi);
            }
        }

        private void txtTutar_KeyUp(object sender, KeyEventArgs e)
        {
            if (lblGonderenMusteriBilgisi.Tag != null)
            {
                int gonderenMusteriNo = Convert.ToInt32(lblGonderenMusteriBilgisi.Tag);
                var havaleUcretInput = new HavaleUcretHesaplaInputModel()
                {
                    MusteriNo = gonderenMusteriNo,
                    Tutar = txtTutar.Text
                };
                var havaleUcretiSonuc = MusteriBusiness.HavaleUcretiHesapla(havaleUcretInput);
                txtHavaleUcreti.Text = havaleUcretiSonuc.HavaleUcreti.ToString();
                txtToplamGonderilecekTutar.Text = havaleUcretiSonuc.ToplamTutar.ToString();
            }
        }

        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HavaleYapma_FormClosing(object sender, FormClosingEventArgs e)
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
