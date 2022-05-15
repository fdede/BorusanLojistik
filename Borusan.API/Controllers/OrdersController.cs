using AutoMapper;
using Borusan.Core.DTOs;
using Borusan.Core.Models;
using Borusan.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Borusan.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : CustomBaseController
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<IActionResult> Save(CreateOrderDto createOrderDto)
        {
            return CreateActionResult(await _orderService.AddAsyncWithMaterial(createOrderDto));
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddRangeWithMaterial(CreateOrderListDto createOrderListDto)
        {
            return CreateActionResult(await _orderService.AddRangeAsyncWithMaterial(createOrderListDto));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllOrdersWithStatus()
        {
            return CreateActionResult(await _orderService.GetAllOrdersWithStatus());
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetOrderWithStatusByCustomerOrderNo(string customerOrderNo)
        {
            return CreateActionResult(await _orderService.GetOrderWithStatusByCustomerOrderNo(customerOrderNo));
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateStatus(UpdateStatusDto updateStatusDto)
        {
            return CreateActionResult(await _orderService.UpdateStatus(updateStatusDto));
        }

    }
}
