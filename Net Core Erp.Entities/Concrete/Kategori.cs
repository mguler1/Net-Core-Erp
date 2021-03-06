using Net_Core_Erp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Core_Erp.Entities.Concrete
{
   public class Kategori : ITable
    {
       
        public int KategoriD { get; set; }

        
        public string KategoriAd { get; set; }
        public ICollection<Urun> Uruns { get; set; }//her kategoride birden fazla ürün olabilir
    }
}
