using Microsoft.EntityFrameworkCore;
using System;
using DoctorWho.Db.DataModels;
namespace DoctorWho.Db
{
    public class DoctorWhoCoreDbContext:DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Enemy> Enemies { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Companion> Companions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-CGU4KCR;Database=DoctorWhoCore;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var seedData = new SeedData();

            modelBuilder.Entity<EpisodeCompanion>().HasKey(ec => new { ec.EpisodeId, ec.CompanionId });
            modelBuilder.Entity<EpisodeEnemy>().HasKey(ee => new { ee.EpisodeId, ee.EnemyId });
            modelBuilder.Entity<Episode>().HasOne(e => e.Author).WithMany(s => s.Episodes).HasForeignKey(e => e.AuthorId);
            modelBuilder.Entity<Episode>().HasOne(e => e.Doctor).WithMany(s => s.Episodes).HasForeignKey(e => e.DoctorId);
            modelBuilder.Entity<Author>().HasData(seedData.AuthorTableData());
            modelBuilder.Entity<Doctor>().HasData(seedData.DoctorTableData());
            modelBuilder.Entity<Enemy>().HasData(seedData.EnemyTableData());
            modelBuilder.Entity<Companion>().HasData(seedData.CompanionTableData());
            modelBuilder.Entity<Episode>().HasData(seedData.EpisodeTableData());
            modelBuilder.Entity<EpisodeEnemy>().HasData(seedData.EpisodeEnemyTableData());
            modelBuilder.Entity<EpisodeCompanion>().HasData(seedData.EpisodeCompanionTableData());
        }
    }
}
