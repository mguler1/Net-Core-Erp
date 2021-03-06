using Net_Core_Erp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Core_Erp.Entities.Concrete
{
    public class Detay : ITablo
    {
       
        public int DetayID { get; set; }
      
        public string UrunAd { get; set; }
        
        public string UrunBilgi { get; set; }
    }
}
