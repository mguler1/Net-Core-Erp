using Net_Core_Erp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Core_Erp.Business.Interfaces
{
   public interface IGenericService<Tablo>where Tablo:class,ITablo,new ()
    {
        void Ekle(Tablo tablo);
        void Sil(Tablo tablo);
        void Güncelle(Tablo tablo);
        Tablo Detay(int id);
        List<Tablo> Listele();
    }
}
