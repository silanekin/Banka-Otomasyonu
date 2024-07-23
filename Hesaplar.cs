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
    public partial class Hesaplar : Form
    {
        private int _musteriNo = 0;
        public string SecilenHesapNo { get; set; }
        public string SecilenHesapBakiyesi { get; set; }

        public Hesaplar(int musteriNo)
        {
            InitializeComponent();
            _musteriNo = musteriNo;
        }

        private void Hesaplar_Load(object sender, EventArgs e)
        {
            var hesaplar = Context.Hesaplar.Where(x => x.Aktif == true).ToList();
            if (_musteriNo != 0)
            {
                hesaplar = Context.Hesaplar.Where(x => x.MusteriNo == _musteriNo && x.Aktif == true).ToList();
            }
            grdHesaplar.DataSource = hesaplar;
        }

        private void grdHesaplar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grdHesaplar.Rows[e.RowIndex];
                SecilenHesapNo = row.Cells["HesapNo"].Value.ToString();
                SecilenHesapBakiyesi = row.Cells["Bakiye"].Value.ToString();
                this.Close();
            }
        }
    }
}
