﻿// <auto-generated />
using System;
using EnvanterUygulaması.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EnvanterUygulaması.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230823121453_TableUpdate5")]
    partial class TableUpdate5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EnvanterUygulaması.Models.AltModeller", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Durumu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UstModelID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("UstModelID");

                    b.ToTable("AltModeller");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.Bildirimler", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OkunduMu")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("Bildirimler");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.Bulutlar", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnaDevreNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Bulutlar");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.Devreler", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bolge")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BulutID")
                        .HasColumnType("int");

                    b.Property<bool>("Durumu")
                        .HasColumnType("bit");

                    b.Property<int>("EkleyenID")
                        .HasColumnType("int");

                    b.Property<string>("IpBlogu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Koordinat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Mahsup")
                        .HasColumnType("bit");

                    b.Property<int>("No")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("BulutID")
                        .IsUnique();

                    b.HasIndex("EkleyenID")
                        .IsUnique();

                    b.ToTable("Devreler");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.DonanimAltTurleri", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DonanimTuruID")
                        .HasColumnType("int");

                    b.Property<string>("Durumu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("DonanimTuruID");

                    b.ToTable("DonanimAltTurleri");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.DonanimMarkalari", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Durumu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("DonanimMarkalari");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.DonanimTurleri", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Durumu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("DonanimTurleri");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.Donanimlar", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Adedi")
                        .HasColumnType("int");

                    b.Property<DateTime>("AlimTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("AltModelID")
                        .HasColumnType("int");

                    b.Property<int?>("BaglantiHizi")
                        .HasColumnType("int");

                    b.Property<string>("Birim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DonanimAltTuruID")
                        .HasColumnType("int");

                    b.Property<int>("DonanimMarkaID")
                        .HasColumnType("int");

                    b.Property<int>("DonanimTuruID")
                        .HasColumnType("int");

                    b.Property<string>("Durumu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EkleyenID")
                        .HasColumnType("int");

                    b.Property<int>("GarantiSuresi")
                        .HasColumnType("int");

                    b.Property<string>("MacAdresi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Poe")
                        .HasColumnType("bit");

                    b.Property<string>("SeriNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UstModelID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("AltModelID")
                        .IsUnique();

                    b.HasIndex("DonanimAltTuruID")
                        .IsUnique();

                    b.HasIndex("DonanimMarkaID")
                        .IsUnique();

                    b.HasIndex("DonanimTuruID")
                        .IsUnique();

                    b.HasIndex("EkleyenID")
                        .IsUnique();

                    b.HasIndex("UstModelID")
                        .IsUnique();

                    b.ToTable("Donanimlar");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.KullaniciRolleri", b =>
                {
                    b.Property<int>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<int>("RolID")
                        .HasColumnType("int");

                    b.HasKey("KullaniciID", "RolID");

                    b.HasIndex("RolID");

                    b.ToTable("KullaniciRolleri");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.Kullanicilar", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifresi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Kullanicilar");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.Roller", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Yetkisi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Roller");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.UstModeller", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Durumu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("UstModeller");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.YazilimMarkalari", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Durumu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("YazilimMarkalari");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.Yazilimlar", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AlimTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CihazSayisi")
                        .HasColumnType("int");

                    b.Property<int>("DestekSuresi")
                        .HasColumnType("int");

                    b.Property<int>("EkleyenID")
                        .HasColumnType("int");

                    b.Property<string>("Turu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Versiyon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YazilimMarkaID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("EkleyenID")
                        .IsUnique();

                    b.HasIndex("YazilimMarkaID")
                        .IsUnique();

                    b.ToTable("Yazilimlar");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.loglar", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Tarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("Loglar");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.AltModeller", b =>
                {
                    b.HasOne("EnvanterUygulaması.Models.UstModeller", "ustModeller")
                        .WithMany("altModeller")
                        .HasForeignKey("UstModelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ustModeller");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.Devreler", b =>
                {
                    b.HasOne("EnvanterUygulaması.Models.Bulutlar", "bulutlar")
                        .WithOne("devreler")
                        .HasForeignKey("EnvanterUygulaması.Models.Devreler", "BulutID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnvanterUygulaması.Models.Kullanicilar", "kullanicilar")
                        .WithOne("devreler")
                        .HasForeignKey("EnvanterUygulaması.Models.Devreler", "EkleyenID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("bulutlar");

                    b.Navigation("kullanicilar");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.DonanimAltTurleri", b =>
                {
                    b.HasOne("EnvanterUygulaması.Models.DonanimTurleri", "donanimTurleri")
                        .WithMany("donanimAltTurleri")
                        .HasForeignKey("DonanimTuruID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("donanimTurleri");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.Donanimlar", b =>
                {
                    b.HasOne("EnvanterUygulaması.Models.AltModeller", "altModeller")
                        .WithOne("donanimlar")
                        .HasForeignKey("EnvanterUygulaması.Models.Donanimlar", "AltModelID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("EnvanterUygulaması.Models.DonanimAltTurleri", "donanimAltTurleri")
                        .WithOne("donanimlar")
                        .HasForeignKey("EnvanterUygulaması.Models.Donanimlar", "DonanimAltTuruID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnvanterUygulaması.Models.DonanimMarkalari", "donanimMarkalari")
                        .WithOne("donanimlar")
                        .HasForeignKey("EnvanterUygulaması.Models.Donanimlar", "DonanimMarkaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnvanterUygulaması.Models.DonanimTurleri", "donanimTurleri")
                        .WithOne("donanimlar")
                        .HasForeignKey("EnvanterUygulaması.Models.Donanimlar", "DonanimTuruID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnvanterUygulaması.Models.Kullanicilar", "kullanicilar")
                        .WithOne("donanimlar")
                        .HasForeignKey("EnvanterUygulaması.Models.Donanimlar", "EkleyenID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnvanterUygulaması.Models.UstModeller", "ustModeller")
                        .WithOne("donanimlar")
                        .HasForeignKey("EnvanterUygulaması.Models.Donanimlar", "UstModelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("altModeller");

                    b.Navigation("donanimAltTurleri");

                    b.Navigation("donanimMarkalari");

                    b.Navigation("donanimTurleri");

                    b.Navigation("kullanicilar");

                    b.Navigation("ustModeller");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.KullaniciRolleri", b =>
                {
                    b.HasOne("EnvanterUygulaması.Models.Kullanicilar", "kullanicilar")
                        .WithMany("kullaniciRolleri")
                        .HasForeignKey("KullaniciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnvanterUygulaması.Models.Roller", "roller")
                        .WithMany("kullaniciRolleri")
                        .HasForeignKey("RolID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("kullanicilar");

                    b.Navigation("roller");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.Yazilimlar", b =>
                {
                    b.HasOne("EnvanterUygulaması.Models.Kullanicilar", "kullanicilar")
                        .WithOne("yazilimlar")
                        .HasForeignKey("EnvanterUygulaması.Models.Yazilimlar", "EkleyenID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnvanterUygulaması.Models.YazilimMarkalari", "yazilimMarkalari")
                        .WithOne("yazilimlar")
                        .HasForeignKey("EnvanterUygulaması.Models.Yazilimlar", "YazilimMarkaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("kullanicilar");

                    b.Navigation("yazilimMarkalari");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.AltModeller", b =>
                {
                    b.Navigation("donanimlar")
                        .IsRequired();
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.Bulutlar", b =>
                {
                    b.Navigation("devreler")
                        .IsRequired();
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.DonanimAltTurleri", b =>
                {
                    b.Navigation("donanimlar")
                        .IsRequired();
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.DonanimMarkalari", b =>
                {
                    b.Navigation("donanimlar")
                        .IsRequired();
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.DonanimTurleri", b =>
                {
                    b.Navigation("donanimAltTurleri");

                    b.Navigation("donanimlar")
                        .IsRequired();
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.Kullanicilar", b =>
                {
                    b.Navigation("devreler")
                        .IsRequired();

                    b.Navigation("donanimlar")
                        .IsRequired();

                    b.Navigation("kullaniciRolleri");

                    b.Navigation("yazilimlar")
                        .IsRequired();
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.Roller", b =>
                {
                    b.Navigation("kullaniciRolleri");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.UstModeller", b =>
                {
                    b.Navigation("altModeller");

                    b.Navigation("donanimlar")
                        .IsRequired();
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.YazilimMarkalari", b =>
                {
                    b.Navigation("yazilimlar")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
