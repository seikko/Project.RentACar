using FluentValidation;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.ValidationRules.FluentValidation
{
   public class ColorValidator:AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(x => x.ColorName).NotEmpty();
            RuleFor(x => x.ColorName).MinimumLength(3);
        }
    }
}
