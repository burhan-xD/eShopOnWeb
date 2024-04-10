using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BlazorShared.Attributes;

namespace BlazorShared.Models;

[Endpoint(Name = "all-orders")]
public class OrderModel
{
    public string BuyerId { get; set; }
    public DateTimeOffset OrderDate { get; set; }
    //public List<OrderItemModel> OrderItemModels { get; set; }
    public string Status { get; set; }
    public decimal TotalPrice { get; set; }
}
