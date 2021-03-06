﻿using Net_Core_Erp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Core_Erp.Entities.Concrete
{
   public class Mesajlar : ITable
    {
       
        public int MesajId { get; set; }

       
        public string Gonderici { get; set; }

     
        public string Alici { get; set; }

    
        public string Konu { get; set; }

     
        public string Icerik { get; set; }

        
        public DateTime Tarih { get; set; }
    }
}