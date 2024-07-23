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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void musteriEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["MusteriEkle"] != null)
            {
                Application.OpenForms["MusteriEkle"].Focus();
            }
            else
            {
                MusteriEkle musteriEkle = new MusteriEkle();
                musteriEkle.MdiParent = this;
                musteriEkle.Show();
            }
            lblBaslik.SendToBack();
            lblAciklama.SendToBack();
        }

        private void hesapActirmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["HesapActirma"] != null)
            {
                Application.OpenForms["HesapActirma"].Focus();
            }
            else
            {
                HesapActirma hesapActirma = new HesapActirma();
                hesapActirma.MdiParent = this;
                hesapActirma.Show();
            }
            lblBaslik.SendToBack();
            lblAciklama.SendToBack();
        }

        private void paraCekmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ParaCekme"] != null)
            {
                Application.OpenForms["ParaCekme"].Focus();
            }
            else
            {
                ParaCekme paraCek = new ParaCekme();
                paraCek.MdiParent = this;
                paraCek.Show();
            }
            lblBaslik.SendToBack();
            lblAciklama.SendToBack();
        }

        private void paraYatirmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ParaYatirma"] != null)
            {
                Application.OpenForms["ParaYatirma"].Focus();
            }
            else
            {
                ParaYatirma paraYatirma = new ParaYatirma();
                paraYatirma.MdiParent = this;
                paraYatirma.Show();
            }
            lblBaslik.SendToBack();
            lblAciklama.SendToBack();
        }

        private void hesabaHavaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["HavaleYapma"] != null)
            {
                Application.OpenForms["HavaleYapma"].Focus();
            }
            else
            {
                HavaleYapma havale = new HavaleYapma();
                havale.MdiParent = this;
                havale.Show();
            }
            lblBaslik.SendToBack();
            lblAciklama.SendToBack();
        }

        private void gelirGiderRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["GelirGiderRaporu"] != null)
            {
                Application.OpenForms["GelirGiderRaporu"].Focus();
            }
            else
            {
                GelirGiderRaporu rapor = new GelirGiderRaporu();
                rapor.MdiParent = this;
                rapor.Show();
            }
            lblBaslik.SendToBack();
            lblAciklama.SendToBack();
        }

        private void hesapOzetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["HesapOzeti"] != null)
            {
                Application.OpenForms["HesapOzeti"].Focus();
            }
            else
            {
                HesapOzeti hesapOzeti = new HesapOzeti();
                hesapOzeti.MdiParent = this;
                hesapOzeti.Show();
            }
            lblBaslik.SendToBack();
            lblAciklama.SendToBack();
        }

        private void hesapKapatmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["HesapKapatma"] != null)
            {
                Application.OpenForms["HesapKapatma"].Focus();
            }
            else
            {
                HesapKapatma hesapKapatma = new HesapKapatma();
                hesapKapatma.MdiParent = this;
                hesapKapatma.Show();
            }
            lblBaslik.SendToBack();
            lblAciklama.SendToBack();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
