using Net_Core_Erp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Core_Erp.Entities.Concrete
{
   public class KargoTakip : ITable
    {
        public int KargoTakipID { get; set; }
      
        public string TakipKodu { get; set; }
       
        public string Aciklama { get; set; }
        public DateTime TarihZaman { get; set; }
    }
}
