namespace Ordering.Application.orders.Queries.GetOrdersByCustomer;

public record GetOrdersByCustomerQuery(Guid CustomerId)
    : IQuery<GetOrdersByCustomerResult>;

public record class GetOrdersByCustomerResult(IEnumerable<OrderDto> Orders);
