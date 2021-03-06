using Net_Core_Erp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Core_Erp.Entities.Concrete
{
  public  class Urun : ITable
    {
     
        public int UrunID { get; set; }

       
        public string UrunAd { get; set; }
       
        public string Marka { get; set; }
        public short Stok { get; set; }

        
        public decimal AlisFiyat { get; set; }

       
        public decimal SatisFiyat { get; set; }
        public bool Durum { get; set; }

        public string UrunGorsel { get; set; }
        // public int Kategoriid { get; set; }
        public virtual Kategori Kategori { get; set; } //her ürünün bir kategorisi olabilir
        public ICollection<SatisHareket> SatisHarekets { get; set; }
    }

}
