namespace Ordering.Application.orders.Queries.GetOrders;

public record GetOrdersQuery(PaginationRequest PaginagionRequest)
    : IQuery<GetOrdersResult>;

public record GetOrdersResult(PaginatedResult<OrderDto> Orders);