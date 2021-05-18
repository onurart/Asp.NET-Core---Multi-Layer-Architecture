using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerProject.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).HasColumnName("ID");
            builder.Property(m => m.SiparisBagId).HasColumnName("SiparisBagID");
            builder.Property(m => m.Tarih).HasColumnType("smalldatetime");
            builder.Property(m => m.Saat).HasColumnType("datetime");
            builder.Property(m => m.Termin).HasColumnType("datetime");
            builder.Property(m => m.Seri).HasMaxLength(5);
            builder.Property(m => m.SeriNo).HasMaxLength(20);
            builder.Property(m => m.GonderenId).HasColumnName("GonderenID");
            builder.Property(m => m.GonderenUnvan).HasMaxLength(100);
            builder.Property(m => m.GonderenFaturaAdresId).HasColumnName("GonderenFaturaAdresID");
            builder.Property(m => m.GonderenFaturaAdresUnvan).HasMaxLength(100);
            builder.Property(m => m.YuklemeHesapId).HasColumnName("YuklemeHesapID");
            builder.Property(m => m.YuklemeHesapUnvan).HasMaxLength(100);
            builder.Property(m => m.YuklemeAdresId).HasColumnName("YuklemeAdresID");
            builder.Property(m => m.YuklemeAdresFaturaUnvan).HasMaxLength(100);
            builder.Property(m => m.YuklemeSehir).HasMaxLength(20);
            builder.Property(m => m.YuklemeSehirAdi).HasMaxLength(50);
            builder.Property(m => m.YuklemeSube).HasMaxLength(20);
            builder.Property(m => m.YuklemeSubeAdi).HasMaxLength(50);
            builder.Property(m => m.AliciId).HasColumnName("AliciID");
            builder.Property(m => m.AliciUnvan).HasMaxLength(100);
            builder.Property(m => m.AliciFaturaAdresId).HasColumnName("AliciFaturaAdresID");
            builder.Property(m => m.AliciFaturaAdresUnvan).HasMaxLength(100);
            builder.Property(m => m.AliciTeslimAdresId).HasColumnName("AliciTeslimAdresID");
            builder.Property(m => m.AliciTeslimAdresUnvan).HasMaxLength(100);
            builder.Property(m => m.AliciTeslimSehir).HasMaxLength(20);
            builder.Property(m => m.AliciTeslimSehirAdi).HasMaxLength(50);
            builder.Property(m => m.AliciTeslimSube).HasMaxLength(20);
            builder.Property(m => m.AliciTeslimSubeAdi).HasMaxLength(50);
            builder.Property(m => m.NakliyeHesapId).HasColumnName("NakliyeHesapID");
            builder.Property(m => m.NakliyeHesapUnvan).HasMaxLength(100);
            builder.Property(m => m.NakliyeHesapFaturaId).HasColumnName("NakliyeHesapFaturaID");
            builder.Property(m => m.NakliyeHesapFaturaUnvan).HasMaxLength(100);
            builder.Property(m => m.Aciklama).HasMaxLength(300);
            builder.Property(m => m.Aciklama2).HasMaxLength(100);
            builder.Property(m => m.Aciklama3).HasMaxLength(100);
            builder.Property(m => m.SilmeNedeni).HasMaxLength(100);
            builder.Property(m => m.KayitBy).HasMaxLength(20);
            builder.Property(m => m.KayitDate).HasColumnType("datetime");
            builder.Property(m => m.DegisBy).HasMaxLength(20);
            builder.Property(m => m.DegisDate).HasColumnType("datetime");

            builder.ToTable("Orders");

        }
    }
}
