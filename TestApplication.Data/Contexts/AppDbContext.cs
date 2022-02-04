using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TestApplication.Domain.Entities;

namespace TestApplication.Data.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<UserEntity>? UserEntities { get; set; }
        
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
