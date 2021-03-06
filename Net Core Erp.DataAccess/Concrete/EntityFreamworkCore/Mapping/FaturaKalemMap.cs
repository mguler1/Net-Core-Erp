using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net_Core_Erp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Core_Erp.DataAccess.Concrete.EntityFreamworkCore.Mapping
{
   public  class FaturaKalemMap:IEntityTypeConfiguration<FaturaKalem>
    {
       
        public void Configure(EntityTypeBuilder<FaturaKalem> builder)
        {
            builder.HasKey(I => I.FaturaKalemID);
            builder.Property(I => I.FaturaKalemID).UseIdentityColumn();
            builder.Property(I => I.Acıklama).HasMaxLength(100);

        }
    }
}
