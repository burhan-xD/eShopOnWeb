using AutoMapper;
using Microsoft.eShopWeb.ApplicationCore.Entities;
using Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate;
using Microsoft.eShopWeb.PublicApi.CatalogBrandEndpoints;
using Microsoft.eShopWeb.PublicApi.CatalogItemEndpoints;
using Microsoft.eShopWeb.PublicApi.CatalogTypeEndpoints;
using Microsoft.eShopWeb.PublicApi.OrderEndpoints;

namespace Microsoft.eShopWeb.PublicApi;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CatalogItem, CatalogItemDto>();
        CreateMap<CatalogType, CatalogTypeDto>()
            .ForMember(dto => dto.Name, options => options.MapFrom(src => src.Type));
        CreateMap<CatalogBrand, CatalogBrandDto>()
            .ForMember(dto => dto.Name, options => options.MapFrom(src => src.Brand));
        CreateMap<Order, OrderDto>()
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()))
            .ForMember(dest => dest.OrderItems, opt => opt.MapFrom(src => src.OrderItems));

        //CreateMap<OrderItem, OrderItemDto>()
        //    .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(src => src.UnitPrice))
        //    .ForMember(dest => dest.Units, opt => opt.MapFrom(src => src.Units))
        //    .ForMember(dest => dest.TotalPrice, opt => opt.MapFrom(src => src.UnitPrice * src.Units));
    }
}

