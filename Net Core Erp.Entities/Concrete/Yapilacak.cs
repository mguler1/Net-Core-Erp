using Net_Core_Erp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Core_Erp.Entities.Concrete
{
    public class Yapilacak : ITablo
    {
        
        public int YapilacakID { get; set; }
        
        public string Baslik { get; set; }
       
        public bool Durum { get; set; }
     
        public string Süre { get; set; }
    }
}
