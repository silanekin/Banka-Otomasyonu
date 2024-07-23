using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu.Model
{
    /// <summary>
    /// Memory context.
    /// </summary>
    public static class Context
    {
        public static void Init()
        {
            Musteriler = new List<Musteri>();
            Hesaplar = new List<Hesap>();
            HesapHaraketleri = new List<HesapHareket>();
            BankaToplamParaMiktari = 1000000;
        }

        public static List<Musteri> Musteriler { get; set; }

        public static List<Hesap> Hesaplar { get; set; }

        public static List<HesapHareket> HesapHaraketleri { get; set; }

        public static decimal BankaToplamParaMiktari { get; set; }
    }
}
