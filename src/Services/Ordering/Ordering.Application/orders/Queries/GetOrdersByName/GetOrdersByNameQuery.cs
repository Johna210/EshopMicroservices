﻿namespace Ordering.Application.orders.Queries.GetOrdersByName;

public record GetOrdersByNameQuery(string Name) 
    : IQuery<GetOrdersByNameResult>;

public record GetOrdersByNameResult(IEnumerable<OrderDto> Orders);

