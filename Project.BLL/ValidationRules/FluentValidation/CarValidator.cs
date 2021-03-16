using FluentValidation;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.ValidationRules.FluentValidation
{
   public class CarValidator: AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(x => x.CarName).NotEmpty();
            RuleFor(x => x.CarName).MinimumLength(3);
            RuleFor(x => x.DailyPrice).NotEmpty();
        }
    }
    }

