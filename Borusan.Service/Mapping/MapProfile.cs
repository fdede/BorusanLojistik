using AutoMapper;
using Borusan.Core.DTOs;
using Borusan.Core.Models;

namespace Borusan.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<CreateOrderDto, Order>().ForMember(
                dest => dest.Material,
                opt => opt.MapFrom(src => src.MaterialDto));

            CreateMap<Order, ResponseOrderDto>();
            CreateMap<MaterialDto, Material>().ReverseMap();

            CreateMap<Order, ResponseOrderWithStatusDto>().ForMember(
                dest => dest.OrderStatusDto,
                opt => opt.MapFrom(src => src.OrderStatus));

            CreateMap<OrderStatus, OrderStatusDto>().ReverseMap();

            
        }
    }
}
