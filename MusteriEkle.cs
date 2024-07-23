using BankaOtomasyonu.Model.ViewModels;
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
using Model = BankaOtomasyonu.Model;

namespace banka_otomasyonu
{
    public partial class MusteriEkle : Form
    {
        private Business.Musteri MusteriBusiness;

        public MusteriEkle()
        {
            InitializeComponent();
            MusteriBusiness = new Business.Musteri();
        }

        private void btn_kaydol_Click(object sender, EventArgs e)
        {
            try
            {
                var musteri = new MusteriInputModel()
                {
                    Adi = txt_ad.Text,
                    Soyadi = txt_soyad.Text,
                    TcNo = txt_tcKimlikNo.Text,
                    DogumTarihi = txtDogumTarihi.Text,
                    Sifre = txt_sifre.Text,
                    SifreTekrar = txt_sifreTekrar.Text
                };

                if (!rdBireysel.Checked && !rdKurumsal.Checked)
                    musteri.MusteriTip = 0;
                else
                    musteri.MusteriTip = rdBireysel.Checked ? (int)Model.MusteriTip.Bireysel : (int)Model.MusteriTip.Kurumsal;

                MusteriBusiness.MusteriOlustur(musteri);

                txt_ad.Text = string.Empty;
                txt_soyad.Text = string.Empty;
                txt_tcKimlikNo.Text = string.Empty;
                txtDogumTarihi.ResetText();
                txt_sifre.Text = string.Empty;
                txt_sifreTekrar.Text = string.Empty;
                MessageBox.Show("Müşteri kaydı başarıyla oluşturulmuştur.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_ad.Focus();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MusteriEkle_FormClosing(object sender, FormClosingEventArgs e)
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
