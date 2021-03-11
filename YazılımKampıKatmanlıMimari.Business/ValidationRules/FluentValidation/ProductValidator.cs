using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using YazılımKampıKatmanlıMimari.Entities;

namespace YazılımKampıKatmanlıMimari.Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(10);
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalıdır");

        }

        private bool StartWithA(string arg)
        {
           return  arg.StartsWith("A");
        }
    }
}
