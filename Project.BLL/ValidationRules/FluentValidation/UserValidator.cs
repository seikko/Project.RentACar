using FluentValidation;
using Project.ENTITIES.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.ValidationRules.FluentValidation
{
  public   class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().MinimumLength(4);
            RuleFor(x => x.LastName).NotEmpty().MinimumLength(2);
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Password).NotEmpty().MinimumLength(6).MaximumLength(8).WithMessage("Lütfen 6 ile 8 karakter arasında parola giriniz");
           
        }
    }
}
