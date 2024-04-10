using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorShared.Models;
using Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate;

namespace Microsoft.eShopWeb.ApplicationCore.Interfaces;

public interface IOrderService
{
    Task CreateOrderAsync(int basketId, Address shippingAddress);

    Task<List<Order>> AllOrder();
    //Task<List<OrderModel>> GetAllModel();
}
