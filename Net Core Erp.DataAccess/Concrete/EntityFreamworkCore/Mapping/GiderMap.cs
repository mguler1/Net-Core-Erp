using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net_Core_Erp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Core_Erp.DataAccess.Concrete.EntityFreamworkCore.Mapping
{
    public class GiderMap : IEntityTypeConfiguration<Gider>
    {
        public void Configure(EntityTypeBuilder<Gider> builder)
        {
            builder.HasKey(I => I.GiderID);
            builder.Property(I => I.GiderID).UseIdentityColumn();
            builder.Property(I => I.Acıklama).HasMaxLength(200);
        }
    }
}
