using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            // AddNewItemToTable(carManager);
            // DeleteToTables(carManager, brandManager, colorManager);
            // UpdateToCarTable(carManager);

            // UserAdd(customerManager, userManager);

            //CarDetails(carManager);

            //  CustomerDetails(customerManager);

           // RentalAdd(rentalManager);

            
            var rentableCars = rentalManager.GetRentableCars(Convert.ToDateTime("26/03/2021 15:00:00"));
           // var rentableCars = rentalManager.GetAll();

            if (rentableCars.Success==true)
            {
                Console.WriteLine(rentableCars.Message);
                foreach (var cant in rentableCars.Data)
                {
                    Console.WriteLine(cant.CarId);
                }

            }
            else
            {
                Console.WriteLine(rentableCars.Message);
                foreach (var can in rentableCars.Data)
                {
                    Console.WriteLine(can.CarId);
                }
            }


        }

        private static void RentalAdd(RentalManager rentalManager)
        {
            var result = rentalManager.Add(new Rental
            {
                CarId = 5,
                CustomerId = 5,               
                RentDate =   DateTime.Parse("23/03/2021 15:00:00"),
                ReturnDate = DateTime.Parse("23/03/2021 15:00:00")

            });
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CustomerDetails(CustomerManager customerManager)
        {
            var result = customerManager.GetCustomerDetails();
            if (result.Success == true)
            {
                foreach (var c in result.Data)
                {
                    Console.WriteLine(c.CustomerId + " / " + c.FirstName + " / " + c.LastName + " / " + c.CompanyName + " / " + c.EMail + " / " + c.Password);

                }
                Console.WriteLine("----------");
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarDetails(CarManager carManager)
        {
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + " " + car.CarName + " " + car.Description + " " + car.ColorName + " - " + car.ModelYear + " - " + car.DailyPrice);

                }
                Console.WriteLine("----------");
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void UserAdd(CustomerManager customerManager, UserManager userManager)
        {
            var resultUser = userManager.Add(new User
            {
                FirstName = "Ahmet",
                LastName = "Çelebi",
                EMail = "ahmetcelebi@gmail.com",
                Password = "123456789"
            });

            var resultCustomer = customerManager.Add(new Customer
            {
                CustomerId = 2,
                CompanyName = "Ahmet Holding"
            });

            if (resultUser.Success && resultCustomer.Success == true)
            {
                Console.WriteLine(resultUser.Message + " " + resultCustomer.Message);
            }
            else
            {
                Console.WriteLine(resultUser.Message + " " + resultCustomer.Message);
            }
        }


        private static void AddNewItemToTable(CarManager carManager)
        {
            var result = carManager.Add(new Car
            {
                BrandId = 7,
                ColorId = 7,
                CarName = "C",
                ModelYear = "2021",
                DailyPrice = 250,
                Description = "1.5 Elegance CVT"

            });
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }


            //brandManager.Add(new Brand
            //{
            //    BrandId = 7,
            //    BrandName = "Honda"

            //});

            //colorManager.Add(new Color
            //{
            //    ColorId = 7,
            //    ColorName = "Pembe"
            //});
        }        

        private static void UpdateToCarTable(CarManager carManager)
        {
            carManager.Update(new Car
            {
                CarId = 8,
                CarName = "A3",
                BrandId = 5,
                ColorId = 5,
                ModelYear = "2021",
                DailyPrice = 299,
                Description = "Sedan 1.0 FSI"

            }); ;
        }

        private static void DeleteToTables(CarManager carManager, BrandManager brandManager, ColorManager colorManager)
        {
            carManager.Delete(new Car { CarId = 7 });
            brandManager.Delete(new Brand { BrandId = 7 });
            colorManager.Delete(new Color { ColorId = 7 });
        }


    }
}
