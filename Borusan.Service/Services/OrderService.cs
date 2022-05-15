using AutoMapper;
using Borusan.Core.DTOs;
using Borusan.Core.Models;
using Borusan.Core.Repositories;
using Borusan.Core.Services;
using Borusan.Core.UnitOfWorks;

namespace Borusan.Service.Services
{
    public class OrderService : Service<Order>, IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<Material> _materialRepository;
        private readonly IMapper _mapper;

        public OrderService(IUnitOfWork unitOfWork, IGenericRepository<Order> repository, IOrderRepository orderRepository, IGenericRepository<Material> materialRepository, IMapper mapper) : base(unitOfWork, repository)
        {
            _orderRepository = orderRepository;
            _unitOfWork = unitOfWork;
            _materialRepository = materialRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<ResponseOrderDto>> AddAsyncWithMaterial(CreateOrderDto createOrderDto)
        {
            bool hasDublicateOrder = await _orderRepository.AnyAsync(x => x.CustomerOrderNo == createOrderDto.CustomerOrderNo);
            if (hasDublicateOrder)
            {
                return CustomResponseDto<ResponseOrderDto>.Fail(400, false, "Aynı müşteri için tekrar eden müşteri sipariş numarasına izin verilmez");
            }

            Order order = _mapper.Map<Order>(createOrderDto);

            bool hasMaterial = await _materialRepository.AnyAsync(x => x.Id == order.Material.Id);
            if (hasMaterial)
            {
                order.MaterialId = order.Material.Id;
                order.Material = null;
            }

            order.OrderStatusId = 1;
            order.UpdatedDate = DateTime.Now;

            await _orderRepository.AddAsyncWithMaterial(order);
            await _unitOfWork.CommitAsync();
            return CustomResponseDto<ResponseOrderDto>.Success(201, true, _mapper.Map<ResponseOrderDto>(order));

        }

        public async Task<CustomResponseDto<List<ResponseOrderDto>>> AddRangeAsyncWithMaterial(CreateOrderListDto createOrderListDto)
        {
            List<Order> orderList = new List<Order>();

            foreach (CreateOrderDto orderDto in createOrderListDto.OrderPackage)
            {
                bool hasDublicateOrder = await _orderRepository.AnyAsync(x => x.CustomerOrderNo == orderDto.CustomerOrderNo);
                
                if (hasDublicateOrder)
                    return CustomResponseDto<List<ResponseOrderDto>>.Fail(400, false, "Aynı müşteri için tekrar eden müşteri sipariş numarasına izin verilmez");

                Order order = _mapper.Map<Order>(orderDto);

                bool hasMaterial = await _materialRepository.AnyAsync(x => x.Id == order.Material.Id);
                if (hasMaterial)
                {
                    order.MaterialId = order.Material.Id;
                    order.Material = null;
                }

                order.OrderStatusId = 1;
                order.UpdatedDate = DateTime.Now;
                orderList.Add(order);
            }

            await _orderRepository.AddRangeAsyncWithMaterial(orderList);
            await _unitOfWork.CommitAsync();
            return CustomResponseDto<List<ResponseOrderDto>>.Success(201, true, _mapper.Map<List<ResponseOrderDto>>(orderList));


        }

        public async Task<CustomResponseDto<List<ResponseOrderWithStatusDto>>> GetAllOrdersWithStatus()
        {
            var orders = await _orderRepository.GetAllOrdersWithStatus();
            var ordersDtos = _mapper.Map<List<ResponseOrderWithStatusDto>>(orders);
            return CustomResponseDto<List<ResponseOrderWithStatusDto>>.Success(200, true, ordersDtos);
        }

        public async Task<CustomResponseDto<ResponseOrderWithStatusDto>> GetOrderWithStatusByCustomerOrderNo(string customerOrderNo)
        {
            var order = await _orderRepository.GetOrderWithStatusByCustomerOrderNo(customerOrderNo);
            var orderDto = _mapper.Map<ResponseOrderWithStatusDto>(order);
            return CustomResponseDto<ResponseOrderWithStatusDto>.Success(200, true, orderDto);
        }
    }
}
