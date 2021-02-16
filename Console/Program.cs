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
            CarManager carManager = new CarManager(new EfCarDal());

            System.Console.WriteLine("Get cars name min 2 char: ");

            System.Console.WriteLine(carManager.GetAll());


        }
    }
}
