using FluentValidation;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.ValidationRules.FluentValidation
{
   public class BrandValidator:AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(x => x.BrandName).NotEmpty();
            RuleFor(x => x.BrandName).MinimumLength(3);
        }
    }
}
