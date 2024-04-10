using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShared.Models;
public class OrderModelResponse
{
    public List<OrderModel> Orders { get; set; } = new List<OrderModel>();
}
