using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu.Model
{
    public class HesapHareket : BaseModel
    {
        public HesapHareket()
        {
            GlobalVariables.HesapIdentitySeed++;
            Id = GlobalVariables.HesapIdentitySeed;
        }

        public string HesapNo { get; set; }

        public string Aciklama { get; set; }

        public string Bakiye { get; set; }

        public IslemTip IslemTipi { get; set; }

        public string BankadakiToplamPara { get; set; }
    }
}
