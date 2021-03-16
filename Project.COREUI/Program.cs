using Project.BLL.Concrete;
using Project.DAL.Concrete.EntityFramework;
using Project.ENTITIES.Concrete;
using System;

namespace Project.COREUI
{
    class Program
    {
        static void Main(string[] args)
        {
      
            //CarTest();
            //BrandTest();
            //CarDetailTest();
            //RentalTest();
            //UserTest();
            //CustomerTest();

            Console.ReadLine();
        }

        private static void CarTest()
        {


            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Update(new Car
            {
                ID = 3,
                CarName = "Serkan",
                BrandID = 1,
                ColorID = 1,
                DailyPrice = 10,
                ModelYear = 1996,
                Description = "Bu veri Test Verisidir."
            });

            
        }
        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var item in brandManager.GetByID(2).Data)
            {
                Console.WriteLine(item.BrandName);
            }
        }
        private static void CarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetCarDetail().Data)
            {
                Console.WriteLine(item.CarName);
                Console.WriteLine(item.ColorName);
                Console.WriteLine(item.Description);
            }
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            foreach (var item in rentalManager.GetAll().Data)
            {
                Console.WriteLine(item.CarID);
                Console.WriteLine(item.CustomerID);
                Console.WriteLine(item.RentDate);

            }
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User
            {
                FirstName = "Engin",
                LastName = "Demiroğ",
                Email = "deneme@deneme.com",
                Password = "123456"
            });
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //customerManager.Add(new Customer
            //{
            //    UserID = 1,
            //    CompanyName = "Kodlamaio"
            //}) ;
            foreach (var item in customerManager.GetByID(6).Data)
            {
                Console.WriteLine(item.ID);
                Console.WriteLine(item.UserID);
                Console.WriteLine(item.CompanyName);
            }


           
           
           

        }
    }
}
