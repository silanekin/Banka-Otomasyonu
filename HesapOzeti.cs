using BankaOtomasyonu.Model;
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
using BankaOtomasyonu.Model.ViewModels;

namespace banka_otomasyonu
{
    public partial class HesapOzeti : Form
    {
        private Business.Musteri MusteriBusiness;

        public HesapOzeti()
        {
            InitializeComponent();
            MusteriBusiness = new Business.Musteri();
            txtBaslangicTarih.Text = DateTime.Now.AddDays(-1).ToShortDateString();
        }

        private void btnHesapSec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hesaplar frmHesaplar = new Hesaplar(0);
            frmHesaplar.lblBaslik.Text = "Lütfen çift tıklayarak bir hesap seçiniz.";
            frmHesaplar.ShowDialog();
            lblHesapBilgisi.Tag = frmHesaplar.SecilenHesapNo;
            lblHesapBilgisi.Text = string.Format("Hesap No: {0} Bakiye: {1} TL", frmHesaplar.SecilenHesapNo, frmHesaplar.SecilenHesapBakiyesi);
        }

        private void btnHesapOzetiGetir_Click(object sender, EventArgs e)
        {
            if (lblHesapBilgisi.Tag == null)
            {
                MessageBox.Show("Lütfen hesap seçiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var hesapHareket = new HesapHareketInputModel()
            {
                HesapNo = lblHesapBilgisi.Tag.ToString(),
                BaslangicTarihi = Convert.ToDateTime(txtBaslangicTarih.Text + " " + txtBaslangicSaat.Text),
                BitisTarihi = Convert.ToDateTime(txtBitisTarih.Text + " " + txtBitisSaat.Text)
            };

            grdHesapOzeti.DataSource = MusteriBusiness.HesapHareketleriListele(hesapHareket);
            grdHesapOzeti.Columns["Id"].Visible = false;
            grdHesapOzeti.Columns["Aciklama"].Width = 290;
        }

        private void HesapOzeti_FormClosing(object sender, FormClosingEventArgs e)
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
