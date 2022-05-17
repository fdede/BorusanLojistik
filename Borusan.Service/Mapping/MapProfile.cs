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

            CreateMap<Order, ResponseOrderWithStatusDto>()
                .ForMember(
                    dest => dest.OrderStatusDto,
                    opt => opt.MapFrom(src => src.OrderStatus))
                .ForMember(
                    dest => dest.AmountTypeDto,
                    opt => opt.MapFrom(src => src.AmountType))
                .ForMember(
                    dest => dest.WeightUnitDto,
                    opt => opt.MapFrom(src => src.WeightUnit))
                .ForMember(
                    dest => dest.MaterialDto,
                    opt => opt.MapFrom(src => src.Material));

            CreateMap<OrderStatus, OrderStatusDto>().ReverseMap();
            CreateMap<AmountType, AmountTypeDto>().ReverseMap();
            CreateMap<WeightUnit, WeightUnitDto>().ReverseMap();
            
        }
    }
}
