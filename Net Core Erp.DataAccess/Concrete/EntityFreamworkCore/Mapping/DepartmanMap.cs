using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net_Core_Erp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Core_Erp.DataAccess.Concrete.EntityFreamworkCore.Mapping
{
    public class DepartmanMap : IEntityTypeConfiguration<Departman>
    {
        public void Configure(EntityTypeBuilder<Departman> builder)
        {
            builder.HasKey(I => I.DepartmanID);
            builder.Property(I => I.DepartmanID).UseIdentityColumn();
            builder.Property(I => I.DepartmanAd).HasMaxLength(30);
            builder.HasMany(I => I.Personels).WithOne(I => I.Departman).HasForeignKey(I => I.departmanid);
        }
    }
}
