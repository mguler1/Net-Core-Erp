using Net_Core_Erp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Core_Erp.Entities.Concrete
{
    public class Personel : ITablo
    {

        public int PersonelID { get; set; }


        public string PersonelAd { get; set; }


        public string PersonelSoyad { get; set; }


        public string PersonelGorsel { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }
        public int departmanid { get; set; }
        public virtual Departman Departman { get; set; }
    }
}
