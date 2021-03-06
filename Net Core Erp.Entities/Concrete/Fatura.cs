using Net_Core_Erp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Core_Erp.Entities.Concrete
{
   public class Fatura : ITablo
    {
       
        public int FaturaID { get; set; }
       
        public string FaturaSeriNo { get; set; }

       
        public string FaturaSıraNo { get; set; }

      
        public DateTime Tarih { get; set; }

      
        public string Saat { get; set; }

      
        public string VergiDairesi { get; set; }

        
        public string TeslimEden { get; set; }

        
        public string TeslimAlan { get; set; }

        public decimal Toplam { get; set; }

        public ICollection<FaturaKalem> FaturaKalems { get; set; }//bir faturanın birden fazla kalemi olabilir
    }
}
