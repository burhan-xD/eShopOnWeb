using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorAdmin.Helpers;
using BlazorAdmin.Services;
using BlazorShared.Interfaces;
using BlazorShared.Models;

namespace BlazorAdmin.Pages.OrderPage;

public partial class Orders: BlazorComponent
{
    [Microsoft.AspNetCore.Components.Inject]
    public IOrderService OrderService { get; set; }

    private List<OrderModel> orderList = new List<OrderModel>();

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            orderList = await OrderService.List();
            CallRequestRefresh();
        }

        await base.OnAfterRenderAsync(firstRender);
    }
}
