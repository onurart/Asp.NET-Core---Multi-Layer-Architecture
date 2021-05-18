﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NLayerProject.Data;

namespace NLayerProject.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200528082929_AddBranches")]
    partial class AddBranches
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NLayerProject.Core.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Meyve"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "Kırtasiye"
                        });
                });

            modelBuilder.Entity("NLayerProject.Core.Model.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Adres2")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Bolge")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("DegisBy")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("DegisDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FaturaCariHesapKodu")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("FaturaCariId")
                        .HasColumnName("FaturaCariID")
                        .HasColumnType("int");

                    b.Property<string>("FaturaCariUnvan")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("Firma")
                        .HasColumnType("int");

                    b.Property<string>("HesapKodu")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("HesapTipi")
                        .HasColumnType("int");

                    b.Property<int>("HesapTuru")
                        .HasColumnType("int");

                    b.Property<bool>("IsPasif")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("KayitBy")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("KayitDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int>("OdemeGun")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("PostaKodu")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Sehir")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("SehirAdi")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Semt")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.Property<int>("Sirket")
                        .HasColumnType("int");

                    b.Property<string>("SubeAdi")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("SubeKodu")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("TCNo")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Tel1")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Tel2")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Ulke")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Unvan")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("VadeGun")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("VergiDairesi")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("VergiNo")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Yetkili")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("YetkiliEmail")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("YetkiliTel1")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("YetkiliTel2")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("NLayerProject.Core.Model.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("Aciklama2")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Aciklama3")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("AliciFaturaAdresId")
                        .HasColumnName("AliciFaturaAdresID")
                        .HasColumnType("int");

                    b.Property<string>("AliciFaturaAdresUnvan")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("AliciId")
                        .HasColumnName("AliciID")
                        .HasColumnType("int");

                    b.Property<int>("AliciTeslimAdresId")
                        .HasColumnName("AliciTeslimAdresID")
                        .HasColumnType("int");

                    b.Property<string>("AliciTeslimAdresUnvan")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("AliciTeslimSehir")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("AliciTeslimSehirAdi")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("AliciTeslimSube")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("AliciTeslimSubeAdi")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("AliciUnvan")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("AltProjeId")
                        .HasColumnType("int");

                    b.Property<string>("DegisBy")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("DegisDate")
                        .HasColumnType("datetime");

                    b.Property<int>("EvrakTipi")
                        .HasColumnType("int");

                    b.Property<int>("FaturaTip")
                        .HasColumnType("int");

                    b.Property<int>("Firma")
                        .HasColumnType("int");

                    b.Property<int>("FiyatTipi")
                        .HasColumnType("int");

                    b.Property<int>("GonderenFaturaAdresId")
                        .HasColumnName("GonderenFaturaAdresID")
                        .HasColumnType("int");

                    b.Property<string>("GonderenFaturaAdresUnvan")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("GonderenId")
                        .HasColumnName("GonderenID")
                        .HasColumnType("int");

                    b.Property<string>("GonderenUnvan")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("Iptal")
                        .HasColumnType("bit");

                    b.Property<string>("KayitBy")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("KayitDate")
                        .HasColumnType("datetime");

                    b.Property<int>("KayitTipi")
                        .HasColumnType("int");

                    b.Property<int>("NakliyeHesapFaturaId")
                        .HasColumnName("NakliyeHesapFaturaID")
                        .HasColumnType("int");

                    b.Property<string>("NakliyeHesapFaturaUnvan")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("NakliyeHesapId")
                        .HasColumnName("NakliyeHesapID")
                        .HasColumnType("int");

                    b.Property<string>("NakliyeHesapUnvan")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("OdemeSekli")
                        .HasColumnType("int");

                    b.Property<int>("OdmeTuru")
                        .HasColumnType("int");

                    b.Property<int>("ProjeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Saat")
                        .HasColumnType("datetime");

                    b.Property<string>("Seri")
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.Property<string>("SeriNo")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.Property<string>("SilmeNedeni")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("SiparisBagId")
                        .HasColumnName("SiparisBagID")
                        .HasColumnType("int");

                    b.Property<int>("Sirket")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("smalldatetime");

                    b.Property<DateTime>("Termin")
                        .HasColumnType("datetime");

                    b.Property<int>("TeslimTipi")
                        .HasColumnType("int");

                    b.Property<int>("Tip")
                        .HasColumnType("int");

                    b.Property<int>("Tur")
                        .HasColumnType("int");

                    b.Property<string>("YuklemeAdresFaturaUnvan")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("YuklemeAdresId")
                        .HasColumnName("YuklemeAdresID")
                        .HasColumnType("int");

                    b.Property<int>("YuklemeHesapId")
                        .HasColumnName("YuklemeHesapID")
                        .HasColumnType("int");

                    b.Property<string>("YuklemeHesapUnvan")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("YuklemeSehir")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("YuklemeSehirAdi")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("YuklemeSube")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("YuklemeSubeAdi")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("NLayerProject.Core.Model.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Aciklama2")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Birim")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Birim2")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Birim3")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<decimal>("BirimDesi")
                        .HasColumnType("decimal (18,6)");

                    b.Property<decimal>("BirimKg")
                        .HasColumnType("decimal (18,6)");

                    b.Property<decimal>("BirimM3")
                        .HasColumnType("decimal (18,6)");

                    b.Property<decimal>("BrutTutar")
                        .HasColumnType("decimal (18,6)");

                    b.Property<string>("DagitimIrsNo")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("DegisBy")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("DegisDate")
                        .HasColumnType("datetime");

                    b.Property<decimal>("Desi")
                        .HasColumnType("decimal (18,6)");

                    b.Property<int>("Durum")
                        .HasColumnType("int");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal (18,6)");

                    b.Property<string>("HesapBirim")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("KayitBy")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("KayitDate")
                        .HasColumnType("datetime");

                    b.Property<decimal>("Kdv")
                        .HasColumnType("decimal (18,6)");

                    b.Property<decimal>("KdvOran")
                        .HasColumnType("decimal (18,6)");

                    b.Property<decimal>("Kg")
                        .HasColumnType("decimal (18,6)");

                    b.Property<decimal>("M3")
                        .HasColumnType("decimal (18,6)");

                    b.Property<decimal>("Masraf")
                        .HasColumnType("decimal (18,6)");

                    b.Property<decimal>("MasrafNakliye")
                        .HasColumnType("decimal (18,6)");

                    b.Property<decimal>("Miktar")
                        .HasColumnType("decimal (18,6)");

                    b.Property<decimal>("Miktar2")
                        .HasColumnType("decimal (18,6)");

                    b.Property<decimal>("Miktar3")
                        .HasColumnType("decimal (18,6)");

                    b.Property<string>("MusteriIrsNo")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<int>("OrderId")
                        .HasColumnName("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("Sira")
                        .HasColumnType("int");

                    b.Property<string>("StokAdi")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("StokId")
                        .HasColumnName("StokID")
                        .HasColumnType("int")
                        .HasMaxLength(40);

                    b.Property<string>("StokKodu")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<decimal>("Toplam")
                        .HasColumnType("decimal (18,6)");

                    b.Property<decimal>("Tutar")
                        .HasColumnType("decimal (18,6)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("NLayerProject.Core.Model.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("NLayerProject.Core.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("InnerBarcode")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal (18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            IsDeleted = false,
                            Name = "Elma",
                            Price = 5.5m,
                            Stock = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            IsDeleted = false,
                            Name = "Armut",
                            Price = 6.0m,
                            Stock = 95
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            IsDeleted = false,
                            Name = "Muz",
                            Price = 14.50m,
                            Stock = 300
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            IsDeleted = false,
                            Name = "Kitap",
                            Price = 30.0m,
                            Stock = 120
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            IsDeleted = false,
                            Name = "Defter",
                            Price = 12.30m,
                            Stock = 150
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            IsDeleted = false,
                            Name = "Kalem",
                            Price = 7.50m,
                            Stock = 400
                        });
                });

            modelBuilder.Entity("NLayerProject.Core.Models.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Kod")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("NLayerProject.Core.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bolge")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("BolgeAdi")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Ilce")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("IlceAdi")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Kod")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Sehir")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("SehirAdi")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Tanim")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("Tip")
                        .HasColumnType("int");

                    b.Property<string>("Ulke")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("UlkeAdi")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("NLayerProject.Core.Model.OrderDetail", b =>
                {
                    b.HasOne("NLayerProject.Core.Model.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NLayerProject.Core.Model.Product", b =>
                {
                    b.HasOne("NLayerProject.Core.Model.Category", "Category")
                        .WithMany("Product")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
