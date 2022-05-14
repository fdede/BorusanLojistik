using Borusan.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Borusan.Repository.Seeds
{
    internal class MaterialSeed : IEntityTypeConfiguration<Material>
    {
        public void Configure(EntityTypeBuilder<Material> builder)
        {
            builder.HasData(
                new Material { Id = 1, CreatedDate = DateTime.Now, Name = "Monitör" },
                new Material { Id = 2, CreatedDate = DateTime.Now, Name = "Klavye" },
                new Material { Id = 3, CreatedDate = DateTime.Now, Name = "Mouse" });
        }
    }
}
