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
    public partial class HesapActirma : Form
    {
        private Business.Musteri MusteriBusiness;

        public HesapActirma()
        {
            InitializeComponent();
            MusteriBusiness = new Business.Musteri();
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                HesapInputModel hesap = new HesapInputModel()
                {
                    MusteriNo = lblMusteriBilgisi.Tag != null ? (int)lblMusteriBilgisi.Tag : 0,
                    HesapAdi = txtHesapAdi.Text
                };

                MusteriBusiness.HesapAc(hesap);

                txtHesapAdi.Text = string.Empty;
                MessageBox.Show("Hesap açma işlemi başarıyla gerçekleştirilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHesapAdi.Focus();
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
                txtHesapAdi.Focus();
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HesapActirma_FormClosing(object sender, FormClosingEventArgs e)
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
