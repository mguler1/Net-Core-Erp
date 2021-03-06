using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net_Core_Erp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Core_Erp.DataAccess.Concrete.EntityFreamworkCore.Mapping
{
    public class SatisHareketMap : IEntityTypeConfiguration<SatisHareket>
    {
        public void Configure(EntityTypeBuilder<SatisHareket> builder)
        {
            builder.HasKey(I => I.SatisID);
            builder.Property(I => I.SatisID).UseIdentityColumn();
         

        }
    }
}
