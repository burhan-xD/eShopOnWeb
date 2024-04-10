namespace Microsoft.eShopWeb.PublicApi.OrderEndpoints;

public class OrderItemDto
{
    public decimal UnitPrice { get; private set; }
    public int Units { get; private set; }
    public decimal TotalPrice => UnitPrice * Units;
}
