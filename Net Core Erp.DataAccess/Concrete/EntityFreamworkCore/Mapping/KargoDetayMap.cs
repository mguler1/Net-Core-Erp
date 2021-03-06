using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net_Core_Erp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Core_Erp.DataAccess.Concrete.EntityFreamworkCore.Mapping
{
    public class KargoDetayMap : IEntityTypeConfiguration<KargoDetay>
    {
        public void Configure(EntityTypeBuilder<KargoDetay> builder)
        {
            builder.HasKey(I => I.KargoDetayID);
            builder.Property(I => I.KargoDetayID).UseIdentityColumn();
            builder.Property(I => I.Aciklama).HasMaxLength(300);
            builder.Property(I => I.TakipKodu).HasMaxLength(10);
            builder.Property(I => I.Personel).HasMaxLength(10);
        }
    }
}
