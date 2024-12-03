namespace Ordering.Application.orders.Commands.UpdateOrder;

public record UpdateOrderCommand(OrderDto Order)
    : ICommand<UpdateOrderResult>;

public record UpdateOrderResult(bool IsSuccess);

public class UpdateOrderCommandValidator : AbstractValidator<UpdateOrderCommand>
{
    public UpdateOrderCommandValidator()
    {
        RuleFor(x => x.Order.Id).NotEmpty().WithMessage("Id is requried");
        RuleFor(x => x.Order.OrderName).NotEmpty().WithMessage("Name is requried");
        RuleFor(x => x.Order.CustomerId).NotEmpty().WithMessage("CustomerId is requried");
    }
}   