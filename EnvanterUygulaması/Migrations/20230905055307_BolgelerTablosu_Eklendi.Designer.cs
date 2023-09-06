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
    [Migration("20230905055307_BolgelerTablosu_Eklendi")]
    partial class BolgelerTablosu_Eklendi
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

            modelBuilder.Entity("EnvanterUygulaması.Models.Bolgeler", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Bolgeler");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.Bulutlar", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("int");

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

                    b.Property<int>("BolgeId")
                        .HasColumnType("int");

                    b.Property<int>("BulutID")
                        .HasColumnType("int");

                    b.Property<string>("Durumu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.HasIndex("BolgeId");

                    b.HasIndex("BulutID");

                    b.HasIndex("EkleyenID");

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

            modelBuilder.Entity("EnvanterUygulaması.Models.DonanimMarkaTurleri", b =>
                {
                    b.Property<int>("MarkaId")
                        .HasColumnType("int");

                    b.Property<int>("TurId")
                        .HasColumnType("int");

                    b.HasKey("MarkaId", "TurId");

                    b.HasIndex("TurId");

                    b.ToTable("DonanimMarkaTurleri");
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

                    b.Property<int>("TurID")
                        .HasColumnType("int");

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

                    b.Property<DateTime>("AlimTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("AltModelID")
                        .HasColumnType("int");

                    b.Property<int?>("BaglantiHizi")
                        .HasColumnType("int");

                    b.Property<int>("BolgeId")
                        .HasColumnType("int");

                    b.Property<int?>("DonanimAltTuruID")
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

                    b.Property<string>("Gucu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MacAdresi")
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

                    b.HasIndex("AltModelID");

                    b.HasIndex("BolgeId");

                    b.HasIndex("DonanimAltTuruID");

                    b.HasIndex("DonanimMarkaID");

                    b.HasIndex("DonanimTuruID");

                    b.HasIndex("EkleyenID");

                    b.HasIndex("UstModelID");

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

                    b.Property<int>("DonanimMarkaId")
                        .HasColumnType("int");

                    b.Property<string>("Durumu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("DonanimMarkaId");

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

                    b.Property<int>("BolgeId")
                        .HasColumnType("int");

                    b.Property<int>("CihazSayisi")
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

                    b.HasIndex("BolgeId");

                    b.HasIndex("EkleyenID");

                    b.HasIndex("YazilimMarkaID");

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
                    b.HasOne("EnvanterUygulaması.Models.Bolgeler", "bolgeler")
                        .WithMany("devreler")
                        .HasForeignKey("BolgeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnvanterUygulaması.Models.Bulutlar", "bulutlar")
                        .WithMany("devreler")
                        .HasForeignKey("BulutID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnvanterUygulaması.Models.Kullanicilar", "kullanicilar")
                        .WithMany("devreler")
                        .HasForeignKey("EkleyenID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("bolgeler");

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

            modelBuilder.Entity("EnvanterUygulaması.Models.DonanimMarkaTurleri", b =>
                {
                    b.HasOne("EnvanterUygulaması.Models.DonanimMarkalari", "donanimMarkalari")
                        .WithMany("donanimMarkaTurleri")
                        .HasForeignKey("MarkaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnvanterUygulaması.Models.DonanimTurleri", "donanimTurleri")
                        .WithMany("donanimMarkaTurleri")
                        .HasForeignKey("TurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("donanimMarkalari");

                    b.Navigation("donanimTurleri");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.Donanimlar", b =>
                {
                    b.HasOne("EnvanterUygulaması.Models.AltModeller", "altModeller")
                        .WithMany("donanimlar")
                        .HasForeignKey("AltModelID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EnvanterUygulaması.Models.Bolgeler", "bolgeler")
                        .WithMany("donanimlar")
                        .HasForeignKey("BolgeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnvanterUygulaması.Models.DonanimAltTurleri", "donanimAltTurleri")
                        .WithMany("donanimlar")
                        .HasForeignKey("DonanimAltTuruID");

                    b.HasOne("EnvanterUygulaması.Models.DonanimMarkalari", "donanimMarkalari")
                        .WithMany("donanimlar")
                        .HasForeignKey("DonanimMarkaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnvanterUygulaması.Models.DonanimTurleri", "donanimTurleri")
                        .WithMany("donanimlar")
                        .HasForeignKey("DonanimTuruID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnvanterUygulaması.Models.Kullanicilar", "kullanicilar")
                        .WithMany("donanimlar")
                        .HasForeignKey("EkleyenID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnvanterUygulaması.Models.UstModeller", "ustModeller")
                        .WithMany("donanimlar")
                        .HasForeignKey("UstModelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("altModeller");

                    b.Navigation("bolgeler");

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

            modelBuilder.Entity("EnvanterUygulaması.Models.UstModeller", b =>
                {
                    b.HasOne("EnvanterUygulaması.Models.DonanimMarkalari", "donanimMarkalari")
                        .WithMany("ustModeller")
                        .HasForeignKey("DonanimMarkaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("donanimMarkalari");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.Yazilimlar", b =>
                {
                    b.HasOne("EnvanterUygulaması.Models.Bolgeler", "bolgeler")
                        .WithMany("yazilimlar")
                        .HasForeignKey("BolgeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnvanterUygulaması.Models.Kullanicilar", "kullanicilar")
                        .WithMany("yazilimlar")
                        .HasForeignKey("EkleyenID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnvanterUygulaması.Models.YazilimMarkalari", "yazilimMarkalari")
                        .WithMany("yazilimlar")
                        .HasForeignKey("YazilimMarkaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("bolgeler");

                    b.Navigation("kullanicilar");

                    b.Navigation("yazilimMarkalari");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.AltModeller", b =>
                {
                    b.Navigation("donanimlar");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.Bolgeler", b =>
                {
                    b.Navigation("devreler");

                    b.Navigation("donanimlar");

                    b.Navigation("yazilimlar");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.Bulutlar", b =>
                {
                    b.Navigation("devreler");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.DonanimAltTurleri", b =>
                {
                    b.Navigation("donanimlar");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.DonanimMarkalari", b =>
                {
                    b.Navigation("donanimMarkaTurleri");

                    b.Navigation("donanimlar");

                    b.Navigation("ustModeller");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.DonanimTurleri", b =>
                {
                    b.Navigation("donanimAltTurleri");

                    b.Navigation("donanimMarkaTurleri");

                    b.Navigation("donanimlar");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.Kullanicilar", b =>
                {
                    b.Navigation("devreler");

                    b.Navigation("donanimlar");

                    b.Navigation("kullaniciRolleri");

                    b.Navigation("yazilimlar");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.Roller", b =>
                {
                    b.Navigation("kullaniciRolleri");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.UstModeller", b =>
                {
                    b.Navigation("altModeller");

                    b.Navigation("donanimlar");
                });

            modelBuilder.Entity("EnvanterUygulaması.Models.YazilimMarkalari", b =>
                {
                    b.Navigation("yazilimlar");
                });
#pragma warning restore 612, 618
        }
    }
}
