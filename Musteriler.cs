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
    public partial class Musteriler : Form
    {
        public int SecilenMusteriId { get; set; }
        public string SecilenMusteriAdi { get; set; }
        public string SecilenMusteriSoyadi { get; set; }

        public Musteriler()
        {
            InitializeComponent();
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            grdMusteriler.DataSource = Context.Musteriler;
        }

        private void grdMusteriler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grdMusteriler.Rows[e.RowIndex];
                SecilenMusteriId = Convert.ToInt32(row.Cells["Id"].Value);
                SecilenMusteriAdi = row.Cells["Adi"].Value.ToString();
                SecilenMusteriSoyadi = row.Cells["Soyadi"].Value.ToString();
                this.Close();
            }
        }
    }
}
