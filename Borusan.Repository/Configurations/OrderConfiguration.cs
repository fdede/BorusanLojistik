using Borusan.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Borusan.Repository.Configurations
{
    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CustomerOrderNo).IsRequired().HasMaxLength(100);
            builder.Property(x => x.FromAddress).IsRequired();
            builder.Property(x => x.ToAddress).IsRequired();
            builder.Property(x => x.Amount).IsRequired();
            builder.Property(x => x.AmountTypeId).IsRequired();
            builder.Property(x => x.Weight).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(x => x.WeightUnitId).IsRequired();
            builder.Property(x => x.MaterialId).IsRequired();
        }
    }
}
