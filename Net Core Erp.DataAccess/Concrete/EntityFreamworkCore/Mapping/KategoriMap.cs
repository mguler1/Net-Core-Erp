using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net_Core_Erp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Core_Erp.DataAccess.Concrete.EntityFreamworkCore.Mapping
{
    public class KategoriMap : IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            builder.HasKey(I => I.KategorID);
            builder.Property(I => I.KategorID).UseIdentityColumn();
            builder.Property(I => I.KategoriAd).HasMaxLength(30);
            builder.HasMany(I => I.Uruns).WithOne(I => I.Kategori).HasForeignKey(I => I.Kategoriid);
        }
    }
}
