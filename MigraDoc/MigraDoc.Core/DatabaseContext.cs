using Microsoft.EntityFrameworkCore;
using MigraDoc.Core.Models;
using MigraDoc.Core.Models.FullData;

namespace MigraDoc.Core
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
            Database.EnsureCreated();
        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=157.230.97.233;Port=6606;Database=MigraDoc;Uid=pro;Pwd=rsE>9S^2Fu:kNVc:");
            }
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<isChange> isChanges { get; set; }
        public DbSet<Change> Changes { get; set; }
        public DbSet<FullName> FullNames { get; set; }
        public DbSet<Passport> Passports { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<EducationInfo> EducationInfos { get; set; }
        public DbSet<Kinsfolk> Kinsfolks { get; set; }
        public DbSet<MigrationCard> MigrationCards { get; set; }
        public DbSet<RusLangDocument> RusLangDocuments { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<WorkFromWho> WorkFromWhos { get; set; }
        public DbSet<MigrationReg> MigrationRegs { get; set; }
        public DbSet<AddressDuringWork> AddressDuringWorks { get; set; }
        public DbSet<Work> Works { get; set; }

    }
}
