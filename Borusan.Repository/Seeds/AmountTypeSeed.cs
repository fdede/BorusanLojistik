using Borusan.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borusan.Repository.Seeds
{
    internal class AmountTypeSeed : IEntityTypeConfiguration<AmountType>
    {
        public void Configure(EntityTypeBuilder<AmountType> builder)
        {
            builder.HasData(
                new AmountType { Id = 1, CreatedDate = DateTime.Now, Name = "Adet" },
                new AmountType { Id = 2, CreatedDate = DateTime.Now, Name = "Koli" },
                new AmountType { Id = 3, CreatedDate = DateTime.Now, Name = "Paket" },
                new AmountType { Id = 4, CreatedDate = DateTime.Now, Name = "palet" });
        }
    }
}
