using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net_Core_Erp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Core_Erp.DataAccess.Concrete.EntityFreamworkCore.Mapping
{
    public class UrunMap : IEntityTypeConfiguration<Urun>
    {
        public void Configure(EntityTypeBuilder<Urun> builder)
        {

            builder.HasKey(I => I.UrunID);
            builder.Property(I => I.UrunID).UseIdentityColumn();
            builder.Property(I => I.UrunAd).HasMaxLength(30);
            builder.Property(I => I.Marka).HasMaxLength(30);
            builder.Property(I => I.UrunGorsel).HasMaxLength(250);
            builder.HasMany(I => I.SatisHarekets).WithOne(I => I.Urun).HasForeignKey(I => I.Urunid);
        }
    }
}
