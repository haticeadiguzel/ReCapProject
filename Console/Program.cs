using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EfCarDal());

            //System.Console.WriteLine("Car Name " + "Daily Price " + "Description");

            //foreach (var car in carManager.GetAll())
            //{
            //    //System.Console.WriteLine("{0}/{1}/{2}" + car.CarName + " " + car.DailyPrice + " " + car.Description);
            //    System.Console.WriteLine(car.CarName +" "+ car.DailyPrice + " " + car.Description);
            //}

            CarManager carmanager = new CarManager(new EfCarDal());
            foreach (var car in carmanager.GetCarDetails().Data)
            {
                System.Console.WriteLine(car.CarName+"  -   "+car.BrandName+"    -   "+car.ColorName+"  -    "+car.DailyPrice);
            }

        }
    }
}
