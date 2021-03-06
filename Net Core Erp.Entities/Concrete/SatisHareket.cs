using Net_Core_Erp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Net_Core_Erp.Entities.Concrete
{
    public class SatisHareket : ITablo
    {
       
        public int SatisID { get; set; }
        //ürün
        public virtual Urun Urun { get; set; }
        public int Urunid { get; set; }
        //cari
        public virtual Cari Cari { get; set; }
        public int Cariid { get; set; }
        //personel
        public int Personelid { get; set; }
        public virtual Personel Personel { get; set; }
       

        public DateTime Tarih { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal ToplamTutar { get; set; }
    }
}
