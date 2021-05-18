using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Data.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).UseIdentityColumn().HasColumnName("ID");
            builder.Property(m => m.Kod).HasMaxLength(50);
            builder.Property(m => m.Tanim).HasMaxLength(200);
            builder.Property(m => m.Ulke).HasMaxLength(50);
            builder.Property(m => m.UlkeAdi).HasMaxLength(50);
            builder.Property(m => m.Bolge).HasMaxLength(50);
            builder.Property(m => m.BolgeAdi).HasMaxLength(50);
            builder.Property(m => m.Sehir).HasMaxLength(50);
            builder.Property(m => m.SehirAdi).HasMaxLength(50);
            builder.Property(m => m.Ilce).HasMaxLength(50);
            builder.Property(m => m.IlceAdi).HasMaxLength(50);

            builder.ToTable("Cities");
        }
    }
}
