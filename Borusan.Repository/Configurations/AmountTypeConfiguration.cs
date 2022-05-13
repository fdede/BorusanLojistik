using Borusan.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Borusan.Repository.Configurations
{
    internal class AmountTypeConfiguration : IEntityTypeConfiguration<AmountType>
    {
        public void Configure(EntityTypeBuilder<AmountType> builder)
        {
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
        }
    }
}
