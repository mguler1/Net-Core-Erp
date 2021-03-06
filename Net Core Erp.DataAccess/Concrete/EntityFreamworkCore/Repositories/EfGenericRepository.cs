using Net_Core_Erp.DataAccess.Concrete.EntityFreamworkCore.Contexts;
using Net_Core_Erp.DataAccess.Interfaces;
using Net_Core_Erp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net_Core_Erp.DataAccess.Concrete.EntityFreamworkCore.Repositories
{

    public class EfGenericRepository<Tablo> : IGenericDal<Tablo> where Tablo : class, ITablo, new()
    {
        public Tablo Detay(int id)
        {
            using var context = new Context();
            return context.Set<Tablo>().Find(id);
        }

        public void Ekle(Tablo tablo)
        {
            using var context = new Context();
            context.Set<Tablo>().Add(tablo);
            context.SaveChanges();
        }

        public void Güncelle(Tablo tablo)
        {
            using var context = new Context();
            context.Set<Tablo>().Update(tablo);
            context.SaveChanges();
        }

        public List<Tablo> Listele()
        {
            using var context = new Context();
            return context.Set<Tablo>().ToList();
        }

        public void Sil(Tablo tablo)
        {
            using var context = new Context();
            context.Set<Tablo>().Remove(tablo);
            context.SaveChanges();
        }
    }
}
