using FluentValidation;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.ValidationRules.FluentValidation
{
   public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.CompanyName).NotEmpty().MinimumLength(3);
            
        }
    }
}
