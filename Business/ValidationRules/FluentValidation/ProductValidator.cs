using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.product_name).MinimumLength(2);
            RuleFor(p => p.unit_price).NotEmpty();
            RuleFor(p => p.product_name).Must(StartWidthA);
        }

        private bool StartWidthA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}

