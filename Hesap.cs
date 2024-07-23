using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu.Model
{
    /// <summary>
    /// Hesap bilgileri.
    /// </summary>
    public class Hesap : BaseModel
    {
        public Hesap()
        {
            GlobalVariables.HesapIdentitySeed++;
            Id = GlobalVariables.HesapIdentitySeed;
        }

        /// <summary>
        /// Müşteri numarası.
        /// </summary>
        public int MusteriNo { get; set; }

        /// <summary>
        /// Hesap adı.
        /// </summary>
        public string HesapAdi { get; set; }

        /// <summary>
        /// Hesap numarası.
        /// </summary>
        public string HesapNo { get; set; }

        /// <summary>
        /// Hesap bakiyesi.
        /// </summary>
        public decimal Bakiye { get; set; }

        /// <summary>
        /// Hesap aktif mi?
        /// </summary>
        public bool Aktif { get; set; }
    }
}
