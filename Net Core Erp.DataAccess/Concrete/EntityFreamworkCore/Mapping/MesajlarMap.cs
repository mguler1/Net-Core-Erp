using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net_Core_Erp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Core_Erp.DataAccess.Concrete.EntityFreamworkCore.Mapping
{
    public class MesajlarMap : IEntityTypeConfiguration<Mesajlar>
    {
        public void Configure(EntityTypeBuilder<Mesajlar> builder)
        {
            builder.HasKey(I => I.MesajId);
            builder.Property(I => I.MesajId).UseIdentityColumn();
            builder.Property(I => I.Gonderici).HasMaxLength(50);
            builder.Property(I => I.Alici).HasMaxLength(50);
            builder.Property(I => I.Konu).HasMaxLength(50);
            builder.Property(I => I.Icerik).HasMaxLength(2000);
        }
    }
}
