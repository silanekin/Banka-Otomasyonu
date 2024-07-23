using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu.Model
{
    /// <summary>
    /// Temel model özellikleri.
    /// </summary>
    public abstract class BaseModel
    {
        /// <summary>
        /// Identity no.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Kayıt oluşturulma tarihi.
        /// </summary>        
        public DateTime OlusturulmaTarihi { get; set; }
    }
}
