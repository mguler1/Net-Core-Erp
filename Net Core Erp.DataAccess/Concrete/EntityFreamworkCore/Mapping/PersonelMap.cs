using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net_Core_Erp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Core_Erp.DataAccess.Concrete.EntityFreamworkCore.Mapping
{
    public class PersonelMap : IEntityTypeConfiguration<Personel>
    {
        public void Configure(EntityTypeBuilder<Personel> builder)
        {
            builder.HasKey(I => I.PersonelID);
            builder.Property(I => I.PersonelID).UseIdentityColumn();
            builder.Property(I => I.PersonelAd).HasMaxLength(30);
            builder.Property(I => I.PersonelSoyad).HasMaxLength(30);
            builder.Property(I => I.PersonelGorsel).HasMaxLength(250);
            builder.HasMany(I => I.SatisHarekets).WithOne(I => I.Personel).HasForeignKey(I => I.Personelid);
        }
    }
}
