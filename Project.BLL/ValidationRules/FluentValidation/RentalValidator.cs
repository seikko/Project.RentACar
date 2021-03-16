using FluentValidation;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.ValidationRules.FluentValidation
{
   public class RentalValidator:AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            
        }
    }
}
