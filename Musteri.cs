using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu.Model
{
    /// <summary>
    /// Müşteri bilgileri.
    /// </summary>
    public class Musteri : BaseModel
    {
        public Musteri()
        {
            GlobalVariables.MusteriIdentitySeed++;
            Id = GlobalVariables.MusteriIdentitySeed;
        }

        /// <summary>
        /// Adı.
        /// </summary>
        public string Adi { get; set; }

        /// <summary>
        /// Soyadı.
        /// </summary>
        public string Soyadi { get; set; }

        /// <summary>
        /// T.C. kimlik numarası.
        /// </summary>
        public string TcNo { get; set; }

        /// <summary>
        /// Doğum tarihi.
        /// </summary>
        public DateTime DogumTarihi { get; set; }

        /// <summary>
        /// Müşteri tipi.
        /// </summary>
        public MusteriTip MusteriTip { get; set; }

        /// <summary>
        /// Şifre.
        /// </summary>
        public string Sifre { get; set; }

        /// <summary>
        /// Günlük para çekme kalan limit miktarı.
        /// </summary>
        public decimal GunlukParaCekmeKalanLimit { get; set; }
    }
}
