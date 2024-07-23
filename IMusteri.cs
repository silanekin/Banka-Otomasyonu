using BankaOtomasyonu.Model;
using BankaOtomasyonu.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu.Business
{
    public interface IMusteri
    {
        void MusteriOlustur(MusteriInputModel musteri);

        void HesapAc(HesapInputModel hesap);

        void HesapKapat(string hesapNo);

        void ParaYatir(ParaYatirmaInputModel paraYatirma);

        void ParaCek(ParaCekmeInputModel paraCekme);

        void HavaleYap(HavaleInputModel havale);

        HavaleUcretiResultModel HavaleUcretiHesapla(HavaleUcretHesaplaInputModel havaleUcretHesaplInput);

        List<HesapHareket> HesapHareketleriListele(HesapHareketInputModel hesapHareket);
    }
}
