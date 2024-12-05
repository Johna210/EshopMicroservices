using Ordering.Application.orders.Commands.UpdateOrder;

namespace Ordering.Api.Endpoints;

public record UpdateOrderRequest(OrderDto Order);

public record UpdateOrderResponse(bool IsSuccess);

public class UpdateOrders : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPut("/orders", async (UpdateOrderRequest request, ISender sender) =>
        {
            // Configure the mapping
            TypeAdapterConfig<UpdateOrderRequest, UpdateOrderCommand>
               .NewConfig()
               .Map(dest => dest.Order.Payment.CVV, src => src.Order.Payment.CVV);

            var command = request.Adapt<UpdateOrderCommand>();

            var result = await sender.Send(command);

            var response = result.Adapt<UpdateOrderResponse>();

            return Results.Ok(response);
        })
            .WithName("UpdateOrder")
            .Produces<UpdateOrderResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .ProducesProblem(StatusCodes.Status404NotFound)
            .WithSummary("Update an order")
            .WithDescription("Update an order in the system");
    }
}
