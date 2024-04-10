using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Threading.Tasks;
using BlazorShared.Interfaces;
using BlazorShared.Models;

namespace BlazorAdmin.Services;

public class OrderService : IOrderService
{
    private readonly HttpService _httpService;

    public OrderService(HttpService httpService)
    {
        _httpService = httpService;
    }

    public  Task<List<OrderModel>> List()
    {
        //var response = await _httpService.HttpGet<OrderModelResponse>("all-orders");
        //return response.Orders;



        var orders = new List<OrderModel>
        {
            new OrderModel
            {
                BuyerId = "2",
                OrderDate = DateTime.Now,
                TotalPrice = 555,
                Status = "Beklemede",
            },
            new OrderModel
            {
                BuyerId = "burhan@test.com",
                OrderDate = DateTime.Now,
                TotalPrice = 456,
                Status = "Kardoya Verildi",
            },
            new OrderModel
            {
                BuyerId = "22",
                OrderDate = DateTime.Now,
                TotalPrice = 1111,
                Status = "İptal Edildi",
            }
        };

        return Task.FromResult(orders);
    }
}
