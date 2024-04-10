using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShared.Models;
public class OrderItemModel
{
    public decimal UnitPrice { get; private set; }
    public int Units { get; private set; }
    public decimal TotalPrice => UnitPrice * Units;
}
