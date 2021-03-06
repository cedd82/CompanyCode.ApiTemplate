// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using CompanyCode.ApiTemplate.Repository.Postgres.Entities;

using Microsoft.EntityFrameworkCore;

namespace CompanyCode.ApiTemplate.Repository.Postgres
{
    public partial class PostgresDbContext : DbContext
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public PostgresDbContext(DbContextOptions<PostgresDbContext> options)
            : base(options)
        { }

        public virtual DbSet<ProcessEventData> ProcessEventData { get; set; }
        public virtual DbSet<SysLog> SysLog { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SysLog>(entity =>
            {
                entity.Property(e => e.LogDate).HasDefaultValueSql("now()");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
    
}