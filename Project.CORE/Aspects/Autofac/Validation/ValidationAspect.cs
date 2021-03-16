using Castle.DynamicProxy;
using FluentValidation;
using Project.CORE.CrossCuttingConcerns.Validation;
using Project.CORE.Utilities.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.CORE.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception 
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            //Defensive coding 
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu bir doğrulama sınıfı degildir.");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {

            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities)
            { 
                ValidationTool.Validate(validator, entity);
            }
        }
      

    }
}
