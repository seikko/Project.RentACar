using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Project.BLL.Abstract;
using Project.BLL.Concrete;
using Project.CORE.Utilities.Interceptors;
using Project.DAL.Abstract;
using Project.DAL.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BLL.DependencyResolver.Autofac
{
   public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance();
            builder.RegisterType<EfCarDal>().As<ICarDal>();

            builder.RegisterType<BrandManager>().As<IBrandService>().SingleInstance();
            builder.RegisterType<EfBrandDal>().As<IBrandDal>();

            builder.RegisterType<ColorManager>().As<IColorService>().SingleInstance();
            builder.RegisterType<EfColorDal>().As<IColorDal>();

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<CustomerManager>().As<ICustomerService>().SingleInstance();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>();

            builder.RegisterType<RentalManager>().As<IRentalService>().SingleInstance();
            builder.RegisterType<EfRentalDal>().As<IRentalDal>();



            builder.RegisterType<CarImageManager>().As<ICarImageService>().SingleInstance();
            builder.RegisterType<EfCarImageDal>().As<ICarImageDal>();




            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces().EnableInterfaceInterceptors(new ProxyGenerationOptions()
            {

                Selector = new AspectInterceptorSelector()
            }).SingleInstance();


        }
    }
}
