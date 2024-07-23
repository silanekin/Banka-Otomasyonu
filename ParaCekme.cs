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
    public partial class ParaCekme : Form
    {
        private Business.Musteri MusteriBusiness;

        public ParaCekme()
        {
            InitializeComponent();
            MusteriBusiness = new Business.Musteri();
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            try
            {
                var paraCekme = new ParaCekmeInputModel()
                {
                    HesapNo = lblHesapBilgisi.Tag != null ? lblHesapBilgisi.Tag.ToString() : "",
                    Tutar = txtTutar.Text
                };

                MusteriBusiness.ParaCek(paraCekme);

                lblHesapBilgisi.Tag = null;
                lblHesapBilgisi.Text = string.Empty;
                txtTutar.Text = string.Empty;
                MessageBox.Show("Para çekme işlemi başarıyla gerçekleştirilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTutar.Focus();
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
                txtTutar.Focus();
            }
        }

        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ParaCekme_FormClosing(object sender, FormClosingEventArgs e)
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
