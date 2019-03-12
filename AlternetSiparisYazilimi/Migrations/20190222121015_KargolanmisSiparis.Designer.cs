﻿// <auto-generated />
using AlternetSiparisYazilimi.Models.VeritabaniSebatKatmani;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AlternetSiparisYazilimi.Migrations
{
    [DbContext(typeof(AlternetSiparisDbContext))]
    [Migration("20190222121015_KargolanmisSiparis")]
    partial class KargolanmisSiparis
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlternetSiparisYazilimi.Models.SepetSatiri", b =>
                {
                    b.Property<int>("SatirID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Adet");

                    b.Property<int?>("SiparisID");

                    b.Property<int?>("UrunID");

                    b.HasKey("SatirID");

                    b.HasIndex("SiparisID");

                    b.HasIndex("UrunID");

                    b.ToTable("SepetSatiri");
                });

            modelBuilder.Entity("AlternetSiparisYazilimi.Models.Siparis", b =>
                {
                    b.Property<int>("SiparisID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdresSatiri1")
                        .IsRequired();

                    b.Property<string>("AdresSatiri2");

                    b.Property<string>("AdresSatiri3");

                    b.Property<string>("Alici")
                        .IsRequired();

                    b.Property<bool>("Kargolandi");

                    b.Property<string>("PostaKodu");

                    b.Property<string>("Sehir")
                        .IsRequired();

                    b.Property<string>("Ulke")
                        .IsRequired();

                    b.HasKey("SiparisID");

                    b.ToTable("Siparisler");
                });

            modelBuilder.Entity("AlternetSiparisYazilimi.Models.Urun", b =>
                {
                    b.Property<int>("UrunID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Aciklama");

                    b.Property<decimal>("Fiyat");

                    b.Property<string>("Isim");

                    b.Property<string>("Kategorisi");

                    b.Property<byte[]>("UrunResmi");

                    b.HasKey("UrunID");

                    b.ToTable("Urunler");
                });

            modelBuilder.Entity("AlternetSiparisYazilimi.Models.SepetSatiri", b =>
                {
                    b.HasOne("AlternetSiparisYazilimi.Models.Siparis")
                        .WithMany("SepetSatirlari")
                        .HasForeignKey("SiparisID");

                    b.HasOne("AlternetSiparisYazilimi.Models.Urun", "Urun")
                        .WithMany()
                        .HasForeignKey("UrunID");
                });
#pragma warning restore 612, 618
        }
    }
}