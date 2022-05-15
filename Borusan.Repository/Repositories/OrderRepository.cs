using Borusan.Core.DTOs;
using Borusan.Core.Models;
using Borusan.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borusan.Repository.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Order> AddAsyncWithMaterial(Order order)
        {
            await _context.Orders.AddAsync(order);
            return order;
        }

        public async Task<List<Order>> AddRangeAsyncWithMaterial(List<Order> orders)
        {
            await _context.Orders.AddRangeAsync(orders);
            return orders;
        }

        public async Task<List<Order>> GetAllOrdersWithStatus()
        {
            return await _context.Orders.Include(x => x.OrderStatus).ToListAsync();
        }

        public async Task<Order> GetOrderWithStatusByCustomerOrderNo(string customerOrderNo)
        {
            return await _context.Orders.Include(x => x.OrderStatus).FirstOrDefaultAsync(x => x.CustomerOrderNo == customerOrderNo);
        }

        public void UpdateStatus(Order order)
        {
            _context.Orders.Update(order);
        }
    }
}
