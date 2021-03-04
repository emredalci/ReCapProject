using System;
using Bussiness.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Vehicles----");
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName);
                Console.WriteLine(car.DailyPrice);
                Console.WriteLine(car.ModelYear);
            }

            AddCarTest();
            UpdateCarTest();
            DeleteCarTest();
        }

        public static void AddCarTest() 
        {
            var carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 2, ColorId = 1, CarName = "BMW 316i", DailyPrice = 400, Descriptions = "Manual", ModelYear = 2019 });
            Console.WriteLine("---Vehicles---");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName);
            }
        }

        public static void UpdateCarTest() 
        {
            var carManager = new CarManager(new EfCarDal());
            carManager.Update(new Car { Id = 1005, BrandId = 2, ColorId = 1, CarName = "BMW 316_", DailyPrice = 400, Descriptions = "Manual", ModelYear = 2019 });
            Console.WriteLine("---Vehicles---");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName);
            }
        }
        public static void DeleteCarTest() 
        {
            var carManager = new CarManager(new EfCarDal());
            carManager.Delete(new Car { Id = 1005, BrandId = 2, ColorId = 1, CarName = "BMW 316_", DailyPrice = 400, Descriptions = "Manual", ModelYear = 2019 });
            Console.WriteLine("---Vehicles---");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName);
            }
        }
    }
}
