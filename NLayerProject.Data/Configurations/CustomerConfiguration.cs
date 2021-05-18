using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerProject.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Data.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn().HasColumnName("ID");
            builder.Property(x => x.HesapKodu).HasMaxLength(30);
            builder.Property(x => x.Unvan).IsRequired().HasMaxLength(100);
            builder.Property(x => x.SubeKodu).HasMaxLength(20);
            builder.Property(x => x.SubeAdi).HasMaxLength(100);
            builder.Property(x => x.Tel1).HasMaxLength(20);
            builder.Property(x => x.Tel2).HasMaxLength(20);
            builder.Property(x => x.Fax).HasMaxLength(20);
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.FaturaCariId).HasColumnName("FaturaCariID");
            builder.Property(x => x.FaturaCariHesapKodu).HasMaxLength(20);
            builder.Property(x => x.FaturaCariUnvan).HasMaxLength(100);
            builder.Property(x => x.Adres).HasMaxLength(100);
            builder.Property(x => x.Adres2).HasMaxLength(100);
            builder.Property(x => x.Sehir).HasMaxLength(50);
            builder.Property(x => x.SehirAdi).HasMaxLength(100);
            builder.Property(x => x.Ulke).HasMaxLength(50);
            builder.Property(x => x.Bolge).HasMaxLength(50);
            builder.Property(x => x.Semt).HasMaxLength(50);
            builder.Property(x => x.PostaKodu).HasMaxLength(10);
            builder.Property(x => x.VergiDairesi).HasMaxLength(40);
            builder.Property(x => x.VergiNo).HasMaxLength(20);
            builder.Property(x => x.TCNo).HasMaxLength(20);
            builder.Property(x => x.Yetkili).HasMaxLength(50);
            builder.Property(x => x.YetkiliTel1).HasMaxLength(20);
            builder.Property(x => x.YetkiliTel2).HasMaxLength(20);
            builder.Property(x => x.YetkiliEmail).HasMaxLength(50);
            builder.Property(x => x.VadeGun).HasDefaultValue(0);
            builder.Property(x => x.OdemeGun).HasDefaultValue(0);
            builder.Property(x => x.IsPasif).HasDefaultValue(false);
            builder.Property(x => x.KayitDate).HasDefaultValueSql("GETDATE()");

            builder.ToTable("Customers");
        }

    }
}
