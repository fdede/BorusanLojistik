using Borusan.Core.DTOs;
using Borusan.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borusan.Core.Repositories
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<Order> AddAsyncWithMaterial(Order order);
        Task<List<Order>> AddRangeAsyncWithMaterial(List<Order> orders);
        Task<Order> GetOrderWithStatusByCustomerOrderNo(string customerOrderNo);
        Task<List<Order>> GetAllOrdersWithStatus();
    }
}
