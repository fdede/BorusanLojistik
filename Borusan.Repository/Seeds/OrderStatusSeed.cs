using Borusan.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Borusan.Repository.Seeds
{
    internal class OrderStatusSeed : IEntityTypeConfiguration<OrderStatus>
    {
        public void Configure(EntityTypeBuilder<OrderStatus> builder)
        {
            builder.HasData(
                new OrderStatus { Id = 1, CreatedDate = DateTime.Now, Name = "Sipariş Alındı" },
                new OrderStatus { Id = 2, CreatedDate = DateTime.Now, Name = "Yola Çıktı" },
                new OrderStatus { Id = 3, CreatedDate = DateTime.Now, Name = "Dağıtım Merkezinde" },
                new OrderStatus { Id = 4, CreatedDate = DateTime.Now, Name = "Dağıtıma Çıktı" },
                new OrderStatus { Id = 5, CreatedDate = DateTime.Now, Name = "Teslim Edildi" },
                new OrderStatus { Id = 6, CreatedDate = DateTime.Now, Name = "Teslim Edilemedi" });
        }
    }
}
