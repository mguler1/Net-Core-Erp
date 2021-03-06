using Microsoft.EntityFrameworkCore;
using Net_Core_Erp.DataAccess.Concrete.EntityFreamworkCore.Mapping;
using Net_Core_Erp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net_Core_Erp.DataAccess.Concrete.EntityFreamworkCore.Contexts
{
   public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MEHDI;database=KmErp;integrated security=true;");


            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new AdminMap());
            modelBuilder.ApplyConfiguration(new CariMap());
            modelBuilder.ApplyConfiguration(new DepartmanMap());
            modelBuilder.ApplyConfiguration(new DetayMap());
            modelBuilder.ApplyConfiguration(new FaturaMap());
            modelBuilder.ApplyConfiguration(new FaturaKalemMap());
            modelBuilder.ApplyConfiguration(new GiderMap());
            modelBuilder.ApplyConfiguration(new KargoDetayMap());
            modelBuilder.ApplyConfiguration(new KargoTakipMap());
            modelBuilder.ApplyConfiguration(new KategoriMap());
            modelBuilder.ApplyConfiguration(new UrunMap());
            modelBuilder.ApplyConfiguration(new MesajlarMap());
            modelBuilder.ApplyConfiguration(new PersonelMap());
            modelBuilder.ApplyConfiguration(new SatisHareketMap());
            modelBuilder.ApplyConfiguration(new YapilacakMap());
         


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Cari> Caris { get; set; }
        public DbSet<Departman> Departmans { get; set; }
        public DbSet<Fatura> Faturas { get; set; }
        public DbSet<FaturaKalem> FaturaKalems { get; set; }
        public DbSet<Gider> Giders { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<SatisHareket> SatisHarekets { get; set; }
        public DbSet<Urun> Uruns { get; set; }
        public DbSet<Detay> Detays { get; set; }
        public DbSet<Yapilacak> Yapilacaks { get; set; }
        public DbSet<KargoDetay> KargoDetays { get; set; }
        public DbSet<KargoTakip> KargoTakips { get; set; }
        public DbSet<Mesajlar> Mesajlars { get; set; }

    }
}

