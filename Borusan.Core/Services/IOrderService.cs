using Borusan.Core.DTOs;
using Borusan.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borusan.Core.Services
{
    public interface IOrderService : IService<Order>
    {
        Task<CustomResponseDto<List<ResponseOrderDto>>> AddRangeAsyncWithMaterial(CreateOrderListDto createOrderListDto);
        Task<CustomResponseDto<ResponseOrderDto>> AddAsyncWithMaterial(CreateOrderDto order);
        Task<CustomResponseDto<ResponseOrderWithStatusDto>> GetOrderWithStatusByCustomerOrderNo(string customerOrderNo);
        Task<CustomResponseDto<List<ResponseOrderWithStatusDto>>> GetAllOrdersWithStatus();
        Task<CustomResponseDto<ResponseOrderWithStatusDto>> UpdateStatus(UpdateStatusDto updateStatusDto);
    }
}
