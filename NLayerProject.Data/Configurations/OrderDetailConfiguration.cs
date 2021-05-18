using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerProject.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Data.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).HasColumnName("ID");
            builder.Property(m => m.OrderId).HasColumnName("OrderID");
            builder.Property(m => m.Aciklama).HasMaxLength(100);
            builder.Property(m => m.Aciklama2).HasMaxLength(100);
            builder.Property(m => m.StokId).HasMaxLength(40).HasColumnName("StokID");
            builder.Property(m => m.StokKodu).HasMaxLength(40);
            builder.Property(m => m.StokAdi).HasMaxLength(100);
            builder.Property(m => m.Birim).HasMaxLength(10);
            builder.Property(m => m.Miktar).HasColumnType("decimal (18,6)");
            builder.Property(m => m.Birim2).HasMaxLength(10);
            builder.Property(m => m.Miktar2).HasColumnType("decimal (18,6)");
            builder.Property(m => m.Birim3).HasMaxLength(10);
            builder.Property(m => m.Miktar3).HasColumnType("decimal (18,6)");
            builder.Property(m => m.HesapBirim).HasMaxLength(10);
            builder.Property(m => m.BirimKg).HasColumnType("decimal (18,6)");
            builder.Property(m => m.Kg).HasColumnType("decimal (18,6)");
            builder.Property(m => m.BirimDesi).HasColumnType("decimal (18,6)");
            builder.Property(m => m.Desi).HasColumnType("decimal (18,6)");
            builder.Property(m => m.BirimM3).HasColumnType("decimal (18,6)");
            builder.Property(m => m.M3).HasColumnType("decimal (18,6)");
            builder.Property(m => m.Fiyat).HasColumnType("decimal (18,6)");
            builder.Property(m => m.Tutar).HasColumnType("decimal (18,6)");
            builder.Property(m => m.Masraf).HasColumnType("decimal (18,6)");
            builder.Property(m => m.MasrafNakliye).HasColumnType("decimal (18,6)");
            builder.Property(m => m.BrutTutar).HasColumnType("decimal (18,6)");
            builder.Property(m => m.KdvOran).HasColumnType("decimal (18,6)");
            builder.Property(m => m.Kdv).HasColumnType("decimal (18,6)");
            builder.Property(m => m.Toplam).HasColumnType("decimal (18,6)");
            builder.Property(m => m.DagitimIrsNo).HasMaxLength(500);
            builder.Property(m => m.MusteriIrsNo).HasMaxLength(500);
            builder.Property(m => m.KayitBy).HasMaxLength(20);
            builder.Property(m => m.KayitDate).HasColumnType("datetime");
            builder.Property(m => m.DegisBy).HasMaxLength(20);
            builder.Property(m => m.DegisDate).HasColumnType("datetime");

            builder.ToTable("OrderDetails");
        }
    }
}
