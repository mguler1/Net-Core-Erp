using Net_Core_Erp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Core_Erp.Entities.Concrete
{
   public class Cari:ITablo
    {
       
        public int CariID { get; set; }
       
        public string CariAd { get; set; }

      
        public string CariSoyad { get; set; }

      
        public string CariSehir { get; set; }

      
        public string CariMail { get; set; }

       
        public string CariSifre { get; set; }
        public bool Durum { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }
    }
}
