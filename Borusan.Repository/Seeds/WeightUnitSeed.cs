using Borusan.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Borusan.Repository.Seeds
{
    internal class WeightUnitSeed : IEntityTypeConfiguration<WeightUnit>
    {
        public void Configure(EntityTypeBuilder<WeightUnit> builder)
        {
            builder.HasData(
                new WeightUnit { Id = 1, CreatedDate = DateTime.Now, Name = "Kg" },
                new WeightUnit { Id = 2, CreatedDate = DateTime.Now, Name = "Ton" });
        }
    }
}
