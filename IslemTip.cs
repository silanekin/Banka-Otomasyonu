using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu.Model
{
    /// <summary>
    /// İşlem tipleri.
    /// </summary>
    public enum IslemTip
    {
        /// <summary>
        /// Havale.
        /// </summary>
        Havale = 0,

        /// <summary>
        /// Para yatırma.
        /// </summary>
        ParaYatirma = 1,

        /// <summary>
        /// Para çekme.
        /// </summary>
        ParaCekme = 2
    }
}
