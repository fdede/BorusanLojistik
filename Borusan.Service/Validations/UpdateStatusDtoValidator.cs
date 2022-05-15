using Borusan.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borusan.Service.Validations
{
    public class UpdateStatusDtoValidator : AbstractValidator<UpdateStatusDto>
    {
        public UpdateStatusDtoValidator()
        {
            RuleFor(x => x.CustomerOrderNo).NotEmpty().WithMessage("{PropertyName} is required").NotNull().WithMessage("{PropertyName} is required");
            RuleFor(x => x.OrderStatusId).InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater than 0");
        }
    }
}
