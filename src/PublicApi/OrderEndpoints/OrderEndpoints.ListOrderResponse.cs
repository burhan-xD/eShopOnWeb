﻿using System.Collections.Generic;
using System;

namespace Microsoft.eShopWeb.PublicApi.OrderEndpoints;

public class ListOrderResponse : BaseResponse
{
    public ListOrderResponse(Guid correlationId) : base(correlationId)
    {
    }

    public ListOrderResponse()
    {
    }

    public List<OrderDto> Orders { get; set; } = new List<OrderDto>();
}
