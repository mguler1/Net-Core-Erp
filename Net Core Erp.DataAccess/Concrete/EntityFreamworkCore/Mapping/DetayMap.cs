using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net_Core_Erp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Core_Erp.DataAccess.Concrete.EntityFreamworkCore.Mapping
{
    public class DetayMap : IEntityTypeConfiguration<Detay>
    {
        public void Configure(EntityTypeBuilder<Detay> builder)
        {
            builder.HasKey(I => I.DetayID);
            builder.Property(I => I.DetayID).UseIdentityColumn();
            builder.Property(I => I.UrunAd).HasMaxLength(30);
            builder.Property(I => I.UrunBilgi).HasMaxLength(2500);
        }
    }
}
