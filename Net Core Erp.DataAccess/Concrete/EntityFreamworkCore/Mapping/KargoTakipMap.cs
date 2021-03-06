using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net_Core_Erp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Core_Erp.DataAccess.Concrete.EntityFreamworkCore.Mapping
{
    public class KargoTakipMap : IEntityTypeConfiguration<KargoTakip>
    {
        public void Configure(EntityTypeBuilder<KargoTakip> builder)
        {

            builder.HasKey(I => I.KargoTakipID);
            builder.Property(I => I.KargoTakipID).UseIdentityColumn();
            builder.Property(I => I.TakipKodu).HasMaxLength(10);
            builder.Property(I => I.Aciklama).HasMaxLength(100);
        }
    }
}
