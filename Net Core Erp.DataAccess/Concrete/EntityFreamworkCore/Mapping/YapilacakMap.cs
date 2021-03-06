using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net_Core_Erp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Core_Erp.DataAccess.Concrete.EntityFreamworkCore.Mapping
{

    public class YapilacakMap : IEntityTypeConfiguration<Yapilacak>
    {
        public void Configure(EntityTypeBuilder<Yapilacak> builder)
        {
            builder.HasKey(I => I.YapilacakID);
            builder.Property(I => I.YapilacakID).UseIdentityColumn();
            builder.Property(I => I.Süre).HasMaxLength(50);
            builder.Property(I => I.Baslik).HasMaxLength(50);
        }
    }
}
