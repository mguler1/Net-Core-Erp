using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net_Core_Erp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Core_Erp.DataAccess.Concrete.EntityFreamworkCore.Mapping
{
    public class FaturaMap : IEntityTypeConfiguration<Fatura>
    {
        public void Configure(EntityTypeBuilder<Fatura> builder)
        {
            builder.HasKey(I => I.FaturaID);
            builder.Property(I => I.FaturaID).UseIdentityColumn();
            builder.Property(I => I.FaturaSeriNo).HasMaxLength(1).HasColumnType("Char");
            builder.Property(I => I.FaturaSıraNo).HasMaxLength(6);
            builder.Property(I => I.Tarih).HasColumnType("DateTime");
            builder.Property(I => I.Saat).HasMaxLength(5).HasColumnType("Char");
            builder.Property(I => I.VergiDairesi).HasMaxLength(60);
            builder.Property(I => I.TeslimAlan).HasMaxLength(30);
            builder.Property(I => I.TeslimEden).HasMaxLength(30);

            builder.HasMany(I => I.FaturaKalems).WithOne(I => I.Fatura).HasForeignKey(I => I.Faturaid);
        }
    }
}
