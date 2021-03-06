using Net_Core_Erp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Core_Erp.Entities.Concrete
{
   public class Admin:ITablo
    {
       
        public int AdminID { get; set; }
        
        public string KullaniciAd { get; set; }
      
        public string Sifre { get; set; }
       
        public string Yetki { get; set; }
    }
}
