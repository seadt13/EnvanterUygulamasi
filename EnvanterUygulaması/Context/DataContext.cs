using EnvanterUygulaması.Models;
using Microsoft.EntityFrameworkCore;

namespace EnvanterUygulaması.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<YazilimMarkalari> YazilimMarkalari { get; set; }
        public DbSet<Yazilimlar> Yazilimlar { get; set; }
        public DbSet<Donanimlar> Donanimlar { get; set; }
        public DbSet<DonanimMarkalari> DonanimMarkalari { get; set; }
        public DbSet<UstModeller> UstModeller { get; set; }
        public DbSet<AltModeller> AltModeller { get; set; }
        public DbSet<Bulutlar> Bulutlar { get; set; }
        public DbSet<Devreler> Devreler { get; set; }
        public DbSet<Kullanicilar> Kullanicilar { get; set; }
        public DbSet<Roller> Roller { get; set; }
        public DbSet<KullaniciRolleri> KullaniciRolleri { get; set; }
        public DbSet<Bildirimler> Bildirimler { get; set; }
        public DbSet<DonanimTurleri> DonanimTurleri { get; set; }
        public DbSet<DonanimAltTurleri> DonanimAltTurleri { get; set; }
        public DbSet<loglar> Loglar { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Yazilimlar>()
                .HasOne(y => y.yazilimMarkalari)
                .WithOne(ym => ym.yazilimlar)
                .HasForeignKey<Yazilimlar>(y => y.YazilimMarkaID);

            modelBuilder.Entity<Donanimlar>()
                .HasOne(d => d.donanimMarkalari)
                .WithOne(dm => dm.donanimlar)
                .HasForeignKey<Donanimlar>(d => d.DonanimMarkaID);

            modelBuilder.Entity<Donanimlar>()
                .HasOne(d => d.ustModeller)
                .WithOne(um => um.donanimlar)
                .HasForeignKey<Donanimlar>(d => d.UstModelID);

            modelBuilder.Entity<Donanimlar>()
                 .HasOne(d => d.altModeller)
                 .WithOne(am => am.donanimlar)
                 .HasForeignKey<Donanimlar>(d => d.AltModelID)
                 .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<UstModeller>()
               .HasMany(um => um.altModeller)
               .WithOne(am => am.ustModeller)
               .HasForeignKey(am => am.UstModelID);

            modelBuilder.Entity<Devreler>()
                .HasOne(de => de.bulutlar)
                .WithOne(b => b.devreler)
                .HasForeignKey<Devreler>(de => de.BulutID);

            modelBuilder.Entity<KullaniciRolleri>()
                .HasKey(kr => new { kr.KullaniciID, kr.RolID });

            modelBuilder.Entity<KullaniciRolleri>()
                .HasOne(kr => kr.kullanicilar)
                .WithMany(k => k.kullaniciRolleri)
                .HasForeignKey(kr => kr.KullaniciID);

            modelBuilder.Entity<KullaniciRolleri>()
                .HasOne(kr => kr.roller)
                .WithMany(r => r.kullaniciRolleri)
                .HasForeignKey(kr => kr.RolID);

            modelBuilder.Entity<Donanimlar>()
                .HasOne(d => d.donanimTurleri)
                .WithOne(dt => dt.donanimlar)
                .HasForeignKey<Donanimlar>(d => d.DonanimTuruID);

            modelBuilder.Entity<Donanimlar>()
                .HasOne(d => d.donanimAltTurleri)
                .WithOne(dat => dat.donanimlar)
                .HasForeignKey<Donanimlar>(d => d.DonanimAltTuruID);

            modelBuilder.Entity<Donanimlar>()
                .HasOne(d => d.kullanicilar)
                .WithOne(k => k.donanimlar)
                .HasForeignKey<Donanimlar>(d => d.EkleyenID);

            modelBuilder.Entity<DonanimAltTurleri>()
                .HasOne(dat => dat.donanimTurleri)
                .WithMany(dt => dt.donanimAltTurleri)
                .HasForeignKey(dat => dat.DonanimTuruID);


            modelBuilder.Entity<Yazilimlar>()
                .HasOne(y => y.kullanicilar)
                .WithOne(k => k.yazilimlar)
                .HasForeignKey<Yazilimlar>(y => y.EkleyenID);

            modelBuilder.Entity<Devreler>()
                .HasOne(de => de.kullanicilar)
                .WithOne(k => k.devreler)
                .HasForeignKey<Devreler>(de => de.EkleyenID);

            base.OnModelCreating(modelBuilder);
        }
    }

}
