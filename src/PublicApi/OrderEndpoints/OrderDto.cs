using System;
using System.Collections.Generic;
using Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate;

namespace Microsoft.eShopWeb.PublicApi.OrderEndpoints;

public class OrderDto
{
    public string BuyerId { get; private set; }
    public DateTimeOffset OrderDate { get; private set; }
    public Address ShipToAddress { get; private set; }
    public OrderStatus Status { get; private set; }
    public List<OrderItemDto> OrderItems { get; set; }
}
