using Borusan.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Borusan.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Material> Materials { get; set; }
        public DbSet<WeightUnit> WeightUnits { get; set; }
        public DbSet<AmountType> AmountTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

    }
}
