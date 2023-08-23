﻿// <auto-generated />
using EnvanterUygulaması.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnvanterUygulaması.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230814121159_TableUpdate3")]
    partial class TableUpdate3
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

                    b.Property<int>("DonanimAltTuruID")
                        .HasColumnType("int");

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

                    b.Property<string>("AltBasligi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AltModelID")
                        .HasColumnType("int");

                    b.Property<int?>("BaglantiHizi")
                        .HasColumnType("int");

                    b.Property<string>("Birim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DonanimAltTuruid")
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

                    b.HasIndex("DonanimAltTuruid");

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
                    b.HasOne("EnvanterUygulaması.Models.UstModeller", "UstModel")
                        .WithMany("AltModel")
                        .HasForeignKey("UstModelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UstModel");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.Devreler", b =>
                {
                    b.HasOne("EnvanterUygulaması.Models.Bulutlar", "Bulut")
                        .WithOne("Devre")
                        .HasForeignKey("EnvanterUygulaması.Models.Devreler", "BulutID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnvanterUygulaması.Models.Kullanicilar", "Kullanici")
                        .WithOne("Devre")
                        .HasForeignKey("EnvanterUygulaması.Models.Devreler", "EkleyenID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bulut");

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.DonanimAltTurleri", b =>
                {
                    b.HasOne("EnvanterUygulaması.Models.DonanimTurleri", "DonanimTuru")
                        .WithMany("DonanimAltTuru")
                        .HasForeignKey("DonanimTuruID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("DonanimTuru");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.Donanimlar", b =>
                {
                    b.HasOne("EnvanterUygulaması.Models.DonanimAltTurleri", "DonanimAltTuru")
                        .WithMany()
                        .HasForeignKey("DonanimAltTuruid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnvanterUygulaması.Models.DonanimMarkalari", "DonanimMarka")
                        .WithOne("Donanim")
                        .HasForeignKey("EnvanterUygulaması.Models.Donanimlar", "DonanimMarkaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnvanterUygulaması.Models.DonanimTurleri", "DonanimTuru")
                        .WithOne("Donanim")
                        .HasForeignKey("EnvanterUygulaması.Models.Donanimlar", "DonanimTuruID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnvanterUygulaması.Models.Kullanicilar", "Kullanici")
                        .WithOne("Donanim")
                        .HasForeignKey("EnvanterUygulaması.Models.Donanimlar", "EkleyenID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnvanterUygulaması.Models.UstModeller", "UstModel")
                        .WithOne("Donanim")
                        .HasForeignKey("EnvanterUygulaması.Models.Donanimlar", "UstModelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DonanimAltTuru");

                    b.Navigation("DonanimMarka");

                    b.Navigation("DonanimTuru");

                    b.Navigation("Kullanici");

                    b.Navigation("UstModel");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.KullaniciRolleri", b =>
                {
                    b.HasOne("EnvanterUygulaması.Models.Kullanicilar", "Kullanici")
                        .WithMany("KullaniciRol")
                        .HasForeignKey("KullaniciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnvanterUygulaması.Models.Roller", "Rol")
                        .WithMany("KullaniciRol")
                        .HasForeignKey("RolID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.Yazilimlar", b =>
                {
                    b.HasOne("EnvanterUygulaması.Models.Kullanicilar", "Kullanici")
                        .WithOne("Yazilim")
                        .HasForeignKey("EnvanterUygulaması.Models.Yazilimlar", "EkleyenID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnvanterUygulaması.Models.YazilimMarkalari", "YazilimMarka")
                        .WithOne("Yazilim")
                        .HasForeignKey("EnvanterUygulaması.Models.Yazilimlar", "YazilimMarkaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");

                    b.Navigation("YazilimMarka");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.Bulutlar", b =>
                {
                    b.Navigation("Devre")
                        .IsRequired();
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.DonanimMarkalari", b =>
                {
                    b.Navigation("Donanim")
                        .IsRequired();
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.DonanimTurleri", b =>
                {
                    b.Navigation("Donanim")
                        .IsRequired();

                    b.Navigation("DonanimAltTuru");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.Kullanicilar", b =>
                {
                    b.Navigation("Devre")
                        .IsRequired();

                    b.Navigation("Donanim")
                        .IsRequired();

                    b.Navigation("KullaniciRol");

                    b.Navigation("Yazilim")
                        .IsRequired();
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.Roller", b =>
                {
                    b.Navigation("KullaniciRol");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.UstModeller", b =>
                {
                    b.Navigation("AltModel");

                    b.Navigation("Donanim")
                        .IsRequired();
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.YazilimMarkalari", b =>
                {
                    b.Navigation("Yazilim")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
