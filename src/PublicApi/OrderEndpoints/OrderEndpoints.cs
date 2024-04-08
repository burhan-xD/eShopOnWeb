using AutoMapper;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Routing;
using Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate;
using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using Microsoft.eShopWeb.PublicApi.CatalogBrandEndpoints;
using MinimalApi.Endpoint;
using Microsoft.eShopWeb.PublicApi.OrderEndpoints;
using System.Linq;
namespace PublicApi.OrderEndpoints;

public class OrderEndpoints : IEndpoint<IResult, IRepository<Order>>
{
    private readonly IMapper _mapper;

    public OrderEndpoints(IMapper mapper)
    {
        _mapper = mapper;
    }

    public void AddRoute(IEndpointRouteBuilder app)
    {
        app.MapGet("api/all-orders",
            async (IRepository<Order> orderRepository) =>
            {
                return await HandleAsync(orderRepository);
            })
           .Produces<ListOrderResponse>()
           .WithTags("OrderEndpoints");
    }

    public async Task<IResult> HandleAsync(IRepository<Order> orderRepository)
    {
        var response = new ListOrderResponse();

        var items = await orderRepository.ListAsync();

        response.Orders.AddRange(items.Select(_mapper.Map<OrderDto>));
        //response.Orders.AddRange(items.Select(order => _mapper.Map<OrderDto>(order)));

        return Results.Ok(response);
    }
}
