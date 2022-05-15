using Borusan.Core.DTOs;
using FluentValidation;

namespace Borusan.Service.Validations
{
    public class CreateOrderListDtoValidator : AbstractValidator<CreateOrderListDto>
    {
        public CreateOrderListDtoValidator()
        {
            RuleFor(x => x.OrderPackage).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");
            RuleForEach(x => x.OrderPackage).SetValidator(new CreateOrderDtoValidator());
        }
    }
}
