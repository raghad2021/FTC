using FTC.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FTC.Data
{
    public class FtcDbContext : IdentityDbContext
    {
        public FtcDbContext(DbContextOptions<FtcDbContext> options)
            : base(options)
        {
        }
        public DbSet<InformationDbEntity> Information { get; set; }
        public DbSet<SectionDbEntity> sections { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<InformationDbEntity>();
            builder.Entity<SectionDbEntity>();
            builder.Entity<BaseDbEntity>().HasQueryFilter(x => !x.IsDelete);
        }
    }
}
