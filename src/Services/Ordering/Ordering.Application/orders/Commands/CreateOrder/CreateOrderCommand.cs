namespace Ordering.Application.orders.Commands.CreateOrder;

public record CreateOrderCommand(OrderDto Order) 
    : ICommand<CreateOrderResult>;

public record CreateOrderResult(Guid Id);

public class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
{
    public CreateOrderCommandValidator()
    {
        RuleFor(x => x.Order.OrderName).NotEmpty().WithMessage("Name is requried");
        RuleFor(x => x.Order.CustomerId).NotEmpty().WithMessage("CustomerId is requried");
        RuleFor(x => x.Order.OrderItems).NotEmpty().WithMessage("OrderItems should not be empty");
    }
}