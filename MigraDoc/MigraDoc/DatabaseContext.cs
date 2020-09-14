using Microsoft.EntityFrameworkCore;
using MigraDoc.Core.Entities;

namespace MigraDoc.WebAPI
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

        public DbSet<AddressEntity> Addresses { get; set; }
        public DbSet<EducationEntity> Educations { get; set; }
        public DbSet<EducationLevelEntity> EducationLevels { get; set; }
        public DbSet<FamilyStatusEntity> FamilyStatuses { get; set; }
        public DbSet<IdentityDocumentEntity> IdentityDocuments { get; set; }
        public DbSet<IncomeListEntity> IncomeLists { get; set; }
        public DbSet<IncomeEntity> Incomes { get; set; }
        public DbSet<NameChangesEntity> NameChanges { get; set; }
        public DbSet<NationalityEntity> Nationalities { get; set; }
        public DbSet<RelativesEntity> Relatives { get; set; }
        public DbSet<RussianKnowledgeEntity> RussianKnowledges { get; set; }
        public DbSet<UnreleasedConvictionEntity> UnreleasedConvictions { get; set; }
        public DbSet<UserDataEntity> UserDatas { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<WorkEntity> Works { get; set; }
        public DbSet<WorkPermitEntity> WorkPermits { get; set; }
    }
}
