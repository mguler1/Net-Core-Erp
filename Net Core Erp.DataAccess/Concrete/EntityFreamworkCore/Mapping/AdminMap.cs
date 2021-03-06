using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net_Core_Erp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Core_Erp.DataAccess.Concrete.EntityFreamworkCore.Mapping
{
    public class AdminMap : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(I => I.AdminID);
            builder.Property(I => I.AdminID).UseIdentityColumn();
            builder.Property(I => I.KullaniciAd).HasMaxLength(10);
            builder.Property(I => I.Sifre).HasMaxLength(10);
            builder.Property(I => I.Yetki).HasMaxLength(1);
        }
    }
}
