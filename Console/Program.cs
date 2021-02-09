using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManagger = new CarManager(new InMemoryCarDal());
            foreach (var car in carManagger.GetAll())
            {
                System.Console.WriteLine(car.Description);
            }
        }
    }
}
