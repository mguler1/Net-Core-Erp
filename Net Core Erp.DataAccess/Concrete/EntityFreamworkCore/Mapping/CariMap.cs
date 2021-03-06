using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net_Core_Erp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Core_Erp.DataAccess.Concrete.EntityFreamworkCore.Mapping
{
    public class CariMap : IEntityTypeConfiguration<Cari>
    {
        public void Configure(EntityTypeBuilder<Cari> builder)
        {
            builder.HasKey(I => I.CariID);
            builder.Property(I => I.CariID).UseIdentityColumn();
            builder.Property(I => I.CariAd).HasMaxLength(30);
            builder.Property(I => I.CariSehir).HasMaxLength(13);
            builder.Property(I => I.CariMail).HasMaxLength(50);
            builder.Property(I => I.CariSifre).HasMaxLength(20);

            builder.HasMany(I => I.SatisHarekets).WithOne(I => I.Cari).HasForeignKey(I => I.Cariid);
        }
    }
}
