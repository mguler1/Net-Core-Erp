using Net_Core_Erp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Core_Erp.Entities.Concrete
{
   public class KargoDetay : ITablo
    {
      
        public int KargoDetayID { get; set; }
       
        public string Aciklama { get; set; }
    
        public string TakipKodu { get; set; }
     
        public string Personel { get; set; }
      
        public string Alici { get; set; }
        public DateTime Tarih { get; set; }
    }
}
