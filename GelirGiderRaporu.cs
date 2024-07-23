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

namespace banka_otomasyonu
{
    public partial class GelirGiderRaporu : Form
    {
        public GelirGiderRaporu()
        {
            InitializeComponent();
            txtBaslangicTarih.Text = DateTime.Now.AddDays(-1).ToShortDateString();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            DateTime baslangicTarihi = Convert.ToDateTime(txtBaslangicTarih.Text + " " + txtBaslangicSaat.Text);
            DateTime bitisTarihi = Convert.ToDateTime(txtBitisTarih.Text + " " + txtBitisSaat.Text);
            var tumHesapHareketleri = Context.HesapHaraketleri
                .Where(x => x.OlusturulmaTarihi >= baslangicTarihi && x.OlusturulmaTarihi <= bitisTarihi)
                .OrderByDescending(x => x.OlusturulmaTarihi)
                .ToList();

            grdRapor.DataSource = tumHesapHareketleri;
            grdRapor.Columns["Id"].Visible = false;
            grdRapor.Columns["Aciklama"].Width = 290;
        }

        private void GelirGiderRaporu_FormClosing(object sender, FormClosingEventArgs e)
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
